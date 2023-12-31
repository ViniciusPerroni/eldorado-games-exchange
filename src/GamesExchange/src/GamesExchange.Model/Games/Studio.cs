﻿using System.ComponentModel.DataAnnotations;

namespace GamesExchange.Model.Games
{
    public enum Studio
    {
        [Display(Name = "Nintendo")]
        Nintendo = 1,
        [Display(Name = "Rockstar Games")]
        RockstarGames = 2,
        [Display(Name = "Electronic Arts")]
        ElectronicArts = 3,
        [Display(Name = "Activision")]
        Activision = 4,
        [Display(Name = "Ubisoft")]
        Ubisoft = 5,
        [Display(Name = "Square Enix")]
        SquareEnix = 6,
        [Display(Name = "Naughty Dog")]
        NaughtyDog = 7,
        [Display(Name = "Valve")]
        Valve = 8,
        [Display(Name = "Blizzard Entertainment")]
        BlizzardEntertainment = 9,
        [Display(Name = "Epic Games")]
        EpicGames = 10,
        [Display(Name = "Bethesda Game Studios")]
        BethesdaGameStudios = 11,
        [Display(Name = "CD Projekt Red")]
        CDProjektRed = 12,
        [Display(Name = "Konami")]
        Konami = 13,
        [Display(Name = "Capcom")]
        Capcom = 14,
        [Display(Name = "BioWare")]
        BioWare = 15,
        [Display(Name = "FromSoftware")]
        FromSoftware = 16,
        [Display(Name = "Bungie")]
        Bungie = 17,
        [Display(Name = "Gearbox Software")]
        GearboxSoftware = 18,
        [Display(Name = "343 Industries")]
        Industries = 19,
        [Display(Name = "Infinity Ward")]
        InfinityWard = 20,
        [Display(Name = "Riot Games")]
        RiotGames = 21,
        [Display(Name = "Sucker Punch Productions")]
        SuckerPunchProductions = 22,
        [Display(Name = "Santa Monica Studio")]
        SantaMonicaStudio = 23,
        [Display(Name = "Ubisoft Montreal")]
        UbisoftMontreal = 24,
        [Display(Name = "Turn 10 Studios")]
        Turn10Studios = 25,
        [Display(Name = "Respawn Entertainment")]
        RespawnEntertainment = 26,
        [Display(Name = "Insomniac Games")]
        InsomniacGames = 27,
        [Display(Name = "Guerrilla Games")]
        GuerrillaGames = 28,
        [Display(Name = "Larian Studios")]
        LarianStudios = 29,
        [Display(Name = "Crystal Dynamics")]
        CrystalDynamics = 30,
        [Display(Name = "Remedy Entertainment")]
        RemedyEntertainment = 31,
        [Display(Name = "SEGA")]
        SEGA = 32,
        [Display(Name = "Kojima Productions")]
        KojimaProductions = 33,
        [Display(Name = "Ubisoft Toronto")]
        UbisoftToronto = 34,
        [Display(Name = "Bethesda Softworks")]
        BethesdaSoftworks = 35,
        [Display(Name = "Ubisoft Quebec")]
        UbisoftQuebec = 36,
        [Display(Name = "BioWare Edmonton")]
        BioWareEdmonton = 37,
        [Display(Name = "Ubisoft Massive")]
        UbisoftMassive = 38,
        [Display(Name = "EA Sports")]
        EASports = 39,
        [Display(Name = "Codemasters")]
        Codemasters = 40,
        [Display(Name = "PlatinumGames")]
        PlatinumGames = 41,
        [Display(Name = "Team Ninja")]
        TeamNinja = 42,
        [Display(Name = "Game Freak")]
        GameFreak = 43,
        [Display(Name = "NetherRealm Studios")]
        NetherRealmStudios = 44,
        [Display(Name = "IO Interactive")]
        IOInteractive = 45,
        [Display(Name = "Hangar 13")]
        Hangar13 = 46,
        [Display(Name = "Square Enix Montreal")]
        SquareEnixMontreal = 47,
        [Display(Name = "Monolith Productions")]
        MonolithProductions = 52,
        [Display(Name = "Raven Software")]
        RavenSoftware = 53,
        [Display(Name = "Sega AM2")]
        SegaAM2 = 54,
        [Display(Name = "SNK")]
        SNK = 55,
        [Display(Name = "Rare")]
        Rare = 56,
        [Display(Name = "Square")]
        Square = 57,
        [Display(Name = "Tecmo")]
        Tecmo = 58,
        [Display(Name = "Team17")]
        Team17 = 59,
        [Display(Name = "Toys for Bob")]
        ToysForBob = 60,
        [Display(Name = "Ubisoft Montpellier")]
        UbisoftMontpellier = 61,
        [Display(Name = "Ubisoft Paris")]
        UbisoftParis = 62,
        [Display(Name = "Ubisoft Reflections")]
        UbisoftReflections = 63,
        [Display(Name = "Ubisoft Sofia")]
        UbisoftSofia = 64,
        [Display(Name = "Ubisoft Vancouver")]
        UbisoftVancouver = 65,
        [Display(Name = "Vicarious Visions")]
        VicariousVisions = 66,
        [Display(Name = "Visual Concepts")]
        VisualConcepts = 67,
        [Display(Name = "Ys Net")]
        YsNet = 68,
        [Display(Name = "Zenimax Online Studios")]
        ZenimaxOnlineStudios = 69,
        [Display(Name = "ZeniMax Texas")]
        ZenimaxTexas = 70,
        [Display(Name = "505 Games")]
        Games505 = 71,
        [Display(Name = "Acclaim Studios")]
        AcclaimStudios = 72,
        [Display(Name = "Arc System Works")]
        ArcSystemWorks = 73,
        [Display(Name = "Artificial Mind and Movement")]
        ArtificialMindMovement = 74,
        [Display(Name = "Bizarre Creations")]
        BizarreCreations = 75,
        [Display(Name = "Bluepoint Games")]
        BluepointGames = 76,
        [Display(Name = "Bugbear Entertainment")]
        BugbearEntertainment = 77,
        [Display(Name = "Camelot Software Planning")]
        CamelotSoftwarePlanning = 78,
        [Display(Name = "Cauldron")]
        Cauldron = 79,
        [Display(Name = "Clover Studio")]
        CloverStudio = 80,
        [Display(Name = "Codemasters Birmingham")]
        CodemastersBirmingham = 81,
        [Display(Name = "Codemasters Studios")]
        CodemastersStudios = 82,
        [Display(Name = "Crytek")]
        Crytek = 83,
        [Display(Name = "D3 Publisher")]
        D3Publisher = 84,
        [Display(Name = "Davilex Games")]
        DavilexGames = 85,
        [Display(Name = "Day 1 Studios")]
        Day1Studios = 86,
        [Display(Name = "Digital Extremes")]
        DigitalExtremes = 87,
        [Display(Name = "Dimps")]
        Dimps = 88,
        [Display(Name = "Double Fine Productions")]
        DoubleFineProductions = 89,
        [Display(Name = "Eden Games")]
        EdenGames = 90,
        [Display(Name = "Eidos Interactive")]
        EidosInteractive = 91,
        [Display(Name = "Eurocom")]
        Eurocom = 92,
        [Display(Name = "Free Radical Design")]
        FreeRadicalDesign = 93,
        [Display(Name = "Frontier Developments")]
        FrontierDevelopments = 94,
        [Display(Name = "Gaijin Entertainment")]
        GaijinEntertainment = 95,
        [Display(Name = "Grasshopper Manufacture")]
        GrasshopperManufacture = 96,
        [Display(Name = "Harmonix Music Systems")]
        HarmonixMusicSystems = 97,
        [Display(Name = "Heavy Iron Studios")]
        HeavyIronStudios = 98,
        [Display(Name = "Hudson Soft")]
        HudsonSoft = 99
    }
}
