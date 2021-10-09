using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum VisualAffinityType
    {
        AffinityMappingCravers         ,
        AffinityMappingSophons         ,
        AffinityMappingVenetians       ,
        AffinityMappingVampirilis      , // Vodyani
        AffinityMappingTerrans         ,
        AffinityMappingHoratio         ,
        AffinityMappingTimeLords       ,
        AffinityMappingUnfallen        ,
        AffinityMappingVaulters        ,
        AffinityMappingMajorHisshos    ,
        AffinityMappingUmbralChoir     ,
    }

    public class VisualAffinity : FactionSetting
    {
        public VisualAffinity(VisualAffinityType iType, int iScoreModifier) : base((int)iType, iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }

        public VisualAffinityType _type { get; set; }
        public string GetPopulationModifierTrait()
        {
            switch (_type)
            {
                case VisualAffinityType.AffinityMappingCravers:
                    return "PopulationModifiersTraitCravers";
                case VisualAffinityType.AffinityMappingSophons:
                    return "PopulationModifiersTraitSophons";
                case VisualAffinityType.AffinityMappingVenetians:
                    return "PopulationModifiersTraitVenetians";
                case VisualAffinityType.AffinityMappingVampirilis:
                    return "PopulationModifiersTraitVampirilis";
                case VisualAffinityType.AffinityMappingTerrans:
                    return "PopulationModifiersTraitTerrans";
                case VisualAffinityType.AffinityMappingHoratio:
                    return "PopulationModifiersTraitHoratio";
                case VisualAffinityType.AffinityMappingTimeLords:
                    return "PopulationModifiersTraitTimeLords";
                case VisualAffinityType.AffinityMappingUnfallen:
                    return "PopulationModifiersTraitUnfallen";
                case VisualAffinityType.AffinityMappingVaulters:
                    return "PopulationModifiersTraitVaulters";
                case VisualAffinityType.AffinityMappingMajorHisshos:
                    return "PopulationModifiersTraitMajorHisshos";
                case VisualAffinityType.AffinityMappingUmbralChoir:
                    return "PopulationModifiersTraitUmbralChoir";
                default:
                    break;
            }

            return "Unknown";
        }
    }

    public class VisualAffinityGroup : FactionSettingGroup
    {
        public void Initialize()
        {
            _settingGroup.Add(new VisualAffinity(VisualAffinityType.AffinityMappingCravers, 5));
            _settingGroup.Add(new VisualAffinity(VisualAffinityType.AffinityMappingSophons, 5));
            _settingGroup.Add(new VisualAffinity(VisualAffinityType.AffinityMappingTerrans, 10));
            _settingGroup.Add(new VisualAffinity(VisualAffinityType.AffinityMappingHoratio, 10));
            _settingGroup.Add(new VisualAffinity(VisualAffinityType.AffinityMappingVampirilis, 5));
            _settingGroup.Add(new VisualAffinity(VisualAffinityType.AffinityMappingVenetians, 10));
            _settingGroup.Add(new VisualAffinity(VisualAffinityType.AffinityMappingTimeLords, 5));
            _settingGroup.Add(new VisualAffinity(VisualAffinityType.AffinityMappingUnfallen, 5));
            _settingGroup.Add(new VisualAffinity(VisualAffinityType.AffinityMappingVaulters, 10));
            _settingGroup.Add(new VisualAffinity(VisualAffinityType.AffinityMappingMajorHisshos, 5));
            _settingGroup.Add(new VisualAffinity(VisualAffinityType.AffinityMappingUmbralChoir, 5));
        }
        public VisualAffinity GetRandomVisualAffinity(List<int> iExclusionList, int iPointValueLessThan)
        {
            return (VisualAffinity)GetRandomSettingFromGroup(iExclusionList, iPointValueLessThan);
        }

        public VisualAffinity GetRandomVisualAffinity(int iPointValueLessThan)
        {
            return (VisualAffinity)GetRandomSettingFromGroup(iPointValueLessThan);
        }
        public VisualAffinity GetRandomVisualAffinity()
        {
            return (VisualAffinity)GetRandomSettingFromGroup();
        }
        public VisualAffinity GetVisualAffinity(VisualAffinityType iType)
        {
            return (VisualAffinity)GetSettingFromGroup((int)iType);
        }
    }
}
