using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestorVirtual.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedForgottenDbSets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    Guid = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Matches the user's GUID."),
                    UserGuid = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "The GUID of the user to whom this portfolio belongs."),
                    Balance = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false, comment: "The current balance of the portfolio, representing the amount of money available for investment."),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicates whether this portfolio is soft-deleted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Portfolios_AspNetUsers_UserGuid",
                        column: x => x.UserGuid,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This model represents the portfolio that the user creates upon starting a simulation. It will be the central hub of operations, showing the user's investment holdings, their watchlist, and their current balance.");

            migrationBuilder.CreateTable(
                name: "PortfolioStocks",
                columns: table => new
                {
                    PortfolioGuid = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "The GUID of the portfolio to which this stock belongs."),
                    StockId = table.Column<int>(type: "int", nullable: false, comment: "The ID of the stock that is watchlisted.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioStocks", x => new { x.PortfolioGuid, x.StockId });
                    table.ForeignKey(
                        name: "FK_PortfolioStocks_Portfolios_PortfolioGuid",
                        column: x => x.PortfolioGuid,
                        principalTable: "Portfolios",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PortfolioStocks_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "This is the mapping table that is used for handling a portfolio's watchlist.");

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortfolioId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "The GUID of the portfolio to which this transaction belongs."),
                    StockId = table.Column<int>(type: "int", nullable: false, comment: "The ID of the stock involved in this transaction."),
                    Shares = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false, comment: "The number of shares involved in this transaction."),
                    PricePerShare = table.Column<decimal>(type: "DECIMAL(6,2)", nullable: false, comment: "The price per share at the time of the transaction."),
                    MilestoneStep = table.Column<int>(type: "int", nullable: false, comment: "The step in the milestone sequence to which this transaction belongs."),
                    IsBuyOrder = table.Column<bool>(type: "bit", nullable: false, comment: "Indicates whether this transaction is a buy order (true) or a sell order (false).")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Portfolios_PortfolioId",
                        column: x => x.PortfolioId,
                        principalTable: "Portfolios",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Represents a transaction in the portfolio, either a buy or sell order.");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_UserGuid",
                table: "Portfolios",
                column: "UserGuid");

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioStocks_StockId",
                table: "PortfolioStocks",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PortfolioId",
                table: "Transactions",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_StockId",
                table: "Transactions",
                column: "StockId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PortfolioStocks");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Portfolios");
        }
    }
}
