using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestorVirtual.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedForgottenValidation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "LearningTerms",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "This is the field that will hold the slug used for extra security and SEO",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "This is the field that will hold the slug used for extra security and SEO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "LearningTerms",
                type: "nvarchar(max)",
                nullable: false,
                comment: "This is the field that will hold the slug used for extra security and SEO",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "This is the field that will hold the slug used for extra security and SEO");
        }
    }
}
