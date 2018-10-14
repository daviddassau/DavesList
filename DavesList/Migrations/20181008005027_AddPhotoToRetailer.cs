using Microsoft.EntityFrameworkCore.Migrations;

namespace DavesList.Migrations
{
    public partial class AddPhotoToRetailer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Retailers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Retailers");
        }
    }
}
