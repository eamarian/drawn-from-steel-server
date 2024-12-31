using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrawnFromSteel.Migrations
{
    /// <inheritdoc />
    public partial class AddSkills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "skill_group",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_skill_group", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "skill",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    skill_group_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_skill", x => x.id);
                    table.ForeignKey(
                        name: "fk_skill_skill_group_skill_group_id",
                        column: x => x.skill_group_id,
                        principalTable: "skill_group",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "skill_group",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "Skills from the crafting skill group are used in the creation and appraisal of goods and for jury-rigging contraptions. They are especially useful during rests and downtime.", "Crafting" },
                    { 2, "Skills from the exploration skill group are used to physically explore the environment around the characters, and to overcome physical obstacles.", "Exploration" },
                    { 3, "Skills from the interpersonal skill group are used to socially interact with other creatures, and are particularly useful during negotiations. Aside from the Handle Animals skill, you can generally only use interpersonal skills when you attempt to influence creatures who have emotions and who can understand you.", "Interpersonal" },
                    { 4, "Skills from the intrigue skill group are used in tasks centered around investigation, thievery, and spycraft.", "Intrigue" },
                    { 5, "Skills from the lore skill group are used to research and recall specific information. They are especially useful during rests and downtime.", "Lore" }
                });

            migrationBuilder.InsertData(
                table: "skill",
                columns: new[] { "id", "description", "name", "skill_group_id" },
                values: new object[,]
                {
                    { 1, "Make bombs and potions", "Alchemy", 1 },
                    { 2, "Create buildings and vehicles", "Architecture", 1 },
                    { 3, "Forge metal armor and weapons", "Blacksmithing", 1 },
                    { 4, "Make ranged weapons and ammunition", "Fletching", 1 },
                    { 5, "Create false badges, documents, and other items", "Forgery", 1 },
                    { 6, "Create bracelets, crowns, rings, and other jewelry", "Jewelry", 1 },
                    { 7, "Build machines and clockwork items", "Mechanics", 1 },
                    { 8, "Craft cloth and leather clothing", "Tailoring", 1 },
                    { 9, "Move up vertical surfaces", "Climb", 1 },
                    { 10, "Control vehicles", "Drive", 2 },
                    { 11, "Remain engaged in strenuous activity over a long period of time", "Endurance", 2 },
                    { 12, "Move across unsteady or narrow surfaces, and tumble", "Gymnastics", 2 },
                    { 13, "Use mundane first aid", "Heal", 2 },
                    { 14, "Leap vertical and horizontal distances", "Jump", 2 },
                    { 15, "Pick up, carry, and throw heavy objects", "Lift", 2 },
                    { 16, "Read a map and travel without becoming lost", "Navigate", 2 },
                    { 17, "Ride and control a mount who isn’t sapient, such as a horse", "Ride", 2 },
                    { 18, "Move through deep liquid", "Swim", 2 },
                    { 19, "Impress others with stories of your deeds", "Brag", 3 },
                    { 20, "Relate to someone on a personal level", "Empathize", 3 },
                    { 21, "Attract romantic attention from someone", "Flirt", 3 },
                    { 22, "Make bets with others", "Gamble", 3 },
                    { 23, "Interact with animal wildlife that isn’t sapient", "Handle Animals", 3 },
                    { 24, "Obtain information from a creature withholding it", "Interrogate", 3 },
                    { 25, "Awe or scare a creature", "Intimidate", 3 },
                    { 26, "Inspire people to action", "Lead", 3 },
                    { 27, "Convince someone that a falsehood is true", "Lie", 3 },
                    { 28, "Perform music vocally or with an instrument", "Music", 3 },
                    { 29, "Engage in dance, oratory, acting, or some other physical performance", "Perform", 3 },
                    { 30, "Convince someone to agree with you through use of your charms and grace", "Persuade", 3 },
                    { 31, "Read the emotions and body language of other creatures", "Read Person", 3 },
                    { 32, "Intuitively sense the details of your surroundings", "Alertness", 4 },
                    { 33, "Hide an object on your person or in your environment", "Conceal Object", 4 },
                    { 34, "Change your appearance to look like a different person", "Disguise", 4 },
                    { 35, "Actively listen to something that is hard to hear, such as a whispered conversation through a door", "Eavesdrop", 4 },
                    { 36, "Escape from bonds such as rope or manacles", "Escape Artist", 4 },
                    { 37, "Conceal yourself from others’ observation", "Hide", 4 },
                    { 38, "Open a lock without using the key", "Pick Lock", 4 },
                    { 39, "Steal an item that another person wears or carries without them noticing", "Pick Pocket", 4 },
                    { 40, "Disable a mechanical device such as a trap", "Sabotage", 4 },
                    { 41, "Actively search an environment for important details and items", "Search", 4 },
                    { 42, "Move silently", "Sneak", 4 },
                    { 43, "Follow a trail that another creature has left behind", "Track", 4 },
                    { 44, "Knowing about a culture’s customs, folktales, and taboos", "Culture", 5 },
                    { 45, "Knowing about criminal organizations, their crimes, their relationships, and their leaders", "Criminal Underworld", 5 },
                    { 46, "Knowing about significant past events", "History", 5 },
                    { 47, "Knowing about magical places, spells, rituals, items, and phenomena", "Magic", 5 },
                    { 48, "Knowing monster ecology, strengths, and weaknesses", "Monsters", 5 },
                    { 49, "Knowing about natural flora, fauna, and weather", "Nature", 5 },
                    { 50, "Knowing about psionic places, spells, rituals, items, and phenomena", "Psionics", 5 },
                    { 51, "Knowing about religious mythology, practices, and rituals", "Religion", 5 },
                    { 52, "Knowing gossip, legends, and uncertain truths", "Rumors", 5 },
                    { 53, "Knowing noble etiquette and the leadership and power dynamics of noble families", "Society", 5 },
                    { 54, "Knowing about the various planets of the timescape", "Timescape", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "ix_skill_skill_group_id",
                table: "skill",
                column: "skill_group_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "skill");

            migrationBuilder.DropTable(
                name: "skill_group");
        }
    }
}
