using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.Database.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    DoctorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ImageSmall = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialty = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Experience = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Education = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Area = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Certifications = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShortPresentation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    IsHomePage = table.Column<bool>(type: "bit", nullable: true),
                    WhoAdded = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Admin"),
                    WhenAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WhoModified = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Admin"),
                    WhenModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WhoRemoved = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Admin"),
                    WhenRemoved = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.DoctorId);
                });

            migrationBuilder.CreateTable(
                name: "Page",
                columns: table => new
                {
                    PageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageAnchorText = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PageLink = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PageLinkPosition = table.Column<int>(type: "int", nullable: false),
                    WhoAdded = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Admin"),
                    WhenAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WhoModified = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Admin"),
                    WhenModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WhoRemoved = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Admin"),
                    WhenRemoved = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Page", x => x.PageId);
                });

            migrationBuilder.CreateTable(
                name: "Parameter",
                columns: table => new
                {
                    ParameterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    WhoAdded = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Admin"),
                    WhenAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WhoModified = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Admin"),
                    WhenModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WhoRemoved = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Admin"),
                    WhenRemoved = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parameter", x => x.ParameterId);
                });

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "DoctorId", "Area", "Biography", "Certifications", "Education", "Experience", "Image", "ImageSmall", "IsHomePage", "Name", "Position", "ShortPresentation", "Specialty", "WhenAdded", "WhenModified", "WhenRemoved" },
                values: new object[,]
                {
                    { 1, "London, USA", "<p>Biography</p>", "USA Board Neurological Surgery", "University of California, USA", "15+ Years", "detail-dr1.jpg", "t1.jpg", true, "Dr. Micheal Anderson", 1, "Short presentation", "Heart Surgery", new DateTime(2022, 9, 27, 3, 31, 10, 690, DateTimeKind.Local).AddTicks(9154), null, null },
                    { 2, "London, USA", "<p>Biography</p>", "USA Board Neurological Surgery", "University of California, USA", "15+ Years", "detail-dr1.jpg", "t2.jpg", true, "Dr. Micheal Anderson", 1, "Short presentation", "Heart Surgery", new DateTime(2022, 9, 27, 3, 31, 10, 690, DateTimeKind.Local).AddTicks(9188), null, null },
                    { 3, "London, USA", "<p>Biography</p>", "USA Board Neurological Surgery", "University of California, USA", "15+ Years", "detail-dr1.jpg", "t3.jpg", true, "Dr. Micheal Anderson", 1, "Short presentation", "Heart Surgery", new DateTime(2022, 9, 27, 3, 31, 10, 690, DateTimeKind.Local).AddTicks(9192), null, null },
                    { 4, "London, USA", "<p>Biography</p>", "USA Board Neurological Surgery", "University of California, USA", "15+ Years", "detail-dr1.jpg", "t4.jpg", true, "Dr. Micheal Anderson", 1, "Short presentation", "Heart Surgery", new DateTime(2022, 9, 27, 3, 31, 10, 690, DateTimeKind.Local).AddTicks(9196), null, null }
                });

            migrationBuilder.InsertData(
                table: "Page",
                columns: new[] { "PageId", "PageAnchorText", "PageLink", "PageLinkPosition", "WhenAdded", "WhenModified", "WhenRemoved" },
                values: new object[,]
                {
                    { 1, "Home Page", "/Home", 1, new DateTime(2022, 9, 27, 3, 31, 10, 690, DateTimeKind.Local).AddTicks(5998), null, null },
                    { 2, "Services", "/Services", 2, new DateTime(2022, 9, 27, 3, 31, 10, 690, DateTimeKind.Local).AddTicks(6044), null, null },
                    { 3, "Doctors", "/Doctors", 3, new DateTime(2022, 9, 27, 3, 31, 10, 690, DateTimeKind.Local).AddTicks(6046), null, null },
                    { 4, "Appointments", "/Appointments", 4, new DateTime(2022, 9, 27, 3, 31, 10, 690, DateTimeKind.Local).AddTicks(6048), null, null }
                });

            migrationBuilder.InsertData(
                table: "Parameter",
                columns: new[] { "ParameterId", "Code", "Content", "Name", "WhenAdded", "WhenModified", "WhenRemoved" },
                values: new object[,]
                {
                    { 1, "footerNote", "Nullam erat ametam arcu lorme pharetra id risus act sectetur ipsum luctus est ullam erat ametam arcu lorme pharetra id us act sectetur ipsum luctus est.", "Footer note", new DateTime(2022, 9, 27, 3, 31, 10, 691, DateTimeKind.Local).AddTicks(2036), null, null },
                    { 2, "footerAddress", "134, Cornish Building, Some <br />Near by area, New York, <br />USA - 34556", "Footer address", new DateTime(2022, 9, 27, 3, 31, 10, 691, DateTimeKind.Local).AddTicks(2060), null, null },
                    { 3, "hours", "8.00 AM - 6:00PM", "Open hours", new DateTime(2022, 9, 27, 3, 31, 10, 691, DateTimeKind.Local).AddTicks(2064), null, null },
                    { 4, "phone", "1 (888) 123 4567", "Phone", new DateTime(2022, 9, 27, 3, 31, 10, 691, DateTimeKind.Local).AddTicks(2066), null, null },
                    { 5, "email", "info@Medika.com", "Email", new DateTime(2022, 9, 27, 3, 31, 10, 691, DateTimeKind.Local).AddTicks(2069), null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Page");

            migrationBuilder.DropTable(
                name: "Parameter");
        }
    }
}
