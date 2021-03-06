﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Razor_Identity.Data.Migrations
{
    public partial class Added8partstoRepairOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "RepairOrders",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part1Id",
                table: "RepairOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part2Id",
                table: "RepairOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part3Id",
                table: "RepairOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part4Id",
                table: "RepairOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part5Id",
                table: "RepairOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part6Id",
                table: "RepairOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part7Id",
                table: "RepairOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part8Id",
                table: "RepairOrders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RepairOrders_Part1Id",
                table: "RepairOrders",
                column: "Part1Id");

            migrationBuilder.CreateIndex(
                name: "IX_RepairOrders_Part2Id",
                table: "RepairOrders",
                column: "Part2Id");

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
                name: "FK_RepairOrders_Parts_Part1Id",
                table: "RepairOrders",
                column: "Part1Id",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairOrders_Parts_Part2Id",
                table: "RepairOrders",
                column: "Part2Id",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_RepairOrders_Parts_Part1Id",
                table: "RepairOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairOrders_Parts_Part2Id",
                table: "RepairOrders");

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
                name: "IX_RepairOrders_Part1Id",
                table: "RepairOrders");

            migrationBuilder.DropIndex(
                name: "IX_RepairOrders_Part2Id",
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
                name: "Part1Id",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "Part2Id",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "Part3Id",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "Part4Id",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "Part5Id",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "Part6Id",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "Part7Id",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "Part8Id",
                table: "RepairOrders");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "RepairOrders",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);
        }
    }
}
