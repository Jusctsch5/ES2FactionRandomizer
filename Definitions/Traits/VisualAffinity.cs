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
        public VisualAffinity(VisualAffinityType iType, int iScoreModifier) : base(iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }

        VisualAffinityType _type { get; set; }
    }
}
