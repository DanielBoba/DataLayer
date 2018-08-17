using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BitfinexFundings",
                columns: table => new
                {
                    Key = table.Column<Guid>(nullable: false),
                    Id = table.Column<long>(nullable: false),
                    Mts = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    Rate = table.Column<double>(nullable: false),
                    Period = table.Column<double>(nullable: false),
                    Symbol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BitfinexFundings", x => x.Key);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BitfinexFundings");
        }
    }
}
