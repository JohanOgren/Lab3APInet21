using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab3APInet21.Migrations
{
    public partial class CreateDBAndSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    HobbyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.HobbyId);
                    table.ForeignKey(
                        name: "FK_Hobbies_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WebbLinks",
                columns: table => new
                {
                    WebbLinkId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link = table.Column<string>(nullable: false),
                    HobbyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebbLinks", x => x.WebbLinkId);
                    table.ForeignKey(
                        name: "FK_WebbLinks_Hobbies_HobbyId",
                        column: x => x.HobbyId,
                        principalTable: "Hobbies",
                        principalColumn: "HobbyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Tony", "0701231233" },
                    { 2, "Banner", "070321321" },
                    { 3, "Rogers", "0703123123" },
                    { 4, "Thor", "0704141444" },
                    { 5, "Strange", "0705555112" }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "HobbyId", "Description", "PersonId", "Titel" },
                values: new object[,]
                {
                    { 1, "Make them Shine", 1, "Cars" },
                    { 8, "Calculate stuff", 1, "Math" },
                    { 2, "Make them Fast", 2, "Cars" },
                    { 5, "Train Legs", 2, "WorkOut" },
                    { 6, "Train Arms", 3, "WorkOut" },
                    { 4, "Lightning", 4, "Magic" },
                    { 3, "Teleports", 5, "Magic" },
                    { 7, "Make them Weird", 5, "Cars" }
                });

            migrationBuilder.InsertData(
                table: "WebbLinks",
                columns: new[] { "WebbLinkId", "HobbyId", "Link" },
                values: new object[,]
                {
                    { 1, 1, "FakeLinkForHobby1" },
                    { 8, 8, "FakeLinkForHobby4" },
                    { 2, 2, "FakeLinkForHobby1" },
                    { 5, 5, "FakeLinkForHobby3" },
                    { 6, 6, "FakeLinkForHobby3" },
                    { 4, 4, "FakeLinkForHobby2" },
                    { 3, 3, "FakeLinkForHobby2" },
                    { 7, 7, "FakeLinkForHobby4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_PersonId",
                table: "Hobbies",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_WebbLinks_HobbyId",
                table: "WebbLinks",
                column: "HobbyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WebbLinks");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
