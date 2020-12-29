using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum TechType
    {
        FactionTraitTechnologyDefinitionScienceAndExploration1,
        FactionTraitTechnologyDefinitionScienceAndExploration2,
        FactionTraitTechnologyDefinitionEconomyAndTrade1,
        FactionTraitTechnologyDefinitionEconomyAndTrade2,
        FactionTraitTechnologyDefinitionEmpireDevelopment1,
        FactionTraitTechnologyDefinitionEmpireDevelopment2,
        FactionTraitTechnologyDefinitionMilitary1,
        FactionTraitTechnologyDefinitionMilitary2,
        // FactionTraitTechnologyDefinitionEmpireDevelopment1Horatio
    }

    public class Tech : FactionSetting
    {
        public Tech(TechType iType, int iScoreModifier) : base(iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        TechType _type { get; set; }
    }
}
