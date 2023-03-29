using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvideenceObvytelstva2.Migrations
{
    /// <inheritdoc />
    public partial class final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ulice = table.Column<string>(type: "TEXT", nullable: false),
                    cisloPopisne = table.Column<int>(type: "INTEGER", nullable: false),
                    psc = table.Column<int>(type: "INTEGER", nullable: false),
                    Obec = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skolas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NazevSkoly = table.Column<string>(type: "TEXT", nullable: false),
                    Poznamka = table.Column<string>(type: "TEXT", nullable: false),
                    AdresaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skolas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skolas_Adresses_AdresaId",
                        column: x => x.AdresaId,
                        principalTable: "Adresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zamestnanis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NazevFirmy = table.Column<string>(type: "TEXT", nullable: false),
                    Poznamka = table.Column<string>(type: "TEXT", nullable: false),
                    AdresaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zamestnanis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zamestnanis_Adresses_AdresaId",
                        column: x => x.AdresaId,
                        principalTable: "Adresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OborStudia = table.Column<string>(type: "TEXT", nullable: false),
                    Rocnik = table.Column<int>(type: "INTEGER", nullable: false),
                    SkolaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Skolas_SkolaId",
                        column: x => x.SkolaId,
                        principalTable: "Skolas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zamestnanecs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nastup = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Oddeleni = table.Column<string>(type: "TEXT", nullable: false),
                    ZamestnaniId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zamestnanecs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zamestnanecs_Zamestnanis_ZamestnaniId",
                        column: x => x.ZamestnaniId,
                        principalTable: "Zamestnanis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Osobas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KrestniJmeno = table.Column<string>(type: "TEXT", nullable: false),
                    Prijmeni = table.Column<string>(type: "TEXT", nullable: false),
                    Titul = table.Column<string>(type: "TEXT", nullable: false),
                    Vek = table.Column<int>(type: "INTEGER", nullable: false),
                    AddressId = table.Column<int>(type: "INTEGER", nullable: false),
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    ZamestnanecId = table.Column<int>(type: "INTEGER", nullable: false),
                    StudentId1 = table.Column<int>(type: "INTEGER", nullable: true),
                    ZamestnanecId1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osobas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Osobas_Adresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Adresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Osobas_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Osobas_Students_StudentId1",
                        column: x => x.StudentId1,
                        principalTable: "Students",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Osobas_Zamestnanecs_ZamestnanecId",
                        column: x => x.ZamestnanecId,
                        principalTable: "Zamestnanecs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Osobas_Zamestnanecs_ZamestnanecId1",
                        column: x => x.ZamestnanecId1,
                        principalTable: "Zamestnanecs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Osobas_AddressId",
                table: "Osobas",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Osobas_StudentId",
                table: "Osobas",
                column: "StudentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Osobas_StudentId1",
                table: "Osobas",
                column: "StudentId1",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Osobas_ZamestnanecId",
                table: "Osobas",
                column: "ZamestnanecId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Osobas_ZamestnanecId1",
                table: "Osobas",
                column: "ZamestnanecId1",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skolas_AdresaId",
                table: "Skolas",
                column: "AdresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SkolaId",
                table: "Students",
                column: "SkolaId");

            migrationBuilder.CreateIndex(
                name: "IX_Zamestnanecs_ZamestnaniId",
                table: "Zamestnanecs",
                column: "ZamestnaniId");

            migrationBuilder.CreateIndex(
                name: "IX_Zamestnanis_AdresaId",
                table: "Zamestnanis",
                column: "AdresaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Osobas");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Zamestnanecs");

            migrationBuilder.DropTable(
                name: "Skolas");

            migrationBuilder.DropTable(
                name: "Zamestnanis");

            migrationBuilder.DropTable(
                name: "Adresses");
        }
    }
}
