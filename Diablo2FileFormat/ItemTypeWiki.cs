using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo2FileFormat
{

    public static class ItemTypeWiki
    {
        public static Dictionary<string, ItemType> ItemTypeString = new Dictionary<string, ItemType>()
        {
			// Armor
			{ "dr6", ItemType.AlphaHelm },
            { "aar", ItemType.AncientArmor },
            { "dr3", ItemType.Antlers },
            { "utp", ItemType.ArchonPlate },
            { "ulm", ItemType.Armet },
            { "ba4", ItemType.AssaultHelmet },
            { "ba5", ItemType.AvengerGuard },
            { "upl", ItemType.BalrogSkin },
            { "xhl", ItemType.Basinet },
            { "ztb", ItemType.BattleBelt },
            { "xtb", ItemType.BattleBoots },
            { "xtg", ItemType.BattleGauntlets },
            { "mbl", ItemType.Belt },
            { "drb", ItemType.BloodSpirit },
            { "bhm", ItemType.BoneHelm },
            { "uh9", ItemType.BoneVisage },
            { "uhn", ItemType.Boneweave },
            { "umb", ItemType.BoneweaveBoots },
            { "mgl", ItemType.Bracers },
            { "ulg", ItemType.BrambleMitts },
            { "brs", ItemType.BreastPlate },
            { "cap", ItemType.Cap },
            { "bab", ItemType.CarnageHelm },
            { "xlm", ItemType.Casque },
            { "mbt", ItemType.ChainBoots },
            { "chn", ItemType.ChainMail },
            { "xul", ItemType.ChaosArmor },
            { "ci0", ItemType.Circlet },
            { "uhc", ItemType.ColossusGirdle },
            { "bae", ItemType.ConquerorCrown },
            { "urn", ItemType.Corona },
            { "ci1", ItemType.Coronet },
            { "crn", ItemType.Crown },
            { "utg", ItemType.CrusaderGauntlets },
            { "xrs", ItemType.Cuirass },
            { "xsk", ItemType.DeathMask },
            { "usk", ItemType.Demonhead },
            { "xla", ItemType.DemonhideArmor },
            { "xlb", ItemType.DemonhideBoots },
            { "xlg", ItemType.DemonhideGloves },
            { "zlb", ItemType.DemonhideSash },
            { "bad", ItemType.DestroyerHelm },
            { "ci3", ItemType.Diadem },
            { "ung", ItemType.DiamondMail },
            { "drf", ItemType.DreamSpirit },
            { "uui", ItemType.DuskShroud },
            { "drd", ItemType.EarthSpirit },
            { "xth", ItemType.EmbossedPlate },
            { "dr4", ItemType.FalconMask },
            { "ba2", ItemType.FangedHelm },
            { "fld", ItemType.FieldPlate },
            { "fhl", ItemType.FullHelm },
            { "plt", ItemType.PlateMail },
            { "ful", ItemType.FullPlateMail },
            { "bac", ItemType.FuryVisor },
            { "hgl", ItemType.Gauntlets },
            { "xui", ItemType.GhostArmor },
            { "uhl", ItemType.GiantConch },
            { "hbl", ItemType.Girdle },
            { "lgl", ItemType.Gloves },
            { "gth", ItemType.GothicPlate },
            { "xrn", ItemType.GrandCrown },
            { "urs", ItemType.GreatHauberk },
            { "ghm", ItemType.GreatHelm },
            { "dr7", ItemType.GriffonHeadress },
            { "xh9", ItemType.GrimHelm },
            { "baf", ItemType.GuardianCrown },
            { "hla", ItemType.HardLeatherArmor },
            { "dr2", ItemType.HawkHelm },
            { "tbl", ItemType.HeavyBelt },
            { "vbt", ItemType.HeavyBoots },
            { "xmg", ItemType.HeavyBracers },
            { "vgl", ItemType.HeavyGloves },
            { "ult", ItemType.HellforgedPlate },
            { "hlm", ItemType.Helm },
            { "ba3", ItemType.HornedHelm },
            { "dr8", ItemType.HuntersGuise },
            { "ukp", ItemType.Hydraskull },
            { "urg", ItemType.Hyperion },
            { "ba1", ItemType.JawboneCap },
            { "ba6", ItemType.JawboneVisor },
            { "uld", ItemType.KrakenShell },
            { "uth", ItemType.LacqueredPlate },
            { "lea", ItemType.LeatherArmor },
            { "lbt", ItemType.LeatherBoots },
            { "vbl", ItemType.LightBelt },
            { "tgl", ItemType.LightGauntlets },
            { "ltp", ItemType.LightPlate },
            { "tbt", ItemType.LightPlatedBoots },
            { "xng", ItemType.LinkedMail },
            { "ba7", ItemType.LionHelm },
            { "ucl", ItemType.LoricatedMail },
            { "xtp", ItemType.MagePlate },
            { "msk", ItemType.Mask },
            { "xhn", ItemType.MeshArmor },
            { "zmb", ItemType.MeshBelt },
            { "xmb", ItemType.MeshBoots },
            { "utb", ItemType.MirroredBoots },
            { "umc", ItemType.MithrilCoil },
            { "uhb", ItemType.MyrmidonGreaves },
            { "uhg", ItemType.OgreGauntlets },
            { "xar", ItemType.OrnatePlate },
            { "hbt", ItemType.PlateBoots },
            { "qui", ItemType.QuiltedArmor },
            { "ba8", ItemType.RageMask },
            { "rng", ItemType.RingMail },
            { "xpl", ItemType.RussetArmor },
            { "uar", ItemType.SacredArmor },
            { "dr9", ItemType.SacredFeathers },
            { "xkp", ItemType.Sallet },
            { "lbl", ItemType.Sash },
            { "ba9", ItemType.SavageHelmet },
            { "scl", ItemType.ScaleMail },
            { "ula", ItemType.ScarabHusk },
            { "uvb", ItemType.ScarabshellBoots },
            { "xea", ItemType.SerpentskinArmor },
            { "uul", ItemType.ShadowPlate },
            { "uap", ItemType.Shako },
            { "zvb", ItemType.SharkskinBelt },
            { "xvb", ItemType.SharkskinBoots },
            { "xvg", ItemType.SharkskinGloves },
            { "xld", ItemType.SharktoothArmor },
            { "skp", ItemType.SkullCap },
            { "dre", ItemType.SkySpirit },
            { "baa", ItemType.SlayerGuard },
            { "ulc", ItemType.SpiderwebSash },
            { "uhm", ItemType.SpiredHelm },
            { "dr5", ItemType.SpiritMask },
            { "spl", ItemType.SplintMail },
            { "stu", ItemType.StuddedLeather },
            { "drc", ItemType.SunSpirit },
            { "xlt", ItemType.TemplarCoat },
            { "ci2", ItemType.Tiara },
            { "xcl", ItemType.TigulatedMail },
            { "dra", ItemType.TotemicMask },
            { "xtu", ItemType.TrellisedArmor },
            { "utc", ItemType.TrollBelt },
            { "umg", ItemType.Vambraces },
            { "uvg", ItemType.VampireboneGloves },
            { "uvc", ItemType.VampirefangBelt },
            { "zhb", ItemType.WarBelt },
            { "xhb", ItemType.WarBoots },
            { "xhg", ItemType.WarGauntlets },
            { "xap", ItemType.WarHat },
            { "xhm", ItemType.WingedHelm },
            { "utu", ItemType.WireFleece },
            { "dr1", ItemType.WolfHead },
            { "uea", ItemType.Wyrmhide },
            { "ulb", ItemType.WyrmhideBoots },

			// Misc
			{ "gsv", ItemType.Amethyst },
            { "r11", ItemType.AmnRune },
            { "amu", ItemType.Amulet },
            { "yps", ItemType.AntidotePotion },
            { "aqv", ItemType.Arrows },
            { "bey", ItemType.BaalsEye },
            { "bks", ItemType.BarkScroll },
            { "r30", ItemType.BerRune },
            { "cqv", ItemType.Bolts },
            { "ass", ItemType.BookofSkill },
            { "bet", ItemType.BurningEssenceofTerror },
            { "r32", ItemType.ChamRune },
            { "ceh", ItemType.ChargedEssenceofHatred },
            { "cm3", ItemType.GrandCharm },
            { "cm2", ItemType.LargeCharm },
            { "cm1", ItemType.SmallCharm },
            { "gcv", ItemType.ChippedAmethyst },
            { "gcw", ItemType.ChippedDiamond },
            { "gcg", ItemType.ChippedEmerald },
            { "gcr", ItemType.ChippedRuby },
            { "gcb", ItemType.ChippedSapphire },
            { "skc", ItemType.ChippedSkull },
            { "gcy", ItemType.ChippedTopaz },
            { "bkd", ItemType.DecipheredBarkScroll },
            { "dhn", ItemType.DiablosHorn },
            { "gsw", ItemType.Diamond },
            { "r14", ItemType.DolRune },
            { "r01", ItemType.ElRune },
            { "r02", ItemType.EldRune },
            { "elx", ItemType.Elixir },
            { "gsg", ItemType.Emerald },
            { "r05", ItemType.EthRune },
            { "r19", ItemType.FalRune },
            { "fed", ItemType.FesteringEssenceofDestruction },
            { "gfv", ItemType.FlawedAmethyst },
            { "gfw", ItemType.FlawedDiamond },
            { "gfg", ItemType.FlawedEmerald },
            { "gfr", ItemType.FlawedRuby },
            { "gfb", ItemType.FlawedSapphire },
            { "skf", ItemType.FlawedSkull },
            { "gfy", ItemType.FlawedTopaz },
            { "gzv", ItemType.FlawlessAmethyst },
            { "glw", ItemType.FlawlessDiamond },
            { "glg", ItemType.FlawlessEmerald },
            { "glr", ItemType.FlawlessRuby },
            { "glb", ItemType.FlawlessSapphire },
            { "skl", ItemType.FlawlessSkull },
            { "gly", ItemType.FlawlessTopaz },
            { "hpf", ItemType.FullHealingPotion },
            { "mpf", ItemType.FullManaPotion },
            { "rvl", ItemType.FullRejuvenationPotion },
            { "gld", ItemType.Gold },
            { "g34", ItemType.GoldBird },
            { "hp5", ItemType.GreaterHealingPotion },
            { "mp5", ItemType.GreaterManaPotion },
            { "r25", ItemType.GulRune },
            { "hp3", ItemType.HealingPotion },
            { "hpo", ItemType.HealingPotionMid },
            { "r15", ItemType.HelRune },
            { "hrb", ItemType.Herb },
            { "box", ItemType.HoradricCube },
            { "ibk", ItemType.IdentifyBook },
            { "isc", ItemType.IdentifyScroll },
            { "r16", ItemType.IoRune },
            { "r24", ItemType.IstRune },
            { "r06", ItemType.IthRune },
            { "j34", ItemType.JadeFigurine },
            { "r31", ItemType.JahRune },
            { "jew", ItemType.Jewel },
            { "pk3", ItemType.KeyofDestruction },
            { "pk2", ItemType.KeyofHate },
            { "pk1", ItemType.KeyofTerror },
            { "qbr", ItemType.KhalimsBrain },
            { "qey", ItemType.KhalimsEye },
            { "qhr", ItemType.KhalimsHeart },
            { "r18", ItemType.KoRune },
            { "bbb", ItemType.LamEsensTome },
            { "bpl", ItemType.LargeBluePotion },
            { "rpl", ItemType.LargeRedPotion },
            { "r20", ItemType.LemRune },
            { "hp1", ItemType.LesserHealingPotion },
            { "mp1", ItemType.LesserManaPotion },
            { "hp2", ItemType.LightHealingPotion },
            { "mp2", ItemType.LightManaPotion },
            { "r28", ItemType.LoRune },
            { "r17", ItemType.LumRune },
            { "ice", ItemType.Maguffin },
            { "r23", ItemType.MalRune },
            { "mp3", ItemType.ManaPotion },
            { "mpo", ItemType.ManaPotionMid },
            { "mbr", ItemType.MephistosBrain },
            { "luv", ItemType.MephistoKey },
            { "mss", ItemType.MephistoSoulStone },
            { "r04", ItemType.NefRune },
            { "r27", ItemType.OhmRune },
            { "r09", ItemType.OrtRune },
            { "gpv", ItemType.PerfectAmethyst },
            { "gpw", ItemType.PerfectDiamond },
            { "gpg", ItemType.PerfectEmerald },
            { "gpr", ItemType.PerfectRuby },
            { "gpb", ItemType.PerfectSapphire },
            { "skz", ItemType.PerfectSkull },
            { "gpy", ItemType.PerfectTopaz },
            { "ear", ItemType.PlayerEar },
            { "r21", ItemType.PulRune },
            { "r08", ItemType.RalRune },
            { "rvs", ItemType.RejuvenationPotion },
            { "rin", ItemType.Ring },
            { "gsr", ItemType.Ruby },
            { "gsb", ItemType.Sapphire },
            { "0sc", ItemType.Scroll },
            { "tr1", ItemType.ScrollofHoradric },
            { "tr2", ItemType.ScrollofMalah },
            { "xyz", ItemType.PotionofLife },
            { "r13", ItemType.ShaelRune },
            { "key", ItemType.SkeletonKey },
            { "sku", ItemType.Skull },
            { "bps", ItemType.SmallBluePotion },
            { "rps", ItemType.SmallRedPotion },
            { "r12", ItemType.SolRune },
            { "vps", ItemType.StaminaPotion },
            { "std", ItemType.StandardofHeroes },
            { "hp4", ItemType.StrongHealingPotion },
            { "mp4", ItemType.StrongManaPotion },
            { "r29", ItemType.SurRune },
            { "r07", ItemType.TalRune },
            { "wms", ItemType.ThawingPotion },
            { "r10", ItemType.ThulRune },
            { "r03", ItemType.TirRune },
            { "toa", ItemType.TokenofAbsolution },
            { "gsy", ItemType.Topaz },
            { "tch", ItemType.Torch },
            { "tbk", ItemType.TownPortalBook },
            { "tsc", ItemType.TownPortalScroll },
            { "tes", ItemType.TwistedEssenceofSuffering },
            { "r22", ItemType.UmRune },
            { "r26", ItemType.VexRune },
            { "vip", ItemType.ViperAmulet },
            { "r33", ItemType.ZodRune },

			// Shields
			{ "uow", ItemType.Aegis },
            { "pa4", ItemType.AerinShield },
            { "pa7", ItemType.AkaranRondache },
            { "pa6", ItemType.AkaranTarge },
            { "pad", ItemType.KurastShield },
            { "xts", ItemType.AncientShield },
            { "xpk", ItemType.BarbedShield },
            { "upk", ItemType.BladeBarrier },
            { "nef", ItemType.BloodlordSkull },
            { "bsh", ItemType.BoneShield },
            { "buc", ItemType.Buckler },
            { "ne9", ItemType.CantorTrophy },
            { "pa5", ItemType.CrownShield },
            { "xuc", ItemType.Defender },
            { "ne5", ItemType.DemonHead },
            { "xit", ItemType.DragonShield },
            { "ne7", ItemType.FetishTrophy },
            { "ne4", ItemType.GargoyleHead },
            { "gts", ItemType.GothicShield },
            { "xsh", ItemType.GrimShield },
            { "pa9", ItemType.GildedShield },
            { "nea", ItemType.HeirophantTrophy },
            { "uuc", ItemType.Heater },
            { "neg", ItemType.HellspawnSkull },
            { "pa3", ItemType.HeraldicShield },
            { "kit", ItemType.KiteShield },
            { "lrg", ItemType.LargeShield },
            { "uml", ItemType.Luna },
            { "neb", ItemType.MinionSkull },
            { "uit", ItemType.Monarch },
            { "ne6", ItemType.MummifiedTrophy },
            { "ned", ItemType.OverseerSkull },
            { "xow", ItemType.Pavise },
            { "ne1", ItemType.PreservedHead },
            { "pa8", ItemType.ProtectorShield },
            { "pa2", ItemType.Rondache },
            { "xml", ItemType.RoundShield },
            { "paa", ItemType.RoyalShield },
            { "pac", ItemType.SacredRondache },
            { "pab", ItemType.SacredTarge },
            { "xrg", ItemType.Scutum },
            { "ne8", ItemType.SextonTrophy },
            { "sml", ItemType.SmallShield },
            { "spk", ItemType.SpikedShield },
            { "nee", ItemType.SuccubusSkull },
            { "pa1", ItemType.Targe },
            { "tow", ItemType.TowerShield },
            { "ush", ItemType.TrollNest },
            { "ne3", ItemType.UnravellerHead },
            { "paf", ItemType.VortexShield },
            { "uts", ItemType.Ward },
            { "pae", ItemType.ZakarumShield },
            { "ne2", ItemType.ZombieHead },

			// Weapons
			{ "9gi", ItemType.AncientAxe },
            { "9wd", ItemType.AncientSword },
            { "8lx", ItemType.Arbalest },
            { "6ws", ItemType.ArchonStaff },
            { "am6", ItemType.AshwoodBow },
            { "7sm", ItemType.Ataghan },
            { "axe", ItemType.Axe },
            { "bal", ItemType.BalancedAxe },
            { "bkf", ItemType.BalancedKnife },
            { "8hx", ItemType.Balista },
            { "7gs", ItemType.BalrogBlade },
            { "7s7", ItemType.BalrogSpear },
            { "9sp", ItemType.BarbedClub },
            { "bar", ItemType.Bardiche },
            { "bsw", ItemType.BastardSword },
            { "btx", ItemType.BattleAxe },
            { "7cs", ItemType.BattleCestus },
            { "9tk", ItemType.BattleDart },
            { "9wh", ItemType.BattleHammer },
            { "9s8", ItemType.BattleScythe },
            { "bst", ItemType.BattleStaff },
            { "9bs", ItemType.BattleSword },
            { "9ba", ItemType.BeardedAxe },
            { "9h9", ItemType.BecDeCorbin },
            { "7wa", ItemType.BerserkerAxe },
            { "9vo", ItemType.Bill },
            { "bld", ItemType.Blade },
            { "6hb", ItemType.BladeBow },
            { "btl", ItemType.BladeTalons },
            { "7dg", ItemType.BoneKnife },
            { "bwn", ItemType.BoneWand },
            { "brn", ItemType.Brandistock },
            { "bax", ItemType.BroadAxe },
            { "bsd", ItemType.BroadSword },
            { "9wn", ItemType.BurntWand },
            { "7ws", ItemType.Caduceus },
            { "8lb", ItemType.CedarBow },
            { "8cs", ItemType.CedarStaff },
            { "am7", ItemType.CeremonialBow },
            { "ama", ItemType.CeremonialJavelin },
            { "am9", ItemType.CeremonialPike },
            { "am8", ItemType.CeremonialSpear },
            { "ces", ItemType.Cestus },
            { "7ga", ItemType.ChampionAxe },
            { "7b7", ItemType.ChampionSword },
            { "gpm", ItemType.ChokingGasPotion },
            { "8rx", ItemType.ChuKoNu },
            { "9kr", ItemType.Cinquedeas },
            { "ob4", ItemType.ClaspedOrb },
            { "clw", ItemType.Claws },
            { "clm", ItemType.Claymore },
            { "9ax", ItemType.Cleaver },
            { "ob8", ItemType.CloudySphere },
            { "clb", ItemType.Club },
            { "7fb", ItemType.ColossalSword },
            { "7gd", ItemType.ColossalBlade },
            { "6hx", ItemType.ColossusCrossbow },
            { "7vo", ItemType.ColossusVoulge },
            { "cbw", ItemType.CompositeBow },
            { "7bs", ItemType.ConquestSword },
            { "mxb", ItemType.Crossbow },
            { "9mp", ItemType.Crowbill },
            { "6l7", ItemType.CrusaderBow },
            { "7pa", ItemType.CrypticAxe },
            { "7ls", ItemType.CrypticSword },
            { "crs", ItemType.CrystalSword },
            { "ob7", ItemType.CrystallineGlobe },
            { "9cl", ItemType.Cudgel },
            { "9sm", ItemType.Cutlass },
            { "9cm", ItemType.DacianFalx },
            { "dgr", ItemType.Dagger },
            { "7bt", ItemType.Decapitator },
            { "d33", ItemType.DecoyDagger },
            { "6rx", ItemType.DemonCrossbow },
            { "obd", ItemType.DemonHeart },
            { "7mt", ItemType.DevilStar },
            { "6s7", ItemType.DiamondBow },
            { "9cr", ItemType.DimensionalBlade },
            { "obf", ItemType.DimensionalShard },
            { "dir", ItemType.Dirk },
            { "9ws", ItemType.DivineScepter },
            { "2ax", ItemType.DoubleAxe },
            { "8cb", ItemType.DoubleBow },
            { "ob5", ItemType.DragonStone },
            { "ob1", ItemType.DragonStone },
            { "8sb", ItemType.EdgeBow },
            { "6cs", ItemType.ElderStaff },
            { "obc", ItemType.EldritchOrb },
            { "7sb", ItemType.ElegantBlade },
            { "92h", ItemType.Espadon },
            { "72a", ItemType.EttinAxe },
            { "9gd", ItemType.ExecutionerSword },
            { "opm", ItemType.ExplodingPotion },
            { "7ss", ItemType.Falcata },
            { "flc", ItemType.Falchion },
            { "7kr", ItemType.FangedKnife },
            { "9xf", ItemType.Fascia },
            { "7la", ItemType.FeralAxe },
            { "7lw", ItemType.FeralClaws },
            { "fla", ItemType.Flail },
            { "flb", ItemType.Flamberge },
            { "9ma", ItemType.FlangedMace },
            { "7ta", ItemType.FlyingAxe },
            { "7tk", ItemType.FlyingKnife },
            { "9ta", ItemType.Francisca },
            { "opl", ItemType.FulmatingPotion },
            { "9tr", ItemType.Fuscina },
            { "7gl", ItemType.GhostGlaive },
            { "7st", ItemType.GhostSpear },
            { "7yw", ItemType.GhostWand },
            { "gix", ItemType.GiantAxe },
            { "gis", ItemType.GiantSword },
            { "7wc", ItemType.GiantThresher },
            { "g33", ItemType.Gidbinn },
            { "9ss", ItemType.Gladius },
            { "glv", ItemType.Glaive },
            { "7gi", ItemType.GloriousAxe },
            { "ob6", ItemType.GlowingOrb },
            { "cst", ItemType.GnarledStaff },
            { "6mx", ItemType.GorgonCrossbow },
            { "9ga", ItemType.GothicAxe },
            { "8lw", ItemType.GothicBow },
            { "8bs", ItemType.GothicStaff },
            { "9b9", ItemType.GothicSword },
            { "amc", ItemType.GrandMatronBow },
            { "gsc", ItemType.GrandScepter },
            { "9gw", ItemType.GraveWand },
            { "gax", ItemType.GreatAxe },
            { "6cb", ItemType.GreatBow },
            { "gma", ItemType.GreatMaul },
            { "9pi", ItemType.GreatPilum },
            { "7h7", ItemType.GreatPoleaxe },
            { "gsd", ItemType.GreatSword },
            { "9lw", ItemType.GreaterClaws },
            { "9tw", ItemType.GreaterTalons },
            { "9wc", ItemType.GrimScythe },
            { "gwn", ItemType.GrimWand },
            { "hal", ItemType.Halberd },
            { "hax", ItemType.HandAxe },
            { "9cs", ItemType.HandScythe },
            { "9ts", ItemType.Harpoon },
            { "9ha", ItemType.Hatchet },
            { "axf", ItemType.HatchetHands },
            { "obb", ItemType.HeavenlyStone },
            { "hxb", ItemType.HeavyCrossbow },
            { "hfh", ItemType.HellforgeHammer },
            { "7cm", ItemType.HighlandBlade },
            { "9qs", ItemType.HolyWaterSprinkler },
            { "hdm", ItemType.HoradricMalus },
            { "hst", ItemType.HoradricStaff },
            { "hbw", ItemType.HuntersBow },
            { "9b8", ItemType.Hurlbat },
            { "6lw", ItemType.HydraBow },
            { "7fc", ItemType.HydraEdge },
            { "7ja", ItemType.HyperionJavelin },
            { "7sr", ItemType.HyperionSpear },
            { "9mt", ItemType.JaggedStar },
            { "jav", ItemType.Javelin },
            { "8ss", ItemType.JoStaff },
            { "ktr", ItemType.Katar },
            { "qf1", ItemType.KhalimFlail },
            { "9fl", ItemType.Knout },
            { "kri", ItemType.Kriss },
            { "9p9", ItemType.Lance },
            { "lax", ItemType.LargeAxe },
            { "7bl", ItemType.LegendSpike },
            { "72h", ItemType.LegendSword },
            { "7wh", ItemType.LegendaryMallet },
            { "7bw", ItemType.LichWand },
            { "lxb", ItemType.LightCrossbow },
            { "9b7", ItemType.LochaberAxe },
            { "lbb", ItemType.LongBattleBow },
            { "lbw", ItemType.LongBow },
            { "8l8", ItemType.LongSiegeBow },
            { "lst", ItemType.LongStaff },
            { "lsd", ItemType.LongSword },
            { "lwb", ItemType.LongWarBow },
            { "mac", ItemType.Mace },
            { "am5", ItemType.MaidenJavelin },
            { "am4", ItemType.MaidenPike },
            { "am3", ItemType.MaidenSpear },
            { "7br", ItemType.Mancatcher },
            { "9gm", ItemType.MarteldeFer },
            { "amb", ItemType.MatriarchalBow },
            { "ame", ItemType.MatriarchalPike },
            { "amd", ItemType.MatriarchalSpear },
            { "amf", ItemType.MatriarchalJavelin },
            { "mau", ItemType.Maul },
            { "7sc", ItemType.MightyScepter },
            { "9la", ItemType.MilitaryAxe },
            { "mpi", ItemType.MilitaryPick },
            { "7di", ItemType.MithralPoint },
            { "mst", ItemType.MorningStar },
            { "7wd", ItemType.MythicalSword },
            { "9wa", ItemType.Naga },
            { "7o7", ItemType.OgreAxe },
            { "7m7", ItemType.OgreMaul },
            { "ops", ItemType.OilPotion },
            { "9pa", ItemType.Partizan },
            { "6lx", ItemType.PelletBow },
            { "9yw", ItemType.PetrifiedWand },
            { "7cr", ItemType.PhaseBlade },
            { "pik", ItemType.Pike },
            { "pil", ItemType.Pilum },
            { "9dg", ItemType.Poignard },
            { "pax", ItemType.Poleaxe },
            { "7wn", ItemType.PolishedWand },
            { "8ls", ItemType.QuarterStaff },
            { "9ar", ItemType.Quhab },
            { "gps", ItemType.RancidGasPotion },
            { "8hb", ItemType.RazorBow },
            { "am2", ItemType.ReflexBow },
            { "7ma", ItemType.ReinforcedMace },
            { "rxb", ItemType.RepeatingCrossbow },
            { "9di", ItemType.Rondel },
            { "8sw", ItemType.RuneBow },
            { "9sc", ItemType.RuneScepter },
            { "8ws", ItemType.RuneStaff },
            { "9ls", ItemType.RuneSword },
            { "7tw", ItemType.RunicTalons },
            { "sbr", ItemType.Sabre },
            { "ob2", ItemType.SacredGlobe },
            { "scp", ItemType.Scepter },
            { "scm", ItemType.Scimitar },
            { "skr", ItemType.ScissorsKatar },
            { "9qr", ItemType.ScissorsQuhab },
            { "7qr", ItemType.ScissorsSuwayyah },
            { "7fl", ItemType.Scourge },
            { "scy", ItemType.Scythe },
            { "7qs", ItemType.SeraphRod },
            { "6lb", ItemType.ShadowBow },
            { "9sb", ItemType.Shamshir },
            { "6bs", ItemType.Shillelah },
            { "sbb", ItemType.ShortBattleBow },
            { "sbw", ItemType.ShortBow },
            { "8s8", ItemType.ShortSiegeBow },
            { "ssp", ItemType.ShortSpear },
            { "sst", ItemType.ShortStaff },
            { "ssd", ItemType.ShortSword },
            { "swb", ItemType.ShortWarBow },
            { "8mx", ItemType.SiegeCrossbow },
            { "7ba", ItemType.SilverEdgedAxe },
            { "9s9", ItemType.Simbilan },
            { "7ax", ItemType.SmallCrescent },
            { "ob3", ItemType.SmokedSphere },
            { "ob9", ItemType.SparklingBall },
            { "spr", ItemType.Spear },
            { "spt", ItemType.Spetum },
            { "9gl", ItemType.Spiculum },
            { "6sb", ItemType.SpiderBow },
            { "spc", ItemType.SpikedClub },
            { "msf", ItemType.StaffOfTheKings },
            { "am1", ItemType.StagBow },
            { "6ls", ItemType.Stalagmite },
            { "9bl", ItemType.Stilleto },
            { "gpl", ItemType.StranglingGasPotion },
            { "7tr", ItemType.StygianPike },
            { "7pi", ItemType.StygianPilum },
            { "qf2", ItemType.SuperKhalimFlail },
            { "7ar", ItemType.Suwayyah },
            { "oba", ItemType.SwirlingCrystal },
            { "9bt", ItemType.Tabar },
            { "7s8", ItemType.Thresher },
            { "tax", ItemType.ThrowingAxe },
            { "tkf", ItemType.ThrowingKnife },
            { "tsp", ItemType.ThrowingSpear },
            { "7gm", ItemType.ThunderMaul },
            { "7ha", ItemType.Tomahawk },
            { "9bw", ItemType.TombWand },
            { "tri", ItemType.Trident },
            { "7cl", ItemType.Truncheon },
            { "9fc", ItemType.Tulwar },
            { "9gs", ItemType.TuskSword },
            { "92a", ItemType.TwinAxe },
            { "2hs", ItemType.TwoHandedSword },
            { "7sp", ItemType.TyrantClub },
            { "7gw", ItemType.UnearthedWand },
            { "obe", ItemType.VortexOrb },
            { "vou", ItemType.Voulge },
            { "6ss", ItemType.WalkingStick },
            { "wnd", ItemType.Wand },
            { "wax", ItemType.WarAxe },
            { "9m9", ItemType.WarClub },
            { "9bk", ItemType.WarDart },
            { "7xf", ItemType.WarFist },
            { "9br", ItemType.WarFork },
            { "whm", ItemType.WarHammer },
            { "9ja", ItemType.WarJavelin },
            { "7p7", ItemType.WarPike },
            { "wsp", ItemType.WarScepter },
            { "wsc", ItemType.WarScythe },
            { "9sr", ItemType.WarSpear },
            { "7mp", ItemType.WarSpike },
            { "wst", ItemType.WarStaff },
            { "wsd", ItemType.WarSword },
            { "6sw", ItemType.WardBow },
            { "7b8", ItemType.WingedAxe },
            { "7ts", ItemType.WingedHarpoon },
            { "7bk", ItemType.WingedKnife },
            { "leg", ItemType.WirtsLeg },
            { "wrb", ItemType.WristBlade },
            { "9wb", ItemType.WristSpike },
            { "7wb", ItemType.WristSword },
            { "9st", ItemType.Yari },
            { "ywn", ItemType.YewWand },
            { "9fb", ItemType.Zweihander },
        };

        // Shield item codes mapped to their in game, human-friendly, readable name.
        public static Dictionary<ItemType, string> ShieldName = new Dictionary<ItemType, string>()
        {
            { ItemType.Aegis,            "Aegis" },
            { ItemType.AerinShield,      "Aerin Shield" },
            { ItemType.AkaranRondache,   "Akaran Rondache" },
            { ItemType.AkaranTarge,      "Akaran Targe" },
            { ItemType.KurastShield,     "Kurast Shield" },
            { ItemType.AncientShield,    "Ancient Shield" },
            { ItemType.BarbedShield,     "Barbed Shield" },
            { ItemType.BladeBarrier,     "Blade Barrier" },
            { ItemType.BloodlordSkull,   "Bloodlord Skull" },
            { ItemType.BoneShield,       "Bone Shield" },
            { ItemType.Buckler,          "Buckler" },
            { ItemType.CantorTrophy,     "Cantor Trophy" },
            { ItemType.CrownShield,      "Crown Shield" },
            { ItemType.Defender,         "Defender" },
            { ItemType.DemonHead,        "Demon Head" },
            { ItemType.DragonShield,     "Dragon Shield" },
            { ItemType.FetishTrophy,     "Fetish Trophy" },
            { ItemType.GargoyleHead,     "Gargoyle Head" },
            { ItemType.GothicShield,     "Gothic Shield" },
            { ItemType.GrimShield,       "Grim Shield" },
            { ItemType.GildedShield,     "Gilded Shield" },
            { ItemType.HeirophantTrophy, "Heirophant Trophy" },
            { ItemType.Heater,           "Heater" },
            { ItemType.HellspawnSkull,   "Hellspawn Skull" },
            { ItemType.HeraldicShield,   "Heraldic Shield" },
            { ItemType.KiteShield,       "Kite Shield" },
            { ItemType.LargeShield,      "Large Shield" },
            { ItemType.Luna,             "Luna" },
            { ItemType.MinionSkull,      "Minion Skull" },
            { ItemType.Monarch,          "Monarch" },
            { ItemType.MummifiedTrophy,  "Mummified Trophy" },
            { ItemType.OverseerSkull,    "Overseer Skull" },
            { ItemType.Pavise,           "Pavise" },
            { ItemType.PreservedHead,    "Preserved Head" },
            { ItemType.ProtectorShield,  "Protector Shield" },
            { ItemType.Rondache,         "Rondache" },
            { ItemType.RoundShield,      "Round Shield" },
            { ItemType.RoyalShield,      "Royal Shield" },
            { ItemType.SacredRondache,   "Sacred Rondache" },
            { ItemType.SacredTarge,      "Sacred Targe" },
            { ItemType.Scutum,           "Scutum" },
            { ItemType.SextonTrophy,     "Sexton Trophy" },
            { ItemType.SmallShield,      "Small Shield" },
            { ItemType.SpikedShield,     "Spiked Shield" },
            { ItemType.SuccubusSkull,    "Succubus Skull" },
            { ItemType.Targe,            "Targe" },
            { ItemType.TowerShield,      "Tower Shield" },
            { ItemType.TrollNest,        "Troll Nest" },
            { ItemType.UnravellerHead,   "Unraveller Head" },
            { ItemType.VortexShield,     "Vortex Shield" },
            { ItemType.Ward,             "Ward" },
            { ItemType.ZakarumShield,    "Zakarum Shield" },
            { ItemType.ZombieHead,       "Zombie Head" },
        };

        // Armor item codes mapped to their in game, human-friendly, readable name.
        public static Dictionary<ItemType, string> ArmorName = new Dictionary<ItemType, string>()
        {
            { ItemType. AlphaHelm,         "Alpha Helm" } ,
            { ItemType. AncientArmor,      "Ancient Armor" },
            { ItemType.    Antlers,           "Antlers" },
             { ItemType.            ArchonPlate,       "Archon Plate" }, 
            { ItemType.            Armet,             "Armet" },             
            { ItemType.            AssaultHelmet,     "Assault Helmet" },
            { ItemType.            AvengerGuard,      "Avenger Guard" }, 
            { ItemType.            BalrogSkin,        "Balrog Skin" }, 
            { ItemType.            Basinet,           "Basinet" }, 
            { ItemType.            BattleBelt,        "Battle Belt" }, 
            { ItemType.            BattleBoots,       "Battle Boots" }, 
            { ItemType.            BattleGauntlets,   "Battle Gauntlets" }, 
            { ItemType.            Belt,              "Belt" }, 
            { ItemType.            BloodSpirit,       "Blood Spirit" }, 
            { ItemType.            BoneHelm,          "Bone Helm" }, 
            { ItemType.            BoneVisage,        "Bone Visage" }, 
            { ItemType.            Boneweave,         "Boneweave" }, 
            { ItemType.            BoneweaveBoots,    "Boneweave Boots" }, 
            { ItemType.            Bracers,           "Bracers" }, 
            { ItemType.            BrambleMitts,      "Bramble Mitts" }, 
            { ItemType.            BreastPlate,       "Breast Plate" }, 
            { ItemType.            Cap,               "Cap" }, 
            { ItemType.            CarnageHelm,       "Carnage Helm" }, 
            { ItemType.            Casque,            "Casque" }, { ItemType.
            ChainBoots,        "Chain Boots" }, { ItemType.
            ChainMail,         "Chain Mail" }, { ItemType.
            ChaosArmor,        "Chaos Armor" }, { ItemType.
            Circlet,           "Circlet" }, { ItemType.
            ColossusGirdle,    "Colossus Girdle" }, { ItemType.
            ConquerorCrown,    "Conqueror Crown" }, { ItemType.
            Corona,            "Corona" }, { ItemType.
            Coronet,           "Coronet" }, { ItemType.
            Crown,             "Crown" }, { ItemType.
            CrusaderGauntlets, "Crusader Gauntlets" }, { ItemType.
            Cuirass,           "Cuirass" }, { ItemType.
            DeathMask,         "Death Mask" }, { ItemType.
            Demonhead,         "Demonhead" }, { ItemType.
            DemonhideArmor,    "Demonhide Armor" }, { ItemType.
            DemonhideBoots,    "Demonhide Boots" }, { ItemType.
            DemonhideGloves,   "Demonhide Gloves" }, { ItemType.
            DemonhideSash,     "Demonhide Sash" }, { ItemType.
            DestroyerHelm,     "Destroyer Helm" }, { ItemType.
            Diadem,            "Diadem" }, { ItemType.
            DiamondMail,       "Diamond Mail" }, { ItemType.
            DreamSpirit,       "Dream Spirit" }, { ItemType.
            DuskShroud,        "Dusk Shroud" }, { ItemType.
            EarthSpirit,       "Earth Spirit" }, { ItemType.
            EmbossedPlate,     "Embossed Plate" }, { ItemType.
            FalconMask,        "Falcon Mask" }, { ItemType.
            FangedHelm,        "Fanged Helm" }, { ItemType.
            FieldPlate,        "Field Plate" }, { ItemType.
            FullHelm,          "Full Helm" }, { ItemType.
            PlateMail,         "Plate Mail" }, { ItemType.
            FullPlateMail,     "Full Plate Mail" }, { ItemType.
            FuryVisor,         "Fury Visor" }, { ItemType.
            Gauntlets,         "Gauntlets" }, { ItemType.
            GhostArmor,        "Ghost Armor" }, { ItemType.
            GiantConch,        "Giant Conch" }, { ItemType.
            Girdle,            "Girdle" }, { ItemType.
            Gloves,            "Gloves" }, { ItemType.
            GothicPlate,       "Gothic Plate" }, { ItemType.
            GrandCrown,        "Grand Crown" }, { ItemType.
            GreatHauberk,      "Great Hauberk" }, { ItemType.
            GreatHelm,         "Great Helm" }, { ItemType.
            GriffonHeadress,   "Griffon Headress" }, { ItemType.
            GrimHelm,          "Grim Helm" }, { ItemType.
            GuardianCrown,     "Guardian Crown" }, { ItemType.
            HardLeatherArmor,  "Hard Leather Armor" }, { ItemType.
            HawkHelm,          "Hawk Helm" }, { ItemType.
            HeavyBelt,         "Heavy Belt" }, { ItemType.
            HeavyBoots,        "Heavy Boots" }, { ItemType.
            HeavyBracers,      "Heavy Bracers" }, { ItemType.
            HeavyGloves,       "Heavy Gloves" }, { ItemType.
            HellforgedPlate,   "Hellforged Plate" }, { ItemType.
            Helm,              "Helm" }, { ItemType.
            HornedHelm,        "Horned Helm" }, { ItemType.
            HuntersGuise,      "Hunter's Guise" }, { ItemType.
            Hydraskull,        "Hydraskull" }, { ItemType.
            Hyperion,          "Hyperion" }, { ItemType.
            JawboneCap,        "Jawbone Cap" }, { ItemType.
            JawboneVisor,      "Jawbone Visor" }, { ItemType.
            KrakenShell,       "Kraken Shell" }, { ItemType.
            LacqueredPlate,    "Lacquered Plate" }, { ItemType.
            LeatherArmor,      "Leather Armor" }, { ItemType.
            LeatherBoots,      "Leather Boots" }, { ItemType.
            LightBelt,         "Light Belt" }, { ItemType.
            LightGauntlets,    "Light Gauntlets" }, { ItemType.
            LightPlate,        "Light Plate" }, { ItemType.
            LightPlatedBoots,  "Light Plated Boots" }, { ItemType.
            LinkedMail,        "Linked Mail" }, { ItemType.
            LionHelm,          "Lion Helm" }, { ItemType.
            LoricatedMail,     "Loricated Mail" }, { ItemType.
            MagePlate,         "Mage Plate" }, { ItemType.
            Mask,              "Mask" }, { ItemType.
            MeshArmor,         "Mesh Armor" }, { ItemType.
            MeshBelt,          "Mesh Belt" }, { ItemType.
            MeshBoots,         "Mesh Boots" }, { ItemType.
            MirroredBoots,     "Mirrored Boots" }, { ItemType.
            MithrilCoil,       "Mithril Coil" }, { ItemType.
            MyrmidonGreaves,   "Myrmidon Greaves" }, { ItemType.
            OgreGauntlets,     "Ogre Gauntlets" }, { ItemType.
            OrnatePlate,       "Ornate Plate" }, { ItemType.
            PlateBoots,        "Plate Boots" }, { ItemType.
            QuiltedArmor,      "Quilted Armor" }, { ItemType.
            RageMask,          "Rage Mask" }, { ItemType.
            RingMail,          "Ring Mail" }, { ItemType.
            RussetArmor,       "Russet Armor" }, { ItemType.
            SacredArmor,       "Sacred Armor" }, { ItemType.
            SacredFeathers,    "Sacred Feathers" }, { ItemType.
            Sallet,            "Sallet" }, { ItemType.
            Sash,              "Sash" }, { ItemType.
            SavageHelmet,      "Savage Helmet" }, { ItemType.
            ScaleMail,         "Scale Mail" }, { ItemType.
            ScarabHusk,        "Scarab Husk" }, { ItemType.
            ScarabshellBoots,  "Scarabshell Boots" }, { ItemType.
            SerpentskinArmor,  "Serpentskin Armor" }, { ItemType.
            ShadowPlate,       "Shadow Plate" }, { ItemType.
            Shako,             "Shako" }, { ItemType.
            SharkskinBelt,     "Sharkskin Belt" }, { ItemType.
            SharkskinBoots,    "Sharkskin Boots" }, { ItemType.
            SharkskinGloves,   "Sharkskin Gloves" }, { ItemType.
            SharktoothArmor,   "Sharktooth Armor" }, { ItemType.
            SkullCap,          "Skull Cap" }, { ItemType.
            SkySpirit,         "Sky Spirit" }, { ItemType.
            SlayerGuard,       "Slayer Guard" }, { ItemType.
            SpiderwebSash,     "Spiderweb Sash" }, { ItemType.
            SpiredHelm,        "Spired Helm" }, { ItemType.
            SpiritMask,        "Spirit Mask" }, { ItemType.
            SplintMail,        "Splint Mail" }, { ItemType.
            StuddedLeather,    "Studded Leather" }, { ItemType.
            SunSpirit,         "Sun Spirit" }, { ItemType.
            TemplarCoat,       "Templar Coat" }, { ItemType.
            Tiara,             "Tiara" }, { ItemType.
            TigulatedMail,     "Tigulated Mail" }, { ItemType.
            TotemicMask,       "Totemic Mask" }, { ItemType.
            TrellisedArmor,    "Trellised Armor" }, { ItemType.
            TrollBelt,         "Troll Belt" }, { ItemType.
            Vambraces,         "Vambraces" }, { ItemType.
            VampireboneGloves, "Vampirebone Gloves" }, { ItemType.
            VampirefangBelt,   "Vampirefang Belt" }, { ItemType.
            WarBelt,           "War Belt" }, { ItemType.
            WarBoots,          "War Boots" }, { ItemType.
            WarGauntlets,      "War Gauntlets" }, { ItemType.
            WarHat,            "War Hat" }, { ItemType.
            WingedHelm,        "Winged Helm" }, { ItemType.
            WireFleece,        "Wire Fleece" }, { ItemType.
            WolfHead,          "Wolf Head" }, { ItemType.
            Wyrmhide,          "Wyrmhide" }, { ItemType.
            WyrmhideBoots,     "Wyrmhide Boots" },

        };

        // Weapon item codes mapped to their in game, human-friendly, readable name.
        public static Dictionary<ItemType, string> WeaponName = new Dictionary<ItemType, string>()
        {
            { ItemType.AncientAxe,          "Ancient Axe" },
            { ItemType.            AncientSword,        "Ancient Sword" },
            { ItemType.            Arbalest,            "Arbalest" }, { ItemType.
            ArchonStaff,         "Archon Staff" }, { ItemType.
            AshwoodBow,          "Ashwood Bow" }, { ItemType.
            Ataghan,             "Ataghan" }, { ItemType.
            Axe,                 "Axe" }, { ItemType.
            BalancedAxe,         "Balanced Axe" }, { ItemType.
            BalancedKnife,       "Balanced Knife" }, { ItemType.
            Balista,             "Balista" }, { ItemType.
            BalrogBlade,         "Balrog Blade" }, { ItemType.
            BalrogSpear,         "Balrog Spear" }, { ItemType.
            BarbedClub,          "Barbed Club" }, { ItemType.
            Bardiche,            "Bardiche" }, { ItemType.
            BastardSword,        "Bastard Sword" }, { ItemType.
            BattleAxe,           "Battle Axe" }, { ItemType.
            BattleCestus,        "Battle Cestus" }, { ItemType.
            BattleDart,          "Battle Dart" }, { ItemType.
            BattleHammer,        "Battle Hammer" }, { ItemType.
            BattleScythe,        "Battle Scythe" }, { ItemType.
            BattleStaff,         "Battle Staff" }, { ItemType.
            BattleSword,         "Battle Sword" }, { ItemType.
            BeardedAxe,          "Bearded Axe" }, { ItemType.
            BecDeCorbin,         "Bec De Corbin" }, { ItemType.
            BerserkerAxe,        "Berserker Axe" }, { ItemType.
            Bill,                "Bill" }, { ItemType.
            Blade,               "Blade" }, { ItemType.
            BladeBow,            "Blade Bow" }, { ItemType.
            BladeTalons,         "Blade Talons" }, { ItemType.
            BoneKnife,           "Bone Knife" }, { ItemType.
            BoneWand,            "Bone Wand" }, { ItemType.
            Brandistock,         "Brandistock" }, { ItemType.
            BroadAxe,            "Broad Axe" }, { ItemType.
            BroadSword,          "Broad Sword" }, { ItemType.
            BurntWand,           "Burnt Wand" }, { ItemType.
            Caduceus,            "Caduceus" }, { ItemType.
            CedarBow,            "Cedar Bow" }, { ItemType.
            CedarStaff,          "Cedar Staff" }, { ItemType.
            CeremonialBow,       "Ceremonial Bow" }, { ItemType.
            CeremonialJavelin,   "Ceremonial Javelin" }, { ItemType.
            CeremonialPike,      "Ceremonial Pike" }, { ItemType.
            CeremonialSpear,     "Ceremonial Spear" }, { ItemType.
            Cestus,              "Cestus" }, { ItemType.
            ChampionAxe,         "Champion Axe" }, { ItemType.
            ChampionSword,       "Champion Sword" }, { ItemType.
            ChokingGasPotion,    "Choking Gas Potion" }, { ItemType.
            ChuKoNu,             "Chu-Ko-Nu" }, { ItemType.
            Cinquedeas,          "Cinquedeas" }, { ItemType.
            ClaspedOrb,          "Clasped Orb" }, { ItemType.
            Claws,               "Claws" }, { ItemType.
            Claymore,            "Claymore" }, { ItemType.
            Cleaver,             "Cleaver" }, { ItemType.
            CloudySphere,        "Cloudy Sphere" }, { ItemType.
            Club,                "Club" }, { ItemType.
            ColossalSword,       "Colossal Sword" }, { ItemType.
            ColossalBlade,       "Colossal Blade" }, { ItemType.
            ColossusCrossbow,    "Colossus Crossbow" }, { ItemType.
            ColossusVoulge,      "Colossus Voulge" }, { ItemType.
            CompositeBow,        "Composite Bow" }, { ItemType.
            ConquestSword,       "Conquest Sword" }, { ItemType.
            Crossbow,            "Crossbow" }, { ItemType.
            Crowbill,            "Crowbill" }, { ItemType.
            CrusaderBow,         "Crusader Bow" }, { ItemType.
            CrypticAxe,          "Cryptic Axe" }, { ItemType.
            CrypticSword,        "Cryptic Sword" }, { ItemType.
            CrystalSword,        "Crystal Sword" }, { ItemType.
            CrystallineGlobe,    "Crystalline Globe" }, { ItemType.
            Cudgel,              "Cudgel" }, { ItemType.
            Cutlass,             "Cutlass" }, { ItemType.
            DacianFalx,          "Dacian Falx" }, { ItemType.
            Dagger,              "Dagger" }, { ItemType.
            Decapitator,         "Decapitator" }, { ItemType.
            DecoyDagger,         "Decoy Dagger" }, { ItemType.
            DemonCrossbow,       "Demon Crossbow" }, { ItemType.
            DemonHeart,          "Demon Heart" }, { ItemType.
            DevilStar,           "Devil Star" }, { ItemType.
            DiamondBow,          "Diamond Bow" }, { ItemType.
            DimensionalBlade,    "Dimensional Blade" }, { ItemType.
            DimensionalShard,    "Dimensional Shard" }, { ItemType.
            Dirk,                "Dirk" }, { ItemType.
            DivineScepter,       "Divine Scepter" }, { ItemType.
            DoubleAxe,           "Double Axe" }, { ItemType.
            DoubleBow,           "Double Bow" }, { ItemType.
            DragonStone,         "Dragon Stone" }, { ItemType.
            EableOrb,            "Eable Orb" }, { ItemType.
            EdgeBow,             "Edge Bow" }, { ItemType.
            ElderStaff,          "Elder Staff" }, { ItemType.
            EldritchOrb,         "Eldritch Orb" }, { ItemType.
            ElegantBlade,        "Elegant Blade" }, { ItemType.
            Espadon,             "Espadon" }, { ItemType.
            EttinAxe,            "Ettin Axe" }, { ItemType.
            ExecutionerSword,    "Executioner Sword" }, { ItemType.
            ExplodingPotion,     "Exploding Potion" }, { ItemType.
            Falcata,             "Falcata" }, { ItemType.
            Falchion,            "Falchion" }, { ItemType.
            FangedKnife,         "Fanged Knife" }, { ItemType.
            Fascia,              "Fascia" }, { ItemType.
            FeralAxe,            "Feral Axe" }, { ItemType.
            FeralClaws,          "Feral Claws" }, { ItemType.
            Flail,               "Flail" }, { ItemType.
            Flamberge,           "Flamberge" }, { ItemType.
            FlangedMace,         "Flanged Mace" }, { ItemType.
            FlyingAxe,           "Flying Axe" }, { ItemType.
            FlyingKnife,         "Flying Knife" }, { ItemType.
            Francisca,           "Francisca" }, { ItemType.
            FulmatingPotion,     "Fulmating Potion" }, { ItemType.
            Fuscina,             "Fuscina" }, { ItemType.
            GhostGlaive,         "Ghost Glaive" }, { ItemType.
            GhostSpear,          "Ghost Spear" }, { ItemType.
            GhostWand,           "Ghost Wand" }, { ItemType.
            GiantAxe,            "Giant Axe" }, { ItemType.
            GiantSword,          "Giant Sword" }, { ItemType.
            GiantThresher,       "Giant Thresher" }, { ItemType.
            Gidbinn,             "Gidbinn" }, { ItemType.
            Gladius,             "Gladius" }, { ItemType.
            Glaive,              "Glaive" }, { ItemType.
            GloriousAxe,         "Glorious Axe" }, { ItemType.
            GlowingOrb,          "Glowing Orb" }, { ItemType.
            GnarledStaff,        "Gnarled Staff" }, { ItemType.
            GorgonCrossbow,      "Gorgon Crossbow" }, { ItemType.
            GothicAxe,           "Gothic Axe" }, { ItemType.
            GothicBow,           "Gothic Bow" }, { ItemType.
            GothicStaff,         "Gothic Staff" }, { ItemType.
            GothicSword,         "Gothic Sword" }, { ItemType.
            GrandMatronBow,      "Grand Matron Bow" }, { ItemType.
            GrandScepter,        "Grand Scepter" }, { ItemType.
            GraveWand,           "Grave Wand" }, { ItemType.
            GreatAxe,            "Great Axe" }, { ItemType.
            GreatBow,            "Great Bow" }, { ItemType.
            GreatMaul,           "Great Maul" }, { ItemType.
            GreatPilum,          "Great Pilum" }, { ItemType.
            GreatPoleaxe,        "Great Poleaxe" }, { ItemType.
            GreatSword,          "Great Sword" }, { ItemType.
            GreaterClaws,        "Greater Claws" }, { ItemType.
            GreaterTalons,       "Greater Talons" }, { ItemType.
            GrimScythe,          "Grim Scythe" }, { ItemType.
            GrimWand,            "Grim Wand" }, { ItemType.
            Halberd,             "Halberd" }, { ItemType.
            HandAxe,             "Hand Axe" }, { ItemType.
            HandScythe,          "Hand Scythe" }, { ItemType.
            Harpoon,             "Harpoon" }, { ItemType.
            Hatchet,             "Hatchet" }, { ItemType.
            HatchetHands,        "HatchetHands" }, { ItemType.
            HeavenlyStone,       "Heavenly Stone" }, { ItemType.
            HeavyCrossbow,       "Heavy Crossbow" }, { ItemType.
            HellforgeHammer,     "Hellforge Hammer" }, { ItemType.
            HighlandBlade,       "Highland Blade" }, { ItemType.
            HolyWaterSprinkler,  "Holy Water Sprinkler" }, { ItemType.
            HoradricMalus,       "Horadric Malus" }, { ItemType.
            HoradricStaff,       "Horadric Staff" }, { ItemType.
            HuntersBow,          "Hunters Bow" }, { ItemType.
            Hurlbat,             "Hurlbat" }, { ItemType.
            HydraBow,            "Hydra Bow" }, { ItemType.
            HydraEdge,           "Hydra Edge" }, { ItemType.
            HyperionJavelin,     "Hyperion Javelin" }, { ItemType.
            HyperionSpear,       "Hyperion Spear" }, { ItemType.
            JaggedStar,          "Jagged Star" }, { ItemType.
            Javelin,             "Javelin" }, { ItemType.
            JoStaff,             "Jo Staff" }, { ItemType.
            Katar,               "Katar" }, { ItemType.
            KhalimFlail,         "Khalim Flail" }, { ItemType.
            Knout,               "Knout" }, { ItemType.
            Kriss,               "Kriss" }, { ItemType.
            Lance,               "Lance" }, { ItemType.
            LargeAxe,            "Large Axe" }, { ItemType.
            LegendSpike,         "Legend Spike" }, { ItemType.
            LegendSword,         "Legend Sword" }, { ItemType.
            LegendaryMallet,     "Legendary Mallet" }, { ItemType.
            LichWand,            "Lich Wand" }, { ItemType.
            LightCrossbow,       "Light Crossbow" }, { ItemType.
            LochaberAxe,         "Lochaber Axe" }, { ItemType.
            LongBattleBow,       "Long Battle Bow" }, { ItemType.
            LongBow,             "Long Bow" }, { ItemType.
            LongSiegeBow,        "Long Siege Bow" }, { ItemType.
            LongStaff,           "Long Staff" }, { ItemType.
            LongSword,           "Long Sword" }, { ItemType.
            LongWarBow,          "Long War Bow" }, { ItemType.
            Mace,                "Mace" }, { ItemType.
            MaidenJavelin,       "Maiden Javelin" }, { ItemType.
            MaidenPike,          "Maiden Pike" }, { ItemType.
            MaidenSpear,         "Maiden Spear" }, { ItemType.
            Mancatcher,          "Mancatcher" }, { ItemType.
            MarteldeFer,         "Martel de Fer" }, { ItemType.
            MatriarchalBow,      "Matriarchal Bow" }, { ItemType.
            MatriarchalPike,     "Matriarchal Pike" }, { ItemType.
            MatriarchalSpear,    "Matriarchal Spear" }, { ItemType.
            MatriarchalJavelin,  "Matriarchal Javelin" }, { ItemType.
            Maul,                "Maul" }, { ItemType.
            MightyScepter,       "Mighty Scepter" }, { ItemType.
            MilitaryAxe,         "Military Axe" }, { ItemType.
            MilitaryPick,        "Military Pick" }, { ItemType.
            MithralPoint,        "Mithral Point" }, { ItemType.
            MorningStar,         "Morning Star" }, { ItemType.
            MythicalSword,       "Mythical Sword" }, { ItemType.
            Naga,                "Naga" }, { ItemType.
            OgreAxe,             "Ogre Axe" }, { ItemType.
            OgreMaul,            "Ogre Maul" }, { ItemType.
            OilPotion,           "Oil Potion" }, { ItemType.
            Partizan,            "Partizan" }, { ItemType.
            PelletBow,           "Pellet Bow" }, { ItemType.
            PetrifiedWand,       "Petrified Wand" }, { ItemType.
            PhaseBlade,          "Phase Blade" }, { ItemType.
            Pike,                "Pike" }, { ItemType.
            Pilum,               "Pilum" }, { ItemType.
            Poignard,            "Poignard" }, { ItemType.
            Poleaxe,             "Poleaxe" }, { ItemType.
            PolishedWand,        "Polished Wand" }, { ItemType.
            QuarterStaff,        "Quarter Staff" }, { ItemType.
            Quhab,               "Quhab" }, { ItemType.
            RancidGasPotion,     "Rancid Gas Potion" }, { ItemType.
            RazorBow,            "Razor Bow" }, { ItemType.
            ReflexBow,           "Reflex Bow" }, { ItemType.
            ReinforcedMace,      "Reinforced Mace" }, { ItemType.
            RepeatingCrossbow,   "Repeating Crossbow" }, { ItemType.
            Rondel,              "Rondel" }, { ItemType.
            RuneBow,             "Rune Bow" }, { ItemType.
            RuneScepter,         "Rune Scepter" }, { ItemType.
            RuneStaff,           "Rune Staff" }, { ItemType.
            RuneSword,           "Rune Sword" }, { ItemType.
            RunicTalons,         "Runic Talons" }, { ItemType.
            Sabre,               "Sabre" }, { ItemType.
            SacredGlobe,         "Sacred Globe" }, { ItemType.
            Scepter,             "Scepter" }, { ItemType.
            Scimitar,            "Scimitar" }, { ItemType.
            ScissorsKatar,       "Scissors Katar" }, { ItemType.
            ScissorsQuhab,       "Scissors Quhab" }, { ItemType.
            ScissorsSuwayyah,    "Scissors Suwayyah" }, { ItemType.
            Scourge,             "Scourge" }, { ItemType.
            Scythe,              "Scythe" }, { ItemType.
            SeraphRod,           "Seraph Rod" }, { ItemType.
            ShadowBow,           "Shadow Bow" }, { ItemType.
            Shamshir,            "Shamshir" }, { ItemType.
            Shillelah,           "Shillelah" }, { ItemType.
            ShortBattleBow,      "Short Battle Bow" }, { ItemType.
            ShortBow,            "Short Bow" }, { ItemType.
            ShortSiegeBow,       "Short Siege Bow" }, { ItemType.
            ShortSpear,          "Short Spear" }, { ItemType.
            ShortStaff,          "Short Staff" }, { ItemType.
            ShortSword,          "Short Sword" }, { ItemType.
            ShortWarBow,         "Short War Bow" }, { ItemType.
            SiegeCrossbow,       "Siege Crossbow" }, { ItemType.
            SilverEdgedAxe,      "Silver Edged Axe" }, { ItemType.
            Simbilan,            "Simbilan" }, { ItemType.
            SmallCrescent,       "Small Crescent" }, { ItemType.
            SmokedSphere,        "Smoked Sphere" }, { ItemType.
            SparklingBall,       "Sparkling Ball" }, { ItemType.
            Spear,               "Spear" }, { ItemType.
            Spetum,              "Spetum" }, { ItemType.
            Spiculum,            "Spiculum" }, { ItemType.
            SpiderBow,           "Spider Bow" }, { ItemType.
            SpikedClub,          "Spiked Club" }, { ItemType.
            StaffOfTheKings,     "Staff Of The Kings" }, { ItemType.
            StagBow,             "Stag Bow" }, { ItemType.
            Stalagmite,          "Stalagmite" }, { ItemType.
            Stilleto,            "Stilleto" }, { ItemType.
            StranglingGasPotion, "Strangling Gas Potion" }, { ItemType.
            StygianPike,         "Stygian Pike" }, { ItemType.
            StygianPilum,        "Stygian Pilum" }, { ItemType.
            SuperKhalimFlail,    "Super Khalim Flail" }, { ItemType.
            Suwayyah,            "Suwayyah" }, { ItemType.
            SwirlingCrystal,     "Swirling Crystal" }, { ItemType.
            Tabar,               "Tabar" }, { ItemType.
            Thresher,            "Thresher" }, { ItemType.
            ThrowingAxe,         "Throwing Axe" }, { ItemType.
            ThrowingKnife,       "Throwing Knife" }, { ItemType.
            ThrowingSpear,       "Throwing Spear" }, { ItemType.
            ThunderMaul,         "Thunder Maul" }, { ItemType.
            Tomahawk,            "Tomahawk" }, { ItemType.
            TombWand,            "Tomb Wand" }, { ItemType.
            Trident,             "Trident" }, { ItemType.
            Truncheon,           "Truncheon" }, { ItemType.
            Tulwar,              "Tulwar" }, { ItemType.
            TuskSword,           "Tusk Sword" }, { ItemType.
            TwinAxe,             "Twin Axe" }, { ItemType.
            TwoHandedSword,      "Two Handed Sword" }, { ItemType.
            TyrantClub,          "Tyrant Club" }, { ItemType.
            UnearthedWand,       "Unearthed Wand" }, { ItemType.
            VortexOrb,           "Vortex Orb" }, { ItemType.
            Voulge,              "Voulge" }, { ItemType.
            WalkingStick,        "Walking Stick" }, { ItemType.
            Wand,                "Wand" }, { ItemType.
            WarAxe,              "War Axe" }, { ItemType.
            WarClub,             "War Club" }, { ItemType.
            WarDart,             "War Dart" }, { ItemType.
            WarFist,             "War Fist" }, { ItemType.
            WarFork,             "War Fork" }, { ItemType.
            WarHammer,           "War Hammer" }, { ItemType.
            WarJavelin,          "War Javelin" }, { ItemType.
            WarPike,             "War Pike" }, { ItemType.
            WarScepter,          "War Scepter" }, { ItemType.
            WarScythe,           "War Scythe" }, { ItemType.
            WarSpear,            "War Spear" }, { ItemType.
            WarSpike,            "War Spike" }, { ItemType.
            WarStaff,            "War Staff" }, { ItemType.
            WarSword,            "War Sword" }, { ItemType.
            WardBow,             "Ward Bow" }, { ItemType.
            WingedAxe,           "Winged Axe" }, { ItemType.
            WingedHarpoon,       "Winged Harpoon" }, { ItemType.
            WingedKnife,         "Winged Knife" }, { ItemType.
            WirtsLeg,            "Wirts Leg" }, { ItemType.
            WristBlade,          "Wrist Blade" }, { ItemType.
            WristSpike,          "Wrist Spike" }, { ItemType.
            WristSword,          "Wrist Sword" }, { ItemType.
            Yari,                "Yari" }, { ItemType.
            YewWand,             "Yew Wand" }, { ItemType.
            Zweihander,          "Zweihander" }
        };

        // Misc items codes, like jewelry, gems, potions and runes, mapped to their in
        // game, human-friendly, readable name.
        public static Dictionary<ItemType, string> MiscName = new Dictionary<ItemType, string>()
        {
            { ItemType.Amethyst,                      "Amethyst" }, { ItemType.
            AmnRune,                       "Amn Rune" }, { ItemType.
            Amulet,                        "Amulet" }, { ItemType.
            AntidotePotion,                "Antidote Potion" }, { ItemType.
            Arrows,                        "Arrows" }, { ItemType.
            BaalsEye,                      "Baal's Eye" }, { ItemType.
            BarkScroll,                    "Bark Scroll" }, { ItemType.
            BerRune,                       "Ber Rune" }, { ItemType.
            Bolts,                         "Bolts" }, { ItemType.
            BookofSkill,                   "Book of Skill" }, { ItemType.
            BurningEssenceofTerror,        "Burning Essence of Terror" }, { ItemType.
            ChamRune,                      "Cham Rune" }, { ItemType.
            ChargedEssenceofHatred,        "Charged Essence of Hatred" }, { ItemType.
            GrandCharm,                    "Grand Charm" }, { ItemType.
            LargeCharm,                    "Large Charm" }, { ItemType.
            SmallCharm,                    "Small Charm" }, { ItemType.
            ChippedAmethyst,               "Chipped Amethyst" }, { ItemType.
            ChippedDiamond,                "Chipped Diamond" }, { ItemType.
            ChippedEmerald,                "Chipped Emerald" }, { ItemType.
            ChippedRuby,                   "Chipped Ruby" }, { ItemType.
            ChippedSapphire,               "Chipped Sapphire" }, { ItemType.
            ChippedSkull,                  "Chipped Skull" }, { ItemType.
            ChippedTopaz,                  "Chipped Topaz" }, { ItemType.
            DecipheredBarkScroll,          "Deciphered Bark Scroll" }, { ItemType.
            DiablosHorn,                   "Diablo's Horn" }, { ItemType.
            Diamond,                       "Diamond" }, { ItemType.
            DolRune,                       "Dol Rune" }, { ItemType.
            ElRune,                        "El Rune" }, { ItemType.
            EldRune,                       "Eld Rune" }, { ItemType.
            Elixir,                        "Elixir" }, { ItemType.
            Emerald,                       "Emerald" }, { ItemType.
            EthRune,                       "Eth Rune" }, { ItemType.
            FalRune,                       "Fal Rune" }, { ItemType.
            FesteringEssenceofDestruction, "Festering Essence of Destruction" }, { ItemType.
            FlawedAmethyst,                "Flawed Amethyst" }, { ItemType.
            FlawedDiamond,                 "Flawed Diamond" }, { ItemType.
            FlawedEmerald,                 "Flawed Emerald" }, { ItemType.
            FlawedRuby,                    "Flawed Ruby" }, { ItemType.
            FlawedSapphire,                "Flawed Sapphire" }, { ItemType.
            FlawedSkull,                   "Flawed Skull" }, { ItemType.
            FlawedTopaz,                   "Flawed Topaz" }, { ItemType.
            FlawlessAmethyst,              "Flawless Amethyst" }, { ItemType.
            FlawlessDiamond,               "Flawless Diamond" }, { ItemType.
            FlawlessEmerald,               "Flawless Emerald" }, { ItemType.
            FlawlessRuby,                  "Flawless Ruby" }, { ItemType.
            FlawlessSapphire,              "Flawless Sapphire" }, { ItemType.
            FlawlessSkull,                 "Flawless Skull" }, { ItemType.
            FlawlessTopaz,                 "Flawless Topaz" }, { ItemType.
            FullHealingPotion,             "Full Healing Potion" }, { ItemType.
            FullManaPotion,                "Full Mana Potion" }, { ItemType.
            FullRejuvenationPotion,        "Full Rejuvenation Potion" }, { ItemType.
            Gold,                          "Gold" }, { ItemType.
            GoldBird,                      "Gold Bird" }, { ItemType.
            GreaterHealingPotion,          "Greater Healing Potion" }, { ItemType.
            GreaterManaPotion,             "Greater Mana Potion" }, { ItemType.
            GulRune,                       "Gul Rune" }, { ItemType.
            HealingPotion,                 "Healing Potion" }, { ItemType.
            HealingPotionMid,              "Healing Potion" }, { ItemType.
            HelRune,                       "Hel Rune" }, { ItemType.
            Herb,                          "Herb" }, { ItemType.
            HoradricCube,                  "Horadric Cube" }, { ItemType.
            IdentifyBook,                  "Identify Book" }, { ItemType.
            IdentifyScroll,                "Identify Scroll" }, { ItemType.
            IoRune,                        "Io Rune" }, { ItemType.
            IstRune,                       "Ist Rune" }, { ItemType.
            IthRune,                       "Ith Rune" }, { ItemType.
            JadeFigurine,                  "Jade Figurine" }, { ItemType.
            JahRune,                       "Jah Rune" }, { ItemType.
            Jewel,                         "Jewel" }, { ItemType.
            KeyofDestruction,              "Key of Destruction" }, { ItemType.
            KeyofHate,                     "Key of Hate" }, { ItemType.
            KeyofTerror,                   "Key of Terror" }, { ItemType.
            KhalimsBrain,                  "Khalim's Brain" }, { ItemType.
            KhalimsEye,                    "Khalim's Eye" }, { ItemType.
            KhalimsHeart,                  "Khalim's Heart" }, { ItemType.
            KoRune,                        "Ko Rune" }, { ItemType.
            LamEsensTome,                  "Lam Esens Tome" }, { ItemType.
            LargeBluePotion,               "Large Blue Potion" }, { ItemType.
            LargeRedPotion,                "Large Red Potion" }, { ItemType.
            LemRune,                       "Lem Rune" }, { ItemType.
            LesserHealingPotion,           "Lesser Healing Potion" }, { ItemType.
            LesserManaPotion,              "Lesser Mana Potion" }, { ItemType.
            LightHealingPotion,            "Light Healing Potion" }, { ItemType.
            LightManaPotion,               "Light Mana Potion" }, { ItemType.
            LoRune,                        "Lo Rune" }, { ItemType.
            LumRune,                       "Lum Rune" }, { ItemType.
            Maguffin,                      "Maguffin" }, { ItemType.
            MalRune,                       "Mal Rune" }, { ItemType.
            ManaPotion,                    "Mana Potion" }, { ItemType.
            ManaPotionMid,                 "Mana Potion" }, { ItemType.
            MephistosBrain,                "Mephisto's Brain" }, { ItemType.
            MephistoKey,                   "Mephisto Key" }, { ItemType.
            MephistoSoulStone,             "Mephisto Soul Stone" }, { ItemType.
            NefRune,                       "Nef Rune" }, { ItemType.
            OhmRune,                       "Ohm Rune" }, { ItemType.
            OrtRune,                       "Ort Rune" }, { ItemType.
            PerfectAmethyst,               "Perfect Amethyst" }, { ItemType.
            PerfectDiamond,                "Perfect Diamond" }, { ItemType.
            PerfectEmerald,                "Perfect Emerald" }, { ItemType.
            PerfectRuby,                   "Perfect Ruby" }, { ItemType.
            PerfectSapphire,               "Perfect Sapphire" }, { ItemType.
            PerfectSkull,                  "Perfect Skull" }, { ItemType.
            PerfectTopaz,                  "Perfect Topaz" }, { ItemType.
            PlayerEar,                     "Player Ear" }, { ItemType.
            PulRune,                       "Pul Rune" }, { ItemType.
            RalRune,                       "Ral Rune" }, { ItemType.
            RejuvenationPotion,            "Rejuvenation Potion" }, { ItemType.
            Ring,                          "Ring" }, { ItemType.
            Ruby,                          "Ruby" }, { ItemType.
            Sapphire,                      "Sapphire" }, { ItemType.
            Scroll,                        "Scroll" }, { ItemType.
            ScrollofHoradric,              "Scroll of Horadric" }, { ItemType.
            ScrollofMalah,                 "Scroll of Malah" }, { ItemType.
            PotionofLife,                  "Potion of Life" }, { ItemType.
            ShaelRune,                     "Shael Rune" }, { ItemType.
            SkeletonKey,                   "Skeleton Key" }, { ItemType.
            Skull,                         "Skull" }, { ItemType.
            SmallBluePotion,               "Small Blue Potion" }, { ItemType.
            SmallRedPotion,                "Small Red Potion" }, { ItemType.
            SolRune,                       "Sol Rune" }, { ItemType.
            StaminaPotion,                 "Stamina Potion" }, { ItemType.
            StandardofHeroes,              "Standard of Heroes" }, { ItemType.
            StrongHealingPotion,           "Strong Healing Potion" }, { ItemType.
            StrongManaPotion,              "Strong Mana Potion" }, { ItemType.
            SurRune,                       "Sur Rune" }, { ItemType.
            TalRune,                       "Tal Rune" }, { ItemType.
            ThawingPotion,                 "Thawing Potion" }, { ItemType.
            ThulRune,                      "Thul Rune" }, { ItemType.
            TirRune,                       "Tir Rune" }, { ItemType.
            TokenofAbsolution,             "Token of Absolution" }, { ItemType.
            Topaz,                         "Topaz" }, { ItemType.
            Torch,                         "Torch" }, { ItemType.
            TownPortalBook,                "Town Portal Book" }, { ItemType.
            TownPortalScroll,              "Town Portal Scroll" }, { ItemType.
            TwistedEssenceofSuffering,     "Twisted Essence of Suffering" }, { ItemType.
            UmRune,                        "Um Rune" }, { ItemType.
            VexRune,                       "Vex Rune" }, { ItemType.
            ViperAmulet,                   "Viper Amulet" }, { ItemType.
            ZodRune,                       "Zod Rune" },
        };
    }
}
