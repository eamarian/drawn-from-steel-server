using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrawnFromSteel.Migrations
{
    /// <inheritdoc />
    public partial class AddSize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "size_modifier",
                table: "ancestry",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "size_squares",
                table: "ancestry",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "size_modifier", "size_squares" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "size_modifier", "size_squares" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "size_modifier", "size_squares" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "size_modifier", "size_squares", "speed" },
                values: new object[] { 2, 1, 6 });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "size_modifier", "size_squares" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "size_modifier", "size_squares" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "size_modifier", "size_squares" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "size_modifier", "size_squares" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "size_modifier", "size_squares" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "size_modifier", "size_squares" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "size_modifier", "size_squares" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "size_modifier", "size_squares" },
                values: new object[] { 2, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "size_modifier",
                table: "ancestry");

            migrationBuilder.DropColumn(
                name: "size_squares",
                table: "ancestry");

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 4,
                column: "speed",
                value: 5);
        }
    }
}
