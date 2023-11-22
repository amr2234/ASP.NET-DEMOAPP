using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CLS.DemoApp.Identity.Migrations
{
    public partial class intialidentity2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NationalNo",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NationalNo",
                table: "AspNetUsers");
        }
    }
}
