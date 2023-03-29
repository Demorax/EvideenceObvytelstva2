using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvideenceObvytelstva2.Migrations
{
    /// <inheritdoc />
    public partial class snadFinalSNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Osobas_Students_StudentId1",
                table: "Osobas");

            migrationBuilder.DropForeignKey(
                name: "FK_Osobas_Zamestnanecs_ZamestnanecId1",
                table: "Osobas");

            migrationBuilder.DropIndex(
                name: "IX_Osobas_StudentId1",
                table: "Osobas");

            migrationBuilder.DropIndex(
                name: "IX_Osobas_ZamestnanecId1",
                table: "Osobas");

            migrationBuilder.DropColumn(
                name: "StudentId1",
                table: "Osobas");

            migrationBuilder.DropColumn(
                name: "ZamestnanecId1",
                table: "Osobas");

            migrationBuilder.AlterColumn<int>(
                name: "ZamestnanecId",
                table: "Osobas",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Osobas",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ZamestnanecId",
                table: "Osobas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Osobas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId1",
                table: "Osobas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZamestnanecId1",
                table: "Osobas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Osobas_StudentId1",
                table: "Osobas",
                column: "StudentId1",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Osobas_ZamestnanecId1",
                table: "Osobas",
                column: "ZamestnanecId1",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Osobas_Students_StudentId1",
                table: "Osobas",
                column: "StudentId1",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Osobas_Zamestnanecs_ZamestnanecId1",
                table: "Osobas",
                column: "ZamestnanecId1",
                principalTable: "Zamestnanecs",
                principalColumn: "Id");
        }
    }
}
