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
        public SecondaryPolitics(SecondaryPoliticsType iType, int iScoreModifier) : base(iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        SecondaryPoliticsType _type { get; set; }
    }
}
