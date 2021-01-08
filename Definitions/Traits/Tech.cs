using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum TechType
    {
        FactionTraitTechnologyDefinitionScienceAndExploration1    ,
        FactionTraitTechnologyDefinitionScienceAndExploration2    ,
        FactionTraitTechnologyDefinitionEconomyAndTrade1          ,
        FactionTraitTechnologyDefinitionEconomyAndTrade2          ,
        FactionTraitTechnologyDefinitionEmpireDevelopment1        ,
        FactionTraitTechnologyDefinitionEmpireDevelopment2        ,
        FactionTraitTechnologyDefinitionMilitary1                 ,
        FactionTraitTechnologyDefinitionMilitary2                 ,
    }

    public class Tech : FactionSetting
    {
        public Tech(TechType iType, int iScoreModifier) : base((int)iType, iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        public TechType _type { get; set; }
    }

    public class TechGroup : FactionSettingGroup
    {
        public void Initialize()
        {
            _settingGroup.Add(new Tech(TechType.FactionTraitTechnologyDefinitionScienceAndExploration1, 10));
            _settingGroup.Add(new Tech(TechType.FactionTraitTechnologyDefinitionScienceAndExploration2, 10));
            _settingGroup.Add(new Tech(TechType.FactionTraitTechnologyDefinitionEconomyAndTrade1, 10));
            _settingGroup.Add(new Tech(TechType.FactionTraitTechnologyDefinitionEconomyAndTrade2, 10));
            _settingGroup.Add(new Tech(TechType.FactionTraitTechnologyDefinitionEmpireDevelopment1, 10));
            _settingGroup.Add(new Tech(TechType.FactionTraitTechnologyDefinitionEmpireDevelopment2, 10));
            _settingGroup.Add(new Tech(TechType.FactionTraitTechnologyDefinitionMilitary1, 10));
            _settingGroup.Add(new Tech(TechType.FactionTraitTechnologyDefinitionMilitary2, 10));
        }
        public Tech GetRandomTech(List<int> iExclusionList, int iPointValueLessThan)
        {
            return (Tech)GetRandomSettingFromGroup(iExclusionList, iPointValueLessThan);
        }

        public Tech GetRandomTech(int iPointValueLessThan)
        {
            return (Tech)GetRandomSettingFromGroup(iPointValueLessThan);
        }
        public Tech GetRandomTech()
        {
            return (Tech)GetRandomSettingFromGroup();
        }
    }

}
