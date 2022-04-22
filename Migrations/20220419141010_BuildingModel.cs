using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerPortal.Migrations
{
    public partial class BuildingModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Building",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AdminName = table.Column<string>(type: "TEXT", nullable: true),
                    AdminEmail = table.Column<string>(type: "TEXT", nullable: true),
                    AdminPhone = table.Column<string>(type: "TEXT", nullable: true),
                    TechName = table.Column<string>(type: "TEXT", nullable: true),
                    TechEmail = table.Column<string>(type: "TEXT", nullable: true),
                    TechPhone = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CustomerID = table.Column<int>(type: "INTEGER", nullable: false),
                    AddressID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Building");
        }
    }
}