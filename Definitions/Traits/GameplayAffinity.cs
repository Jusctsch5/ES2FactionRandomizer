using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum GameplayAffinityType
    {
        AffinityGameplayCravers        ,
        AffinityGameplaySophons        ,
        AffinityGameplayLumeris        ,
        AffinityGameplayVampirilis     ,
        AffinityGameplayTerrans        ,
        AffinityGameplayHoratio        ,
        AffinityGameplayTimeLords      ,
        AffinityGameplayVenetians      ,
        AffinityGameplayVaulters       ,
        AffinityGameplayMajorHisshos   ,
        AffinityGameplayUmbralChoir
    }

    public class GameplayAffinity : FactionSetting
    {
        public GameplayAffinity(GameplayAffinityType iType, int iScoreModifier) : base((int)iType, iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }

        public GameplayAffinityType _type { get; set; }
        
    }
    public class GameplayAffinityGroup : FactionSettingGroup
    {
        public void Initialize()
        {
            _settingGroup.Add(new GameplayAffinity(GameplayAffinityType.AffinityGameplayCravers, 100));
            _settingGroup.Add(new GameplayAffinity(GameplayAffinityType.AffinityGameplaySophons, 100));
            _settingGroup.Add(new GameplayAffinity(GameplayAffinityType.AffinityGameplayTerrans, 95));
            _settingGroup.Add(new GameplayAffinity(GameplayAffinityType.AffinityGameplayHoratio, 95));
            _settingGroup.Add(new GameplayAffinity(GameplayAffinityType.AffinityGameplayTimeLords, 95));
            _settingGroup.Add(new GameplayAffinity(GameplayAffinityType.AffinityGameplayVampirilis, 95));
            _settingGroup.Add(new GameplayAffinity(GameplayAffinityType.AffinityGameplayLumeris, 100));
            _settingGroup.Add(new GameplayAffinity(GameplayAffinityType.AffinityGameplayVenetians, 95));
            _settingGroup.Add(new GameplayAffinity(GameplayAffinityType.AffinityGameplayVaulters, 95));
            _settingGroup.Add(new GameplayAffinity(GameplayAffinityType.AffinityGameplayMajorHisshos, 100));
            _settingGroup.Add(new GameplayAffinity(GameplayAffinityType.AffinityGameplayUmbralChoir, 100));
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
