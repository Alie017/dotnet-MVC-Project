using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlisverisProje.Migrations
{
    /// <inheritdoc />
    public partial class EF1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lists_Products_ProductId",
                table: "Lists");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Lists",
                newName: "DetailId");

            migrationBuilder.RenameIndex(
                name: "IX_Lists_ProductId",
                table: "Lists",
                newName: "IX_Lists_DetailId");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Detail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetailName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Detail_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detail_ProductId",
                table: "Detail",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lists_Detail_DetailId",
                table: "Lists",
                column: "DetailId",
                principalTable: "Detail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lists_Detail_DetailId",
                table: "Lists");

            migrationBuilder.DropTable(
                name: "Detail");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "DetailId",
                table: "Lists",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Lists_DetailId",
                table: "Lists",
                newName: "IX_Lists_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lists_Products_ProductId",
                table: "Lists",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
