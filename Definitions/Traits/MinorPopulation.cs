using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum MinorPopulationType
    {
        FactionTraitMinorAmoebaTitle,
        FactionTraitMinorBenthysTitle,
        FactionTraitMinorBhagabasTitle,
        FactionTraitMinorBotsTitle,
        FactionTraitMinorDamageTitle,
        FactionTraitMinorDeuyivansTitle,
        FactionTraitMinorDiplomacyTitle,
        FactionTraitMinorEydersTitle,
        FactionTraitMinorGalvransTitle,
        FactionTraitMinorGreenmanTitle,
        FactionTraitMinorGnashastsTitle,
        FactionTraitMinorHarmonyTitle,
        FactionTraitMinorHaroshemsTitle,
        FactionTraitMinorHisshosTitle,
        FactionTraitMinorMavrosTitle,
        FactionTraitMinorNirisTitle,
        FactionTraitMinorPilgrimsTitle,
        FactionTraitMinorPulsosTitle,
        FactionTraitMinorRemnantsTitle,
        FactionTraitMinorTikanansTitle,
        FactionTraitMinorZvaliTitle,
        FactionTraitMinorKalTikMasTitle,        //  Updates
        FactionTraitMinorSowersTitle,
        FactionTraitMinorSefalorosTitle,
        FactionTraitMinorSistersOfMercyTitle,   // Vaulters (DLC1)        
        FactionTraitMinorIlloTitle,             // Hissho (DLC2)
        FactionTraitMinorMinorHackingTitle,       // Umbral (DLC3)
        // FactionTraitMinorOracularsTitle        // Nakalim (DLC4)
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
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorAmoebaTitle, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorBenthysTitle, 10)); // Kalgeros
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorBhagabasTitle, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorBotsTitle, 10));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorDamageTitle, 10));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorDeuyivansTitle, 10));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorDiplomacyTitle, 10));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorEydersTitle, 10));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorGalvransTitle, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorGreenmanTitle, 10)); // Amblyr
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorGnashastsTitle, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorHarmonyTitle, 10));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorHaroshemsTitle, 10));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorHisshosTitle, 5)); // Yuusho
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorMavrosTitle, 10));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorNirisTitle, 10));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorPilgrimsTitle, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorPulsosTitle, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorRemnantsTitle, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorTikanansTitle, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorZvaliTitle, 10));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorKalTikMasTitle, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorSowersTitle, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorSefalorosTitle, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorSistersOfMercyTitle, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorIlloTitle, 5));
            _settingGroup.Add(new MinorPopulation(MinorPopulationType.FactionTraitMinorMinorHackingTitle, 5)); // Kalmat
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
