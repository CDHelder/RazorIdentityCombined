using Microsoft.EntityFrameworkCore.Migrations;

namespace Razor_Identity.Data.Migrations
{
    public partial class Addedatotalof8parts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Part3Id",
                table: "RepairOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part3Quantity",
                table: "RepairOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Part4Id",
                table: "RepairOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part4Quantity",
                table: "RepairOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Part5Id",
                table: "RepairOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part5Quantity",
                table: "RepairOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Part6Id",
                table: "RepairOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part6Quantity",
                table: "RepairOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Part7Id",
                table: "RepairOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part7Quantity",
                table: "RepairOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Part8Id",
                table: "RepairOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part8Quantity",
                table: "RepairOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartID3",
                table: "RepairOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartID4",
                table: "RepairOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartID5",
                table: "RepairOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartID6",
                table: "RepairOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartID7",
                table: "RepairOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartID8",
                table: "RepairOrders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RepairOrders_Part3Id",
                table: "RepairOrders",
                column: "Part3Id");

            migrationBuilder.CreateIndex(
                name: "IX_RepairOrders_Part4Id",
                table: "RepairOrders",
                column: "Part4Id");

            migrationBuilder.CreateIndex(
                name: "IX_RepairOrders_Part5Id",
                table: "RepairOrders",
                column: "Part5Id");

            migrationBuilder.CreateIndex(
                name: "IX_RepairOrders_Part6Id",
                table: "RepairOrders",
                column: "Part6Id");

            migrationBuilder.CreateIndex(
                name: "IX_RepairOrders_Part7Id",
                table: "RepairOrders",
                column: "Part7Id");

            migrationBuilder.CreateIndex(
                name: "IX_RepairOrders_Part8Id",
                table: "RepairOrders",
                column: "Part8Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RepairOrders_Parts_Part3Id",
                table: "RepairOrders",
                column: "Part3Id",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairOrders_Parts_Part4Id",
                table: "RepairOrders",
                column: "Part4Id",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairOrders_Parts_Part5Id",
                table: "RepairOrders",
                column: "Part5Id",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairOrders_Parts_Part6Id",
                table: "RepairOrders",
                column: "Part6Id",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairOrders_Parts_Part7Id",
                table: "RepairOrders",
                column: "Part7Id",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairOrders_Parts_Part8Id",
                table: "RepairOrders",
                column: "Part8Id",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepairOrders_Parts_Part3Id",
                table: "RepairOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairOrders_Parts_Part4Id",
                table: "RepairOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairOrders_Parts_Part5Id",
                table: "RepairOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairOrders_Parts_Part6Id",
                table: "RepairOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairOrders_Parts_Part7Id",
                table: "RepairOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairOrders_Parts_Part8Id",
                table: "RepairOrders");

            migrationBuilder.DropIndex(
                name: "IX_RepairOrders_Part3Id",
                table: "RepairOrders");

            migrationBuilder.DropIndex(
                name: "IX_RepairOrders_Part4Id",
                table: "RepairOrders");

            migrationBuilder.DropIndex(
                name: "IX_RepairOrders_Part5Id",
                table: "RepairOrders");

            migrationBuilder.DropIndex(
                name: "IX_RepairOrders_Part6Id",
                table: "RepairOrders");

            migrationBuilder.DropIndex(
                name: "IX_RepairOrders_Part7Id",
                table: "RepairOrders");

            migrationBuilder.DropIndex(
                name: "IX_RepairOrders_Part8Id",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "Part3Id",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "Part3Quantity",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "Part4Id",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "Part4Quantity",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "Part5Id",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "Part5Quantity",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "Part6Id",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "Part6Quantity",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "Part7Id",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "Part7Quantity",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "Part8Id",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "Part8Quantity",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "PartID3",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "PartID4",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "PartID5",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "PartID6",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "PartID7",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "PartID8",
                table: "RepairOrders");
        }
    }
}
