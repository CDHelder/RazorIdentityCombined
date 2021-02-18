using Microsoft.EntityFrameworkCore.Migrations;

namespace Razor_Identity.Data.Migrations
{
    public partial class DeletePartList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepairOrders_PartLists_PartListId",
                table: "RepairOrders");

            migrationBuilder.DropTable(
                name: "PartPartList");

            migrationBuilder.DropTable(
                name: "PartLists");

            migrationBuilder.DropIndex(
                name: "IX_RepairOrders_PartListId",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "PartListId",
                table: "RepairOrders");

            migrationBuilder.DropColumn(
                name: "PartListId",
                table: "Parts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PartListId",
                table: "RepairOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartListId",
                table: "Parts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PartLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RepairOrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PartPartList",
                columns: table => new
                {
                    PartListsId = table.Column<int>(type: "int", nullable: false),
                    PartsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartPartList", x => new { x.PartListsId, x.PartsId });
                    table.ForeignKey(
                        name: "FK_PartPartList_PartLists_PartListsId",
                        column: x => x.PartListsId,
                        principalTable: "PartLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartPartList_Parts_PartsId",
                        column: x => x.PartsId,
                        principalTable: "Parts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RepairOrders_PartListId",
                table: "RepairOrders",
                column: "PartListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PartPartList_PartsId",
                table: "PartPartList",
                column: "PartsId");

            migrationBuilder.AddForeignKey(
                name: "FK_RepairOrders_PartLists_PartListId",
                table: "RepairOrders",
                column: "PartListId",
                principalTable: "PartLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
