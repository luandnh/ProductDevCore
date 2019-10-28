using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nesops.Oauth2.Library.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_AspNetUsers_OwnerIdId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_OwnerIdId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "OwnerIdId",
                table: "Applications");

            migrationBuilder.AddColumn<Guid>(
                name: "OwnerId",
                table: "Applications",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Applications_OwnerId",
                table: "Applications",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_AspNetUsers_OwnerId",
                table: "Applications",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_AspNetUsers_OwnerId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_OwnerId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Applications");

            migrationBuilder.AddColumn<Guid>(
                name: "OwnerIdId",
                table: "Applications",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Applications_OwnerIdId",
                table: "Applications",
                column: "OwnerIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_AspNetUsers_OwnerIdId",
                table: "Applications",
                column: "OwnerIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
