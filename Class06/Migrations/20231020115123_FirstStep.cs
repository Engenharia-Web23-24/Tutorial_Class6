using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Class06.Migrations
{
    /// <inheritdoc />
    public partial class FirstStep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "class",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        name = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_class", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "student",
            //    columns: table => new
            //    {
            //        number = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        classId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_student", x => x.number);
            //        table.ForeignKey(
            //            name: "FK_student_class_classId",
            //            column: x => x.classId,
            //            principalTable: "class",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_student_classId",
            //    table: "student",
            //    column: "classId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "student");

            //migrationBuilder.DropTable(
            //    name: "class");
        }
    }
}
