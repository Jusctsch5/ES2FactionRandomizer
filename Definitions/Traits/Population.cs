using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum PopulationTraitType
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

    public class Population : FactionSetting
    {
        public Population(PopulationTraitType iType, int iScoreModifier) : base(iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        PopulationTraitType _type { get; set; }
    }
}
