using Microsoft.EntityFrameworkCore.Migrations;

namespace Razor_Identity.Data.Migrations
{
    public partial class AddPart2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Part2Id",
                table: "RepairOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part2Quantity",
                table: "RepairOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartID2",
                table: "RepairOrders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RepairOrders_Part2Id",
                table: "RepairOrders",
                column: "Part2Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RepairOrders_Parts_Part2Id",
                table: "RepairOrders",
                column: "Part2Id",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepairOrders_Parts_Part2Id",
                table: "RepairOrders");

            migrationBuilder.DropIndex(
                name: "IX_RepairOrders_Part2Id",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "Part2Id",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "Part2Quantity",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "PartID2",
                table: "RepairOrders");
        }
    }
}
