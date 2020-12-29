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
        public TertiaryPopulationModifier(TertiaryPopulationModifierType iType, int iScoreModifier) : base(iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        TertiaryPopulationModifierType _type { get; set; }
    }
}
