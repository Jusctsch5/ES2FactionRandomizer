using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum TertiaryPopulationModifierType
    {
        // Base Game
        PopulationCollectionBonusTraitNone,
        PopulationCollectionBonusTraitCustomFactionScience                              ,
        PopulationCollectionBonusTraitCustomFactionWar                              ,
        PopulationCollectionBonusTraitCustomFactionDust                            ,
        PopulationCollectionBonusTraitCustomFactionFIDSI                          ,
        PopulationCollectionBonusTraitCustomFactionInfluence                            ,
        PopulationCollectionBonusTraitCustomFactionFood,
        PopulationCollectionBonusTraitCustomFactionIndustry,
        PopulationCollectionBonusTraitCustomFactionPeace,
        PopulationCollectionBonusTraitCustomFactionScienceDefense         , // Vaulters (DLC1)
        PopulationCollectionBonusTraitCustomFactionManpowerProductionCost , // Hissho (DLC2)
        PopulationCollectionBonusTraitCustomFactionHacking, // Umbral Choir (DLC3)
                                                                            // Nakalim (DLC4)
    }

    public class TertiaryPopulationModifier : FactionSetting
    {
        public TertiaryPopulationModifier(TertiaryPopulationModifierType iType, int iScoreModifier) : base((int)iType, iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        public TertiaryPopulationModifierType _type { get; set; }
    }

    public class TertiaryPopulationModifierGroup : FactionSettingGroup
    {
        public void Initialize()
        {
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitCustomFactionScience, 10));
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitCustomFactionWar, 10));
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitCustomFactionDust, 10));
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitCustomFactionFIDSI, 10));
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitCustomFactionInfluence, 10));
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitCustomFactionFood, 10));
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitCustomFactionIndustry, 10));
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitCustomFactionPeace, 10));
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitCustomFactionScienceDefense, 10));
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitCustomFactionManpowerProductionCost, 10));
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitCustomFactionHacking, 10));

        }
        public TertiaryPopulationModifier GetRandomTertiaryPopulationModifier(List<int> iExclusionList, int iPointValueLessThan)
        {
            return (TertiaryPopulationModifier)GetRandomSettingFromGroup(iExclusionList, iPointValueLessThan);
        }

        public TertiaryPopulationModifier GetRandomTertiaryPopulationModifier(int iPointValueLessThan)
        {
            return (TertiaryPopulationModifier)GetRandomSettingFromGroup(iPointValueLessThan);
        }
        public TertiaryPopulationModifier GetRandomTertiaryPopulationModifier()
        {
            return (TertiaryPopulationModifier)GetRandomSettingFromGroup();
        }
        
    }
}
