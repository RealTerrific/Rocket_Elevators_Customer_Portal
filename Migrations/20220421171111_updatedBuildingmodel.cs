using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerPortal.Migrations
{
    public partial class updatedBuildingmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "customer_id",
                table: "Building",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "customer_id",
                table: "Building");
        }
    }
}
