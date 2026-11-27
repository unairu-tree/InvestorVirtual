using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestorVirtual.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExpandedPortfolioStockEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Shares",
                table: "Transactions",
                type: "DECIMAL(18,8)",
                nullable: false,
                comment: "The number of shares involved in this transaction.",
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)",
                oldComment: "The number of shares involved in this transaction.");

            migrationBuilder.AddColumn<bool>(
                name: "IsInWatchlist",
                table: "PortfolioStocks",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Indicates whether the stock is in the portfolio's watchlist.");

            migrationBuilder.AddColumn<decimal>(
                name: "SharesOwned",
                table: "PortfolioStocks",
                type: "DECIMAL(18,8)",
                nullable: false,
                defaultValue: 0m,
                comment: "The number of shares owned of this stock.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInWatchlist",
                table: "PortfolioStocks");

            migrationBuilder.DropColumn(
                name: "SharesOwned",
                table: "PortfolioStocks");

            migrationBuilder.AlterColumn<decimal>(
                name: "Shares",
                table: "Transactions",
                type: "DECIMAL(18,2)",
                nullable: false,
                comment: "The number of shares involved in this transaction.",
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,8)",
                oldComment: "The number of shares involved in this transaction.");
        }
    }
}
