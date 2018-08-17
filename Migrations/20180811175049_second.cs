using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BitfinexTrades",
                columns: table => new
                {
                    Key = table.Column<Guid>(nullable: false),
                    Id = table.Column<long>(nullable: false),
                    Mts = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Rate = table.Column<double>(nullable: false),
                    Period = table.Column<double>(nullable: false),
                    Pair = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BitfinexTrades", x => x.Key);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BitfinexTrades");
        }
    }
}
