using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nesops.Oauth2.Library.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_AspNetUsers_ApplicationsAspNetUsersId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_ApplicationsAspNetUsersId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "ApplicationsAspNetUsersId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Applications");

            migrationBuilder.AddColumn<Guid>(
                name: "OwnerIdId",
                table: "Applications",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "ApplicationsAspNetUsersId",
                table: "Applications",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OwnerId",
                table: "Applications",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ApplicationsAspNetUsersId",
                table: "Applications",
                column: "ApplicationsAspNetUsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_AspNetUsers_ApplicationsAspNetUsersId",
                table: "Applications",
                column: "ApplicationsAspNetUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
