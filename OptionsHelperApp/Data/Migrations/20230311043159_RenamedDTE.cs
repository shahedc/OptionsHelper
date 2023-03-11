using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OptionsHelperApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenamedDTE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DaysToExpiration",
                table: "OptionContracts",
                newName: "DaysToClose");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DaysToClose",
                table: "OptionContracts",
                newName: "DaysToExpiration");
        }
    }
}
