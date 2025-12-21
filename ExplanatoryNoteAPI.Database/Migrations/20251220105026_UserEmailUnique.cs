using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExplanatoryNoteAPI.Database.Migrations
{
    /// <inheritdoc />
    public partial class UserEmailUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SysUser_Email",
                table: "SysUser",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SysUser_Email",
                table: "SysUser");
        }
    }
}
