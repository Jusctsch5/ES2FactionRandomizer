using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum PrimaryPoliticsType
    {
        PopulationPoliticalTraitIndustrialist,
        PopulationPoliticalTraitPacifist,
        PopulationPoliticalTraitScientific,
        PopulationPoliticalTraitReligious,
        PopulationPoliticalTraitMilitarist,
        PopulationPoliticalTraitEcologist,
    }

    public class PrimaryPolitics : FactionSetting
    {
        public PrimaryPolitics(PrimaryPoliticsType iType, int iScoreModifier) : base((int)iType, iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }

        public PrimaryPoliticsType _type { get; set; }

        public string GetPoliticsReference()
        {
            switch (_type)
            {
                case PrimaryPoliticsType.PopulationPoliticalTraitIndustrialist:
                    return "Politics01";
                case PrimaryPoliticsType.PopulationPoliticalTraitScientific:
                    return "Politics02";
                case PrimaryPoliticsType.PopulationPoliticalTraitPacifist:
                    return "Politics03";
                case PrimaryPoliticsType.PopulationPoliticalTraitEcologist:
                    return "Politics04";
                case PrimaryPoliticsType.PopulationPoliticalTraitReligious:
                    return "Politics05";
                case PrimaryPoliticsType.PopulationPoliticalTraitMilitarist:
                    return "Politics06";
                default:
                    break;
            }

            return "Unknown";
        }
    }

    public class PrimaryPoliticsGroup : FactionSettingGroup
    {
        public void Initialize()
        {
            _settingGroup.Add(new PrimaryPolitics(PrimaryPoliticsType.PopulationPoliticalTraitIndustrialist, 10));
            _settingGroup.Add(new PrimaryPolitics(PrimaryPoliticsType.PopulationPoliticalTraitPacifist, 10));
            _settingGroup.Add(new PrimaryPolitics(PrimaryPoliticsType.PopulationPoliticalTraitScientific, 10));
            _settingGroup.Add(new PrimaryPolitics(PrimaryPoliticsType.PopulationPoliticalTraitReligious, 10));
            _settingGroup.Add(new PrimaryPolitics(PrimaryPoliticsType.PopulationPoliticalTraitMilitarist, 10));
            _settingGroup.Add(new PrimaryPolitics(PrimaryPoliticsType.PopulationPoliticalTraitEcologist, 10));
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
}
