using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum HomePlanetType
    {
        FactionTraitHomePlanetPlanetTypeArid        ,
        FactionTraitHomePlanetPlanetTypeAtoll       ,
        FactionTraitHomePlanetPlanetTypeBoreal      ,
        FactionTraitHomePlanetPlanetTypeForest      ,
        FactionTraitHomePlanetPlanetTypeJungle      ,
        FactionTraitHomePlanetPlanetTypeMonsoon     ,
        FactionTraitHomePlanetPlanetTypeOcean       ,
        FactionTraitHomePlanetPlanetTypeSnow        ,
        FactionTraitHomePlanetPlanetTypeSteppes     ,
        FactionTraitHomePlanetPlanetTypeTerran      ,
        FactionTraitHomePlanetPlanetTypeTropical    ,
        FactionTraitHomePlanetPlanetTypeTundra      ,
        FactionTraitHomePlanetPlanetTypeVeldt       ,
        FactionTraitHomePlanetPlanetTypeFake,
    }

    public class HomePlanet : FactionSetting
    {
        public HomePlanet(HomePlanetType iType, int iScoreModifier) : base((int)iType, iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        public HomePlanetType _type { get; set; } 
    }

    public class HomePlanetGroup : FactionSettingGroup
    {
        public void Initialize()
        {
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeArid, 5));
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeAtoll, 15));
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeBoreal, 10));
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeForest, 15));
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeJungle, 10));
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeMonsoon, 10));
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeOcean, 15));
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeSnow, 5));
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeSteppes, 10));
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeTerran, 15));
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeTropical, 10)); // Medd
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeTundra, 10));
            _settingGroup.Add(new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeVeldt, 10)); // savannah
            _fakeHomePlanet = new HomePlanet(HomePlanetType.FactionTraitHomePlanetPlanetTypeFake, 5);
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

        public HomePlanet _fakeHomePlanet { get; set; }
    }
}
