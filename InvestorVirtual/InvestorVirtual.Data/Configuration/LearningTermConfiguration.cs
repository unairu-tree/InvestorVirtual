namespace InvestorVirtual.Data.Configuration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Models;
using Models.Enums;

public class LearningTermConfiguration : IEntityTypeConfiguration<LearningTerm>
{
    public static readonly IEnumerable<LearningTerm> LearningTerms = new List<LearningTerm>
    {
        new() {
            Id = 1,
            Slug = "asset",
            TermName = "Asset",
            Description = "Anything of value that a person or company owns. It can be physical (like cash, land, or machinery) or financial (like stocks and bonds) that can be converted into money or used to generate future earnings (selling with a profit or through dividends).",
            Category = TermCategory.General
        },
        new() {
            Id = 2,
            Slug = "liability",
            TermName = "Liability",
            Description = "Money or debts that a person or company owes to others. Examples include bank loans, unpaid bills, mortgages, or credit card balances.",
            Category = TermCategory.General
        },
        new() {
            Id = 3,
            Slug = "equity",
            TermName = "Equity",
            Description = "The actual net worth of an owner's share in a business or asset. It is calculated simply as what you own (Assets) minus what you owe (Liabilities).",
            Category = TermCategory.General
        },
        new() {
            Id = 4,
            Slug = "pe-ratio",
            TermName = "Price-to-Earnings (P/E) Ratio",
            Description = "A quick valuation check that compares a company's stock price to how much profit it actually makes per share. It shows whether a stock is cheap or expensive relative to its real earnings. Example: If a stock trades at $100 and earns $5 per share each year, its P/E ratio is 20 ($100 / $5). This means investors are paying $20 for every $1 of annual profit the company makes.",
            Category = TermCategory.FundamentalAnalysis
        },
        new() {
            Id = 5,
            Slug = "market-cap",
            TermName = "Market Capitalization (Market Cap)",
            Description = "The total market value of a company. It is calculated by multiplying the price of a single stock share by the total number of shares that exist. It shows how big a company really is (Small-Cap vs. Large-Cap).",
            Category = TermCategory.FundamentalAnalysis
        },
        new() {
            Id = 6,
            Slug = "rsi",
            TermName = "Relative Strength Index (RSI)",
            Description = "A simple score from 0 to 100 that shows if a stock has been bought or sold too quickly. A score above 70 usually means a stock is overbought (overpriced), while below 30 means it is oversold (bargain price).",
            Category = TermCategory.TechnicalIndicator
        },
        new() {
            Id = 7,
            Slug = "sma",
            TermName = "Simple Moving Average (SMA)",
            Description = "A line on a chart that shows the average closing price of a stock over a specific number of days (like 20, 50, or 200 days). It smoothes out daily price bounces to show the overall trend direction. Investors usually have 20, 50 and 200 day SMAs active at the same time, which they use to analyze market trends.",
            Category = TermCategory.TechnicalIndicator
        },
        new() {
            Id = 8,
            Slug = "ema",
            TermName = "Exponential Moving Average (EMA)",
            Description = "Similar to an SMA, but it gives more weight to the most recent prices. This makes it react faster to fresh news or sudden price changes than a standard moving average.",
            Category = TermCategory.TechnicalIndicator
        },
        new() {
            Id = 9,
            Slug = "head-and-shoulders",
            TermName = "Head and Shoulders",
            Description = "A visual price chart shape that looks like three peaks (a tall middle \"head\" between two lower \"shoulders\"). It usually signals that an upward price trend is running out of steam and may turn downward.",
            Category = TermCategory.ChartPattern
        },
        new() {
            Id = 10,
            Slug = "double-bottom",
            TermName = "Double Bottom",
            Description = "A chart pattern that looks like the letter \"W\". It happens when a stock price drops to a low point twice, bounces off that level both times, and signals a potential price recovery. It usually bounces back due to funds stepping in to buy on a \"discount\" price after panic sell-offs, because they still have faith in the asset, otherwise they would let it crash through their foundations.",
            Category = TermCategory.ChartPattern
        },
        new() {
            Id = 11,
            Slug = "bull-market",
            TermName = "Bullish Market (Bull Market)",
            Description = "A market period where prices are steadily rising and general investor sentiment is optimistic. It is named after a bull, which attacks by thrusting its horns upward.",
            Category = TermCategory.General
        },
        new() {
            Id = 12,
            Slug = "bear-market",
            TermName = "Bearish Market (Bear Market)",
            Description = "A market period where stock prices fall significantly (typically 20% or more from recent highs) and market sentiment is pessimistic. It is named after a bear, which attacks by swiping its paws downward.",
            Category = TermCategory.General
        },
        new() {
            Id = 13,
            Slug = "eps",
            TermName = "EPS (Earnings Per Share)",
            Description = "A company's net profit divided by its total number of stock shares. It shows how much profit a company generates for every single share of stock issued. Example: If a company makes $10 million in profit and has 5 million issued shares to investors, its EPS is $2 (10 million / 5 million).",
            Category = TermCategory.FundamentalAnalysis
        },
        new() {
            Id = 14,
            Slug = "trailing-pe",
            TermName = "Trailing P/E",
            Description = "A P/E ratio that compares current share price against real, proven earnings over the past 12 months (last 4 quarters). It reflects actual historical performance rather than future promises.",
            Category = TermCategory.FundamentalAnalysis
        },
        new() {
            Id = 15,
            Slug = "forward-pe",
            TermName = "Forward P/E",
            Description = "A P/E ratio that compares current share price against estimated future earnings projected by financial analysts for the next 12 months. It shows what investors expect the company to earn ahead. This is one of the stones that tips a stock's cost if the company fails to meet these expectations during their quarterly \"Earnings Call\".",
            Category = TermCategory.FundamentalAnalysis
        },
        new() {
            Id = 16,
            Slug = "fiscal-year",
            TermName = "Fiscal Year",
            Description = "A 12-month accounting period used by companies for financial reporting and tax purposes. It does not always align with the calendar year (Jan 1–Dec 31); for instance, Apple's fiscal year ends in late September.",
            Category = TermCategory.General
        },
        new() {
            Id = 17,
            Slug = "fiscal-quarter",
            TermName = "Fiscal Quarter",
            Description = "A 3-month chunk of a company's fiscal year (Q1, Q2, Q3, Q4). Public companies publish official financial updates and earnings reports at the end of every fiscal quarter usually called \"Earnings Calls\".",
            Category = TermCategory.General
        },
        new() {
            Id = 18,
            Slug = "dividend",
            TermName = "Dividend",
            Description = "A cash payout that a profitable company shares directly with its stockholders, usually paid out quarterly. It rewards long-term investors simply for owning shares in the business.",
            Category = TermCategory.General
        },
        new() {
            Id = 19,
            Slug = "dividend-yield",
            TermName = "Dividend Yield",
            Description = "A percentage that shows how much a company pays out in dividends each year relative to its current stock price. It measures the cash return you get on your investment, similar to an interest rate at a bank. Example: If a company's stock price is $100 and it pays $4.00 in total dividends per year, its Dividend Yield is 4% ($4 / $100). If the stock price rises to $200 while the dividend stays $4, the yield drops to 2%. If you want to calculate this cash yield yourself you would have to calculate what is x% out of the company's current share price and multiply that by the total amount of shares you own.",
            Category = TermCategory.General
        },
        new() {
            Id = 20,
            Slug = "ex-date",
            TermName = "Ex-Dividend Date (Ex-Date)",
            Description = "The cutoff date that determines who gets paid the upcoming dividend. You must buy the stock before this date to receive the dividend. If you buy on or after the ex-dividend date, the dividend payment goes to the previous owner.",
            Category = TermCategory.General
        },
        new() {
            Id = 21,
            Slug = "fractional-shares",
            TermName = "Fractional Shares",
            Description = "A portion of a single equity share, allowing you to buy stock based on a specific dollar amount rather than the full share price. Depending on the brokerage or trading platform, fractional shares may either pay a proportional dividend (e.g., holding 0.5 shares yields half the dividend payout) or no dividend at all if the platform limits payouts strictly to whole shares.",
            Category = TermCategory.General
        },
        new() {
            Id = 22,
            Slug = "brokerage",
            TermName = "Investment Platform (Brokerage)",
            Description = "A digital service or app that connects investors to financial exchanges to buy and sell stocks, ETFs, and other assets. Platforms differ in features, such as supporting fractional share execution, commission structures, and specific dividend distribution policies.",
            Category = TermCategory.General
        },
        new() {
            Id = 23,
            Slug = "trading-volume",
            TermName = "Trading Volume (Volume)",
            Description = "The total number of shares bought and sold for a specific stock during a set period (usually one trading day). Higher volume means high activity and liquidity, making it easier to enter or exit a position without moving the price drastically.",
            Category = TermCategory.General
        },
        new() {
            Id = 24,
            Slug = "buying-volume",
            TermName = "Buying Volume (Buy-Side Volume)",
            Description = "Trading activity where orders are executed at or above the seller's asking price. High buying volume shows strong market demand and typically pushes the stock price upward.",
            Category = TermCategory.General
        },
        new() {
            Id = 25,
            Slug = "selling-volume",
            TermName = "Selling Volume (Sell-Side Volume)",
            Description = "Trading activity where sellers are eager to exit and fulfill orders at or below the buyer's bidding price. High selling volume indicates panic, profit-taking, or heavy supply, pushing the price downward.",
            Category = TermCategory.General
        },
        new() {
            Id = 26,
            Slug = "low-volume-sentiment-shift",
            TermName = "Low-Volume Sentiment Shift (Institutional Repricing)",
            Description = "A rapid stock price change (e.g., 10%–20%) occurring on low trading volume, typically caused by sudden news, major geopolitical events, or quarterly earnings calls. When unexpected news drops, institutional algorithms and market makers instantly update their buy/sell quotes to a new level. The price shifts dramatically without needing massive retail trading volume simply because no buyers or sellers are willing to execute orders at the previous price.",
            Category = TermCategory.General
        },
        new() {
            Id = 27,
            Slug = "golden-cross",
            TermName = "Golden Cross",
            Description = "A bullish pattern that occurs when a short-term moving average (like the 50-day SMA, or faster 20-day SMA) crosses above a longer-term moving average (like the 200-day or 50-day SMA). It signals that recent buying momentum is accelerating upward and a sustained bull trend may be starting.",
            Category = TermCategory.ChartPattern
        },
        new() {
            Id = 28,
            Slug = "death-cross",
            TermName = "Death Cross",
            Description = "A bearish pattern that occurs when a short-term moving average (like the 50-day SMA, or faster 20-day SMA) drops below a longer-term moving average (like the 200-day or 50-day SMA). It signals that downward selling pressure is taking over and further price decline may follow.",
            Category = TermCategory.ChartPattern
        },
        new() {
            Id = 29,
            Slug = "falling-knife",
            TermName = "Falling Knife",
            Description = "A slang term for a stock whose price is plummeting rapidly with no signs of stopping. Trying to buy it during the steep drop is called \"catching a falling knife\"—a high-risk attempt to guess the bottom that often leads to quick losses before the price stabilizes.",
            Category = TermCategory.ChartPattern
        },
        new() {
            Id = 30,
            Slug = "dead-cat-bounce",
            TermName = "Dead Cat Bounce",
            Description = "A temporary, short-lived price recovery during a severe, long-term downtrend. It gives a false impression that the stock has bottomed out, but the price quickly resumes falling once the brief surge in buying runs out of steam.",
            Category = TermCategory.ChartPattern
        },
    };

    public void Configure(EntityTypeBuilder<LearningTerm> builder)
    {
        builder.HasData(LearningTerms);
    }
}