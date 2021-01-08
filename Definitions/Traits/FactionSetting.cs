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
            _exclusiveSet = new List<int>();
        }

        public string _jsonString { get; set; }
        public int _scoreModifier { get; set; }
        public int _id { get; set; }
        public List<int> _exclusiveSet { get; set; }

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
                filteredSettingsGroup.Add(setting);
            }
            int r = _rand.Next(filteredSettingsGroup.Count());
            return filteredSettingsGroup[r];
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
                filteredSettingsGroup.Add(setting);
            }
            int r = _rand.Next(filteredSettingsGroup.Count());
            return filteredSettingsGroup[r];
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
                if (setting._scoreModifier < iMinPoints || setting._scoreModifier > iMaxPoints)
                {
                    continue;
                }
                filteredSettingsGroup.Add(setting);
            }
            int r = _rand.Next(filteredSettingsGroup.Count());
            Console.WriteLine("Got Trait:" + filteredSettingsGroup[r]._jsonString + 
                              " score:" + filteredSettingsGroup[r]._scoreModifier + 
                              " from minPoints:" + iMinPoints + 
                              " maxPoints:" + iMaxPoints);
            return filteredSettingsGroup[r];
        }

        public void AddExclusivity(List<int> iExclusionList)
        {
            foreach (var factionSetting in _settingGroup)
            {

                // If there's a match, add exclusive list to the setting. 
                foreach (var exclusiveValue in iExclusionList)
                {
                    if (factionSetting._id == exclusiveValue)
                    {
                        factionSetting._exclusiveSet.Clear();
                        factionSetting._exclusiveSet = new List<int>(iExclusionList);
                        break;
                    }
                }
            }
        }

        public List<FactionSetting> _settingGroup;
        Random _rand;
    }
}