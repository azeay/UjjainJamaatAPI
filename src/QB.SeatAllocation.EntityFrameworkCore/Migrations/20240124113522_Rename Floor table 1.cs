using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QB.SeatAllocation.Migrations
{
    public partial class RenameFloortable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasjidFloors_Masjids_MasjidId",
                table: "MasjidFloors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MasjidFloors",
                table: "MasjidFloors");

            migrationBuilder.RenameTable(
                name: "MasjidFloors",
                newName: "Floors");

            migrationBuilder.RenameIndex(
                name: "IX_MasjidFloors_MasjidId",
                table: "Floors",
                newName: "IX_Floors_MasjidId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Floors",
                table: "Floors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Floors_Masjids_MasjidId",
                table: "Floors",
                column: "MasjidId",
                principalTable: "Masjids",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Floors_Masjids_MasjidId",
                table: "Floors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Floors",
                table: "Floors");

            migrationBuilder.RenameTable(
                name: "Floors",
                newName: "MasjidFloors");

            migrationBuilder.RenameIndex(
                name: "IX_Floors_MasjidId",
                table: "MasjidFloors",
                newName: "IX_MasjidFloors_MasjidId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MasjidFloors",
                table: "MasjidFloors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MasjidFloors_Masjids_MasjidId",
                table: "MasjidFloors",
                column: "MasjidId",
                principalTable: "Masjids",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
