using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum PrimaryPopulationModifierTraitType
    {
        PopulationModifiersTraitAmoebaPrimaryTitle                   ,   // Base Game
        PopulationModifiersTraitBotsPrimaryTitle                     ,
        PopulationModifiersTraitCraversPrimaryTitle                  ,
        PopulationModifiersTraitDeuyivansPrimaryTitle                ,
        PopulationModifiersTraitGnashastsPrimaryTitle                ,
        PopulationModifiersTraitHaroshemsPrimaryTitle                ,
        PopulationModifiersTraitHoratioPrimaryTitle                  ,
        PopulationModifiersTraitMavrosPrimaryTitle                   ,
        PopulationModifiersTraitMezariPrimaryTitle                   ,
        PopulationModifiersTraitNirisPrimaryTitle                    ,
        PopulationModifiersTraitPilgrimsPrimaryTitle                 ,
        PopulationModifiersTraitPrimaryFIDSITitle                    ,
        PopulationModifiersTraitPulsosPrimaryTitle                   ,     
        PopulationModifiersTraitRemnantPrimaryTitle                  ,
        PopulationModifiersTraitSheredynPrimaryTitle                 ,
        PopulationModifiersTraitSophonsPrimaryTitle                  ,
        PopulationModifiersTraitTerransPrimaryTitle                  ,
        PopulationModifiersTraitTikanansPrimaryTitle                 ,
        PopulationModifiersTraitTimeLordsPrimaryTitle                ,
        PopulationModifiersTraitUnfallenPrimaryTitle                 ,
        PopulationModifiersTraitVampirilisPrimaryTitle               ,
        PopulationModifiersTraitVenetiansPrimaryTitle                ,
        PopulationModifiersTraitZvaliPrimaryTitle                    ,
        PopulationModifiersTraitSuperGuardiansPrimaryTitle           ,
        PopulationModifiersTraitPrimaryStrategicToFood01Title        ,
        PopulationModifiersTraitHisshoPrimaryTitle                   ,   // Hissho (DLC2)
        PopulationModifiersTraitIlloPrimaryTitle                     ,                 
        PopulationModifiersTraitPrimaryProcessingPower01Title        ,   // Umbral Choir (DLC3)
        // PopulationModifiersTraitPrimaryHappinessTempleTitle       ,   // Nakalim (DLC4)
    }

    public class PrimaryPopulationModifier : FactionSetting
    {
        public PrimaryPopulationModifier(PrimaryPopulationModifierTraitType iType, int iScoreModifier) : base(iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        PrimaryPopulationModifierTraitType _type { get; set; }
    }
}
