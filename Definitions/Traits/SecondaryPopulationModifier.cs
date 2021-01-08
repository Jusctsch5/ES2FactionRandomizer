using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum SecondaryPopulationModifierType
    {
        PopulationModifiersTraitSecondaryNone,
        PopulationModifiersTraitSecondaryScienceCold,
        PopulationModifiersTraitSecondaryDustFertile,
        PopulationModifiersTraitSecondaryInfluenceTemperate,
        PopulationModifiersTraitSecondaryDefenseSterile,
        PopulationModifiersTraitSecondaryHappinessHot,
        PopulationModifiersTraitSecondaryFoodFertile02,
        PopulationModifiersTraitSecondaryFoodSterile,
        PopulationModifiersTraitSecondaryHappinessFertile,
        PopulationModifiersTraitSecondaryIndustryHot,
        PopulationModifiersTraitSecondaryFoodGas,
        PopulationModifiersTraitSecondaryScienceAnomaly01,
        PopulationModifiersTraitSecondaryScienceHappy,
        PopulationModifiersTraitSecondaryManpowerFertile,
        PopulationModifiersTraitSecondaryGroundBattleAttackerDamageFertile,
        PopulationModifiersTraitSecondaryDustGas,
        PopulationModifiersTraitSecondaryFoodFertile01,
        PopulationModifiersTraitSecondaryDustHappy,
        PopulationModifiersTraitSecondaryScienceAnomaly02,
        PopulationModifiersTraitSecondaryIndustrySterile,
        PopulationModifiersTraitSecondaryDustSterile,
        PopulationModifiersTraitSecondaryHappinessTemperate,
        PopulationModifiersTraitSecondaryIndustryCold,
        PopulationModifiersTraitSecondaryScienceHot,
        PopulationModifiersTraitSecondaryDefenseFertile,
        PopulationModifiersTraitSecondaryIndustryMeager,
        PopulationModifiersTraitSecondaryGroundBattleAttackerDamage01,
        PopulationModifiersTraitSecondaryManpower,
        PopulationModifiersTraitPrimaryInfluenceOnHot01,
        PopulationModifiersTraitSecondaryAntiDepletion01,
        PopulationModifiersTraitSecondaryHappinessSterile,
        PopulationModifiersTraitSecondaryIndustryFertile,
        PopulationModifiersTraitSecondaryStrategicToScience01,
    }

    public class SecondaryPopulationModifier : FactionSetting
    {
        public SecondaryPopulationModifier(SecondaryPopulationModifierType iType, int iScoreModifier) : base((int)iType, iType.ToString(), iScoreModifier)
        {
            _type = iType;
        }
        public SecondaryPopulationModifierType _type { get; set; }
    }
    public class SecondaryPopulationModifierGroup : FactionSettingGroup
    {
        public void Initialize()
        {
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryScienceCold, 5));       
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryDustFertile, 5));       
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryInfluenceTemperate, 5));
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryDefenseSterile, 5));    
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryHappinessHot, 5));      
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryFoodFertile02, 15));    
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryFoodSterile, 10));      
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryHappinessFertile, 10)); 
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryIndustryHot, 5));       
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryFoodGas, 5));           
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryScienceAnomaly01, 5));  
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryScienceHappy, 10));     
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryManpowerFertile, 5));   
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryGroundBattleAttackerDamageFertile, 10));
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryDustGas, 5));           
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryFoodFertile01, 5));     
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryDustHappy, 5));         
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryScienceAnomaly02, 10)); 
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryIndustrySterile, 5));   
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryDustSterile, 10));      
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryHappinessTemperate, 5));
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryIndustryCold, 5));        
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryScienceHot, 5));          
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryDefenseFertile, 5));      
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryGroundBattleAttackerDamage01, 5));
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryManpower, 5));          
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitPrimaryInfluenceOnHot01, 5));    
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryAntiDepletion01, 10));  
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryHappinessSterile, 10)); 
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryIndustryFertile, 10));  
            _settingGroup.Add(new SecondaryPopulationModifier(SecondaryPopulationModifierType.PopulationModifiersTraitSecondaryStrategicToScience01, 15)); 
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
