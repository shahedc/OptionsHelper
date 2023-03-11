using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OptionsHelperApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedOptionContract : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OptionContracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    AccountOwner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpenAmount = table.Column<double>(type: "float", nullable: false),
                    DateOpened = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClosedAmount = table.Column<double>(type: "float", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClosingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfitLoss = table.Column<double>(type: "float", nullable: false),
                    ProfitPercentage = table.Column<double>(type: "float", nullable: false),
                    DaysToExpiration = table.Column<int>(type: "int", nullable: false),
                    Assigned = table.Column<bool>(type: "bit", nullable: false),
                    StrikePrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionContracts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OptionContracts");
        }
    }
}
