using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserProfile.Data.Migrations
{
    /// <inheritdoc />
    public partial class profile_v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE name = 'UserCred' AND type = 'U')
            BEGIN
                CREATE TABLE [UserCred] (
                    [Id] INT NOT NULL,
                    [Password] NVARCHAR(MAX) NOT NULL,
                    CONSTRAINT [PK_UserCred] PRIMARY KEY ([Id]),
                    CONSTRAINT [FK_UserCred_UserDetails_Id] 
                        FOREIGN KEY ([Id]) REFERENCES [UserDetails] ([Id]) ON DELETE CASCADE
                );
            END
            ");
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCred");
        }
    }
}
