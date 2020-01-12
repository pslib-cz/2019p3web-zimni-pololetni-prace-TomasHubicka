using Microsoft.EntityFrameworkCore.Migrations;

namespace Gamebook.Migrations
{
    public partial class linkNumbernowstring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LinkNumber",
                table: "linkTexts",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LinkNumber",
                value: "one");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LinkNumber",
                value: "two");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LinkNumber",
                value: "three");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LinkNumber",
                value: "one");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LinkNumber",
                value: "two");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LinkNumber",
                value: "one");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 7,
                column: "LinkNumber",
                value: "two");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 8,
                column: "LinkNumber",
                value: "one");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 9,
                column: "LinkNumber",
                value: "two");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 10,
                column: "LinkNumber",
                value: "one");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 11,
                column: "LinkNumber",
                value: "two");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 12,
                column: "LinkNumber",
                value: "one");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 13,
                column: "LinkNumber",
                value: "two");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 14,
                column: "LinkNumber",
                value: "one");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 15,
                column: "LinkNumber",
                value: "two");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 16,
                column: "LinkNumber",
                value: "one");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 17,
                column: "LinkNumber",
                value: "two");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 18,
                column: "LinkNumber",
                value: "one");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 19,
                column: "LinkNumber",
                value: "two");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 20,
                column: "LinkNumber",
                value: "one");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 21,
                column: "LinkNumber",
                value: "two");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 22,
                column: "LinkNumber",
                value: "three");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 23,
                column: "LinkNumber",
                value: "one");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 24,
                column: "LinkNumber",
                value: "two");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 25,
                column: "LinkNumber",
                value: "one");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 26,
                column: "LinkNumber",
                value: "two");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 27,
                column: "LinkNumber",
                value: "one");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 28,
                column: "LinkNumber",
                value: "two");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 29,
                column: "LinkNumber",
                value: "one");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 30,
                column: "LinkNumber",
                value: "one");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 31,
                column: "LinkNumber",
                value: "one");

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 32,
                column: "LinkNumber",
                value: "one");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "LinkNumber",
                table: "linkTexts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 1,
                column: "LinkNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 2,
                column: "LinkNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 3,
                column: "LinkNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 4,
                column: "LinkNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 5,
                column: "LinkNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 6,
                column: "LinkNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 7,
                column: "LinkNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 8,
                column: "LinkNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 9,
                column: "LinkNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 10,
                column: "LinkNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 11,
                column: "LinkNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 12,
                column: "LinkNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 13,
                column: "LinkNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 14,
                column: "LinkNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 15,
                column: "LinkNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 16,
                column: "LinkNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 17,
                column: "LinkNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 18,
                column: "LinkNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 19,
                column: "LinkNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 20,
                column: "LinkNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 21,
                column: "LinkNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 22,
                column: "LinkNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 23,
                column: "LinkNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 24,
                column: "LinkNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 25,
                column: "LinkNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 26,
                column: "LinkNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 27,
                column: "LinkNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 28,
                column: "LinkNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 29,
                column: "LinkNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 30,
                column: "LinkNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 31,
                column: "LinkNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "linkTexts",
                keyColumn: "Id",
                keyValue: 32,
                column: "LinkNumber",
                value: 1);
        }
    }
}
