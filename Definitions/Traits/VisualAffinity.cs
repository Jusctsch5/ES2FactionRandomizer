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

        public VisualAffinityType _type { get; set; }

        public static string ConvertAffinityTypeToUuidStr(VisualAffinityType iType)
        {
            switch (iType)
            {
                case VisualAffinityType.VisualAffinityCravers:
                    return "8e684513-e6a3-4c19-bdad-3bd349a54e51";
                case VisualAffinityType.VisualAffinitySophons:
                    return "5b82905c-330d-4691-b9de-2d358fbeeca6";
                case VisualAffinityType.VisualAffinityLumeris:
                    return "72566b3f-22db-451c-aa5a-16c4bad24091";
                case VisualAffinityType.VisualAffinityVodyani:
                    return "7a9d8117-ae0c-49e6-aa1a-fd9ac34dbf36";
                case VisualAffinityType.VisualAffinityTerrans:
                    return "0b6394e4-1fbf-49ab-b0a0-5482fbbfc539";
                case VisualAffinityType.VisualAffinityHoratio:
                    return "c5d7cc07-cc1d-4105-bbd5-3144cd83b3ff";
                case VisualAffinityType.VisualAffinityTimeLords:
                    break;
                case VisualAffinityType.VisualAffinityVenetians:
                    return "f2b73626-0987-4334-bae5-fd23a47cf51a";
                case VisualAffinityType.VisualAffinityVaulters:
                    return "942b30b4-1ab5-449b-b24b-f457ceff918b";
                case VisualAffinityType.VisualAffinityMajorHisshos:
                    return "d6225e01-bf32-4e12-9a4f-bd73acc1784a";
                case VisualAffinityType.VisualAffinityUmbralChoir:
                    return "232116cd-b184-4ea0-ada4-a834d107ed2a";
                default:
                    return "";

            }
            return "";
        }
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
