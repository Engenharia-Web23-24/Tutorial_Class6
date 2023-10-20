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

            // Look for any student.
            if (_context.Students.Any())
            {
                return;   // DB has been seeded
            }

          
            var classes = new List<Class>();
            var students = new List<Student>();

            using (StreamReader sr = File.OpenText("Data\\StudentsList_Class06.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {

                    string[] parts = line.Split(";");

                    if (!classes.Any(x => x.Name.Equals(parts[2])))
                    {
                        classes.Add(new Class { Name = parts[2] });
                    }
                    students.Add(new Student
                    {
                        Number = Int32.Parse(parts[0]),
                        Name = parts[1],
                        Class = classes.SingleOrDefault(x => x.Name == parts[2])
                    });
                }
                _context.Classes.AddRange(classes);
                _context.Students.AddRange(students);
                _context.SaveChanges();
            }

        }
    }
}
