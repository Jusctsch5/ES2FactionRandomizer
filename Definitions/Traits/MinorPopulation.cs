using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum MinorPopulationType
    {
        FactionTraitMinorAmoeba,
        FactionTraitMinorBenthys,
        FactionTraitMinorBhagabas,
        FactionTraitMinorBots,
        FactionTraitMinorDamage,
        FactionTraitMinorDeuyivans,
        FactionTraitMinorDiplomacy,
        FactionTraitMinorEyders,
        FactionTraitMinorGalvrans,
        FactionTraitMinorGreenman,
        FactionTraitMinorGnashasts,
        FactionTraitMinorHarmony,
        FactionTraitMinorHaroshems,
        FactionTraitMinorHisshos,
        FactionTraitMinorMavros,
        FactionTraitMinorNiris,
        FactionTraitMinorPilgrims,
        FactionTraitMinorPulsos,
        FactionTraitMinorRemnants,
        FactionTraitMinorTikanans,
        FactionTraitMinorZvali,
        FactionTraitMinorKalTikMas,        //  Updates
        FactionTraitMinorSowers,
        FactionTraitMinorSefaloros,
        FactionTraitMinorSistersOfMercy,   // Vaulters (DLC1)        
        FactionTraitMinorIllo,             // Hissho (DLC2)
        FactionTraitMinorMinorHacking,       // Umbral (DLC3)
        // FactionTraitMinorOraculars        // Nakalim (DLC4)
    }

    public class MinorPopulation : FactionSetting
    {
        public MinorPopulation(MinorPopulationType iType, int iScoreModifier) : base((int)iType, iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        public MinorPopulationType _type { get; set; }
    }
    public class MinorPopulationGroup : FactionSettingGroup
    {
        public void Initialize()
        {
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorAmoeba, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorBenthys, 10)); // Kalgeros
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorBhagabas, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorBots, 10));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorDamage, 10));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorDeuyivans, 10));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorDiplomacy, 10));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorEyders, 10));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorGalvrans, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorGreenman, 10)); // Amblyr
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorGnashasts, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorHarmony, 10));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorHaroshems, 10));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorHisshos, 5)); // Yuusho
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorMavros, 10));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorNiris, 10));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorPilgrims, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorPulsos, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorRemnants, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorTikanans, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorZvali, 10));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorKalTikMas, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorSowers, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorSefaloros, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorSistersOfMercy, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorIllo, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorMinorHacking, 5)); // Kalmat
        }
        public MinorPopulation GetRandomMinorPopulation(List<int> iExclusionList, int iPointValueLessThan)
        {
            return (MinorPopulation)GetRandomSettingFromGroup(iExclusionList, iPointValueLessThan);
        }

        public MinorPopulation GetRandomMinorPopulation(int iPointValueLessThan)
        {
            return (MinorPopulation)GetRandomSettingFromGroup(iPointValueLessThan);
        }
        public MinorPopulation GetRandomMinorPopulation()
        {
            return (MinorPopulation)GetRandomSettingFromGroup();
        }
    }

}
