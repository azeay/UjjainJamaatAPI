using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QB.SeatAllocation.Migrations
{
    public partial class ModifiedSeatReservationandUsertables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeatReservations_AbpUsers_UserId1",
                table: "SeatReservations");

            migrationBuilder.DropColumn(
                name: "ITS",
                table: "SeatReservations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SeatReservations");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "SeatReservations",
                newName: "UpdatedByUserId1");

            migrationBuilder.RenameIndex(
                name: "IX_SeatReservations_UserId1",
                table: "SeatReservations",
                newName: "IX_SeatReservations_UpdatedByUserId1");

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "SeatReservations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CreatedByUserId1",
                table: "SeatReservations",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "SeatReservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "SeatReservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "MuminId",
                table: "SeatReservations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "MuminId1",
                table: "SeatReservations",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "SeatReservations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ITS",
                table: "AbpUsers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_SeatReservations_CreatedByUserId1",
                table: "SeatReservations",
                column: "CreatedByUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_SeatReservations_MuminId1",
                table: "SeatReservations",
                column: "MuminId1");

            migrationBuilder.AddForeignKey(
                name: "FK_SeatReservations_AbpUsers_CreatedByUserId1",
                table: "SeatReservations",
                column: "CreatedByUserId1",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SeatReservations_AbpUsers_MuminId1",
                table: "SeatReservations",
                column: "MuminId1",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SeatReservations_AbpUsers_UpdatedByUserId1",
                table: "SeatReservations",
                column: "UpdatedByUserId1",
                principalTable: "AbpUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeatReservations_AbpUsers_CreatedByUserId1",
                table: "SeatReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_SeatReservations_AbpUsers_MuminId1",
                table: "SeatReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_SeatReservations_AbpUsers_UpdatedByUserId1",
                table: "SeatReservations");

            migrationBuilder.DropIndex(
                name: "IX_SeatReservations_CreatedByUserId1",
                table: "SeatReservations");

            migrationBuilder.DropIndex(
                name: "IX_SeatReservations_MuminId1",
                table: "SeatReservations");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "SeatReservations");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId1",
                table: "SeatReservations");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "SeatReservations");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "SeatReservations");

            migrationBuilder.DropColumn(
                name: "MuminId",
                table: "SeatReservations");

            migrationBuilder.DropColumn(
                name: "MuminId1",
                table: "SeatReservations");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "SeatReservations");

            migrationBuilder.DropColumn(
                name: "ITS",
                table: "AbpUsers");

            migrationBuilder.RenameColumn(
                name: "UpdatedByUserId1",
                table: "SeatReservations",
                newName: "UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_SeatReservations_UpdatedByUserId1",
                table: "SeatReservations",
                newName: "IX_SeatReservations_UserId1");

            migrationBuilder.AddColumn<long>(
                name: "ITS",
                table: "SeatReservations",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "SeatReservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_SeatReservations_AbpUsers_UserId1",
                table: "SeatReservations",
                column: "UserId1",
                principalTable: "AbpUsers",
                principalColumn: "Id");
        }
    }
}
