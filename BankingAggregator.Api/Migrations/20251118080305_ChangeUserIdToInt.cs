using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankingAggregator.Api.Migrations
{
    /// <inheritdoc />
    public partial class ChangeUserIdToInt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Users_UserId1",
                schema: "banking",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_UserId1",
                schema: "banking",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "UserId1",
                schema: "banking",
                table: "Accounts");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                schema: "banking",
                table: "Accounts",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_UserId",
                schema: "banking",
                table: "Accounts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Users_UserId",
                schema: "banking",
                table: "Accounts",
                column: "UserId",
                principalSchema: "banking",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Users_UserId",
                schema: "banking",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_UserId",
                schema: "banking",
                table: "Accounts");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                schema: "banking",
                table: "Accounts",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                schema: "banking",
                table: "Accounts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_UserId1",
                schema: "banking",
                table: "Accounts",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Users_UserId1",
                schema: "banking",
                table: "Accounts",
                column: "UserId1",
                principalSchema: "banking",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
