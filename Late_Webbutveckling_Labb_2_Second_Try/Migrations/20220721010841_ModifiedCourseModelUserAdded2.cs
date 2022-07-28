using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Late_Webbutveckling_Labb_2_Second_Try.Migrations
{
    public partial class ModifiedCourseModelUserAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_users_UserId",
                table: "courses");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_users_UserId",
                table: "courses",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_users_UserId",
                table: "courses");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_courses_users_UserId",
                table: "courses",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
