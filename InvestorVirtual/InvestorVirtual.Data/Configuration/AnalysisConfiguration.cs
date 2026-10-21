namespace InvestorVirtual.Data.Configuration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Models;
using Models.Enums;

public class AnalysisConfiguration : IEntityTypeConfiguration<Analysis>
{
    public static readonly IEnumerable<Analysis> Analyses = new List<Analysis>
    {
        // Analysis configuration for Nvidia events
        new ()
        {
            Id = 1,
            Rating = Rating.StrongBuy,
            Reasoning = "Massive AI data center demand drives high revenue visibility. Analysts boost targets as Blackwell deployment schedules surpass expectations.",
            TargetPrice = 155.00m,
            AnalystCount = 42,
            EventId = 1
        },
        new ()
        {
            Id = 2,
            Rating = Rating.Buy,
            Reasoning = "Flash crash panic over low-cost AI training is overdone. Hardware moats and massive compute requirements remain essential for scaling.",
            TargetPrice = 132.00m,
            AnalystCount = 40,
            EventId = 2
        },
        new ()
        {
            Id = 3,
            Rating = Rating.StrongBuy,
            Reasoning = "Next-gen architecture reveals widened performance gaps over rivals. Power efficiency metrics prompt target upgrades.",
            TargetPrice = 168.00m,
            AnalystCount = 45,
            EventId = 3
        },
        new ()
        {
            Id = 4,
            Rating = Rating.StrongBuy,
            Reasoning = "Q1 blowout earnings crush estimates and erase cost concerns. Gross margins over 70% prove unmatched pricing power.",
            TargetPrice = 185.00m,
            AnalystCount = 44,
            EventId = 4
        },
        new ()
        {
            Id = 5,
            Rating = Rating.Buy,
            Reasoning = "Supply chain checks confirm packaging bottlenecks are easing. Long-term outlook remains firmly positive.",
            TargetPrice = 175.00m,
            AnalystCount = 41,
            EventId = 5
        },
        new ()
        {
            Id = 6,
            Rating = Rating.StrongBuy,
            Reasoning = "Record Q2 results and sovereign AI demand unlock fresh growth verticals. Price targets surge to new highs.",
            TargetPrice = 195.00m,
            AnalystCount = 46,
            EventId = 6
        },
        new ()
        {
            Id = 7,
            Rating = Rating.StrongBuy,
            Reasoning = "Multi-billion cloud contract solidifies multi-year cash flows. Ecosystem stickiness prevents client churn.",
            TargetPrice = 205.00m,
            AnalystCount = 43,
            EventId = 7
        },
        new ()
        {
            Id = 8,
            Rating = Rating.Buy,
            Reasoning = "Q3 earnings confirm stable margins and strong free cash flow. Macro noise fails to dent robust institutional demand.",
            TargetPrice = 215.00m,
            AnalystCount = 45,
            EventId = 8
        },
        new ()
        {
            Id = 9,
            Rating = Rating.Buy,
            Reasoning = "Export rule updates create minor friction but leave core order books intact. Viewed as a temporary dip.",
            TargetPrice = 210.00m,
            AnalystCount = 39,
            EventId = 9
        },
        new ()
        {
            Id = 10,
            Rating = Rating.StrongBuy,
            Reasoning = "Year-end review crowns NVDA as the backbone of the AI economy. High margins and robust expansion set to continue.",
            TargetPrice = 225.00m,
            AnalystCount = 48,
            EventId = 10
        },

        // Analysis configuration for Oracle events
        new ()
        {
            Id = 11,
            Rating = Rating.Buy,
            Reasoning = "OCI metrics show strong enterprise pull. Competitive pricing is successfully drawing major AI and database workloads away from legacy rivals.",
            TargetPrice = 145.00m,
            AnalystCount = 34,
            EventId = 11
        },
        new ()
        {
            Id = 12,
            Rating = Rating.StrongBuy,
            Reasoning = "Multi-cloud database partnership eliminates friction for enterprise clients, driving immediate interest and scaling cross-platform adoption.",
            TargetPrice = 160.00m,
            AnalystCount = 36,
            EventId = 12
        },
        new ()
        {
            Id = 13,
            Rating = Rating.StrongBuy,
            Reasoning = "Q3 RPO backlog expansion smashes expectations. Massive multi-year corporate commitments secure exceptional long-term revenue visibility.",
            TargetPrice = 180.00m,
            AnalystCount = 38,
            EventId = 13
        },
        new ()
        {
            Id = 14,
            Rating = Rating.Buy,
            Reasoning = "Native AI agents in Fusion and NetSuite accelerate SaaS growth. Legacy on-premise holdouts are converting faster than anticipated.",
            TargetPrice = 175.00m,
            AnalystCount = 35,
            EventId = 14
        },
        new ()
        {
            Id = 15,
            Rating = Rating.StrongBuy,
            Reasoning = "Blockbuster Q4 results confirm full cloud transformation. Compounding OCI consumption rates push operating margins to new highs.",
            TargetPrice = 195.00m,
            AnalystCount = 40,
            EventId = 15
        },
        new ()
        {
            Id = 16,
            Rating = Rating.Buy,
            Reasoning = "CapEx roadmap for data centers is heavily pre-backed by firm customer commitments, successfully de-risking the aggressive cloud build-out.",
            TargetPrice = 190.00m,
            AnalystCount = 37,
            EventId = 16
        },
        new ()
        {
            Id = 17,
            Rating = Rating.StrongBuy,
            Reasoning = "Q1 earnings beat highlights robust margin stability and high free cash flow conversion. Institutional sentiment remains firmly positive.",
            TargetPrice = 210.00m,
            AnalystCount = 39,
            EventId = 17
        },
        new ()
        {
            Id = 18,
            Rating = Rating.StrongBuy,
            Reasoning = "Sovereign cloud win with defense agencies creates a highly lucrative, sticky revenue vertical insulated from broader market shifts.",
            TargetPrice = 225.00m,
            AnalystCount = 42,
            EventId = 18
        },
        new ()
        {
            Id = 19,
            Rating = Rating.Buy,
            Reasoning = "Q2 top-line growth accelerates as database conversions outpace forecasts. Analysts quickly upgrade targets to match compounding tailwinds.",
            TargetPrice = 220.00m,
            AnalystCount = 38,
            EventId = 19
        },
        new ()
        {
            Id = 20,
            Rating = Rating.StrongBuy,
            Reasoning = "Year-end tech summit outlines a bold autonomous database strategy. Long-term scaling targets cement Oracle as an enterprise cloud anchor.",
            TargetPrice = 240.00m,
            AnalystCount = 44,
            EventId = 20
        },

        // Analysis configuration for Eli Lilly events
        new ()
        {
            Id = 21,
            Rating = Rating.StrongBuy,
            Reasoning = "Doubled profits and strong 2025 outlook validate obesity drug dominance. High multiples are justified by compounding demand.",
            TargetPrice = 950.00m,
            AnalystCount = 38,
            EventId = 21
        },
        new ()
        {
            Id = 22,
            Rating = Rating.Buy,
            Reasoning = "Supply chain expansion clears the path for accelerated fulfillment. Distribution bottlenecks are successfully resolving.",
            TargetPrice = 920.00m,
            AnalystCount = 35,
            EventId = 22
        },
        new ()
        {
            Id = 23,
            Rating = Rating.Hold,
            Reasoning = "Strong Q1 sales offset by cautious guidance shifts and rising R&D costs. Near-term consolidation expected before next leg up.",
            TargetPrice = 880.00m,
            AnalystCount = 36,
            EventId = 23
        },
        new ()
        {
            Id = 24,
            Rating = Rating.StrongBuy,
            Reasoning = "Orforglipron Phase III success de-risks the oral pipeline and widens Lilly's competitive moat against injectable rivals.",
            TargetPrice = 960.00m,
            AnalystCount = 40,
            EventId = 24
        },
        new ()
        {
            Id = 25,
            Rating = Rating.Buy,
            Reasoning = "FDA fast-track status accelerates commercialization timelines for key biotech candidates, keeping sentiment positive.",
            TargetPrice = 990.00m,
            AnalystCount = 37,
            EventId = 25
        },
        new ()
        {
            Id = 26,
            Rating = Rating.Hold,
            Reasoning = "Solid Q2 beat overshadowed by pricing compression and mixed trial data. Analysts trim short-term targets to account for margin friction.",
            TargetPrice = 840.00m,
            AnalystCount = 39,
            EventId = 26
        },
        new ()
        {
            Id = 27,
            Rating = Rating.Buy,
            Reasoning = "Direct-to-consumer pricing strategy defends market share. Near-term margin softness is viewed as a necessary trade-off for volume.",
            TargetPrice = 890.00m,
            AnalystCount = 34,
            EventId = 27
        },
        new ()
        {
            Id = 28,
            Rating = Rating.StrongBuy,
            Reasoning = "Q3 blowout results and guidance raise completely erase prior margin concerns. Earnings visibility remains best-in-class.",
            TargetPrice = 1050.00m,
            AnalystCount = 42,
            EventId = 28
        },
        new ()
        {
            Id = 29,
            Rating = Rating.StrongBuy,
            Reasoning = "Market cap milestone reflects unmatched growth in pharmaceutical sector. Institutional accumulation remains aggressive.",
            TargetPrice = 1100.00m,
            AnalystCount = 41,
            EventId = 29
        },
        new ()
        {
            Id = 30,
            Rating = Rating.StrongBuy,
            Reasoning = "CapEx investment secures multi-year manufacturing capacity. Long-term structural tailwinds remain exceptionally robust.",
            TargetPrice = 1150.00m,
            AnalystCount = 43,
            EventId = 30
        },

        // Analysis configuration for Mircon events
        new ()
        {
            Id = 31,
            Rating = Rating.Buy,
            Reasoning = "HBM3E qualification secures a key spot in tier-1 AI supply chains. Power efficiency metrics strengthen market share capture against Asian rivals.",
            TargetPrice = 145.00m,
            AnalystCount = 35,
            EventId = 31
        },
        new ()
        {
            Id = 32,
            Rating = Rating.StrongBuy,
            Reasoning = "Q2 earnings beat and fully sold-out 2025 HBM capacity confirm massive revenue visibility. Pricing power remains firm across server DRAM.",
            TargetPrice = 175.00m,
            AnalystCount = 38,
            EventId = 32
        },
        new ()
        {
            Id = 33,
            Rating = Rating.Hold,
            Reasoning = "Consumer PC and mobile memory pricing softness creates near-term margin friction. Investors wait for legacy inventory clearing before re-entering.",
            TargetPrice = 155.00m,
            AnalystCount = 34,
            EventId = 33
        },
        new ()
        {
            Id = 34,
            Rating = Rating.StrongBuy,
            Reasoning = "Q3 blowout results and gross margin expansion prove AI memory is structurally shifting corporate profitability. Target prices revised upward.",
            TargetPrice = 205.00m,
            AnalystCount = 40,
            EventId = 34
        },
        new ()
        {
            Id = 35,
            Rating = Rating.Buy,
            Reasoning = "Domestic fab progress de-risks long-term supply chains. Subsidies and capital efficiency support steady balance sheet strength.",
            TargetPrice = 195.00m,
            AnalystCount = 36,
            EventId = 35
        },
        new ()
        {
            Id = 36,
            Rating = Rating.StrongBuy,
            Reasoning = "Q4 results confirm full memory supercycle recovery. Tight supply conditions into next year guarantee sustained pricing power.",
            TargetPrice = 230.00m,
            AnalystCount = 42,
            EventId = 36
        },
        new ()
        {
            Id = 37,
            Rating = Rating.Hold,
            Reasoning = "Export rule adjustments create administrative friction but fail to break core order books. Viewed as a temporary consolidation phase.",
            TargetPrice = 215.00m,
            AnalystCount = 37,
            EventId = 37
        },
        new ()
        {
            Id = 38,
            Rating = Rating.StrongBuy,
            Reasoning = "HBM4 customer sampling extends technical leadership over competitors. Forward-looking AI hardware contracts remain exceptionally strong.",
            TargetPrice = 255.00m,
            AnalystCount = 41,
            EventId = 38
        },
        new ()
        {
            Id = 39,
            Rating = Rating.StrongBuy,
            Reasoning = "Q1 earnings shatter forecasts with record guidance. Cloud demand conversion validates long-term earnings expansion.",
            TargetPrice = 275.00m,
            AnalystCount = 45,
            EventId = 39
        },
        new ()
        {
            Id = 40,
            Rating = Rating.StrongBuy,
            Reasoning = "Year-end enterprise SSD and DRAM demand closes out a banner year. Institutional accumulation remains aggressive heading into the new fiscal period.",
            TargetPrice = 295.00m,
            AnalystCount = 46,
            EventId = 40
        },

        // Analysis configuration for Exxonmobil events
        new ()
        {
            Id = 41,
            Rating = Rating.Buy,
            Reasoning = "Record production and structural savings offset softer crude pricing. Capital discipline and shareholder returns remain best-in-class.",
            TargetPrice = 125.00m,
            AnalystCount = 32,
            EventId = 41
        },
        new ()
        {
            Id = 42,
            Rating = Rating.StrongBuy,
            Reasoning = "Permian and Guyana low-cost asset mix drives structural margin expansion. Breakeven costs continue to trend lower.",
            TargetPrice = 135.00m,
            AnalystCount = 35,
            EventId = 42
        },
        new ()
        {
            Id = 43,
            Rating = Rating.Hold,
            Reasoning = "Crude price weakness weighs on upstream realization metrics. Near-term consolidation expected as oil markets search for a floor.",
            TargetPrice = 120.00m,
            AnalystCount = 33,
            EventId = 43
        },
        new ()
        {
            Id = 44,
            Rating = Rating.Buy,
            Reasoning = "Low-carbon investments and lithium projects diversify future cash streams without risking near-term balance sheet stability.",
            TargetPrice = 132.00m,
            AnalystCount = 34,
            EventId = 44
        },
        new ()
        {
            Id = 45,
            Rating = Rating.StrongBuy,
            Reasoning = "Q2 earnings beat proves structural cost savings successfully cushion against cyclical refining margin troughs.",
            TargetPrice = 140.00m,
            AnalystCount = 36,
            EventId = 45
        },
        new ()
        {
            Id = 46,
            Rating = Rating.StrongBuy,
            Reasoning = "Yellowtail early start-up in Guyana reinforces elite execution capabilities. Offshore growth pipeline remains unmatched.",
            TargetPrice = 150.00m,
            AnalystCount = 39,
            EventId = 46
        },
        new ()
        {
            Id = 47,
            Rating = Rating.Buy,
            Reasoning = "Resilient free cash flow fully funds aggressive buybacks and dividends. Balance sheet strength offers exceptional downside protection.",
            TargetPrice = 148.00m,
            AnalystCount = 37,
            EventId = 47
        },
        new ()
        {
            Id = 48,
            Rating = Rating.StrongBuy,
            Reasoning = "Consistent dividend growth and disciplined capital allocation solidify XOM's status as a premier core equity holding.",
            TargetPrice = 155.00m,
            AnalystCount = 40,
            EventId = 48
        },
        new ()
        {
            Id = 49,
            Rating = Rating.Buy,
            Reasoning = "Record refinery throughput and strong product yields drive downstream earnings upside. Operational efficiency remains top-tier.",
            TargetPrice = 162.00m,
            AnalystCount = 38,
            EventId = 49
        },
        new ()
        {
            Id = 50,
            Rating = Rating.StrongBuy,
            Reasoning = "Multidecade production peak and flawless project execution close out a stellar year. Institutional accumulation remains firm.",
            TargetPrice = 170.00m,
            AnalystCount = 42,
            EventId = 50
        },

        // Analysis configuration for Tesla events
        new ()
        {
            Id = 51,
            Rating = Rating.Buy,
            Reasoning = "Solid annual delivery numbers prove market resilience. Scale advantages protect market share despite intense global EV competition.",
            TargetPrice = 410.00m,
            AnalystCount = 38,
            EventId = 51
        },
        new ()
        {
            Id = 52,
            Rating = Rating.StrongBuy,
            Reasoning = "Next-gen platform roadmap de-risks long-term volume growth. Cost-cutting initiatives lay the groundwork for future margin expansion.",
            TargetPrice = 440.00m,
            AnalystCount = 41,
            EventId = 52
        },
        new ()
        {
            Id = 53,
            Rating = Rating.Hold,
            Reasoning = "Delivery miss and margin friction trigger a warranted near-term consolidation. Investors wait for concrete signs of volume re-acceleration.",
            TargetPrice = 360.00m,
            AnalystCount = 37,
            EventId = 53
        },
        new ()
        {
            Id = 54,
            Rating = Rating.Buy,
            Reasoning = "FSD software adoption provides high-margin recurring revenue. Autonomous scaling remains a primary long-term valuation anchor.",
            TargetPrice = 425.00m,
            AnalystCount = 39,
            EventId = 54
        },
        new ()
        {
            Id = 55,
            Rating = Rating.StrongBuy,
            Reasoning = "Q2 delivery rebound and record energy storage deployments validate multi-pillar business model. Sentiment turns decisively positive.",
            TargetPrice = 460.00m,
            AnalystCount = 42,
            EventId = 55
        },
        new ()
        {
            Id = 56,
            Rating = Rating.Hold,
            Reasoning = "Robotaxi expansion brings immense long-term upside but faces near-term regulatory headwinds and compliance scrutiny.",
            TargetPrice = 430.00m,
            AnalystCount = 38,
            EventId = 56
        },
        new ()
        {
            Id = 57,
            Rating = Rating.StrongBuy,
            Reasoning = "Q3 earnings beat and tax-credit rush showcase strong consumer pull. Cash generation metrics reassure institutional portfolios.",
            TargetPrice = 490.00m,
            AnalystCount = 44,
            EventId = 57
        },
        new ()
        {
            Id = 58,
            Rating = Rating.StrongBuy,
            Reasoning = "Energy storage division scaling at hyper-growth rates diversifies revenue away from cyclical auto demand. Margins exceed expectations.",
            TargetPrice = 520.00m,
            AnalystCount = 40,
            EventId = 58
        },
        new ()
        {
            Id = 59,
            Rating = Rating.Hold,
            Reasoning = "Temporary dips in regulatory credit revenue create minor earnings drag. Analysts adjust target multiples cautiously.",
            TargetPrice = 495.00m,
            AnalystCount = 36,
            EventId = 59
        },
        new ()
        {
            Id = 60,
            Rating = Rating.StrongBuy,
            Reasoning = "Year-end execution cements a solid operational recovery. Momentum heading into the new year keeps institutional accumulation strong.",
            TargetPrice = 550.00m,
            AnalystCount = 45,
            EventId = 60
        },

        // Analysis configuration for Rocket Lab events
        new ()
        {
            Id = 61,
            Rating = Rating.Buy,
            Reasoning = "Q4 beat and backlog expansion confirm strong market positioning. Space Systems segment provides high-margin recurring growth.",
            TargetPrice = 45.00m,
            AnalystCount = 22,
            EventId = 61
        },
        new ()
        {
            Id = 62,
            Rating = Rating.StrongBuy,
            Reasoning = "HASTE program contract wins prove high-margin versatility. Electron launch monopoly in small-sat class remains unmatched.",
            TargetPrice = 52.00m,
            AnalystCount = 24,
            EventId = 62
        },
        new ()
        {
            Id = 63,
            Rating = Rating.Buy,
            Reasoning = "Q1 margin expansion in Space Systems validates diversification away from pure launch services. Equity targets adjusted upward.",
            TargetPrice = 48.00m,
            AnalystCount = 23,
            EventId = 63
        },
        new ()
        {
            Id = 64,
            Rating = Rating.StrongBuy,
            Reasoning = "Neutron engine hot-fire completion de-risks medium-lift timeline. Long-term constellation capabilities unlock major upside.",
            TargetPrice = 60.00m,
            AnalystCount = 26,
            EventId = 64
        },
        new ()
        {
            Id = 65,
            Rating = Rating.StrongBuy,
            Reasoning = "SDA prime contract win cements defense sector status. Sticky government backlog provides unmatched multi-year cash visibility.",
            TargetPrice = 68.00m,
            AnalystCount = 28,
            EventId = 65
        },
        new ()
        {
            Id = 66,
            Rating = Rating.StrongBuy,
            Reasoning = "Record Q2 backlog and automated factory scaling prove execution capabilities. Institutional accumulation remains heavy.",
            TargetPrice = 74.00m,
            AnalystCount = 27,
            EventId = 66
        },
        new ()
        {
            Id = 67,
            Rating = Rating.Hold,
            Reasoning = "Neutron stage test adjustment introduces minor schedule uncertainty. Price pullback provides an attractive re-entry point.",
            TargetPrice = 65.00m,
            AnalystCount = 25,
            EventId = 67
        },
        new ()
        {
            Id = 68,
            Rating = Rating.StrongBuy,
            Reasoning = "Q3 top-line surge proves commercial constellation demand remains robust. Free cash flow transition remains on track.",
            TargetPrice = 82.00m,
            AnalystCount = 29,
            EventId = 68
        },
        new ()
        {
            Id = 69,
            Rating = Rating.StrongBuy,
            Reasoning = "Space Force rapid-callout win highlights operational agility. Premium pricing power for responsive launches boosts gross margins.",
            TargetPrice = 88.00m,
            AnalystCount = 30,
            EventId = 69
        },
        new ()
        {
            Id = 70,
            Rating = Rating.StrongBuy,
            Reasoning = "Record launch cadence and multi-billion backlog cap off a banner year. Strong competitive moat heading into the upcoming period.",
            TargetPrice = 95.00m,
            AnalystCount = 31,
            EventId = 70
        },

        // Analysis configuration for Vertiv events
        new ()
        {
            Id = 71,
            Rating = Rating.StrongBuy,
            Reasoning = "Q4 beat and massive liquid cooling backlog confirm Vertiv's elite positioning as a picks-and-shovels AI infrastructure play.",
            TargetPrice = 145.00m,
            AnalystCount = 30,
            EventId = 71
        },
        new ()
        {
            Id = 72,
            Rating = Rating.Buy,
            Reasoning = "Direct-to-chip cooling innovations cement technical leadership. High thermal dissipation standards make Vertiv an indispensable supplier.",
            TargetPrice = 160.00m,
            AnalystCount = 32,
            EventId = 72
        },
        new ()
        {
            Id = 73,
            Rating = Rating.StrongBuy,
            Reasoning = "Q1 margin expansion proves pricing power remains robust. Operational leverage drives exceptional earnings quality.",
            TargetPrice = 175.00m,
            AnalystCount = 34,
            EventId = 73
        },
        new ()
        {
            Id = 74,
            Rating = Rating.StrongBuy,
            Reasoning = "Hyperscale power alliances de-risk large-scale project execution and expand the addressable market footprint.",
            TargetPrice = 195.00m,
            AnalystCount = 36,
            EventId = 74
        },
        new ()
        {
            Id = 75,
            Rating = Rating.StrongBuy,
            Reasoning = "Q2 earnings blowout and guidance raise trigger aggressive target price revisions across Wall Street desks.",
            TargetPrice = 220.00m,
            AnalystCount = 39,
            EventId = 75
        },
        new ()
        {
            Id = 76,
            Rating = Rating.Buy,
            Reasoning = "Factory footprint scaling removes future bottlenecks and ensures smooth conversion of the massive order backlog.",
            TargetPrice = 210.00m,
            AnalystCount = 35,
            EventId = 76
        },
        new ()
        {
            Id = 77,
            Rating = Rating.StrongBuy,
            Reasoning = "Q3 order intake records shatter consensus expectations. Profitability metrics outperform even aggressive forecasts.",
            TargetPrice = 245.00m,
            AnalystCount = 41,
            EventId = 77
        },
        new ()
        {
            Id = 78,
            Rating = Rating.Buy,
            Reasoning = "Lead-time reductions strengthen customer loyalty and accelerate cash conversion cycles. Balance sheet health remains premier.",
            TargetPrice = 235.00m,
            AnalystCount = 37,
            EventId = 78
        },
        new ()
        {
            Id = 79,
            Rating = Rating.StrongBuy,
            Reasoning = "High-density power infrastructure rollout captures high-value GPU deployment dollars. Competitive moat widens further.",
            TargetPrice = 265.00m,
            AnalystCount = 42,
            EventId = 79
        },
        new ()
        {
            Id = 80,
            Rating = Rating.StrongBuy,
            Reasoning = "Year-end investor targets confirm multi-year structural tailwinds. Institutional accumulation remains aggressive heading into the new cycle.",
            TargetPrice = 290.00m,
            AnalystCount = 44,
            EventId = 80
        },

        // Analysis configuration for Celsius events
        new ()
        {
            Id = 81,
            Rating = Rating.Buy,
            Reasoning = "Q4 execution and retail footprint expansion validate structural category growth. Distribution efficiency improves margins.",
            TargetPrice = 65.00m,
            AnalystCount = 25,
            EventId = 81
        },
        new ()
        {
            Id = 82,
            Rating = Rating.Buy,
            Reasoning = "Essentials line adoption in fitness channels deepens brand loyalty and captures high-margin health-conscious consumers.",
            TargetPrice = 70.00m,
            AnalystCount = 27,
            EventId = 82
        },
        new ()
        {
            Id = 83,
            Rating = Rating.StrongBuy,
            Reasoning = "Q1 earnings beat and market share gains prove domestic demand remains resilient against competitive headwinds.",
            TargetPrice = 78.00m,
            AnalystCount = 29,
            EventId = 83
        },
        new ()
        {
            Id = 84,
            Rating = Rating.Buy,
            Reasoning = "European expansion opens up a high-growth international vertical, diversifying revenue away from domestic concentration.",
            TargetPrice = 75.00m,
            AnalystCount = 26,
            EventId = 84
        },
        new ()
        {
            Id = 85,
            Rating = Rating.StrongBuy,
            Reasoning = "Q2 blowout results trigger widespread upward revisions of target prices as operating leverage exceeds expectations.",
            TargetPrice = 88.00m,
            AnalystCount = 31,
            EventId = 85
        },
        new ()
        {
            Id = 86,
            Rating = Rating.Buy,
            Reasoning = "Successful seasonal campaigns protect shelf space and maintain strong velocity metrics across convenience store networks.",
            TargetPrice = 84.00m,
            AnalystCount = 28,
            EventId = 86
        },
        new ()
        {
            Id = 87,
            Rating = Rating.StrongBuy,
            Reasoning = "Q3 resilience against competitor discounting proves brand pricing power. Logistics optimizations enhance bottom-line performance.",
            TargetPrice = 92.00m,
            AnalystCount = 32,
            EventId = 87
        },
        new ()
        {
            Id = 88,
            Rating = Rating.Buy,
            Reasoning = "Club store penetration secures massive volume distribution channels, supporting steady top-line compounding.",
            TargetPrice = 89.00m,
            AnalystCount = 29,
            EventId = 88
        },
        new ()
        {
            Id = 89,
            Rating = Rating.StrongBuy,
            Reasoning = "Powder hydration expansion taps into high-margin wellness trends, broadening the addressable product ecosystem.",
            TargetPrice = 96.00m,
            AnalystCount = 34,
            EventId = 89
        },
        new ()
        {
            Id = 90,
            Rating = Rating.StrongBuy,
            Reasoning = "Year-end market retention solidifies CELH's position as a top-tier growth stock. Institutional accumulation remains favorable.",
            TargetPrice = 102.00m,
            AnalystCount = 35,
            EventId = 90
        },

        // Analysis configuration for Vanguard ETF events
        new ()
        {
            Id = 91,
            Rating = Rating.Buy,
            Reasoning = "Resilient macro data and solid GDP print support continuous capital inflows into core S&P 500 tracking instruments.",
            TargetPrice = 115.00m,
            AnalystCount = 45,
            EventId = 91
        },
        new ()
        {
            Id = 92,
            Rating = Rating.Hold,
            Reasoning = "Fed rate path uncertainty introduces near-term market consolidation. Broad index exposure provides optimal risk mitigation.",
            TargetPrice = 110.00m,
            AnalystCount = 42,
            EventId = 92
        },
        new ()
        {
            Id = 93,
            Rating = Rating.StrongBuy,
            Reasoning = "Q1 earnings strength across index constituents drives positive net asset value expansion and reinforces bullish sentiment.",
            TargetPrice = 125.00m,
            AnalystCount = 48,
            EventId = 93
        },
        new ()
        {
            Id = 94,
            Rating = Rating.Buy,
            Reasoning = "Inflation cooling and sector rotation broaden market participation, creating a healthier structural foundation for the index.",
            TargetPrice = 122.00m,
            AnalystCount = 44,
            EventId = 94
        },
        new ()
        {
            Id = 95,
            Rating = Rating.StrongBuy,
            Reasoning = "Q2 earnings beat milestones push the benchmark higher. Fundamental earnings growth dominates multiple expansion.",
            TargetPrice = 135.00m,
            AnalystCount = 52,
            EventId = 95
        },
        new ()
        {
            Id = 96,
            Rating = Rating.Hold,
            Reasoning = "Jackson Hole policy dialogue creates temporary macro friction. Long-term accumulation strategies remain fully intact.",
            TargetPrice = 130.00m,
            AnalystCount = 46,
            EventId = 96
        },
        new ()
        {
            Id = 97,
            Rating = Rating.StrongBuy,
            Reasoning = "Q3 composite earnings beat consensus expectations, confirming robust corporate cash flows across large-cap leaders.",
            TargetPrice = 145.00m,
            AnalystCount = 55,
            EventId = 97
        },
        new ()
        {
            Id = 98,
            Rating = Rating.Buy,
            Reasoning = "Treasury yield shifts provide attractive entry points for passive capital deployment into index-tracking accumulation ETFs.",
            TargetPrice = 140.00m,
            AnalystCount = 49,
            EventId = 98
        },
        new ()
        {
            Id = 99,
            Rating = Rating.StrongBuy,
            Reasoning = "FOMC easing cycle action ignites a powerful year-end equity rally, pushing ETF net asset valuations toward upper targets.",
            TargetPrice = 155.00m,
            AnalystCount = 58,
            EventId = 99
        },
        new ()
        {
            Id = 100,
            Rating = Rating.StrongBuy,
            Reasoning = "Banner year performance closing cements VUAA's status as an essential bedrock holding for global equity portfolios.",
            TargetPrice = 165.00m,
            AnalystCount = 60,
            EventId = 100
        }
    };

    public void Configure(EntityTypeBuilder<Analysis> builder)
    {
        builder.HasData(Analyses);
    }
}