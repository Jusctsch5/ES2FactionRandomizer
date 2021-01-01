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
        public PrimaryPopulationModifier(PrimaryPopulationModifierTraitType iType, int iScoreModifier) : base((int)iType, iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        public PrimaryPopulationModifierTraitType _type { get; set; }
    }
    public class PrimaryPopulationModifierGroup : FactionSettingGroup
    {
        public void Initialize()
        {
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitAmoebaPrimaryTitle, 10)); // Nuturers
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitBotsPrimaryTitle, 5)); // Craftsmen
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitCraversPrimaryTitle, 15)); // Extreme Foremen
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitDeuyivansPrimaryTitle, 10)); // Methodists
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitGnashastsPrimaryTitle, 5)); // Tough Defenders
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitHaroshemsPrimaryTitle, 5)); // Agricultural Engineers
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitHoratioPrimaryTitle, 5)); // Hedonists
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitMezariPrimaryTitle, 5)); // Analysts
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryFIDSITitle, 15)); // Meritocratic Cosmopolites
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitSheredynPrimaryTitle, 10)); // Martial Traditions
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitSophonsPrimaryTitle, 5)); // Analysts
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitTerransPrimaryTitle, 5)); // Loyal Citizens
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitTikanansPrimaryTitle, 10)); // Eager Volunteers
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitTimeLordsPrimaryTitle, 25)); // Adept Workers
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitUnfallenPrimaryTitle, 15)); // Agriculturalists
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitVampirilisPrimaryTitle, 10)); // Gargantuan Population
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitVenetiansPrimaryTitle, 5)); // Bankers
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryStrategicToFood01Title, 5)); // Strategic Sustenance
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitHisshoPrimaryTitle, 5)); // Martial Traditions
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitIlloPrimaryTitle, 5)); // Stellar Stoics
            _settingGroup.Add(new PrimaryPopulationModifier(PrimaryPopulationModifierTraitType.PopulationModifiersTraitPrimaryProcessingPower01Title, 5)); // Natural Born Hackers
        }
        public PrimaryPopulationModifier GetRandomPrimaryPopulationModifier(List<int> iExclusionList, int iPointValueLessThan)
        {
            return (PrimaryPopulationModifier)GetRandomSettingFromGroup(iExclusionList, iPointValueLessThan);
        }

        public PrimaryPopulationModifier GetRandomPrimaryPopulationModifier(int iPointValueLessThan)
        {
            return (PrimaryPopulationModifier)GetRandomSettingFromGroup(iPointValueLessThan);
        }
        public PrimaryPopulationModifier GetRandomPrimaryPopulationModifier()
        {
            return (PrimaryPopulationModifier)GetRandomSettingFromGroup();
        }
    }
}
