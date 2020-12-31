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
        FactionTraitAceSenatorsTitle,
        FactionTraitAmateurExecutivesTitle,
        FactionTraitReducedTaxesTitle,
        FactionTraitApatheticColonistsTitle,
        FactionTraitBeamSpecializationTitle,
        FactionTraitBigBrothersTitle,
        FactionTraitBigFleets1Title,
        FactionTraitBigFleets2Title,
        FactionTraitBigSpenders1Title,
        FactionTraitBigSpenders2Title,
        FactionTraitBlackThumb1Title,
        FactionTraitBlackThumb2Title,
        FactionTraitBlockadeBreakersTitle,
        FactionTraitBrilliantStrategists1Title,
        FactionTraitBrilliantStrategists2Title,
        FactionTraitBuilders1Title,
        FactionTraitBuilders2Title,
        FactionTraitBuilders3Title,
        FactionTraitBurningColonizationTitle,
        FactionTraitBusinessmen1Title,
        FactionTraitBusinessmen2Title,
        FactionTraitBusinessmen3Title,
        FactionTraitCombatRookiesTitle,
        FactionTraitCombatSpecialistsTitle,
        FactionTraitConfidentTacticiansTitle,
        FactionTraitContentCitizens1Title,
        FactionTraitContentCitizens2Title,
        FactionTraitCowards1Title,
        FactionTraitCowards2Title,
        FactionTraitCrowdedPlanets1Title,
        FactionTraitCrowdedPlanets2Title,
        FactionTraitCulturalists1Title,
        FactionTraitCulturalists2Title,
        FactionTraitDeadlyWeapons1Title,
        FactionTraitDeadlyWeapons2Title,
        FactionTraitDiligentWorkersTitle,
        FactionTraitDisciplinedTitle,
        FactionTraitDoubtfulTacticiansTitle,
        FactionTraitDryFrozenColonizationTitle,
        FactionTraitEfficientExplorer1Title,
        FactionTraitEfficientExplorer2Title,
        FactionTraitEternalWarTitle,
        FactionTraitExpansionists1Title,
        FactionTraitExpansionists2Title,
        FactionTraitExtendedConsortiumTitle,
        FactionTraitFactionTraitSmoothTalkersTitle,
        FactionTraitUtopianInfrastructureTitle,
        FactionTraitFastTraveler1Title,
        FactionTraitFastTraveler2Title,
        FactionTraitFearlessWarriors1Title,
        FactionTraitFearlessWarriors2Title,
        FactionTraitFeebleWarriors1Title,
        FactionTraitFeebleWarriors2Title,
        FactionTraitFerventColonists1Title,
        FactionTraitFerventColonists2Title,
        FactionTraitFierceVigilantesTitle,
        FactionTraitFloodedTemperateColonizationTitle,
        FactionTraitFrailVigilantesTitle,
        FactionTraitFrozenColonizationTitle,
        FactionTraitGasColonizationTitle,
        FactionTraitGeneHunterTitle,
        FactionTraitGrowthPlan1Title,
        FactionTraitGrowthPlan2Title,
        FactionTraitGrowthPlan3Title,
        FactionTraitGuardiansTitle,
        FactionTraitHotWetColonizationTitle,
        FactionTraitHumaneWeaponsTitle,
        FactionTraitIneptTradersTitle,
        FactionTraitInimicalTitle,
        FactionTraitKineticSpecializationTitle,
        FactionTraitKingpinExecutivesTitle,
        FactionTraitLaserSpecializationTitle,
        FactionTraitLegendaryHeroes1Title,
        FactionTraitLegendaryHeroes2Title,
        FactionTraitLousySenatorsTitle,
        FactionTraitLuxuryConnoisseursTitle,
        FactionTraitLuxuryIgnoramusesTitle,
        FactionTraitMissileSpecializationTitle,
        FactionTraitMutualUnderstanding1Title,
        FactionTraitMutualUnderstanding2Title,
        FactionTraitNaive1Title,
        FactionTraitNaive2Title,
        FactionTraitOptimalDefense1Title,
        FactionTraitOptimalDefense2Title,
        FactionTraitOptimistic1Title,
        FactionTraitOptimistic2Title,
        FactionTraitPatriots1Title,
        FactionTraitPatriots2Title,
        FactionTraitPerfectGenes1Title,
        FactionTraitPerfectGenes2Title,
        FactionTraitPessimistic1Title,
        FactionTraitPessimistic2Title,
        FactionTraitPoorStrategists1Title,
        FactionTraitPoorStrategists2Title,
        FactionTraitPriceOfPerfection1Title,
        FactionTraitPriceOfPerfection2Title,
        FactionTraitProneToAgitationTitle,
        FactionTraitPushovers1Title,
        FactionTraitPushovers2Title,
        FactionTraitScanningTitle,
        FactionTraitScientists1Title,
        FactionTraitScientists2Title,
        FactionTraitScientists3Title,
        FactionTraitSkillfulTradersTitle,
        FactionTraitSlowTraveler1Title,
        FactionTraitSlowTraveler2Title,
        FactionTraitSocialChameleonsTitle,
        FactionTraitSpaceCadets1Title,
        FactionTraitSpaceCadets2Title,
        FactionTraitStartWithHyperiumTitle,
        FactionTraitStartWithNegativeAnomalyTitle,
        FactionTraitStartWithPositiveAnomalyTitle,
        FactionTraitStartWithTitaniumTitle,
        FactionTraitSubOptimalDefenseTitle,
        FactionTraitTemperateColonizationTitle,
        FactionTraitUniqueDictatorshipTitle,
        FactionTraitUnskilledBuilders1Title,
        FactionTraitUnskilledBuilders2Title,    
        FactionTraitSacredTraditionTitle,                                    // Hissho (DLC2)
        FactionTraitHisshosFestivalsTitle,
        FactionTraitMiningExpertsTitle,
        FactionTraitPirateHatersTitle,
        FactionTraitJuggernautSpecialistsTitle,
        FactionTraitStartWithJuggernautTitle,
        FactionTraitReducedManpowerFromFoodTitle,                            // Umbral Choir (DLC3)
        FactionTraitManpowerFromProcessingPowerTitle,
        FactionTraitBonusHackingRoutesTitle,
        FactionTraitBonusHackingSpeedTitle,
        FactionTraitNativelyInvisibleShipsTitle,
        FactionTraitProcessingPowerFromTraitorsTitle,
        FactionTraitTradePenaltyTitle,
        FactionTraitLuxuryCostModifierTitle,
        FactionTraitAntiExpansionistsTitle

        // Nakalim (DLC4)
        /*
        FactionTraitTechnologicalHeadStartTitle                ,
        FactionTraitScienceReductionTitle                      ,
        FactionTraitMinorBonusDamageOnAcademyTitle             ,
        FactionTraitMinorBonusContributionToAcademyTitle       ,
        FactionTraitMinorOracularsTitle
        */

    }

    public class FactionTrait : FactionSetting
    {
        public FactionTrait(FactionTraitType iType, int iScoreModifier) : base(iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        FactionTraitType _type { get; set; }
    }
    public class FactionTraitGroup : FactionSettingGroup
    {
        public void Initialize()
        {
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitAceSenatorsTitle, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitReducedTaxesTitle, 10)); // Alternative Imports
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitAmateurExecutivesTitle, -5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitApatheticColonistsTitle, -5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBigBrothersTitle, 5)); // Big Brothers
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBigFleets1Title, 15));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBigFleets2Title, 25));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBigSpenders1Title, -5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBigSpenders2Title, -10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBlackThumb1Title, -5)); // opp growth plan
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBlackThumb2Title, -10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBlockadeBreakersTitle, 15));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBrilliantStrategists1Title, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBrilliantStrategists2Title, 20));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBuilders1Title, 10)); // Constructionists
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBuilders2Title, 25)); // Constructionists II
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBuilders3Title, 40)); // Constructionists III
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBusinessmen1Title, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBusinessmen2Title, 25));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBusinessmen3Title, 40));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitCombatRookiesTitle, -10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitCombatSpecialistsTitle, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitConfidentTacticiansTitle, 5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitContentCitizens1Title, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitContentCitizens2Title, 15));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitCowards1Title, -5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitCowards2Title, -10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitCrowdedPlanets1Title, 15));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitCrowdedPlanets2Title, 40));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitCulturalists1Title, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitCulturalists2Title, 20));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitDeadlyWeapons1Title, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitDeadlyWeapons2Title, 20));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitDisciplinedTitle, 5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitDoubtfulTacticiansTitle, -5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitEfficientExplorer1Title, 5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitEfficientExplorer2Title, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitEternalWarTitle, -15));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitExpansionists1Title, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitExpansionists2Title, 25));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitExtendedConsortiumTitle, 15));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitFactionTraitSmoothTalkersTitle, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitUtopianInfrastructureTitle, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitFastTraveler1Title, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitFastTraveler2Title, 25));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitFearlessWarriors1Title, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitFearlessWarriors2Title, 20));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitFeebleWarriors1Title, -5)); // opp. fearless warriors
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitFeebleWarriors2Title, -10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitFerventColonists1Title, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitFerventColonists2Title, 15));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitGrowthPlan1Title, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitGrowthPlan2Title, 25));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitGrowthPlan3Title, 40));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitGuardiansTitle, 40));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitHumaneWeaponsTitle, -5)); // opp. deadly weapons
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitIneptTradersTitle, 10)); // opp. skilled traders
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitInimicalTitle, 10)); // biophobic
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitKingpinExecutivesTitle, 10)); // opp. Amateur Executives
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitLegendaryHeroes1Title, 15));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitLegendaryHeroes2Title, 30));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitLousySenatorsTitle, -5)); // opp. Ace senators
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitLuxuryConnoisseursTitle, 10)); // oop. Luxury Ignoramuses
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitLuxuryIgnoramusesTitle, -5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitMutualUnderstanding1Title, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitMutualUnderstanding2Title, 15));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitNaive1Title, 5)); // Harmonious
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitNaive2Title, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitOptimalDefense1Title, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitOptimalDefense2Title, 20));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitOptimistic1Title, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitOptimistic2Title, 25));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPatriots1Title, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPatriots2Title, 15));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPerfectGenes1Title, 5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPerfectGenes2Title, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPessimistic1Title, -10)); // Vexed I, opp. Optimistic
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPessimistic2Title, -25));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPoorStrategists1Title, -5)); // opp. Brilliant Strategists
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPoorStrategists2Title, -10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPriceOfPerfection1Title, -5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPriceOfPerfection2Title, -10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitProneToAgitationTitle, -5));  // opp. Disciplined
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPushovers1Title, -5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPushovers2Title, -10));// opp. Culturalists
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitScanningTitle, 25)); // Pathfinder
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitScientists1Title, 10)); // rational minds
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitScientists2Title, 25));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitScientists3Title, 40));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitSkillfulTradersTitle, 20)); // Inept Traders
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitSlowTraveler1Title, -10)); // wary Travelers opp. Fast traveler
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitSlowTraveler2Title, -25));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitSocialChameleonsTitle, 15));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitSpaceCadets1Title, -5)); // rational minds
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitSpaceCadets2Title, -10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitStartWithNegativeAnomalyTitle, 10)); // strange but bad. opp strange but good
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitStartWithPositiveAnomalyTitle, 10)); // strange but good. opp strange but bad
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitStartWithHyperiumTitle, 10)); // hyperium mine
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitStartWithTitaniumTitle, 10)); // titanium mine
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitSubOptimalDefenseTitle, -5)); // opp. optimal defense
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitUnskilledBuilders1Title, -5)); // opp.  constructionists
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitUnskilledBuilders2Title, -10));
            
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitSacredTraditionTitle, 10));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitHisshosFestivalsTitle, 10)); // observances
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitMiningExpertsTitle, 5)); // Resource Recoverers
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitPirateHatersTitle, 5));
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitJuggernautSpecialistsTitle, 5)); // Behemoth Builders
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitStartWithJuggernautTitle, 10)); // Behemoth Discoverer
             
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitReducedManpowerFromFoodTitle, -5)); // Immaterial Population
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitManpowerFromProcessingPowerTitle, 10)); // Dark Matter Manipulators
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBonusHackingRoutesTitle, 5)); // Organic Network
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitBonusHackingSpeedTitle, 10)); // Twitch Infiltrators
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitNativelyInvisibleShipsTitle, 10)); // Ghosts
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitProcessingPowerFromTraitorsTitle, 10)); // Exploited Sleepers
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitTradePenaltyTitle, 10)); // Fledgling Traders
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitLuxuryCostModifierTitle, -10)); // Expensive Tastes
            _settingGroup.Add(new FactionTrait(FactionTraitType.FactionTraitAntiExpansionistsTitle, -20)); // Stay-at-Home

            //_factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitDiligentWorkersTitle                 ,   10));
            // _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitFierceVigilantesTitle                ,   10));
            // _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitFrailVigilantesTitle                 ,   10));
            // _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitUniqueDictatorshipTitle              ,   10)); // Absolute totalitatianisms

            //_factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBeamSpecializationTitle              ,   10)); // Beam weapons???
            // _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitKineticSpecializationTitle           ,   10)); //  Kinetic weapons
            // _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitLaserSpecializationTitle             ,   10));
            // _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitMissileSpecializationTitle           ,   10));

            //_factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitBurningColonizationTitle             ,   10)); // Hot Blooded
            //_factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitDryFrozenColonizationTitle           ,   10)); // Don't fear the freezer
            // _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitFloodedTemperateColonizationTitle    ,   10));
            // _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitFrozenColonizationTitle              ,   10));
            // _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitGasColonizationTitle                 ,   10));
            //_factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitHotWetColonizationTitle              ,   10));
            // _factionTraits.Add(new FactionTrait(FactionTraitType.FactionTraitTemperateColonizationTitle           ,   10));
        }
        public FactionTrait GetRandomFactionTrait(List<int> iExclusionList, int iPointValueLessThan)
        {
            return (FactionTrait)GetRandomSettingFromGroup(iExclusionList, iPointValueLessThan);
        }

        public FactionTrait GetRandomFactionTrait(int iPointValueLessThan)
        {
            return (FactionTrait)GetRandomSettingFromGroup(iPointValueLessThan);
        }
        public FactionTrait GetRandomFactionTrait()
        {
            return (FactionTrait)GetRandomSettingFromGroup();
        }
    }

}
