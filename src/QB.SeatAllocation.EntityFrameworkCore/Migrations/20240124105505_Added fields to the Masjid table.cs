using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QB.SeatAllocation.Migrations
{
    public partial class AddedfieldstotheMasjidtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Masjids",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Masjids",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Masjids",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Masjids");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Masjids");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Masjids");
        }
    }
}
