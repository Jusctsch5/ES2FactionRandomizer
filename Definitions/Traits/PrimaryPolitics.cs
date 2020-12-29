using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum PrimaryPoliticsType
    {
        PopulationPoliticalTraitIndustrialistTitle,
        PopulationPoliticalTraitPacifistTitle,
        PopulationPoliticalTraitScientificTitle,
        PopulationPoliticalTraitReligiousTitle,
        PopulationPoliticalTraitMilitaristTitle,
        PopulationPoliticalTraitEcologistTitle,
    }

    public class PrimaryPolitics : FactionSetting
    {
        public PrimaryPolitics(PrimaryPoliticsType iType, int iScoreModifier) : base(iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        PrimaryPoliticsType _type { get; set; }
    }
}
