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
        public GameplayAffinity(GameplayAffinityType iType, int iScoreModifier) : base(iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }

        GameplayAffinityType _type { get; set; }
    }
}
