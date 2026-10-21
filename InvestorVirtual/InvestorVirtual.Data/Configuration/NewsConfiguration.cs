namespace InvestorVirtual.Data.Configuration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Models;

public class NewsConfiguration : IEntityTypeConfiguration<News>
{
    public static readonly IEnumerable<News> NewsItems = new List<News>
    {
        // News configuration for Nvidia events
        new ()
        {
            Id = 1,
            Headline = "NVIDIA Leads Tech Surge as AI Infrastructure Demand Accelerates",
            Body = "Enterprise spending on artificial intelligence data centers reaches unprecedented heights as major cloud service providers scramble to secure next-generation architecture allocations. Supply chain checks and channel partner feedback indicate robust, widespread enterprise adoption across multiple core sectors, cementing hardware dominance. Wall Street sentiment remains overwhelmingly bullish as order books stretch far into upcoming fiscal quarters.",
            Source = "Financial Times",
            EventId = 1
        },
        new ()
        {
            Id = 2,
            Headline = "DeepSeek Shockwave Triggers Historic Tech Sell-Off Across Wall Street",
            Body = "A surprise efficiency breakthrough from AI upstart DeepSeek sends massive shockwaves through global equity markets, triggering a historic single-day plunge for semiconductor stocks. Panicked investors rush to exit positions, questioning whether low-cost training methods could upend traditional hardware spending cycles. Wall Street analysts scramble to evaluate the true medium-term impact as trading volumes spike to record levels.",
            Source = "Bloomberg",
            EventId = 2
        },
        new ()
        {
            Id = 3,
            Headline = "NVIDIA Unveils Breakthrough Next-Gen Architecture at Global Tech Keynote",
            Body = "Chief Executive Officer Jensen Huang showcases staggering quantum leaps in raw processing power, thermal management, and energy efficiency during the highly anticipated annual developer conference keynote. The landmark hardware and software integration announcement solidifies the company's unassailable technological moat against emerging hardware competitors, driving immediate enthusiasm across institutional portfolios.",
            Source = "Reuters",
            EventId = 3
        },
        new ()
        {
            Id = 4,
            Headline = "Q1 Earnings Blowout: NVIDIA Smashes Consensus Estimates and Raises Guidance",
            Body = "Quarterly financial results shatter Wall Street consensus estimates, driven by relentless, compounding data center infrastructure expansion globally. Gross margins remain exceptionally resilient at over seventy percent, successfully easing previous market anxieties regarding potential supply chain cost pressures and component manufacturing bottlenecks.",
            Source = "Wall Street Journal",
            EventId = 4
        },
        new ()
        {
            Id = 5,
            Headline = "Navigating Chip Yields: NVIDIA Partners Overcome Packaging Bottlenecks",
            Body = "Advanced packaging constraints and substrate limitations show concrete signs of easing as key foundry partners successfully ramp up specialized packaging capacity. Industry insiders and supply chain auditors report significantly improved wafer output heading into the crucial second-half production cycle, clearing the path for uninterrupted client deliveries.",
            Source = "CNBC",
            EventId = 5
        },
        new ()
        {
            Id = 6,
            Headline = "Record-Breaking Q2 Revenue Confirms Unstoppable AI Supercycle Momentum",
            Body = "NVIDIA delivers yet another blockbuster quarterly earnings report, posting staggering year-over-year revenue growth that leaves market skeptics behind. Emerging international initiatives and enterprise sovereign data center builds rapidly expand past traditional tech sectors to become major new revenue growth verticals.",
            Source = "Financial Times",
            EventId = 6
        },
        new ()
        {
            Id = 7,
            Headline = "Major Cloud Giant Expands Strategic AI Partnership with NVIDIA Ecosystem",
            Body = "A landmark multi-billion dollar infrastructure deployment agreement is officially signed to integrate hundreds of thousands of new accelerated computing nodes globally. This expanded partnership highlights the deep, sticky enterprise ecosystem lock-in maintained through proprietary CUDA software development frameworks and integrated networking suites.",
            Source = "Bloomberg",
            EventId = 7
        },
        new ()
        {
            Id = 8,
            Headline = "Q3 Earnings Show Stabilizing Margins and Exceptional Free Cash Flow Generation",
            Body = "Despite lingering macroeconomic uncertainties and shifting interest rate environments, institutional demand for high-performance AI compute infrastructure demonstrates zero signs of fatigue. Executive management highlights accelerating deployment timelines and expanding cluster sizes among tier-one cloud service providers worldwide.",
            Source = "Reuters",
            EventId = 8
        },
        new ()
        {
            Id = 9,
            Headline = "Export Control Headwinds Pose Brief Compliance Challenges for Tech Giants",
            Body = "Updated international regulatory frameworks and shifting trade policies prompt minor, temporary adjustments to global shipping channels and compliance verification protocols. Senior market analysts view the financial impact as entirely manageable within existing forward-looking revenue forecasts and institutional models.",
            Source = "Wall Street Journal",
            EventId = 9
        },
        new ()
        {
            Id = 10,
            Headline = "NVIDIA Closes Out Milestone Year Solidifying Dominance in Accelerated Computing",
            Body = "As the calendar turns, market analysts reflect on a truly transformative twelve months defined by market leadership, aggressive software ecosystem expansion, and unmatched hardware performance benchmarks. The company enters the upcoming fiscal period positioned firmly at the center of the global digital infrastructure revolution.",
            Source = "CNBC",
            EventId = 10
        },

        // News configuration for Oracle events
        new ()
        {
            Id = 11,
            Headline = "OCI Growth Metrics Show Accelerating Enterprise Migration",
            Body = "Oracle's latest operational metrics highlight rapid adoption of Oracle Cloud Infrastructure (OCI) as major enterprise clients transition mission-critical database workloads. Industry analysts point to competitive pricing and high-performance cluster flexibility as key drivers pulling large-scale workloads away from legacy competitors.",
            Source = "Financial Times",
            EventId = 11
        },
        new ()
        {
            Id = 12,
            Headline = "Landmark Multi-Cloud Database Partnership Expands Reach",
            Body = "Oracle announces a major expansion of its multi-cloud database interoperability framework, allowing seamless cross-platform data management for corporate clients. The strategic initiative drastically reduces latency for joint enterprise accounts and drives immediate positive reactions across institutional portfolios.",
            Source = "Bloomberg",
            EventId = 12
        },
        new ()
        {
            Id = 13,
            Headline = "Q3 Fiscal Earnings Reveal Surging Cloud Backlog and RPO",
            Body = "Quarterly financial disclosures showcase an extraordinary expansion in Oracle's remaining performance obligations. Total cloud contract backlogs skyrocket past major milestones as heavy-hitting corporate clients lock in long-term infrastructure commitments.",
            Source = "Wall Street Journal",
            EventId = 13
        },
        new ()
        {
            Id = 14,
            Headline = "Enterprise AI Integration Expansion Gains Broad Momentum",
            Body = "Oracle accelerates the rollout of native generative AI agents across its Fusion and NetSuite enterprise application suites. The new capabilities streamline complex enterprise resource planning workflows, successfully winning over legacy on-premise holdouts at a rapid pace.",
            Source = "CNBC",
            EventId = 14
        },
        new ()
        {
            Id = 15,
            Headline = "Q4 Fiscal Year Financial Results Confirm Cloud Transformation",
            Body = "Oracle delivers blockbuster full-year financial results, officially cementing its transition into a dominant cloud infrastructure leader. Total cloud revenues post stellar year-over-year growth, driven heavily by compounding OCI consumption rates and expanding operating margins.",
            Source = "Financial Times",
            EventId = 15
        },
        new ()
        {
            Id = 16,
            Headline = "Massive Data Center Expansion CapEx Roadmap Announced",
            Body = "Management details a heavy capital expenditure roadmap to construct dozens of specialized cloud data centers worldwide to meet surging AI cluster demand. Executives emphasize that nearly every new facility is pre-backed by firm customer commitments, de-risking the infrastructure build-out.",
            Source = "Reuters",
            EventId = 16
        },
        new ()
        {
            Id = 17,
            Headline = "Q1 Fiscal Earnings Highlight Strong Margin Expansion and OCI Demand",
            Body = "First-quarter earnings reports beat Wall Street consensus estimates as cloud gross margins demonstrate solid stability. Management highlights robust multi-tenant workload growth and strong free cash flow conversion across core operating segments.",
            Source = "Wall Street Journal",
            EventId = 17
        },
        new ()
        {
            Id = 18,
            Headline = "Major Government and Defense Cloud Contract Secured",
            Body = "Oracle scores a landmark high-security cloud deployment contract with public sector and defense agencies. The dedicated sovereign cloud win establishes a highly lucrative, sticky revenue vertical that remains fully insulated from broader macroeconomic shifts.",
            Source = "Bloomberg",
            EventId = 18
        },
        new ()
        {
            Id = 19,
            Headline = "Q2 Fiscal Earnings Showcase Rapid Revenue Acceleration",
            Body = "Second-quarter results demonstrate accelerating top-line growth driven by exceptional OCI consumption figures and database license conversions. Wall Street equity analysts quickly adjust forward targets to reflect compounding multi-year tailwinds.",
            Source = "CNBC",
            EventId = 19
        },
        new ()
        {
            Id = 20,
            Headline = "Annual Tech Summit Outlines Bold Strategic Outlook",
            Body = "At the annual technology summit, executive leadership unveils an aggressive roadmap focused on autonomous database automation and hyperscale expansion. Institutional investors respond enthusiastically to management's long-term scaling targets.",
            Source = "Financial Times",
            EventId = 20
        },

        // News configuration for Eli Lilly events
        new ()
        {
            Id = 21,
            Headline = "Eli Lilly Reports Strong Q4 Results and Robust 2025 Guidance",
            Body = "Eli Lilly kicks off the year by doubling prior-year profits, fueled by skyrocketing global demand for Mounjaro and Zepbound. Management issues an aggressive full-year outlook, though some profit-taking occurs as investors price in high valuation multiples.",
            Source = "Wall Street Journal",
            EventId = 21
        },
        new ()
        {
            Id = 22,
            Headline = "Zepbound Supply Chain Expands as New Manufacturing Hubs Come Online",
            Body = "The company announces major progress in alleviating weight-loss drug shortages with expanded packaging and production lines. Market participants react favorably to the improved distribution capacity, securing steady upward momentum.",
            Source = "Bloomberg",
            EventId = 22
        },
        new ()
        {
            Id = 23,
            Headline = "Q1 Sales Surge 45%, but Profit Guidance Adjustment Sparks Pullback",
            Body = "Despite smashing first-quarter consensus earnings and revenue estimates behind robust Mounjaro adoption, shares dip during the session. Wall Street expresses caution following a subtle shift in profit guidance parameters and increased research spending.",
            Source = "Financial Times",
            EventId = 23
        },
        new ()
        {
            Id = 24,
            Headline = "Phase III Orforglipron Trial Data Demonstrates Strong Oral Efficacy",
            Body = "Eli Lilly unveils highly anticipated clinical trial results for its once-daily oral weight-loss pill, showing competitive weight reduction metrics. The successful data reinforces confidence in the company's next-generation pipeline beyond injectable treatments.",
            Source = "Reuters",
            EventId = 24
        },
        new ()
        {
            Id = 25,
            Headline = "FDA Grants Fast-Track Designation to Innovative Biotech Portfolio",
            Body = "Regulatory authorities award priority review status to Lilly's specialized treatment candidate, accelerating its path to market. Institutional buyers step in aggressively, lifting share prices across mid-summer trading sessions.",
            Source = "CNBC",
            EventId = 25
        },
        new ()
        {
            Id = 26,
            Headline = "Q2 Beat Overshadowed by Mixed Clinical Data and Margin Pressures",
            Body = "Though second-quarter revenue spikes 38% year-over-year and EPS beats expectations, the stock suffers a severe sell-off. Disappointing concurrent clinical trial details and lower realized net prices per dose trigger immediate profit-taking and margin anxiety.",
            Source = "Wall Street Journal",
            EventId = 26
        },
        new ()
        {
            Id = 27,
            Headline = "Zepbound Direct-to-Consumer Strategy Targets Broader Accessibility",
            Body = "Lilly rolls out expansive direct fulfillment and tiered pricing channels to widen patient access and outpace competing formulations. The aggressive market share defense creates short-term margin uncertainty among institutional equity holders.",
            Source = "Bloomberg",
            EventId = 27
        },
        new ()
        {
            Id = 28,
            Headline = "Q3 Blowout Earnings and Guidance Hike Re-ignite Bullish Momentum",
            Body = "Eli Lilly shatters third-quarter top and bottom-line estimates, forcing Wall Street to aggressively revise price targets upward. Management's raised full-year guidance successfully puts prior margin worries to rest as volume growth surges.",
            Source = "Financial Times",
            EventId = 28
        },
        new ()
        {
            Id = 29,
            Headline = "Eli Lilly Crosses Historic Market Capitalization Milestone",
            Body = "Driven by relentless blockbuster drug demand and global healthcare expansion, Lilly hits a major valuation milestone. Momentum-driven funds and institutional buyers push trading volumes to new multi-month highs ahead of year-end.",
            Source = "CNBC",
            EventId = 29
        },
        new ()
        {
            Id = 30,
            Headline = "Global Manufacturing CapEx Plan Outlines Massive Multi-Year Scale",
            Body = "Management concludes the year by detailing a multi-billion dollar capital expenditure program dedicated to scaling international active pharmaceutical ingredient plants. Analysts praise the disciplined long-term capacity investment.",
            Source = "Reuters",
            EventId = 30
        },

        // News configuration for Micron events
        new ()
        {
            Id = 31,
            Headline = "Micron Secures Key HBM3E Qualification for Next-Gen AI Accelerators",
            Body = "Micron begins full-volume commercial shipments of its high-bandwidth memory solution for top-tier artificial intelligence platforms. Semiconductor analysts highlight the company's energy efficiency advantage over Asian competitors as a primary driver for accelerated market share capture.",
            Source = "Reuters",
            EventId = 31
        },
        new ()
        {
            Id = 32,
            Headline = "Q2 Fiscal Earnings Beat Estimates as 2025 HBM Capacity Sells Out",
            Body = "Micron delivers blockbuster quarterly results, confirming its entire high-bandwidth memory allocation for the year is fully booked under firm customer contracts. Strong enterprise data center demand boosts operating income and validates the memory supercycle narrative.",
            Source = "Wall Street Journal",
            EventId = 32
        },
        new ()
        {
            Id = 33,
            Headline = "Sluggish Consumer PC and Smartphone Demand Sparks Margin Anxiety",
            Body = "Trading sentiment turns cautious following industry reports of oversupply in standard client DRAM and NAND flash memory products. Despite strong AI tailwinds, weakness in traditional consumer hardware lines triggers a brief multi-session stock pullback.",
            Source = "Bloomberg",
            EventId = 33
        },
        new ()
        {
            Id = 34,
            Headline = "Q3 Earnings Blowout Driven by Massive Gross Margin Expansion",
            Body = "Micron posts third-quarter revenue and earnings that comfortably clear Wall Street forecasts, powered by aggressive price hikes across server DRAM lines. Management raises forward guidance, demonstrating how premium AI memory shipments are structurally expanding profitability.",
            Source = "Financial Times",
            EventId = 34
        },
        new ()
        {
            Id = 35,
            Headline = "Micron Breaks Ground on Advanced Domestic Manufacturing Expansion",
            Body = "Federal incentives and state subsidies accelerate construction on high-volume memory fabrication plants in the United States. The strategic infrastructure milestone de-risks long-term supply chains for domestic defense and commercial technology partners.",
            Source = "CNBC",
            EventId = 35
        },
        new ()
        {
            Id = 36,
            Headline = "Q4 Financial Results Confirm Monumental Turnaround in Memory Market",
            Body = "Closing out its fiscal year, Micron reports massive year-over-year revenue expansion driven by relentless data center upgrades. The executive team emphasizes that supply constraints will persist into the coming year, securing favorable pricing power.",
            Source = "Wall Street Journal",
            EventId = 36
        },
        new ()
        {
            Id = 37,
            Headline = "Export Control Policy Revisions Trigger Administrative Headwinds",
            Body = "Updated international trade parameters introduce licensing requirements for advanced memory shipments to certain overseas markets. Investors briefly panic over potential order cancellations, but analysts categorize the dip as short-term policy noise.",
            Source = "Reuters",
            EventId = 37
        },
        new ()
        {
            Id = 38,
            Headline = "Micron Begins Customer Sampling of Next-Generation HBM4 Architecture",
            Body = "Engineering updates reveal early delivery of custom HBM4 memory stacks to key hyper-scaler partners. The technological leap promises unprecedented data transfer rates while further widening Micron's power-efficiency lead in high-performance computing.",
            Source = "Bloomberg",
            EventId = 38
        },
        new ()
        {
            Id = 39,
            Headline = "Q1 Fiscal 2026 Earnings Shatter Expectations With Record Guidance",
            Body = "Micron kicks off its new fiscal year with stellar top and bottom-line beats, propelled by multi-year cloud customer commitments. Aggressive target price upgrades sweep across equity research desks as forward estimates are recalibrated upward.",
            Source = "Financial Times",
            EventId = 39
        },
        new ()
        {
            Id = 40,
            Headline = "Enterprise SSD Demand Surges to Cap Off a Record-Breaking Year",
            Body = "Data center operators rush to secure high-capacity NAND storage solutions alongside DRAM allocations ahead of annual budget closes. High institutional volume pushes shares toward session highs to close out the calendar year.",
            Source = "CNBC",
            EventId = 40
        },

        // News configuration for Exxonmobil events
        new ()
        {
            Id = 41,
            Headline = "ExxonMobil Reports Strong Full-Year Results and Record Production",
            Body = "ExxonMobil kicks off the year by posting solid annual earnings supported by multi-decade high production volumes across advantaged assets. Management highlights aggressive structural cost savings and disciplined capital allocation, though weaker crude realizations create mild headwinds.",
            Source = "Wall Street Journal",
            EventId = 41
        },
        new ()
        {
            Id = 42,
            Headline = "Permian Basin and Guyana Operations Drive Upstream Output Growth",
            Body = "Operational updates confirm that low-cost production in the Permian and Guyana continues to exceed internal efficiency projections. Energy analysts praise the high-return asset mix for structurally lowering the company's overall breakeven cost per barrel.",
            Source = "Reuters",
            EventId = 42
        },
        new ()
        {
            Id = 43,
            Headline = "Q1 Earnings Dip Amid Softening Global Crude Realizations",
            Body = "Despite robust operational output, first-quarter earnings face downward pressure from declining international oil prices. Short-term profit-taking enters the stock as investors digest lower upstream margins across global segments.",
            Source = "Financial Times",
            EventId = 43
        },
        new ()
        {
            Id = 44,
            Headline = "Low-Carbon Solutions and Lithium Development Initiative Gains Traction",
            Body = "ExxonMobil details progress on its commercial-scale lithium extraction and carbon capture infrastructure projects aimed at diversifying future revenue streams. Long-term investors react favorably to the energy transition strategy.",
            Source = "Bloomberg",
            EventId = 44
        },
        new ()
        {
            Id = 45,
            Headline = "Q2 Earnings Beat Estimates Driven by Structural Cost Reductions",
            Body = "Second-quarter financial disclosures clear consensus forecasts as ongoing structural cost efficiencies offset bottom-of-cycle chemical and refining margins. Cash flow generation remains robust, fueling steady share repurchases.",
            Source = "Wall Street Journal",
            EventId = 45
        },
        new ()
        {
            Id = 46,
            Headline = "Guyana Yellowtail Project Starts Up Ahead of Schedule",
            Body = "The massive Yellowtail deepwater development in Guyana achieves first oil months ahead of target timelines and under budget. Institutional accumulation accelerates as offshore production milestones reinforce long-term earnings visibility.",
            Source = "Reuters",
            EventId = 46
        },
        new ()
        {
            Id = 47,
            Headline = "Q3 Earnings Release Highlights Resilient Cash Flow and Share Buybacks",
            Body = "ExxonMobil posts solid third-quarter results, generating billions in free cash flow while keeping debt-to-capital ratios near industry-leading lows. Management reiterates commitment to its aggressive annual shareholder distribution targets.",
            Source = "CNBC",
            EventId = 47
        },
        new ()
        {
            Id = 48,
            Headline = "Annual Dividend Increase Confirms Long-Term Shareholder Commitment",
            Body = "The corporation declares its latest quarterly dividend hike, extending its multi-decade streak of consecutive annual dividend growth. Income-focused institutional funds step up equity accumulation following the announcement.",
            Source = "Financial Times",
            EventId = 48
        },
        new ()
        {
            Id = 49,
            Headline = "Refinery Throughput Reach Record Levels to Close Out Fourth Quarter",
            Body = "Global refining facilities achieve record utilization rates and higher distillate yields following successful upgrade projects. Strong diesel and gasoline crack spreads boost downstream earnings contributions.",
            Source = "Bloomberg",
            EventId = 49
        },
        new ()
        {
            Id = 50,
            Headline = "Year-End Portfolio Review Highlights Multidecade Production Peak",
            Body = "As the calendar year concludes, ExxonMobil confirms annual net production hits its highest level in over 40 years. Analysts commend the disciplined execution of core capital projects heading into the new cycle.",
            Source = "Wall Street Journal",
            EventId = 50
        },

        // News configuration for Tesla events
        new ()
        {
            Id = 51,
            Headline = "Tesla Announces Q4 Production and Delivery Figures for 2024",
            Body = "Tesla releases its full-year and fourth-quarter delivery metrics, showcasing resilient global demand amidst macroeconomic headwinds. Wall Street analysts evaluate the figures against intensifying EV competition in international markets.",
            Source = "Wall Street Journal",
            EventId = 51
        },
        new ()
        {
            Id = 52,
            Headline = "Management Details Next-Gen Platform and Production Cost Cuts",
            Body = "During a strategic update, executive leadership outlines manufacturing innovations designed to slash production costs and accelerate the rollout of lower-priced mass-market electric vehicles. Investors respond favorably to the long-term margin preservation strategy.",
            Source = "Reuters",
            EventId = 52
        },
        new ()
        {
            Id = 53,
            Headline = "First-Quarter Deliveries Fall Short of Consensus Expectations",
            Body = "Tesla posts a sequential drop in quarterly vehicle deliveries, impacted by factory upgrades and supply chain adjustments. Shares experience a sharp intraday pullback as analysts express near-term anxiety over shrinking automotive gross margins.",
            Source = "Bloomberg",
            EventId = 53
        },
        new ()
        {
            Id = 54,
            Headline = "FSD Adoption Rates Climb as Software Updates Expand Capabilities",
            Body = "Latest telemetry and subscription metrics indicate growing consumer uptake of Full Self-Driving capabilities. Software-driven revenue streams begin providing a stabilizing counterweight to fluctuating hardware margins.",
            Source = "CNBC",
            EventId = 54
        },
        new ()
        {
            Id = 55,
            Headline = "Q2 Deliveries Rebound Strongly Accompanied by Record Energy Storage",
            Body = "Second-quarter operational updates beat consensus estimates, driven by a solid recovery in vehicle deliveries and an all-time high deployment of Megapack energy storage systems. Market sentiment shifts toward renewed optimism.",
            Source = "Financial Times",
            EventId = 55
        },
        new ()
        {
            Id = 56,
            Headline = "Robotaxi Testing Progresses Amid Growing Regulatory Scrutiny",
            Body = "Tesla expands autonomous ride-hailing pilot tests across key metropolitan zones. While tech optimists praise the scaling timeline, regulators demand rigorous safety compliance data, triggering short-term caution among institutional holders.",
            Source = "Wall Street Journal",
            EventId = 56
        },
        new ()
        {
            Id = 57,
            Headline = "Q3 Earnings Beat Expectations Ahead of EV Tax Credit Expiration",
            Body = "Tesla delivers a strong third-quarter financial report, boosted by a rush of buyers securing vehicles prior to pending regulatory subsidy expirations. Operating cash flows remain robust despite pricing adjustments.",
            Source = "Reuters",
            EventId = 57
        },
        new ()
        {
            Id = 58,
            Headline = "Megafactory Output Expands to Meet Surging Global Grid Storage Demand",
            Body = "The energy division scales manufacturing lines to fulfill multi-gigawatt orders for utility-scale battery installations. Analysts highlight energy storage as Tesla's fastest-growing margin catalyst outside of automotive sales.",
            Source = "Bloomberg",
            EventId = 58
        },
        new ()
        {
            Id = 59,
            Headline = "Regulatory Credit Revenue Fluctuations Trigger Mixed Analyst Reactions",
            Body = "Quarterly disclosures show a temporary contraction in zero-emission regulatory credit sales to rival automakers. Equity researchers adjust near-term earnings targets to account for the shifting legislative landscape.",
            Source = "Financial Times",
            EventId = 59
        },
        new ()
        {
            Id = 60,
            Headline = "Year-End Push Solidifies Annual Delivery and Energy Deployment Totals",
            Body = "As the year closes, Tesla executes an aggressive end-of-quarter delivery wave. Institutional accumulation stabilizes share prices as the market turns its focus toward autonomous driving catalysts for the upcoming period.",
            Source = "CNBC",
            EventId = 60
        },

        // News configuration for Rocket Lab events
        new ()
        {
            Id = 61,
            Headline = "Rocket Lab Delivers Strong Q4 Financials and Broadens Launch Backlog",
            Body = "Rocket Lab posts impressive fourth-quarter financial results driven by accelerated Space Systems manufacturing and rapid Electron launch scheduling. Executive leadership outlines an expanding total backlog, reinforcing institutional confidence.",
            Source = "Wall Street Journal",
            EventId = 61
        },
        new ()
        {
            Id = 62,
            Headline = "Electron Launch Frequency Reaches Historic High Following HASTE Win",
            Body = "Rocket Lab secures additional hypersonic test launches under its HASTE suborbital program, demonstrating unrivaled mission flexibility. Commercial and defense clients continue to line up for dedicated orbital deployments.",
            Source = "Reuters",
            EventId = 62
        },
        new ()
        {
            Id = 63,
            Headline = "Q1 Financial Results Highlight Accelerating Space Systems Growth",
            Body = "First-quarter revenue clears analyst consensus estimates as satellite component manufacturing outpaces launch services growth. Gross margins improve across high-value defense subcontracts.",
            Source = "Bloomberg",
            EventId = 63
        },
        new ()
        {
            Id = 64,
            Headline = "Neutron Archimedes Engine Testing Achieves Key Qualification Milestone",
            Body = "Engineers successfully complete full-duration hot-fire testing for the medium-lift Neutron rocket engine in Virginia. Wall Street reacts enthusiastically to reduced technological risks on the path to orbital debut.",
            Source = "CNBC",
            EventId = 64
        },
        new ()
        {
            Id = 65,
            Headline = "Space Development Agency Awards Major Satellite Bus Manufacturing Deal",
            Body = "Rocket Lab lands a lucrative prime contract with defense agencies to manufacture next-generation satellite buses for national security constellations. The award cements the company's status as a premier defense contractor.",
            Source = "Financial Times",
            EventId = 65
        },
        new ()
        {
            Id = 66,
            Headline = "Q2 Earnings Surpass Target Margins as Order Backlog Hits Record",
            Body = "Second-quarter results demonstrate compounding revenue growth led by expanding constellation contracts. Management confirms steady progress across launch complex construction and automated fabrication facilities.",
            Source = "Wall Street Journal",
            EventId = 66
        },
        new ()
        {
            Id = 67,
            Headline = "Stage Structural Testing Discrepancy Causes Brief Neutron Schedule Shift",
            Body = "Engineering disclosures reveal minor structural adjustments required following stage 1 pressure testing for Neutron. Share prices experience a brief pullback as traders re-evaluate capital expenditure timelines.",
            Source = "Reuters",
            EventId = 67
        },
        new ()
        {
            Id = 68,
            Headline = "Q3 Revenue Spikes Driven by Commercial Constellation Deployments",
            Body = "Third-quarter disclosures highlight record Electron launch cadence alongside expanding satellite assembly operations. Management outlines a clear path toward sustainable free cash flow generation.",
            Source = "Bloomberg",
            EventId = 68
        },
        new ()
        {
            Id = 69,
            Headline = "U.S. Space Force Selects Rocket Lab for Responsive Orbital Mission",
            Body = "Federal defense officials award a dedicated rapid-callout launch contract on Electron. The high-margin defense mission highlights Rocket Lab's ability to execute precision orbital inserts on short notice.",
            Source = "CNBC",
            EventId = 69
        },
        new ()
        {
            Id = 70,
            Headline = "Year-End Review Highlights Record Electron Launches and Historic Backlog",
            Body = "Closing out a transformative operational year, Rocket Lab sets a company record for total orbital launches completed in a single calendar year. Analysts commend management's disciplined balance sheet strategy.",
            Source = "Financial Times",
            EventId = 70
        },

        // News configuration for Vertiv events
        new ()
        {
            Id = 71,
            Headline = "Vertiv Posts Blockbuster Q4 Results Driven by AI Cooling Demand",
            Body = "Vertiv reports strong fourth-quarter financial metrics, highlighting an unprecedented surge in orders for its thermal management and power infrastructure systems. Wall Street rewards the execution speed as backlogs expand rapidly.",
            Source = "Wall Street Journal",
            EventId = 71
        },
        new ()
        {
            Id = 72,
            Headline = "Direct-to-Chip Liquid Cooling Solutions Gain Industry-Wide Traction",
            Body = "The company unveils next-generation thermal management architectures tailored for ultra-dense artificial intelligence clusters. Major data center operators adopt Vertiv's systems to mitigate high thermal dissipation challenges.",
            Source = "Reuters",
            EventId = 72
        },
        new ()
        {
            Id = 73,
            Headline = "Q1 Financial Results Demonstrate Substantial Margin Improvement",
            Body = "First-quarter revenue and earnings comfortably exceed consensus estimates, powered by favorable pricing power and streamlined manufacturing output. Operating margins climb to new multi-year highs.",
            Source = "Bloomberg",
            EventId = 73
        },
        new ()
        {
            Id = 74,
            Headline = "Strategic Alliance Announced to Support Hyperscale AI Power Grids",
            Body = "Vertiv partners with major electrical equipment providers to deliver integrated power distribution units and backup systems for massive AI data centers. Institutional investors view the alliance as a strong competitive moat.",
            Source = "Financial Times",
            EventId = 74
        },
        new ()
        {
            Id = 75,
            Headline = "Q2 Earnings Beat Triggers Upward Revision of Full-Year Outlook",
            Body = "Second-quarter performance crushes expectations, prompting executive management to raise full-year revenue and free cash flow guidance. Strong conversion metrics drive heavy institutional buying volume.",
            Source = "CNBC",
            EventId = 75
        },
        new ()
        {
            Id = 76,
            Headline = "Global Manufacturing Footprint Expands to Alleviate Delivery Backlogs",
            Body = "Vertiv details a multi-million-dollar factory expansion plan across North America and Europe to shorten delivery lead times for critical infrastructure hardware. Analysts praise the proactive capacity scaling.",
            Source = "Wall Street Journal",
            EventId = 76
        },
        new ()
        {
            Id = 77,
            Headline = "Q3 Earnings Show Record Order Intake and Expanding Profitability",
            Body = "Third-quarter disclosures reveal record-breaking order intake figures as data center operators rush to lock in thermal capacity. Net income scales significantly faster than top-line revenue growth.",
            Source = "Reuters",
            EventId = 77
        },
        new ()
        {
            Id = 78,
            Headline = "Operational Efficiencies Successfully Lower Customer Delivery Lead Times",
            Body = "Supply chain optimizations allow Vertiv to accelerate project delivery schedules for major hyperscale clients. The operational agility strengthens customer retention and market dominance.",
            Source = "Bloomberg",
            EventId = 78
        },
        new ()
        {
            Id = 79,
            Headline = "Next-Generation High-Density Power Management System Unveiled",
            Body = "Vertiv rolls out innovative switchgear and busbar solutions designed to handle massive electrical loads required by modern GPU racks. Industry reports validate the technological leap.",
            Source = "Financial Times",
            EventId = 79
        },
        new ()
        {
            Id = 80,
            Headline = "Year-End Summit Outlines Aggressive Multi-Year Margin Targets",
            Body = "Closing out a stellar operational year, leadership presents a bullish long-term financial framework at the annual investor summit. Analysts adjust price targets upward to account for enduring structural demand.",
            Source = "CNBC",
            EventId = 80
        },

        // News configuration for Celsius events
        new ()
        {
            Id = 81,
            Headline = "Celsius Holdings Reports Strong Q4 Financials and Expanding Retail Footprint",
            Body = "Celsius posts solid fourth-quarter revenue growth, driven by deep penetration into mainstream grocery and fitness channels. Management emphasizes efficient inventory management across domestic distribution networks.",
            Source = "Wall Street Journal",
            EventId = 81
        },
        new ()
        {
            Id = 82,
            Headline = "Celsius Essentials Line Gains Rapid Traction Across Fitness Centers",
            Body = "The amino-infused Celsius Essentials product line rolls out successfully to specialized fitness centers and gym chains. Consumer response exceeds initial internal forecasts, boosting short-term shipment volumes.",
            Source = "Reuters",
            EventId = 82
        },
        new ()
        {
            Id = 83,
            Headline = "Q1 Financial Results Beat Estimates on Strong Domestic Scan Data",
            Body = "First-quarter earnings comfortably clear consensus expectations as market share within the functional energy category expands. Gross profit margins demonstrate solid resilience against input cost pressures.",
            Source = "Bloomberg",
            EventId = 83
        },
        new ()
        {
            Id = 84,
            Headline = "International Expansion Accelerates Into Key European Retail Markets",
            Body = "Celsius expands its distribution footprint across the UK, France, and Benelux regions through strategic retail partnerships. International revenue segments post double-digit percentage gains year-over-year.",
            Source = "Financial Times",
            EventId = 84
        },
        new ()
        {
            Id = 85,
            Headline = "Q2 Earnings Disclosures Highlight Record Revenue and Portfolio Synergy",
            Body = "Second-quarter results crush Wall Street projections, propelled by robust seasonal demand and optimized distribution networks. Institutional investors respond favorably to expanding operating leverage.",
            Source = "CNBC",
            EventId = 85
        },
        new ()
        {
            Id = 86,
            Headline = "Fall Promotional Campaign and New Flavor Lineup Drive Store Traffic",
            Body = "Retailers report high consumer engagement with newly introduced seasonal flavor variations and targeted digital marketing campaigns. Shelf-space allocations increase across major convenience store chains.",
            Source = "Wall Street Journal",
            EventId = 86
        },
        new ()
        {
            Id = 87,
            Headline = "Q3 Earnings Show Resilient Top-Line Growth Amid Category Competition",
            Body = "Third-quarter financial reports indicate stable revenue expansion despite aggressive promotional discounting by legacy beverage competitors. Direct-store-delivery logistics demonstrate notable cost improvements.",
            Source = "Reuters",
            EventId = 87
        },
        new ()
        {
            Id = 88,
            Headline = "Club Store and Foodservice Channels Deliver Accelerated Volume Growth",
            Body = "Wholesale club partnerships and bulk packaging formats drive steady volume gains. Analysts highlight the multi-channel diversification as a key driver for long-term brand durability.",
            Source = "Bloomberg",
            EventId = 88
        },
        new ()
        {
            Id = 89,
            Headline = "Hydration Powder Sticks Roll Out to Capture Wellness Segment",
            Body = "Celsius broadens its non-carbonated wellness portfolio with zero-sugar electrolyte powder sticks. The new product line targets health-conscious consumers seeking functional hydration options.",
            Source = "Financial Times",
            EventId = 89
        },
        new ()
        {
            Id = 90,
            Headline = "Year-End Retail Data Confirms Solid Category Share Retention",
            Body = "Closing out the calendar year, comprehensive retail scan data confirms Celsius maintains its standing as a dominant high-growth energy brand. Analysts praise the disciplined brand management strategy.",
            Source = "CNBC",
            EventId = 90
        },

        // News configuration for Vanguard ETF events
        new ()
        {
            Id = 91,
            Headline = "S&P 500 Index Kicks Off Year Following Robust Q4 GDP Expansion",
            Body = "U.S. macroeconomic data confirms resilient economic growth heading into the new year, supporting strong corporate fundamentals across the 500 index constituents tracked by institutional passive funds.",
            Source = "Wall Street Journal",
            EventId = 91
        },
        new ()
        {
            Id = 92,
            Headline = "Federal Reserve Signaling Triggers Broad Equity Market Volatility",
            Body = "Central bank commentary regarding interest rate trajectories introduces short-term friction across major large-cap sectors, resulting in a healthy consolidation phase for index tracking funds.",
            Source = "Reuters",
            EventId = 92
        },
        new ()
        {
            Id = 93,
            Headline = "Q1 Composite Earnings Beat Consensus Estimates Across Index Sectors",
            Body = "First-quarter reporting season demonstrates broad-based profitability expansion, led by technology and financial heavyweights. Passive inflows into broad-market index funds remain exceptionally high.",
            Source = "Bloomberg",
            EventId = 93
        },
        new ()
        {
            Id = 94,
            Headline = "Cooling Inflation Metrics Fuel Sector Rotation into Cyclical Equities",
            Body = "Favorable consumer price index updates prompt institutional asset managers to reallocate capital across lagging sectors, broadening market participation beyond mega-cap technology issues.",
            Source = "Financial Times",
            EventId = 94
        },
        new ()
        {
            Id = 95,
            Headline = "Q2 Earnings Results Push S&P 500 Benchmark to New Milestones",
            Body = "Strong corporate performance reports reinforce a fundamentals-driven market expansion. Total index returns climb steadily as earnings-per-share metrics beat top-down consensus forecasts.",
            Source = "CNBC",
            EventId = 95
        },
        new ()
        {
            Id = 96,
            Headline = "Jackson Hole Commentary Sparks Brief Macroeconomic Re-Pricing",
            Body = "Global investors closely analyze central bank policy speeches for clues on future monetary easing cycles. Broad equity indices experience mild intraday swings before stabilizing near key technical supports.",
            Source = "Wall Street Journal",
            EventId = 96
        },
        new ()
        {
            Id = 97,
            Headline = "Q3 Composite Earnings Season Exceeds Expectations Led by Mega-Caps",
            Body = "Third-quarter corporate scorecards validate the resilience of the broader U.S. economy. Heavy institutional accumulation flows directly into low-cost accumulation ETFs like VUAA.",
            Source = "Reuters",
            EventId = 97
        },
        new ()
        {
            Id = 98,
            Headline = "Treasury Yield Fluctuations Prompt Short-Term Cross-Asset Adjustments",
            Body = "Shifting sovereign debt yields create temporary headwinds for equity valuations, though dip-buyers quickly step in to support core large-cap components.",
            Source = "Bloomberg",
            EventId = 98
        },
        new ()
        {
            Id = 99,
            Headline = "FOMC Rate Cut Decision Catalyzes Year-End Market Rally",
            Body = "The Federal Reserve implements a widely anticipated monetary policy adjustment, sparking a broad-based equity rally as institutional portfolios position for the new year.",
            Source = "Financial Times",
            EventId = 99
        },
        new ()
        {
            Id = 100,
            Headline = "Year-End Index Review Confirms Another Banner Year for U.S. Equities",
            Body = "Closing out the calendar year, the S&P 500 records another stellar annual total return. Low-cost passive funds register record-breaking net asset inflows from global investors.",
            Source = "CNBC",
            EventId = 100
        }
    };

    public void Configure(EntityTypeBuilder<News> builder)
    {
        builder.HasData(NewsItems);
    }
}