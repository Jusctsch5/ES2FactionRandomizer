using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum FactionTraitType
    {
        // Base Game
        FactionTraitAceSenators,
        FactionTraitAmateurExecutives,
        FactionTraitReducedTaxes,
        FactionTraitApatheticColonists,
        FactionTraitBeamSpecialization,
        FactionTraitBigBrothers,
        FactionTraitBigFleets1,
        FactionTraitBigFleets2,
        FactionTraitBigSpenders1,
        FactionTraitBigSpenders2,
        FactionTraitBlackThumb1,
        FactionTraitBlackThumb2,
        FactionTraitBlockadeBreakers,
        FactionTraitBrilliantStrategists1,
        FactionTraitBrilliantStrategists2,
        FactionTraitBuilders1,
        FactionTraitBuilders2,
        FactionTraitBuilders3,
        FactionTraitBurningColonization,
        FactionTraitBusinessmen1,
        FactionTraitBusinessmen2,
        FactionTraitBusinessmen3,
        FactionTraitCombatRookies,
        FactionTraitCombatSpecialists,
        FactionTraitConfidentTacticians,
        FactionTraitContentCitizens1,
        FactionTraitContentCitizens2,
        FactionTraitCowards1,
        FactionTraitCowards2,
        FactionTraitCrowdedPlanets1,
        FactionTraitCrowdedPlanets2,
        FactionTraitCulturalists1,
        FactionTraitCulturalists2,
        FactionTraitDeadlyWeapons1,
        FactionTraitDeadlyWeapons2,
        FactionTraitDiligentWorkers,
        FactionTraitDisciplined,
        FactionTraitDoubtfulTacticians,
        FactionTraitDryFrozenColonization,
        FactionTraitEfficientExplorer1,
        FactionTraitEfficientExplorer2,
        FactionTraitEternalWar,
        FactionTraitExpansionists1,
        FactionTraitExpansionists2,
        FactionTraitExtendedConsortium,
        FactionTraitFactionTraitSmoothTalkers,
        FactionTraitUtopianInfrastructure,
        FactionTraitFastTraveler1,
        FactionTraitFastTraveler2,
        FactionTraitFearlessWarriors1,
        FactionTraitFearlessWarriors2,
        FactionTraitFeebleWarriors1,
        FactionTraitFeebleWarriors2,
        FactionTraitFerventColonists1,
        FactionTraitFerventColonists2,
        FactionTraitFierceVigilantes,
        FactionTraitFloodedTemperateColonization,
        FactionTraitFrailVigilantes,
        FactionTraitFrozenColonization,
        FactionTraitGasColonization,
        FactionTraitGeneHunter,
        FactionTraitGrowthPlan1,
        FactionTraitGrowthPlan2,
        FactionTraitGrowthPlan3,
        FactionTraitGuardians,
        FactionTraitHotWetColonization,
        FactionTraitHumaneWeapons,
        FactionTraitIneptTraders,
        FactionTraitInimical,
        FactionTraitKineticSpecialization,
        FactionTraitKingpinExecutives,
        FactionTraitLaserSpecialization,
        FactionTraitLegendaryHeroes1,
        FactionTraitLegendaryHeroes2,
        FactionTraitLousySenators,
        FactionTraitLuxuryConnoisseurs,
        FactionTraitLuxuryIgnoramuses,
        FactionTraitMissileSpecialization,
        FactionTraitMutualUnderstanding1,
        FactionTraitMutualUnderstanding2,
        FactionTraitNaive1,
        FactionTraitNaive2,
        FactionTraitOptimalDefense1,
        FactionTraitOptimalDefense2,
        FactionTraitOptimistic1,
        FactionTraitOptimistic2,
        FactionTraitPatriots1,
        FactionTraitPatriots2,
        FactionTraitPerfectGenes1,
        FactionTraitPerfectGenes2,
        FactionTraitPessimistic1,
        FactionTraitPessimistic2,
        FactionTraitPoorStrategists1,
        FactionTraitPoorStrategists2,
        FactionTraitPriceOfPerfection1,
        FactionTraitPriceOfPerfection2,
        FactionTraitProneToAgitation,
        FactionTraitPushovers1,
        FactionTraitPushovers2,
        FactionTraitScanning,
        FactionTraitScientists1,
        FactionTraitScientists2,
        FactionTraitScientists3,
        FactionTraitSkillfulTraders,
        FactionTraitSlowTraveler1,
        FactionTraitSlowTraveler2,
        FactionTraitSocialChameleons,
        FactionTraitSpaceCadets1,
        FactionTraitSpaceCadets2,
        FactionTraitStartWithHyperium,
        FactionTraitStartWithNegativeAnomaly,
        FactionTraitStartWithPositiveAnomaly,
        FactionTraitStartWithTitanium,
        FactionTraitCorsairs,
        FactionTraitCoreWorlds,
        FactionTraitFactionTraitManualHomeSystem,
        FactionTraitSubOptimalDefense,
        FactionTraitTemperateColonization,
        FactionTraitUniqueDictatorship,
        FactionTraitUnskilledBuilders1,
        FactionTraitUnskilledBuilders2,    
        FactionTraitSacredTradition,                                    // Hissho (DLC2)
        FactionTraitHisshosFestivals,
        FactionTraitMiningExperts,
        FactionTraitPirateHaters,
        FactionTraitJuggernautSpecialists,
        FactionTraitStartWithJuggernaut,
        FactionTraitReducedManpowerFromFood,                            // Umbral Choir (DLC3)
        FactionTraitManpowerFromProcessingPower,
        FactionTraitBonusHackingRoutes,
        FactionTraitBonusHackingSpeed,
        FactionTraitNativelyInvisibleShips,
        FactionTraitNativeObliteratorProtection,
        FactionTraitProcessingPowerFromTraitors,
        FactionTraitTradePenalty,
        FactionTraitLuxuryCostModifier,
        FactionTraitAntiExpansionists

        // Nakalim (DLC4)
        /*
        FactionTraitTechnologicalHeadStart                ,
        FactionTraitScienceReduction                      ,
        FactionTraitMinorBonusDamageOnAcademy             ,
        FactionTraitMinorBonusContributionToAcademy       ,
        FactionTraitMinorOraculars
        */

    }

    public class FactionTrait : FactionSetting
    {
        public FactionTrait(FactionTraitType iType, int iScoreModifier) : base((int)iType, iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        public FactionTraitType _type { get; set; }

        
    }
    public class FactionTraitGroup : FactionSettingGroup
    {
        public void Initialize()
        {
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitAceSenators, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitReducedTaxes, 10)); // Alternative Imports
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitAmateurExecutives, -5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitApatheticColonists, -5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBigBrothers, 5)); // Big Brothers
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBigFleets1, 15));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBigFleets2, 25));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBigSpenders1, -5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBigSpenders2, -10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBlackThumb1, -5)); // opp growth plan
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBlackThumb2, -10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBlockadeBreakers, 15));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBrilliantStrategists1, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBrilliantStrategists2, 20));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBuilders1, 10)); // Constructionists
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBuilders2, 25)); // Constructionists II
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBuilders3, 40)); // Constructionists III
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBusinessmen1, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBusinessmen2, 25));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBusinessmen3, 40));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitCombatRookies, -10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitCombatSpecialists, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitConfidentTacticians, 5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitContentCitizens1, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitContentCitizens2, 15));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitCowards1, -5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitCowards2, -10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitCrowdedPlanets1, 15));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitCrowdedPlanets2, 40));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitCulturalists1, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitCulturalists2, 20));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitDeadlyWeapons1, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitDeadlyWeapons2, 20));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitDisciplined, 5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitDoubtfulTacticians, -5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitEfficientExplorer1, 5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitEfficientExplorer2, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitEternalWar, -15));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitExpansionists1, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitExpansionists2, 25));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitExtendedConsortium, 15));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitFactionTraitSmoothTalkers, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitUtopianInfrastructure, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitFastTraveler1, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitFastTraveler2, 25));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitFearlessWarriors1, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitFearlessWarriors2, 20));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitFeebleWarriors1, -5)); // opp. fearless warriors
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitFeebleWarriors2, -10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitFerventColonists1, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitFerventColonists2, 15));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitGrowthPlan1, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitGrowthPlan2, 25));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitGrowthPlan3, 40));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitGuardians, 40));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitHumaneWeapons, -5)); // opp. deadly weapons
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitIneptTraders, -10)); // opp. skilled traders
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitInimical, 10)); // biophobic
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitKingpinExecutives, 10)); // opp. Amateur Executives
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitLegendaryHeroes1, 15));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitLegendaryHeroes2, 30));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitLousySenators, -5)); // opp. Ace senators
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitLuxuryConnoisseurs, 10)); // oop. Luxury Ignoramuses
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitLuxuryIgnoramuses, -5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitMutualUnderstanding1, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitMutualUnderstanding2, 15));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitNaive1, 5)); // Harmonious
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitNaive2, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitOptimalDefense1, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitOptimalDefense2, 20));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitOptimistic1, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitOptimistic2, 25));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPatriots1, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPatriots2, 15));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPerfectGenes1, 5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPerfectGenes2, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPessimistic1, -10)); // Vexed I, opp. Optimistic
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPessimistic2, -25));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPoorStrategists1, -5)); // opp. Brilliant Strategists
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPoorStrategists2, -10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPriceOfPerfection1, -5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPriceOfPerfection2, -10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitProneToAgitation, -5));  // opp. Disciplined
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPushovers1, -5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPushovers2, -10));// opp. Culturalists
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitScanning, 25)); // Pathfinder
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitScientists1, 10)); // rational minds
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitScientists2, 25));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitScientists3, 40));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitSkillfulTraders, 20)); // Inept Traders
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitSlowTraveler1, -10)); // wary Travelers opp. Fast traveler
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitSlowTraveler2, -25));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitSocialChameleons, 15));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitSpaceCadets1, -5)); // rational minds
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitSpaceCadets2, -10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitStartWithNegativeAnomaly, 10)); // strange but bad. opp strange but good
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitStartWithPositiveAnomaly, 10)); // strange but good. opp strange but bad
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitStartWithHyperium, 10)); // hyperium mine
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitStartWithTitanium, 10)); // titanium mine
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitCorsairs, 5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitCoreWorlds, 10)); // Core Worlds
            
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitFactionTraitManualHomeSystem, 10));

            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitSubOptimalDefense, -5)); // opp. optimal defense
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitUnskilledBuilders1, -5)); // opp.  constructionists
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitUnskilledBuilders2, -10));
            
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitSacredTradition, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitHisshosFestivals, 10)); // observances
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitMiningExperts, 5)); // Resource Recoverers
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPirateHaters, 5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitJuggernautSpecialists, 5)); // Behemoth Builders
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitStartWithJuggernaut, 10)); // Behemoth Discoverer
             
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitReducedManpowerFromFood, -5)); // Immaterial Population
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitManpowerFromProcessingPower, 10)); // Dark Matter Manipulators
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBonusHackingRoutes, 5)); // Organic Network
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBonusHackingSpeed, 10)); // Twitch Infiltrators
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitNativelyInvisibleShips, 10)); // Ghosts
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitNativeObliteratorProtection, 10)); // Resilient            
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitProcessingPowerFromTraitors, 10)); // Exploited Sleepers
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitTradePenalty, 10)); // Fledgling Traders
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitLuxuryCostModifier, -10)); // Expensive Tastes
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitAntiExpansionists, -20)); // Stay-at-Home

            //_factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitDiligentWorkers                 ,   10));
            // _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitFierceVigilantes                ,   10));
            // _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitFrailVigilantes                 ,   10));
            // _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitUniqueDictatorship              ,   10)); // Absolute totalitatianisms

            //_factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBeamSpecialization              ,   10)); // Beam weapons???
            // _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitKineticSpecialization           ,   10)); //  Kinetic weapons
            // _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitLaserSpecialization             ,   10));
            // _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitMissileSpecialization           ,   10));

            //_factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBurningColonization             ,   10)); // Hot Blooded
            //_factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitDryFrozenColonization           ,   10)); // Don't fear the freezer
            // _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitFloodedTemperateColonization    ,   10));
            // _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitFrozenColonization              ,   10));
            // _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitGasColonization                 ,   10));
            //_factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitHotWetColonization              ,   10));
            // _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitTemperateColonization           ,   10));

            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitAceSenators,
                                           (int)FactionTraitType.FactionTraitLousySenators });

            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitApatheticColonists,
                                           (int)FactionTraitType.FactionTraitFerventColonists1,
                                           (int)FactionTraitType.FactionTraitFerventColonists2 });

            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitAmateurExecutives, 
                                           (int)FactionTraitType.FactionTraitKingpinExecutives });

            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitBigFleets1, 
                                           (int)FactionTraitType.FactionTraitBigFleets2 });

            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitBigSpenders1,
                                           (int)FactionTraitType.FactionTraitBigSpenders2,
                                           (int)FactionTraitType.FactionTraitBusinessmen1,
                                           (int)FactionTraitType.FactionTraitBusinessmen2,
                                           (int)FactionTraitType.FactionTraitBusinessmen3 });

            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitGrowthPlan1,
                                           (int)FactionTraitType.FactionTraitGrowthPlan2,
                                           (int)FactionTraitType.FactionTraitGrowthPlan3,
                                           (int)FactionTraitType.FactionTraitBlackThumb1,
                                           (int)FactionTraitType.FactionTraitBlackThumb2});

            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitBrilliantStrategists1,
                                           (int)FactionTraitType.FactionTraitBrilliantStrategists2,
                                           (int)FactionTraitType.FactionTraitPoorStrategists1,
                                           (int)FactionTraitType.FactionTraitPoorStrategists2});

            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitConfidentTacticians,
                                           (int)FactionTraitType.FactionTraitDoubtfulTacticians});

            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitBuilders1,
                                           (int)FactionTraitType.FactionTraitBuilders2,
                                           (int)FactionTraitType.FactionTraitBuilders3,
                                           (int)FactionTraitType.FactionTraitUnskilledBuilders1,
                                           (int)FactionTraitType.FactionTraitUnskilledBuilders2});

            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitContentCitizens1,
                                           (int)FactionTraitType.FactionTraitContentCitizens2});

            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitCorsairs,
                                           (int)FactionTraitType.FactionTraitPirateHaters});

            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitCombatRookies,
                                           (int)FactionTraitType.FactionTraitCombatSpecialists});

            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitDeadlyWeapons1,
                                           (int)FactionTraitType.FactionTraitDeadlyWeapons2,
                                           (int)FactionTraitType.FactionTraitHumaneWeapons});

            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitEfficientExplorer1,
                                           (int)FactionTraitType.FactionTraitEfficientExplorer2});

            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitEfficientExplorer1,
                                           (int)FactionTraitType.FactionTraitEfficientExplorer2});

            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitExpansionists1,
                                           (int)FactionTraitType.FactionTraitExpansionists2});

            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitFastTraveler1,
                                           (int)FactionTraitType.FactionTraitFastTraveler2,
                                           (int)FactionTraitType.FactionTraitSlowTraveler1,
                                           (int)FactionTraitType.FactionTraitSlowTraveler2});

            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitFearlessWarriors1,
                                           (int)FactionTraitType.FactionTraitFearlessWarriors2,
                                           (int)FactionTraitType.FactionTraitFeebleWarriors1,
                                           (int)FactionTraitType.FactionTraitFeebleWarriors2});

            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitNaive1,
                                           (int)FactionTraitType.FactionTraitNaive2 });

            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitIneptTraders,
                                           (int)FactionTraitType.FactionTraitSkillfulTraders});

            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitLegendaryHeroes1,
                                           (int)FactionTraitType.FactionTraitLegendaryHeroes2});
            
            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitLuxuryConnoisseurs,
                                           (int)FactionTraitType.FactionTraitLuxuryIgnoramuses});


            AddExclusivity(new List<int> { (int)FactionTraitType.FactionTraitOptimalDefense1,
                                           (int)FactionTraitType.FactionTraitOptimalDefense2,
                                           (int)FactionTraitType.FactionTraitSubOptimalDefense});

            AddExclusivity(new List<int> {(int)FactionTraitType.FactionTraitOptimistic1,
                                          (int)FactionTraitType.FactionTraitOptimistic2,
                                          (int)FactionTraitType.FactionTraitPessimistic1,
                                          (int)FactionTraitType.FactionTraitPessimistic2});

            AddExclusivity(new List<int> {(int)FactionTraitType.FactionTraitFactionTraitManualHomeSystem,
                                          (int)FactionTraitType.FactionTraitFerventColonists1,
                                          (int)FactionTraitType.FactionTraitFerventColonists2,
                                          (int)FactionTraitType.FactionTraitApatheticColonists});



            

        }
        public FactionTrait GetRandomFactionTrait(List<int> iExclusionList, int iPointValueLessThan)
        {
            return (FactionTrait)GetRandomSettingFromGroup(iExclusionList, iPointValueLessThan);
        }

        public FactionTrait GetRandomFactionTrait()
        {
            return (FactionTrait)GetRandomSettingFromGroup();
        }

        public FactionTrait GetRandomFactionTraitMinPoints(List<int> iExclusionList, int iMinPoints)
        {
            return (FactionTrait)GetRandomSettingMinPoints(iExclusionList, iMinPoints);
        }

        public FactionTrait GetRandomFactionTraitRange(List<int> iExclusionList, int iMinPoints, int iMaxPoints)
        {
            return (FactionTrait)GetRandomSettingRange(iExclusionList, iMinPoints, iMaxPoints);
        }
    }
}