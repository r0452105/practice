using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CyclingAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cyclist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstimateWeight = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RY = table.Column<int>(type: "int", nullable: false),
                    MO = table.Column<int>(type: "int", nullable: false),
                    DO = table.Column<int>(type: "int", nullable: false),
                    CO = table.Column<int>(type: "int", nullable: false),
                    TT = table.Column<int>(type: "int", nullable: false),
                    PR = table.Column<int>(type: "int", nullable: false),
                    SP = table.Column<int>(type: "int", nullable: false),
                    ACC = table.Column<int>(type: "int", nullable: false),
                    END = table.Column<int>(type: "int", nullable: false),
                    RES = table.Column<int>(type: "int", nullable: false),
                    REC = table.Column<int>(type: "int", nullable: false),
                    HIL = table.Column<int>(type: "int", nullable: false),
                    ATT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cyclist", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cyclist",
                columns: new[] { "Id", "ACC", "ATT", "BirthDate", "CO", "DO", "END", "EstimateWeight", "FirstName", "HIL", "Height", "LastName", "MO", "Nationality", "PR", "REC", "RES", "RY", "SP", "TT" },
                values: new object[] { 1000000, 10, 10, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 10, 10, 45.0, "Aaron", 10, 1.45, "Sprangers", 10, "Belgium", 10, 10, 10, 10, 10, 10 });

            migrationBuilder.InsertData(
                table: "Cyclist",
                columns: new[] { "Id", "ACC", "ATT", "BirthDate", "CO", "DO", "END", "EstimateWeight", "FirstName", "HIL", "Height", "LastName", "MO", "Nationality", "PR", "REC", "RES", "RY", "SP", "TT" },
                values: new object[] { 1000001, 10, 10, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 10, 10, 45.0, "Kevin", 10, 1.45, "Ceusters", 10, "Belgium", 10, 10, 10, 10, 10, 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cyclist");
        }
    }
}
