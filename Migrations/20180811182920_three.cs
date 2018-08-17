using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class three : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "BitfinexTrades");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "BitfinexTrades");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Period",
                table: "BitfinexTrades",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Rate",
                table: "BitfinexTrades",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
