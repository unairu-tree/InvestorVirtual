using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestorVirtual.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedLearningTermSlugs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "LearningTerms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "This is the field that will hold the slug used for extra security and SEO");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Slug",
                value: "asset");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Slug",
                value: "liability");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Slug",
                value: "equity");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 4,
                column: "Slug",
                value: "pe-ratio");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 5,
                column: "Slug",
                value: "market-cap");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 6,
                column: "Slug",
                value: "rsi");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 7,
                column: "Slug",
                value: "sma");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 8,
                column: "Slug",
                value: "ema");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 9,
                column: "Slug",
                value: "head-and-shoulders");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 10,
                column: "Slug",
                value: "double-bottom");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 11,
                column: "Slug",
                value: "bull-market");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 12,
                column: "Slug",
                value: "bear-market");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 13,
                column: "Slug",
                value: "eps");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 14,
                column: "Slug",
                value: "trailing-pe");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 15,
                column: "Slug",
                value: "forward-pe");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 16,
                column: "Slug",
                value: "fiscal-year");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 17,
                column: "Slug",
                value: "fiscal-quarter");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 18,
                column: "Slug",
                value: "dividend");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 19,
                column: "Slug",
                value: "dividend-yield");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 20,
                column: "Slug",
                value: "ex-date");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 21,
                column: "Slug",
                value: "fractional-shares");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 22,
                column: "Slug",
                value: "brokerage");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 23,
                column: "Slug",
                value: "trading-volume");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 24,
                column: "Slug",
                value: "buying-volume");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 25,
                column: "Slug",
                value: "selling-volume");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 26,
                column: "Slug",
                value: "low-volume-sentiment-shift");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 27,
                column: "Slug",
                value: "golden-cross");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 28,
                column: "Slug",
                value: "death-cross");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 29,
                column: "Slug",
                value: "falling-knife");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 30,
                column: "Slug",
                value: "dead-cat-bounce");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "LearningTerms");
        }
    }
}
