using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrawnFromSteel.Migrations
{
    /// <inheritdoc />
    public partial class AddAncestryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ancestry",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    type = table.Column<string>(type: "text", nullable: false),
                    sub_type = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    speed = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ancestry", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "ancestry",
                columns: new[] { "id", "description", "speed", "sub_type", "type" },
                values: new object[,]
                {
                    { 1, "", 5, "", "Devil" },
                    { 2, "", 5, "", "Dragon Knight" },
                    { 3, "", 5, "", "Dwarf" },
                    { 4, "", 5, "Wode", "Elf" },
                    { 5, "", 5, "High", "Elf" },
                    { 6, "", 5, "", "Hakaan" },
                    { 7, "", 5, "", "Human" },
                    { 8, "", 5, "", "Memonek" },
                    { 9, "", 5, "", "Orc" },
                    { 10, "", 5, "", "Polder" },
                    { 11, "", 5, "", "Revenant" },
                    { 12, "", 5, "", "Time Raider" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ancestry");
        }
    }
}
