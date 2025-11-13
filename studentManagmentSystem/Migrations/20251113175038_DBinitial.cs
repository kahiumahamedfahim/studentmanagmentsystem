using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studentManagmentSystem.Migrations
{
    /// <inheritdoc />
    public partial class DBinitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Students_StudentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Students_StudentId1",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Students_StudentId2",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_StudentId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_StudentId1",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_StudentId2",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "StudentId1",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "StudentId2",
                table: "Courses");

            migrationBuilder.CreateTable(
                name: "CourseStudent",
                columns: table => new
                {
                    AllCoursesCourseId = table.Column<int>(type: "int", nullable: false),
                    StudentsStudentId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.AllCoursesCourseId, x.StudentsStudentId });
                    table.ForeignKey(
                        name: "FK_CourseStudent_Courses_AllCoursesCourseId",
                        column: x => x.AllCoursesCourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudent_Students_StudentsStudentId",
                        column: x => x.StudentsStudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MajorCourse",
                columns: table => new
                {
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MajorCourse", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_MajorCourse_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MajorCourse_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MinorCourse",
                columns: table => new
                {
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MinorCourse", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_MinorCourse_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MinorCourse_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_StudentsStudentId",
                table: "CourseStudent",
                column: "StudentsStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_MajorCourse_CourseId",
                table: "MajorCourse",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_MinorCourse_CourseId",
                table: "MinorCourse",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudent");

            migrationBuilder.DropTable(
                name: "MajorCourse");

            migrationBuilder.DropTable(
                name: "MinorCourse");

            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentId1",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentId2",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StudentId",
                table: "Courses",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StudentId1",
                table: "Courses",
                column: "StudentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StudentId2",
                table: "Courses",
                column: "StudentId2");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Students_StudentId",
                table: "Courses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Students_StudentId1",
                table: "Courses",
                column: "StudentId1",
                principalTable: "Students",
                principalColumn: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Students_StudentId2",
                table: "Courses",
                column: "StudentId2",
                principalTable: "Students",
                principalColumn: "StudentId");
        }
    }
}
