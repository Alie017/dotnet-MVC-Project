using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlisverisProje.Migrations
{
    /// <inheritdoc />
    public partial class EF2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Lists");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Lists");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Lists");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Lists");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Lists");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Lists");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Lists");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Lists");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Lists");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Lists");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Lists");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Lists");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Lists");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Lists");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Lists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Lists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Lists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Lists",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Lists",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Lists",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Lists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Lists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Lists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Lists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Lists",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Lists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Lists",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Lists",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
