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
        public PrimaryPolitics(PrimaryPoliticsType iType, int iScoreModifier) : base((int)iType, iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }

        PrimaryPoliticsType _type { get; set; }
    }
    public class PrimaryPoliticsGroup : FactionSettingGroup
    {
        public void Initialize()
        {
            _settingGroup.Add(new PrimaryPolitics(PrimaryPoliticsType.PopulationPoliticalTraitIndustrialistTitle, 10));
            _settingGroup.Add(new PrimaryPolitics(PrimaryPoliticsType.PopulationPoliticalTraitPacifistTitle, 10));
            _settingGroup.Add(new PrimaryPolitics(PrimaryPoliticsType.PopulationPoliticalTraitScientificTitle, 10));
            _settingGroup.Add(new PrimaryPolitics(PrimaryPoliticsType.PopulationPoliticalTraitReligiousTitle, 10));
            _settingGroup.Add(new PrimaryPolitics(PrimaryPoliticsType.PopulationPoliticalTraitMilitaristTitle, 10));
            _settingGroup.Add(new PrimaryPolitics(PrimaryPoliticsType.PopulationPoliticalTraitEcologistTitle, 10));
        }
        public PrimaryPolitics GetRandomPrimaryPolitics(List<int> iExclusionList, int iPointValueLessThan)
        {
            return (PrimaryPolitics)GetRandomSettingFromGroup(iExclusionList, iPointValueLessThan);
        }

        public PrimaryPolitics GetRandomPrimaryPolitics(int iPointValueLessThan)
        {
            return (PrimaryPolitics)GetRandomSettingFromGroup(iPointValueLessThan);
        }
        public PrimaryPolitics GetRandomPrimaryPolitics()
        {
            return (PrimaryPolitics)GetRandomSettingFromGroup();
        }
    }
