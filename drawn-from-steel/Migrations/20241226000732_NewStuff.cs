using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrawnFromSteel.Migrations
{
    /// <inheritdoc />
    public partial class NewStuff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "skill_pool",
                type: "varchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "skill_option",
                type: "varchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "skill_option",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "skill_group",
                type: "varchar(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "skill_group",
                type: "varchar(500)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "skill",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "skill",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "type",
                table: "ancestry",
                type: "varchar(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "sub_type",
                table: "ancestry",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "ancestry",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "max_height_inches",
                table: "ancestry",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "max_life_expectancy_years",
                table: "ancestry",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "max_weight_pounds",
                table: "ancestry",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "min_height_inches",
                table: "ancestry",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "min_life_expectancy_years",
                table: "ancestry",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "min_weight_pounds",
                table: "ancestry",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "points",
                table: "ancestry",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "stability",
                table: "ancestry",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "armor_category",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    category = table.Column<string>(type: "varchar(30)", nullable: false),
                    description = table.Column<string>(type: "varchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_armor_category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "characteristic",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    name = table.Column<string>(type: "varchar(10)", nullable: false),
                    @short = table.Column<char>(name: "short", type: "character(1)", nullable: false),
                    description = table.Column<string>(type: "varchar(300)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_characteristic", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hero_level_echelon",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    echelon = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "varchar(1000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_hero_level_echelon", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "kit",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    name = table.Column<string>(type: "varchar(30)", nullable: false),
                    description = table.Column<string>(type: "varchar(500)", nullable: false),
                    stamina_bonus_per_echelon = table.Column<int>(type: "integer", nullable: false),
                    speed_bonus = table.Column<int>(type: "integer", nullable: false),
                    stability_bonus = table.Column<int>(type: "integer", nullable: false),
                    melee_damage_bonus_tier1 = table.Column<int>(type: "integer", nullable: false),
                    melee_damage_bonus_tier2 = table.Column<int>(type: "integer", nullable: false),
                    melee_damage_bonus_tier3 = table.Column<int>(type: "integer", nullable: false),
                    ranged_damage_bonus_tier1 = table.Column<int>(type: "integer", nullable: false),
                    ranged_damage_bonus_tier2 = table.Column<int>(type: "integer", nullable: false),
                    ranged_damage_bonus_tier3 = table.Column<int>(type: "integer", nullable: false),
                    ranged_distance_bonus = table.Column<int>(type: "integer", nullable: false),
                    melee_distance_bonus = table.Column<int>(type: "integer", nullable: false),
                    disengage_bonus = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_kit", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "perk_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    type = table.Column<string>(type: "varchar(15)", nullable: false),
                    description = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_perk_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "purchased_ancestry_trait",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    cost = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", nullable: false),
                    description = table.Column<string>(type: "varchar(500)", nullable: false),
                    ancestry_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_purchased_ancestry_trait", x => x.id);
                    table.ForeignKey(
                        name: "fk_purchased_ancestry_trait_ancestry_ancestry_id",
                        column: x => x.ancestry_id,
                        principalTable: "ancestry",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "signature_ancestry_trait",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    name = table.Column<string>(type: "varchar(50)", nullable: false),
                    description = table.Column<string>(type: "varchar(500)", nullable: false),
                    ancestry_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_signature_ancestry_trait", x => x.id);
                    table.ForeignKey(
                        name: "fk_signature_ancestry_trait_ancestry_ancestry_id",
                        column: x => x.ancestry_id,
                        principalTable: "ancestry",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "weapon_category",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    category = table.Column<string>(type: "varchar(30)", nullable: false),
                    description = table.Column<string>(type: "varchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_weapon_category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hero_level",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    level = table.Column<int>(type: "integer", nullable: false),
                    hero_level_echelon_id = table.Column<int>(type: "integer", nullable: false),
                    xp_threshhold = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_hero_level", x => x.id);
                    table.ForeignKey(
                        name: "fk_hero_level_hero_level_echelon_hero_level_echelon_id",
                        column: x => x.hero_level_echelon_id,
                        principalTable: "hero_level_echelon",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "kit_armor_category",
                columns: table => new
                {
                    kit_id = table.Column<int>(type: "integer", nullable: false),
                    armor_category_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_kit_armor_category", x => new { x.kit_id, x.armor_category_id });
                    table.ForeignKey(
                        name: "fk_kit_armor_category_armor_category_armor_category_id",
                        column: x => x.armor_category_id,
                        principalTable: "armor_category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_kit_armor_category_kit_kit_id",
                        column: x => x.kit_id,
                        principalTable: "kit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "kit_weapon_category",
                columns: table => new
                {
                    kit_id = table.Column<int>(type: "integer", nullable: false),
                    weapon_category_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_kit_weapon_category", x => new { x.kit_id, x.weapon_category_id });
                    table.ForeignKey(
                        name: "fk_kit_weapon_category_kit_kit_id",
                        column: x => x.kit_id,
                        principalTable: "kit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_kit_weapon_category_weapon_category_weapon_category_id",
                        column: x => x.weapon_category_id,
                        principalTable: "weapon_category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "max_height_inches", "max_life_expectancy_years", "max_weight_pounds", "min_height_inches", "min_life_expectancy_years", "min_weight_pounds", "points", "stability" },
                values: new object[] { 72, 120, 250, 60, 70, 120, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "max_height_inches", "max_life_expectancy_years", "max_weight_pounds", "min_height_inches", "min_life_expectancy_years", "min_weight_pounds", "points", "stability" },
                values: new object[] { 84, 90, 350, 72, 50, 200, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "max_height_inches", "max_life_expectancy_years", "max_weight_pounds", "min_height_inches", "min_life_expectancy_years", "min_weight_pounds", "points", "stability" },
                values: new object[] { 54, 1500, 1000, 48, 700, 500, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "max_height_inches", "max_life_expectancy_years", "max_weight_pounds", "min_height_inches", "min_life_expectancy_years", "min_weight_pounds", "points", "stability" },
                values: new object[] { 78, 3000, 150, 66, 1200, 100, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "max_height_inches", "max_life_expectancy_years", "max_weight_pounds", "min_height_inches", "min_life_expectancy_years", "min_weight_pounds", "points", "stability" },
                values: new object[] { 78, 3000, 150, 66, 1200, 100, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "max_height_inches", "max_life_expectancy_years", "max_weight_pounds", "min_height_inches", "min_life_expectancy_years", "min_weight_pounds", "points", "stability" },
                values: new object[] { 102, 500, 2000, 90, 300, 1000, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "max_height_inches", "max_life_expectancy_years", "max_weight_pounds", "min_height_inches", "min_life_expectancy_years", "min_weight_pounds", "points", "stability" },
                values: new object[] { 72, 120, 300, 60, 70, 100, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "max_height_inches", "max_life_expectancy_years", "max_weight_pounds", "min_height_inches", "min_life_expectancy_years", "min_weight_pounds", "points", "stability" },
                values: new object[] { 72, 120, 100, 60, 70, 50, 4, 0 });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "max_height_inches", "max_life_expectancy_years", "max_weight_pounds", "min_height_inches", "min_life_expectancy_years", "min_weight_pounds", "points", "stability" },
                values: new object[] { 78, 90, 300, 66, 50, 150, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "max_height_inches", "max_life_expectancy_years", "max_weight_pounds", "min_height_inches", "min_life_expectancy_years", "min_weight_pounds", "points", "stability" },
                values: new object[] { 42, 90, 50, 36, 50, 20, 3, 0 });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "max_height_inches", "max_life_expectancy_years", "max_weight_pounds", "min_height_inches", "min_life_expectancy_years", "min_weight_pounds", "points", "stability" },
                values: new object[] { 0, 0, 0, 0, 0, 0, 2, 0 });

            migrationBuilder.UpdateData(
                table: "ancestry",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "max_height_inches", "max_life_expectancy_years", "max_weight_pounds", "min_height_inches", "min_life_expectancy_years", "min_weight_pounds", "points", "stability" },
                values: new object[] { 72, 90, 250, 60, 50, 120, 2, 0 });

            migrationBuilder.InsertData(
                table: "armor_category",
                columns: new[] { "id", "category", "description" },
                values: new object[,]
                {
                    { 1, "None", "If a kit has no armor, you can wear whatever clothing you like! Robes, a fashionable tunic and pants, or just loincloth it—totally up to you." },
                    { 2, "Light", "If a kit features light armor, you might wear padded cloth, leather armor, or even a chain shirt." },
                    { 3, "Medium", "If a kit has medium armor, you might wear layers of thick hides, a breastplate, or armor made of metal scales." },
                    { 4, "Heavy", "If a kit has heavy armor, then you’re likely wearing metal from head to toe. Chain mail, ring mail, and suits of plate armor protect you better than any other mundane protection." },
                    { 5, "Shield", "If a kit has a shield, then you wield a shield that can be any shape and made of any mundane material you like. The best shields have a sweet insignia on them, so start thinking about yours!" }
                });

            migrationBuilder.InsertData(
                table: "characteristic",
                columns: new[] { "id", "description", "name", "short" },
                values: new object[,]
                {
                    { 1, "Might (M) represents strength and brawn. A creature’s ability to break down doors, swing an axe, stand up during an earthquake, or hurl an ally across a chasm is determined by Might.", "Might", 'M' },
                    { 2, "Agility (A) represents coordination and nimbleness. A creature’s ability to backflip out of danger, shoot a crossbow, dodge an explosion, or pluck keys from a guard’s belt is determined by Agility.", "Agility", 'A' },
                    { 3, "Reason (R) represents a logical mind and education. A creature’s ability to solve a puzzle that unlocks a door, recall lore about necromancy, decipher a coded message, or blast a foe with psionic power is determined by Reason.", "Reason", 'R' },
                    { 4, "Intuition (I) represents instincts and experience. A creature’s ability to recognize a faint sound as the approach of a distant rider, quickly read the tell of a bluffing gambler, calm a rearing horse, or track a monster across the tundra is determined by Intuition.", "Intuition", 'I' },
                    { 5, "Presence (P) represents force of personality. A creature’s ability to lie to a judge, convince a crowd to join a revolution, impress a queen at a royal banquet, or cast a magic spell by singing a song is determined by Presence.", "Presence", 'P' }
                });

            migrationBuilder.InsertData(
                table: "hero_level_echelon",
                columns: new[] { "id", "description", "echelon" },
                values: new object[,]
                {
                    { 1, "The 1st echelon of play encompasses levels 1 to 3. At this echelon, the player characters are local heroes. They save lost caravans, besieged villages, and overlooked neighborhood s of cities. The heroes battle bands of mortal humanoids —dwarves, elves, goblins, humans, kobolds, orcs. They face the occasional larger monstrous threat, such as a bredbeddle, ogre, or chimera. These are the kinds of creatures that can threaten a small community, but rarely have plans for world domination or the destruction of the timescape.However, the adversaries might work for or be manipulated by a stronger threat as a foreshadowing of what awaits the hero at higher echelons.", 1 },
                    { 2, "The 2nd echelon of play encompasses levels 4 to 6. At this echelon, heroes are now known throughout wider region they serve. In Vasloria, this mean s that they’re saving and celebrated by an entire country. In Capital, their reputation and work now encompasses several different neighborhoods of the enormous city. Heroes of the timescape might be known for saving a planet! Heroes in this echelon battle humanoids of great supernatural power, such as draconians, devils, and hobgoblin s . The bosses they face possess cunning and ambition as great as their terrible power, such as medusas and overminds. Heroes are this level also face the humanoid threats of earlier levels, but these foes are their villainous counterparts of equal power instead of bands of ruffians or marauding armies.", 2 },
                    { 3, "The 3rd echelon of play encompasses levels 7 to 9. At this echelon, heroes are saving and known throughout the setting where they serve. Most folks in Vasloria, Capital, or the timescape itself know of the heroes and are grateful for their efforts saving the continent, massive city, or many worlds, respectively . Foes at this echelon include beings of great power, such as giants, vampires, and valok.", 3 },
                    { 4, "The 4th echelon of play encompasses level 10 (and possibly beyond in future products). At this echelon, heroes are saving the entire timescape from threats like liches, powerful dragons, and Ajax the Invincible.", 4 }
                });

            migrationBuilder.InsertData(
                table: "kit",
                columns: new[] { "id", "description", "disengage_bonus", "melee_damage_bonus_tier1", "melee_damage_bonus_tier2", "melee_damage_bonus_tier3", "melee_distance_bonus", "name", "ranged_damage_bonus_tier1", "ranged_damage_bonus_tier2", "ranged_damage_bonus_tier3", "ranged_distance_bonus", "speed_bonus", "stability_bonus", "stamina_bonus_per_echelon" },
                values: new object[,]
                {
                    { 1, "The Arcane Archer kit allows you to combine magic and ranged weapon attacks. Your lack of armor keeps you mobile, and your magic makes your arrows explode to devastate your foes.", 1, 0, 0, 0, 0, "Arcane Archer", 2, 2, 2, 10, 1, 0, 0 },
                    { 2, "Who says lightly armored heroes can’t also be hard to move? You just need to employ some psionics! You use the Battlemind kit harnesses the power of your mind to make yourself harder to move and your foes easier to push around.", 0, 2, 2, 2, 0, "Battlemind", 0, 0, 0, 0, 2, 1, 3 },
                    { 3, "Providing throwable light weapons and light armor easily concealed by a cloak to confuse your enemies, the Cloak and Dagger kit makes you more mobile while providing a boost to your effectiveness at range and to your damage. This kit is good for a hero who wants to be able to move all over the battlefield while keeping their options open for using short-range attacks.", 1, 1, 1, 1, 0, "Cloak and Dagger", 1, 1, 1, 5, 2, 0, 3 },
                    { 4, "The Dual Wielder kit is for folks who want to excel at using two weapons at the same time. The fighting style maximizes the power of each instrument in your hands, making you a whirling deliverer of death.", 1, 2, 2, 2, 0, "Dual Wielder", 0, 0, 0, 0, 2, 0, 6 },
                    { 5, "The Guisarmier kit is for those who want to use a polearm for extended reach and still gain the extra protection of armor. This is the kit that allows you to become the ultimate halberd, longspear, or glaive fighter.", 0, 2, 2, 2, 1, "Guisarmier", 0, 0, 0, 0, 0, 1, 6 },
                    { 6, "If you want to be fast in a fight, then Martial Artist is the kit for you. Unencumbered by weapons or armor, this fighting style rewards quick, focused unarmed strikes to opponents, and allows you to be the ultimate skirmisher.", 1, 2, 2, 2, 0, "Martial Artist", 0, 0, 0, 0, 3, 0, 3 },
                    { 7, "The Mountain kit does exactly what it says on the tin. You don heavy armor and a heavy weapon to stand strong against your foes, quickly demolishing them when it’s your turn to attack.", 0, 0, 0, 4, 0, "Mountain", 0, 0, 0, 0, 0, 2, 9 },
                    { 8, "If you want a good balance of protection, speed, and damage, the Panther kit is for you. This kit increases your Stamina not by wearing armor, but through the focused battle preparation of body and mind, letting you be fast and mobile while swinging a heavy weapon at your foes.", 0, 0, 0, 4, 0, "Panther", 0, 0, 0, 0, 1, 1, 6 },
                    { 9, "Meant for brawlers and boxers, the Pugilist kit gives you access to a melee fighting style that gives you a boost to Stamina and damage while allowing you to float like a butterfly. If you want to be a tough, strong hero who doles out punishment with your fists, then this kit is for you.", 0, 1, 1, 1, 0, "Pugilist", 0, 0, 0, 0, 2, 1, 6 },
                    { 10, "The Raider kit keeps you protected while granting you full mobility, providing a boost to speed and distance that lets you run around the battlefield like a Viking warrior.", 1, 1, 1, 1, 0, "Raider", 1, 1, 1, 5, 1, 0, 6 },
                    { 11, "The Ranger kit outfits you with light armor and several weapons, letting you easily switch between using a melee weapon and a bow. This kit provides a good balance of bonuses to Stamina, speed, damage, and range to create a hero who is a jack-of-all-trades.", 1, 1, 1, 1, 0, "Ranger", 1, 1, 1, 5, 1, 0, 6 },
                    { 12, "The Rapid-Fire kit is for archers who want to deal maximum damage by shooting as many arrows as possible into nearby enemies. With this kit, your fighting technique focuses on peppering foes at medium range.", 1, 0, 0, 0, 0, "Rapid-Fire", 2, 2, 2, 7, 1, 0, 3 },
                    { 13, "The retiarius is often depicted as a lightly armored warrior with a net in one hand and a trident in the other, and this kit gives you the equipment and fighting technique to make that happen. Tie up your foe with a net and then poke them to death!", 1, 2, 2, 2, 1, "Retiarius", 0, 0, 0, 0, 1, 0, 3 },
                    { 14, "The Shining Armor kit provides the most protection a kit can afford, providing you with the sword, shield, and armor necessary to play the prototypical knight.", 0, 2, 2, 2, 0, "Shining Armor", 0, 0, 0, 0, 0, 1, 12 },
                    { 15, "The Sniper kit gives you the tools and techniques to take down enemies from afar. This kit can help you become the archer who lurks behind trees or down tunnels, picking off enemies with a bow or crossbow as they approach", 1, 0, 0, 0, 0, "Sniper", 0, 0, 4, 10, 1, 0, 0 },
                    { 16, "The Spellsword kit combines melee attacks and a little bit of magic for warriors who don’t want to have to choose between the incantation and the blade.", 0, 2, 2, 3, 0, "Spellsword", 0, 0, 0, 0, 1, 1, 6 },
                    { 17, "Armed with a simple reach weapon, often a quarterstaff, heroes using the Stick and Robe kit are highly mobile thanks to their light armor. This allows them to make maximum use of their weapon’s length.", 1, 1, 1, 1, 1, "Stick and Robe", 0, 0, 0, 0, 2, 0, 3 },
                    { 18, "If you want to be mobile and deal a lot of damage with melee attacks, then you should reach for the Swashbuckler kit. This is a great kit for heroes who want to be master duelists.", 1, 2, 2, 2, 0, "Swashbuckler", 0, 0, 0, 0, 3, 0, 3 },
                    { 19, "The Sword and Board kit doesn't just give you a shield—it makes the shield part of your offensive arsenal. With a medium weapon in one hand and a block of steel or solid oak in the other, you can protect yourself and control the battlefield.", 1, 2, 2, 2, 0, "Sword and Board", 0, 0, 0, 0, 0, 1, 9 },
                    { 20, "The Warrior Priest kit imbues the power of the gods into your weapon, making it a smiting instrument. You wade into the fray without fear, thanks to the power of the divine ... and the heavy armor you’re wearing.", 0, 1, 1, 1, 0, "Warrior Priest", 0, 0, 0, 0, 1, 1, 9 },
                    { 21, "The Whirlwind kit makes effective use of whips, granting you mobility, damage, and reach. If you want to be a mobile warrior who uses a chain or whip, then this is the kit for you.", 1, 1, 1, 1, 0, "Whirlwind", 0, 0, 0, 0, 1, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "perk_type",
                columns: new[] { "id", "description", "type" },
                values: new object[,]
                {
                    { 1, "Crafting perks let you better craft materials and become an expert in the things you create.", "Crafting" },
                    { 2, "Exploration perks let you better traverse and explore environments.", "Exploration" },
                    { 3, "Interpersonal perks let you better interact with other creatures.", "Interpersonal" },
                    { 4, "Intrigue perks let you better investigate mysteries and find the truth while keeping your secrets hidden.", "Intrigue" },
                    { 5, "Lore perks let you better research and recall specific information.", "Lore" },
                    { 6, "Supernatural perks let you use magic and psionics to influence the world around you.", "Supernatural" }
                });

            migrationBuilder.InsertData(
                table: "purchased_ancestry_trait",
                columns: new[] { "id", "ancestry_id", "cost", "description", "name" },
                values: new object[,]
                {
                    { 1, 1, 1, "Your pointy tail allows you to punctuate all your actions. Once per round, you can deal extra damage equal to your highest characteristic score on a melee strike.", "Barbed Tail" },
                    { 2, 1, 1, "Your powerful legs improve your speed. Your speed becomes 6.", "Beast Legs" },
                    { 3, 1, 1, "Your eyes are a solid, vibrant color that flares to show your excitement or rage. Whenever you take damage from a creature, you can use a triggered action to curse that creature for daring to do you harm. The creature takes d10 + your level psychic damage.", "Glowing Eyes" },
                    { 4, 1, 1, "Your eyes let you see through the dark, fog, and other types of concealment. You don’t take a bane on strikes against concealed, unhidden creatures.", "Hellsight" },
                    { 5, 1, 2, "Your cherished horns are larger than the average devil and a hardened representation of your force of will, allowing you to succeed on a roll of 5 or higher with saving throws.", "Impressive Horns" },
                    { 6, 1, 2, "Your prehensile tail allows you to challenge foes on all sides. You can’t be flanked", "Prehensile Tail" },
                    { 7, 1, 2, "You possess wings powerful enough to take you airborne. While using your wings to fly, you can stay aloft for a number of rounds equal to your Might (minimum of 1 round) before you fall prone. While using your wings to fly at 1st, 2nd, and 3rd level, you have damage weakness 5.", "Wings" }
                });

            migrationBuilder.InsertData(
                table: "signature_ancestry_trait",
                columns: new[] { "id", "ancestry_id", "description", "name" },
                values: new object[,]
                {
                    { 1, 1, "Your innate magic allows you to twist how your words are perceived to get a better read on people and convince them to see things your way. You gain an interpersonal skill of your choice, and you have an edge when attempting to discover an NPC’s motivations and pitfalls during negotiations (see Negotiation).", "Silver Tongue" },
                    { 2, 2, "Your hardened scales grant you immunity equal to your level to one of the following damage types: acid, cold, corruption, fire, lightning, or poison. You can change your damage immunity type when you finish a respite.", "Wyrmplate" },
                    { 3, 3, "TODO", "Runic Carving" }
                });

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 15,
                column: "description",
                value: "Two skills from the crafting skill group.");

            migrationBuilder.InsertData(
                table: "weapon_category",
                columns: new[] { "id", "category", "description" },
                values: new object[,]
                {
                    { 1, "Bow", "Bows cover any weapon used to fire an arrow or bolt projectile. This includes crossbows, longbows, and shortbows. You don’t need to track mundane ammunition for these weapons, unless the Director says otherwise." },
                    { 2, "Ensnaring Weapon", "Ensnaring weapons include bolas, nets, and other weapons made to capture an enemy and hold them in place." },
                    { 3, "Heavy Weapon", "Heavy weapons are two-handed melee weapons with weighty bladed or bludgeoning heads, made to seriously harm or kill enemies in a single mighty blow. Greatswords, greataxes, mauls, and morningstars are all examples of heavy weapons." },
                    { 4, "Light Weapon", "Light weapons are one-handed melee weapons that can be used to make several strikes in rapid succession. Many such weapons can be thrown or used as an off-hand defensive weapon. Daggers, shortswords, rapiers, and throwing hammers are typical light weapons. If your kit uses a light weapon, you can wield two light weapons at a time." },
                    { 5, "Medium Weapon", "Medium weapons are one-handed melee weapons that can be carried into battle while leaving one hand free, or while using that hand to hold a shield or implement. Battleaxes, clubs, longswords, and warhammers are medium weapons." },
                    { 6, "Polearm", "Polearms are two-handed melee weapons with long hafts that increase the wielder’s reach. They include glaives, halberds, longspears, and quarterstaffs." },
                    { 7, "Unarmed Strike", "Any kit that uses unarmed strikes allows you to use your body as a weapon. Punches, kicks, eye gouges, and the like are your forte." },
                    { 8, "Whip", "Whip weapons include the standard whip, but also include spiked chains, flails, and any similarly long and flexible melee weapon." }
                });

            migrationBuilder.InsertData(
                table: "hero_level",
                columns: new[] { "id", "hero_level_echelon_id", "level", "xp_threshhold" },
                values: new object[,]
                {
                    { 1, 1, 1, 0 },
                    { 2, 1, 2, 16 },
                    { 3, 1, 3, 32 },
                    { 4, 2, 4, 48 },
                    { 5, 2, 5, 64 },
                    { 6, 2, 6, 80 },
                    { 7, 3, 7, 96 },
                    { 8, 3, 8, 112 },
                    { 9, 3, 9, 128 },
                    { 10, 4, 10, 144 }
                });

            migrationBuilder.CreateIndex(
                name: "ix_hero_level_hero_level_echelon_id",
                table: "hero_level",
                column: "hero_level_echelon_id");

            migrationBuilder.CreateIndex(
                name: "ix_kit_armor_category_armor_category_id",
                table: "kit_armor_category",
                column: "armor_category_id");

            migrationBuilder.CreateIndex(
                name: "ix_kit_weapon_category_weapon_category_id",
                table: "kit_weapon_category",
                column: "weapon_category_id");

            migrationBuilder.CreateIndex(
                name: "ix_purchased_ancestry_trait_ancestry_id",
                table: "purchased_ancestry_trait",
                column: "ancestry_id");

            migrationBuilder.CreateIndex(
                name: "ix_signature_ancestry_trait_ancestry_id",
                table: "signature_ancestry_trait",
                column: "ancestry_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "characteristic");

            migrationBuilder.DropTable(
                name: "hero_level");

            migrationBuilder.DropTable(
                name: "kit_armor_category");

            migrationBuilder.DropTable(
                name: "kit_weapon_category");

            migrationBuilder.DropTable(
                name: "perk_type");

            migrationBuilder.DropTable(
                name: "purchased_ancestry_trait");

            migrationBuilder.DropTable(
                name: "signature_ancestry_trait");

            migrationBuilder.DropTable(
                name: "hero_level_echelon");

            migrationBuilder.DropTable(
                name: "armor_category");

            migrationBuilder.DropTable(
                name: "kit");

            migrationBuilder.DropTable(
                name: "weapon_category");

            migrationBuilder.DropColumn(
                name: "max_height_inches",
                table: "ancestry");

            migrationBuilder.DropColumn(
                name: "max_life_expectancy_years",
                table: "ancestry");

            migrationBuilder.DropColumn(
                name: "max_weight_pounds",
                table: "ancestry");

            migrationBuilder.DropColumn(
                name: "min_height_inches",
                table: "ancestry");

            migrationBuilder.DropColumn(
                name: "min_life_expectancy_years",
                table: "ancestry");

            migrationBuilder.DropColumn(
                name: "min_weight_pounds",
                table: "ancestry");

            migrationBuilder.DropColumn(
                name: "points",
                table: "ancestry");

            migrationBuilder.DropColumn(
                name: "stability",
                table: "ancestry");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "skill_pool",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "skill_option",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "skill_option",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "skill_group",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "skill_group",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(500)");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "skill",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "skill",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "type",
                table: "ancestry",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)");

            migrationBuilder.AlterColumn<string>(
                name: "sub_type",
                table: "ancestry",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "ancestry",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)");

            migrationBuilder.UpdateData(
                table: "skill_option",
                keyColumn: "id",
                keyValue: 15,
                column: "description",
                value: " Two skills from the crafting skill group.");
        }
    }
}
