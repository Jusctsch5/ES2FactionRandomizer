using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum HomePlanetType
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
        public HomePlanet(HomePlanetType iType, int iScoreModifier) : base((int)iType, iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        HomePlanetType _type { get; set; } 
    }

    public class HomePlanetGroup : FactionSettingGroup
    {
        public void Initialize()
        {
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeAridTitle, 5));
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeAtollTitle, 15));
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeBorealTitle, 10));
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeForestTitle, 15));
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeJungleTitle, 10));
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeMonsoonTitle, 10));
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeOceanTitle, 15));
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeSnowTitle, 5));
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeSteppesTitle, 10));
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeTerranTitle, 15));
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeTropicalTitle, 10)); // Medd
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeTundraTitle, 10));
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeVeldtTitle, 10)); // savannah
        }
        public HomePlanet GetRandomHomePlanet(List<int> iExclusionList, int iPointValueLessThan)
        {
            return (HomePlanet)GetRandomSettingFromGroup(iExclusionList, iPointValueLessThan);
        }

        public HomePlanet GetRandomHomePlanet(int iPointValueLessThan)
        {
            return (HomePlanet)GetRandomSettingFromGroup(iPointValueLessThan);
        }
        public HomePlanet GetRandomHomePlanet()
        {
            return (HomePlanet)GetRandomSettingFromGroup();
        }
    }
}
