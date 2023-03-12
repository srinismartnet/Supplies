using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SampleBlazorCURD.Server.Migrations
{
    /// <inheritdoc />
    public partial class Changedlocationtodistrict : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Companies",
                newName: "District");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "District",
                table: "Companies",
                newName: "Location");
        }
    }
}
