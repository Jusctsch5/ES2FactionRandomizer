using ES2FactionRandomizer.Definitions.Traits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions
{ 
    public class TraitDefinitions
    {
        public TraitDefinitions()
        {
            _factionTraits = new List<FactionTrait>();
            _gameplayAffinity = new List<GameplayAffinity>() ;
            _homePlanets = new List<HomePlanet>();
            _populations = new List<Population>();
            _primary = new List<PrimaryPopulationModifier>();
            _secondary = new List<SecondaryPopulationModifier>();
            _tertiary = new List<TertiaryPopulationModifier>();
            _primaryPolitics = new List<PrimaryPolitics>();
            _secondaryPolitics = new List<SecondaryPolitics>();
            _governments = new List<Government>();
            _tech = new List<Tech>;
        }

        public void Initialize()
        {
            _gameplayAffinity.Add(new GameplayAffinity(GameplayAffinityType.GameplayAffinityCravers            , 100));
            _gameplayAffinity.Add(new GameplayAffinity(GameplayAffinityType.GameplayAffinitySophons            , 100));
            _gameplayAffinity.Add(new GameplayAffinity(GameplayAffinityType.GameplayAffinityTerrans            ,  95));
            _gameplayAffinity.Add(new GameplayAffinity(GameplayAffinityType.GameplayAffinityHoratio            ,  95));
            _gameplayAffinity.Add(new GameplayAffinity(GameplayAffinityType.GameplayAffinityTimeLords          ,  95));
            _gameplayAffinity.Add(new GameplayAffinity(GameplayAffinityType.GameplayAffinityVodyani            ,  95));
            _gameplayAffinity.Add(new GameplayAffinity(GameplayAffinityType.GameplayAffinityLumeris            , 100));
            _gameplayAffinity.Add(new GameplayAffinity(GameplayAffinityType.GameplayAffinityVenetians          ,  95));
            _gameplayAffinity.Add(new GameplayAffinity(GameplayAffinityType.GameplayAffinityVaulters           ,  95));
            _gameplayAffinity.Add(new GameplayAffinity(GameplayAffinityType.GameplayAffinityMajorHisshos       , 100));
            _gameplayAffinity.Add(new GameplayAffinity(GameplayAffinityType.GameplayAffinityUmbralChoir        , 100));

            _visualAffinity.Add(new VisualAffinity(VisualAffinityType.VisualAffinityCravers                    ,   5));
            _visualAffinity.Add(new VisualAffinity(VisualAffinityType.VisualAffinitySophons                    ,   5));
            _visualAffinity.Add(new VisualAffinity(VisualAffinityType.VisualAffinityTerrans                    ,  10));
            _visualAffinity.Add(new VisualAffinity(VisualAffinityType.VisualAffinityHoratio                    ,  10));
            _visualAffinity.Add(new VisualAffinity(VisualAffinityType.VisualAffinityVodyani                    ,   5));
            _visualAffinity.Add(new VisualAffinity(VisualAffinityType.VisualAffinityLumeris                    ,  10));
            _visualAffinity.Add(new VisualAffinity(VisualAffinityType.VisualAffinityTimeLords                  ,   5));
            _visualAffinity.Add(new VisualAffinity(VisualAffinityType.VisualAffinityVenetians                  ,   5));
            _visualAffinity.Add(new VisualAffinity(VisualAffinityType.VisualAffinityVaulters                   ,  10));
            _visualAffinity.Add(new VisualAffinity(VisualAffinityType.VisualAffinityMajorHisshos               ,   5));
            _visualAffinity.Add(new VisualAffinity(VisualAffinityType.VisualAffinityUmbralChoir                ,   5));

            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitAceSenatorsTitle                  ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitReducedTaxesTitle                 ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitAmateurExecutivesTitle            ,   -5));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitApatheticColonistsTitle           ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBeamSpecializationTitle           ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBigBrothersTitle                  ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBigFleets1Title                   ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBigFleets2Title                   ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBigSpenders1Title                 ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBigSpenders2Title                 ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBlackThumb1Title                  ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBlackThumb2Title                  ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBlockadeBreakersTitle             ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBrilliantStrategists1Title        ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBrilliantStrategists2Title        ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBuilders1Title                    ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBuilders2Title                    ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBuilders3Title                    ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBurningColonizationTitle          ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBusinessmen1Title                 ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBusinessmen2Title                 ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBusinessmen3Title                 ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitCombatRookiesTitle                ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitCombatSpecialistsTitle            ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitConfidentTacticiansTitle          ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitContentCitizens1Title             ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitContentCitizens2Title             ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitCowards1Title                     ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitCowards2Title                     ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitCrowdedPlanets1Title              ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitCrowdedPlanets2Title              ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitCulturalists1Title                ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitCulturalists2Title                ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitDeadlyWeapons1Title               ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitDeadlyWeapons2Title               ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitDiligentWorkersTitle              ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitDisciplinedTitle                  ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitDoubtfulTacticiansTitle           ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitDryFrozenColonizationTitle        ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitEfficientExplorer1Title           ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitEfficientExplorer2Title           ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitEternalWarTitle                   ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitExpansionists1Title               ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitExpansionists2Title               ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitExtendedConsortiumTitle           ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitFactionTraitSmoothTalkersTitle    ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitUtopianInfrastructureTitle        ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitFastTraveler1Title                ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitFastTraveler2Title                ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitFearlessWarriors1Title            ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitFearlessWarriors2Title            ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitFeebleWarriors1Title              ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitFeebleWarriors2Title              ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitFerventColonists1Title            ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitFerventColonists2Title            ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitFierceVigilantesTitle             ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitFloodedTemperateColonizationTitle ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitFrailVigilantesTitle              ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitFrozenColonizationTitle           ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitGasColonizationTitle              ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitGeneHunterTitle                   ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitGrowthPlan1Title                  ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitGrowthPlan2Title                  ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitGrowthPlan3Title                  ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitGuardiansTitle                    ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitHotWetColonizationTitle           ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitHumaneWeaponsTitle                ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitIneptTradersTitle                 ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitInimicalTitle                     ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitKineticSpecializationTitle        ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitKingpinExecutivesTitle            ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitLaserSpecializationTitle          ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitLegendaryHeroes1Title             ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitLegendaryHeroes2Title             ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitLousySenatorsTitle                ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitLuxuryConnoisseursTitle           ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitLuxuryIgnoramusesTitle            ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitMissileSpecializationTitle        ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitMutualUnderstanding1Title         ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitMutualUnderstanding2Title         ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitNaive1Title                       ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitNaive2Title                       ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitOptimalDefense1Title              ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitOptimalDefense2Title              ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitOptimistic1Title                  ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitOptimistic2Title                  ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitPatriots1Title                    ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitPatriots2Title                    ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitPerfectGenes1Title                ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitPerfectGenes2Title                ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitPessimistic1Title                 ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitPessimistic2Title                 ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitPoorStrategists1Title             ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitPoorStrategists2Title             ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitPriceOfPerfection1Title           ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitPriceOfPerfection2Title           ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitProneToAgitationTitle             ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitPushovers1Title                   ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitPushovers2Title                   ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitScanningTitle                     ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitScientists1Title                  ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitScientists2Title                  ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitScientists3Title                  ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitSkillfulTradersTitle              ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitSlowTraveler1Title                ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitSlowTraveler2Title                ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitSocialChameleonsTitle             ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitSpaceCadets1Title                 ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitSpaceCadets2Title                 ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitStartWithHyperiumTitle            ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitStartWithNegativeAnomalyTitle     ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitStartWithPositiveAnomalyTitle     ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitStartWithTitaniumTitle            ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitSubOptimalDefenseTitle            ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitTemperateColonizationTitle        ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitUniqueDictatorshipTitle           ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitUnskilledBuilders1Title           ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitUnskilledBuilders2Title           ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitSacredTraditionTitle              ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitHisshosFestivalsTitle             ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitMiningExpertsTitle                ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitPirateHatersTitle                 ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitJuggernautSpecialistsTitle        ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitStartWithJuggernautTitle          ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitReducedManpowerFromFoodTitle      ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitManpowerFromProcessingPowerTitle  ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBonusHackingRoutesTitle           ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBonusHackingSpeedTitle            ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitNativelyInvisibleShipsTitle       ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitProcessingPowerFromTraitorsTitle  ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitTradePenaltyTitle                 ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitLuxuryCostModifierTitle           ,   10));
            _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitAntiExpansionistsTitle            ,   10));

            _homePlanets.Add(new HomePlanet(HomePlanetTraitType.FactionTraitHomePlanetPlanetTypeAridTitle      ,   5));
            _homePlanets.Add(new HomePlanet(HomePlanetTraitType.FactionTraitHomePlanetPlanetTypeAtollTitle     ,  15));
            _homePlanets.Add(new HomePlanet(HomePlanetTraitType.FactionTraitHomePlanetPlanetTypeBorealTitle    ,  10));
            _homePlanets.Add(new HomePlanet(HomePlanetTraitType.FactionTraitHomePlanetPlanetTypeForestTitle    ,  15));
            _homePlanets.Add(new HomePlanet(HomePlanetTraitType.FactionTraitHomePlanetPlanetTypeJungleTitle    ,  10));
            _homePlanets.Add(new HomePlanet(HomePlanetTraitType.FactionTraitHomePlanetPlanetTypeMonsoonTitle   ,  10));
            _homePlanets.Add(new HomePlanet(HomePlanetTraitType.FactionTraitHomePlanetPlanetTypeOceanTitle     ,  15));
            _homePlanets.Add(new HomePlanet(HomePlanetTraitType.FactionTraitHomePlanetPlanetTypeSnowTitle      ,   5));
            _homePlanets.Add(new HomePlanet(HomePlanetTraitType.FactionTraitHomePlanetPlanetTypeSteppesTitle   ,  10));
            _homePlanets.Add(new HomePlanet(HomePlanetTraitType.FactionTraitHomePlanetPlanetTypeTerranTitle    ,  15));
            _homePlanets.Add(new HomePlanet(HomePlanetTraitType.FactionTraitHomePlanetPlanetTypeTropicalTitle  ,  10)); // Medd
            _homePlanets.Add(new HomePlanet(HomePlanetTraitType.FactionTraitHomePlanetPlanetTypeTundraTitle    ,  10));
            _homePlanets.Add(new HomePlanet(HomePlanetTraitType.FactionTraitHomePlanetPlanetTypeVeldtTitle     ,  10)); // savannah

            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorAmoebaTitle                   ,   5));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorBenthysTitle                  ,  10)); // Kalgeros
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorBhagabasTitle                 ,  5));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorBotsTitle                     ,  10));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorDamageTitle                   ,  10));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorDeuyivansTitle                ,  10));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorDiplomacyTitle                ,  10));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorEydersTitle                   ,  10));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorGalvransTitle                 ,   5));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorGreenmanTitle                 ,  10)); // Amblyr
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorGnashastsTitle                ,   5));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorHarmonyTitle                  ,  10));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorHaroshemsTitle                ,  10));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorHisshosTitle                  ,   5)); // Yuusho
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorMavrosTitle                   ,  10));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorNirisTitle                    ,  10));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorPilgrimsTitle                 ,   5));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorPulsosTitle                   ,   5));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorRemnantsTitle                 ,   5));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorTikanansTitle                 ,   5));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorZvaliTitle                    ,  10));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorKalTikMasTitle                ,   5));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorSowersTitle                   ,   5));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorSefalorosTitle                ,   5));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorSistersOfMercyTitle           ,   5));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorIlloTitle                     ,   5));
            _populations.Add(new Population(PopulationTraitType.FactionTraitMinorMinorHackingTitle             ,   5)); // Kalmat

            _primary.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitAmoebaPrimaryTitle                                 , 10)); // Nuturers
            _primary.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitBotsPrimaryTitle                                   ,  5)); // Craftsmen
            _primary.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitCraversPrimaryTitle                                , 15)); // Extreme Foremen
            _primary.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitDeuyivansPrimaryTitle                              , 10)); // Methodists
            _primary.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitGnashastsPrimaryTitle                              ,  5)); // Tough Defenders
            _primary.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitHaroshemsPrimaryTitle                              ,  5)); // Agricultural Engineers
            _primary.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitHoratioPrimaryTitle                                ,  5)); // Hedonists
            _primary.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitMezariPrimaryTitle                                 ,  5)); // Analysts
            _primary.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryFIDSITitle                                  , 15)); // Meritocratic Cosmopolites
            _primary.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitSheredynPrimaryTitle                               , 10)); // Martial Traditions
            _primary.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitSophonsPrimaryTitle                                ,  5)); // Analysts
            _primary.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitTerransPrimaryTitle                                ,  5)); // Loyal Citizens
            _primary.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitTikanansPrimaryTitle                               , 10)); // Eager Volunteers
            _primary.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitTimeLordsPrimaryTitle                              , 25)); // Adept Workers
            _primary.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitUnfallenPrimaryTitle                               , 15)); // Agriculturalists
            _primary.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitVampirilisPrimaryTitle                             , 10)); // Gargantuan Population
            _primary.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitVenetiansPrimaryTitle                              ,  5)); // Bankers
            _primary.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryStrategicToFood01Title                      ,  5)); // Strategic Sustenance
            _primary.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitHisshoPrimaryTitle                                 ,  5)); // Martial Traditions
            _primary.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitIlloPrimaryTitle                                   ,  5)); // Stellar Stoics
            _primary.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryProcessingPower01Title                      ,  5)); // Natural Born Hackers

            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitHisshoSecondaryTitle                         , 10)); // Serve With Honor
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitBenthysSecondaryTitle                        , 10)); // Euphorists
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitBhagabasSecondaryTitle                       , 10)); // Blissful Residents
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitDeuyivansSecondaryTitle                      ,  5)); // Hydroponics Spec
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitEydersSecondaryTitle                         ,  5)); // Catalyzation Specialists
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitGnashastsSecondaryTitle                      , 10)); // Rushless Defender
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitHaroshemsSecondaryTitle                      , 10)); // efficient farmers
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitHisshosSecondaryTitle                        ,  5)); // Harshly-Trained Combatants
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitMavrosSecondaryTitle                         ,  5)); // Hephaestian Workers
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitMezariSecondaryTitle                         ,  5)); // Cryologists
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitNirisSecondaryTitle                          ,  5)); // Prolific Farmers
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitPilgrimsSecondaryTitle                       ,  5)); // Experimentalists
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitPulsosSecondaryTitle                         , 10)); // Anomaly Stalkers
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitRemnantSecondaryTitle                        ,  5)); // TreasureHunters
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitSecondaryDefenseFertileTitle                 ,  5)); // Logisticians
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitSecondaryDustMeagerTitle                     , 10)); // Dust Purists
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitSecondaryHappinessHotTitle                   ,  5)); // Warmhearted
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitSecondaryHappinessTemperateTitle             ,  5)); // Naturalists
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitSecondaryIndustryColdTitle                   ,  5)); // Geothermal Specialists
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitSecondaryIndustryMeagerTitle                 ,  5)); // Self-Sustaining Laborers
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitSecondaryScienceHotTitle                     ,  5)); // Insulation Specialists
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitTerransSecondaryTitle                        ,  5)); // Engaging Denizens
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitTikanansSecondaryTitle                       ,  5)); // Bountiful Troops
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitUnfallenSecondaryTitle                       , 15)); // Bounteous Gardeners
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitVenetiansSecondaryTitle                      ,  5)); // Dust Seekers
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitZvaliSecondaryTitle                          , 10)); // Scientistic Hobbyist
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitSecondaryAntiDepletion01Title                , 10)); // Planet Menders
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitSecondaryHappinessSterileTitle               , 10)); // Hardened Dwellers
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitSecondaryIndustryFertileTitle                , 10)); // Biomimetic Builders
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitSecondaryStrategicToScience01Title           , 15)); // Strategic Science
            _secondary.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierTraitType.PopulationModifiersTraitSecondaryGroundBattleAttackerDamage01Title   ,  5)); // Public Minefields

            _tertiary.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitSophonTitle                                    , 10));
            _tertiary.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitCraverTitle                                    , 10));
            _tertiary.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitVenetianTitle                                  , 10));
            _tertiary.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitVampirilisTitle                                , 10));
            _tertiary.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitSheredynTitle                                  , 10));
            _tertiary.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitTerransTitle                                   , 10));
            _tertiary.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitHoratioTitle                                   , 10));
            _tertiary.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitTimeLordsTitle                                 , 10));
            _tertiary.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitUnfallenTitle                                  , 10));
            _tertiary.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitCustomFactionScienceDefenseTitle               , 10));
            _tertiary.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitCustomFactionManpowerProductionCostTitle       , 10));
            _tertiary.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitUmbralChoirTitle                               , 10));

            _primaryPolitics.Add(new PrimaryPolitics(PrimaryPoliticsType.PopulationPoliticalTraitIndustrialistTitle                                                  , 10));
            _primaryPolitics.Add(new PrimaryPolitics(PrimaryPoliticsType.PopulationPoliticalTraitPacifistTitle                                                       , 10));
            _primaryPolitics.Add(new PrimaryPolitics(PrimaryPoliticsType.PopulationPoliticalTraitScientificTitle                                                     , 10));
            _primaryPolitics.Add(new PrimaryPolitics(PrimaryPoliticsType.PopulationPoliticalTraitReligiousTitle                                                      , 10));
            _primaryPolitics.Add(new PrimaryPolitics(PrimaryPoliticsType.PopulationPoliticalTraitMilitaristTitle                                                     , 10));
            _primaryPolitics.Add(new PrimaryPolitics(PrimaryPoliticsType.PopulationPoliticalTraitEcologistTitle                                                      , 10));

            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitAntiEcologistTitle                                            , 10));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitAntiIndustrialistTitle                                        , 10));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitAntiMilitaristTitle                                           , 10));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitAntiPacifistTitle                                             , 10));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitAntiReligiousTitle                                            , 10));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitAntiScientistTitle                                            , 10));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitAggressiveTitle                                               ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitAtheistTitle                                                  ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitCuriousTitle                                                  ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitDiplomatTitle                                                 ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitEcologistToIndustrialistTitle                                 ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitEcologistToMilitaristTitle                                    ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitEcologistToReligiousTitle                                     ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitEcologistToScienceTitle                                       ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitFanaticTitle                                                  ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitHedonistTitle                                                 ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitIndustrialistToPacifistTitle                                  ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitIndustrialistToReligiousTitle                                 ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitIndustryToScienceTitle                                        ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitMercifulTitle                                                 ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitMilitaristToEcologistTitle                                    ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitMilitaristToReligiousTitle                                    ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitMilitaristToScientificTitle                                   ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitOptimisedTitle                                                ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitPacifistToEcologistTitle                                      ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitPacifistToIndustrialistTitle                                  ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitPiousTitle                                                    ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitPragmaticTitle                                                ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitRelativistTitle                                               ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitReligiousToEcologistTitle                                     ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitReligiousToIndustrialistTitle                                 ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitReligiousToMilitaristTitle                                    ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitReligiousToPacifistTitle                                      ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitReligiousToScientificTitle                                    ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitSagaciousTitle                                                ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitScientificToEcologistTitle                                    ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitScientificToIndustrialistTitle                                ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitScientificToPacifistTitle                                     ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitSearcherTitle                                                 ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitWarmongerTitle                                                ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitWaryTitle                                                     ,  5));
            _secondaryPolitics.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitXenophobicTitle                                               ,  5));

            _governments.Add(new Government(GovernmentType.GovernmentDemocracy,     10));
            _governments.Add(new Government(GovernmentType.GovernmentDictatorship,  10));
            _governments.Add(new Government(GovernmentType.GovernmentFederation,    10));
            _governments.Add(new Government(GovernmentType.GovernmentRepublic,      10));
            _governments.Add(new Government(GovernmentType.GovernmentAutocracy,     10));

            _tech.Add(new Tech(TechType.FactionTraitTechnologyDefinitionScienceAndExploration1       , 10));
            _tech.Add(new Tech(TechType.FactionTraitTechnologyDefinitionScienceAndExploration2       , 10));
            _tech.Add(new Tech(TechType.FactionTraitTechnologyDefinitionEconomyAndTrade1             , 10));
            _tech.Add(new Tech(TechType.FactionTraitTechnologyDefinitionEconomyAndTrade2             , 10));
            _tech.Add(new Tech(TechType.FactionTraitTechnologyDefinitionEmpireDevelopment1           , 10));
            _tech.Add(new Tech(TechType.FactionTraitTechnologyDefinitionEmpireDevelopment2           , 10));
            _tech.Add(new Tech(TechType.FactionTraitTechnologyDefinitionMilitary1                    , 10));
            _tech.Add(new Tech(TechType.FactionTraitTechnologyDefinitionMilitary2                    , 10));

        }

        List<GameplayAffinity>            _gameplayAffinity;
        List<VisualAffinity>              _visualAffinity;
        List<FactionTrait>                _factionTraits;
        List<HomePlanet>                  _homePlanets;
        List<Population>                  _populations;
        List<PrimaryPopulationModifier>   _primary;
        List<SecondaryPopulationModifier> _secondary;
        List<TertiaryPopulationModifier>  _tertiary;
        List<PrimaryPolitics>             _primaryPolitics;
        List<SecondaryPolitics>           _secondaryPolitics;
        List<Government>                  _governments;
        List<Tech>                        _tech;
    }
}
