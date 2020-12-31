using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum SecondaryPopulationModifierType
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
        public SecondaryPopulationModifier(SecondaryPopulationModifierType iType, int iScoreModifier) : base((int)iType, iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        SecondaryPopulationModifierType _type { get; set; }
    }
    public class SecondaryPopulationModifierGroup : FactionSettingGroup
    {
        public void Initialize()
        {
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitHisshoSecondaryTitle, 10)); // Serve With Honor
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitBenthysSecondaryTitle, 10)); // Euphorists
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitBhagabasSecondaryTitle, 10)); // Blissful Residents
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitDeuyivansSecondaryTitle, 5)); // Hydroponics Spec
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitEydersSecondaryTitle, 5)); // Catalyzation Specialists
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitGnashastsSecondaryTitle, 10)); // Rushless Defender
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitHaroshemsSecondaryTitle, 10)); // efficient farmers
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitHisshosSecondaryTitle, 5)); // Harshly-Trained Combatants
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitMavrosSecondaryTitle, 5)); // Hephaestian Workers
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitMezariSecondaryTitle, 5)); // Cryologists
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitNirisSecondaryTitle, 5)); // Prolific Farmers
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitPilgrimsSecondaryTitle, 5)); // Experimentalists
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitPulsosSecondaryTitle, 10)); // Anomaly Stalkers
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitRemnantSecondaryTitle, 5)); // TreasureHunters
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryDefenseFertileTitle, 5)); // Logisticians
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryDustMeagerTitle, 10)); // Dust Purists
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryHappinessHotTitle, 5)); // Warmhearted
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryHappinessTemperateTitle, 5)); // Naturalists
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryIndustryColdTitle, 5)); // Geothermal Specialists
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryIndustryMeagerTitle, 5)); // Self-Sustaining Laborers
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryScienceHotTitle, 5)); // Insulation Specialists
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitTerransSecondaryTitle, 5)); // Engaging Denizens
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitTikanansSecondaryTitle, 5)); // Bountiful Troops
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitUnfallenSecondaryTitle, 15)); // Bounteous Gardeners
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitVenetiansSecondaryTitle, 5)); // Dust Seekers
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitZvaliSecondaryTitle, 10)); // Scientistic Hobbyist
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryAntiDepletion01Title, 10)); // Planet Menders
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryHappinessSterileTitle, 10)); // Hardened Dwellers
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryIndustryFertileTitle, 10)); // Biomimetic Builders
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryStrategicToScience01Title, 15)); // Strategic Science
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryGroundBattleAttackerDamage01Title, 5)); // Public Minefields
        }

        public SecondaryPopulationModifier GetRandomSecondaryPopulationModifier(List<int> iExclusionList, int iPointValueLessThan)
        {
            return (SecondaryPopulationModifier)GetRandomSettingFromGroup(iExclusionList, iPointValueLessThan);
        }

        public SecondaryPopulationModifier GetRandomSecondaryPopulationModifier(int iPointValueLessThan)
        {
            return (SecondaryPopulationModifier)GetRandomSettingFromGroup(iPointValueLessThan);
        }
        public SecondaryPopulationModifier GetRandomSecondaryPopulationModifier()
        {
            return (SecondaryPopulationModifier)GetRandomSettingFromGroup();
        }
    }
}
