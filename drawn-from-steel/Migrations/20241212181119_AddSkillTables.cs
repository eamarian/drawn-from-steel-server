using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrawnFromSteel.Migrations
{
    /// <inheritdoc />
    public partial class AddSkillTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "skill_option",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_skill_option", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "skill_pool",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_skill_pool", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "skill_option_pool",
                columns: table => new
                {
                    skill_option_id = table.Column<int>(type: "integer", nullable: false),
                    skill_pool_id = table.Column<int>(type: "integer", nullable: false),
                    count = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_skill_option_pool", x => new { x.skill_option_id, x.skill_pool_id });
                    table.ForeignKey(
                        name: "fk_skill_option_pool_skill_option_skill_option_id",
                        column: x => x.skill_option_id,
                        principalTable: "skill_option",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_skill_option_pool_skill_pool_skill_pool_id",
                        column: x => x.skill_pool_id,
                        principalTable: "skill_pool",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "skill_pool_skill",
                columns: table => new
                {
                    skill_pool_id = table.Column<int>(type: "integer", nullable: false),
                    skill_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_skill_pool_skill", x => new { x.skill_pool_id, x.skill_id });
                    table.ForeignKey(
                        name: "fk_skill_pool_skill_skill_pool_skill_pool_id",
                        column: x => x.skill_pool_id,
                        principalTable: "skill_pool",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_skill_pool_skill_skill_skill_id",
                        column: x => x.skill_id,
                        principalTable: "skill",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "skill_pool_skill_group",
                columns: table => new
                {
                    skill_pool_id = table.Column<int>(type: "integer", nullable: false),
                    skill_group_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_skill_pool_skill_group", x => new { x.skill_pool_id, x.skill_group_id });
                    table.ForeignKey(
                        name: "fk_skill_pool_skill_group_skill_group_skill_group_id",
                        column: x => x.skill_group_id,
                        principalTable: "skill_group",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_skill_pool_skill_group_skill_pool_skill_pool_id",
                        column: x => x.skill_pool_id,
                        principalTable: "skill_pool",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "skill_option",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "One skill from the exploration or interpersonal skill groups.", "env-nomadic" },
                    { 2, "One skill from the crafting or lore skill groups.", "env-rural" },
                    { 3, "One skill from the interpersonal or lore skill groups.", "env-secluded" },
                    { 4, "One skill from the interpersonal or intrigue skill groups.", "env-urban" },
                    { 5, "One skill from the crafting or exploration skill groups.", "env-wilderness" },
                    { 6, "One skill from the exploration or intrigue skill groups.", "org-anarchic" },
                    { 7, "One skill from the intrigue or lore skill groups.", "org-bureaucratic" },
                    { 8, "One skill from the crafting or interpersonal skill groups.", "org-communal" },
                    { 9, "One skill from the lore skill group.", "upb-academic" },
                    { 10, "The Music or Perform skill, or one skill from the crafting skill group.", "upb-creative" },
                    { 11, "One skill from the intrigue skill group.", "upb-illegal" },
                    { 12, "One of the Blacksmithing or Handle Animals skills, or one skill from the exploration skill group.", "upb-labor" },
                    { 13, " One of the Alertness, Blacksmithing, Climb, Endurance, Fletching, Intimidate, Jump, Monsters, Ride, or Track skills.", "upb-martial" },
                    { 14, "One skill from the interpersonal skill group.", "upb-noble" },
                    { 15, " Two skills from the crafting skill group.", "car-artisan" },
                    { 16, "The Criminal Underworld skill, plus two skills from the intrigue skill group.", "car-criminal" },
                    { 17, "Two skills from the exploration skill group.", "car-gladiator" },
                    { 18, "The Endurance skill, plus choose any two skills from Blacksmithing or the skills of the exploration skill group.", "car-laborer" },
                    { 19, "The Magic skill, plus two skills from the lore skill group.", "car-magesapprentice" },
                    { 20, "The Music or Performance skill, plus two skills from the interpersonal skill group.", "car-performer" },
                    { 21, "Two skills from the lore skill group.", "car-sage" },
                    { 22, "One skill from each of the exploration skill group and the intrigue skill group.", "car-soldier" },
                    { 23, "Choose any two skills from the interpersonal or lore skill groups.", "cls-conduit" },
                    { 24, "You gain Magic and can choose any three skills from the crafting or lore skill groups.", "cls-elementalist" },
                    { 25, "Nature, plus choose any two skills from the exploration or intrigue skill groups.", "cls-fury" },
                    { 26, "Hide and Sneak, plus choose any five skills from Criminal Underworld or the skills of the exploration, interpersonal, or intrigue skill groups.", "cls-shadow" },
                    { 27, "Lead, plus choose any two skills from Alertness, Architecture, Blacksmithing, Brag, Culture, Empathize, Fletching, History, Mechanics, Monsters, Search, or the skills of the exploration skill group.", "cls-tactician" }
                });

            migrationBuilder.InsertData(
                table: "skill_pool",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "env-nomadic" },
                    { 2, "env-rural" },
                    { 3, "env-secluded" },
                    { 4, "env-urban" },
                    { 5, "env-wilderness" },
                    { 6, "org-anarchic" },
                    { 7, "org-bureaucratic" },
                    { 8, "org-communal" },
                    { 9, "upb-academic" },
                    { 10, "upb-creative" },
                    { 11, "upb-illegal" },
                    { 12, "upb-labor" },
                    { 13, "upb-martial" },
                    { 14, "upb-noble" },
                    { 15, "car-artisan" },
                    { 16, "car-criminal-1" },
                    { 17, "car-criminal-2" },
                    { 18, "car-gladiator" },
                    { 19, "car-laborer-1" },
                    { 20, "car-laborer-2" },
                    { 21, "car-magesapprentice-1" },
                    { 22, "car-magesapprentice-2" },
                    { 23, "car-performer-1" },
                    { 24, "car-performer-2" },
                    { 25, "car-sage" },
                    { 26, "car-soldier-1" },
                    { 27, "car-soldier-2" },
                    { 28, "cls-conduit" },
                    { 29, "cls-elementalist-1" },
                    { 30, "cls-elementalist-2" },
                    { 31, "cls-fury-1" },
                    { 32, "cls-fury-2" },
                    { 33, "cls-shadow-1" },
                    { 34, "cls-shadow-2" },
                    { 35, "cls-tactician-1" },
                    { 36, "cls-tactician-2" }
                });

            migrationBuilder.InsertData(
                table: "skill_option_pool",
                columns: new[] { "skill_option_id", "skill_pool_id", "count" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 1 },
                    { 5, 5, 1 },
                    { 6, 6, 1 },
                    { 7, 7, 1 },
                    { 8, 8, 1 },
                    { 9, 9, 1 },
                    { 10, 10, 1 },
                    { 11, 11, 1 },
                    { 12, 12, 1 },
                    { 13, 13, 1 },
                    { 14, 14, 1 },
                    { 15, 15, 2 },
                    { 16, 16, 1 },
                    { 16, 17, 2 },
                    { 17, 18, 2 },
                    { 18, 19, 1 },
                    { 18, 20, 2 },
                    { 19, 21, 1 },
                    { 19, 22, 2 },
                    { 20, 23, 1 },
                    { 20, 24, 2 },
                    { 21, 25, 2 },
                    { 22, 26, 1 },
                    { 22, 27, 1 },
                    { 23, 28, 2 },
                    { 24, 29, 1 },
                    { 24, 30, 3 },
                    { 25, 31, 1 },
                    { 25, 32, 2 },
                    { 26, 33, 2 },
                    { 26, 34, 5 },
                    { 27, 35, 1 },
                    { 27, 36, 2 }
                });

            migrationBuilder.InsertData(
                table: "skill_pool_skill",
                columns: new[] { "skill_id", "skill_pool_id" },
                values: new object[,]
                {
                    { 28, 10 },
                    { 29, 10 },
                    { 3, 12 },
                    { 23, 12 },
                    { 3, 13 },
                    { 4, 13 },
                    { 9, 13 },
                    { 11, 13 },
                    { 14, 13 },
                    { 17, 13 },
                    { 25, 13 },
                    { 32, 13 },
                    { 43, 13 },
                    { 48, 13 },
                    { 45, 16 },
                    { 11, 19 },
                    { 3, 20 },
                    { 47, 21 },
                    { 28, 23 },
                    { 29, 23 },
                    { 47, 29 },
                    { 49, 31 },
                    { 37, 33 },
                    { 42, 33 },
                    { 45, 34 },
                    { 26, 35 },
                    { 2, 36 },
                    { 3, 36 },
                    { 4, 36 },
                    { 7, 36 },
                    { 19, 36 },
                    { 20, 36 },
                    { 32, 36 },
                    { 41, 36 },
                    { 44, 36 },
                    { 46, 36 },
                    { 48, 36 }
                });

            migrationBuilder.InsertData(
                table: "skill_pool_skill_group",
                columns: new[] { "skill_group_id", "skill_pool_id" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 1 },
                    { 1, 2 },
                    { 5, 2 },
                    { 3, 3 },
                    { 5, 3 },
                    { 3, 4 },
                    { 4, 4 },
                    { 1, 5 },
                    { 2, 5 },
                    { 2, 6 },
                    { 4, 6 },
                    { 4, 7 },
                    { 5, 7 },
                    { 1, 8 },
                    { 3, 8 },
                    { 5, 9 },
                    { 1, 10 },
                    { 4, 11 },
                    { 2, 12 },
                    { 3, 14 },
                    { 1, 15 },
                    { 4, 17 },
                    { 2, 18 },
                    { 2, 20 },
                    { 5, 22 },
                    { 3, 24 },
                    { 5, 25 },
                    { 2, 26 },
                    { 4, 27 },
                    { 3, 28 },
                    { 5, 28 },
                    { 1, 30 },
                    { 5, 30 },
                    { 2, 32 },
                    { 4, 32 },
                    { 2, 34 },
                    { 3, 34 },
                    { 4, 34 },
                    { 2, 36 }
                });

            migrationBuilder.CreateIndex(
                name: "ix_skill_option_pool_skill_pool_id",
                table: "skill_option_pool",
                column: "skill_pool_id");

            migrationBuilder.CreateIndex(
                name: "ix_skill_pool_skill_skill_id",
                table: "skill_pool_skill",
                column: "skill_id");

            migrationBuilder.CreateIndex(
                name: "ix_skill_pool_skill_group_skill_group_id",
                table: "skill_pool_skill_group",
                column: "skill_group_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "skill_option_pool");

            migrationBuilder.DropTable(
                name: "skill_pool_skill");

            migrationBuilder.DropTable(
                name: "skill_pool_skill_group");

            migrationBuilder.DropTable(
                name: "skill_option");

            migrationBuilder.DropTable(
                name: "skill_pool");
        }
    }
}
