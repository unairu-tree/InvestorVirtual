using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestorVirtual.Data.Migrations
{
    /// <inheritdoc />
    public partial class IDontEvenKnowWhatIAmDoingAtThisPoint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "DaySimulations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "DaySimulations",
                type: "DECIMAL(7,2)",
                nullable: false,
                defaultValue: 0m,
                comment: "The starting cash balance of $10,000 modified through simulation days");

            migrationBuilder.UpdateData(
                table: "DaySimulations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Balance",
                value: 10.000m);
        }
    }
}
