using Microsoft.EntityFrameworkCore.Migrations;

namespace NotariaDB.Database.Migrations
{
    public partial class BloodtypesConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "bloodtypes",
                columns: new[] { "bloodtype_id", "name" },
                values: new object[,]
                {
                    { 1, "A+" },
                    { 2, "A-" },
                    { 3, "B+" },
                    { 4, "B-" },
                    { 5, "O+" },
                    { 6, "O-" },
                    { 7, "AB+" },
                    { 8, "AB-" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "bloodtypes",
                keyColumn: "bloodtype_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "bloodtypes",
                keyColumn: "bloodtype_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "bloodtypes",
                keyColumn: "bloodtype_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "bloodtypes",
                keyColumn: "bloodtype_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "bloodtypes",
                keyColumn: "bloodtype_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "bloodtypes",
                keyColumn: "bloodtype_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "bloodtypes",
                keyColumn: "bloodtype_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "bloodtypes",
                keyColumn: "bloodtype_id",
                keyValue: 8);
        }
    }
}
