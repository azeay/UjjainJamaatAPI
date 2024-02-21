using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QB.SeatAllocation.Migrations
{
    public partial class MiqaatFloortableadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MiqaatFloors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    isGenerated = table.Column<bool>(type: "bit", nullable: false),
                    MiqaatId = table.Column<int>(type: "int", nullable: false),
                    FloorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiqaatFloors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MiqaatFloors_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MiqaatFloors_Miqaats_MiqaatId",
                        column: x => x.MiqaatId,
                        principalTable: "Miqaats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MiqaatFloors_FloorId",
                table: "MiqaatFloors",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_MiqaatFloors_MiqaatId",
                table: "MiqaatFloors",
                column: "MiqaatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MiqaatFloors");
        }
    }
}
