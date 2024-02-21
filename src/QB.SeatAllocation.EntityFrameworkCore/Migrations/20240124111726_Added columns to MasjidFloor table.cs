using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QB.SeatAllocation.Migrations
{
    public partial class AddedcolumnstoMasjidFloortable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ColumnCount",
                table: "MasjidFloors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ColumnInitials",
                table: "MasjidFloors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RowCount",
                table: "MasjidFloors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RowInitials",
                table: "MasjidFloors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZoneCount",
                table: "MasjidFloors",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColumnCount",
                table: "MasjidFloors");

            migrationBuilder.DropColumn(
                name: "ColumnInitials",
                table: "MasjidFloors");

            migrationBuilder.DropColumn(
                name: "RowCount",
                table: "MasjidFloors");

            migrationBuilder.DropColumn(
                name: "RowInitials",
                table: "MasjidFloors");

            migrationBuilder.DropColumn(
                name: "ZoneCount",
                table: "MasjidFloors");
        }
    }
}
