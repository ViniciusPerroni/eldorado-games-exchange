using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GamesExchange.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class startDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasUser = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CellNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Console = table.Column<int>(type: "int", nullable: false),
                    Studio = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exchanges",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GameId = table.Column<long>(type: "bigint", nullable: false),
                    LocatorId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exchanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exchanges_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exchanges_People_LocatorId",
                        column: x => x.LocatorId,
                        principalTable: "People",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CellNumber", "Email", "FirstName", "HasUser", "LastName", "PhoneNumber" },
                values: new object[] { 1L, "", "admin@gmail.com", "Administrator", true, "Admin", "" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "Password", "PersonId", "Role", "Username" },
                values: new object[] { 1L, true, "123456", 1L, 1, "admin" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Console", "Description", "Name", "OwnerId", "Price", "ReleaseDate", "Studio" },
                values: new object[,]
                {
                    { 1L, 12, "The Last of Us é um jogo eletrônico de ação-aventura e sobrevivência desenvolvido pela Naughty Dog e publicado pela Sony Computer Entertainment. Foi lançado em 14 de junho de 2013 para PlayStation 3.", "The Last of Us", 1L, 40m, new DateTime(2013, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 2L, 4, "Red Dead Redemption 2 é um jogo eletrônico de ação-aventura desenvolvido e publicado pela RockstarGames Games. É o terceiro título da série Red Dead e foi lançado em 26 de outubro de 2018.", "Red Dead Redemption 2", 1L, 55m, new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3L, 3, "The Legend of Zelda: Breath of the Wild é um jogo eletrônico de ação-aventura desenvolvido e publicado pela Nintendo para os consoles Nintendo Switch e Wii U. É o décimo nono título da série The Legend of Zelda e foi lançado em 3 de março de 2017.", "The Legend of Zelda: Breath of the Wild", 1L, 60m, new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4L, 4, "God of War é um jogo eletrônico de ação-aventura desenvolvido pela Santa Monica Studio e publicado pela Sony Interactive Entertainment. Foi lançado em 20 de abril de 2018 para PlayStation 4.", "God of War", 1L, 50m, new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 5L, 12, "Grand Theft Auto V é um jogo eletrônico de ação-aventura desenvolvido pela RockstarGames North e publicado pela RockstarGames Games. Foi lançado em 17 de setembro de 2013 para PlayStation 3 e Xbox 360, e em 18 de novembro para PlayStation 4 e Xbox One.", "Grand Theft Auto V", 1L, 45m, new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 6L, 4, "Dark Souls III é um jogo eletrônico de ação-aventura e RPG de ação desenvolvido pela FromSoftware e publicado pela Bandai Namco Entertainment. Foi lançado em 24 de março de 2016 para PlayStation 4, Xbox One e Microsoft Windows.", "Dark Souls III", 1L, 35m, new DateTime(2016, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 7L, 1, "FIFA 22 é um jogo eletrônico de simulação de futebol desenvolvido e publicado pela Electronic Arts. Foi lançado em 1 de outubro de 2021 para PlayStation 4, PlayStation 5, Xbox One, Xbox Series X/S, Nintendo Switch e Microsoft Windows.", "FIFA 22", 1L, 55m, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 8L, 3, "Super Mario Odyssey é um jogo eletrônico de plataforma desenvolvido e publicado pela Nintendo. Foi lançado em 27 de outubro de 2017 para Nintendo Switch.", "Super Mario Odyssey", 1L, 50m, new DateTime(2017, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 9L, 4, "Overwatch é um jogo eletrônico multijogador de tiro em primeira pessoa desenvolvido e publicado pela Blizzard Entertainment. Foi lançado em 24 de maio de 2016 para PlayStation 4, Xbox One e Microsoft Windows.", "Overwatch", 1L, 40m, new DateTime(2016, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 10L, 4, "Cyberpunk 2077 é um jogo eletrônico de RPG de ação desenvolvido e publicado pela CD Projekt. Foi lançado em 10 de dezembro de 2020 para PlayStation 4, Xbox One, Google Stadia e Microsoft Windows.", "Cyberpunk 2077", 1L, 60m, new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 11L, 4, "Uncharted 4: A Thief's End é um jogo eletrônico de ação-aventura desenvolvido pela Naughty Dog e publicado pela Sony Interactive Entertainment. Foi lançado em 10 de maio de 2016 para PlayStation 4.", "Uncharted 4: A Thief's End", 1L, 45m, new DateTime(2016, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 12L, 4, "Assassin's Creed Valhalla é um jogo eletrônico de ação-aventura e RPG desenvolvido e publicado pela Ubisoft. Foi lançado em 10 de novembro de 2020 para PlayStation 4, Xbox One, Google Stadia e Microsoft Windows.", "Assassin's Creed Valhalla", 1L, 55m, new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 13L, 3, "Super Smash Bros. Ultimate é um jogo eletrônico de luta desenvolvido pela Bandai Namco Studios e Sora Ltd. e publicado pela Nintendo. Foi lançado em 7 de dezembro de 2018 para Nintendo Switch.", "Super Smash Bros. Ultimate", 1L, 50m, new DateTime(2018, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 14L, 4, "Bloodborne é um jogo eletrônico de ação-aventura e RPG de ação desenvolvido pela FromSoftware e publicado pela Sony Computer Entertainment. Foi lançado em 24 de março de 2015 para PlayStation 4.", "Bloodborne", 1L, 40m, new DateTime(2015, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 16L, 4, "Horizon Zero Dawn é um jogo eletrônico de ação-aventura desenvolvido pela Guerrilla Games e publicado pela Sony Interactive Entertainment. Foi lançado em 28 de fevereiro de 2017 para PlayStation 4, e posteriormente para Microsoft Windows.", "Horizon Zero Dawn", 1L, 50m, new DateTime(2017, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 17L, 4, "The Witcher 3: Wild Hunt é um jogo eletrônico de RPG de ação desenvolvido pela CD Projekt RED e publicado pela CD Projekt. Foi lançado em 19 de maio de 2015 para PlayStation 4, Xbox One e Microsoft Windows.", "The Witcher 3: Wild Hunt", 1L, 55m, new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 18L, 3, "Super Mario 3D World + Bowser's Fury é um jogo eletrônico de plataforma desenvolvido e publicado pela Nintendo. Foi lançado em 12 de fevereiro de 2021 para Nintendo Switch.", "Super Mario 3D World + Bowser's Fury", 1L, 45m, new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 19L, 4, "Fortnite é um jogo eletrônico multijogador online de sobrevivência e battle royale desenvolvido e publicado pela Epic Games. Foi lançado em 25 de julho de 2017 para Microsoft Windows, macOS, PlayStation 4 e Xbox One.", "Fortnite", 1L, 0m, new DateTime(2017, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 20L, 1, "Resident Evil Village é um jogo eletrônico de survival horror desenvolvido e publicado pela Capcom. Foi lançado em 7 de maio de 2021 para PlayStation 4, PlayStation 5, Xbox One, Xbox Series X/S, Google Stadia e Microsoft Windows.", "Resident Evil Village", 1L, 50m, new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 21L, 12, "The Elder Scrolls V: Skyrim é um jogo eletrônico de RPG de ação desenvolvido e publicado pela Bethesda Game Studios. Foi lançado em 11 de novembro de 2011 para PlayStation 3, Xbox 360 e Microsoft Windows.", "The Elder Scrolls V: Skyrim", 1L, 40m, new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 22L, 11, "Super Mario Galaxy é um jogo eletrônico de plataforma desenvolvido e publicado pela Nintendo para o console Wii. Foi lançado em 1 de novembro de 2007.", "Super Mario Galaxy", 1L, 35m, new DateTime(2007, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 23L, 3, "Hades é um jogo eletrônico roguelike desenvolvido e publicado pela Supergiant Games. Foi lançado em 17 de setembro de 2020 para Nintendo Switch e Microsoft Windows.", "Hades", 1L, 25m, new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 24L, 4, "Ghost of Tsushima é um jogo eletrônico de ação-aventura desenvolvido pela Sucker Punch Productions e publicado pela Sony Interactive Entertainment. Foi lançado em 17 de julho de 2020 para PlayStation 4.", "Ghost of Tsushima", 1L, 50m, new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 25L, 3, "Pokémon Sword and Shield são jogos eletrônicos de RPG desenvolvidos pela Game Freak e publicados pela The Pokémon Company e pela Nintendo. Foram lançados em 15 de novembro de 2019 para Nintendo Switch.", "Pokémon Sword and Shield", 1L, 45m, new DateTime(2019, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 26L, 4, "Call of Duty: Warzone é um jogo eletrônico de battle royale gratuito desenvolvido e publicado pela Infinity Ward e pela Activision. Foi lançado em 10 de março de 2020 para PlayStation 4, Xbox One e Microsoft Windows.", "Call of Duty: Warzone", 1L, 0m, new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27L, 4, "Sekiro: Shadows Die Twice é um jogo eletrônico de ação-aventura e RPG de ação desenvolvido pela FromSoftware e publicado pela Activision. Foi lançado em 22 de março de 2019 para PlayStation 4, Xbox One e Microsoft Windows.", "Sekiro: Shadows Die Twice", 1L, 55m, new DateTime(2019, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 28L, 3, "Animal Crossing: New Horizons é um jogo eletrônico de simulação de vida desenvolvido e publicado pela Nintendo. Foi lançado em 20 de março de 2020 para Nintendo Switch.", "Animal Crossing: New Horizons", 1L, 45m, new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 29L, 4, "Marvel's Spider-Man é um jogo eletrônico de ação-aventura desenvolvido pela Insomniac Games e publicado pela Sony Interactive Entertainment. Foi lançado em 7 de setembro de 2018 para PlayStation 4.", "Marvel's Spider-Man", 1L, 50m, new DateTime(2018, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exchanges_GameId",
                table: "Exchanges",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Exchanges_LocatorId",
                table: "Exchanges",
                column: "LocatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_OwnerId",
                table: "Games",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PersonId",
                table: "Users",
                column: "PersonId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exchanges");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
