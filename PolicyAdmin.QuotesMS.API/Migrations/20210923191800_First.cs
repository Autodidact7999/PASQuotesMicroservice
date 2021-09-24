using Microsoft.EntityFrameworkCore.Migrations;

namespace PolicyAdmin.QuotesMS.API.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BusinesssValueRangeTo",
                table: "QuotesMaster",
                newName: "BusinessValueRangeTo");

            migrationBuilder.RenameColumn(
                name: "BusinesssValueRangeFrom",
                table: "QuotesMaster",
                newName: "BusinessValueRangeFrom");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BusinessValueRangeTo",
                table: "QuotesMaster",
                newName: "BusinesssValueRangeTo");

            migrationBuilder.RenameColumn(
                name: "BusinessValueRangeFrom",
                table: "QuotesMaster",
                newName: "BusinesssValueRangeFrom");
        }
    }
}
