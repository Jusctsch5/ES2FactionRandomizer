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
        GovernmentFederation,
        GovernmentRepublic,
        GovernmentAutocracy,
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
            _settingGroup.Add(new Government(GovernmentType.GovernmentFederation, 10));
            _settingGroup.Add(new Government(GovernmentType.GovernmentRepublic, 10));
            _settingGroup.Add(new Government(GovernmentType.GovernmentAutocracy, 10));
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
