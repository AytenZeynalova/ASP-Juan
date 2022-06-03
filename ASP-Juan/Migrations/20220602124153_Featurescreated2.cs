using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_Juan.Migrations
{
    public partial class Featurescreated2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Backgroundcolor",
                table: "Features",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Backgroundcolor",
                table: "Features");
        }
    }
}
