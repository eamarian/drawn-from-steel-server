using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrawnFromSteel.Migrations
{
    /// <inheritdoc />
    public partial class AuthUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "session",
                columns: table => new
                {
                    session_token = table.Column<string>(type: "text", nullable: false),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    expires = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_session", x => x.session_token);
                    table.ForeignKey(
                        name: "fk_session_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_user_email",
                table: "user",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_account_provider_account_id_provider",
                table: "account",
                columns: new[] { "provider_account_id", "provider" });

            migrationBuilder.CreateIndex(
                name: "ix_session_user_id",
                table: "session",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "session");

            migrationBuilder.DropIndex(
                name: "ix_user_email",
                table: "user");

            migrationBuilder.DropIndex(
                name: "ix_account_provider_account_id_provider",
                table: "account");
        }
    }
}
