using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QB.SeatAllocation.Migrations
{
    public partial class AddedMasjidFloortable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasjidFloors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    MasjidId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasjidFloors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MasjidFloors_Masjids_MasjidId",
                        column: x => x.MasjidId,
                        principalTable: "Masjids",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MasjidFloors_MasjidId",
                table: "MasjidFloors",
                column: "MasjidId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasjidFloors");
        }
    }
}
