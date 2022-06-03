using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_Juan.Migrations
{
    public partial class HomeSlidersTableCreated2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "HomeSliders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "HomeSliders");
        }
    }
}
