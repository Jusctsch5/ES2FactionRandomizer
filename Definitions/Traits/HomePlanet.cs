using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum HomePlanetTraitType
    {
        FactionTraitHomePlanetPlanetTypeAridTitle        ,
        FactionTraitHomePlanetPlanetTypeAtollTitle       ,
        FactionTraitHomePlanetPlanetTypeBorealTitle      ,
        FactionTraitHomePlanetPlanetTypeForestTitle      ,
        FactionTraitHomePlanetPlanetTypeJungleTitle      ,
        FactionTraitHomePlanetPlanetTypeMonsoonTitle     ,
        FactionTraitHomePlanetPlanetTypeOceanTitle       ,
        FactionTraitHomePlanetPlanetTypeSnowTitle        ,
        FactionTraitHomePlanetPlanetTypeSteppesTitle     ,
        FactionTraitHomePlanetPlanetTypeTerranTitle      ,
        FactionTraitHomePlanetPlanetTypeTropicalTitle    ,
        FactionTraitHomePlanetPlanetTypeTundraTitle      ,
        FactionTraitHomePlanetPlanetTypeVeldtTitle       ,
    }

    public class HomePlanet : FactionSetting
    {
        public HomePlanet(HomePlanetTraitType iType, int iScoreModifier) : base(iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        HomePlanetTraitType _type { get; set; }
    }
}
