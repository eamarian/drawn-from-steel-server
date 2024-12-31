using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrawnFromSteel.Migrations
{
    /// <inheritdoc />
    public partial class SeedKitWeaponAndArmorCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "kit_armor_category",
                columns: new[] { "armor_category_id", "kit_id" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 1, 6 },
                    { 4, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 2, 10 },
                    { 5, 10 },
                    { 3, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 4, 14 },
                    { 5, 14 },
                    { 1, 15 },
                    { 2, 16 },
                    { 5, 16 },
                    { 2, 17 },
                    { 2, 18 },
                    { 3, 19 },
                    { 5, 19 },
                    { 4, 20 },
                    { 1, 21 }
                });

            migrationBuilder.InsertData(
                table: "kit_weapon_category",
                columns: new[] { "kit_id", "weapon_category_id" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 5 },
                    { 3, 4 },
                    { 4, 4 },
                    { 4, 5 },
                    { 5, 6 },
                    { 6, 7 },
                    { 7, 3 },
                    { 8, 3 },
                    { 9, 7 },
                    { 10, 4 },
                    { 11, 1 },
                    { 11, 5 },
                    { 12, 1 },
                    { 13, 2 },
                    { 13, 6 },
                    { 14, 5 },
                    { 15, 1 },
                    { 16, 5 },
                    { 17, 6 },
                    { 18, 5 },
                    { 19, 5 },
                    { 20, 4 },
                    { 21, 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 3, 19 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 5, 19 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 4, 20 });

            migrationBuilder.DeleteData(
                table: "kit_armor_category",
                keyColumns: new[] { "armor_category_id", "kit_id" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 13, 6 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 16, 5 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 17, 6 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 18, 5 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 19, 5 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "kit_weapon_category",
                keyColumns: new[] { "kit_id", "weapon_category_id" },
                keyValues: new object[] { 21, 8 });
        }
    }
}
