using Microsoft.EntityFrameworkCore.Migrations;

namespace TipBot.Migrations
{
    public partial class AddUsedToAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Used",
                table: "UnusedAddresses",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Used",
                table: "UnusedAddresses");
        }
    }
}
