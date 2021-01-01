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
        PopulationCollectionBonusTraitSophonTitle                              ,
        PopulationCollectionBonusTraitCraverTitle                              ,
        PopulationCollectionBonusTraitVenetianTitle                            ,
        PopulationCollectionBonusTraitVampirilisTitle                          ,
        PopulationCollectionBonusTraitSheredynTitle                            ,
        PopulationCollectionBonusTraitTerransTitle                             ,
        PopulationCollectionBonusTraitHoratioTitle                             ,
        PopulationCollectionBonusTraitTimeLordsTitle                           ,
        PopulationCollectionBonusTraitUnfallenTitle                            ,
        PopulationCollectionBonusTraitCustomFactionScienceDefenseTitle         , // Vaulters (DLC1)
        PopulationCollectionBonusTraitCustomFactionManpowerProductionCostTitle , // Hissho (DLC2)
        PopulationCollectionBonusTraitUmbralChoirTitle                         , // Umbral Choir (DLC3)
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
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitSophonTitle, 10));
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitCraverTitle, 10));
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitVenetianTitle, 10));
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitVampirilisTitle, 10));
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitSheredynTitle, 10));
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitTerransTitle, 10));
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitHoratioTitle, 10));
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitTimeLordsTitle, 10));
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitUnfallenTitle, 10));
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitCustomFactionScienceDefenseTitle, 10));
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitCustomFactionManpowerProductionCostTitle, 10));
            _settingGroup.Add(new TertiaryPopulationModifier(TertiaryPopulationModifierType.PopulationCollectionBonusTraitUmbralChoirTitle, 10));
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
