using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NotariaDB.Database.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "usuarios",
                keyColumn: "id",
                keyValue: "1039760194");

            migrationBuilder.DeleteData(
                table: "usuarios",
                keyColumn: "id",
                keyValue: "21979476");

            migrationBuilder.DeleteData(
                table: "usuarios",
                keyColumn: "id",
                keyValue: "719912");

            migrationBuilder.DeleteData(
                table: "usuarios",
                keyColumn: "id",
                keyValue: "98509595");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "usuarios",
                columns: new[] { "id", "birth_date", "doctype_id", "expedition_date", "expedition_place", "name", "surname" },
                values: new object[,]
                {
                    { "1039760194", new DateTime(1992, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SALGAR", "ANA CRISTINA", "DÍAZ OSORIO" },
                    { "21979476", new DateTime(1970, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SALGAR", "RUTH NELLY", "OSORIO GARCÍA" },
                    { "719912", new DateTime(1942, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SALGAR", "VILEY DE JESÚS", "DÍAZ GARCÍA" },
                    { "98509595", new DateTime(1970, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SALGAR", "JAVIER ALONSO", "DÍAZ GALLEGO" }
                });
        }
    }
}
