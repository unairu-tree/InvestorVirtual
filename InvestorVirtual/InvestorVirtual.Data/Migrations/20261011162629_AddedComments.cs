using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestorVirtual.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Stocks",
                comment: "This model represents the stocks each user can interact with");

            migrationBuilder.AlterTable(
                name: "Prices",
                comment: "This model represents the price movements and buy/sell volume of every stock on a daily basis");

            migrationBuilder.AlterTable(
                name: "News",
                comment: "This model represents the news articles that are written for each of the stocks to keep track of what is happening in the stock market");

            migrationBuilder.AlterTable(
                name: "LearningTerms",
                comment: "This model is independent from the others and represents the financial terms with descriptions about them for the users to read and learn");

            migrationBuilder.AlterTable(
                name: "Events",
                comment: "This model represents the main hub that links the price, news, analysis together and then links to the stock");

            migrationBuilder.AlterTable(
                name: "Analyses",
                comment: "This model represents the analysis surrounding each stock based on the events that happen in the world");

            migrationBuilder.AlterColumn<string>(
                name: "Ticker",
                table: "Stocks",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                comment: "This is the company ticker (a short, 3-4 letter, all caps name specific to stocks trading)",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Stocks",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                comment: "This is a short description for the company and their business",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "Sector",
                table: "Stocks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "This is the sector the company operates in",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LogoPath",
                table: "Stocks",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "This is the path to the company logo",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Stocks",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "This is the company name",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<long>(
                name: "SellVolume",
                table: "Prices",
                type: "bigint",
                nullable: false,
                comment: "This is how much shares of a stock were sold in a specific time span (e.g. a day, a week, a month,)",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<decimal>(
                name: "PriceValue",
                table: "Prices",
                type: "DECIMAL(6,2)",
                nullable: false,
                comment: "This is the current price for 1 share of a stock",
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(6,2)");

            migrationBuilder.AlterColumn<long>(
                name: "BuyVolume",
                table: "Prices",
                type: "bigint",
                nullable: false,
                comment: "This is how much shares of a stock were bought in a specific time span (e.g. a day, a week, a month,)",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "Source",
                table: "News",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "This is the source or sources of the article",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Headline",
                table: "News",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                comment: "This is the news article's headline",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                comment: "This is the main story surrounding the stock",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TermName",
                table: "LearningTerms",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "This is what the name of the term is",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "LearningTerms",
                type: "nvarchar(max)",
                nullable: false,
                comment: "This is the description of the term",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Category",
                table: "LearningTerms",
                type: "int",
                nullable: false,
                comment: "This will show the category of the term",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Events",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "This will hold the title and will cover important aspects of a company's events",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "StockId",
                table: "Events",
                type: "int",
                nullable: false,
                comment: "This will reference the stock associated with the event",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PriceId",
                table: "Events",
                type: "int",
                nullable: false,
                comment: "This will reference the price associated with the event",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "NewsId",
                table: "Events",
                type: "int",
                nullable: false,
                comment: "This will reference the news associated with the event",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Events",
                type: "datetime2",
                nullable: false,
                comment: "This will record the date of the event",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "AnalysisId",
                table: "Events",
                type: "int",
                nullable: false,
                comment: "This will reference the analysis associated with the event",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "TargetPrice",
                table: "Analyses",
                type: "DECIMAL(6,2)",
                nullable: false,
                comment: "This is the price expected by analysts to be reached by the stock",
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(6,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Reasoning",
                table: "Analyses",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                comment: "This is the explanation the analysts give to explain their rating",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Analyses",
                type: "int",
                nullable: false,
                comment: "This represents the rating from 'Strong-Sell' to 'Strong-Buy' given by the analysts",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AnalystCount",
                table: "Analyses",
                type: "int",
                nullable: false,
                comment: "This is the count of analysts that have taken part in the analysis of the stock",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "A quick valuation check that compares a company's stock price to how much profit it actually makes per share. It shows whether a stock is cheap or expensive relative to its real earnings. Example: If a stock trades at $100 and earns $5 per share each year, its P/E ratio is 20 ($100 / $5). This means investors are paying $20 for every $1 of annual profit the company makes.");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "A chart pattern that looks like the letter \"W\". It happens when a stock price drops to a low point twice, bounces off that level both times, and signals a potential price recovery. It usually bounces back due to funds stepping in to buy on a \"discount\" price after panic sell-offs, because they still have faith in the asset, otherwise they would let it crash through their foundations.");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "A P/E ratio that compares current share price against estimated future earnings projected by financial analysts for the next 12 months. It shows what investors expect the company to earn ahead. This is one of the stones that tips a stock's cost if the company fails to meet these expectations during their quarterly \"Earnings Call\".");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Stocks",
                oldComment: "This model represents the stocks each user can interact with");

            migrationBuilder.AlterTable(
                name: "Prices",
                oldComment: "This model represents the price movements and buy/sell volume of every stock on a daily basis");

            migrationBuilder.AlterTable(
                name: "News",
                oldComment: "This model represents the news articles that are written for each of the stocks to keep track of what is happening in the stock market");

            migrationBuilder.AlterTable(
                name: "LearningTerms",
                oldComment: "This model is independent from the others and represents the financial terms with descriptions about them for the users to read and learn");

            migrationBuilder.AlterTable(
                name: "Events",
                oldComment: "This model represents the main hub that links the price, news, analysis together and then links to the stock");

            migrationBuilder.AlterTable(
                name: "Analyses",
                oldComment: "This model represents the analysis surrounding each stock based on the events that happen in the world");

            migrationBuilder.AlterColumn<string>(
                name: "Ticker",
                table: "Stocks",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldComment: "This is the company ticker (a short, 3-4 letter, all caps name specific to stocks trading)");

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Stocks",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldComment: "This is a short description for the company and their business");

            migrationBuilder.AlterColumn<string>(
                name: "Sector",
                table: "Stocks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "This is the sector the company operates in");

            migrationBuilder.AlterColumn<string>(
                name: "LogoPath",
                table: "Stocks",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "This is the path to the company logo");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Stocks",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "This is the company name");

            migrationBuilder.AlterColumn<long>(
                name: "SellVolume",
                table: "Prices",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "This is how much shares of a stock were sold in a specific time span (e.g. a day, a week, a month,)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PriceValue",
                table: "Prices",
                type: "DECIMAL(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(6,2)",
                oldComment: "This is the current price for 1 share of a stock");

            migrationBuilder.AlterColumn<long>(
                name: "BuyVolume",
                table: "Prices",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldComment: "This is how much shares of a stock were bought in a specific time span (e.g. a day, a week, a month,)");

            migrationBuilder.AlterColumn<string>(
                name: "Source",
                table: "News",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "This is the source or sources of the article");

            migrationBuilder.AlterColumn<string>(
                name: "Headline",
                table: "News",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldComment: "This is the news article's headline");

            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "This is the main story surrounding the stock");

            migrationBuilder.AlterColumn<string>(
                name: "TermName",
                table: "LearningTerms",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "This is what the name of the term is");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "LearningTerms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "This is the description of the term");

            migrationBuilder.AlterColumn<int>(
                name: "Category",
                table: "LearningTerms",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "This will show the category of the term");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Events",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "This will hold the title and will cover important aspects of a company's events");

            migrationBuilder.AlterColumn<int>(
                name: "StockId",
                table: "Events",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "This will reference the stock associated with the event");

            migrationBuilder.AlterColumn<int>(
                name: "PriceId",
                table: "Events",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "This will reference the price associated with the event");

            migrationBuilder.AlterColumn<int>(
                name: "NewsId",
                table: "Events",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "This will reference the news associated with the event");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Events",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "This will record the date of the event");

            migrationBuilder.AlterColumn<int>(
                name: "AnalysisId",
                table: "Events",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "This will reference the analysis associated with the event");

            migrationBuilder.AlterColumn<decimal>(
                name: "TargetPrice",
                table: "Analyses",
                type: "DECIMAL(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(6,2)",
                oldComment: "This is the price expected by analysts to be reached by the stock");

            migrationBuilder.AlterColumn<string>(
                name: "Reasoning",
                table: "Analyses",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldComment: "This is the explanation the analysts give to explain their rating");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Analyses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "This represents the rating from 'Strong-Sell' to 'Strong-Buy' given by the analysts");

            migrationBuilder.AlterColumn<int>(
                name: "AnalystCount",
                table: "Analyses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "This is the count of analysts that have taken part in the analysis of the stock");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "A quick valuation check that compares a company's stock price to how much profit it actually makes per share. It shows whether a stock is cheap or expensive relative to its real earnings. Example: If a stock trades at $100 and earns $5 per share each year, its P/E ratio is 20 ($100 / $5). This means investors are paying $20 for every $1 of annual profit the company makes");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "A chart pattern that looks like the letter \"W\". It happens when a stock price drops to a low point twice, bounces off that level both times, and signals a potential price recovery. It usually bounces back due to funds stepping in to buy on a \"discount\" price after panic sell-offs, because they still have faith in the asset, otherwise they would let it crash through their foundations");

            migrationBuilder.UpdateData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "A P/E ratio that compares current share price against estimated future earnings projected by financial analysts for the next 12 months. It shows what investors expect the company to earn ahead. This is one of the stones that tips a stock's cost if the company fails to meet these expectations during their quarterly \"Earnings Call\"");
        }
    }
}
