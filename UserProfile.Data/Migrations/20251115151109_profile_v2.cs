using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserProfile.Data.Migrations
{
    /// <inheritdoc />
    public partial class profile_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "UserDetails");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "UserDetails",
                newName: "LoginId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserDetails",
                table: "UserDetails",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserDetails",
                table: "UserDetails");

            migrationBuilder.RenameTable(
                name: "UserDetails",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "LoginId",
                table: "Users",
                newName: "Username");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }
    }
}
