using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace NotariaDB.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bloodtypes",
                columns: table => new
                {
                    bloodtype_id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.bloodtype_id);
                });

            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "doctypes",
                columns: table => new
                {
                    doctype_id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.doctype_id);
                });

            migrationBuilder.CreateTable(
                name: "mat_attaches",
                columns: table => new
                {
                    attach_id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.attach_id);
                });

            migrationBuilder.CreateTable(
                name: "medicos",
                columns: table => new
                {
                    id = table.Column<string>(maxLength: 15, nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    surname = table.Column<string>(maxLength: 50, nullable: false),
                    medic_card = table.Column<string>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "nac_attaches",
                columns: table => new
                {
                    attach_id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.attach_id);
                });

            migrationBuilder.CreateTable(
                name: "places",
                columns: table => new
                {
                    place_id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    department_id = table.Column<int>(nullable: false),
                    city_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.place_id);
                    table.ForeignKey(
                        name: "fk_places_city_id",
                        column: x => x.city_id,
                        principalTable: "cities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_places_department_id",
                        column: x => x.department_id,
                        principalTable: "departments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id = table.Column<string>(maxLength: 15, nullable: false),
                    doctype_id = table.Column<int>(nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    surname = table.Column<string>(maxLength: 50, nullable: false),
                    expedition_place = table.Column<string>(maxLength: 100, nullable: true),
                    expedition_date = table.Column<DateTime>(type: "date", nullable: true),
                    birth_date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.id);
                    table.ForeignKey(
                        name: "fk_usuarios_doctype_id",
                        column: x => x.doctype_id,
                        principalTable: "doctypes",
                        principalColumn: "doctype_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "notarios",
                columns: table => new
                {
                    user_id = table.Column<string>(maxLength: 15, nullable: false),
                    title = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.user_id);
                    table.ForeignKey(
                        name: "fk_notarios_user_id",
                        column: x => x.user_id,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "defunciones",
                columns: table => new
                {
                    serial = table.Column<string>(maxLength: 15, nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    surname = table.Column<string>(maxLength: 50, nullable: false),
                    relateduser_id = table.Column<string>(maxLength: 15, nullable: true),
                    medic_id = table.Column<string>(maxLength: 15, nullable: false),
                    place_id = table.Column<int>(nullable: false),
                    dead_date = table.Column<DateTime>(type: "date", nullable: false),
                    reg_date = table.Column<DateTime>(type: "date", nullable: false),
                    witness_id = table.Column<string>(maxLength: 15, nullable: false),
                    notary_id = table.Column<string>(maxLength: 15, nullable: false),
                    attach_description = table.Column<string>(maxLength: 75, nullable: false),
                    fileroute = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.serial);
                    table.ForeignKey(
                        name: "fk_defunciones_medic_id",
                        column: x => x.medic_id,
                        principalTable: "medicos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_defunciones_notary_id",
                        column: x => x.notary_id,
                        principalTable: "notarios",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_defunciones_places_id",
                        column: x => x.place_id,
                        principalTable: "places",
                        principalColumn: "place_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_defunciones_relateduser1_id",
                        column: x => x.relateduser_id,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_defunciones_witness1_id",
                        column: x => x.witness_id,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "matrimonios",
                columns: table => new
                {
                    serial = table.Column<string>(maxLength: 15, nullable: false),
                    name1 = table.Column<string>(maxLength: 50, nullable: false),
                    surname1 = table.Column<string>(maxLength: 50, nullable: false),
                    relateduser1_id = table.Column<string>(maxLength: 15, nullable: true),
                    name2 = table.Column<string>(maxLength: 45, nullable: false),
                    surname2 = table.Column<string>(maxLength: 50, nullable: false),
                    relateduser2_id = table.Column<string>(maxLength: 45, nullable: true),
                    place_id = table.Column<int>(nullable: false),
                    weeding_date = table.Column<DateTime>(type: "date", nullable: false),
                    reg_date = table.Column<DateTime>(type: "date", nullable: false),
                    witness_id = table.Column<string>(maxLength: 15, nullable: false),
                    notary_id = table.Column<string>(maxLength: 15, nullable: false),
                    attach_id = table.Column<int>(nullable: false),
                    attach_description = table.Column<string>(maxLength: 75, nullable: false),
                    fileroute = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.serial);
                    table.ForeignKey(
                        name: "fk_matrimonios_attach_id",
                        column: x => x.attach_id,
                        principalTable: "mat_attaches",
                        principalColumn: "attach_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_matrimonios_notary_id",
                        column: x => x.notary_id,
                        principalTable: "notarios",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_matrimonios_places_id",
                        column: x => x.place_id,
                        principalTable: "places",
                        principalColumn: "place_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_matrimonios_relateduser1_id",
                        column: x => x.relateduser1_id,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_matrimonios_relateduser2_id",
                        column: x => x.relateduser2_id,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_matrimonios_witness1_id",
                        column: x => x.witness_id,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "nacimientos",
                columns: table => new
                {
                    nuip = table.Column<string>(maxLength: 15, nullable: false),
                    serial = table.Column<string>(maxLength: 15, nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    surname1 = table.Column<string>(maxLength: 50, nullable: false),
                    surname2 = table.Column<string>(maxLength: 50, nullable: false),
                    sex = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false),
                    place_id = table.Column<int>(nullable: false),
                    bloodtype_id = table.Column<int>(nullable: false),
                    birth_hour = table.Column<TimeSpan>(type: "time", nullable: true),
                    birth_date = table.Column<DateTime>(type: "date", nullable: false),
                    reg_date = table.Column<DateTime>(type: "date", nullable: false),
                    mom_id = table.Column<string>(maxLength: 15, nullable: false),
                    dad_id = table.Column<string>(maxLength: 15, nullable: false),
                    witness_id = table.Column<string>(maxLength: 15, nullable: false),
                    relateduser_id = table.Column<string>(maxLength: 15, nullable: true),
                    notary_id = table.Column<string>(maxLength: 15, nullable: false),
                    attach_id = table.Column<int>(nullable: false),
                    attach_description = table.Column<string>(maxLength: 75, nullable: false),
                    fileroute = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.nuip);
                    table.ForeignKey(
                        name: "fk_nacimientos_attach_id",
                        column: x => x.attach_id,
                        principalTable: "nac_attaches",
                        principalColumn: "attach_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_nacimientos_bloodtype_id",
                        column: x => x.bloodtype_id,
                        principalTable: "bloodtypes",
                        principalColumn: "bloodtype_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_nacimientos_dad_id",
                        column: x => x.dad_id,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_nacimientos_mom_id",
                        column: x => x.mom_id,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_nacimientos_notary_id",
                        column: x => x.notary_id,
                        principalTable: "notarios",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_nacimientos_places_id",
                        column: x => x.place_id,
                        principalTable: "places",
                        principalColumn: "place_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_nacimientos_relateduser_id",
                        column: x => x.relateduser_id,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_nacimientos_witness1_id",
                        column: x => x.witness_id,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "fk_defunciones_medic_id_idx",
                table: "defunciones",
                column: "medic_id");

            migrationBuilder.CreateIndex(
                name: "fk_defunciones_notary_id_idx",
                table: "defunciones",
                column: "notary_id");

            migrationBuilder.CreateIndex(
                name: "fk_nacimientos_places_id_idx",
                table: "defunciones",
                column: "place_id");

            migrationBuilder.CreateIndex(
                name: "fk_nacimientos_relateduser_id_idx",
                table: "defunciones",
                column: "relateduser_id");

            migrationBuilder.CreateIndex(
                name: "fk_nacimientos_witness1_id_idx",
                table: "defunciones",
                column: "witness_id");

            migrationBuilder.CreateIndex(
                name: "fk_matrimonios_attach_id_idx",
                table: "matrimonios",
                column: "attach_id");

            migrationBuilder.CreateIndex(
                name: "fk_matrimonios_notary_id_idx",
                table: "matrimonios",
                column: "notary_id");

            migrationBuilder.CreateIndex(
                name: "fk_nacimientos_places_id_idx",
                table: "matrimonios",
                column: "place_id");

            migrationBuilder.CreateIndex(
                name: "fk_nacimientos_relateduser_id_idx",
                table: "matrimonios",
                column: "relateduser1_id");

            migrationBuilder.CreateIndex(
                name: "fk_matrimonios_relateduser2_id_idx",
                table: "matrimonios",
                column: "relateduser2_id");

            migrationBuilder.CreateIndex(
                name: "fk_nacimientos_witness1_id_idx",
                table: "matrimonios",
                column: "witness_id");

            migrationBuilder.CreateIndex(
                name: "fk_nacimientos_attach_id_idx",
                table: "nacimientos",
                column: "attach_id");

            migrationBuilder.CreateIndex(
                name: "fk_nacimientos_bloodtype_id_idx",
                table: "nacimientos",
                column: "bloodtype_id");

            migrationBuilder.CreateIndex(
                name: "fk_nacimientos_dad_id_idx",
                table: "nacimientos",
                column: "dad_id");

            migrationBuilder.CreateIndex(
                name: "fk_nacimientos_mom_id_idx",
                table: "nacimientos",
                column: "mom_id");

            migrationBuilder.CreateIndex(
                name: "fk_nacimientos_notary_id_idx",
                table: "nacimientos",
                column: "notary_id");

            migrationBuilder.CreateIndex(
                name: "fk_nacimientos_places_id_idx",
                table: "nacimientos",
                column: "place_id");

            migrationBuilder.CreateIndex(
                name: "fk_nacimientos_relateduser_id_idx",
                table: "nacimientos",
                column: "relateduser_id");

            migrationBuilder.CreateIndex(
                name: "fk_nacimientos_witness1_id_idx",
                table: "nacimientos",
                column: "witness_id");

            migrationBuilder.CreateIndex(
                name: "fk_places_city_id_idx",
                table: "places",
                column: "city_id");

            migrationBuilder.CreateIndex(
                name: "fk_places_department_id_idx",
                table: "places",
                column: "department_id");

            migrationBuilder.CreateIndex(
                name: "fk_doctypes_usuarios_idx",
                table: "usuarios",
                column: "doctype_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "defunciones");

            migrationBuilder.DropTable(
                name: "matrimonios");

            migrationBuilder.DropTable(
                name: "nacimientos");

            migrationBuilder.DropTable(
                name: "medicos");

            migrationBuilder.DropTable(
                name: "mat_attaches");

            migrationBuilder.DropTable(
                name: "nac_attaches");

            migrationBuilder.DropTable(
                name: "bloodtypes");

            migrationBuilder.DropTable(
                name: "notarios");

            migrationBuilder.DropTable(
                name: "places");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "cities");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropTable(
                name: "doctypes");
        }
    }
}
