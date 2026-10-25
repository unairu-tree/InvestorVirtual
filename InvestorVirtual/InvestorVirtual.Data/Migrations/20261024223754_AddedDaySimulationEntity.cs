using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestorVirtual.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDaySimulationEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DaySimulations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<int>(type: "int", nullable: false, comment: "The simulation starts on day 1 and has a maximum of 10 days")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaySimulations", x => x.Id);
                },
                comment: "This is a solo model used for the day simulation mechanic of the app");

            migrationBuilder.InsertData(
                table: "DaySimulations",
                columns: new[] { "Id", "Day" },
                values: new object[] { 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DaySimulations");
        }
    }
}
