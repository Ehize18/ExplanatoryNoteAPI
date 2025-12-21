using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExplanatoryNoteAPI.Database.Migrations
{
    /// <inheritdoc />
    public partial class UserApprove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TEI_IndustrialObject_IndustrialObjectId",
                table: "TEI");

            migrationBuilder.DropForeignKey(
                name: "FK_TEI_NonIndustrialObject_NonIndustrialObjectId",
                table: "TEI");

            migrationBuilder.DropIndex(
                name: "IX_TEI_IndustrialObjectId",
                table: "TEI");

            migrationBuilder.DropIndex(
                name: "IX_TEI_NonIndustrialObjectId",
                table: "TEI");

            migrationBuilder.DropColumn(
                name: "IndustrialObjectId",
                table: "TEI");

            migrationBuilder.DropColumn(
                name: "NonIndustrialObjectId",
                table: "TEI");

            migrationBuilder.AddColumn<bool>(
                name: "IsEmailConfirmed",
                table: "SysUser",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_TEI_IndustialObjectId",
                table: "TEI",
                column: "IndustialObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TEI_NonIndustialObjectId",
                table: "TEI",
                column: "NonIndustialObjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_TEI_IndustrialObject_IndustialObjectId",
                table: "TEI",
                column: "IndustialObjectId",
                principalTable: "IndustrialObject",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TEI_NonIndustrialObject_NonIndustialObjectId",
                table: "TEI",
                column: "NonIndustialObjectId",
                principalTable: "NonIndustrialObject",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TEI_IndustrialObject_IndustialObjectId",
                table: "TEI");

            migrationBuilder.DropForeignKey(
                name: "FK_TEI_NonIndustrialObject_NonIndustialObjectId",
                table: "TEI");

            migrationBuilder.DropIndex(
                name: "IX_TEI_IndustialObjectId",
                table: "TEI");

            migrationBuilder.DropIndex(
                name: "IX_TEI_NonIndustialObjectId",
                table: "TEI");

            migrationBuilder.DropColumn(
                name: "IsEmailConfirmed",
                table: "SysUser");

            migrationBuilder.AddColumn<Guid>(
                name: "IndustrialObjectId",
                table: "TEI",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "NonIndustrialObjectId",
                table: "TEI",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TEI_IndustrialObjectId",
                table: "TEI",
                column: "IndustrialObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TEI_NonIndustrialObjectId",
                table: "TEI",
                column: "NonIndustrialObjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_TEI_IndustrialObject_IndustrialObjectId",
                table: "TEI",
                column: "IndustrialObjectId",
                principalTable: "IndustrialObject",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TEI_NonIndustrialObject_NonIndustrialObjectId",
                table: "TEI",
                column: "NonIndustrialObjectId",
                principalTable: "NonIndustrialObject",
                principalColumn: "Id");
        }
    }
}
