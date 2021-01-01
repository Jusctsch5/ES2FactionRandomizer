using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer
{
    public class FactionSetting
    {
        public FactionSetting(int iId, string iJsonString, int iScoreModifier)
        {
            _id = iId;
            _jsonString = iJsonString;
            _scoreModifier = iScoreModifier;
        }

        public string _jsonString { get; set; }
        public int _scoreModifier { get; set; }
        public int _id { get; set; }

    }
    public class FactionSettingGroup
    {
        public FactionSettingGroup()
        {
            _settingGroup = new List<FactionSetting>();
            _rand = new Random();
        }

        public FactionSetting GetRandomSettingFromGroup(List<int> iExclusionList, int iPointValueLessThan)
        {
            var filteredSettingsGroup = new List<FactionSetting>();
            foreach (var setting in _settingGroup)
            {
                if (iExclusionList.Contains(setting._id)) {
                    continue;
                }
                if (iPointValueLessThan != 0 && setting._scoreModifier > iPointValueLessThan)
                {
                    continue;
                }
            }
            int r = _rand.Next(_settingGroup.Count());
            return _settingGroup[r];
        }

        public FactionSetting GetRandomSettingFromGroup(int iPointValueLessThan)
        {
            var exclusionListEmpty = new List<int>();
            return GetRandomSettingFromGroup(exclusionListEmpty, iPointValueLessThan);
        }

        public FactionSetting GetRandomSettingFromGroup()
        {
            var exclusionListEmpty = new List<int>();
            return GetRandomSettingFromGroup(exclusionListEmpty, 0);
        }
        public FactionSetting GetSettingFromGroup(int iValue)
        {
            return _settingGroup.Find(x => x._id == iValue);
        }


        public FactionSetting GetRandomSettingMinPoints(List<int> iExclusionList, int iMinPoints)
        {
            var filteredSettingsGroup = new List<FactionSetting>();
            foreach (var setting in _settingGroup)
            {
                if (iExclusionList.Contains(setting._id))
                {
                    continue;
                }
                if (iMinPoints != 0 && setting._scoreModifier < iMinPoints)
                {
                    continue;
                }
            }
            int r = _rand.Next(_settingGroup.Count());
            return _settingGroup[r];
        }

        public FactionSetting GetRandomSettingRange(List<int> iExclusionList, int iMinPoints, int iMaxPoints)
        {
            var filteredSettingsGroup = new List<FactionSetting>();
            foreach (var setting in _settingGroup)
            {
                if (iExclusionList.Contains(setting._id))
                {
                    continue;
                }
                if (iMinPoints != 0 && setting._scoreModifier < iMinPoints && setting._scoreModifier > iMaxPoints)
                {
                    continue;
                }
            }
            int r = _rand.Next(_settingGroup.Count());
            return _settingGroup[r];
        }

        public List<FactionSetting> _settingGroup;
        Random _rand;
    }

}











    /*
    <?xml version = "1.0" encoding="utf-8"?>
<MajorFaction xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" Name="786264be-f052-4efb-80c3-b74276052964" Author="Frogulous" Standard="false" Priority="0">
  <Affinity Name = "AffinityGameplayCravers" />
  < Trait Name="IsMajorFaction" />
  <Trait Name = "FactionTraitFearlessWarriors1" />
  < Trait Name="FactionTraitTechnologyDefinitionEconomyAndTrade1" />
  <Trait Name = "FactionTraitTechnologyDefinitionMilitary1" />
  < Trait Name="FactionTraitCrowdedPlanets1" />
  <Trait Name = "FactionTraitMinorNiris" />
  < Trait Name="FactionTraitBigFleets1" />
  <Trait Name = "FactionTraitIneptTraders" />
  < Trait Name="FactionTraitHomePlanetPlanetTypeTerran" />
  <Trait Name = "TraitCustomFaction" />
  < TraitStartingSenate Name="" SubCategory="" Priority="100">
    <Prerequisites />
    <UnlockedAbstractShipDesigns />
    <Government Name = "GovernmentDemocracy" />
    < PoliticsWeight Politics="Politics01" Weight="0" />
    <PoliticsWeight Politics = "Politics02" Weight="0" />
    <PoliticsWeight Politics = "Politics03" Weight="1" />
    <PoliticsWeight Politics = "Politics04" Weight="0" />
    <PoliticsWeight Politics = "Politics05" Weight="0" />
    <PoliticsWeight Politics = "Politics06" Weight="2" />
    <Cost>10</Cost>
  </TraitStartingSenate>
  <Bailiff Name = "DefaultMoneyBailiff" />
  < Bailiff Name="DefaultEmpirePointBailiff" />
  <MajorPopulation Affinity = "8e684513-e6a3-4c19-bdad-3bd349a54e51" Count="2" />
  <LocalizedDescription />
  <LocalizedName>Sophisticated Cravers</LocalizedName>
</MajorFaction>
        */