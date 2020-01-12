using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gamebook.Migrations
{
    public partial class init : Migration
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
                    AchievementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_achievements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "linkText",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoomId = table.Column<int>(nullable: false),
                    LinkNumber = table.Column<int>(nullable: false),
                    text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_linkText", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "roomTexts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    text = table.Column<string>(nullable: true)
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
                table: "linkText",
                columns: new[] { "Id", "LinkNumber", "RoomId", "text" },
                values: new object[,]
                {
                    { 1, 1, 1, "Outside" },
                    { 27, 1, 21, "Push" },
                    { 26, 2, 19, "Fight" },
                    { 25, 1, 19, "Run" },
                    { 24, 2, 13, "No" },
                    { 23, 1, 13, "Yes" },
                    { 22, 3, 12, "Cool window, check it out" },
                    { 21, 2, 12, "Basement" },
                    { 20, 1, 12, "Living room" },
                    { 19, 2, 10, "Continue down the hallway" },
                    { 18, 1, 10, "Bedroom" },
                    { 17, 2, 9, "Continue down the hallway" },
                    { 16, 1, 9, "Bedroom" },
                    { 15, 2, 8, "Continue down the hallway" },
                    { 28, 2, 21, "Pull" },
                    { 13, 2, 7, "No" },
                    { 2, 2, 1, "Garage" },
                    { 3, 3, 1, "Hallway" },
                    { 4, 1, 3, "Yes" },
                    { 14, 1, 8, "Bedroom" },
                    { 6, 1, 4, "Bedroom" },
                    { 5, 2, 3, "No" },
                    { 8, 1, 5, "Bedroom" },
                    { 9, 2, 5, "Continue down the hallway" },
                    { 10, 1, 6, "kitchen" },
                    { 11, 2, 6, "Continue down the hallway hallway" },
                    { 12, 1, 7, "Yes" },
                    { 7, 2, 4, "Continue down the hallway" }
                });

            migrationBuilder.InsertData(
                table: "roomTexts",
                columns: new[] { "Id", "text" },
                values: new object[,]
                {
                    { 16, "You try to open the door to the living room, but you can't. If only you had that crowbar now. The only way to go is now to the basement." },
                    { 17, "Down to the basement you go!" },
                    { 18, "You look out of the cool window. You looked so close that you fell out and died." },
                    { 19, "As you enter the basement, you suddenly see a not very friendly looking monster coming your way. Do you run or fight?" },
                    { 25, "You suddenly feel like you can defeat the monster without any weapons. You try it and fail horribly. You died." },
                    { 21, "You're running as fast as you can and now there's a door. Will you push or pull?" },
                    { 22, "You tried pushing, it didn't work and you don't have the time to try pulling now. The monster catched up to you and you died horribly." },
                    { 23, "You pulled and it opened, so you closed it behind you and ran. The monster didn't know how doors work and you got away. " },
                    { 24, "You decide that the knife you got is a really good weapon against a deadly monster. It wasn't and you died." },
                    { 15, "You decide to leave your crowbar there and continue down the stairs into the basement." },
                    { 20, "You decide to run, but the crowbar is so heavy that the monster catches up and rips you apart." },
                    { 14, "You decide to keep your crowbar and continue down the stairs into the basement." },
                    { 7, "As you enter the kitchen, you notice a knife stuck in the wall. Would you like to take it?" },
                    { 12, "Ignoring the singing, you continue down the hallway only to find 3 things. a living room that's boarded up, probably accesible with a crowbar, stairs to the basement and a very cool open window that you feel extreme urge to check out. Which one do you choose?" },
                    { 11, "You decide to enter the hallway. You immediatelly realise how big of a mistake that was. The song from a little girl standing in the middle of the room immediatelly stops and she looks straight at you with her black eyes. You pass out and never wake up again." },
                    { 10, "You enter a hallway. You hear someone sing behind a door to a bedroom. Do you want to see who's singing, or do you want to continue down the hallway" },
                    { 9, "You leave the knife be and go to the hallway. You hear someone sing behind a door to a bedroom. Would you like to check it out or do you continue down the hallway?" },
                    { 8, "You pull the knife out of the wall, and take it with you on an adventure to the hallway. You hear someone sing behind a door to a bedroom. Would you like to check it out or do you continue down the hallway?" },
                    { 6, "You enter the hallway. You see a door to a kitchen. Would you like to go in there, or continue down the hallway" },
                    { 5, "You decide to leave the crowbar there and exit through another door in the garage. You enter the Hallway. In the darkness, you hear someone sing behind a door to a bedroom. Where would you like to go?" },
                    { 4, "You take the crowbar and exit through another door in the garage. You enter the Hallway. In the darkness, you hear someone sing behind a door to a bedroom. Where would you like to go?" },
                    { 3, "You entered the garage and as you look around, you find a crowbar, thinking that it might be useful. Would you like to take it?" },
                    { 2, "You go outside, decide that it isn't worth the risk of a monster or something and leave." },
                    { 1, "You enter the presumably haunted house, looking for any clues of the incident that happened a year ago. As you look around you see that there are exactly 3 doors, one leads to the outside, one leads to a Garage and one leads to a Hallway. Which one do you choose?" },
                    { 26, "You don't have a flashlight and it's dark. You feel a breath on your back. A monster ripped you apart." },
                    { 13, "You feel happy that you grabbed that crowbar, get in there and find a flashlight. Such an awesome source of light! Would you like to keep your crowbar?" }
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
                name: "linkText");

            migrationBuilder.DropTable(
                name: "roomTexts");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
