using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions.Traits
{
    public enum GameplayAffinityType
    {
        AffinityGameplayCravers        ,
        AffinityGameplaySophons        ,
        AffinityGameplayVenetians      ,
        AffinityGameplayVampirilis     ,
        AffinityGameplayTerrans        ,
        AffinityGameplayHoratio        ,
        AffinityGameplayTimeLords      ,
        AffinityGameplayUnfallen       ,
        AffinityGameplayVaulters       ,
        AffinityGameplayMajorHisshos   ,
        AffinityGameplayUmbralChoir
    }

    public class GameplayAffinity : FactionSetting
    {
        public GameplayAffinity(GameplayAffinityType iType, int iScoreModifier) : base((int)iType, iType.ToString(), iScoreModifier)
        {
            _type = iType;

            if (iType == GameplayAffinityType.AffinityGameplayVampirilis || iType == GameplayAffinityType.AffinityGameplayUmbralChoir)
            {
                _canHaveMinorPop = false;
            }
            else
            {
                _canHaveMinorPop = true;
            }
        }

        public GameplayAffinityType _type { get; set; }
        public bool _canHaveMinorPop { get; set; }
    }
    public class GameplayAffinityGroup : FactionSettingGroup
    {
        public void Initialize()
        {
            var affinityGameplayCravers       = new GameplayAffinity(GameplayAffinityType.AffinityGameplayCravers, 100);
            var affinityGameplaySophons       = new GameplayAffinity(GameplayAffinityType.AffinityGameplaySophons, 100);
            var affinityGameplayTerrans       = new GameplayAffinity(GameplayAffinityType.AffinityGameplayTerrans, 95);
            var affinityGameplayHoratio       = new GameplayAffinity(GameplayAffinityType.AffinityGameplayHoratio, 95);
            var affinityGameplayTimeLords     = new GameplayAffinity(GameplayAffinityType.AffinityGameplayTimeLords, 95);
            var affinityGameplayVampirilis    = new GameplayAffinity(GameplayAffinityType.AffinityGameplayVampirilis, 95);
            var affinityGameplayVenetians     = new GameplayAffinity(GameplayAffinityType.AffinityGameplayVenetians, 100);
            var affinityGameplayUnfallen      = new GameplayAffinity(GameplayAffinityType.AffinityGameplayUnfallen, 95);
            var affinityGameplayVaulters      = new GameplayAffinity(GameplayAffinityType.AffinityGameplayVaulters, 95);
            var affinityGameplayMajorHisshos  = new GameplayAffinity(GameplayAffinityType.AffinityGameplayMajorHisshos, 100);
            var affinityGameplayUmbralChoir   = new GameplayAffinity(GameplayAffinityType.AffinityGameplayUmbralChoir, 100);

            affinityGameplayVampirilis._exclusiveSet = new List<int>
            {
                (int)FactionTraitType.FactionTraitApatheticColonists,
                (int)FactionTraitType.FactionTraitFerventColonists1,
                (int)FactionTraitType.FactionTraitFerventColonists2,
                (int)FactionTraitType.FactionTraitCrowdedPlanets1,
                (int)FactionTraitType.FactionTraitCrowdedPlanets2,
                (int)FactionTraitType.FactionTraitGuardians,
                //(int)FactionTraitType.FactionTraitFactionTraitManualHomeSystem,
            };

            affinityGameplayVenetians._exclusiveSet = new List<int>
            {
                //(int)FactionTraitType.FactionTraitFactionTraitManualHomeSystem,
            };

            affinityGameplayUnfallen._exclusiveSet = new List<int>
            {
                (int)FactionTraitType.FactionTraitApatheticColonists,
                (int)FactionTraitType.FactionTraitFerventColonists1,
                (int)FactionTraitType.FactionTraitFerventColonists2,
                //(int)FactionTraitType.FactionTraitFactionTraitManualHomeSystem
            };

            affinityGameplayMajorHisshos._exclusiveSet = new List<int> 
            {
                (int)FactionTraitType.FactionTraitInimical,
                (int)FactionTraitType.FactionTraitContentCitizens1,
                (int)FactionTraitType.FactionTraitContentCitizens2,
                (int)FactionTraitType.FactionTraitCoreWorlds,
                (int)FactionTraitType.FactionTraitExpansionists1,
                (int)FactionTraitType.FactionTraitExpansionists2,
                (int)FactionTraitType.FactionTraitGuardians,
                (int)FactionTraitType.FactionTraitNaive1,
                (int)FactionTraitType.FactionTraitNaive2,
                (int)FactionTraitType.FactionTraitOptimistic1,
                (int)FactionTraitType.FactionTraitOptimistic2,
                (int)FactionTraitType.FactionTraitSmoothTalkers,
                (int)FactionTraitType.FactionTraitAntiExpansionists,
                (int)FactionTraitType.FactionTraitUtopianInfrastructure,
                (int)FactionTraitType.FactionTraitPessimistic1,
                (int)FactionTraitType.FactionTraitPessimistic2
            };

            affinityGameplayUmbralChoir._exclusiveSet = new List<int> 
            {
                (int)FactionTraitType.FactionTraitInimical,
                (int)FactionTraitType.FactionTraitApatheticColonists,
                (int)FactionTraitType.FactionTraitExtendedConsortium,
                (int)FactionTraitType.FactionTraitFerventColonists1,
                (int)FactionTraitType.FactionTraitFerventColonists2,
                (int)FactionTraitType.FactionTraitGuardians,
                //(int)FactionTraitType.FactionTraitFactionTraitManualHomeSystem,
                (int)FactionTraitType.FactionTraitNativeObliteratorProtection,
                (int)FactionTraitType.FactionTraitStartWithNegativeAnomaly,
                (int)FactionTraitType.FactionTraitStartWithPositiveAnomaly
            };

            _settingGroup.Add(affinityGameplayCravers        );
            _settingGroup.Add(affinityGameplaySophons        );
            _settingGroup.Add(affinityGameplayTerrans        );
            _settingGroup.Add(affinityGameplayHoratio        );
            _settingGroup.Add(affinityGameplayTimeLords      );
            _settingGroup.Add(affinityGameplayVampirilis     );
            _settingGroup.Add(affinityGameplayVenetians      );
            _settingGroup.Add(affinityGameplayUnfallen       );
            _settingGroup.Add(affinityGameplayVaulters       );
            _settingGroup.Add(affinityGameplayMajorHisshos   );
            _settingGroup.Add(affinityGameplayUmbralChoir    );
        }
        public GameplayAffinity GetRandomGameplayAffinity(List<int> iExclusionList, int iPointValueLessThan)
        {
            return (GameplayAffinity)GetRandomSettingFromGroup(iExclusionList, iPointValueLessThan);
        }

        public GameplayAffinity GetRandomGameplayAffinity(int iPointValueLessThan)
        {
            return (GameplayAffinity)GetRandomSettingFromGroup(iPointValueLessThan);
        }
        public GameplayAffinity GetRandomGameplayAffinity()
        {
            return (GameplayAffinity)GetRandomSettingFromGroup();
        }
    }
}
