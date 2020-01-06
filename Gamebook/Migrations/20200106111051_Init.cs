using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gamebook.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "achievements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    win = table.Column<bool>(nullable: false),
                    TurnAround = table.Column<bool>(nullable: false),
                    BedroomAdventure = table.Column<bool>(nullable: false),
                    FallOut = table.Column<bool>(nullable: false),
                    CrowbarsAreHeavy = table.Column<bool>(nullable: false),
                    PushingNeverWorks = table.Column<bool>(nullable: false),
                    KnifeFight = table.Column<bool>(nullable: false),
                    KungFuFight = table.Column<bool>(nullable: false),
                    ItsDark = table.Column<bool>(nullable: false),
                    DoNothingAndDie = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_achievements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "roomTexts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    text = table.Column<string>(nullable: true),
                    linktext1 = table.Column<string>(nullable: true),
                    linktext2 = table.Column<string>(nullable: true),
                    linktext3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roomTexts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    login = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "achievements",
                columns: new[] { "Id", "BedroomAdventure", "CrowbarsAreHeavy", "DoNothingAndDie", "FallOut", "ItsDark", "KnifeFight", "KungFuFight", "PushingNeverWorks", "TurnAround", "UserId", "win" },
                values: new object[] { 1, false, false, false, false, false, false, false, false, false, 0, false });

            migrationBuilder.InsertData(
                table: "roomTexts",
                columns: new[] { "Id", "linktext1", "linktext2", "linktext3", "text" },
                values: new object[,]
                {
                    { 25, "", "", "", "You suddenly feel like you can defeat the monster without any weapons. You try it and fail horribly. You died." },
                    { 24, "", "", "", "You decide that the knife you got is a really good weapon against a deadly monster. It wasn't and you died." },
                    { 23, "", "", "", "You pulled and it opened, so you closed it behind you and ran. The monster didn't know how doors work and you got away. " },
                    { 22, "", "", "", "You tried pushing, it didn't work and you don't have the time to try pulling now. The monster catched up to you and you died horribly." },
                    { 21, "push", "pull", "", "You're running as fast as you can and now there's a door. Will you push or pull?" },
                    { 20, "", "", "", "You decide to run, but the crowbar is so heavy that the monster catches up and rips you apart." },
                    { 19, "run", "fight", "", "As you enter the basement, you suddenly see a not very friendly looking monster coming your way. Do you run or fight?" },
                    { 18, "", "", "", "You look out of the cool window. You looked so close that you fell out and died." },
                    { 17, "", "", "", "Down to the basement you go!" },
                    { 16, "", "", "", "You try to open the door to the living room, but you can't. If only you had that crowbar now. The only way to go is now to the basement." },
                    { 15, "", "", "", "You decide to leave your crowbar there and continue down the stairs into the basement." },
                    { 14, "", "", "", "You decide to keep your crowbar and continue down the stairs into the basement." },
                    { 13, "yes", "no", "", "You feel happy that you grabbed that crowbar, get in there and find a flashlight. Such an awesome source of light! Would you like to keep your crowbar?" },
                    { 12, "living room", "Basement", "cool window, check it out", "Ignoring the singing, you continue down the hallway only to find 3 things. a living room that's boarded up, probably accesible with a crowbar, stairs to the basement and a very cool open window that you feel extreme urge to check out. Which one do you choose?" },
                    { 11, "", "", "", "You decide to enter the hallway. You immediatelly realise how big of a mistake that was. The song from a little girl standing in the middle of the room immediatelly stops and she looks straight at you with her black eyes. You pass out and never wake up again." },
                    { 10, "bedroom", "continue down the hallway", "", "You enter a hallway. You hear someone sing behind a door to a bedroom. Do you want to see who's singing, or do you want to continue down the hallway" },
                    { 9, "bedroom", "continue down the hallway", "", "You leave the knife be and go to the hallway. You hear someone sing behind a door to a bedroom. Would you like to check it out or do you continue down the hallway?" },
                    { 8, "bedroom", "continue down the hallway", "", "You pull the knife out of the wall, and take it with you on an adventure to the hallway. You hear someone sing behind a door to a bedroom. Would you like to check it out or do you continue down the hallway?" },
                    { 7, "yes", "no", "", "As you enter the kitchen, you notice a knife stuck in the wall. Would you like to take it?" },
                    { 6, "kitchen", "continue down the hallway hallway", "", "You enter the hallway. You see a door to a kitchen. Would you like to go in there, or continue down the hallway" },
                    { 5, "bedroom", "even more hallway", "", "You decide to leave the crowbar there and exit through another door in the garage. You enter the Hallway. In the darkness, you hear someone sing behind a door to a bedroom. Where would you like to go?" },
                    { 4, "bedroom", "continue down the hallway", "", "You take the crowbar and exit through another door in the garage. You enter the Hallway. In the darkness, you hear someone sing behind a door to a bedroom. Where would you like to go?" },
                    { 3, "Yes", "No", "", "You entered the garage and as you look around, you find a crowbar, thinking that it might be useful. Would you like to take it?" },
                    { 2, "", "", "", "You go outside, decide that it isn't worth the risk of a monster or something and leave." },
                    { 1, "Outside", "Garage", "Hallway", "You enter the presumably haunted house, looking for any clues of the incident that happened a year ago. As you look around you see that there are exactly 3 doors, one leads to the outside, one leads to a Garage and one leads to a Hallway. Which one do you choose?" },
                    { 26, "", "", "", "You don't have a flashlight and it's dark. You feel a breath on your back. A monster ripped you apart." }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "login", "password" },
                values: new object[] { 1, "first", "first" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "achievements");

            migrationBuilder.DropTable(
                name: "roomTexts");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
