using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum VisualAffinityType
    {
        VisualAffinityCravers         ,
        VisualAffinitySophons         ,
        VisualAffinityLumeris         ,
        VisualAffinityVodyani         ,
        VisualAffinityTerrans         ,
        VisualAffinityHoratio         ,
        VisualAffinityTimeLords       ,
        VisualAffinityVenetians       ,
        VisualAffinityVaulters        ,
        VisualAffinityMajorHisshos    ,
        VisualAffinityUmbralChoir     ,
    }

    public class VisualAffinity : FactionSetting
    {
        public VisualAffinity(VisualAffinityType iType, int iScoreModifier) : base((int)iType, iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }

        VisualAffinityType _type { get; set; }
    }

    public class VisualAffinityGroup : FactionSettingGroup
    {
        public void Initialize()
        {
            _settingGroup.Add(new VisualAffinity(VisualAffinityType.VisualAffinityCravers, 5));
            _settingGroup.Add(new VisualAffinity(VisualAffinityType.VisualAffinitySophons, 5));
            _settingGroup.Add(new VisualAffinity(VisualAffinityType.VisualAffinityTerrans, 10));
            _settingGroup.Add(new VisualAffinity(VisualAffinityType.VisualAffinityHoratio, 10));
            _settingGroup.Add(new VisualAffinity(VisualAffinityType.VisualAffinityVodyani, 5));
            _settingGroup.Add(new VisualAffinity(VisualAffinityType.VisualAffinityLumeris, 10));
            _settingGroup.Add(new VisualAffinity(VisualAffinityType.VisualAffinityTimeLords, 5));
            _settingGroup.Add(new VisualAffinity(VisualAffinityType.VisualAffinityVenetians, 5));
            _settingGroup.Add(new VisualAffinity(VisualAffinityType.VisualAffinityVaulters, 10));
            _settingGroup.Add(new VisualAffinity(VisualAffinityType.VisualAffinityMajorHisshos, 5));
            _settingGroup.Add(new VisualAffinity(VisualAffinityType.VisualAffinityUmbralChoir, 5));
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
            return (VisualAffinity)GetRandomSettingFromGroup((int)iType);
        }
    }
}
