using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrawnFromSteel.Migrations
{
    /// <inheritdoc />
    public partial class Backerkit2Updates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 16, 16 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 16, 17 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 17, 18 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 18, 19 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 18, 20 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 19, 21 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 19, 22 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 20, 23 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 20, 24 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 21, 25 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 22, 26 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 22, 27 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 23, 28 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 24, 29 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 24, 30 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 25, 31 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 25, 32 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 26, 33 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 26, 34 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 27, 35 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 27, 36 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 28, 10 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 29, 10 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 23, 12 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 9, 13 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 14, 13 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 17, 13 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 25, 13 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 32, 13 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 43, 13 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 48, 13 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 45, 16 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 11, 19 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 3, 20 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 47, 21 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 28, 23 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 29, 23 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 47, 29 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 49, 31 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 37, 33 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 42, 33 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 45, 34 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 26, 35 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 2, 36 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 3, 36 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 4, 36 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 7, 36 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 19, 36 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 20, 36 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 32, 36 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 41, 36 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 44, 36 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 46, 36 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 48, 36 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 4, 17 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 2, 20 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 5, 22 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 3, 24 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 5, 25 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 2, 26 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 4, 27 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 3, 28 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 5, 28 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 1, 30 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 5, 30 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 4, 32 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 3, 34 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 4, 34 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 2, 36 });

            migrationBuilder.CreateTable(
                name: "career",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    name = table.Column<string>(type: "varchar(20)", nullable: false),
                    description = table.Column<string>(type: "varchar(300)", nullable: false),
                    language_bonus = table.Column<int>(type: "integer", nullable: false),
                    renown_bonus = table.Column<int>(type: "integer", nullable: false),
                    wealth_bonus = table.Column<int>(type: "integer", nullable: false),
                    project_point_bonus = table.Column<int>(type: "integer", nullable: false),
                    perk_type_id = table.Column<int>(type: "integer", nullable: false),
                    skill_option_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_career", x => x.id);
                    table.ForeignKey(
                        name: "fk_career_perk_type_perk_type_id",
                        column: x => x.perk_type_id,
                        principalTable: "perk_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_career_skill_option_skill_option_id",
                        column: x => x.skill_option_id,
                        principalTable: "skill_option",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "environment",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    name = table.Column<string>(type: "varchar(10)", nullable: false),
                    description = table.Column<string>(type: "varchar(1000)", nullable: false),
                    skill_option_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_environment", x => x.id);
                    table.ForeignKey(
                        name: "fk_environment_skill_option_skill_option_id",
                        column: x => x.skill_option_id,
                        principalTable: "skill_option",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hero_class",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    name = table.Column<string>(type: "varchar(15)", nullable: false),
                    description = table.Column<string>(type: "varchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_hero_class", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "language",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    name = table.Column<string>(type: "varchar(30)", nullable: false),
                    description = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_language", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "organization",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    name = table.Column<string>(type: "varchar(15)", nullable: false),
                    description = table.Column<string>(type: "varchar(1500)", nullable: false),
                    skill_option_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_organization", x => x.id);
                    table.ForeignKey(
                        name: "fk_organization_skill_option_skill_option_id",
                        column: x => x.skill_option_id,
                        principalTable: "skill_option",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "upbringing",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    name = table.Column<string>(type: "varchar(10)", nullable: false),
                    description = table.Column<string>(type: "varchar(500)", nullable: false),
                    skill_option_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_upbringing", x => x.id);
                    table.ForeignKey(
                        name: "fk_upbringing_skill_option_skill_option_id",
                        column: x => x.skill_option_id,
                        principalTable: "skill_option",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "career_question",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    career_id = table.Column<int>(type: "integer", nullable: false),
                    question = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_career_question", x => x.id);
                    table.ForeignKey(
                        name: "fk_career_question_career_career_id",
                        column: x => x.career_id,
                        principalTable: "career",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "inciting_incident",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    name = table.Column<string>(type: "varchar(30)", nullable: false),
                    description = table.Column<string>(type: "varchar(500)", nullable: false),
                    career_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_inciting_incident", x => x.id);
                    table.ForeignKey(
                        name: "fk_inciting_incident_career_career_id",
                        column: x => x.career_id,
                        principalTable: "career",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "culture_preset_ancestry",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    ancestry_id = table.Column<int>(type: "integer", nullable: false),
                    language_id = table.Column<int>(type: "integer", nullable: false),
                    environment_id = table.Column<int>(type: "integer", nullable: false),
                    organization_id = table.Column<int>(type: "integer", nullable: false),
                    uprbringing_id = table.Column<int>(type: "integer", nullable: false),
                    upbringing_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_culture_preset_ancestry", x => x.id);
                    table.ForeignKey(
                        name: "fk_culture_preset_ancestry_ancestry_ancestry_id",
                        column: x => x.ancestry_id,
                        principalTable: "ancestry",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_culture_preset_ancestry_environment_environment_id",
                        column: x => x.environment_id,
                        principalTable: "environment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_culture_preset_ancestry_language_language_id",
                        column: x => x.language_id,
                        principalTable: "language",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_culture_preset_ancestry_organization_organization_id",
                        column: x => x.organization_id,
                        principalTable: "organization",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_culture_preset_ancestry_upbringing_upbringing_id",
                        column: x => x.upbringing_id,
                        principalTable: "upbringing",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "culture_preset_community",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    community = table.Column<string>(type: "varchar(30)", nullable: false),
                    environment_id = table.Column<int>(type: "integer", nullable: false),
                    organization_id = table.Column<int>(type: "integer", nullable: false),
                    uprbringing_id = table.Column<int>(type: "integer", nullable: false),
                    upbringing_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_culture_preset_community", x => x.id);
                    table.ForeignKey(
                        name: "fk_culture_preset_community_environment_environment_id",
                        column: x => x.environment_id,
                        principalTable: "environment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_culture_preset_community_organization_organization_id",
                        column: x => x.organization_id,
                        principalTable: "organization",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_culture_preset_community_upbringing_upbringing_id",
                        column: x => x.upbringing_id,
                        principalTable: "upbringing",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "career",
                columns: new[] { "id", "description", "language_bonus", "name", "perk_type_id", "project_point_bonus", "renown_bonus", "skill_option_id", "wealth_bonus" },
                values: new object[,]
                {
                    { 1, "You worked as a spy for a government or organization.", 2, "Agent", 4, 0, 0, 15, 1 },
                    { 2, "Career? Who needs a career when you’re born into money! Or marry into it! Or con your way into it! Whatever the case, you didn’t need to work thanks to (someone’s) generational wealth.", 1, "Aristocrat", 5, 0, 1, 16, 1 },
                    { 3, "You made and sold useful wares.", 1, "Artisan", 1, 240, 0, 17, 1 },
                    { 4, "You lived by going to a tavern, crossroads, city street, or other busy area and begging passersby for money or food.", 2, "Beggar", 3, 0, 0, 18, 1 },
                    { 5, "You once worked as a bandit, insurgent, smuggler, outlaw, or even as an assassin.", 1, "Criminal", 4, 120, 0, 19, 1 },
                    { 6, "You worked in a church, temple, or other religious institution as part of the clergy.", 0, "Disciple", 6, 120, 0, 20, 1 },
                    { 7, "You ventured into uncharted areas and made your living as a cartographer, researcher, resource seeker, or treasure hunter.", 2, "Explorer", 2, 0, 0, 21, 1 },
                    { 8, "You grew crops or cared for livestock.", 1, "Farmer", 2, 120, 0, 22, 1 },
                    { 9, "In the past, you entertained the masses with flashy displays of violence in the arena.", 1, "Gladiator", 2, 0, 2, 23, 1 },
                    { 10, "You worked as a farmer, builder, clothes washer, forester, miner, or some other profession engaged in hard manual labor.", 1, "Laborer", 2, 120, 0, 24, 1 },
                    { 11, "For long years, you studied magic under the mentorship of a more experienced mage.", 1, "Mage's Apprentice", 6, 0, 1, 25, 1 },
                    { 12, "You can sing, act, or dance well enough that people actually pay to see you do it. Imagine that!", 0, "Performer", 3, 0, 2, 26, 1 },
                    { 13, "You worked as a leader within a formal, bureaucratic organization or government. You might have been appointed, born, or elected into your position, but getting people to agree and making decisions for the people you serve (or who served you) was your job.", 1, "Politician", 3, 0, 1, 27, 1 }
                });

            migrationBuilder.InsertData(
                table: "environment",
                columns: new[] { "id", "description", "name", "skill_option_id" },
                values: new object[,]
                {
                    { 1, "A nomadic culture travels from place to place to survive. They might follow animal migrations or the weather, travel to sell their wares or services, or simply enjoy a restless lifestyle full of new experiences and peoples. Those who grow up in nomadic cultures learn to navigate the wilderness and interact with others.", "Nomadic", 1 },
                    { 2, "A rural culture is one located in a town, village, or smaller settled enclave. People dwelling in such places often cultivate the land, trade goods or services with travelers passing through, harvest fish from the sea, or mine metals and gems from the earth.Living among a small population, most folks in a rural community learn a trade and are handed down bits of essential knowledge to help their community survive. For example, when a rural culture has only one blacksmith, it’s important to have an apprentice already learning at the anvil well before that smith starts to get old. If the only priest in town gets the sniffles, folks want an acolyte ready to wear the fancy robes should the worst occur.", "Rural", 2 },
                    { 3, "A secluded culture is based in one relatively close-quarters structure—a building, a cavern, and so forth—and interacts with other cultures only rarely. Such places are often buildings or complexes such as monasteries, castles, or prisons. Folk in a secluded culture have little or no reason to leave their home or interact with other cultures on the outside, but might have an awareness of those cultures and of events happening outside their enclave. When people live together in close quarters, they typically learn to get along. They often spend much time in study or introspection, as there is not much else to do in seclusion.", "Secluded", 3 },
                    { 4, "An urban culture is always centered in a city. Such a culture might arise within the walls of Capital, a massive metropolis with a cosmopolitan population; within a network of caverns that hold an underground city; or in any other place where a large population lives relatively close together. The people of urban cultures often learn to effectively misdirect others in order to navigate the crowds and the political machinations that can come with city life.", "Urban", 4 },
                    { 5, "A wilderness culture doesn’t attempt to tame the terrain in which its people live, whether desert, forest, swamp, tundra, ocean, or more exotic climes. Instead, the folk of such a culture thrive amid nature, taking their sustenance and shelter from the land itself. A wilderness culture might be a circle of druids protecting a great wode, a band of brigands hiding out in desert caves, or a camp of orc mercenaries who call the trackless mountains home. People in a wilderness culture learn how to use the land for all they need to live, typically crafting their own tools, clothing, and more.", "Wilderness", 5 }
                });

            migrationBuilder.InsertData(
                table: "hero_class",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "A censor is a trained warrior devoted to a saint or god. They hunt down forces of evil using melee weapons and magic granted to them by their divine patron and specialize in locking down one enemy during combat and hunting the wicked.", "Censor" },
                    { 2, "A conduit is the devoted priest of a saint or god. They wield divine magic that smites enemies with holy energy and supports their allies. They are the best healing class in this book.", "Conduit" },
                    { 3, "An elementalist studies the elemental forces of the timescape and controls earth, fire, the void, and more with magic. Many of their abilities cover wide areas of the map and they have a versatile array of tricks that allow them to control the battlefield and accomplish tasks outside of combat.", "Elementalist" },
                    { 4, "Coursing with the rage of the Primordial Chaos in their veins, a fury is a mobile warrior who gets up close and personal with enemies to dish out lots of damage. If you want to leap around the battlefield felling your foes and breaking down walls, then the fury is the class for you.", "Fury" },
                    { 5, "Disciplined and calm, the null is an unarmed warrior who creates an aura that quells the supernatural and other special effects created by their enemies. They use psionics to make their body stronger than any steel and faster than any steed.", "Null" },
                    { 6, "Stalking foes from the darkness, the shadow is an expert assassin and thief who can use melee and ranged attacks to great effect if they get the drop on their foe. They also utilize magic to help them stay mobile on the battlefield and sneak up on their prey.", "Shadow" },
                    { 7, "A brilliant strategist and weapons master, the tactician excels at granting allies more movement and actions in the battlefield and supports their allies outside of combat as well. If you want to inspire your friends to greatness, then the tactician class is for you", "Tactician" },
                    { 8, "A talent is the master of psionics, manifesting powers that manipulate objects, minds, and time. These heroes can reach far into themselves to use abilities even when they don’t have enough heroic resources—if they’re willing to face the cost.", "Talent" },
                    { 9, "A troubadour inspires their allies with storytelling and swordplay that is as much an art as it is an act of war. Their quips, songs, poems, and epic tales produce actual magic that harms foes and bolsters allies. They can even use their magic to tweak the campaign’s story in real time to better suit their needs.", "Troubadour" }
                });

            migrationBuilder.InsertData(
                table: "language",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "Language of contract law. Spoken commonly by Devils and Hobgoblins.", "Anjali" },
                    { 2, "Native language of Axion, and the common language of the timescape by trade. Spoken commonly by Memonek.", "Axiomatic" },
                    { 3, "Common tongue of Orden.", "Caelian" },
                    { 4, "Offshoot of Cyllinric. Spoken commonly by Angulotls.", "Filliaric" },
                    { 5, "Spoken commonly by Bredbeddles, Giants, Ogres, and Trolls.", "High Kuric" },
                    { 6, "Language of interspecies diplomacy. Spoken commonly by High Elves.", "Hyrallic" },
                    { 7, "Spoken commonly by Shadow Elves.", "Illyvric" },
                    { 8, "Offshoot of Zaliac. Spoken commonly by Orcs.", "Kalliak" },
                    { 9, "Patois of Vastariax and Caelian. Spoken commonly by Kobolds.", "Kethiac" },
                    { 10, "Offshoot of Kheltivari. Spoken commonly by Bugbears and Fey.", "Khelt" },
                    { 11, "Distant offshoot of Khamish. Spoken commonly by Polders and Humans of Khoursir.", "Khoursirian" },
                    { 12, "Spoken commonly by Elementals.", "Low Kuric" },
                    { 13, "A symbolic language shared among native telepaths. Spoken commonly by Voiceless Talkers.", "Mindspeech" },
                    { 14, "Incomplete offshoot of Tholl. Spoken commonly by Demons.", "Proto-Ctholl" },
                    { 15, "Spoken commonly by Goblins and Radenwights.", "Szetch" },
                    { 16, "Language of magic. Spoken commonly by Elder Dragons.", "The First Language" },
                    { 17, "Spoken commonly by Gnolls.", "Tholl" },
                    { 18, "Spoken commonly by Olothec.", "Urollialic" },
                    { 19, "Spoken commonly by Gnomes, Olothecs, Trolls, and Voiceless Talkers.", "Variac" },
                    { 20, "Spoken commonly by Dragons and Dragon Knights.", "Vastariax" },
                    { 21, "Offshoot of the Stone Giant dialect of High Kuric. Spoken commonly by Hakaan.", "Vhoric" },
                    { 22, "Spoken commonly by Time-Raiders.", "Voll" },
                    { 23, "Language of druids. Spoken commonly by Wode Elves.", "Yllyric" },
                    { 24, "Spoken commonly by Overminds.", "Za'hariax" },
                    { 25, "Language of engineering. Spoken commonly by Dwarves.", "Zaliac" },
                    { 26, "Spoken commonly by Humans of The Gol region.", "Uvalic" },
                    { 27, "Spoken commonly by Humans of Higara.", "Higaran" },
                    { 28, "Spoken commonly by Humans of Ix.", "Oaxuatl" },
                    { 29, "Spoken commonly by Humans of Khemhara.", "Khemaric" },
                    { 31, "Spoken commonly by Humans of Phaedros.", "Phaedran" },
                    { 32, "Spoken commonly by Humans of Rioja.", "Riojan" },
                    { 33, "Spoken commonly by Humans of Vanigar.", "Vaniric" },
                    { 34, "Spoken commonly by Humans of Vasloria.", "Vaslorian" },
                    { 35, "Dead language of the Sun Elves.", "High Rhyvian" },
                    { 36, "Dead language of the Beast Lords.", "Khamish" },
                    { 37, "Dead language of the Old Fae.", "Kheltivari" },
                    { 38, "Dead language of the Sky Elves.", "Low Rhivian" },
                    { 39, "Dead language of the Olothec and Voiceless Talkers.", "Old Variac" },
                    { 40, "Dead language of the Old Elementals.", "Phorialtic" },
                    { 41, "Dead language of the Steel Dwarves.", "Rallarian" },
                    { 42, "Dead language of the Star Elves.", "Ullorvic" }
                });

            migrationBuilder.InsertData(
                table: "organization",
                columns: new[] { "id", "description", "name", "skill_option_id" },
                values: new object[,]
                {
                    { 1, "In an anarchic culture, there are no rules and no one person leads the others. This might sound like complete chaos— people taking what they want when they want it—and some cultures that practice anarchy are. Other anarchic cultures are peaceful places where people mostly work for themselves, their friends, or their family, but rely on the whole group when times get tough. Many anarchic cultures come together when the need arises, but they leave day-to-day responsibilities up to the individual. If an informal leader appears, it’s because each member of the culture has decided to follow that person for 41 Draw Steel © 2024 MCDM Productions, LLC a time, and the leader enjoys their power only as long as they keep everyone happy. A group of rangers who protect a vast forest, a gang of rebels fighting against a tyrannical despot leader, and a bandit group roving the wilds without a leader are all anarchic cultures. Most anarchic cultures operate outside of settled lands, sticking to the wilds, city sewers, or other secret places. For even when such cultures are harmless, their members know that outsiders might try to impose rules upon them if they live in the same place. As such, many folks in anarchic cultures learn how to navigate the wilds and fend for themselves while avoiding the danger that other folks can represent.", "Anarchic", 6 },
                    { 2, "Bureaucratic cultures are steeped in official leadership and formally recorded laws. Members of such a culture are often ranked in power according to those laws, with a small group of people holding the power to rule according to birthright, popular vote, or some other official and measurable standard. Many bureaucratic communities have one person at the very top, though others might be ruled by a council. A trade guild with a guildmaster, treasurer, secretary, and a charter of rules and regulations for membership; a feudal lord who rules over a group of knights, who in turn rule over peasants who work the land; and a militaristic society with ranks and rules that its people must abide are all examples of bureaucratic cultures. Those who thrive in bureaucratic cultures don’t just follow the rules. They know how to use those rules to their advantage, either bending, changing, or reinterpreting policy to advance their own interests. Schmoozing with those who make the laws is often key to this approach. Others in a bureaucratic culture might specialize in operating outside the strict regulations that govern the culture without getting caught.", "Bureaucratic", 7 },
                    { 3, "A communal culture is a place where all members of the collective are considered equal. The community works together to make important decisions that affect the majority of the culture. While they elect leaders to carry out these decisions and organize their efforts, each person has a relatively equal say in how the culture operates, and everyone contributes to help their people survive and thrive. Individuals often share the burdens of governing, physical labor, childcare, and other duties. A collective of farmers who work together to cultivate and protect their land without a noble, a city of pirates where each person can do as they wish, and a traveling theatrical troupe whose members vote on every artistic and administrative decision are all communal cultures. People in communal cultures learn that their voice and individuality has worth, as do the opinions and hard work of others.", "Communal", 8 }
                });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "description", "name" },
                values: new object[] { "Create items out of wood", "Carpentry" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "description", "name" },
                values: new object[] { "Create delicious dishes", "Cooking" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "description", "name" },
                values: new object[] { "Make ranged weapons and ammunition", "Fletching" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "description", "name" },
                values: new object[] { "Create false badges, documents, and other items", "Forgery" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "description", "name" },
                values: new object[] { "Create bracelets, crowns, rings, and other jewelry", "Jewelry" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "description", "name" },
                values: new object[] { "Build machines and clockwork items", "Mechanics" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "description", "name", "skill_group_id" },
                values: new object[] { "Craft cloth and leather clothing", "Tailoring", 1 });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "description", "name", "skill_group_id" },
                values: new object[] { "Move up vertical surfaces", "Climb", 1 });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "description", "name" },
                values: new object[] { "Control vehicles", "Drive" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "description", "name" },
                values: new object[] { "Remain engaged in strenuous activity over a long period of time", "Endurance" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "description", "name" },
                values: new object[] { "Move across unsteady or narrow surfaces, and tumble", "Gymnastics" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "description", "name" },
                values: new object[] { "Use mundane first aid", "Heal" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "description", "name" },
                values: new object[] { "Leap vertical and horizontal distances", "Jump" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "description", "name" },
                values: new object[] { "Pick up, carry, and throw heavy objects", "Lift" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "description", "name" },
                values: new object[] { "Read a map and travel without becoming lost", "Navigate" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "description", "name", "skill_group_id" },
                values: new object[] { "Ride and control a mount who isn’t sapient, such as a horse", "Ride", 2 });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "description", "name", "skill_group_id" },
                values: new object[] { "Move through deep liquid", "Swim", 2 });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "description", "name" },
                values: new object[] { "Impress others with stories of your deeds", "Brag" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "description", "name" },
                values: new object[] { "Relate to someone on a personal level", "Empathize" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "description", "name" },
                values: new object[] { "Attract romantic attention from someone", "Flirt" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "description", "name" },
                values: new object[] { "Make bets with others", "Gamble" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "description", "name" },
                values: new object[] { "Interact with animal wildlife that isn’t sapient", "Handle Animals" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "description", "name" },
                values: new object[] { "Obtain information from a creature withholding it", "Interrogate" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "description", "name" },
                values: new object[] { "Awe or scare a creature", "Intimidate" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "description", "name" },
                values: new object[] { "Inspire people to action", "Lead" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "description", "name" },
                values: new object[] { "Convince someone that a falsehood is true", "Lie" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "description", "name" },
                values: new object[] { "Perform music vocally or with an instrument", "Music" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "description", "name" },
                values: new object[] { "Engage in dance, oratory, acting, or some other physical performance", "Perform" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "description", "name", "skill_group_id" },
                values: new object[] { "Convince someone to agree with you through use of your charms and grace", "Persuade", 3 });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "description", "name", "skill_group_id" },
                values: new object[] { "Read the emotions and body language of other creatures", "Read Person", 3 });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "description", "name" },
                values: new object[] { "Intuitively sense the details of your surroundings", "Alertness" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "description", "name" },
                values: new object[] { "Hide an object on your person or in your environment", "Conceal Object" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "description", "name" },
                values: new object[] { "Change your appearance to look like a different person", "Disguise" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "description", "name" },
                values: new object[] { "Actively listen to something that is hard to hear, such as a whispered conversation through a door", "Eavesdrop" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "description", "name" },
                values: new object[] { "Escape from bonds such as rope or manacles", "Escape Artist" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "description", "name" },
                values: new object[] { "Conceal yourself from others’ observation", "Hide" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "description", "name" },
                values: new object[] { "Open a lock without using the key", "Pick Lock" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "description", "name" },
                values: new object[] { "Steal an item that another person wears or carries without them noticing", "Pick Pocket" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "description", "name" },
                values: new object[] { "Disable a mechanical device such as a trap", "Sabotage" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "description", "name" },
                values: new object[] { "Actively search an environment for important details and items", "Search" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "description", "name", "skill_group_id" },
                values: new object[] { "Move silently", "Sneak", 4 });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "description", "name", "skill_group_id" },
                values: new object[] { "Follow a trail that another creature has left behind", "Track", 4 });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "description", "name" },
                values: new object[] { "Knowing about a culture’s customs, folktales, and taboos", "Culture" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "description", "name" },
                values: new object[] { "Knowing about criminal organizations, their crimes, their relationships, and their leaders", "Criminal Underworld" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "description", "name" },
                values: new object[] { "Knowing about significant past events", "History" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "description", "name" },
                values: new object[] { "Knowing about magical places, spells, rituals, items, and phenomena", "Magic" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "description", "name" },
                values: new object[] { "Knowing monster ecology, strengths, and weaknesses", "Monsters" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "description", "name" },
                values: new object[] { "Knowing about natural flora, fauna, and weather", "Nature" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "description", "name" },
                values: new object[] { "Knowing about psionic places, spells, rituals, items, and phenomena", "Psionics" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "description", "name" },
                values: new object[] { "Knowing about religious mythology, practices, and rituals", "Religion" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "description", "name" },
                values: new object[] { "Knowing gossip, legends, and uncertain truths", "Rumors" });

            migrationBuilder.InsertData(
                table: "skill",
                columns: new[] { "id", "description", "name", "skill_group_id" },
                values: new object[,]
                {
                    { 55, "Knowing noble etiquette and the leadership and power dynamics of noble families", "Society", 5 },
                    { 56, "Knowing about battle tactics and logistics", "Strategy", 5 },
                    { 57, "Knowing about the various planets of the timescape", "Timescape", 5 }
                });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "description", "name" },
                values: new object[] { "The Sneak skill, plus one skill from the interpersonal skill group and one skill from the intrigue skill group.", "car-agent" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "description", "name" },
                values: new object[] { "One skill from the interpersonal skill group and one skill from the lore skill group.", "car-aristocrat" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "description", "name" },
                values: new object[] { "Two skills from the crafting skill group.", "car-artisan" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "description", "name" },
                values: new object[] { "The Rumors skill, plus one skill from the exploration skill group and one skill from the interpersonal skill group.", "car-beggar" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "description", "name" },
                values: new object[] { "The Criminal Underworld skill, plus two skills from the intrigue skill group.", "car-criminal" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "description", "name" },
                values: new object[] { "The Religion skill, plus two skills from the lore skill group", "car-disciple" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "description", "name" },
                values: new object[] { "The Navigate skill, plus two skills from the exploration skill group.", "car-explorer" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "description", "name" },
                values: new object[] { "The Handle Animals skill, plus two skills from the exploration skill group.", "car-farmer" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "description", "name" },
                values: new object[] { "Two skills from the exploration skill group.", "car-gladiator" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "description", "name" },
                values: new object[] { "The Endurance skill, plus two skills from your choice of either the crafting skill group or the exploration skill group", "car-laborer" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "description", "name" },
                values: new object[] { "The Magic skill, plus two skills from the lore skill group.", "car-mages-apprentice" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "description", "name" },
                values: new object[] { "The Music or Performance skill, plus two skills from the interpersonal skill group.", "car-performer" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "description", "name" },
                values: new object[] { "Two skills from the interpersonal skill group.", "car-politician" });

            migrationBuilder.InsertData(
                table: "skill_option",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 28, "Two skills from the lore skill group.", "car-sage" },
                    { 29, "The Swim skill, plus two skills from the exploration skill group.", "car-sailor" },
                    { 30, "One skill from each of the exploration skill group and the intrigue skill group.", "car-soldier" },
                    { 31, "Nature, plus one skill from the exploration skill group and one skill from the intrigue skill group.", "car-warden" },
                    { 32, "Alertness, plus two skills from the intrigue skill group.", "car-watch-officer" },
                    { 33, "Two skills from the interpersonal or lore skill groups.", "cls-censor" },
                    { 34, "Two skills from the interpersonal or lore skill groups.", "cls-conduit" },
                    { 35, "The Magic skill and three skills from the crafting or lore skill groups.", "cls-elementalist" },
                    { 36, "The Nature Nature skill and two skills from the exploration or intrigue skill groups.", "cls-fury" },
                    { 37, "The Psionics skill and two skills from the interpersonal and lore skill groups.", "cls-null" },
                    { 38, "The Hide and Sneak skills and five skills from Criminal Underworld or the skills of the exploration, interpersonal, or intrigue skill groups.", "cls-shadow" },
                    { 39, "The Lead skill abd two skills from Alertness, Architecture, Blacksmithing, Brag, Culture, Empathize, Fletching, Mechanics, Monsters, Search, Strategy or the skills of the exploration skill group.", "cls-tactician" },
                    { 40, "The Psionics and Read Person skills and two skills from the interpersonal or lore skill groups.", "cls-talent" },
                    { 41, "The Read Person skill and two skills from the interpersonal skill group and one skill from the intrigue or lore skill groups.", "cls-troubadour" }
                });

            migrationBuilder.UpdateData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 15, 15 },
                column: "count",
                value: 1);

            migrationBuilder.InsertData(
                table: "skill_option_pool",
                columns: new[] { "skill_option_id", "skill_pool_id", "count" },
                values: new object[,]
                {
                    { 15, 16, 1 },
                    { 15, 17, 1 },
                    { 16, 18, 1 },
                    { 16, 19, 1 },
                    { 17, 20, 2 },
                    { 18, 21, 1 },
                    { 18, 22, 1 },
                    { 18, 23, 1 },
                    { 19, 24, 1 },
                    { 19, 25, 2 },
                    { 20, 26, 1 },
                    { 20, 27, 2 },
                    { 21, 28, 1 },
                    { 21, 29, 2 },
                    { 22, 30, 1 },
                    { 22, 31, 2 },
                    { 23, 32, 2 },
                    { 24, 33, 1 },
                    { 24, 34, 2 },
                    { 25, 35, 1 },
                    { 25, 36, 2 }
                });

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 15,
                column: "name",
                value: "car-agent-1");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 16,
                column: "name",
                value: "car-agent-2");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 17,
                column: "name",
                value: "car-agent-3");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 18,
                column: "name",
                value: "car-aristocrat-1");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 19,
                column: "name",
                value: "car-aristocrat-2");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 20,
                column: "name",
                value: "car-artisan");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 21,
                column: "name",
                value: "car-beggar-1");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 22,
                column: "name",
                value: "carr-beggar-2");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 23,
                column: "name",
                value: "car-beggar-3");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 24,
                column: "name",
                value: "car-criminal-1");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 25,
                column: "name",
                value: "car-criminal-2");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 26,
                column: "name",
                value: "car-disciple-1");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 27,
                column: "name",
                value: "car-disciple-2");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 28,
                column: "name",
                value: "car-explorer-1");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 29,
                column: "name",
                value: "car-explorer-2");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 30,
                column: "name",
                value: "car-farmer-1");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 31,
                column: "name",
                value: "car-farmer-2");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 32,
                column: "name",
                value: "car-gladiator");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 33,
                column: "name",
                value: "car-laborer-1");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 34,
                column: "name",
                value: "car-laborer-2");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 35,
                column: "name",
                value: "car-magesapprentice-1");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 36,
                column: "name",
                value: "car-magesapprentice-2");

            migrationBuilder.InsertData(
                table: "skill_pool",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 37, "car-performer-1" },
                    { 38, "car-performer-2" },
                    { 39, "car-politician" },
                    { 40, "car-sage" },
                    { 41, "car-sailor-1" },
                    { 42, "car-sailor-2" },
                    { 43, "car-soldier-1" },
                    { 44, "car-soldier-2" },
                    { 45, "car-warden-1" },
                    { 46, "car-warden-2" },
                    { 47, "car-warden-3" },
                    { 48, "car-watch-officer-1" },
                    { 49, "car-watch-officer-2" },
                    { 50, "cls-censor" },
                    { 51, "cls-conduit" },
                    { 52, "cls-elementalist-1" },
                    { 53, "cls-elementalist-2" },
                    { 54, "cls-fury-1" },
                    { 55, "cls-fury-2" },
                    { 56, "cls-null-1" },
                    { 57, "cls-null-2" },
                    { 58, "cls-shadow-1" },
                    { 59, "cls-shadow-2" },
                    { 60, "cls-tactician-1" },
                    { 61, "cls-tactician-2" },
                    { 62, "cls-talent-1" },
                    { 63, "cls-talent-2" },
                    { 64, "cls-troubadour-1" },
                    { 65, "cls-troubadour-2" },
                    { 66, "cls-troubadour-3" }
                });

            migrationBuilder.InsertData(
                table: "skill_pool_skill",
                columns: new[] { "skill_id", "skill_pool_id" },
                values: new object[,]
                {
                    { 30, 10 },
                    { 31, 10 },
                    { 25, 12 },
                    { 6, 13 },
                    { 13, 13 },
                    { 16, 13 },
                    { 19, 13 },
                    { 27, 13 },
                    { 34, 13 },
                    { 45, 13 },
                    { 50, 13 },
                    { 44, 15 },
                    { 54, 21 },
                    { 47, 24 },
                    { 53, 26 },
                    { 18, 28 },
                    { 25, 30 },
                    { 13, 33 },
                    { 49, 35 }
                });

            migrationBuilder.InsertData(
                table: "skill_pool_skill_group",
                columns: new[] { "skill_group_id", "skill_pool_id" },
                values: new object[,]
                {
                    { 3, 16 },
                    { 4, 16 },
                    { 3, 18 },
                    { 5, 19 },
                    { 1, 20 },
                    { 2, 22 },
                    { 3, 22 },
                    { 4, 25 },
                    { 5, 27 },
                    { 2, 29 },
                    { 2, 31 },
                    { 1, 34 },
                    { 5, 36 }
                });

            migrationBuilder.InsertData(
                table: "upbringing",
                columns: new[] { "id", "description", "name", "skill_option_id" },
                values: new object[,]
                {
                    { 1, "Heroes with an academic upbringing were raised by people who collect, study, and share books and other records. Some academics focus on one area of study, such as a college for wizards dedicated to the study of magic, or a church that teaches the word of one deity. People in an academic culture learn how to wield the power that is knowledge.", "Academic", 9 },
                    { 2, "Heroes with a creative upbringing were raised among folk who create art or other works valuable enough to trade. A creative culture might produce fine art such as dance, music, or sculpture, or more practical wares such as wagons, weapons, tools, or buildings. People in such cultures learn the value of quality crafting and attention to detail.", "Creative", 10 },
                    { 3, "Heroes with an illegal upbringing had caregivers who performed activities that other folk—whether within or outside their culture—considered unlawful. A band of pirates, a guild of assassins, or an organization of spies all commit unlawful acts for money. People with illegal upbringings typically don’t mind breaking the rules when it suits them—and are good at making sure no one finds out they did.", "Illegal", 11 },
                    { 4, "People who labor for a living survive through cultivation, typically raising crops or livestock on a farm; by harvesting natural resources, whether by hunting, trapping, logging, or mining; or through manual labor tied to settlement and trade, such as construction, carting, loading cargo, and so forth. People with a labor upbringing know the value of hard work.", "Labor", 12 },
                    { 5, "Heroes who have a martial upbringing are raised by warriors. These might be the soldiers of an established army, a band of mercenaries, a guild of monster-slaying adventurers, or any other folk whose lives revolve around combat. Heroes with a martial upbringing are always ready for a fight—and they know how to finish that fight.", "Martial", 13 },
                    { 6, "Heroes with a noble upbringing were raised by leaders who rule over others and play the games of politics to maintain power. Many families are nobles by birthright, but some cultures have noble titles that are earned through deeds or popularity. Whatever the case, heroes with this background understand why the whispered words in the right ear can sometimes be more powerful than any army.", "Noble", 14 }
                });

            migrationBuilder.InsertData(
                table: "career",
                columns: new[] { "id", "description", "language_bonus", "name", "perk_type_id", "project_point_bonus", "renown_bonus", "skill_option_id", "wealth_bonus" },
                values: new object[,]
                {
                    { 14, "From an early age, you dedicated yourself to learning, whether you shared the knowledge of the world with others or sought out secret lore only for yourself.", 1, "Sage", 5, 240, 0, 28, 1 },
                    { 15, "You worked on a ship that might have been a merchant cog, a mercenary or military craft, or a pirate vessel. You might have been a deckhand, a mate, or even the captain.", 2, "Sailor", 2, 0, 0, 29, 1 },
                    { 16, "In your formative years, you fought tirelessly in skirmishes and campaigns against enemy forces.", 2, "Soldier", 2, 0, 1, 30, 1 },
                    { 17, "You protected a wild region from those who sought to harm it, such as poachers and cultists bent on the destruction of the natural world. Knowing your land well, you could also serve as a guide or the leader of a rescue party for those wandering the wilds.", 1, "Warden", 2, 120, 0, 31, 1 },
                    { 18, "You served as an officer of the law for a local government. You might have been a single person in a much larger city watch or the only constable patrolling a small village.", 2, "Watch Officer", 2, 0, 0, 32, 1 }
                });

            migrationBuilder.InsertData(
                table: "career_question",
                columns: new[] { "id", "career_id", "question" },
                values: new object[,]
                {
                    { 1, 1, "Who did you work for?" },
                    { 2, 1, "Who did you spy on?" },
                    { 3, 1, "Who shouldn't know your true identity and allegiance but does?" },
                    { 4, 1, "Who did you burn or leave behind to get a job done?" },
                    { 5, 2, "How did you become an aristocrat?" },
                    { 6, 2, "What did you do to fill your days?" },
                    { 7, 2, "Which aristocrats and people who worked for you were your best friends and greatest enemies?" },
                    { 8, 2, "• What sentimental heirloom from your old estate do you carry, and what does it mean to you?" },
                    { 9, 3, "What did you create?" },
                    { 10, 3, "Who taught you your craft?" },
                    { 11, 3, "Was there any particular creation you were known for?" },
                    { 12, 3, "Did you have a shop, or did you travel to sell your wares?" },
                    { 13, 4, "What unfortunate circumstances led you to become a beggar?" },
                    { 14, 4, "Where did you beg?" },
                    { 15, 4, "Who made sport out of bullying you?" },
                    { 16, 4, "Who showed you the most kindness?" },
                    { 17, 5, "What sorts of crimes did you commit, and why?" },
                    { 18, 5, "Did anyone help you perform your illicit activities?" },
                    { 19, 5, "What is one crime you botched?" },
                    { 20, 5, "Who was your nemesis while you were a criminal?" },
                    { 21, 6, "What gods or saints did your institution venerate?" },
                    { 22, 6, "What initiation rites did you undergo to get the job?" },
                    { 23, 6, "What were your responsibilities as a disciple?" },
                    { 24, 6, "How was your institution viewed by members of the local culture?" },
                    { 25, 7, "For what purpose did you explore the unknown?" },
                    { 26, 7, "Who else was part of your exploration team?" },
                    { 27, 7, "What types of environments did you explore?" },
                    { 28, 7, "What legend or rumor did you search for but never found?" },
                    { 29, 7, "What is your greatest discovery?" },
                    { 30, 8, "Did you own the land you farmed, or did you farm for another?" },
                    { 31, 8, "What crops or livestock did you cultivate?" },
                    { 32, 8, "Who else worked on the farm with you?" },
                    { 33, 8, "What ill omen did you witness that caused you to have a poor season of farming?" },
                    { 34, 9, "What led you to this life of violent entertainment?" },
                    { 35, 9, "What was your gladiator name and persona?" },
                    { 36, 9, "Who was your biggest rival?" },
                    { 37, 9, "What happened during your most famous match?" },
                    { 38, 10, "What type of manual labor did you do?" },
                    { 39, 10, "What important friendship did you make on the job?" },
                    { 40, 10, "Where did you go with your coworkers to blow off steam when the job was done?" },
                    { 41, 10, "What aspect of the job was most difficult for you?" },
                    { 42, 11, "Who did you study under, and what kind of person were they?" },
                    { 43, 11, "What were your mentor’s areas of expertise?" },
                    { 44, 11, "What aspects of magic did you struggle to comprehend?" },
                    { 45, 11, "What is your current relationship with your mentor?" },
                    { 46, 12, "What is the tone of your performances?" },
                    { 47, 12, "What song, role, or dance are you most known for?" },
                    { 48, 12, "Did you perform in the same place throughout your career, or did you travel?" },
                    { 49, 12, "Were you part of a troupe, or were you a solo act?" },
                    { 50, 13, "Who were you responsible for ruling or representing?" },
                    { 51, 13, "What was your official title and how did you earn it?" },
                    { 52, 13, "Who was your greatest political rival?" },
                    { 53, 13, "What secret do you know that could tear apart the entire system you worked within?" }
                });

            migrationBuilder.InsertData(
                table: "culture_preset_ancestry",
                columns: new[] { "id", "ancestry_id", "environment_id", "language_id", "organization_id", "upbringing_id", "uprbringing_id" },
                values: new object[,]
                {
                    { 1, 1, 4, 1, 2, null, 1 },
                    { 2, 2, 3, 20, 2, null, 5 },
                    { 3, 3, 3, 25, 2, null, 2 },
                    { 4, 4, 5, 23, 2, null, 5 },
                    { 5, 5, 3, 6, 2, null, 5 },
                    { 6, 6, 2, 21, 3, null, 4 },
                    { 7, 7, 4, 34, 3, null, 4 },
                    { 8, 8, 1, 2, 3, null, 1 },
                    { 9, 9, 5, 8, 1, null, 2 },
                    { 10, 10, 4, 11, 3, null, 2 },
                    { 11, 12, 1, 22, 1, null, 5 }
                });

            migrationBuilder.InsertData(
                table: "culture_preset_community",
                columns: new[] { "id", "community", "environment_id", "organization_id", "upbringing_id", "uprbringing_id" },
                values: new object[,]
                {
                    { 1, "Artisan Guild", 4, 2, null, 2 },
                    { 2, "Borderland Homestead", 5, 1, null, 4 },
                    { 3, "College Conclave", 4, 2, null, 1 },
                    { 4, "Criminal Gang", 4, 1, null, 3 },
                    { 5, "Farming Village", 2, 2, null, 4 },
                    { 6, "Herding Community", 1, 3, null, 4 },
                    { 7, "Knightly Order", 3, 2, null, 5 },
                    { 8, "Mercenary Band", 1, 2, null, 5 },
                    { 9, "Merchant Caravan", 1, 2, null, 2 },
                    { 10, "Monastic Order", 3, 2, null, 1 },
                    { 11, "Noble House", 4, 2, null, 6 },
                    { 12, "Outlaw Band", 5, 1, null, 3 },
                    { 13, "Pauper Neighborhood", 4, 3, null, 4 },
                    { 14, "Pirate Crew", 1, 1, null, 3 },
                    { 15, "Telepathic Hive", 3, 3, null, 2 },
                    { 16, "Traveling Entertainers", 1, 3, null, 2 },
                    { 17, "Artisan Guild", 4, 2, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "inciting_incident",
                columns: new[] { "id", "career_id", "description", "name" },
                values: new object[,]
                {
                    { 1, 1, "While on a dangerous espionage assignment, things went sideways. Although you escaped with your life, the mission was a public failure thanks to bad information your agency gave you. They denied you work for them, and you went on the run. Hero work will let you survive and clear your name.", "Disavowed" },
                    { 2, 1, "Your identity was always hidden. It was your way of protecting those around you because the work you did spying on powerful entities came with dangers. Then your world came crashing down when an enemy agent unmasked you, causing you to lose everything— your privacy, livelihood, loved ones, all gone in the blink of an eye. Instead of going into hiding, you became a public hero to protect the innocent in the name of those you lost.", "Faceless" },
                    { 3, 1, "There was a time in your life when you used to sell information to the highest bidder. Your acts were unsanctioned by any one organization, but you were well-connected enough to trade in secrets. Politics never mattered much to you until the information you sold wound up causing a ripple effect of harm that eventually destroyed the place you once called home. You became a hero to make up for your past.", "Free Agent" },
                    { 4, 1, "After years of cultivating a rich list of informants, one of those informants risked everything to expose the heinous plans of powerful individuals. You promised to protect your informant, but your agency left them hanging—literally. You cut ties with your employer and swore to always make good on your word as a hero.", "Informed" },
                    { 5, 1, "While embedded in an undercover assignment, you fell for someone on the other side. They discovered you were a double-agent and though you insisted your feelings were real, the deceit cut too deep for your love interest to ignore. They exposed you, spurned you, or died because of their closeness to you. You left the espionage business to become a hero with nothing to hide.", "Spies and Lovers" },
                    { 6, 1, "You spent your life in service of your country or an organization that upheld your values. During your undercover operations, you discovered everything you were told was a lie. Whether you confronted your superiors or were exposed, you were stripped of your service medals before you left to become a true hero.", "Turncoat" },
                    { 7, 2, "When you entered adulthood, you heard unsavory whispers about your family’s fortune before learning that their wealth came at the cost of others’ suffering. Whether you shed light on the secret or not, you left to become a hero stripped of noble title.", "Blood Money" },
                    { 8, 2, "Through some treasure or innate ability, you were able to defraud other aristocrats. You did it for fun. When you were found out, you lost your status. Whether you served time or escaped from punishment, you decided to rehabilitate yourself and became a hero.", "Charmed Life" },
                    { 9, 2, "The guardians who instilled in you the virtues of doing the right thing were murdered in a senseless petty robbery. Though their wealth was bequeathed to you, it did little to assuage the guilt you felt for being unable to stop the deadly crime. You decided to use your riches to fund your life as a hero, whether publicly or using an alter ego.", "Inheritance" },
                    { 10, 2, "Life outside the manor never piqued your interest. You had everything you wanted. It came as a surprise when the peasants came to overthrow your family. You narrowly escaped, and for the first time witnessed the world. It caused you to become a hero for the people, fighting against inequities.", "Privileged Position" },
                    { 11, 2, "Seeking a break from noble duties, you sought a lookalike to switch identities with. It went so well that you made a habit of switching whenever bored. Unfortunately, your counterpart became so good at imitating you that they convinced everyone you were an impostor. You lost contact with your family, but pursue a heroic path free of the pomp of your old life.", "Royal Pauper" },
                    { 12, 2, "One parent passed away when you were a baby and the other remarried years later. Then that parent died under suspicious circumstances. Their spouse ousted you, and you were banished (and possibly hunted). Rising from tragedy, you now seek to right the wrongs of the world.", "Wicked Secret" },
                    { 13, 3, "A great hero was a fan of the things you created, and gave you a generous commission to create your best work for them. While working on this commission, you and the hero became close friends. The day you finished the work was the same day they disappeared. To honor their legacy, you took up the mantle of a hero with the intent of finishing your friend’s work.", "Continue the Work" },
                    { 14, 3, "As you traveled the road selling your wares, troll bandits attacked you. One of the bandits claimed an item belonging to someone precious to you—or perhaps claimed that person’s life—but the rest were driven off or slain by a group of heroes. Seeing the quick work these heroes made of the bandits inspired you to follow in their footsteps.", "Inspired" },
                    { 15, 3, "A criminal gang stole your goods and harmed a number of people who worked for you. You became a hero to prevent such indignities from being visited upon others, to seek revenge for the assault, or to find the thieves and get your stuff back.", "Robbery" },
                    { 16, 3, "Your parents discouraged your artistic talents, instead trying to focus your passions on the family business. You refused to dim your spark and continued your work in secret. Enraged at discovering your disobedience, they sold your work to a traveling merchant. You left your hometown, seeking your lost art and encouraging others to live freely.", "Stolen Passions" },
                    { 17, 3, "A new patron commissioned some art, but on completion, they refused to pay you and claimed the work as their own. You were accused of plagiarism and run out of town. For you, heroics are about restoring your name and honor", "Tarnished Honor" },
                    { 18, 3, "You had great success that caused an unscrupulous rival to curse you. For a time, everything you tried to create turned to ruin. You broke the curse through adventuring, and in doing so discovered a new joy and purpose that now defines you.", "Twisted Skill" },
                    { 19, 4, "You were never content with your lot. Watching yet another friend fall to preventable circumstances was your last straw. You gathered up what little you had and set off to become a hero, determined to make real change for those society forgot.", "Champion" },
                    { 20, 4, "Something killed the other beggars. It came in the night. You barely saw it, but what you did see of it wasn’t natural. You survived by hiding, or perhaps it simply passed you over for reasons unknown to you. It still haunts your nightmares, and you kill monsters so no one else has to experience such horrors.", "Night Terror" },
                    { 21, 4, "You ran afoul of the local watch by being in the wrong place when they were in a bad mood. A passing hero intervened on your behalf, shaming the guards into moving on, then gave you enough gold to get you back on your feet. Their kindness kindled a spark in you. You took the gold, bought some secondhand gear, and went to pay that hero’s kindness forward.", "One Good Deed" },
                    { 22, 4, "No matter how far you’d fallen, there was one belonging you would never part with, no matter how much money it would bring you. When a pickpocket stole it, you chased them until you were in a part of the city you no longer recognized. With a jolt, you realized you had no desire to return to your previous stomping grounds. You kept going, and you haven’t looked back.", "Precious" },
                    { 23, 4, "A passerby dropped something in your cup. When you counted your day’s collections, you found a magic coin among the coppers. You knew immediately that it was special. When the other beggars—your friends, you thought—were ready to murder you for it, you killed several of them in selfdefense before you fled, leaving behind the only semblance of community you had.", "Strange Charity" },
                    { 24, 4, "You saw something you weren’t meant to see. Others would kill you if they knew, and they might be searching for you even now. You remain on the move, terrified of remaining in one place too long lest it all catch up to you. Perhaps if you make a big enough name for yourself, you can become untouchable and can finally speak of what you saw without fear.", "Witness" },
                    { 25, 5, "You stole, smuggled, and sold antiquities. In your haste to make a quick sale, you didn’t fully vet a client and they subsequently robbed your warehouse. When the items you had stolen were taken from you, you realized the harm you had caused. Now you adventure to find those items you lost and return them where they belong.", "Antiquity Procurement" },
                    { 26, 5, "The last criminal job you pulled led to the death of someone or the destruction of something you love. To make up for the loss you caused, you left your criminal ways behind and became a hero.", "Atonement" },
                    { 27, 5, "You went to prison for your crimes and eventually escaped. An elderly priest took you in and shielded you from the law, convinced that your soul wasn’t corrupt. They never judged you for your past, speaking only of the future. Eventually, the priest died, imparting final words that inspired you to become a hero.", "Friendly Priest" },
                    { 28, 5, "You spent years blackmailing and manipulating nobles for influence and wealth until a scheme went wrong. You were publicly exposed, and after a narrow escape, you reevaluated your life. Under a new identity, you work as a hero and hope no one looks at your past too closely.", "Shadowed Influence" },
                    { 29, 5, "Stealing was a matter of survival for you and not what defined you—at least in your mind. But when your thieving actions lead to innocent folk being harmed, you knew you could be better. You turned your back on your old life, though your old skills come in handy.", "Simply Survival" },
                    { 30, 5, "When a tyrant rose to power in your homeland, they began cracking down on all criminals with deadly raids and public executions. The nature of the crime didn’t matter—pickpockets and beggars were made to kneel before the axe alongside murderers. After losing enough friends, you stood up and joined the resistance—not just against this tyrant, but against authoritarians anywhere.", "Stand Against Tyranny" },
                    { 31, 6, "Swayed by an evil faith, your cult was about to unleash horrors upon the world when an angel (figurative or literal) intervened. They convinced you to stop your cult’s efforts. Now you follow in the footsteps of the angel who showed you the righteous path.", "Angel's Advocate" },
                    { 32, 6, "Although you joined the religious institution under the guidance of a kind mentor, others within the house of worship became increasingly fanatical in their convictions. Your mentor sought to be a voice of reason in the rising tide of hatred and was tried as a heretic before being executed. Leaving the institution behind, you became a hero to uphold the beliefs you hold dear.", "Dogma" },
                    { 33, 6, "Your temple was destroyed in a religious conflict. The institution’s leaders sought retaliation, but you saw in these actions a ceaseless cycle of destruction that would lead to more conflict. Instead, you became a hero to protect religious freedoms, so all worshipers could practice their faith without fear.", "Freedom to Worship" },
                    { 34, 6, "You devoted your life to ministering to the sick and needy and other charitable work. Time and time again, tragedy struck those you served without rhyme or reason. Your prayers went unanswered, and your efforts went thankless. Eventually, you lost your faith in a higher power, and you left your church or temple to do good outside of any religious affiliation.", "Lost Faith" },
                    { 35, 6, "While serving at a religious institution, you almost died in an accident. When you woke, you had lost all memory of ever having worked for the church or temple. Though the clergy encouraged you to stay, you left to forge a new path. Your sense of altruism—whether instilled in you by your past work or a part of who you naturally are—guides you in your life.", "Near-Death Experience" },
                    { 36, 6, "The faith-based organization you were once part of became corrupt. It used its status in the community to accumulate wealth through tithes and its leaders sought political appointments. During a season of drought, the institution stockpiled resources and refused to give aid, resulting in the deaths of many. You became a hero to fight against such corruption and to honor your dearly departed.", "Taxing Times" },
                    { 37, 7, "In an uncharted area, you awakened some dark horror. You have turned to the life of a hero to put an end to the horror you unleashed and keep other hidden dangers at bay.", "Awakening" },
                    { 38, 7, "You made an important but dangerous discovery about a treasure or ancient ritual that could spell mass destruction. Then the unthinkable happened when an unscrupulous colleague, spy, or treasure hunter stole your research notes. You’re looking for them now, and anyone else who might use such discoveries for ill.", "Missing Piece" },
                    { 39, 7, "Traversing seas and mountains to collect valuable artifacts for cultural institutions was once your way of life. When people died trying to reclaim one of the objects you took, you realized the truth. Your work was part of a larger problem of misappropriation and the best place for these significant objects wasn’t in a museum but with the people who created them. You set out to return what had been taken and to protect others from theft.", "Nothing Belongs in a Museum" },
                    { 40, 7, " You delved into dungeons and far-off places by studying them in books. You were an explorer who never felt the need to experience the dangers your peers did. However, your theory about a lost world cost you your reputation. It gave you the impetus to go on adventures and stand up for those with different ideas.", "Unschooled" },
                    { 41, 7, "You saw yourself as an observer and operated within a code of conduct. You swore to never interfere with a group by exposing them to your technology, knowledge, or values. When faced with a moral conundrum, you either broke your code or stood idly by—and suffered the consequences. During this incident, you lost your observation journal but became a hero who refuses to let evil stand unchecked.", "Wanderlust" },
                    { 42, 7, "As a seafaring explorer, you lived to chart unknown courses. Though travel on the high seas was fraught with danger, the destination was always rewarding in riches, knowledge, or some other way that was meaningful to you. Your luck ran out when your ship was destroyed by pirates or other enemy forces. You’ve taken to protecting those who seek safe passage while also hoping to avenge your crew.", "Wind in Your Sails" },
                    { 43, 8, "A horrible blight swept over your homeland, sickening the livestock and causing crops to rot. No one knows whether the blight is of natural origin or something more malevolent, but you set out in search of a way to cleanse the land of this affliction.", "Blight" },
                    { 44, 8, "You’ve always wanted so much more than gathering eggs and milking cows. You kept a secret journal of your dreams, filled with all the things you wanted. When your parent found the journal, they burned it and told you to keep your head out of the clouds. In response, you gathered what you could in a pack and left everything else behind, seeking a life of adventure.", "Bored" },
                    { 45, 8, "While tilling your fields, you found something in the dirt. Perhaps it was a chipped and dented weapon, a piece of ancient jewelry, or something altogether unique. Excited by your find, you showed it to a loved one, but when they touched it, something happened. You now know it was a curse conveyed by the item, though you don’t know why it affected them and not you. You left your old life in search of answers.", "Cursed" },
                    { 46, 8, "Your farm had always been prosperous, until the last few years. Changes in the weather caused smaller yields until you could no longer pay your tithe to the local noble. Her soldiers took what items of value they found, including a precious family heirloom. You left the struggling farm behind to find a better life.", "Hard Times" },
                    { 47, 8, "Your animals were killed, your crops and home set ablaze. The culprits might have been wandering bandits, raiders from a nearby kingdom, or hired thugs sent by a rival farm. Whoever they were, they left you with nothing. You couldn’t face the thought of starting again from scratch, so you took up a life of heroism to protect others from such villainy.", "Razed" },
                    { 48, 8, "Your family bred horses—beautiful creatures that few could rival on the track and in the jousting lists. When a local noble arrived with an offer to buy your prized stallion, your father refused. The noble struck him down where he stood and stole the horse. Without that stallion, the renowned bloodline would end. You intend to get them back—and get revenge.", "Stolen" },
                    { 49, 9, "A local crime lord offered you money to throw your last bout, promising that you’d live through the ordeal and get a cut of all the wagers placed on the match. You upheld your end of the deal—which made the knife in your back after the bout so surprising. You woke in a shallow grave, barely alive, and ready to mete out justice.", "Betrayed" },
                    { 50, 9, "As you stood victorious on the arena sands, a voice cried out among the cheering. “This violence is just for show. You should be ashamed. There are people who need you—who need your skills!” Why did that voice ring so clear? And why did it sound so familiar? You never saw the face of the person who uttered those words, but they weighed heavy on you. The next day, you fled the arena to begin a hero’s life.", "Heckler" },
                    { 51, 9, "As a child, you loved gladiatorial matches, captivated by the fierce displays of showmanship, never giving much thought to how the competitors ended up in the ring. Then your friend was wrongly accused of a crime and sentenced to compete. You went in their place. After viewing what life was like for those forced to fight, you survived your sentence and resolved to protect the unfairly condemned.", "Joined the Arena" },
                    { 52, 9, "You earned every title you could. You beat every opponent willing to face you in the arena. Your final battle with your rival ended with you victorious—and still you were unsatisfied. There are other, greater foes out there—and you mean to find them.", "New Challenges" },
                    { 53, 9, "You were born a noble, but the duplicitous and power-hungry nature of your family had you seeking your own fortune in the arena. You saw that competitors brought there by circumstance and not choice suffered. You gave all you could of your family money to those less fortunate folk and then set out to make a real difference in this cruel world.", "Scion's Compassion" },
                    { 54, 9, "The orphanage you grew up in secretly supplied gladiators to the arena. Forced to fight against many childhood friends as an adult, you vowed to dismantle the arena and free other victims. You became a liberator, dedicating to ending the oppression of others until your dying breath.", "Warrior's Home" },
                    { 55, 10, "Spending your days cleaning and maintaining the sewers doesn’t make you many friends. But you found friendship among the rats. You fought the monsters that hunted your friends, and which everyone else ignored. After making the sewers safe for the rats, you decided to take your talents to the surface and serve other humanoids who might appreciate your efforts in the same way.", "Deep Sentinel" },
                    { 56, 10, "A disaster, such as a cave-in, wildfire, or tidal wave, hit your crew while you were working. You saved as many as you could, but the ones you couldn’t save weigh heavily on your mind. You took up the life of a hero to save as many people as possible, vowing that what happened to you won’t happen again.", "Disaster" },
                    { 57, 10, "A noble you worked for admonished you publicly for work done poorly—and more than once. Finally, you’d had enough. You vowed to take up a new path and show this noble you’re far more than what they make you out to be.", "Embarrassment" },
                    { 58, 10, "You worked with a good friend, and on the job, you would always fantasize about what it would be like to hit the road as adventuring heroes … someday. You didn’t count on your friend falling ill and passing away. Now it’s time to live out that dream for both of you.", "Live the Dream" },
                    { 59, 10, "You kept a lighthouse along the constantly stormy cliffs of your village with your mentor. On a clear and sunny day, your mentor vanished. Finding only a cryptic notebook filled with his musings on the supernatural, you left to find what really what happened. The trail has gone cold for now, and you’re helping others find their loved ones in the meantime.", "Shining Light" },
                    { 60, 10, "You labored silently as an uncaring boss drove those around you into the ground, pushing you to work harder to lessen the burden on your companions. But when the boss pushed too far and killed a friend of yours, you led an uprising against them. That was the start of your adventuring life.", "Slow and Steady" },
                    { 61, 11, "While practicing a spell, your inexperience caused the magic to backfire and your memories were wiped, leaving you with only fragments of who you once were. Determined to recall your past, you now dedicate yourself to helping others, hoping your actions will spark some remembrance or lead you to a way to reverse the magic.", "Forgotten Memories" },
                    { 62, 11, "As a sign of your status as star pupil, your mentor gifted you a familiar as a magic pet. Another jealous apprentice captured the familiar and slipped away in the night. Haunted by your pet’s absence, you adventure to find your kidnapped friend and prevent others from feeling your loss.", "Magic Friendship" },
                    { 63, 11, "One day you woke up and the mage you worked for was just gone. They didn’t take any of their belongings and there was no sign of any foul play—just the scent of sulfur in their bedchamber. You set out on your heroic journey in the aftermath and have been looking for them ever since.", "Missing Mage" },
                    { 64, 11, "Your attempts at magic have always been unpredictable. A powerful mage promised to help you gain control. During your training, a terrible nightmare caused your body to flare with magic and pull the monster of your nightmare into the waking world. The horror escaped. You left, seeking to vanquish their terrible vileness.", "Nightmare Made Flesh" },
                    { 65, 11, "While studying magic, you accidentally sent yourself from your original world to this one. Now you’re stranded here, hoping to find ancient texts or powerful magic treasures that might transport you back home. A life of adventure it is!", "Otherworldly" },
                    { 66, 11, "The mage you worked for was a kindly old soul, but the basic magic they taught you always seemed like a small part of something bigger. It wasn’t until you met an adventuring elementalist that you realized hitting the road as a hero was the only way to truly improve and hone your skills. You resigned your apprenticeship and found yourself walking the path of a hero the next day.", "Ultimate Power" },
                    { 67, 12, "During a performance, you watched in horror as the audience was suddenly overcome by a curse that caused them to disintegrate before your eyes. You aren’t sure what happened, but seeking an answer quickly led you to places where only heroes dare to go.", "Cursed Audience" },
                    { 68, 12, "After a poor performance, you found a script to a well-written play left in your dressing room. The accompanying note asked that if you performed the play, you should give the author credit. But after a commanding performance, you claimed to be star and playwright both—and the curse hidden on those pages activated. A small portion of your skin has begun to transform into undead flesh, and the only cure is to prove you have become selfless.", "False Accolades" },
                    { 69, 12, "You thought you were famous—then that hero came to your show. Suddenly, all eyes were on the dragon-slaying brute instead of on the stage where they belonged. The audience even gave them a standing ovation when they entered the room. All you got was polite applause. Fine. If people want a hero so much, then a hero you shall be.", "Fame and Fortune" },
                    { 70, 12, "Your performances have always been tinged with a bit of melancholy. During a particularly soulful performance, spirits disturbed the living audience and sat in their chairs. They begged you to prevent their demise, providing no other details before disappearing. You set out to see if you could help your most dedicated fans.", "Songs to the Dead" },
                    { 71, 12, "A heckler’s mocking words left you utterly speechless during a performance, stinging your pride and stirring your arrogance. The incident strained your legendary voice, and you could only speak in soft whispers. The heckler was a fey trickster who stole your voice, promising to give it back after you accomplished real good in the world.", "Speechless" },
                    { 72, 12, "When a producer who once shortchanged you shouted out on the street for you to stop a thief who had picked their pocket, your spite toward the producer inspired you to let the thief run right on by. But that decision led to tragedy when the thief later harmed someone you loved. From that moment on, you made it your responsibility to protect others.", "Tragic Lesson" },
                    { 73, 13, "Your political power allowed you to be foolish without consequence. Through sheer carelessness or on a dare, you accidentally harmed or killed an innocent bystander. Due to your position as an official, you faced no consequences. But this event was the final straw for the person you loved or respected most, and they turned away from you. You left the world of political machinations behind to earn back their trust.", "Diplomatic Immunity" },
                    { 74, 13, "You secretly funded a rebel organization intent on overthrowing the corrupt establishment. Someone discovered your treason, and you were forced to leave or risk execution. You became a hero to live and fight another day on behalf of those who have no power.", "Insurrectionist" },
                    { 75, 13, "You were seneschal to a leader, able to sway their opinions, but gossip convinced the monarch you were plotting a coup, and you were ousted from court. You became a hero to continue your work making meaningful change in the world.", "Respected Consul" },
                    { 76, 13, "You tried to work on policy change from the inside of a bureaucratic organization. There were others like you who were more vocal. You started to notice those colleagues were disappearing overnight. Not wanting to find out if you were next on the list, you left to enact change in more direct ways.", "Right Side of History" },
                    { 77, 13, "You used your skills to collect incriminating or scandalous information about your opponents to blackmail them. A rival got one step ahead of you and stole your book of dirty secrets, but instead of using it against you, they gave you an opportunity to leave the world of politics behind. Saved from public humiliation, you now use your skills for the greater good.", "Self-Serving" },
                    { 78, 13, "The red tape required to achieve anything through your political position resulted in a crisis being mishandled and countless people harmed or killed. After that unfortunate event, you resolved to be unfettered by bureaucratic interference and sought to do good through action, not paperwork.", "Unbound" }
                });

            migrationBuilder.InsertData(
                table: "skill_option_pool",
                columns: new[] { "skill_option_id", "skill_pool_id", "count" },
                values: new object[,]
                {
                    { 26, 37, 1 },
                    { 26, 38, 2 },
                    { 27, 39, 2 },
                    { 28, 40, 2 },
                    { 29, 41, 1 },
                    { 29, 42, 2 },
                    { 30, 43, 1 },
                    { 30, 44, 1 },
                    { 31, 45, 1 },
                    { 31, 46, 1 },
                    { 31, 47, 1 },
                    { 32, 48, 1 },
                    { 32, 49, 2 },
                    { 33, 50, 2 },
                    { 34, 51, 2 },
                    { 35, 52, 1 },
                    { 35, 53, 3 },
                    { 36, 54, 1 },
                    { 36, 55, 2 },
                    { 37, 56, 1 },
                    { 37, 57, 2 },
                    { 38, 58, 2 },
                    { 38, 59, 5 },
                    { 39, 60, 1 },
                    { 39, 61, 2 },
                    { 40, 62, 2 },
                    { 40, 63, 2 },
                    { 41, 64, 1 },
                    { 41, 65, 2 },
                    { 41, 66, 1 }
                });

            migrationBuilder.InsertData(
                table: "skill_pool_skill",
                columns: new[] { "skill_id", "skill_pool_id" },
                values: new object[,]
                {
                    { 30, 37 },
                    { 31, 37 },
                    { 20, 41 },
                    { 51, 45 },
                    { 34, 48 },
                    { 49, 52 },
                    { 51, 54 },
                    { 52, 56 },
                    { 39, 58 },
                    { 44, 58 },
                    { 47, 59 },
                    { 28, 60 },
                    { 2, 61 },
                    { 3, 61 },
                    { 6, 61 },
                    { 9, 61 },
                    { 21, 61 },
                    { 22, 61 },
                    { 34, 61 },
                    { 43, 61 },
                    { 46, 61 },
                    { 50, 61 },
                    { 56, 61 },
                    { 33, 62 },
                    { 52, 62 },
                    { 33, 64 }
                });

            migrationBuilder.InsertData(
                table: "skill_pool_skill_group",
                columns: new[] { "skill_group_id", "skill_pool_id" },
                values: new object[,]
                {
                    { 3, 38 },
                    { 3, 39 },
                    { 5, 40 },
                    { 2, 42 },
                    { 2, 43 },
                    { 4, 44 },
                    { 2, 46 },
                    { 4, 47 },
                    { 4, 49 },
                    { 3, 50 },
                    { 5, 50 },
                    { 3, 51 },
                    { 5, 51 },
                    { 1, 53 },
                    { 5, 53 },
                    { 2, 55 },
                    { 4, 55 },
                    { 3, 57 },
                    { 5, 57 },
                    { 2, 59 },
                    { 3, 59 },
                    { 4, 59 },
                    { 2, 61 },
                    { 3, 63 },
                    { 5, 63 },
                    { 3, 65 },
                    { 4, 66 },
                    { 5, 66 }
                });

            migrationBuilder.InsertData(
                table: "career_question",
                columns: new[] { "id", "career_id", "question" },
                values: new object[,]
                {
                    { 54, 14, "What subjects did you study?" },
                    { 55, 14, "Where did your studies take place?" },
                    { 56, 14, "How did you acquire the books and other materials you needed for work?" },
                    { 57, 14, "Who benefited most from your research?" },
                    { 58, 15, "What is the name of the vessel you sailed on and what type of business was the crew engaged in?" },
                    { 59, 15, "What was your job aboard the boat?" },
                    { 60, 15, "What’s the longest amount of time you’ve spent at sea?" },
                    { 61, 15, "Who or what did you lose on your maritime journeys?" },
                    { 62, 16, "• In which army and company did you serve?" },
                    { 63, 16, "What conflicts were you a part of?" },
                    { 64, 16, "What rank did you achieve?" },
                    { 65, 16, "What heroics did you perform in the heat of battle?" },
                    { 66, 17, "What environment did you protect?" },
                    { 67, 17, "Were you part of a formal group of wardens or did you take the job upon yourself?" },
                    { 68, 17, "Which animal became your constant companion while you worked in the wild?" },
                    { 69, 17, "What mysterious creature or wanderer did you meet in the forest, and what prophecy did they share with you?" },
                    { 70, 18, "What type of settlement did you protect?" },
                    { 71, 18, "What was your law enforcement style like? Were you a by-the-book officer, a more lenient-but-fair type, or totally corrupt?" },
                    { 72, 18, "What criminal still eludes your grasp to this day?" },
                    { 73, 18, "Whose life did you save in the line of duty?" },
                    { 74, 18, "What is the most absurd call you ever responded to and how did you handle it?" }
                });

            migrationBuilder.InsertData(
                table: "inciting_incident",
                columns: new[] { "id", "career_id", "description", "name" },
                values: new object[,]
                {
                    { 79, 14, "You were always content to live a peaceful life in your library, until you found that one book—the one that told the tale of heroes who had saved the timescape. They didn’t spend their days behind a desk. They made a real difference. It was time for you to do the same.", "Bookish Ideas" },
                    { 80, 14, "You used to think knowledge could fix everything. You were wrong. When someone you loved fell under a curse, the means to cure them couldn’t be found in any of the books you owned. But that wasn’t going to stop you. The answers are out there, and you’ll find them even if you have to face down death to do so.", "Cure the Curse" },
                    { 81, 14, "An evil mage took all your books for themself, cackling at your impotence as they raided your shelves. Now, you’re off to search through ancient ruins and secret libraries to rebuild your collection of rare tomes—and to find the mage who stole from you.", "Lost Library" },
                    { 82, 14, "While transcribing ancient texts, you and another scribe discovered a shelf of long-forgotten books. At your suggestion, your companion started work on one and vanished along with the tome. Your guilt drove you to seek out your friend and prevent others from falling to similar dangers.", "Paper Guilt" },
                    { 83, 14, "In your pursuit of ancient knowledge, you discovered a prophecy that has yet to come to pass. And that prophecy involves someone who might be … you. Since your discovery, strange dreams have plagued you, driving you to seek out your destiny.", "Unforseen Fortunes" },
                    { 84, 14, "At first you thought it was your imagination, and you brushed off the disappearance of random sentences in historical books. Then as the books changed to entirely blank pages, the disappearances became difficult to ignore, particularly those involving ancient or critical text. Driven by the desire to preserve knowledge, you have made it your purpose to restore and reverse those vanishing texts before they forever disappear.", "Vanishing" },
                    { 85, 15, "You joined up with your best friend, sibling, or other loved one, the culmination of a lifelong dream to sail the high seas together. When they died, you lost your taste for the seafaring life. You left at the first opportunity and haven’t looked back since.", "Alone" },
                    { 86, 15, "It was in the middle of a pirate raid (whether you were part of it or targeted by it) that you realized you no longer yearned for a sailor’s life. You used the chaos of the moment to slip away unnoticed. You now work as a hero in an effort to either end the piracy of others or atone for your past deeds, but you fear the day your old crew finds you and punishes you for your desertion.", "Deserter" },
                    { 87, 15, "You awoke aboard your ship with no memory of who you were. Though the other sailors insisted they knew you, you didn’t know them. The next time you went ashore, you decided to stay, determined to find out who you really are.", "Forgotten" },
                    { 88, 15, "You had the favor of your captain, which earned you many rivals aboard your ship. One night, your fellow sailors pulled you from your bunk and threw you overboard. By some miracle, you were scooped from the waters by a passing vessel. You worked off your debt to them, then set out on a new life with less pettiness.", "Jealousy" },
                    { 89, 15, "There was a mutiny, and you were on the losing side. You were marooned on an island and escaped when a merchant vessel was blown off course by a storm and found you. Your reputation is ruined among sailors, so you seek adventure elsewhere.", "Marooned" },
                    { 90, 15, "A catastrophic storm hit while you were at sea, destroying your ship and leaving you as the only survivor. Once you recovered, you tried to sign on with another ship, but the thought of the open water turned your legs to jelly. Instead, you’ve taken on the role of a traveling hero to make ends meet.", "Water Fear" },
                    { 91, 16, "You enlisted in the military to protect others, but your commander ordered you to beat and kill civilians. When you refused, things got violent. You barely escaped the brawl that ensued, but now you vow to help people on your own terms.", "Dishonorable Discharge" },
                    { 92, 16, "You had a long and storied career as a soldier before deciding to retire to a simpler life. But when you returned to your old home, you found your enemies had laid waste to it. Now the skills you earned on the battlefield are helping you as you become a different kind of warrior—one seeking to save others from the fate you suffered.", "Out of Retirement" },
                    { 93, 16, "The sight of constant bloodshed took its toll on you. You seek peace through healing and dedicated yourself to ending wars before they begin, to spare those around you from the horror.", "Peace Through Healing" },
                    { 94, 16, "You were the last surviving member of your unit after an arduous battle or monstrous assault, surviving only through luck. You turned away from the life of a soldier then, seeking to become a hero who could stand against such threats.", "Sole Survivor" },
                    { 95, 16, "Tired of eking out an existence on the streets, you enrolled in the military. However, you were unable to escape your lower-status background until the officer leading your unit fell in battle. In the chaos that ensued, you assumed their identity and returned home a hero. To avoid suspicion, you took on the life of an adventurer, staying always on the move.", "Stolen Valor" },
                    { 96, 16, "You promised a fellow soldier that you’d protect his family if he ever fell in battle. When he did, you traveled to his village, but found its people slain or scattered by war. Driven by your vow, you have dedicated your life to finding any survivors and protecting others from a similar fate.", "Vow of Sacrifice" },
                    { 97, 17, "When outsiders arrived in your lands with the intent to exploit the wilds for their resources, you spoke out against them. However, several other wardens spoke in favor of these outsiders and allowed them in to despoil nature. Refusing to watch your homeland destroyed, you left. Now you help others avoid such a fate.", "Betrayed" },
                    { 98, 17, "A disease has infected the lands you protect, causing animals to become violent and twisting plants into something dark and sinister. You’ve tried everything, magical and mundane, to stop the scourge, but it continues to spread. As such, you’ve set out in search of a cure or an unblighted land to protect.", "Corruption" },
                    { 99, 17, "You made a mistake that could not be forgiven. The other wardens of the region decided your fate, exiling you from your lands with an order never to return.", "Exiled" },
                    { 100, 17, "A group of heroes arrived in your territory with trouble close on their heels. You fought alongside them to turn back the evil, but it was too much. The heroes fell, and your wilderness was forever altered. Though your lands are beyond saving, there are other lands you can help.", "Honor the Fallen" },
                    { 101, 17, "There were signs. You tried to ignore them, but when a great beast died at your feet, you had to recognize the truth. You were meant to leave your home territory, meant to fight a battle for the fate of all lands—and so you gave up the only life you’ve ever known.", "Portents" },
                    { 102, 17, "You were responsible for guarding something precious, something vital to your region’s survival. But you let someone in, and they betrayed your trust by stealing the thing you were meant to guard. You left your chosen territory to atone for your mistake.", "Theft" },
                    { 103, 18, "You grew bored and disillusioned with chasing down petty thieves and imprisoning folks just trying to survive. Surely there are greater threats in the world. You will find that evil wherever it may lurk, and you’ll be the one to stop it.", "Bigger Fish" },
                    { 104, 18, "You joined the force to help the helpless and bring justice to those wronged. You weren’t prepared for the rampant corruption reaching the top of your organization. You refused to cover for your fellow officers and were told in no simple terms to leave town or face the consequences. Now you travel as a hero, acting as the protector you always wanted to be.", "Corruption Within" },
                    { 105, 18, "Your partner was murdered. That much is irrefutable. But you didn’t do it, despite what the evidence implies. When it became clear you’d take the fall, you fled, leaving everything behind. Not content to cower in the shadows, you decided to adventure under a new name while you work to clear your own.", "Frame Job" },
                    { 106, 18, "You learned everything you know about the job from someone you always looked up to in a corrupt organization. One night, they sent you a cryptic message saying they had discovered “something big,” but before you found out more, they disappeared. No longer sure who you could trust, you slipped away and sought a new life. Now you do what good you can and search to find the truth.", "Missing Mentor" },
                    { 107, 18, "A particularly violent or depraved criminal began targeting you—perhaps stealing something personal or hurting someone you love—after slipping through your grasp. You left your career to pursue the criminal, but the trail has gone cold … for now. Might as well help folk in the meantime.", "One That Got Away" },
                    { 108, 18, "You made it your responsibility to root out and bring down the region’s foremost crime syndicate. They sent goons to burn down your home and teach you a lesson, leaving you bleeding in the street with nothing left except your life. You’ve since taken on the life of a hero to gain the power and influence you need to destroy the syndicate once and for all.", "Powerful Enemies" }
                });

            migrationBuilder.CreateIndex(
                name: "ix_career_perk_type_id",
                table: "career",
                column: "perk_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_career_skill_option_id",
                table: "career",
                column: "skill_option_id");

            migrationBuilder.CreateIndex(
                name: "ix_career_question_career_id",
                table: "career_question",
                column: "career_id");

            migrationBuilder.CreateIndex(
                name: "ix_culture_preset_ancestry_ancestry_id",
                table: "culture_preset_ancestry",
                column: "ancestry_id");

            migrationBuilder.CreateIndex(
                name: "ix_culture_preset_ancestry_environment_id",
                table: "culture_preset_ancestry",
                column: "environment_id");

            migrationBuilder.CreateIndex(
                name: "ix_culture_preset_ancestry_language_id",
                table: "culture_preset_ancestry",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "ix_culture_preset_ancestry_organization_id",
                table: "culture_preset_ancestry",
                column: "organization_id");

            migrationBuilder.CreateIndex(
                name: "ix_culture_preset_ancestry_upbringing_id",
                table: "culture_preset_ancestry",
                column: "upbringing_id");

            migrationBuilder.CreateIndex(
                name: "ix_culture_preset_community_environment_id",
                table: "culture_preset_community",
                column: "environment_id");

            migrationBuilder.CreateIndex(
                name: "ix_culture_preset_community_organization_id",
                table: "culture_preset_community",
                column: "organization_id");

            migrationBuilder.CreateIndex(
                name: "ix_culture_preset_community_upbringing_id",
                table: "culture_preset_community",
                column: "upbringing_id");

            migrationBuilder.CreateIndex(
                name: "ix_environment_skill_option_id",
                table: "environment",
                column: "skill_option_id");

            migrationBuilder.CreateIndex(
                name: "ix_inciting_incident_career_id",
                table: "inciting_incident",
                column: "career_id");

            migrationBuilder.CreateIndex(
                name: "ix_organization_skill_option_id",
                table: "organization",
                column: "skill_option_id");

            migrationBuilder.CreateIndex(
                name: "ix_upbringing_skill_option_id",
                table: "upbringing",
                column: "skill_option_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "career_question");

            migrationBuilder.DropTable(
                name: "culture_preset_ancestry");

            migrationBuilder.DropTable(
                name: "culture_preset_community");

            migrationBuilder.DropTable(
                name: "hero_class");

            migrationBuilder.DropTable(
                name: "inciting_incident");

            migrationBuilder.DropTable(
                name: "language");

            migrationBuilder.DropTable(
                name: "environment");

            migrationBuilder.DropTable(
                name: "organization");

            migrationBuilder.DropTable(
                name: "upbringing");

            migrationBuilder.DropTable(
                name: "career");

            migrationBuilder.DeleteData(
                table: "skill",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "skill",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 15, 16 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 15, 17 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 16, 18 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 16, 19 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 17, 20 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 18, 21 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 18, 22 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 18, 23 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 19, 24 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 19, 25 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 20, 26 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 20, 27 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 21, 28 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 21, 29 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 22, 30 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 22, 31 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 23, 32 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 24, 33 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 24, 34 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 25, 35 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 25, 36 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 26, 37 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 26, 38 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 27, 39 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 28, 40 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 29, 41 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 29, 42 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 30, 43 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 30, 44 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 31, 45 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 31, 46 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 31, 47 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 32, 48 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 32, 49 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 33, 50 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 34, 51 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 35, 52 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 35, 53 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 36, 54 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 36, 55 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 37, 56 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 37, 57 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 38, 58 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 38, 59 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 39, 60 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 39, 61 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 40, 62 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 40, 63 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 41, 64 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 41, 65 });

            migrationBuilder.DeleteData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 41, 66 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 30, 10 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 31, 10 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 25, 12 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 13, 13 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 16, 13 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 19, 13 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 27, 13 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 34, 13 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 45, 13 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 50, 13 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 44, 15 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 54, 21 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 47, 24 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 53, 26 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 18, 28 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 25, 30 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 13, 33 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 49, 35 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 30, 37 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 31, 37 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 20, 41 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 51, 45 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 34, 48 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 49, 52 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 51, 54 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 52, 56 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 39, 58 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 44, 58 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 47, 59 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 28, 60 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 2, 61 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 3, 61 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 6, 61 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 9, 61 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 21, 61 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 22, 61 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 34, 61 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 43, 61 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 46, 61 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 50, 61 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 56, 61 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 33, 62 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 52, 62 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill",
                keyColumns: new[] { "skill_id", "skill_pool_id" },
                keyValues: new object[] { 33, 64 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 5, 19 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 2, 22 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 3, 22 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 4, 25 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 5, 27 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 2, 29 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 2, 31 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 1, 34 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 5, 36 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 3, 38 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 3, 39 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 5, 40 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 2, 42 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 2, 43 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 4, 44 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 2, 46 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 4, 47 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 4, 49 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 3, 50 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 5, 50 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 3, 51 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 5, 51 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 1, 53 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 5, 53 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 2, 55 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 4, 55 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 3, 57 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 5, 57 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 2, 59 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 3, 59 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 4, 59 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 2, 61 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 3, 63 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 5, 63 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 3, 65 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 4, 66 });

            migrationBuilder.DeleteData(
                table: "skill_pool_skill_group",
                keyColumns: new[] { "skill_group_id", "skill_pool_id" },
                keyValues: new object[] { 5, 66 });

            migrationBuilder.DeleteData(
                table: "skill",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "description", "name" },
                values: new object[] { "Make ranged weapons and ammunition", "Fletching" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "description", "name" },
                values: new object[] { "Create false badges, documents, and other items", "Forgery" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "description", "name" },
                values: new object[] { "Create bracelets, crowns, rings, and other jewelry", "Jewelry" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "description", "name" },
                values: new object[] { "Build machines and clockwork items", "Mechanics" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "description", "name" },
                values: new object[] { "Craft cloth and leather clothing", "Tailoring" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "description", "name" },
                values: new object[] { "Move up vertical surfaces", "Climb" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "description", "name", "skill_group_id" },
                values: new object[] { "Control vehicles", "Drive", 2 });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "description", "name", "skill_group_id" },
                values: new object[] { "Remain engaged in strenuous activity over a long period of time", "Endurance", 2 });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "description", "name" },
                values: new object[] { "Move across unsteady or narrow surfaces, and tumble", "Gymnastics" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "description", "name" },
                values: new object[] { "Use mundane first aid", "Heal" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "description", "name" },
                values: new object[] { "Leap vertical and horizontal distances", "Jump" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "description", "name" },
                values: new object[] { "Pick up, carry, and throw heavy objects", "Lift" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "description", "name" },
                values: new object[] { "Read a map and travel without becoming lost", "Navigate" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "description", "name" },
                values: new object[] { "Ride and control a mount who isn’t sapient, such as a horse", "Ride" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "description", "name" },
                values: new object[] { "Move through deep liquid", "Swim" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "description", "name", "skill_group_id" },
                values: new object[] { "Impress others with stories of your deeds", "Brag", 3 });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "description", "name", "skill_group_id" },
                values: new object[] { "Relate to someone on a personal level", "Empathize", 3 });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "description", "name" },
                values: new object[] { "Attract romantic attention from someone", "Flirt" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "description", "name" },
                values: new object[] { "Make bets with others", "Gamble" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "description", "name" },
                values: new object[] { "Interact with animal wildlife that isn’t sapient", "Handle Animals" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "description", "name" },
                values: new object[] { "Obtain information from a creature withholding it", "Interrogate" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "description", "name" },
                values: new object[] { "Awe or scare a creature", "Intimidate" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "description", "name" },
                values: new object[] { "Inspire people to action", "Lead" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "description", "name" },
                values: new object[] { "Convince someone that a falsehood is true", "Lie" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "description", "name" },
                values: new object[] { "Perform music vocally or with an instrument", "Music" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "description", "name" },
                values: new object[] { "Engage in dance, oratory, acting, or some other physical performance", "Perform" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "description", "name" },
                values: new object[] { "Convince someone to agree with you through use of your charms and grace", "Persuade" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "description", "name" },
                values: new object[] { "Read the emotions and body language of other creatures", "Read Person" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "description", "name", "skill_group_id" },
                values: new object[] { "Intuitively sense the details of your surroundings", "Alertness", 4 });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "description", "name", "skill_group_id" },
                values: new object[] { "Hide an object on your person or in your environment", "Conceal Object", 4 });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "description", "name" },
                values: new object[] { "Change your appearance to look like a different person", "Disguise" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "description", "name" },
                values: new object[] { "Actively listen to something that is hard to hear, such as a whispered conversation through a door", "Eavesdrop" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "description", "name" },
                values: new object[] { "Escape from bonds such as rope or manacles", "Escape Artist" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "description", "name" },
                values: new object[] { "Conceal yourself from others’ observation", "Hide" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "description", "name" },
                values: new object[] { "Open a lock without using the key", "Pick Lock" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "description", "name" },
                values: new object[] { "Steal an item that another person wears or carries without them noticing", "Pick Pocket" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "description", "name" },
                values: new object[] { "Disable a mechanical device such as a trap", "Sabotage" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "description", "name" },
                values: new object[] { "Actively search an environment for important details and items", "Search" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "description", "name" },
                values: new object[] { "Move silently", "Sneak" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "description", "name" },
                values: new object[] { "Follow a trail that another creature has left behind", "Track" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "description", "name", "skill_group_id" },
                values: new object[] { "Knowing about a culture’s customs, folktales, and taboos", "Culture", 5 });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "description", "name", "skill_group_id" },
                values: new object[] { "Knowing about criminal organizations, their crimes, their relationships, and their leaders", "Criminal Underworld", 5 });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "description", "name" },
                values: new object[] { "Knowing about significant past events", "History" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "description", "name" },
                values: new object[] { "Knowing about magical places, spells, rituals, items, and phenomena", "Magic" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "description", "name" },
                values: new object[] { "Knowing monster ecology, strengths, and weaknesses", "Monsters" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "description", "name" },
                values: new object[] { "Knowing about natural flora, fauna, and weather", "Nature" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "description", "name" },
                values: new object[] { "Knowing about psionic places, spells, rituals, items, and phenomena", "Psionics" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "description", "name" },
                values: new object[] { "Knowing about religious mythology, practices, and rituals", "Religion" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "description", "name" },
                values: new object[] { "Knowing gossip, legends, and uncertain truths", "Rumors" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "description", "name" },
                values: new object[] { "Knowing noble etiquette and the leadership and power dynamics of noble families", "Society" });

            migrationBuilder.UpdateData(
                table: "skill",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "description", "name" },
                values: new object[] { "Knowing about the various planets of the timescape", "Timescape" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "description", "name" },
                values: new object[] { "Two skills from the crafting skill group.", "car-artisan" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "description", "name" },
                values: new object[] { "The Criminal Underworld skill, plus two skills from the intrigue skill group.", "car-criminal" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "description", "name" },
                values: new object[] { "Two skills from the exploration skill group.", "car-gladiator" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "description", "name" },
                values: new object[] { "The Endurance skill, plus choose any two skills from Blacksmithing or the skills of the exploration skill group.", "car-laborer" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "description", "name" },
                values: new object[] { "The Magic skill, plus two skills from the lore skill group.", "car-magesapprentice" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "description", "name" },
                values: new object[] { "The Music or Performance skill, plus two skills from the interpersonal skill group.", "car-performer" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "description", "name" },
                values: new object[] { "Two skills from the lore skill group.", "car-sage" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "description", "name" },
                values: new object[] { "One skill from each of the exploration skill group and the intrigue skill group.", "car-soldier" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "description", "name" },
                values: new object[] { "Choose any two skills from the interpersonal or lore skill groups.", "cls-conduit" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "description", "name" },
                values: new object[] { "You gain Magic and can choose any three skills from the crafting or lore skill groups.", "cls-elementalist" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "description", "name" },
                values: new object[] { "Nature, plus choose any two skills from the exploration or intrigue skill groups.", "cls-fury" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "description", "name" },
                values: new object[] { "Hide and Sneak, plus choose any five skills from Criminal Underworld or the skills of the exploration, interpersonal, or intrigue skill groups.", "cls-shadow" });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "description", "name" },
                values: new object[] { "Lead, plus choose any two skills from Alertness, Architecture, Blacksmithing, Brag, Culture, Empathize, Fletching, History, Mechanics, Monsters, Search, or the skills of the exploration skill group.", "cls-tactician" });

            migrationBuilder.UpdateData(
                table: "skill_option_pool",
                keyColumns: new[] { "skill_option_id", "skill_pool_id" },
                keyValues: new object[] { 15, 15 },
                column: "count",
                value: 2);

            migrationBuilder.InsertData(
                table: "skill_option_pool",
                columns: new[] { "skill_option_id", "skill_pool_id", "count" },
                values: new object[,]
                {
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

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 15,
                column: "name",
                value: "car-artisan");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 16,
                column: "name",
                value: "car-criminal-1");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 17,
                column: "name",
                value: "car-criminal-2");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 18,
                column: "name",
                value: "car-gladiator");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 19,
                column: "name",
                value: "car-laborer-1");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 20,
                column: "name",
                value: "car-laborer-2");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 21,
                column: "name",
                value: "car-magesapprentice-1");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 22,
                column: "name",
                value: "car-magesapprentice-2");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 23,
                column: "name",
                value: "car-performer-1");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 24,
                column: "name",
                value: "car-performer-2");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 25,
                column: "name",
                value: "car-sage");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 26,
                column: "name",
                value: "car-soldier-1");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 27,
                column: "name",
                value: "car-soldier-2");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 28,
                column: "name",
                value: "cls-conduit");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 29,
                column: "name",
                value: "cls-elementalist-1");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 30,
                column: "name",
                value: "cls-elementalist-2");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 31,
                column: "name",
                value: "cls-fury-1");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 32,
                column: "name",
                value: "cls-fury-2");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 33,
                column: "name",
                value: "cls-shadow-1");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 34,
                column: "name",
                value: "cls-shadow-2");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 35,
                column: "name",
                value: "cls-tactician-1");

            migrationBuilder.UpdateData(
                table: "skill_pool",
                keyColumn: "id",
                keyValue: 36,
                column: "name",
                value: "cls-tactician-2");

            migrationBuilder.InsertData(
                table: "skill_pool_skill",
                columns: new[] { "skill_id", "skill_pool_id" },
                values: new object[,]
                {
                    { 28, 10 },
                    { 29, 10 },
                    { 23, 12 },
                    { 4, 13 },
                    { 9, 13 },
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
                    { 4, 32 },
                    { 3, 34 },
                    { 4, 34 },
                    { 2, 36 }
                });
        }
    }
}
