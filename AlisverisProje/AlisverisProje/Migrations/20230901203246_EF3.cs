using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlisverisProje.Migrations
{
    /// <inheritdoc />
    public partial class EF3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lists_AspNetUsers_AlisverisProjeUsersId",
                table: "Lists");

            migrationBuilder.DropIndex(
                name: "IX_Lists_AlisverisProjeUsersId",
                table: "Lists");

            migrationBuilder.DropColumn(
                name: "AlisverisProjeUsersId",
                table: "Lists");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Lists");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlisverisProjeUsersId",
                table: "Lists",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Lists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Lists_AlisverisProjeUsersId",
                table: "Lists",
                column: "AlisverisProjeUsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lists_AspNetUsers_AlisverisProjeUsersId",
                table: "Lists",
                column: "AlisverisProjeUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
