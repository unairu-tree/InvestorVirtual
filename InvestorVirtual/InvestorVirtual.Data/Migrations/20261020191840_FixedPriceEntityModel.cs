using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestorVirtual.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixedPriceEntityModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuyVolume",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "SellVolume",
                table: "Prices");

            migrationBuilder.AddColumn<bool>(
                name: "IsBullishVolume",
                table: "Prices",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "This is a boolean that will determine if the volume is bullish or bearish, if the volume is bullish it will be true, if it is bearish it will be false");

            migrationBuilder.AddColumn<long>(
                name: "Volume",
                table: "Prices",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                comment: "This is how much shares of a stock were bought/sold in a specific time span (e.g. a day, a week, a month,)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBullishVolume",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "Volume",
                table: "Prices");

            migrationBuilder.AddColumn<long>(
                name: "BuyVolume",
                table: "Prices",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                comment: "This is how much shares of a stock were bought in a specific time span (e.g. a day, a week, a month,)");

            migrationBuilder.AddColumn<long>(
                name: "SellVolume",
                table: "Prices",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                comment: "This is how much shares of a stock were sold in a specific time span (e.g. a day, a week, a month,)");
        }
    }
}
