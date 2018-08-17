using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class quinta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Key",
                table: "BitfinexTrades",
                newName: "TradeId");

            migrationBuilder.AddColumn<Guid>(
                name: "ReadingHighRatesId",
                table: "BitfinexTrades",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ReadingHighRatesId",
                table: "BitfinexFundings",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BitfinexReadingHighRates",
                columns: table => new
                {
                    ReadingHighRatesId = table.Column<Guid>(nullable: false),
                    Open = table.Column<DateTime>(nullable: false),
                    Close = table.Column<DateTime>(nullable: false),
                    Pair = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BitfinexReadingHighRates", x => x.ReadingHighRatesId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BitfinexTrades_ReadingHighRatesId",
                table: "BitfinexTrades",
                column: "ReadingHighRatesId");

            migrationBuilder.CreateIndex(
                name: "IX_BitfinexFundings_ReadingHighRatesId",
                table: "BitfinexFundings",
                column: "ReadingHighRatesId");

            migrationBuilder.AddForeignKey(
                name: "FK_BitfinexFundings_BitfinexReadingHighRates_ReadingHighRatesId",
                table: "BitfinexFundings",
                column: "ReadingHighRatesId",
                principalTable: "BitfinexReadingHighRates",
                principalColumn: "ReadingHighRatesId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BitfinexTrades_BitfinexReadingHighRates_ReadingHighRatesId",
                table: "BitfinexTrades",
                column: "ReadingHighRatesId",
                principalTable: "BitfinexReadingHighRates",
                principalColumn: "ReadingHighRatesId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BitfinexFundings_BitfinexReadingHighRates_ReadingHighRatesId",
                table: "BitfinexFundings");

            migrationBuilder.DropForeignKey(
                name: "FK_BitfinexTrades_BitfinexReadingHighRates_ReadingHighRatesId",
                table: "BitfinexTrades");

            migrationBuilder.DropTable(
                name: "BitfinexReadingHighRates");

            migrationBuilder.DropIndex(
                name: "IX_BitfinexTrades_ReadingHighRatesId",
                table: "BitfinexTrades");

            migrationBuilder.DropIndex(
                name: "IX_BitfinexFundings_ReadingHighRatesId",
                table: "BitfinexFundings");

            migrationBuilder.DropColumn(
                name: "ReadingHighRatesId",
                table: "BitfinexTrades");

            migrationBuilder.DropColumn(
                name: "ReadingHighRatesId",
                table: "BitfinexFundings");

            migrationBuilder.RenameColumn(
                name: "TradeId",
                table: "BitfinexTrades",
                newName: "Key");
        }
    }
}
