using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum SecondaryPoliticsType
    {
        PopulationPoliticalTraitAggressiveTitle                 ,
        PopulationPoliticalTraitAntiEcologistTitle              ,
        PopulationPoliticalTraitAntiIndustrialistTitle          ,
        PopulationPoliticalTraitAntiMilitaristTitle             ,
        PopulationPoliticalTraitAntiPacifistTitle               ,
        PopulationPoliticalTraitAntiReligiousTitle              ,
        PopulationPoliticalTraitAntiScientistTitle              ,
        PopulationPoliticalTraitAtheistTitle                    ,
        PopulationPoliticalTraitCuriousTitle                    ,
        PopulationPoliticalTraitDiplomatTitle                   ,
        PopulationPoliticalTraitEcologistToIndustrialistTitle   ,
        PopulationPoliticalTraitEcologistToMilitaristTitle      ,
        PopulationPoliticalTraitEcologistToReligiousTitle       ,
        PopulationPoliticalTraitEcologistToScienceTitle         ,
        PopulationPoliticalTraitFanaticTitle                    ,
        PopulationPoliticalTraitHedonistTitle                   ,
        PopulationPoliticalTraitIndustrialistToPacifistTitle    ,
        PopulationPoliticalTraitIndustrialistToReligiousTitle   ,
        PopulationPoliticalTraitIndustryToScienceTitle          ,
        PopulationPoliticalTraitMercifulTitle                   ,
        PopulationPoliticalTraitMilitaristToEcologistTitle      ,
        PopulationPoliticalTraitMilitaristToReligiousTitle      ,
        PopulationPoliticalTraitMilitaristToScientificTitle     ,
        PopulationPoliticalTraitOptimisedTitle                  ,
        PopulationPoliticalTraitPacifistToEcologistTitle        ,
        PopulationPoliticalTraitPacifistToIndustrialistTitle    ,
        PopulationPoliticalTraitPiousTitle                      ,
        PopulationPoliticalTraitPragmaticTitle                  ,
        PopulationPoliticalTraitRelativistTitle                 ,
        PopulationPoliticalTraitReligiousToEcologistTitle       ,
        PopulationPoliticalTraitReligiousToIndustrialistTitle   ,
        PopulationPoliticalTraitReligiousToMilitaristTitle      ,
        PopulationPoliticalTraitReligiousToPacifistTitle        ,
        PopulationPoliticalTraitReligiousToScientificTitle      ,
        PopulationPoliticalTraitSagaciousTitle                  ,
        PopulationPoliticalTraitScientificToEcologistTitle      ,
        PopulationPoliticalTraitScientificToIndustrialistTitle  ,
        PopulationPoliticalTraitScientificToPacifistTitle       ,
        PopulationPoliticalTraitSearcherTitle                   ,
        PopulationPoliticalTraitWarmongerTitle                  ,
        PopulationPoliticalTraitWaryTitle                       ,
        PopulationPoliticalTraitXenophobicTitle                 ,
    }

    public class SecondaryPolitics : FactionSetting
    {
        public SecondaryPolitics(SecondaryPoliticsType iType, int iScoreModifier) : base((int)iType, iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        SecondaryPoliticsType _type { get; set; }
    }
    public class SecondaryPoliticsGroup : FactionSettingGroup
    {
        public void Initialize()
        {
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitAntiEcologistTitle, 10));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitAntiIndustrialistTitle, 10));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitAntiMilitaristTitle, 10));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitAntiPacifistTitle, 10));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitAntiReligiousTitle, 10));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitAntiScientistTitle, 10));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitAggressiveTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitAtheistTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitCuriousTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitDiplomatTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitEcologistToIndustrialistTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitEcologistToMilitaristTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitEcologistToReligiousTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitEcologistToScienceTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitFanaticTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitHedonistTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitIndustrialistToPacifistTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitIndustrialistToReligiousTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitIndustryToScienceTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitMercifulTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitMilitaristToEcologistTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitMilitaristToReligiousTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitMilitaristToScientificTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitOptimisedTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitPacifistToEcologistTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitPacifistToIndustrialistTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitPiousTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitPragmaticTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitRelativistTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitReligiousToEcologistTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitReligiousToIndustrialistTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitReligiousToMilitaristTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitReligiousToPacifistTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitReligiousToScientificTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitSagaciousTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitScientificToEcologistTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitScientificToIndustrialistTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitScientificToPacifistTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitSearcherTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitWarmongerTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitWaryTitle, 5));
            _settingGroup.Add(new SecondaryPolitics(SecondaryPoliticsType.PopulationPoliticalTraitXenophobicTitle, 5));
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
