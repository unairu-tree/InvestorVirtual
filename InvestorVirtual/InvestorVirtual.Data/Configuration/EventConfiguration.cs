namespace InvestorVirtual.Data.Configuration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Models;

public class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public static readonly IEnumerable<Event> Events = new List<Event>
    {
        // Nvidia event configuration
        new ()
        {
            Id = 1,
            Title = "AI Infrastructure Demand Surge",
            Date = new DateTime(2025, 1, 15),
            StockId = 1
        },
        new ()
        {
            Id = 2,
            Title = "DeepSeek Sentiment Correction",
            Date = new DateTime(2025, 1, 27),
            StockId = 1
        },
        new ()
        {
            Id = 3,
            Title = "Next-Gen Architecture Reveal",
            Date = new DateTime(2025, 3, 18),
            StockId = 1
        },
        new ()
        {
            Id = 4,
            Title = "Q1 Earnings Blowout & Guidance",
            Date = new DateTime(2025, 5, 22),
            StockId = 1
        },
        new ()
        {
            Id = 5,
            Title = "Supply Chain & Chip Yield Updates",
            Date = new DateTime(2025, 7, 10),
            StockId = 1
        },
        new ()
        {
            Id = 6,
            Title = "Q2 Record Revenue Announcement",
            Date = new DateTime(2025, 8, 27),
            StockId = 1
        },
        new ()
        {
            Id = 7,
            Title = "Major Tech Giant Partnership Expansion",
            Date = new DateTime(2025, 10, 6),
            StockId = 1
        },
        new ()
        {
            Id = 8,
            Title = "Q3 Earnings & Margin Stabilization",
            Date = new DateTime(2025, 11, 20),
            StockId = 1
        },
        new ()
        {
            Id = 9,
            Title = "Global Regulatory & Export headwinds",
            Date = new DateTime(2025, 12, 12),
            StockId = 1
        },
        new ()
        {
            Id = 10,
            Title = "Year-End Market Positioning Review",
            Date = new DateTime(2025, 12, 30),
            StockId = 1
        },

        // Oracle event configuration
        new ()
        {
            Id = 11,
            Title = "Cloud Infrastructure (OCI) Growth Metrics",
            Date = new DateTime(2025, 1, 21),
            StockId = 2
        },
        new ()
        {
            Id = 12,
            Title = "Multi-Cloud Database Partnership",
            Date = new DateTime(2025, 2, 14),
            StockId = 2
        },
        new ()
        {
            Id = 13,
            Title = "Q3 Fiscal Earnings & Cloud Backlog",
            Date = new DateTime(2025, 3, 10),
            StockId = 2
        },
        new ()
        {
            Id = 14,
            Title = "Enterprise AI Integration Expansion",
            Date = new DateTime(2025, 4, 22),
            StockId = 2
        },
        new ()
        {
            Id = 15,
            Title = "Q4 Fiscal Year Financial Results",
            Date = new DateTime(2025, 6, 16),
            StockId = 2
        },
        new ()
        {
            Id = 16,
            Title = "Data Center Expansion CapEx Announcement",
            Date = new DateTime(2025, 7, 25),
            StockId = 2
        },
        new ()
        {
            Id = 17,
            Title = "Q1 Fiscal Earnings & Margin Analysis",
            Date = new DateTime(2025, 9, 11),
            StockId = 2
        },
        new ()
        {
            Id = 18,
            Title = "Government & Defense Cloud Contract Win",
            Date = new DateTime(2025, 10, 20),
            StockId = 2
        },
        new ()
        {
            Id = 19,
            Title = "Q2 Fiscal Earnings & Revenue Acceleration",
            Date = new DateTime(2025, 12, 8),
            StockId = 2
        },
        new ()
        {
            Id = 20,
            Title = "Annual Tech Summit & Strategic Outlook",
            Date = new DateTime(2025, 12, 29),
            StockId = 2
        },

        // Eli Lilly event configuration
        new ()
        {
            Id = 21,
            Title = "Q4 2024 Earnings & Strong 2025 Outlook",
            Date = new DateTime(2025, 2, 5),
            StockId = 3
        },
        new ()
        {
            Id = 22,
            Title = "Zepbound Supply Expansion & Distribution Update",
            Date = new DateTime(2025, 3, 18),
            StockId = 3
        },
        new ()
        {
            Id = 23,
            Title = "Q1 2025 Earnings & Mounjaro Volume Growth",
            Date = new DateTime(2025, 4, 30),
            StockId = 3
        },
        new ()
        {
            Id = 24,
            Title = "Phase III Orforglipron Oral Incretin Trial Data",
            Date = new DateTime(2025, 6, 12),
            StockId = 3
        },
        new ()
        {
            Id = 25,
            Title = "FDA Fast-Track Approval for Next-Gen Biotech Pipeline",
            Date = new DateTime(2025, 7, 15),
            StockId = 3
        },
        new ()
        {
            Id = 26,
            Title = "Q2 Earnings Drop: Price Cuts Offset Record Volume",
            Date = new DateTime(2025, 8, 7),
            StockId = 3
        },
        new ()
        {
            Id = 27,
            Title = "Zepbound Direct-to-Consumer Price Reduction",
            Date = new DateTime(2025, 9, 16),
            StockId = 3
        },
        new ()
        {
            Id = 28,
            Title = "Q3 Earnings Blowout & Full-Year Guidance Bump",
            Date = new DateTime(2025, 10, 30),
            StockId = 3
        },
        new ()
        {
            Id = 29,
            Title = "Trillion-Dollar Market Cap Milestone Surge",
            Date = new DateTime(2025, 11, 21),
            StockId = 3
        },
        new ()
        {
            Id = 30,
            Title = "Global Manufacturing Facilities CapEx Roadmap",
            Date = new DateTime(2025, 12, 17),
            StockId = 3
        },

        // Micron event configuration
        new ()
        {
            Id = 31,
            Title = "HBM3E Mass Production & NVIDIA Supply Qualification",
            Date = new DateTime(2025, 1, 15),
            StockId = 4
        },
        new ()
        {
            Id = 32,
            Title = "Q2 Fiscal Earnings Beat & HBM Capacity Sold Out",
            Date = new DateTime(2025, 3, 19),
            StockId = 4
        },
        new ()
        {
            Id = 33,
            Title = "PC & Mobile Memory Pricing Softness Concerns",
            Date = new DateTime(2025, 5, 13),
            StockId = 4
        },
        new ()
        {
            Id = 34,
            Title = "Q3 Fiscal Earnings & Gross Margin Expansion",
            Date = new DateTime(2025, 6, 25),
            StockId = 4
        },
        new ()
        {
            Id = 35,
            Title = "CHIPS Act Federal Grant Expansion & Idaho Fab Milestone",
            Date = new DateTime(2025, 7, 22),
            StockId = 4
        },
        new ()
        {
            Id = 36,
            Title = "Q4 Fiscal Earnings Blowout & AI Memory Supercycle",
            Date = new DateTime(2025, 9, 24),
            StockId = 4
        },
        new ()
        {
            Id = 37,
            Title = "International Trade Regulation & Export Friction",
            Date = new DateTime(2025, 10, 28),
            StockId = 4
        },
        new ()
        {
            Id = 38,
            Title = "Next-Gen HBM4 Sampling Announcement",
            Date = new DateTime(2025, 11, 18),
            StockId = 4
        },
        new ()
        {
            Id = 39,
            Title = "Q1 Fiscal 2026 Earnings & Record Revenue Guidance",
            Date = new DateTime(2025, 12, 17),
            StockId = 4
        },
        new ()
        {
            Id = 40,
            Title = "Year-End Enterprise SSD & Server DRAM Demand Surge",
            Date = new DateTime(2025, 12, 29),
            StockId = 4
        },

        // Exxonmobil event configuration
        new ()
        {
            Id = 41,
            Title = "Q4 2024 Earnings & Record Annual Production Milestone",
            Date = new DateTime(2025, 1, 31),
            StockId = 5
        },
        new ()
        {
            Id = 42,
            Title = "Permian & Guyana Low-Cost Volume Expansion",
            Date = new DateTime(2025, 3, 19),
            StockId = 5
        },
        new ()
        {
            Id = 43,
            Title = "Q1 Earnings & Crude Oil Price Volatility Pullback",
            Date = new DateTime(2025, 4, 30),
            StockId = 5
        },
        new ()
        {
            Id = 44,
            Title = "Low-Carbon Solutions & Lithium Extraction Roadmap",
            Date = new DateTime(2025, 6, 10),
            StockId = 5
        },
        new ()
        {
            Id = 45,
            Title = "Q2 Earnings Beat Despite Soft Refining Margins",
            Date = new DateTime(2025, 7, 30),
            StockId = 5
        },
        new ()
        {
            Id = 46,
            Title = "Guyana Yellowtail Early Start-Up & Offshore Milestone",
            Date = new DateTime(2025, 9, 16),
            StockId = 5
        },
        new ()
        {
            Id = 47,
            Title = "Q3 Earnings Release & Share Buyback Pace Update",
            Date = new DateTime(2025, 10, 31),
            StockId = 5
        },
        new ()
        {
            Id = 48,
            Title = "Annual Dividend Increase & Capital Allocation Strategy",
            Date = new DateTime(2025, 11, 19),
            StockId = 5
        },
        new ()
        {
            Id = 49,
            Title = "Global Refinery Throughput & Energy Products Surge",
            Date = new DateTime(2025, 12, 10),
            StockId = 5
        },
        new ()
        {
            Id = 50,
            Title = "Year-End Strategic Asset Review & Output Peak",
            Date = new DateTime(2025, 12, 29),
            StockId = 5
        },

        // Tesla event configuration
        new ()
        {
            Id = 51,
            Title = "Q4 2024 Vehicle Delivery & Production Report",
            Date = new DateTime(2025, 1, 2),
            StockId = 6
        },
        new ()
        {
            Id = 52,
            Title = "Next-Gen Vehicle Platform & Cost Reduction Roadmap",
            Date = new DateTime(2025, 2, 26),
            StockId = 6
        },
        new ()
        {
            Id = 53,
            Title = "Q1 2025 Deliveries Miss & Margin Pressures",
            Date = new DateTime(2025, 4, 2),
            StockId = 6
        },
        new ()
        {
            Id = 54,
            Title = "Full Self-Driving (FSD) Supervisory Expansion Milestone",
            Date = new DateTime(2025, 5, 14),
            StockId = 6
        },
        new ()
        {
            Id = 55,
            Title = "Q2 Deliveries Recovery & Energy Storage Record",
            Date = new DateTime(2025, 7, 2),
            StockId = 6
        },
        new ()
        {
            Id = 56,
            Title = "Robotaxi Fleet Expansion & Autonomous Testing Update",
            Date = new DateTime(2025, 8, 20),
            StockId = 6
        },
        new ()
        {
            Id = 57,
            Title = "Q3 Earnings & Pre-Tax Credit Delivery Surge",
            Date = new DateTime(2025, 10, 22),
            StockId = 6
        },
        new ()
        {
            Id = 58,
            Title = "Energy Storage Division Gigafactory Capacity Scale-Up",
            Date = new DateTime(2025, 11, 12),
            StockId = 6
        },
        new ()
        {
            Id = 59,
            Title = "Regulatory Credit Fluctuations & Market Adaptation",
            Date = new DateTime(2025, 12, 3),
            StockId = 6
        },
        new ()
        {
            Id = 60,
            Title = "Year-End Delivery Push and Autonomous Progress Review",
            Date = new DateTime(2025, 12, 29),
            StockId = 6
        },

        // Rocket Lab event configuration
        new ()
        {
            Id = 61,
            Title = "Q4 2024 Earnings & Record Annual Revenue",
            Date = new DateTime(2025, 2, 26),
            StockId = 7
        },
        new ()
        {
            Id = 62,
            Title = "Electron Launch Cadence Record & HASTE Mission Win",
            Date = new DateTime(2025, 3, 19),
            StockId = 7
        },
        new ()
        {
            Id = 63,
            Title = "Q1 2025 Financial Results & Space Systems Expansion",
            Date = new DateTime(2025, 5, 7),
            StockId = 7
        },
        new ()
        {
            Id = 64,
            Title = "Neutron Hot-Fire Test Milestone & Launch Complex Progress",
            Date = new DateTime(2025, 6, 18),
            StockId = 7
        },
        new ()
        {
            Id = 65,
            Title = "SDA Defense Satellite Constellation Contract Award",
            Date = new DateTime(2025, 7, 16),
            StockId = 7
        },
        new ()
        {
            Id = 66,
            Title = "Q2 Earnings & Backlog Expansion Milestone",
            Date = new DateTime(2025, 8, 7),
            StockId = 7
        },
        new ()
        {
            Id = 67,
            Title = "Stage 1 Tank Test Setback & Schedule Adjustment",
            Date = new DateTime(2025, 9, 24),
            StockId = 7
        },
        new ()
        {
            Id = 68,
            Title = "Q3 Financial Results & Commercial Satellite Fleet Contract",
            Date = new DateTime(2025, 11, 12),
            StockId = 7
        },
        new ()
        {
            Id = 69,
            Title = "U.S. Space Force Dedicated Launch Selection",
            Date = new DateTime(2025, 12, 10),
            StockId = 7
        },
        new ()
        {
            Id = 70,
            Title = "Year-End Launch Milestone & Annual Backlog Review",
            Date = new DateTime(2025, 12, 29),
            StockId = 7
        },

        // Vertiv event configuration
        new ()
        {
            Id = 71,
            Title = "Q4 2024 Earnings & Liquid Cooling Backlog Surge",
            Date = new DateTime(2025, 2, 19),
            StockId = 8
        },
        new ()
        {
            Id = 72,
            Title = "Next-Gen Thermal Management & Direct-to-Chip Expansion",
            Date = new DateTime(2025, 3, 26),
            StockId = 8
        },
        new ()
        {
            Id = 73,
            Title = "Q1 2025 Financial Results & Operating Margin Expansion",
            Date = new DateTime(2025, 4, 23),
            StockId = 8
        },
        new ()
        {
            Id = 74,
            Title = "Strategic Partnership for Hyperscale AI Data Center Power",
            Date = new DateTime(2025, 6, 4),
            StockId = 8
        },
        new ()
        {
            Id = 75,
            Title = "Q2 Earnings Beat & Full-Year Guidance Revision",
            Date = new DateTime(2025, 7, 23),
            StockId = 8
        },
        new ()
        {
            Id = 76,
            Title = "Global Manufacturing Capacity Scaling Announcement",
            Date = new DateTime(2025, 9, 10),
            StockId = 8
        },
        new ()
        {
            Id = 77,
            Title = "Q3 Earnings Release & Record Order Intake",
            Date = new DateTime(2025, 10, 22),
            StockId = 8
        },
        new ()
        {
            Id = 78,
            Title = "Supply Chain Optimization and Lead-Time Reduction Milestone",
            Date = new DateTime(2025, 11, 19),
            StockId = 8
        },
        new ()
        {
            Id = 79,
            Title = "High-Density Power Infrastructure Product Launch",
            Date = new DateTime(2025, 12, 10),
            StockId = 8
        },
        new ()
        {
            Id = 80,
            Title = "Year-End Investor Summit & Long-Term Growth Targets",
            Date = new DateTime(2025, 12, 29),
            StockId = 8
        },

        // Celsius event configuration
        new ()
        {
            Id = 81,
            Title = "Q4 2024 Earnings & Omnichannel Distribution Update",
            Date = new DateTime(2025, 2, 26),
            StockId = 9
        },
        new ()
        {
            Id = 82,
            Title = "Celsius Essentials Line Expansion & Fitness Gym Rollout",
            Date = new DateTime(2025, 3, 26),
            StockId = 9
        },
        new ()
        {
            Id = 83,
            Title = "Q1 2025 Financial Results & Convenience Store Market Share",
            Date = new DateTime(2025, 5, 7),
            StockId = 9
        },
        new ()
        {
            Id = 84,
            Title = "International Expansion Launch in Major European Retailers",
            Date = new DateTime(2025, 6, 18),
            StockId = 9
        },
        new ()
        {
            Id = 85,
            Title = "Q2 Earnings Beat & Brand Portfolio Integration",
            Date = new DateTime(2025, 8, 6),
            StockId = 9
        },
        new ()
        {
            Id = 86,
            Title = "New Flavor Lineup & Fall Promotional Campaign Debut",
            Date = new DateTime(2025, 9, 17),
            StockId = 9
        },
        new ()
        {
            Id = 87,
            Title = "Q3 Earnings Release & Direct-Store-Delivery Efficiency",
            Date = new DateTime(2025, 11, 5),
            StockId = 9
        },
        new ()
        {
            Id = 88,
            Title = "Club Store and Foodservice Channel Penetration Growth",
            Date = new DateTime(2025, 11, 26),
            StockId = 9
        },
        new ()
        {
            Id = 89,
            Title = "Hydration Powder Stick Product Line Expansion",
            Date = new DateTime(2025, 12, 10),
            StockId = 9
        },
        new ()
        {
            Id = 90,
            Title = "Year-End Retail Scan Data & Market Position Review",
            Date = new DateTime(2025, 12, 29),
            StockId = 9
        },

        // Vanguard ETF event configuration
        new ()
        {
            Id = 91,
            Title = "Q4 2024 U.S. Macro GDP Print & Index Rebalancing",
            Date = new DateTime(2025, 1, 30),
            StockId = 10
        },
        new ()
        {
            Id = 92,
            Title = "Federal Reserve Rate Path Shift & Market Reaction",
            Date = new DateTime(2025, 3, 19),
            StockId = 10
        },
        new ()
        {
            Id = 93,
            Title = "Q1 S&P 500 Corporate Earnings Season Kickoff",
            Date = new DateTime(2025, 4, 23),
            StockId = 10
        },
        new ()
        {
            Id = 94,
            Title = "Mid-Year Inflation Data Print & Index Sector Rotation",
            Date = new DateTime(2025, 6, 11),
            StockId = 10
        },
        new ()
        {
            Id = 95,
            Title = "Q2 Broad Market Earnings Beat & Index Highs",
            Date = new DateTime(2025, 7, 23),
            StockId = 10
        },
        new ()
        {
            Id = 96,
            Title = "Jackson Hole Economic Symposium & Macro Volatility",
            Date = new DateTime(2025, 8, 20),
            StockId = 10
        },
        new ()
        {
            Id = 97,
            Title = "Q3 S&P 500 Composite Earnings & Tech Sector Rally",
            Date = new DateTime(2025, 10, 22),
            StockId = 10
        },
        new ()
        {
            Id = 98,
            Title = "U.S. Fiscal Policy & Treasury Yield Fluctuation Impact",
            Date = new DateTime(2025, 11, 19),
            StockId = 10
        },
        new ()
        {
            Id = 99,
            Title = "FOMC Rate Decision & Year-End Window Dressing",
            Date = new DateTime(2025, 12, 10),
            StockId = 10
        },
        new ()
        {
            Id = 100,
            Title = "Year-End Index Performance Close & Asset Inflows",
            Date = new DateTime(2025, 12, 30),
            StockId = 10
        }
    };

    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.HasData(Events);
    }
}