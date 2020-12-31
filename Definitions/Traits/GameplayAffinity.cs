using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum GameplayAffinityType
    {
        GameplayAffinityCravers        ,
        GameplayAffinitySophons        ,
        GameplayAffinityLumeris        ,
        GameplayAffinityVodyani        ,
        GameplayAffinityTerrans        ,
        GameplayAffinityHoratio        ,
        GameplayAffinityTimeLords      ,
        GameplayAffinityVenetians      ,
        GameplayAffinityVaulters       ,
        GameplayAffinityMajorHisshos   ,
        GameplayAffinityUmbralChoir
    }

    public class GameplayAffinity : FactionSetting
    {
        public GameplayAffinity(GameplayAffinityType iType, int iScoreModifier) : base((int)iType, iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }

        GameplayAffinityType _type { get; set; }
        
    }
    public class GameplayAffinityGroup : FactionSettingGroup
    {
        public void Initialize()
        {
            _settingGroup.Add(new GameplayAffinity(GameplayAffinityType.GameplayAffinityCravers, 100));
            _settingGroup.Add(new GameplayAffinity(GameplayAffinityType.GameplayAffinitySophons, 100));
            _settingGroup.Add(new GameplayAffinity(GameplayAffinityType.GameplayAffinityTerrans, 95));
            _settingGroup.Add(new GameplayAffinity(GameplayAffinityType.GameplayAffinityHoratio, 95));
            _settingGroup.Add(new GameplayAffinity(GameplayAffinityType.GameplayAffinityTimeLords, 95));
            _settingGroup.Add(new GameplayAffinity(GameplayAffinityType.GameplayAffinityVodyani, 95));
            _settingGroup.Add(new GameplayAffinity(GameplayAffinityType.GameplayAffinityLumeris, 100));
            _settingGroup.Add(new GameplayAffinity(GameplayAffinityType.GameplayAffinityVenetians, 95));
            _settingGroup.Add(new GameplayAffinity(GameplayAffinityType.GameplayAffinityVaulters, 95));
            _settingGroup.Add(new GameplayAffinity(GameplayAffinityType.GameplayAffinityMajorHisshos, 100));
            _settingGroup.Add(new GameplayAffinity(GameplayAffinityType.GameplayAffinityUmbralChoir, 100));
        }
        public GameplayAffinity GetRandomGameplayAffinity(List<int> iExclusionList, int iPointValueLessThan)
        {
            return (GameplayAffinity)GetRandomSettingFromGroup(iExclusionList, iPointValueLessThan);
        }

        public GameplayAffinity GetRandomGameplayAffinity(int iPointValueLessThan)
        {
            return (GameplayAffinity)GetRandomSettingFromGroup(iPointValueLessThan);
        }
        public GameplayAffinity GetRandomGameplayAffinity()
        {
            return (GameplayAffinity)GetRandomSettingFromGroup();
        }
    }
}
