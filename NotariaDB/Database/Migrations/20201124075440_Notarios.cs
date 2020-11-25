using Microsoft.EntityFrameworkCore.Migrations;

namespace NotariaDB.Database.Migrations
{
    public partial class Notarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "notarios",
                columns: new[] { "user_id", "title" },
                values: new object[] { "98509595", "NOTARIO ÚNICO" });

            migrationBuilder.InsertData(
                table: "notarios",
                columns: new[] { "user_id", "title" },
                values: new object[] { "21979476", "NOTARIA ENCARGADA" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "notarios",
                keyColumn: "user_id",
                keyValue: "21979476");

            migrationBuilder.DeleteData(
                table: "notarios",
                keyColumn: "user_id",
                keyValue: "98509595");
        }
    }
}
