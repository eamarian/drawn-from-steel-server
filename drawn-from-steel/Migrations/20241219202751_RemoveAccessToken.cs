using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrawnFromSteel.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAccessToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_session_access_token",
                table: "session");

            migrationBuilder.DropColumn(
                name: "access_token",
                table: "session");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "access_token",
                table: "session",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "ix_session_access_token",
                table: "session",
                column: "access_token",
                unique: true);
        }
    }
}
