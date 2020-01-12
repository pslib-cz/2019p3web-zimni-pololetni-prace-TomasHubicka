using Microsoft.EntityFrameworkCore.Migrations;

namespace Gamebook.Migrations
{
    public partial class idk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_linkText",
                table: "linkText");

            migrationBuilder.RenameTable(
                name: "linkText",
                newName: "linkTexts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_linkTexts",
                table: "linkTexts",
                column: "Id");

            migrationBuilder.InsertData(
                table: "linkTexts",
                columns: new[] { "Id", "LinkNumber", "RoomId", "text" },
                values: new object[,]
                {
                    { 29, 1, 14, "Continue into the basement." },
                    { 30, 1, 15, "Continue into the basement." },
                    { 31, 1, 16, "Continue into the basement." },
                    { 32, 1, 17, "Continue into the basement." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_linkTexts",
                table: "linkTexts");

            migrationBuilder.DeleteData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.RenameTable(
                name: "linkTexts",
                newName: "linkText");

            migrationBuilder.AddPrimaryKey(
                name: "PK_linkText",
                table: "linkText",
                column: "Id");
        }
    }
}
