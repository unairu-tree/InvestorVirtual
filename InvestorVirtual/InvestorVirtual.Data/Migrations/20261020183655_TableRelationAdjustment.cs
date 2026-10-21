using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InvestorVirtual.Data.Migrations
{
    /// <inheritdoc />
    public partial class TableRelationAdjustment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Analyses_AnalysisId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_News_NewsId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Prices_PriceId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_AnalysisId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_NewsId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_PriceId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "AnalysisId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "NewsId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "PriceId",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "This will reference the event associated with the price");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "News",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "This will reference the event associated with the news");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Analyses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "This will reference the event associated with the analysis");

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "CompanyName", "LogoPath", "Sector", "ShortDescription", "Ticker" },
                values: new object[,]
                {
                    { 1, "NVIDIA Corporation", "wwwroot/images/logos/nvidia.svg", "Technology (Semiconductors)", "NVIDIA Corporation is a leading data center-scale AI infrastructure and computing company operating globally through two primary business segments: Compute & Networking, and Graphics. Compute & Networking: Provides accelerated computing and networking platforms, AI hardware and software solutions, and autonomous/electric vehicle technology. Graphics: Offers GeForce GPUs for gaming and personal computers, alongside Quadro and NVIDIA RTX GPUs for enterprise workstations. The company serves the gaming, professional visualization, data center, and automotive markets, selling to OEMs, cloud providers, and system integrators. It maintains key strategic collaborations with Cisco, ChipAgents, and MediaTek to advance AI computing and next-generation chip technology. Founded in 1993, NVIDIA is headquartered in Santa Clara, California.", "NVDA" },
                    { 2, "Oracle Corporation", "wwwroot/images/logos/oracle.svg", "Technology (Software - Infrastructure)", "Oracle Corporation delivers global enterprise information technology solutions, offering integrated cloud, license, hardware, and support services. The company operates across major infrastructure and software domains: Cloud Software (SaaS): Includes enterprise applications like Oracle Fusion Cloud (ERP, EPM, SCM, HCM), NetSuite, Oracle Health, and targeted sales, service, and marketing suites. Infrastructure & Database: Features the Oracle Database, MySQL, Java, and Oracle Autonomous Database, alongside cloud compute, storage, networking, AI, and machine learning capabilities. Hardware & Services: Provides engineered systems, enterprise servers, storage solutions, and operating systems, backed by specialized consulting and technical support. Oracle serves businesses, government agencies, and educational institutions globally via direct and indirect channels. Founded in 1977, the company is headquartered in Austin, Texas.", "ORCL" },
                    { 3, "Eli Lilly and Company", "wwwroot/images/logos/lilly.svg", "Healthcare (Drug Manufacturers - General)", "Eli Lilly and Company is a global pharmaceutical corporation that discovers, develops, manufactures, and markets human prescription medications across several key therapeutic areas. Cardiometabolic & Obesity: Offers blockbusters like Trulicity and Mounjaro for type 2 diabetes, Zepbound for obesity, Jardiance, and an extensive portfolio of insulins (Humalog, Humulin). Oncology: Provides cancer treatments including Verzenio and Cyramza for breast and gastric cancers, Retevmo, and Jaypirca. Immunology & Neuroscience: Markets treatments such as Taltz and Olumiant for autoimmune conditions, Emgality for migraines, and Kisunla for Alzheimer's disease. The company leverages strategic alliances with partners like Boehringer Ingelheim and Roche to co-develop therapies. Founded in 1876, Eli Lilly is headquartered in Indianapolis, Indiana.", "LLY" },
                    { 4, "Micron Technology, Inc.", "wwwroot/images/logos/micron.svg", "Technology (Semiconductors)", "Micron Technology, Inc. engages in the provision of semiconductor memory and storage products in the United States, Taiwan, Mainland China, other Asia Pacific countries, Japan, Europe, and internationally. It operates through Cloud Memory Business Unit, Core Data Center Business Unit, Mobile and Client Business Unit, and Automotive and Embedded Business Unit segments. The company provides dynamic random access memory (DRAM) products, including High-Bandwidth Memory, doublie data rate, low-power DRAM, and graphics DRAM products; NAND products comprising solid state drives, managed NAND, and multi-chip packages; and NOR products. The company sells its products under the Micron brand name and private labels through its own direct sales force, sales or representative offices, as well as through distributors, retailers, and independent sales representatives. Micron Technology, Inc. was founded in 1978 and is headquartered in Boise, Idaho.", "MU" },
                    { 5, "ExxonMobil Holdings Corporation", "wwwroot/images/logos/exxonmobil.svg", "Energy (Oil & Gas Integrated)", "ExxonMobil Holdings Corporation is a global energy and petrochemical enterprise engaged in the exploration, production, and sale of crude oil, natural gas, and derivative products. It operates through four main segments: Upstream & Energy Products: Explores for and produces oil and gas, and provides finished fuels, aromatics, catalysts, and aviation fuel. Chemical & Specialty Products: Manufactures olefins, polyolefins, finished lubricants, basestocks, waxes, and resins under the Exxon, Esso, and Mobil brands. Low-Carbon Solutions: Pursues lower-emission business opportunities, including carbon capture, hydrogen, lower-emission fuels, and lithium extraction. Formerly Exxon Mobil Corporation, the company rebranded to ExxonMobil Holdings Corporation in July 2026. Founded in 1870, it is headquartered in Spring, Texas.", "XOM" },
                    { 6, "Tesla, Inc.", "wwwroot/images/logos/tesla.svg", "Consumer Cyclical (Auto Manufacturers)", "Tesla, Inc. designs, manufactures, leases, and sells electric vehicles, alongside energy generation and storage systems globally. The company operates through two primary business segments: Automotive: Offers consumer electric sedans and sport utility vehicles via direct and used sales, supported by the global Tesla Supercharger network. This segment also includes automotive regulatory credits, insurance, financing, and self-driving/AI software development. Energy Generation & Storage: Designs, installs, and leases solar products (solar panels and Solar Roof) and lithium-ion battery energy storage systems (Powerwall and Megapack) for residential, commercial, industrial, and utility clients. Formerly known as Tesla Motors, Inc., the company rebranded to Tesla, Inc. in February 2017. Incorporated in 2003, it is headquartered in Austin, Texas.", "TSLA" },
                    { 7, "Rocket Lab Corporation", "wwwroot/images/logos/rocketlab.svg", "Industrials (Aerospace & Defense)", "Rocket Lab Corporation is an end-to-end space company providing launch services and space systems solutions globally. It operates through two primary business segments: Launch Services: Designs and manufactures small and medium-class rockets. It operates the Electron orbital launch vehicle for small spacecraft and is developing the Neutron rocket for large constellation deployments, interplanetary missions, and human spaceflight. Space Systems: Provides comprehensive spacecraft design, manufacturing, components, optical systems, flight/ground software, and on-orbit constellation management. The company serves commercial enterprises, aerospace prime contractors, and government agencies. Formerly Rocket Lab USA, Inc., it rebranded to Rocket Lab Corporation in August 2021. Founded in 2006, it is headquartered in Long Beach, California.", "RKLB" },
                    { 8, "Vertiv Holdings Co", "wwwroot/images/logos/vertiv.svg", "Industrials (Electrical Equipment & Parts)", "Vertiv Holdings Co designs, manufactures, and services critical digital infrastructure technologies and lifecycle solutions globally for data centers, communication networks, and industrial environments. Its portfolio powers and cools infrastructure vital for artificial intelligence, cloud services, and e-commerce through several core areas: Power & Thermal Management: Offers AC/DC power management, switchgear, busbars, and comprehensive air and liquid cooling thermal systems. Integrated Solutions: Provides modular solutions, hardware, racks, power distribution units, energy storage solutions, and infrastructure software. Lifecycle Services: Delivers predictive analytics, remote monitoring, preventative maintenance, consulting, and engineering services to optimize system deployments. Vertiv markets its solutions under recognized brands including Vertiv, Liebert, NetSure, Geist, and Avocent via direct sales, OEMs, and channel partners. The company headquarters are in Westerville, Ohio.", "VRT" },
                    { 9, "Celsius Holdings, Inc.", "wwwroot/images/logos/celsius.svg", "Consumer Defensive (Beverages - Non-Alcoholic)", "Celsius Holdings, Inc. develops, processes, markets, and distributes functional energy drinks and hydration products globally. The company focuses on the health, wellness, and fitness beverage markets through targeted product lines: Core Beverages: Offers ready-to-drink functional energy beverages and on-the-go powder sticks under the CELSIUS brand, including the amino-infused CELSIUS ESSENTIALS. Hydration Portfolio: Provides CELSIUS Hydration, a line of zero-sugar electrolyte powders, alongside additional products under the Alani Nu and Rockstar brand names. The company distributes its products through a broad omni-channel network including direct-to-store delivery, supermarkets, convenience stores, gyms, fitness centers, and e-commerce platforms. Formerly known as Vector Ventures, Inc., it rebranded to Celsius Holdings, Inc. in January 2007. Founded in 2004, it is headquartered in Boca Raton, Florida.", "CELH" },
                    { 10, "Vanguard S&P 500 Acc UCITS ETF", "wwwroot/images/logos/vuaa.svg", "Exchange Traded Fund (Largest US stocks)", "The Vanguard S&P 500 UCITS ETF (Acc) offers investors the opportunity to participate in the performance of the 500 largest listed US companies. The S&P 500 index represents the most important US industries and is considered an indicator for the development of the entire US stock market.", "VUAA" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prices_EventId",
                table: "Prices",
                column: "EventId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_News_EventId",
                table: "News",
                column: "EventId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Analyses_EventId",
                table: "Analyses",
                column: "EventId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Analyses_Events_EventId",
                table: "Analyses",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Events_EventId",
                table: "News",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prices_Events_EventId",
                table: "Prices",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analyses_Events_EventId",
                table: "Analyses");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Events_EventId",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_Prices_Events_EventId",
                table: "Prices");

            migrationBuilder.DropIndex(
                name: "IX_Prices_EventId",
                table: "Prices");

            migrationBuilder.DropIndex(
                name: "IX_News_EventId",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_Analyses_EventId",
                table: "Analyses");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "News");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Analyses");

            migrationBuilder.AddColumn<int>(
                name: "AnalysisId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "This will reference the analysis associated with the event");

            migrationBuilder.AddColumn<int>(
                name: "NewsId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "This will reference the news associated with the event");

            migrationBuilder.AddColumn<int>(
                name: "PriceId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "This will reference the price associated with the event");

            migrationBuilder.CreateIndex(
                name: "IX_Events_AnalysisId",
                table: "Events",
                column: "AnalysisId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_NewsId",
                table: "Events",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_PriceId",
                table: "Events",
                column: "PriceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Analyses_AnalysisId",
                table: "Events",
                column: "AnalysisId",
                principalTable: "Analyses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_News_NewsId",
                table: "Events",
                column: "NewsId",
                principalTable: "News",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Prices_PriceId",
                table: "Events",
                column: "PriceId",
                principalTable: "Prices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
