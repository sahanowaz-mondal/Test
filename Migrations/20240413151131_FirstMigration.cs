using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace SerialKeyGenerate.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "srialkey",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    serialkey = table.Column<string>(type: "longtext", nullable: true),
                    StartDate = table.Column<DateTime>(name: "Start_Date", type: "datetime(6)", nullable: false),
                    EndDate = table.Column<DateTime>(name: "End_Date", type: "datetime(6)", nullable: false),
                    Matchserialkey = table.Column<string>(type: "longtext", nullable: true),
                    licncekeys = table.Column<string>(type: "longtext", nullable: true),
                    dyscunt = table.Column<int>(type: "int", nullable: false),
                    addi1 = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    addi2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_srialkey", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "srialkey");
        }
    }
}
