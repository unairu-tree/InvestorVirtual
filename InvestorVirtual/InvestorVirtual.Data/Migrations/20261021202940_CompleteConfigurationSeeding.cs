using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InvestorVirtual.Data.Migrations
{
    /// <inheritdoc />
    public partial class CompleteConfigurationSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Date", "StockId", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "AI Infrastructure Demand Surge" },
                    { 2, new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "DeepSeek Sentiment Correction" },
                    { 3, new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Next-Gen Architecture Reveal" },
                    { 4, new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Q1 Earnings Blowout & Guidance" },
                    { 5, new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Supply Chain & Chip Yield Updates" },
                    { 6, new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Q2 Record Revenue Announcement" },
                    { 7, new DateTime(2025, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Major Tech Giant Partnership Expansion" },
                    { 8, new DateTime(2025, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Q3 Earnings & Margin Stabilization" },
                    { 9, new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Global Regulatory & Export headwinds" },
                    { 10, new DateTime(2025, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Year-End Market Positioning Review" },
                    { 11, new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Cloud Infrastructure (OCI) Growth Metrics" },
                    { 12, new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Multi-Cloud Database Partnership" },
                    { 13, new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Q3 Fiscal Earnings & Cloud Backlog" },
                    { 14, new DateTime(2025, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Enterprise AI Integration Expansion" },
                    { 15, new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Q4 Fiscal Year Financial Results" },
                    { 16, new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Data Center Expansion CapEx Announcement" },
                    { 17, new DateTime(2025, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Q1 Fiscal Earnings & Margin Analysis" },
                    { 18, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Government & Defense Cloud Contract Win" },
                    { 19, new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Q2 Fiscal Earnings & Revenue Acceleration" },
                    { 20, new DateTime(2025, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Annual Tech Summit & Strategic Outlook" },
                    { 21, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Q4 2024 Earnings & Strong 2025 Outlook" },
                    { 22, new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Zepbound Supply Expansion & Distribution Update" },
                    { 23, new DateTime(2025, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Q1 2025 Earnings & Mounjaro Volume Growth" },
                    { 24, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Phase III Orforglipron Oral Incretin Trial Data" },
                    { 25, new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "FDA Fast-Track Approval for Next-Gen Biotech Pipeline" },
                    { 26, new DateTime(2025, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Q2 Earnings Drop: Price Cuts Offset Record Volume" },
                    { 27, new DateTime(2025, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Zepbound Direct-to-Consumer Price Reduction" },
                    { 28, new DateTime(2025, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Q3 Earnings Blowout & Full-Year Guidance Bump" },
                    { 29, new DateTime(2025, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Trillion-Dollar Market Cap Milestone Surge" },
                    { 30, new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Global Manufacturing Facilities CapEx Roadmap" },
                    { 31, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "HBM3E Mass Production & NVIDIA Supply Qualification" },
                    { 32, new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Q2 Fiscal Earnings Beat & HBM Capacity Sold Out" },
                    { 33, new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "PC & Mobile Memory Pricing Softness Concerns" },
                    { 34, new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Q3 Fiscal Earnings & Gross Margin Expansion" },
                    { 35, new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "CHIPS Act Federal Grant Expansion & Idaho Fab Milestone" },
                    { 36, new DateTime(2025, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Q4 Fiscal Earnings Blowout & AI Memory Supercycle" },
                    { 37, new DateTime(2025, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "International Trade Regulation & Export Friction" },
                    { 38, new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Next-Gen HBM4 Sampling Announcement" },
                    { 39, new DateTime(2025, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Q1 Fiscal 2026 Earnings & Record Revenue Guidance" },
                    { 40, new DateTime(2025, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Year-End Enterprise SSD & Server DRAM Demand Surge" },
                    { 41, new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Q4 2024 Earnings & Record Annual Production Milestone" },
                    { 42, new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Permian & Guyana Low-Cost Volume Expansion" },
                    { 43, new DateTime(2025, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Q1 Earnings & Crude Oil Price Volatility Pullback" },
                    { 44, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Low-Carbon Solutions & Lithium Extraction Roadmap" },
                    { 45, new DateTime(2025, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Q2 Earnings Beat Despite Soft Refining Margins" },
                    { 46, new DateTime(2025, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Guyana Yellowtail Early Start-Up & Offshore Milestone" },
                    { 47, new DateTime(2025, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Q3 Earnings Release & Share Buyback Pace Update" },
                    { 48, new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Annual Dividend Increase & Capital Allocation Strategy" },
                    { 49, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Global Refinery Throughput & Energy Products Surge" },
                    { 50, new DateTime(2025, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Year-End Strategic Asset Review & Output Peak" },
                    { 51, new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Q4 2024 Vehicle Delivery & Production Report" },
                    { 52, new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Next-Gen Vehicle Platform & Cost Reduction Roadmap" },
                    { 53, new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Q1 2025 Deliveries Miss & Margin Pressures" },
                    { 54, new DateTime(2025, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Full Self-Driving (FSD) Supervisory Expansion Milestone" },
                    { 55, new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Q2 Deliveries Recovery & Energy Storage Record" },
                    { 56, new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Robotaxi Fleet Expansion & Autonomous Testing Update" },
                    { 57, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Q3 Earnings & Pre-Tax Credit Delivery Surge" },
                    { 58, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Energy Storage Division Gigafactory Capacity Scale-Up" },
                    { 59, new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Regulatory Credit Fluctuations & Market Adaptation" },
                    { 60, new DateTime(2025, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Year-End Delivery Push and Autonomous Progress Review" },
                    { 61, new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Q4 2024 Earnings & Record Annual Revenue" },
                    { 62, new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Electron Launch Cadence Record & HASTE Mission Win" },
                    { 63, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Q1 2025 Financial Results & Space Systems Expansion" },
                    { 64, new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Neutron Hot-Fire Test Milestone & Launch Complex Progress" },
                    { 65, new DateTime(2025, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "SDA Defense Satellite Constellation Contract Award" },
                    { 66, new DateTime(2025, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Q2 Earnings & Backlog Expansion Milestone" },
                    { 67, new DateTime(2025, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Stage 1 Tank Test Setback & Schedule Adjustment" },
                    { 68, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Q3 Financial Results & Commercial Satellite Fleet Contract" },
                    { 69, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "U.S. Space Force Dedicated Launch Selection" },
                    { 70, new DateTime(2025, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Year-End Launch Milestone & Annual Backlog Review" },
                    { 71, new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Q4 2024 Earnings & Liquid Cooling Backlog Surge" },
                    { 72, new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Next-Gen Thermal Management & Direct-to-Chip Expansion" },
                    { 73, new DateTime(2025, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Q1 2025 Financial Results & Operating Margin Expansion" },
                    { 74, new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Strategic Partnership for Hyperscale AI Data Center Power" },
                    { 75, new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Q2 Earnings Beat & Full-Year Guidance Revision" },
                    { 76, new DateTime(2025, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Global Manufacturing Capacity Scaling Announcement" },
                    { 77, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Q3 Earnings Release & Record Order Intake" },
                    { 78, new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Supply Chain Optimization and Lead-Time Reduction Milestone" },
                    { 79, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "High-Density Power Infrastructure Product Launch" },
                    { 80, new DateTime(2025, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Year-End Investor Summit & Long-Term Growth Targets" },
                    { 81, new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Q4 2024 Earnings & Omnichannel Distribution Update" },
                    { 82, new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Celsius Essentials Line Expansion & Fitness Gym Rollout" },
                    { 83, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Q1 2025 Financial Results & Convenience Store Market Share" },
                    { 84, new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "International Expansion Launch in Major European Retailers" },
                    { 85, new DateTime(2025, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Q2 Earnings Beat & Brand Portfolio Integration" },
                    { 86, new DateTime(2025, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "New Flavor Lineup & Fall Promotional Campaign Debut" },
                    { 87, new DateTime(2025, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Q3 Earnings Release & Direct-Store-Delivery Efficiency" },
                    { 88, new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Club Store and Foodservice Channel Penetration Growth" },
                    { 89, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Hydration Powder Stick Product Line Expansion" },
                    { 90, new DateTime(2025, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Year-End Retail Scan Data & Market Position Review" },
                    { 91, new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Q4 2024 U.S. Macro GDP Print & Index Rebalancing" },
                    { 92, new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Federal Reserve Rate Path Shift & Market Reaction" },
                    { 93, new DateTime(2025, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Q1 S&P 500 Corporate Earnings Season Kickoff" },
                    { 94, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Mid-Year Inflation Data Print & Index Sector Rotation" },
                    { 95, new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Q2 Broad Market Earnings Beat & Index Highs" },
                    { 96, new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Jackson Hole Economic Symposium & Macro Volatility" },
                    { 97, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Q3 S&P 500 Composite Earnings & Tech Sector Rally" },
                    { 98, new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "U.S. Fiscal Policy & Treasury Yield Fluctuation Impact" },
                    { 99, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "FOMC Rate Decision & Year-End Window Dressing" },
                    { 100, new DateTime(2025, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Year-End Index Performance Close & Asset Inflows" }
                });

            migrationBuilder.InsertData(
                table: "Analyses",
                columns: new[] { "Id", "AnalystCount", "EventId", "Rating", "Reasoning", "TargetPrice" },
                values: new object[,]
                {
                    { 1, 42, 1, 5, "Massive AI data center demand drives high revenue visibility. Analysts boost targets as Blackwell deployment schedules surpass expectations.", 155.00m },
                    { 2, 40, 2, 4, "Flash crash panic over low-cost AI training is overdone. Hardware moats and massive compute requirements remain essential for scaling.", 132.00m },
                    { 3, 45, 3, 5, "Next-gen architecture reveals widened performance gaps over rivals. Power efficiency metrics prompt target upgrades.", 168.00m },
                    { 4, 44, 4, 5, "Q1 blowout earnings crush estimates and erase cost concerns. Gross margins over 70% prove unmatched pricing power.", 185.00m },
                    { 5, 41, 5, 4, "Supply chain checks confirm packaging bottlenecks are easing. Long-term outlook remains firmly positive.", 175.00m },
                    { 6, 46, 6, 5, "Record Q2 results and sovereign AI demand unlock fresh growth verticals. Price targets surge to new highs.", 195.00m },
                    { 7, 43, 7, 5, "Multi-billion cloud contract solidifies multi-year cash flows. Ecosystem stickiness prevents client churn.", 205.00m },
                    { 8, 45, 8, 4, "Q3 earnings confirm stable margins and strong free cash flow. Macro noise fails to dent robust institutional demand.", 215.00m },
                    { 9, 39, 9, 4, "Export rule updates create minor friction but leave core order books intact. Viewed as a temporary dip.", 210.00m },
                    { 10, 48, 10, 5, "Year-end review crowns NVDA as the backbone of the AI economy. High margins and robust expansion set to continue.", 225.00m },
                    { 11, 34, 11, 4, "OCI metrics show strong enterprise pull. Competitive pricing is successfully drawing major AI and database workloads away from legacy rivals.", 145.00m },
                    { 12, 36, 12, 5, "Multi-cloud database partnership eliminates friction for enterprise clients, driving immediate interest and scaling cross-platform adoption.", 160.00m },
                    { 13, 38, 13, 5, "Q3 RPO backlog expansion smashes expectations. Massive multi-year corporate commitments secure exceptional long-term revenue visibility.", 180.00m },
                    { 14, 35, 14, 4, "Native AI agents in Fusion and NetSuite accelerate SaaS growth. Legacy on-premise holdouts are converting faster than anticipated.", 175.00m },
                    { 15, 40, 15, 5, "Blockbuster Q4 results confirm full cloud transformation. Compounding OCI consumption rates push operating margins to new highs.", 195.00m },
                    { 16, 37, 16, 4, "CapEx roadmap for data centers is heavily pre-backed by firm customer commitments, successfully de-risking the aggressive cloud build-out.", 190.00m },
                    { 17, 39, 17, 5, "Q1 earnings beat highlights robust margin stability and high free cash flow conversion. Institutional sentiment remains firmly positive.", 210.00m },
                    { 18, 42, 18, 5, "Sovereign cloud win with defense agencies creates a highly lucrative, sticky revenue vertical insulated from broader market shifts.", 225.00m },
                    { 19, 38, 19, 4, "Q2 top-line growth accelerates as database conversions outpace forecasts. Analysts quickly upgrade targets to match compounding tailwinds.", 220.00m },
                    { 20, 44, 20, 5, "Year-end tech summit outlines a bold autonomous database strategy. Long-term scaling targets cement Oracle as an enterprise cloud anchor.", 240.00m },
                    { 21, 38, 21, 5, "Doubled profits and strong 2025 outlook validate obesity drug dominance. High multiples are justified by compounding demand.", 950.00m },
                    { 22, 35, 22, 4, "Supply chain expansion clears the path for accelerated fulfillment. Distribution bottlenecks are successfully resolving.", 920.00m },
                    { 23, 36, 23, 3, "Strong Q1 sales offset by cautious guidance shifts and rising R&D costs. Near-term consolidation expected before next leg up.", 880.00m },
                    { 24, 40, 24, 5, "Orforglipron Phase III success de-risks the oral pipeline and widens Lilly's competitive moat against injectable rivals.", 960.00m },
                    { 25, 37, 25, 4, "FDA fast-track status accelerates commercialization timelines for key biotech candidates, keeping sentiment positive.", 990.00m },
                    { 26, 39, 26, 3, "Solid Q2 beat overshadowed by pricing compression and mixed trial data. Analysts trim short-term targets to account for margin friction.", 840.00m },
                    { 27, 34, 27, 4, "Direct-to-consumer pricing strategy defends market share. Near-term margin softness is viewed as a necessary trade-off for volume.", 890.00m },
                    { 28, 42, 28, 5, "Q3 blowout results and guidance raise completely erase prior margin concerns. Earnings visibility remains best-in-class.", 1050.00m },
                    { 29, 41, 29, 5, "Market cap milestone reflects unmatched growth in pharmaceutical sector. Institutional accumulation remains aggressive.", 1100.00m },
                    { 30, 43, 30, 5, "CapEx investment secures multi-year manufacturing capacity. Long-term structural tailwinds remain exceptionally robust.", 1150.00m },
                    { 31, 35, 31, 4, "HBM3E qualification secures a key spot in tier-1 AI supply chains. Power efficiency metrics strengthen market share capture against Asian rivals.", 145.00m },
                    { 32, 38, 32, 5, "Q2 earnings beat and fully sold-out 2025 HBM capacity confirm massive revenue visibility. Pricing power remains firm across server DRAM.", 175.00m },
                    { 33, 34, 33, 3, "Consumer PC and mobile memory pricing softness creates near-term margin friction. Investors wait for legacy inventory clearing before re-entering.", 155.00m },
                    { 34, 40, 34, 5, "Q3 blowout results and gross margin expansion prove AI memory is structurally shifting corporate profitability. Target prices revised upward.", 205.00m },
                    { 35, 36, 35, 4, "Domestic fab progress de-risks long-term supply chains. Subsidies and capital efficiency support steady balance sheet strength.", 195.00m },
                    { 36, 42, 36, 5, "Q4 results confirm full memory supercycle recovery. Tight supply conditions into next year guarantee sustained pricing power.", 230.00m },
                    { 37, 37, 37, 3, "Export rule adjustments create administrative friction but fail to break core order books. Viewed as a temporary consolidation phase.", 215.00m },
                    { 38, 41, 38, 5, "HBM4 customer sampling extends technical leadership over competitors. Forward-looking AI hardware contracts remain exceptionally strong.", 255.00m },
                    { 39, 45, 39, 5, "Q1 earnings shatter forecasts with record guidance. Cloud demand conversion validates long-term earnings expansion.", 275.00m },
                    { 40, 46, 40, 5, "Year-end enterprise SSD and DRAM demand closes out a banner year. Institutional accumulation remains aggressive heading into the new fiscal period.", 295.00m },
                    { 41, 32, 41, 4, "Record production and structural savings offset softer crude pricing. Capital discipline and shareholder returns remain best-in-class.", 125.00m },
                    { 42, 35, 42, 5, "Permian and Guyana low-cost asset mix drives structural margin expansion. Breakeven costs continue to trend lower.", 135.00m },
                    { 43, 33, 43, 3, "Crude price weakness weighs on upstream realization metrics. Near-term consolidation expected as oil markets search for a floor.", 120.00m },
                    { 44, 34, 44, 4, "Low-carbon investments and lithium projects diversify future cash streams without risking near-term balance sheet stability.", 132.00m },
                    { 45, 36, 45, 5, "Q2 earnings beat proves structural cost savings successfully cushion against cyclical refining margin troughs.", 140.00m },
                    { 46, 39, 46, 5, "Yellowtail early start-up in Guyana reinforces elite execution capabilities. Offshore growth pipeline remains unmatched.", 150.00m },
                    { 47, 37, 47, 4, "Resilient free cash flow fully funds aggressive buybacks and dividends. Balance sheet strength offers exceptional downside protection.", 148.00m },
                    { 48, 40, 48, 5, "Consistent dividend growth and disciplined capital allocation solidify XOM's status as a premier core equity holding.", 155.00m },
                    { 49, 38, 49, 4, "Record refinery throughput and strong product yields drive downstream earnings upside. Operational efficiency remains top-tier.", 162.00m },
                    { 50, 42, 50, 5, "Multidecade production peak and flawless project execution close out a stellar year. Institutional accumulation remains firm.", 170.00m },
                    { 51, 38, 51, 4, "Solid annual delivery numbers prove market resilience. Scale advantages protect market share despite intense global EV competition.", 410.00m },
                    { 52, 41, 52, 5, "Next-gen platform roadmap de-risks long-term volume growth. Cost-cutting initiatives lay the groundwork for future margin expansion.", 440.00m },
                    { 53, 37, 53, 3, "Delivery miss and margin friction trigger a warranted near-term consolidation. Investors wait for concrete signs of volume re-acceleration.", 360.00m },
                    { 54, 39, 54, 4, "FSD software adoption provides high-margin recurring revenue. Autonomous scaling remains a primary long-term valuation anchor.", 425.00m },
                    { 55, 42, 55, 5, "Q2 delivery rebound and record energy storage deployments validate multi-pillar business model. Sentiment turns decisively positive.", 460.00m },
                    { 56, 38, 56, 3, "Robotaxi expansion brings immense long-term upside but faces near-term regulatory headwinds and compliance scrutiny.", 430.00m },
                    { 57, 44, 57, 5, "Q3 earnings beat and tax-credit rush showcase strong consumer pull. Cash generation metrics reassure institutional portfolios.", 490.00m },
                    { 58, 40, 58, 5, "Energy storage division scaling at hyper-growth rates diversifies revenue away from cyclical auto demand. Margins exceed expectations.", 520.00m },
                    { 59, 36, 59, 3, "Temporary dips in regulatory credit revenue create minor earnings drag. Analysts adjust target multiples cautiously.", 495.00m },
                    { 60, 45, 60, 5, "Year-end execution cements a solid operational recovery. Momentum heading into the new year keeps institutional accumulation strong.", 550.00m },
                    { 61, 22, 61, 4, "Q4 beat and backlog expansion confirm strong market positioning. Space Systems segment provides high-margin recurring growth.", 45.00m },
                    { 62, 24, 62, 5, "HASTE program contract wins prove high-margin versatility. Electron launch monopoly in small-sat class remains unmatched.", 52.00m },
                    { 63, 23, 63, 4, "Q1 margin expansion in Space Systems validates diversification away from pure launch services. Equity targets adjusted upward.", 48.00m },
                    { 64, 26, 64, 5, "Neutron engine hot-fire completion de-risks medium-lift timeline. Long-term constellation capabilities unlock major upside.", 60.00m },
                    { 65, 28, 65, 5, "SDA prime contract win cements defense sector status. Sticky government backlog provides unmatched multi-year cash visibility.", 68.00m },
                    { 66, 27, 66, 5, "Record Q2 backlog and automated factory scaling prove execution capabilities. Institutional accumulation remains heavy.", 74.00m },
                    { 67, 25, 67, 3, "Neutron stage test adjustment introduces minor schedule uncertainty. Price pullback provides an attractive re-entry point.", 65.00m },
                    { 68, 29, 68, 5, "Q3 top-line surge proves commercial constellation demand remains robust. Free cash flow transition remains on track.", 82.00m },
                    { 69, 30, 69, 5, "Space Force rapid-callout win highlights operational agility. Premium pricing power for responsive launches boosts gross margins.", 88.00m },
                    { 70, 31, 70, 5, "Record launch cadence and multi-billion backlog cap off a banner year. Strong competitive moat heading into the upcoming period.", 95.00m },
                    { 71, 30, 71, 5, "Q4 beat and massive liquid cooling backlog confirm Vertiv's elite positioning as a picks-and-shovels AI infrastructure play.", 145.00m },
                    { 72, 32, 72, 4, "Direct-to-chip cooling innovations cement technical leadership. High thermal dissipation standards make Vertiv an indispensable supplier.", 160.00m },
                    { 73, 34, 73, 5, "Q1 margin expansion proves pricing power remains robust. Operational leverage drives exceptional earnings quality.", 175.00m },
                    { 74, 36, 74, 5, "Hyperscale power alliances de-risk large-scale project execution and expand the addressable market footprint.", 195.00m },
                    { 75, 39, 75, 5, "Q2 earnings blowout and guidance raise trigger aggressive target price revisions across Wall Street desks.", 220.00m },
                    { 76, 35, 76, 4, "Factory footprint scaling removes future bottlenecks and ensures smooth conversion of the massive order backlog.", 210.00m },
                    { 77, 41, 77, 5, "Q3 order intake records shatter consensus expectations. Profitability metrics outperform even aggressive forecasts.", 245.00m },
                    { 78, 37, 78, 4, "Lead-time reductions strengthen customer loyalty and accelerate cash conversion cycles. Balance sheet health remains premier.", 235.00m },
                    { 79, 42, 79, 5, "High-density power infrastructure rollout captures high-value GPU deployment dollars. Competitive moat widens further.", 265.00m },
                    { 80, 44, 80, 5, "Year-end investor targets confirm multi-year structural tailwinds. Institutional accumulation remains aggressive heading into the new cycle.", 290.00m },
                    { 81, 25, 81, 4, "Q4 execution and retail footprint expansion validate structural category growth. Distribution efficiency improves margins.", 65.00m },
                    { 82, 27, 82, 4, "Essentials line adoption in fitness channels deepens brand loyalty and captures high-margin health-conscious consumers.", 70.00m },
                    { 83, 29, 83, 5, "Q1 earnings beat and market share gains prove domestic demand remains resilient against competitive headwinds.", 78.00m },
                    { 84, 26, 84, 4, "European expansion opens up a high-growth international vertical, diversifying revenue away from domestic concentration.", 75.00m },
                    { 85, 31, 85, 5, "Q2 blowout results trigger widespread upward revisions of target prices as operating leverage exceeds expectations.", 88.00m },
                    { 86, 28, 86, 4, "Successful seasonal campaigns protect shelf space and maintain strong velocity metrics across convenience store networks.", 84.00m },
                    { 87, 32, 87, 5, "Q3 resilience against competitor discounting proves brand pricing power. Logistics optimizations enhance bottom-line performance.", 92.00m },
                    { 88, 29, 88, 4, "Club store penetration secures massive volume distribution channels, supporting steady top-line compounding.", 89.00m },
                    { 89, 34, 89, 5, "Powder hydration expansion taps into high-margin wellness trends, broadening the addressable product ecosystem.", 96.00m },
                    { 90, 35, 90, 5, "Year-end market retention solidifies CELH's position as a top-tier growth stock. Institutional accumulation remains favorable.", 102.00m },
                    { 91, 45, 91, 4, "Resilient macro data and solid GDP print support continuous capital inflows into core S&P 500 tracking instruments.", 115.00m },
                    { 92, 42, 92, 3, "Fed rate path uncertainty introduces near-term market consolidation. Broad index exposure provides optimal risk mitigation.", 110.00m },
                    { 93, 48, 93, 5, "Q1 earnings strength across index constituents drives positive net asset value expansion and reinforces bullish sentiment.", 125.00m },
                    { 94, 44, 94, 4, "Inflation cooling and sector rotation broaden market participation, creating a healthier structural foundation for the index.", 122.00m },
                    { 95, 52, 95, 5, "Q2 earnings beat milestones push the benchmark higher. Fundamental earnings growth dominates multiple expansion.", 135.00m },
                    { 96, 46, 96, 3, "Jackson Hole policy dialogue creates temporary macro friction. Long-term accumulation strategies remain fully intact.", 130.00m },
                    { 97, 55, 97, 5, "Q3 composite earnings beat consensus expectations, confirming robust corporate cash flows across large-cap leaders.", 145.00m },
                    { 98, 49, 98, 4, "Treasury yield shifts provide attractive entry points for passive capital deployment into index-tracking accumulation ETFs.", 140.00m },
                    { 99, 58, 99, 5, "FOMC easing cycle action ignites a powerful year-end equity rally, pushing ETF net asset valuations toward upper targets.", 155.00m },
                    { 100, 60, 100, 5, "Banner year performance closing cements VUAA's status as an essential bedrock holding for global equity portfolios.", 165.00m }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Body", "EventId", "Headline", "Source" },
                values: new object[,]
                {
                    { 1, "Enterprise spending on artificial intelligence data centers reaches unprecedented heights as major cloud service providers scramble to secure next-generation architecture allocations. Supply chain checks and channel partner feedback indicate robust, widespread enterprise adoption across multiple core sectors, cementing hardware dominance. Wall Street sentiment remains overwhelmingly bullish as order books stretch far into upcoming fiscal quarters.", 1, "NVIDIA Leads Tech Surge as AI Infrastructure Demand Accelerates", "Financial Times" },
                    { 2, "A surprise efficiency breakthrough from AI upstart DeepSeek sends massive shockwaves through global equity markets, triggering a historic single-day plunge for semiconductor stocks. Panicked investors rush to exit positions, questioning whether low-cost training methods could upend traditional hardware spending cycles. Wall Street analysts scramble to evaluate the true medium-term impact as trading volumes spike to record levels.", 2, "DeepSeek Shockwave Triggers Historic Tech Sell-Off Across Wall Street", "Bloomberg" },
                    { 3, "Chief Executive Officer Jensen Huang showcases staggering quantum leaps in raw processing power, thermal management, and energy efficiency during the highly anticipated annual developer conference keynote. The landmark hardware and software integration announcement solidifies the company's unassailable technological moat against emerging hardware competitors, driving immediate enthusiasm across institutional portfolios.", 3, "NVIDIA Unveils Breakthrough Next-Gen Architecture at Global Tech Keynote", "Reuters" },
                    { 4, "Quarterly financial results shatter Wall Street consensus estimates, driven by relentless, compounding data center infrastructure expansion globally. Gross margins remain exceptionally resilient at over seventy percent, successfully easing previous market anxieties regarding potential supply chain cost pressures and component manufacturing bottlenecks.", 4, "Q1 Earnings Blowout: NVIDIA Smashes Consensus Estimates and Raises Guidance", "Wall Street Journal" },
                    { 5, "Advanced packaging constraints and substrate limitations show concrete signs of easing as key foundry partners successfully ramp up specialized packaging capacity. Industry insiders and supply chain auditors report significantly improved wafer output heading into the crucial second-half production cycle, clearing the path for uninterrupted client deliveries.", 5, "Navigating Chip Yields: NVIDIA Partners Overcome Packaging Bottlenecks", "CNBC" },
                    { 6, "NVIDIA delivers yet another blockbuster quarterly earnings report, posting staggering year-over-year revenue growth that leaves market skeptics behind. Emerging international initiatives and enterprise sovereign data center builds rapidly expand past traditional tech sectors to become major new revenue growth verticals.", 6, "Record-Breaking Q2 Revenue Confirms Unstoppable AI Supercycle Momentum", "Financial Times" },
                    { 7, "A landmark multi-billion dollar infrastructure deployment agreement is officially signed to integrate hundreds of thousands of new accelerated computing nodes globally. This expanded partnership highlights the deep, sticky enterprise ecosystem lock-in maintained through proprietary CUDA software development frameworks and integrated networking suites.", 7, "Major Cloud Giant Expands Strategic AI Partnership with NVIDIA Ecosystem", "Bloomberg" },
                    { 8, "Despite lingering macroeconomic uncertainties and shifting interest rate environments, institutional demand for high-performance AI compute infrastructure demonstrates zero signs of fatigue. Executive management highlights accelerating deployment timelines and expanding cluster sizes among tier-one cloud service providers worldwide.", 8, "Q3 Earnings Show Stabilizing Margins and Exceptional Free Cash Flow Generation", "Reuters" },
                    { 9, "Updated international regulatory frameworks and shifting trade policies prompt minor, temporary adjustments to global shipping channels and compliance verification protocols. Senior market analysts view the financial impact as entirely manageable within existing forward-looking revenue forecasts and institutional models.", 9, "Export Control Headwinds Pose Brief Compliance Challenges for Tech Giants", "Wall Street Journal" },
                    { 10, "As the calendar turns, market analysts reflect on a truly transformative twelve months defined by market leadership, aggressive software ecosystem expansion, and unmatched hardware performance benchmarks. The company enters the upcoming fiscal period positioned firmly at the center of the global digital infrastructure revolution.", 10, "NVIDIA Closes Out Milestone Year Solidifying Dominance in Accelerated Computing", "CNBC" },
                    { 11, "Oracle's latest operational metrics highlight rapid adoption of Oracle Cloud Infrastructure (OCI) as major enterprise clients transition mission-critical database workloads. Industry analysts point to competitive pricing and high-performance cluster flexibility as key drivers pulling large-scale workloads away from legacy competitors.", 11, "OCI Growth Metrics Show Accelerating Enterprise Migration", "Financial Times" },
                    { 12, "Oracle announces a major expansion of its multi-cloud database interoperability framework, allowing seamless cross-platform data management for corporate clients. The strategic initiative drastically reduces latency for joint enterprise accounts and drives immediate positive reactions across institutional portfolios.", 12, "Landmark Multi-Cloud Database Partnership Expands Reach", "Bloomberg" },
                    { 13, "Quarterly financial disclosures showcase an extraordinary expansion in Oracle's remaining performance obligations. Total cloud contract backlogs skyrocket past major milestones as heavy-hitting corporate clients lock in long-term infrastructure commitments.", 13, "Q3 Fiscal Earnings Reveal Surging Cloud Backlog and RPO", "Wall Street Journal" },
                    { 14, "Oracle accelerates the rollout of native generative AI agents across its Fusion and NetSuite enterprise application suites. The new capabilities streamline complex enterprise resource planning workflows, successfully winning over legacy on-premise holdouts at a rapid pace.", 14, "Enterprise AI Integration Expansion Gains Broad Momentum", "CNBC" },
                    { 15, "Oracle delivers blockbuster full-year financial results, officially cementing its transition into a dominant cloud infrastructure leader. Total cloud revenues post stellar year-over-year growth, driven heavily by compounding OCI consumption rates and expanding operating margins.", 15, "Q4 Fiscal Year Financial Results Confirm Cloud Transformation", "Financial Times" },
                    { 16, "Management details a heavy capital expenditure roadmap to construct dozens of specialized cloud data centers worldwide to meet surging AI cluster demand. Executives emphasize that nearly every new facility is pre-backed by firm customer commitments, de-risking the infrastructure build-out.", 16, "Massive Data Center Expansion CapEx Roadmap Announced", "Reuters" },
                    { 17, "First-quarter earnings reports beat Wall Street consensus estimates as cloud gross margins demonstrate solid stability. Management highlights robust multi-tenant workload growth and strong free cash flow conversion across core operating segments.", 17, "Q1 Fiscal Earnings Highlight Strong Margin Expansion and OCI Demand", "Wall Street Journal" },
                    { 18, "Oracle scores a landmark high-security cloud deployment contract with public sector and defense agencies. The dedicated sovereign cloud win establishes a highly lucrative, sticky revenue vertical that remains fully insulated from broader macroeconomic shifts.", 18, "Major Government and Defense Cloud Contract Secured", "Bloomberg" },
                    { 19, "Second-quarter results demonstrate accelerating top-line growth driven by exceptional OCI consumption figures and database license conversions. Wall Street equity analysts quickly adjust forward targets to reflect compounding multi-year tailwinds.", 19, "Q2 Fiscal Earnings Showcase Rapid Revenue Acceleration", "CNBC" },
                    { 20, "At the annual technology summit, executive leadership unveils an aggressive roadmap focused on autonomous database automation and hyperscale expansion. Institutional investors respond enthusiastically to management's long-term scaling targets.", 20, "Annual Tech Summit Outlines Bold Strategic Outlook", "Financial Times" },
                    { 21, "Eli Lilly kicks off the year by doubling prior-year profits, fueled by skyrocketing global demand for Mounjaro and Zepbound. Management issues an aggressive full-year outlook, though some profit-taking occurs as investors price in high valuation multiples.", 21, "Eli Lilly Reports Strong Q4 Results and Robust 2025 Guidance", "Wall Street Journal" },
                    { 22, "The company announces major progress in alleviating weight-loss drug shortages with expanded packaging and production lines. Market participants react favorably to the improved distribution capacity, securing steady upward momentum.", 22, "Zepbound Supply Chain Expands as New Manufacturing Hubs Come Online", "Bloomberg" },
                    { 23, "Despite smashing first-quarter consensus earnings and revenue estimates behind robust Mounjaro adoption, shares dip during the session. Wall Street expresses caution following a subtle shift in profit guidance parameters and increased research spending.", 23, "Q1 Sales Surge 45%, but Profit Guidance Adjustment Sparks Pullback", "Financial Times" },
                    { 24, "Eli Lilly unveils highly anticipated clinical trial results for its once-daily oral weight-loss pill, showing competitive weight reduction metrics. The successful data reinforces confidence in the company's next-generation pipeline beyond injectable treatments.", 24, "Phase III Orforglipron Trial Data Demonstrates Strong Oral Efficacy", "Reuters" },
                    { 25, "Regulatory authorities award priority review status to Lilly's specialized treatment candidate, accelerating its path to market. Institutional buyers step in aggressively, lifting share prices across mid-summer trading sessions.", 25, "FDA Grants Fast-Track Designation to Innovative Biotech Portfolio", "CNBC" },
                    { 26, "Though second-quarter revenue spikes 38% year-over-year and EPS beats expectations, the stock suffers a severe sell-off. Disappointing concurrent clinical trial details and lower realized net prices per dose trigger immediate profit-taking and margin anxiety.", 26, "Q2 Beat Overshadowed by Mixed Clinical Data and Margin Pressures", "Wall Street Journal" },
                    { 27, "Lilly rolls out expansive direct fulfillment and tiered pricing channels to widen patient access and outpace competing formulations. The aggressive market share defense creates short-term margin uncertainty among institutional equity holders.", 27, "Zepbound Direct-to-Consumer Strategy Targets Broader Accessibility", "Bloomberg" },
                    { 28, "Eli Lilly shatters third-quarter top and bottom-line estimates, forcing Wall Street to aggressively revise price targets upward. Management's raised full-year guidance successfully puts prior margin worries to rest as volume growth surges.", 28, "Q3 Blowout Earnings and Guidance Hike Re-ignite Bullish Momentum", "Financial Times" },
                    { 29, "Driven by relentless blockbuster drug demand and global healthcare expansion, Lilly hits a major valuation milestone. Momentum-driven funds and institutional buyers push trading volumes to new multi-month highs ahead of year-end.", 29, "Eli Lilly Crosses Historic Market Capitalization Milestone", "CNBC" },
                    { 30, "Management concludes the year by detailing a multi-billion dollar capital expenditure program dedicated to scaling international active pharmaceutical ingredient plants. Analysts praise the disciplined long-term capacity investment.", 30, "Global Manufacturing CapEx Plan Outlines Massive Multi-Year Scale", "Reuters" },
                    { 31, "Micron begins full-volume commercial shipments of its high-bandwidth memory solution for top-tier artificial intelligence platforms. Semiconductor analysts highlight the company's energy efficiency advantage over Asian competitors as a primary driver for accelerated market share capture.", 31, "Micron Secures Key HBM3E Qualification for Next-Gen AI Accelerators", "Reuters" },
                    { 32, "Micron delivers blockbuster quarterly results, confirming its entire high-bandwidth memory allocation for the year is fully booked under firm customer contracts. Strong enterprise data center demand boosts operating income and validates the memory supercycle narrative.", 32, "Q2 Fiscal Earnings Beat Estimates as 2025 HBM Capacity Sells Out", "Wall Street Journal" },
                    { 33, "Trading sentiment turns cautious following industry reports of oversupply in standard client DRAM and NAND flash memory products. Despite strong AI tailwinds, weakness in traditional consumer hardware lines triggers a brief multi-session stock pullback.", 33, "Sluggish Consumer PC and Smartphone Demand Sparks Margin Anxiety", "Bloomberg" },
                    { 34, "Micron posts third-quarter revenue and earnings that comfortably clear Wall Street forecasts, powered by aggressive price hikes across server DRAM lines. Management raises forward guidance, demonstrating how premium AI memory shipments are structurally expanding profitability.", 34, "Q3 Earnings Blowout Driven by Massive Gross Margin Expansion", "Financial Times" },
                    { 35, "Federal incentives and state subsidies accelerate construction on high-volume memory fabrication plants in the United States. The strategic infrastructure milestone de-risks long-term supply chains for domestic defense and commercial technology partners.", 35, "Micron Breaks Ground on Advanced Domestic Manufacturing Expansion", "CNBC" },
                    { 36, "Closing out its fiscal year, Micron reports massive year-over-year revenue expansion driven by relentless data center upgrades. The executive team emphasizes that supply constraints will persist into the coming year, securing favorable pricing power.", 36, "Q4 Financial Results Confirm Monumental Turnaround in Memory Market", "Wall Street Journal" },
                    { 37, "Updated international trade parameters introduce licensing requirements for advanced memory shipments to certain overseas markets. Investors briefly panic over potential order cancellations, but analysts categorize the dip as short-term policy noise.", 37, "Export Control Policy Revisions Trigger Administrative Headwinds", "Reuters" },
                    { 38, "Engineering updates reveal early delivery of custom HBM4 memory stacks to key hyper-scaler partners. The technological leap promises unprecedented data transfer rates while further widening Micron's power-efficiency lead in high-performance computing.", 38, "Micron Begins Customer Sampling of Next-Generation HBM4 Architecture", "Bloomberg" },
                    { 39, "Micron kicks off its new fiscal year with stellar top and bottom-line beats, propelled by multi-year cloud customer commitments. Aggressive target price upgrades sweep across equity research desks as forward estimates are recalibrated upward.", 39, "Q1 Fiscal 2026 Earnings Shatter Expectations With Record Guidance", "Financial Times" },
                    { 40, "Data center operators rush to secure high-capacity NAND storage solutions alongside DRAM allocations ahead of annual budget closes. High institutional volume pushes shares toward session highs to close out the calendar year.", 40, "Enterprise SSD Demand Surges to Cap Off a Record-Breaking Year", "CNBC" },
                    { 41, "ExxonMobil kicks off the year by posting solid annual earnings supported by multi-decade high production volumes across advantaged assets. Management highlights aggressive structural cost savings and disciplined capital allocation, though weaker crude realizations create mild headwinds.", 41, "ExxonMobil Reports Strong Full-Year Results and Record Production", "Wall Street Journal" },
                    { 42, "Operational updates confirm that low-cost production in the Permian and Guyana continues to exceed internal efficiency projections. Energy analysts praise the high-return asset mix for structurally lowering the company's overall breakeven cost per barrel.", 42, "Permian Basin and Guyana Operations Drive Upstream Output Growth", "Reuters" },
                    { 43, "Despite robust operational output, first-quarter earnings face downward pressure from declining international oil prices. Short-term profit-taking enters the stock as investors digest lower upstream margins across global segments.", 43, "Q1 Earnings Dip Amid Softening Global Crude Realizations", "Financial Times" },
                    { 44, "ExxonMobil details progress on its commercial-scale lithium extraction and carbon capture infrastructure projects aimed at diversifying future revenue streams. Long-term investors react favorably to the energy transition strategy.", 44, "Low-Carbon Solutions and Lithium Development Initiative Gains Traction", "Bloomberg" },
                    { 45, "Second-quarter financial disclosures clear consensus forecasts as ongoing structural cost efficiencies offset bottom-of-cycle chemical and refining margins. Cash flow generation remains robust, fueling steady share repurchases.", 45, "Q2 Earnings Beat Estimates Driven by Structural Cost Reductions", "Wall Street Journal" },
                    { 46, "The massive Yellowtail deepwater development in Guyana achieves first oil months ahead of target timelines and under budget. Institutional accumulation accelerates as offshore production milestones reinforce long-term earnings visibility.", 46, "Guyana Yellowtail Project Starts Up Ahead of Schedule", "Reuters" },
                    { 47, "ExxonMobil posts solid third-quarter results, generating billions in free cash flow while keeping debt-to-capital ratios near industry-leading lows. Management reiterates commitment to its aggressive annual shareholder distribution targets.", 47, "Q3 Earnings Release Highlights Resilient Cash Flow and Share Buybacks", "CNBC" },
                    { 48, "The corporation declares its latest quarterly dividend hike, extending its multi-decade streak of consecutive annual dividend growth. Income-focused institutional funds step up equity accumulation following the announcement.", 48, "Annual Dividend Increase Confirms Long-Term Shareholder Commitment", "Financial Times" },
                    { 49, "Global refining facilities achieve record utilization rates and higher distillate yields following successful upgrade projects. Strong diesel and gasoline crack spreads boost downstream earnings contributions.", 49, "Refinery Throughput Reach Record Levels to Close Out Fourth Quarter", "Bloomberg" },
                    { 50, "As the calendar year concludes, ExxonMobil confirms annual net production hits its highest level in over 40 years. Analysts commend the disciplined execution of core capital projects heading into the new cycle.", 50, "Year-End Portfolio Review Highlights Multidecade Production Peak", "Wall Street Journal" },
                    { 51, "Tesla releases its full-year and fourth-quarter delivery metrics, showcasing resilient global demand amidst macroeconomic headwinds. Wall Street analysts evaluate the figures against intensifying EV competition in international markets.", 51, "Tesla Announces Q4 Production and Delivery Figures for 2024", "Wall Street Journal" },
                    { 52, "During a strategic update, executive leadership outlines manufacturing innovations designed to slash production costs and accelerate the rollout of lower-priced mass-market electric vehicles. Investors respond favorably to the long-term margin preservation strategy.", 52, "Management Details Next-Gen Platform and Production Cost Cuts", "Reuters" },
                    { 53, "Tesla posts a sequential drop in quarterly vehicle deliveries, impacted by factory upgrades and supply chain adjustments. Shares experience a sharp intraday pullback as analysts express near-term anxiety over shrinking automotive gross margins.", 53, "First-Quarter Deliveries Fall Short of Consensus Expectations", "Bloomberg" },
                    { 54, "Latest telemetry and subscription metrics indicate growing consumer uptake of Full Self-Driving capabilities. Software-driven revenue streams begin providing a stabilizing counterweight to fluctuating hardware margins.", 54, "FSD Adoption Rates Climb as Software Updates Expand Capabilities", "CNBC" },
                    { 55, "Second-quarter operational updates beat consensus estimates, driven by a solid recovery in vehicle deliveries and an all-time high deployment of Megapack energy storage systems. Market sentiment shifts toward renewed optimism.", 55, "Q2 Deliveries Rebound Strongly Accompanied by Record Energy Storage", "Financial Times" },
                    { 56, "Tesla expands autonomous ride-hailing pilot tests across key metropolitan zones. While tech optimists praise the scaling timeline, regulators demand rigorous safety compliance data, triggering short-term caution among institutional holders.", 56, "Robotaxi Testing Progresses Amid Growing Regulatory Scrutiny", "Wall Street Journal" },
                    { 57, "Tesla delivers a strong third-quarter financial report, boosted by a rush of buyers securing vehicles prior to pending regulatory subsidy expirations. Operating cash flows remain robust despite pricing adjustments.", 57, "Q3 Earnings Beat Expectations Ahead of EV Tax Credit Expiration", "Reuters" },
                    { 58, "The energy division scales manufacturing lines to fulfill multi-gigawatt orders for utility-scale battery installations. Analysts highlight energy storage as Tesla's fastest-growing margin catalyst outside of automotive sales.", 58, "Megafactory Output Expands to Meet Surging Global Grid Storage Demand", "Bloomberg" },
                    { 59, "Quarterly disclosures show a temporary contraction in zero-emission regulatory credit sales to rival automakers. Equity researchers adjust near-term earnings targets to account for the shifting legislative landscape.", 59, "Regulatory Credit Revenue Fluctuations Trigger Mixed Analyst Reactions", "Financial Times" },
                    { 60, "As the year closes, Tesla executes an aggressive end-of-quarter delivery wave. Institutional accumulation stabilizes share prices as the market turns its focus toward autonomous driving catalysts for the upcoming period.", 60, "Year-End Push Solidifies Annual Delivery and Energy Deployment Totals", "CNBC" },
                    { 61, "Rocket Lab posts impressive fourth-quarter financial results driven by accelerated Space Systems manufacturing and rapid Electron launch scheduling. Executive leadership outlines an expanding total backlog, reinforcing institutional confidence.", 61, "Rocket Lab Delivers Strong Q4 Financials and Broadens Launch Backlog", "Wall Street Journal" },
                    { 62, "Rocket Lab secures additional hypersonic test launches under its HASTE suborbital program, demonstrating unrivaled mission flexibility. Commercial and defense clients continue to line up for dedicated orbital deployments.", 62, "Electron Launch Frequency Reaches Historic High Following HASTE Win", "Reuters" },
                    { 63, "First-quarter revenue clears analyst consensus estimates as satellite component manufacturing outpaces launch services growth. Gross margins improve across high-value defense subcontracts.", 63, "Q1 Financial Results Highlight Accelerating Space Systems Growth", "Bloomberg" },
                    { 64, "Engineers successfully complete full-duration hot-fire testing for the medium-lift Neutron rocket engine in Virginia. Wall Street reacts enthusiastically to reduced technological risks on the path to orbital debut.", 64, "Neutron Archimedes Engine Testing Achieves Key Qualification Milestone", "CNBC" },
                    { 65, "Rocket Lab lands a lucrative prime contract with defense agencies to manufacture next-generation satellite buses for national security constellations. The award cements the company's status as a premier defense contractor.", 65, "Space Development Agency Awards Major Satellite Bus Manufacturing Deal", "Financial Times" },
                    { 66, "Second-quarter results demonstrate compounding revenue growth led by expanding constellation contracts. Management confirms steady progress across launch complex construction and automated fabrication facilities.", 66, "Q2 Earnings Surpass Target Margins as Order Backlog Hits Record", "Wall Street Journal" },
                    { 67, "Engineering disclosures reveal minor structural adjustments required following stage 1 pressure testing for Neutron. Share prices experience a brief pullback as traders re-evaluate capital expenditure timelines.", 67, "Stage Structural Testing Discrepancy Causes Brief Neutron Schedule Shift", "Reuters" },
                    { 68, "Third-quarter disclosures highlight record Electron launch cadence alongside expanding satellite assembly operations. Management outlines a clear path toward sustainable free cash flow generation.", 68, "Q3 Revenue Spikes Driven by Commercial Constellation Deployments", "Bloomberg" },
                    { 69, "Federal defense officials award a dedicated rapid-callout launch contract on Electron. The high-margin defense mission highlights Rocket Lab's ability to execute precision orbital inserts on short notice.", 69, "U.S. Space Force Selects Rocket Lab for Responsive Orbital Mission", "CNBC" },
                    { 70, "Closing out a transformative operational year, Rocket Lab sets a company record for total orbital launches completed in a single calendar year. Analysts commend management's disciplined balance sheet strategy.", 70, "Year-End Review Highlights Record Electron Launches and Historic Backlog", "Financial Times" },
                    { 71, "Vertiv reports strong fourth-quarter financial metrics, highlighting an unprecedented surge in orders for its thermal management and power infrastructure systems. Wall Street rewards the execution speed as backlogs expand rapidly.", 71, "Vertiv Posts Blockbuster Q4 Results Driven by AI Cooling Demand", "Wall Street Journal" },
                    { 72, "The company unveils next-generation thermal management architectures tailored for ultra-dense artificial intelligence clusters. Major data center operators adopt Vertiv's systems to mitigate high thermal dissipation challenges.", 72, "Direct-to-Chip Liquid Cooling Solutions Gain Industry-Wide Traction", "Reuters" },
                    { 73, "First-quarter revenue and earnings comfortably exceed consensus estimates, powered by favorable pricing power and streamlined manufacturing output. Operating margins climb to new multi-year highs.", 73, "Q1 Financial Results Demonstrate Substantial Margin Improvement", "Bloomberg" },
                    { 74, "Vertiv partners with major electrical equipment providers to deliver integrated power distribution units and backup systems for massive AI data centers. Institutional investors view the alliance as a strong competitive moat.", 74, "Strategic Alliance Announced to Support Hyperscale AI Power Grids", "Financial Times" },
                    { 75, "Second-quarter performance crushes expectations, prompting executive management to raise full-year revenue and free cash flow guidance. Strong conversion metrics drive heavy institutional buying volume.", 75, "Q2 Earnings Beat Triggers Upward Revision of Full-Year Outlook", "CNBC" },
                    { 76, "Vertiv details a multi-million-dollar factory expansion plan across North America and Europe to shorten delivery lead times for critical infrastructure hardware. Analysts praise the proactive capacity scaling.", 76, "Global Manufacturing Footprint Expands to Alleviate Delivery Backlogs", "Wall Street Journal" },
                    { 77, "Third-quarter disclosures reveal record-breaking order intake figures as data center operators rush to lock in thermal capacity. Net income scales significantly faster than top-line revenue growth.", 77, "Q3 Earnings Show Record Order Intake and Expanding Profitability", "Reuters" },
                    { 78, "Supply chain optimizations allow Vertiv to accelerate project delivery schedules for major hyperscale clients. The operational agility strengthens customer retention and market dominance.", 78, "Operational Efficiencies Successfully Lower Customer Delivery Lead Times", "Bloomberg" },
                    { 79, "Vertiv rolls out innovative switchgear and busbar solutions designed to handle massive electrical loads required by modern GPU racks. Industry reports validate the technological leap.", 79, "Next-Generation High-Density Power Management System Unveiled", "Financial Times" },
                    { 80, "Closing out a stellar operational year, leadership presents a bullish long-term financial framework at the annual investor summit. Analysts adjust price targets upward to account for enduring structural demand.", 80, "Year-End Summit Outlines Aggressive Multi-Year Margin Targets", "CNBC" },
                    { 81, "Celsius posts solid fourth-quarter revenue growth, driven by deep penetration into mainstream grocery and fitness channels. Management emphasizes efficient inventory management across domestic distribution networks.", 81, "Celsius Holdings Reports Strong Q4 Financials and Expanding Retail Footprint", "Wall Street Journal" },
                    { 82, "The amino-infused Celsius Essentials product line rolls out successfully to specialized fitness centers and gym chains. Consumer response exceeds initial internal forecasts, boosting short-term shipment volumes.", 82, "Celsius Essentials Line Gains Rapid Traction Across Fitness Centers", "Reuters" },
                    { 83, "First-quarter earnings comfortably clear consensus expectations as market share within the functional energy category expands. Gross profit margins demonstrate solid resilience against input cost pressures.", 83, "Q1 Financial Results Beat Estimates on Strong Domestic Scan Data", "Bloomberg" },
                    { 84, "Celsius expands its distribution footprint across the UK, France, and Benelux regions through strategic retail partnerships. International revenue segments post double-digit percentage gains year-over-year.", 84, "International Expansion Accelerates Into Key European Retail Markets", "Financial Times" },
                    { 85, "Second-quarter results crush Wall Street projections, propelled by robust seasonal demand and optimized distribution networks. Institutional investors respond favorably to expanding operating leverage.", 85, "Q2 Earnings Disclosures Highlight Record Revenue and Portfolio Synergy", "CNBC" },
                    { 86, "Retailers report high consumer engagement with newly introduced seasonal flavor variations and targeted digital marketing campaigns. Shelf-space allocations increase across major convenience store chains.", 86, "Fall Promotional Campaign and New Flavor Lineup Drive Store Traffic", "Wall Street Journal" },
                    { 87, "Third-quarter financial reports indicate stable revenue expansion despite aggressive promotional discounting by legacy beverage competitors. Direct-store-delivery logistics demonstrate notable cost improvements.", 87, "Q3 Earnings Show Resilient Top-Line Growth Amid Category Competition", "Reuters" },
                    { 88, "Wholesale club partnerships and bulk packaging formats drive steady volume gains. Analysts highlight the multi-channel diversification as a key driver for long-term brand durability.", 88, "Club Store and Foodservice Channels Deliver Accelerated Volume Growth", "Bloomberg" },
                    { 89, "Celsius broadens its non-carbonated wellness portfolio with zero-sugar electrolyte powder sticks. The new product line targets health-conscious consumers seeking functional hydration options.", 89, "Hydration Powder Sticks Roll Out to Capture Wellness Segment", "Financial Times" },
                    { 90, "Closing out the calendar year, comprehensive retail scan data confirms Celsius maintains its standing as a dominant high-growth energy brand. Analysts praise the disciplined brand management strategy.", 90, "Year-End Retail Data Confirms Solid Category Share Retention", "CNBC" },
                    { 91, "U.S. macroeconomic data confirms resilient economic growth heading into the new year, supporting strong corporate fundamentals across the 500 index constituents tracked by institutional passive funds.", 91, "S&P 500 Index Kicks Off Year Following Robust Q4 GDP Expansion", "Wall Street Journal" },
                    { 92, "Central bank commentary regarding interest rate trajectories introduces short-term friction across major large-cap sectors, resulting in a healthy consolidation phase for index tracking funds.", 92, "Federal Reserve Signaling Triggers Broad Equity Market Volatility", "Reuters" },
                    { 93, "First-quarter reporting season demonstrates broad-based profitability expansion, led by technology and financial heavyweights. Passive inflows into broad-market index funds remain exceptionally high.", 93, "Q1 Composite Earnings Beat Consensus Estimates Across Index Sectors", "Bloomberg" },
                    { 94, "Favorable consumer price index updates prompt institutional asset managers to reallocate capital across lagging sectors, broadening market participation beyond mega-cap technology issues.", 94, "Cooling Inflation Metrics Fuel Sector Rotation into Cyclical Equities", "Financial Times" },
                    { 95, "Strong corporate performance reports reinforce a fundamentals-driven market expansion. Total index returns climb steadily as earnings-per-share metrics beat top-down consensus forecasts.", 95, "Q2 Earnings Results Push S&P 500 Benchmark to New Milestones", "CNBC" },
                    { 96, "Global investors closely analyze central bank policy speeches for clues on future monetary easing cycles. Broad equity indices experience mild intraday swings before stabilizing near key technical supports.", 96, "Jackson Hole Commentary Sparks Brief Macroeconomic Re-Pricing", "Wall Street Journal" },
                    { 97, "Third-quarter corporate scorecards validate the resilience of the broader U.S. economy. Heavy institutional accumulation flows directly into low-cost accumulation ETFs like VUAA.", 97, "Q3 Composite Earnings Season Exceeds Expectations Led by Mega-Caps", "Reuters" },
                    { 98, "Shifting sovereign debt yields create temporary headwinds for equity valuations, though dip-buyers quickly step in to support core large-cap components.", 98, "Treasury Yield Fluctuations Prompt Short-Term Cross-Asset Adjustments", "Bloomberg" },
                    { 99, "The Federal Reserve implements a widely anticipated monetary policy adjustment, sparking a broad-based equity rally as institutional portfolios position for the new year.", 99, "FOMC Rate Cut Decision Catalyzes Year-End Market Rally", "Financial Times" },
                    { 100, "Closing out the calendar year, the S&P 500 records another stellar annual total return. Low-cost passive funds register record-breaking net asset inflows from global investors.", 100, "Year-End Index Review Confirms Another Banner Year for U.S. Equities", "CNBC" }
                });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "EventId", "IsBullishVolume", "PriceValue", "Volume" },
                values: new object[,]
                {
                    { 1, 1, false, 136.24m, 185217300L },
                    { 2, 2, false, 118.42m, 200000000L },
                    { 3, 3, false, 115.50m, 299686900L },
                    { 4, 4, false, 132.83m, 187344000L },
                    { 5, 5, false, 164.10m, 167704100L },
                    { 6, 6, false, 181.60m, 235518900L },
                    { 7, 7, false, 185.54m, 157678100L },
                    { 8, 8, false, 180.64m, 343504800L },
                    { 9, 9, false, 175.02m, 204274900L },
                    { 10, 10, false, 187.54m, 97687300L },
                    { 11, 11, false, 172.57m, 30232000L },
                    { 12, 12, false, 174.16m, 7260900L },
                    { 13, 13, false, 148.79m, 21486100L },
                    { 14, 14, false, 127.24m, 11233700L },
                    { 15, 15, false, 211.10m, 22665300L },
                    { 16, 16, false, 245.12m, 7149600L },
                    { 17, 17, false, 307.86m, 69986000L },
                    { 18, 18, false, 277.18m, 32810700L },
                    { 19, 19, false, 220.54m, 24711200L },
                    { 20, 20, false, 195.38m, 14748100L },
                    { 21, 21, false, 842.18m, 4578900L },
                    { 22, 22, false, 822.51m, 2354900L },
                    { 23, 23, false, 898.95m, 4374100L },
                    { 24, 24, false, 812.03m, 2271100L },
                    { 25, 25, false, 771.75m, 4174100L },
                    { 26, 26, false, 640.86m, 26101600L },
                    { 27, 27, false, 764.71m, 3881300L },
                    { 28, 28, false, 844.50m, 6037200L },
                    { 29, 29, false, 1059.70m, 4266700L },
                    { 30, 30, false, 1041.79m, 3726600L },
                    { 31, 31, false, 103.19m, 27568100L },
                    { 32, 32, false, 102.06m, 16633100L },
                    { 33, 33, false, 96.93m, 28009100L },
                    { 34, 34, false, 127.25m, 39407000L },
                    { 35, 35, false, 109.22m, 27917600L },
                    { 36, 36, false, 161.71m, 57096400L },
                    { 37, 37, false, 221.91m, 14957500L },
                    { 38, 38, false, 228.50m, 33843900L },
                    { 39, 39, false, 225.52m, 41957100L },
                    { 40, 40, false, 294.37m, 26642900L },
                    { 41, 41, false, 106.83m, 20376500L },
                    { 42, 42, false, 115.41m, 17315000L },
                    { 43, 43, false, 105.63m, 20379300L },
                    { 44, 44, false, 107.22m, 17634800L },
                    { 45, 45, false, 111.90m, 12996900L },
                    { 46, 46, false, 114.68m, 17208000L },
                    { 47, 47, false, 114.36m, 20213400L },
                    { 48, 48, false, 117.35m, 15919200L },
                    { 49, 49, false, 119.54m, 19845200L },
                    { 50, 50, false, 120.53m, 14782500L },
                    { 51, 51, false, 379.28m, 109710700L },
                    { 52, 52, false, 290.80m, 100118300L },
                    { 53, 53, false, 282.76m, 212787800L },
                    { 54, 54, false, 347.68m, 136997300L },
                    { 55, 55, false, 315.65m, 119483700L },
                    { 56, 56, false, 323.90m, 77481800L },
                    { 57, 57, false, 438.97m, 84023500L },
                    { 58, 58, false, 430.60m, 58513500L },
                    { 59, 59, false, 446.74m, 87483000L },
                    { 60, 60, false, 459.64m, 66263000L },
                    { 61, 61, false, 21.25m, 16325100L },
                    { 62, 62, false, 18.78m, 12096300L },
                    { 63, 63, false, 22.29m, 7727300L },
                    { 64, 64, false, 27.85m, 18457700L },
                    { 65, 65, false, 47.69m, 26692300L },
                    { 66, 66, false, 44.21m, 21522100L },
                    { 67, 67, false, 48.69m, 30681600L },
                    { 68, 68, false, 49.97m, 21987100L },
                    { 69, 69, false, 57.52m, 38839900L },
                    { 70, 70, false, 70.12m, 18294100L },
                    { 71, 71, false, 107.84m, 5945000L },
                    { 72, 72, false, 81.62m, 1895700L },
                    { 73, 73, false, 78.00m, 24253700L },
                    { 74, 74, false, 112.85m, 5005700L },
                    { 75, 75, false, 130.19m, 6072900L },
                    { 76, 76, false, 136.74m, 12971100L },
                    { 77, 77, false, 171.59m, 22483700L },
                    { 78, 78, false, 170.65m, 6070500L },
                    { 79, 79, false, 181.82m, 5301300L },
                    { 80, 80, false, 165.62m, 3075200L },
                    { 81, 81, false, 27.21m, 9288900L },
                    { 82, 82, false, 34.90m, 9496100L },
                    { 83, 83, false, 35.79m, 6893300L },
                    { 84, 84, false, 44.07m, 6733300L },
                    { 85, 85, false, 42.74m, 12816500L },
                    { 86, 86, false, 56.34m, 4954800L },
                    { 87, 87, false, 59.92m, 6614700L },
                    { 88, 88, false, 40.78m, 5327200L },
                    { 89, 89, false, 44.28m, 4417700L },
                    { 90, 90, false, 46.44m, 3964900L },
                    { 91, 91, false, 110.33m, 70543L },
                    { 92, 92, false, 99.17m, 65788L },
                    { 93, 93, false, 90.55m, 60384L },
                    { 94, 94, false, 100.68m, 40398L },
                    { 95, 95, false, 103.24m, 43012L },
                    { 96, 96, false, 104.77m, 26286L },
                    { 97, 97, false, 110.64m, 23937L },
                    { 98, 98, false, 110.23m, 37378L },
                    { 99, 99, false, 112.93m, 34374L },
                    { 100, 100, false, 112.79m, 18407L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Analyses",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
