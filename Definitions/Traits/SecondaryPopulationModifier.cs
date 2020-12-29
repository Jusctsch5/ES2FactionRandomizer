using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum SecondaryPopulationModifierTraitType
    {
        PopulationModifiersTraitHisshoSecondaryTitle                      ,
        PopulationModifiersTraitBenthysSecondaryTitle                     ,
        PopulationModifiersTraitBhagabasSecondaryTitle                    ,
        PopulationModifiersTraitDeuyivansSecondaryTitle                   ,
        PopulationModifiersTraitEydersSecondaryTitle                      ,
        PopulationModifiersTraitGnashastsSecondaryTitle                   ,
        PopulationModifiersTraitHaroshemsSecondaryTitle                   ,
        PopulationModifiersTraitHisshosSecondaryTitle                     ,
        PopulationModifiersTraitMavrosSecondaryTitle                      ,
        PopulationModifiersTraitMezariSecondaryTitle                      ,
        PopulationModifiersTraitNirisSecondaryTitle                       ,
        PopulationModifiersTraitPilgrimsSecondaryTitle                    ,
        PopulationModifiersTraitPulsosSecondaryTitle                      ,
        PopulationModifiersTraitRemnantSecondaryTitle                     ,
        PopulationModifiersTraitSecondaryDefenseFertileTitle              ,
        PopulationModifiersTraitSecondaryDustMeagerTitle                  ,
        PopulationModifiersTraitSecondaryHappinessHotTitle                ,
        PopulationModifiersTraitSecondaryHappinessTemperateTitle          ,
        PopulationModifiersTraitSecondaryIndustryColdTitle                ,
        PopulationModifiersTraitSecondaryIndustryMeagerTitle              ,
        PopulationModifiersTraitSecondaryScienceHotTitle                  ,
        PopulationModifiersTraitSheredynSecondaryTitle                    ,
        PopulationModifiersTraitTerransSecondaryTitle                     ,
        PopulationModifiersTraitTikanansSecondaryTitle                    ,
        PopulationModifiersTraitUnfallenSecondaryTitle                    ,
        PopulationModifiersTraitVenetiansSecondaryTitle                   ,
        PopulationModifiersTraitZvaliSecondaryTitle                       ,
        PopulationModifiersTraitSecondaryAntiDepletion01Title             ,
        PopulationModifiersTraitSecondaryHappinessSterileTitle            ,
        PopulationModifiersTraitSecondaryIndustryFertileTitle             ,
        PopulationModifiersTraitSecondaryStrategicToScience01Title        ,
        PopulationModifiersTraitSecondaryGroundBattleAttackerDamage01Title,
    }

    public class SecondaryPopulationModifier : FactionSetting
    {
        public SecondaryPopulationModifier(SecondaryPopulationModifierTraitType iType, int iScoreModifier) : base(iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        SecondaryPopulationModifierTraitType _type { get; set; }
    }
}
