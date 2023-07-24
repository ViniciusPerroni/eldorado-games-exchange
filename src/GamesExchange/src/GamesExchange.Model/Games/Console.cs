using System.ComponentModel.DataAnnotations;

namespace GamesExchange.Model.Games
{

    public enum Console
    {
        [Display(Name = "PlayStation 5")]
        PlayStation5 = 1,
        [Display(Name = "Xbox Series X")]
        XboxSeriesX = 2,
        [Display(Name = "Nintendo Switch")]
        NintendoSwitch = 3,
        [Display(Name = "PlayStation 4")]
        PlayStation4 = 4,
        [Display(Name = "Xbox One")]
        XboxOne = 5,
        [Display(Name = "Nintendo Wii U")]
        NintendoWiiU = 6,
        [Display(Name = "PlayStation Vita")]
        PlayStationVita = 7,
        [Display(Name = "Nintendo 3DS")]
        Nintendo3DS = 8,
        [Display(Name = "PlayStation Portable")]
        PlayStationPortable = 9,
        [Display(Name = "Xbox 360")]
        Xbox360 = 10,
        [Display(Name = "Nintendo Wii")]
        NintendoWii = 11,
        [Display(Name = "PlayStation 3")]
        PlayStation3 = 12,
        [Display(Name = "Xbox")]
        Xbox = 13,
        [Display(Name = "PlayStation 2")]
        PlayStation2 = 14,
        [Display(Name = "Nintendo GameCube")]
        NintendoGameCube = 15,
        [Display(Name = "Game Boy Advance")]
        GameBoyAdvance = 16,
        [Display(Name = "PlayStation")]
        PlayStation = 17,
        [Display(Name = "Sega Dreamcast")]
        SegaDreamcast = 18,
        [Display(Name = "Nintendo 64")]
        Nintendo64 = 19,
        [Display(Name = "Game Boy Color")]
        GameBoyColor = 20,
        [Display(Name = "Sega Saturn")]
        SegaSaturn = 21,
        [Display(Name = "PSP")]
        SonyPlayStationPortable = 22,
        [Display(Name = "Super Nintendo")]
        SuperNintendoEntertainmentSystem = 23,
        [Display(Name = "Sega Genesis")]
        SegaGenesis = 24,
        [Display(Name = "Game Boy")]
        GameBoy = 25,
        [Display(Name = "Nintendo")]
        NintendoEntertainmentSystem = 26,
        [Display(Name = "Master System")]
        SegaMasterSystem = 27,
        [Display(Name = "Atari 2600")]
        Atari2600 = 28,
        [Display(Name = "Odyssey")]
        MagnavoxOdyssey = 29
    }
}
