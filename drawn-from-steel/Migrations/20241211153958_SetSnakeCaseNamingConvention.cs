using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrawnFromSteel.Migrations
{
    /// <inheritdoc />
    public partial class SetSnakeCaseNamingConvention : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Hero",
                table: "Hero");

            migrationBuilder.RenameTable(
                name: "Hero",
                newName: "hero");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "hero",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Level",
                table: "hero",
                newName: "level");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "hero",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_hero",
                table: "hero",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "pk_hero",
                table: "hero");

            migrationBuilder.RenameTable(
                name: "hero",
                newName: "Hero");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Hero",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "level",
                table: "Hero",
                newName: "Level");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Hero",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hero",
                table: "Hero",
                column: "Id");
        }
    }
}
