using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MirageResort.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddVillaToDb_Corrected : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Occcupancy",
                table: "Villas",
                newName: "Occupancy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Occupancy",
                table: "Villas",
                newName: "Occcupancy");
        }
    }
}
