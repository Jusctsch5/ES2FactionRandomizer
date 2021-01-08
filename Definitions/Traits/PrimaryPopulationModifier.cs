using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum PrimaryPopulationModifierTraitType
    {
        PopulationModifiersTraitPrimaryNone,
        PopulationModifiersTraitPrimaryScience01,   // Base Game
        PopulationModifiersTraitPrimaryDepletionFIDS,
        PopulationModifiersTraitPrimaryDust,
        PopulationModifiersTraitPrimarySlowGrowthFIDS,
        PopulationModifiersTraitPrimaryInfluence,
        PopulationModifiersTraitPrimaryDefense,
        PopulationModifiersTraitPrimaryHappiness,
        PopulationModifiersTraitPrimaryIDS,
        PopulationModifiersTraitPrimaryFIDSI,
        PopulationModifiersTraitPrimaryFood03,
        PopulationModifiersTraitPrimaryFood01,
        PopulationModifiersTraitPrimaryIndustry,
        PopulationModifiersTraitPrimaryScience02,
        PopulationModifiersTraitPrimaryFood02,
        PopulationModifiersTraitPrimaryManpower,
        PopulationModifiersTraitPrimaryGroundBattleAttackerDamage,
        PopulationModifiersTraitPrimaryProcessingPower01,
        PopulationModifiersTraitPrimaryStrategicToFood01,   
        // PopulationModifiersTraitPrimaryHappinessTemple       ,   // Nakalim (DLC4)
    }

    public class PrimaryPopulationModifier : FactionSetting
    {
        public PrimaryPopulationModifier(PrimaryPopulationModifierTraitType iType, int iScoreModifier) : base((int)iType, iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        public PrimaryPopulationModifierTraitType _type { get; set; }
    }
    public class PrimaryPopulationModifierGroup : FactionSettingGroup
    {
        public void Initialize()
        {
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryScience01, 5));
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryDepletionFIDS, 15));
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryDust, 5));
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimarySlowGrowthFIDS, 15));
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryInfluence, 5));
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryDefense, 5));
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryHappiness, 5));
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryIDS, 15));
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryFIDSI, 15));
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryFood03, 15));
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryFood01, 5));
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryIndustry, 5));
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryScience02, 10));
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryFood02, 10));
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryManpower, 10));
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryGroundBattleAttackerDamage, 5));
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryProcessingPower01, 5)); 
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryStrategicToFood01, 5));
        }
        public PrimaryPopulationModifier GetRandomPrimaryPopulationModifier(List<int> iExclusionList, int iPointValueLessThan)
        {
            return (PrimaryPopulationModifier)GetRandomSettingFromGroup(iExclusionList, iPointValueLessThan);
        }

        public PrimaryPopulationModifier GetRandomPrimaryPopulationModifier(int iPointValueLessThan)
        {
            return (PrimaryPopulationModifier)GetRandomSettingFromGroup(iPointValueLessThan);
        }
        public PrimaryPopulationModifier GetRandomPrimaryPopulationModifier()
        {
            return (PrimaryPopulationModifier)GetRandomSettingFromGroup();
        }
    }
}
