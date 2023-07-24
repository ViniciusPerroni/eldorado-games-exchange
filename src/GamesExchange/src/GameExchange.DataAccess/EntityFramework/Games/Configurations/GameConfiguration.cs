using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using GamesExchange.Model.Games;
using Console = GamesExchange.Model.Games.Console;

namespace GamesExchange.DataAccess.EntityFramework.Games.Configurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            #region HasData
            var game1 = new Game("The Last of Us", "The Last of Us é um jogo eletrônico de ação-aventura e sobrevivência desenvolvido pela Naughty Dog e publicado pela Sony Computer Entertainment. Foi lançado em 14 de junho de 2013 para PlayStation 3.", DateTime.Parse("14/06/2013"), 40,  Console.PlayStation3, Studio.NaughtyDog, 1);
            game1.Id = 1;
            builder.HasData(game1);
            var game2 = new Game("Red Dead Redemption 2", "Red Dead Redemption 2 é um jogo eletrônico de ação-aventura desenvolvido e publicado pela RockstarGames Games. É o terceiro título da série Red Dead e foi lançado em 26 de outubro de 2018.", DateTime.Parse("26/10/2018"), 55, Console.PlayStation4, Studio.RockstarGames, 1);
            game2.Id = 2;
            builder.HasData(game2);
            var game3 = new Game("The Legend of Zelda: Breath of the Wild", "The Legend of Zelda: Breath of the Wild é um jogo eletrônico de ação-aventura desenvolvido e publicado pela Nintendo para os consoles Nintendo Switch e Wii U. É o décimo nono título da série The Legend of Zelda e foi lançado em 3 de março de 2017.", DateTime.Parse("03/03/2017"), 60,  Console.NintendoSwitch, Studio.Nintendo, 1);
            game3.Id = 3;
            builder.HasData(game3);
            var game4 = new Game("God of War", "God of War é um jogo eletrônico de ação-aventura desenvolvido pela Santa Monica Studio e publicado pela Sony Interactive Entertainment. Foi lançado em 20 de abril de 2018 para PlayStation 4.", DateTime.Parse("20/04/2018"), 50, Console.PlayStation4, Studio.SantaMonicaStudio, 1);
            game4.Id = 4;
            builder.HasData(game4);
            var game5 = new Game("Grand Theft Auto V", "Grand Theft Auto V é um jogo eletrônico de ação-aventura desenvolvido pela RockstarGames North e publicado pela RockstarGames Games. Foi lançado em 17 de setembro de 2013 para PlayStation 3 e Xbox 360, e em 18 de novembro para PlayStation 4 e Xbox One.", DateTime.Parse("17/09/2013"), 45,  Console.PlayStation3, Studio.RockstarGames, 1);
            game5.Id = 5;
            builder.HasData(game5);
            var game6 = new Game("Dark Souls III", "Dark Souls III é um jogo eletrônico de ação-aventura e RPG de ação desenvolvido pela FromSoftware e publicado pela Bandai Namco Entertainment. Foi lançado em 24 de março de 2016 para PlayStation 4, Xbox One e Microsoft Windows.", DateTime.Parse("24/03/2016"), 35,  Console.PlayStation4, Studio.FromSoftware, 1);
            game6.Id = 6;
            builder.HasData(game6);
            var game7 = new Game("FIFA 22", "FIFA 22 é um jogo eletrônico de simulação de futebol desenvolvido e publicado pela Electronic Arts. Foi lançado em 1 de outubro de 2021 para PlayStation 4, PlayStation 5, Xbox One, Xbox Series X/S, Nintendo Switch e Microsoft Windows.", DateTime.Parse("01/10/2021"), 55,  Console.PlayStation5, Studio.ElectronicArts, 1);
            game7.Id = 7;
            builder.HasData(game7);
            var game8 = new Game("Super Mario Odyssey", "Super Mario Odyssey é um jogo eletrônico de plataforma desenvolvido e publicado pela Nintendo. Foi lançado em 27 de outubro de 2017 para Nintendo Switch.", DateTime.Parse("27/10/2017"), 50,  Console.NintendoSwitch, Studio.Nintendo, 1);
            game8.Id = 8;
            builder.HasData(game8);
            var game9 = new Game("Overwatch", "Overwatch é um jogo eletrônico multijogador de tiro em primeira pessoa desenvolvido e publicado pela Blizzard Entertainment. Foi lançado em 24 de maio de 2016 para PlayStation 4, Xbox One e Microsoft Windows.", DateTime.Parse("24/05/2016"), 40,  Console.PlayStation4, Studio.BlizzardEntertainment, 1);
            game9.Id = 9;
            builder.HasData(game9);
            var game10 = new Game("Cyberpunk 2077", "Cyberpunk 2077 é um jogo eletrônico de RPG de ação desenvolvido e publicado pela CD Projekt. Foi lançado em 10 de dezembro de 2020 para PlayStation 4, Xbox One, Google Stadia e Microsoft Windows.", DateTime.Parse("10/12/2020"), 60, Console.PlayStation4, Studio.CDProjektRed, 1);
            game10.Id = 10;
            builder.HasData(game10);
            var game11 = new Game("Uncharted 4: A Thief's End", "Uncharted 4: A Thief's End é um jogo eletrônico de ação-aventura desenvolvido pela Naughty Dog e publicado pela Sony Interactive Entertainment. Foi lançado em 10 de maio de 2016 para PlayStation 4.", DateTime.Parse("10/05/2016"), 45,  Console.PlayStation4, Studio.NaughtyDog, 1);
            game11.Id = 11;
            builder.HasData(game11);
            var game12 = new Game("Assassin's Creed Valhalla", "Assassin's Creed Valhalla é um jogo eletrônico de ação-aventura e RPG desenvolvido e publicado pela Ubisoft. Foi lançado em 10 de novembro de 2020 para PlayStation 4, Xbox One, Google Stadia e Microsoft Windows.", DateTime.Parse("10/11/2020"), 55,  Console.PlayStation4, Studio.Ubisoft, 1);
            game12.Id = 12;
            builder.HasData(game12);
            var game13 = new Game("Super Smash Bros. Ultimate", "Super Smash Bros. Ultimate é um jogo eletrônico de luta desenvolvido pela Bandai Namco Studios e Sora Ltd. e publicado pela Nintendo. Foi lançado em 7 de dezembro de 2018 para Nintendo Switch.", DateTime.Parse("07/12/2018"), 50, Console.NintendoSwitch, Studio.Nintendo, 1);
            game13.Id = 13;
            builder.HasData(game13);
            var game14 = new Game("Bloodborne", "Bloodborne é um jogo eletrônico de ação-aventura e RPG de ação desenvolvido pela FromSoftware e publicado pela Sony Computer Entertainment. Foi lançado em 24 de março de 2015 para PlayStation 4.", DateTime.Parse("24/03/2015"), 40,  Console.PlayStation4, Studio.FromSoftware, 1);
            game14.Id = 14;
            builder.HasData(game14);
            var game16 = new Game("Horizon Zero Dawn", "Horizon Zero Dawn é um jogo eletrônico de ação-aventura desenvolvido pela Guerrilla Games e publicado pela Sony Interactive Entertainment. Foi lançado em 28 de fevereiro de 2017 para PlayStation 4, e posteriormente para Microsoft Windows.", DateTime.Parse("28/02/2017"), 50,  Console.PlayStation4, Studio.GuerrillaGames, 1);
            game16.Id = 16;
            builder.HasData(game16);
            var game17 = new Game("The Witcher 3: Wild Hunt", "The Witcher 3: Wild Hunt é um jogo eletrônico de RPG de ação desenvolvido pela CD Projekt RED e publicado pela CD Projekt. Foi lançado em 19 de maio de 2015 para PlayStation 4, Xbox One e Microsoft Windows.", DateTime.Parse("19/05/2015"), 55, Console.PlayStation4, Studio.CDProjektRed, 1);
            game17.Id = 17;
            builder.HasData(game17);
            var game18 = new Game("Super Mario 3D World + Bowser's Fury", "Super Mario 3D World + Bowser's Fury é um jogo eletrônico de plataforma desenvolvido e publicado pela Nintendo. Foi lançado em 12 de fevereiro de 2021 para Nintendo Switch.", DateTime.Parse("12/02/2021"), 45,  Console.NintendoSwitch, Studio.Nintendo, 1);
            game18.Id = 18;
            builder.HasData(game18);
            var game19 = new Game("Fortnite", "Fortnite é um jogo eletrônico multijogador online de sobrevivência e battle royale desenvolvido e publicado pela Epic Games. Foi lançado em 25 de julho de 2017 para Microsoft Windows, macOS, PlayStation 4 e Xbox One.", DateTime.Parse("25/07/2017"), 0, Console.PlayStation4, Studio.EpicGames, 1);
            game19.Id = 19;
            builder.HasData(game19);
            var game20 = new Game("Resident Evil Village", "Resident Evil Village é um jogo eletrônico de survival horror desenvolvido e publicado pela Capcom. Foi lançado em 7 de maio de 2021 para PlayStation 4, PlayStation 5, Xbox One, Xbox Series X/S, Google Stadia e Microsoft Windows.", DateTime.Parse("07/05/2021"), 50, Console.PlayStation5, Studio.Capcom, 1);
            game20.Id = 20;
            builder.HasData(game20);
            var game21 = new Game("The Elder Scrolls V: Skyrim", "The Elder Scrolls V: Skyrim é um jogo eletrônico de RPG de ação desenvolvido e publicado pela Bethesda Game Studios. Foi lançado em 11 de novembro de 2011 para PlayStation 3, Xbox 360 e Microsoft Windows.", DateTime.Parse("11/11/2011"), 40, Console.PlayStation3, Studio.BethesdaGameStudios, 1);
            game21.Id = 21;
            builder.HasData(game21);
            var game22 = new Game("Super Mario Galaxy", "Super Mario Galaxy é um jogo eletrônico de plataforma desenvolvido e publicado pela Nintendo para o console Wii. Foi lançado em 1 de novembro de 2007.", DateTime.Parse("01/11/2007"), 35,  Console.NintendoWii, Studio.Nintendo, 1);
            game22.Id = 22;
            builder.HasData(game22);
            var game23 = new Game("Hades", "Hades é um jogo eletrônico roguelike desenvolvido e publicado pela Supergiant Games. Foi lançado em 17 de setembro de 2020 para Nintendo Switch e Microsoft Windows.", DateTime.Parse("17/09/2020"), 25, Console.NintendoSwitch, Studio.SquareEnix, 1);
            game23.Id = 23;
            builder.HasData(game23);
            var game24 = new Game("Ghost of Tsushima", "Ghost of Tsushima é um jogo eletrônico de ação-aventura desenvolvido pela Sucker Punch Productions e publicado pela Sony Interactive Entertainment. Foi lançado em 17 de julho de 2020 para PlayStation 4.", DateTime.Parse("17/07/2020"), 50,  Console.PlayStation4, Studio.SuckerPunchProductions, 1);
            game24.Id = 24;
            builder.HasData(game24);
            var game25 = new Game("Pokémon Sword and Shield", "Pokémon Sword and Shield são jogos eletrônicos de RPG desenvolvidos pela Game Freak e publicados pela The Pokémon Company e pela Nintendo. Foram lançados em 15 de novembro de 2019 para Nintendo Switch.", DateTime.Parse("15/11/2019"), 45, Console.NintendoSwitch, Studio.GameFreak, 1);
            game25.Id = 25;
            builder.HasData(game25);
            var game26 = new Game("Call of Duty: Warzone", "Call of Duty: Warzone é um jogo eletrônico de battle royale gratuito desenvolvido e publicado pela Infinity Ward e pela Activision. Foi lançado em 10 de março de 2020 para PlayStation 4, Xbox One e Microsoft Windows.", DateTime.Parse("10/03/2020"), 0, Console.PlayStation4, Studio.InfinityWard, 1);
            game26.Id = 26;
            builder.HasData(game26);
            var game27 = new Game("Sekiro: Shadows Die Twice", "Sekiro: Shadows Die Twice é um jogo eletrônico de ação-aventura e RPG de ação desenvolvido pela FromSoftware e publicado pela Activision. Foi lançado em 22 de março de 2019 para PlayStation 4, Xbox One e Microsoft Windows.", DateTime.Parse("22/03/2019"), 55,  Console.PlayStation4, Studio.FromSoftware, 1);
            game27.Id = 27;
            builder.HasData(game27);
            var game28 = new Game("Animal Crossing: New Horizons", "Animal Crossing: New Horizons é um jogo eletrônico de simulação de vida desenvolvido e publicado pela Nintendo. Foi lançado em 20 de março de 2020 para Nintendo Switch.", DateTime.Parse("20/03/2020"), 45, Console.NintendoSwitch, Studio.Nintendo, 1);
            game28.Id = 28;
            builder.HasData(game28);
            var game29 = new Game("Marvel's Spider-Man", "Marvel's Spider-Man é um jogo eletrônico de ação-aventura desenvolvido pela Insomniac Games e publicado pela Sony Interactive Entertainment. Foi lançado em 7 de setembro de 2018 para PlayStation 4.", DateTime.Parse("07/09/2018"), 50,  Console.PlayStation4, Studio.InsomniacGames, 1);
            game29.Id = 29;
            builder.HasData(game29);
            var game30 = new Game("Celeste", "Celeste é um jogo eletrônico de plataforma desenvolvido pela Matt Makes Games. Foi lançado em 25 de janeiro de 2018 para Microsoft Windows, macOS, Linux, Nintendo Switch, PlayStation 4, Xbox One e Stadia.", DateTime.Parse("25/01/2018"), 30,  Console.NintendoSwitch, Studio.InfinityWard, 1);
            game30.Id = 30;
            #endregion
        }
    }
}
