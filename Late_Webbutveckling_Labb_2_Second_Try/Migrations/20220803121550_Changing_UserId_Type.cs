using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Late_Webbutveckling_Labb_2_Second_Try.Migrations
{
    public partial class Changing_UserId_Type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_users_UserId",
                table: "courses");

            migrationBuilder.DropIndex(
                name: "IX_courses_UserId",
                table: "courses");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_courses_UserId1",
                table: "courses",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_users_UserId1",
                table: "courses",
                column: "UserId1",
                principalTable: "users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_users_UserId1",
                table: "courses");

            migrationBuilder.DropIndex(
                name: "IX_courses_UserId1",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "courses");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_courses_UserId",
                table: "courses",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_users_UserId",
                table: "courses",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id");
        }
    }
}
