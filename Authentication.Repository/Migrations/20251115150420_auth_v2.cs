using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Authentication.Repository.Migrations
{
    /// <inheritdoc />
    public partial class auth_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserCred",
                newName: "LoginId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LoginId",
                table: "UserCred",
                newName: "UserId");
        }
    }
}
