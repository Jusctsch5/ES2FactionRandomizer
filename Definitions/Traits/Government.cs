using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum GovernmentType
    {
        GovernmentDemocracy,
        GovernmentDictatorship,
        GovernmentEmpire,
        GovernmentRepublic,
        GovernmentDictatorshipCravers,
    }

    public class Government : FactionSetting
    {
        public Government(GovernmentType iType, int iScoreModifier) : base((int)iType, iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        public GovernmentType _type { get; set; }
    }

    public class GovernmentGroup : FactionSettingGroup
    {
        public void Initialize()
        {
            _settingGroup.Add(new Government(GovernmentType.GovernmentDemocracy, 10));
            _settingGroup.Add(new Government(GovernmentType.GovernmentDictatorship, 10));
            _settingGroup.Add(new Government(GovernmentType.GovernmentEmpire, 10)); // federation
            _settingGroup.Add(new Government(GovernmentType.GovernmentRepublic, 10));
            _settingGroup.Add(new Government(GovernmentType.GovernmentDictatorshipCravers, 10)); // Autocracy
        }
        public Government GetRandomGovernment(List<int> iExclusionList, int iPointValueLessThan)
        {
            return (Government)GetRandomSettingFromGroup(iExclusionList, iPointValueLessThan);
        }

        public Government GetRandomGovernment(int iPointValueLessThan)
        {
            return (Government)GetRandomSettingFromGroup(iPointValueLessThan);
        }
        public Government GetRandomGovernment()
        {
            return (Government)GetRandomSettingFromGroup();
        }
    }

}
