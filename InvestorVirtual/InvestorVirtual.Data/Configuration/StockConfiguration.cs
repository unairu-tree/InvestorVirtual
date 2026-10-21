namespace InvestorVirtual.Data.Configuration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Models;

public class StockConfiguration : IEntityTypeConfiguration<Stock>
{
    public static readonly IEnumerable<Stock> Stocks = new List<Stock>
    {
        new()
        {
            Id = 1,
            Ticker = "NVDA",
            CompanyName = "NVIDIA Corporation",
            ShortDescription = "NVIDIA Corporation is a leading data center-scale AI infrastructure and computing company operating globally through two primary business segments: Compute & Networking, and Graphics. Compute & Networking: Provides accelerated computing and networking platforms, AI hardware and software solutions, and autonomous/electric vehicle technology. Graphics: Offers GeForce GPUs for gaming and personal computers, alongside Quadro and NVIDIA RTX GPUs for enterprise workstations. The company serves the gaming, professional visualization, data center, and automotive markets, selling to OEMs, cloud providers, and system integrators. It maintains key strategic collaborations with Cisco, ChipAgents, and MediaTek to advance AI computing and next-generation chip technology. Founded in 1993, NVIDIA is headquartered in Santa Clara, California.",
            Sector = "Technology (Semiconductors)",
            LogoPath = "wwwroot/images/logos/nvidia.svg",
        },
        new()
        {
            Id = 2,
            Ticker = "ORCL",
            CompanyName = "Oracle Corporation",
            ShortDescription = "Oracle Corporation delivers global enterprise information technology solutions, offering integrated cloud, license, hardware, and support services. The company operates across major infrastructure and software domains: Cloud Software (SaaS): Includes enterprise applications like Oracle Fusion Cloud (ERP, EPM, SCM, HCM), NetSuite, Oracle Health, and targeted sales, service, and marketing suites. Infrastructure & Database: Features the Oracle Database, MySQL, Java, and Oracle Autonomous Database, alongside cloud compute, storage, networking, AI, and machine learning capabilities. Hardware & Services: Provides engineered systems, enterprise servers, storage solutions, and operating systems, backed by specialized consulting and technical support. Oracle serves businesses, government agencies, and educational institutions globally via direct and indirect channels. Founded in 1977, the company is headquartered in Austin, Texas.",
            Sector = "Technology (Software - Infrastructure)",
            LogoPath = "wwwroot/images/logos/oracle.svg",
        },
        new()
        {
            Id = 3,
            Ticker = "LLY",
            CompanyName = "Eli Lilly and Company",
            ShortDescription = "Eli Lilly and Company is a global pharmaceutical corporation that discovers, develops, manufactures, and markets human prescription medications across several key therapeutic areas. Cardiometabolic & Obesity: Offers blockbusters like Trulicity and Mounjaro for type 2 diabetes, Zepbound for obesity, Jardiance, and an extensive portfolio of insulins (Humalog, Humulin). Oncology: Provides cancer treatments including Verzenio and Cyramza for breast and gastric cancers, Retevmo, and Jaypirca. Immunology & Neuroscience: Markets treatments such as Taltz and Olumiant for autoimmune conditions, Emgality for migraines, and Kisunla for Alzheimer's disease. The company leverages strategic alliances with partners like Boehringer Ingelheim and Roche to co-develop therapies. Founded in 1876, Eli Lilly is headquartered in Indianapolis, Indiana.",
            Sector = "Healthcare (Drug Manufacturers - General)",
            LogoPath = "wwwroot/images/logos/lilly.svg",
        },
        new()
        {
            Id = 4,
            Ticker = "MU",
            CompanyName = "Micron Technology, Inc.",
            ShortDescription = "Micron Technology, Inc. engages in the provision of semiconductor memory and storage products in the United States, Taiwan, Mainland China, other Asia Pacific countries, Japan, Europe, and internationally. It operates through Cloud Memory Business Unit, Core Data Center Business Unit, Mobile and Client Business Unit, and Automotive and Embedded Business Unit segments. The company provides dynamic random access memory (DRAM) products, including High-Bandwidth Memory, doublie data rate, low-power DRAM, and graphics DRAM products; NAND products comprising solid state drives, managed NAND, and multi-chip packages; and NOR products. The company sells its products under the Micron brand name and private labels through its own direct sales force, sales or representative offices, as well as through distributors, retailers, and independent sales representatives. Micron Technology, Inc. was founded in 1978 and is headquartered in Boise, Idaho.",
            Sector = "Technology (Semiconductors)",
            LogoPath = "wwwroot/images/logos/micron.svg",
        },
        new()
        {
            Id = 5,
            Ticker = "XOM",
            CompanyName = "ExxonMobil Holdings Corporation",
            ShortDescription = "ExxonMobil Holdings Corporation is a global energy and petrochemical enterprise engaged in the exploration, production, and sale of crude oil, natural gas, and derivative products. It operates through four main segments: Upstream & Energy Products: Explores for and produces oil and gas, and provides finished fuels, aromatics, catalysts, and aviation fuel. Chemical & Specialty Products: Manufactures olefins, polyolefins, finished lubricants, basestocks, waxes, and resins under the Exxon, Esso, and Mobil brands. Low-Carbon Solutions: Pursues lower-emission business opportunities, including carbon capture, hydrogen, lower-emission fuels, and lithium extraction. Formerly Exxon Mobil Corporation, the company rebranded to ExxonMobil Holdings Corporation in July 2026. Founded in 1870, it is headquartered in Spring, Texas.",
            Sector = "Energy (Oil & Gas Integrated)",
            LogoPath = "wwwroot/images/logos/exxonmobil.svg",
        },
        new()
        {
            Id = 6,
            Ticker = "TSLA",
            CompanyName = "Tesla, Inc.",
            ShortDescription = "Tesla, Inc. designs, manufactures, leases, and sells electric vehicles, alongside energy generation and storage systems globally. The company operates through two primary business segments: Automotive: Offers consumer electric sedans and sport utility vehicles via direct and used sales, supported by the global Tesla Supercharger network. This segment also includes automotive regulatory credits, insurance, financing, and self-driving/AI software development. Energy Generation & Storage: Designs, installs, and leases solar products (solar panels and Solar Roof) and lithium-ion battery energy storage systems (Powerwall and Megapack) for residential, commercial, industrial, and utility clients. Formerly known as Tesla Motors, Inc., the company rebranded to Tesla, Inc. in February 2017. Incorporated in 2003, it is headquartered in Austin, Texas.",
            Sector = "Consumer Cyclical (Auto Manufacturers)",
            LogoPath = "wwwroot/images/logos/tesla.svg",
        },
        new()
        {
            Id = 7,
            Ticker = "RKLB",
            CompanyName = "Rocket Lab Corporation",
            ShortDescription = "Rocket Lab Corporation is an end-to-end space company providing launch services and space systems solutions globally. It operates through two primary business segments: Launch Services: Designs and manufactures small and medium-class rockets. It operates the Electron orbital launch vehicle for small spacecraft and is developing the Neutron rocket for large constellation deployments, interplanetary missions, and human spaceflight. Space Systems: Provides comprehensive spacecraft design, manufacturing, components, optical systems, flight/ground software, and on-orbit constellation management. The company serves commercial enterprises, aerospace prime contractors, and government agencies. Formerly Rocket Lab USA, Inc., it rebranded to Rocket Lab Corporation in August 2021. Founded in 2006, it is headquartered in Long Beach, California.",
            Sector = "Industrials (Aerospace & Defense)",
            LogoPath = "wwwroot/images/logos/rocketlab.svg",
        },
        new()
        {
            Id = 8,
            Ticker = "VRT",
            CompanyName = "Vertiv Holdings Co",
            ShortDescription = "Vertiv Holdings Co designs, manufactures, and services critical digital infrastructure technologies and lifecycle solutions globally for data centers, communication networks, and industrial environments. Its portfolio powers and cools infrastructure vital for artificial intelligence, cloud services, and e-commerce through several core areas: Power & Thermal Management: Offers AC/DC power management, switchgear, busbars, and comprehensive air and liquid cooling thermal systems. Integrated Solutions: Provides modular solutions, hardware, racks, power distribution units, energy storage solutions, and infrastructure software. Lifecycle Services: Delivers predictive analytics, remote monitoring, preventative maintenance, consulting, and engineering services to optimize system deployments. Vertiv markets its solutions under recognized brands including Vertiv, Liebert, NetSure, Geist, and Avocent via direct sales, OEMs, and channel partners. The company headquarters are in Westerville, Ohio.",
            Sector = "Industrials (Electrical Equipment & Parts)",
            LogoPath = "wwwroot/images/logos/vertiv.svg",
        },
        new()
        {
            Id = 9,
            Ticker = "CELH",
            CompanyName = "Celsius Holdings, Inc.",
            ShortDescription = "Celsius Holdings, Inc. develops, processes, markets, and distributes functional energy drinks and hydration products globally. The company focuses on the health, wellness, and fitness beverage markets through targeted product lines: Core Beverages: Offers ready-to-drink functional energy beverages and on-the-go powder sticks under the CELSIUS brand, including the amino-infused CELSIUS ESSENTIALS. Hydration Portfolio: Provides CELSIUS Hydration, a line of zero-sugar electrolyte powders, alongside additional products under the Alani Nu and Rockstar brand names. The company distributes its products through a broad omni-channel network including direct-to-store delivery, supermarkets, convenience stores, gyms, fitness centers, and e-commerce platforms. Formerly known as Vector Ventures, Inc., it rebranded to Celsius Holdings, Inc. in January 2007. Founded in 2004, it is headquartered in Boca Raton, Florida.",
            Sector = "Consumer Defensive (Beverages - Non-Alcoholic)",
            LogoPath = "wwwroot/images/logos/celsius.svg",
        },
        new()
        {
            Id = 10,
            Ticker = "VUAA",
            CompanyName = "Vanguard S&P 500 Acc UCITS ETF",
            ShortDescription = "The Vanguard S&P 500 UCITS ETF (Acc) offers investors the opportunity to participate in the performance of the 500 largest listed US companies. The S&P 500 index represents the most important US industries and is considered an indicator for the development of the entire US stock market.",
            Sector = "Exchange Traded Fund (Largest US stocks)",
            LogoPath = "wwwroot/images/logos/vuaa.svg",
        }
    };

public void Configure(EntityTypeBuilder<Stock> builder)
    {
        builder.HasData(Stocks);
    }
}