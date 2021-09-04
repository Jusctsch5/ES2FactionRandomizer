using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum SecondaryPoliticsType
    {
        PopulationPoliticalTraitNone                       ,
        PopulationPoliticalTraitAggressive                 ,
        PopulationPoliticalTraitAntiEcologist              ,
        PopulationPoliticalTraitAntiIndustrialist          ,
        PopulationPoliticalTraitAntiMilitarist             ,
        PopulationPoliticalTraitAntiPacifist               ,
        PopulationPoliticalTraitAntiReligious              ,
        PopulationPoliticalTraitAntiScientist              ,
        PopulationPoliticalTraitMilitaristToIndustrialist    ,
        PopulationPoliticalTraitMilitaristToScientific       ,
        PopulationPoliticalTraitMilitaristToEcologist        ,
        PopulationPoliticalTraitMilitaristToReligious        ,
        PopulationPoliticalTraitIndustrialistToMilitarist    ,
        PopulationPoliticalTraitIndustrialistToPacifist      ,
        PopulationPoliticalTraitIndustrialistToScientific    ,
        PopulationPoliticalTraitIndustrialistToReligious     ,
        PopulationPoliticalTraitPacifistToIndustrialist      ,
        PopulationPoliticalTraitPacifistToScientific         ,
        PopulationPoliticalTraitPacifistToEcologist          ,
        PopulationPoliticalTraitPacifistToReligious          ,
        PopulationPoliticalTraitScientificToMilitarist       ,
        PopulationPoliticalTraitScientificToIndustrialist    ,
        PopulationPoliticalTraitScientificToPacifist         ,
        PopulationPoliticalTraitScientificToEcologist        ,
        PopulationPoliticalTraitEcologistToMilitarist        ,
        PopulationPoliticalTraitEcologistToPacifist          ,
        PopulationPoliticalTraitEcologistToScientific        ,
        PopulationPoliticalTraitEcologistToReligious         ,
        PopulationPoliticalTraitReligiousToMilitarist        ,
        PopulationPoliticalTraitReligiousToIndustrialist     ,
        PopulationPoliticalTraitReligiousToPacifist          ,
        PopulationPoliticalTraitReligiousToEcologist         ,
    }

    public class SecondaryPolitics : FactionSetting
    {
        public SecondaryPolitics(SecondaryPoliticsType iType, int iScoreModifier) : base((int)iType, iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        public SecondaryPoliticsType _type { get; set; }
    }
    public class SecondaryPoliticsGroup : FactionSettingGroup
    {
        public void Initialize()
        {
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitAntiEcologist, 10));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitAntiIndustrialist, 10));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitAntiMilitarist, 10));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitAntiPacifist, 10));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitAntiReligious, 10));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitAntiScientist, 10));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitMilitaristToIndustrialist , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitMilitaristToScientific    , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitMilitaristToEcologist     , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitMilitaristToReligious     , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitIndustrialistToMilitarist , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitIndustrialistToPacifist   , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitIndustrialistToScientific , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitIndustrialistToReligious  , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitPacifistToIndustrialist   , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitPacifistToScientific      , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitPacifistToEcologist       , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitPacifistToReligious       , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitScientificToMilitarist    , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitScientificToIndustrialist , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitScientificToPacifist      , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitScientificToEcologist     , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitEcologistToMilitarist     , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitEcologistToPacifist       , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitEcologistToScientific     , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitEcologistToReligious      , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitReligiousToMilitarist     , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitReligiousToIndustrialist  , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitReligiousToPacifist       , 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitReligiousToEcologist,     5));
        }
        public SecondaryPolitics GetRandomSecondaryPolitics(List<int> iExclusionList, int iPointValueLessThan)
        {
            return (SecondaryPolitics)GetRandomSettingFromGroup(iExclusionList, iPointValueLessThan);
        }

        public SecondaryPolitics GetRandomSecondaryPolitics(int iPointValueLessThan)
        {
            return (SecondaryPolitics)GetRandomSettingFromGroup(iPointValueLessThan);
        }
        public SecondaryPolitics GetRandomSecondaryPolitics()
        {
            return (SecondaryPolitics)GetRandomSettingFromGroup();
        }
    }
}
