using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestorVirtual.Data.Migrations
{
    /// <inheritdoc />
    public partial class MinorPropertyNameFixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Portfolios",
                newName: "IsDeleted");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Portfolios",
                newName: "isDeleted");
        }
    }
}
