using Class06.Models;

namespace Class06.Data
{
    public class DbInitializer
    {
        private readonly Class06Context _context;

        public DbInitializer(Class06Context context) { _context = context; }

        public void Run()
        {
            _context.Database.EnsureCreated();

            // Look for any categories.
            if (_context.Students.Any())
            {
                return;   // DB has been seeded
            }

            Dictionary<string, List<Student>> collection = new Dictionary<string, List<Student>>();

            using (StreamReader sr = File.OpenText("Data\\StudentsList_Class06.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(";"); // splits the information "number;name;class"

                    if (collection.ContainsKey(parts[2]) == false) // creates a Dictionary with course as Key...
                        collection.Add(parts[2], new List<Student>());
                    // ... and list of students as Value
                    collection[parts[2]].Add(new Student { Number = Convert.ToInt32(parts[0]), Name = parts[1] });
                }

                foreach (string _class in collection.Keys) // create Classes in Database
                {
                    _context.Classes.Add(new Class { Name = _class });
                }
                _context.SaveChanges();

                foreach (KeyValuePair<string, List<Student>> aux in collection) // create Students in Database
                {
                    foreach (Student s in aux.Value)
                    {
                        s.ClassId = _context.Classes.Single(classes => classes.Name == aux.Key).Id;
                        _context.Students.Add(s);
                    }
                }
                _context.SaveChanges();
            }


        }
    }
}
