using Microsoft.EntityFrameworkCore.Migrations;

namespace UpSchool_CQRS_DesignPatterns.Migrations
{
    public partial class storage_area_added_to_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Storage",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Storage",
                table: "Products");
        }
    }
}
