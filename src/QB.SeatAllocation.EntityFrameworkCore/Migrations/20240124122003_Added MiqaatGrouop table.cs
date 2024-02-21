using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QB.SeatAllocation.Migrations
{
    public partial class AddedMiqaatGrouoptable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MiqaatGroup",
                table: "Miqaats",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MiqaatGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiqaatGroups", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MiqaatGroups");

            migrationBuilder.DropColumn(
                name: "MiqaatGroup",
                table: "Miqaats");
        }
    }
}
