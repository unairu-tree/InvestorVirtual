using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InvestorVirtual.Data.Migrations
{
    /// <inheritdoc />
    public partial class LearningTermSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LearningTerms",
                columns: new[] { "Id", "Category", "Description", "TermName" },
                values: new object[,]
                {
                    { 1, 1, "Anything of value that a person or company owns. It can be physical (like cash, land, or machinery) or financial (like stocks and bonds) that can be converted into money or used to generate future earnings (selling with a profit or through dividends).", "Asset" },
                    { 2, 1, "Money or debts that a person or company owes to others. Examples include bank loans, unpaid bills, mortgages, or credit card balances.", "Liability" },
                    { 3, 1, "The actual net worth of an owner's share in a business or asset. It is calculated simply as what you own (Assets) minus what you owe (Liabilities).", "Equity" },
                    { 4, 4, "A quick valuation check that compares a company's stock price to how much profit it actually makes per share. It shows whether a stock is cheap or expensive relative to its real earnings. Example: If a stock trades at $100 and earns $5 per share each year, its P/E ratio is 20 ($100 / $5). This means investors are paying $20 for every $1 of annual profit the company makes", "Price-to-Earnings (P/E) Ratio" },
                    { 5, 4, "The total market value of a company. It is calculated by multiplying the price of a single stock share by the total number of shares that exist. It shows how big a company really is (Small-Cap vs. Large-Cap).", "Market Capitalization (Market Cap)" },
                    { 6, 2, "A simple score from 0 to 100 that shows if a stock has been bought or sold too quickly. A score above 70 usually means a stock is overbought (overpriced), while below 30 means it is oversold (bargain price).", "Relative Strength Index (RSI)" },
                    { 7, 2, "A line on a chart that shows the average closing price of a stock over a specific number of days (like 20, 50, or 200 days). It smoothes out daily price bounces to show the overall trend direction. Investors usually have 20, 50 and 200 day SMAs active at the same time, which they use to analyze market trends.", "Simple Moving Average (SMA)" },
                    { 8, 2, "Similar to an SMA, but it gives more weight to the most recent prices. This makes it react faster to fresh news or sudden price changes than a standard moving average.", "Exponential Moving Average (EMA)" },
                    { 9, 3, "A visual price chart shape that looks like three peaks (a tall middle \"head\" between two lower \"shoulders\"). It usually signals that an upward price trend is running out of steam and may turn downward.", "Head and Shoulders" },
                    { 10, 3, "A chart pattern that looks like the letter \"W\". It happens when a stock price drops to a low point twice, bounces off that level both times, and signals a potential price recovery. It usually bounces back due to funds stepping in to buy on a \"discount\" price after panic sell-offs, because they still have faith in the asset, otherwise they would let it crash through their foundations", "Double Bottom" },
                    { 11, 1, "A market period where prices are steadily rising and general investor sentiment is optimistic. It is named after a bull, which attacks by thrusting its horns upward.", "Bullish Market (Bull Market)" },
                    { 12, 1, "A market period where stock prices fall significantly (typically 20% or more from recent highs) and market sentiment is pessimistic. It is named after a bear, which attacks by swiping its paws downward.", "Bearish Market (Bear Market)" },
                    { 13, 4, "A company's net profit divided by its total number of stock shares. It shows how much profit a company generates for every single share of stock issued. Example: If a company makes $10 million in profit and has 5 million issued shares to investors, its EPS is $2 (10 million / 5 million).", "EPS (Earnings Per Share)" },
                    { 14, 4, "A P/E ratio that compares current share price against real, proven earnings over the past 12 months (last 4 quarters). It reflects actual historical performance rather than future promises.", "Trailing P/E" },
                    { 15, 4, "A P/E ratio that compares current share price against estimated future earnings projected by financial analysts for the next 12 months. It shows what investors expect the company to earn ahead. This is one of the stones that tips a stock's cost if the company fails to meet these expectations during their quarterly \"Earnings Call\"", "Forward P/E" },
                    { 16, 1, "A 12-month accounting period used by companies for financial reporting and tax purposes. It does not always align with the calendar year (Jan 1–Dec 31); for instance, Apple's fiscal year ends in late September.", "Fiscal Year" },
                    { 17, 1, "A 3-month chunk of a company's fiscal year (Q1, Q2, Q3, Q4). Public companies publish official financial updates and earnings reports at the end of every fiscal quarter usually called \"Earnings Calls\".", "Fiscal Quarter" },
                    { 18, 1, "A cash payout that a profitable company shares directly with its stockholders, usually paid out quarterly. It rewards long-term investors simply for owning shares in the business.", "Dividend" },
                    { 19, 1, "A percentage that shows how much a company pays out in dividends each year relative to its current stock price. It measures the cash return you get on your investment, similar to an interest rate at a bank. Example: If a company's stock price is $100 and it pays $4.00 in total dividends per year, its Dividend Yield is 4% ($4 / $100). If the stock price rises to $200 while the dividend stays $4, the yield drops to 2%. If you want to calculate this cash yield yourself you would have to calculate what is x% out of the company's current share price and multiply that by the total amount of shares you own.", "Dividend Yield" },
                    { 20, 1, "The cutoff date that determines who gets paid the upcoming dividend. You must buy the stock before this date to receive the dividend. If you buy on or after the ex-dividend date, the dividend payment goes to the previous owner.", "Ex-Dividend Date (Ex-Date)" },
                    { 21, 1, "A portion of a single equity share, allowing you to buy stock based on a specific dollar amount rather than the full share price. Depending on the brokerage or trading platform, fractional shares may either pay a proportional dividend (e.g., holding 0.5 shares yields half the dividend payout) or no dividend at all if the platform limits payouts strictly to whole shares.", "Fractional Shares" },
                    { 22, 1, "A digital service or app that connects investors to financial exchanges to buy and sell stocks, ETFs, and other assets. Platforms differ in features, such as supporting fractional share execution, commission structures, and specific dividend distribution policies.", "Investment Platform (Brokerage)" },
                    { 23, 1, "The total number of shares bought and sold for a specific stock during a set period (usually one trading day). Higher volume means high activity and liquidity, making it easier to enter or exit a position without moving the price drastically.", "Trading Volume (Volume)" },
                    { 24, 1, "Trading activity where orders are executed at or above the seller's asking price. High buying volume shows strong market demand and typically pushes the stock price upward.", "Buying Volume (Buy-Side Volume)" },
                    { 25, 1, "Trading activity where sellers are eager to exit and fulfill orders at or below the buyer's bidding price. High selling volume indicates panic, profit-taking, or heavy supply, pushing the price downward.", "Selling Volume (Sell-Side Volume)" },
                    { 26, 1, "A rapid stock price change (e.g., 10%–20%) occurring on low trading volume, typically caused by sudden news, major geopolitical events, or quarterly earnings calls. When unexpected news drops, institutional algorithms and market makers instantly update their buy/sell quotes to a new level. The price shifts dramatically without needing massive retail trading volume simply because no buyers or sellers are willing to execute orders at the previous price.", "Low-Volume Sentiment Shift (Institutional Repricing)" },
                    { 27, 3, "A bullish pattern that occurs when a short-term moving average (like the 50-day SMA, or faster 20-day SMA) crosses above a longer-term moving average (like the 200-day or 50-day SMA). It signals that recent buying momentum is accelerating upward and a sustained bull trend may be starting.", "Golden Cross" },
                    { 28, 3, "A bearish pattern that occurs when a short-term moving average (like the 50-day SMA, or faster 20-day SMA) drops below a longer-term moving average (like the 200-day or 50-day SMA). It signals that downward selling pressure is taking over and further price decline may follow.", "Death Cross" },
                    { 29, 3, "A slang term for a stock whose price is plummeting rapidly with no signs of stopping. Trying to buy it during the steep drop is called \"catching a falling knife\"—a high-risk attempt to guess the bottom that often leads to quick losses before the price stabilizes.", "Falling Knife" },
                    { 30, 3, "A temporary, short-lived price recovery during a severe, long-term downtrend. It gives a false impression that the stock has bottomed out, but the price quickly resumes falling once the brief surge in buying runs out of steam.", "Dead Cat Bounce" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "LearningTerms",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
