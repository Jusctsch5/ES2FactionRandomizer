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
        public Government(GovernmentType iType, int iScoreModifier) : base(iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        GovernmentType _type { get; set; }
    }
}
