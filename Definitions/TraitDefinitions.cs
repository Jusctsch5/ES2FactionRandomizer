using ES2FactionRandomizer.Definitions.Traits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.Definitions
{ 
    public class TraitDefinitions
    {
        public TraitDefinitions()
        {
            _gameplayAffinityGroup = new GameplayAffinityGroup();
            _visualAffinityGroup = new VisualAffinityGroup();
            _factionTraitGroup = new FactionTraitGroup();
            _homePlanetGroup = new HomePlanetGroup();
            _minorPopulationGroup = new MinorPopulationGroup();
            _primaryPopulationModifierGroup = new PrimaryPopulationModifierGroup();
            _secondaryPopulationModifierGroup = new SecondaryPopulationModifierGroup();
            _tertiaryPopulationModifierGroup = new TertiaryPopulationModifierGroup();
            _primaryPoliticsGroup = new PrimaryPoliticsGroup();
            _secondaryPoliticsGroup = new SecondaryPoliticsGroup();
            _governmentGroup = new GovernmentGroup();
            _techGroup = new TechGroup();
        }

        public void Initialize()
        {
            _gameplayAffinityGroup.Initialize();
            _visualAffinityGroup.Initialize();
            _factionTraitGroup.Initialize();
            _homePlanetGroup.Initialize();
            _minorPopulationGroup.Initialize();
            _primaryPopulationModifierGroup.Initialize();
            _secondaryPopulationModifierGroup.Initialize();
            _tertiaryPopulationModifierGroup.Initialize();
            _primaryPoliticsGroup.Initialize();
            _secondaryPoliticsGroup.Initialize();
            _governmentGroup.Initialize();
            _techGroup.Initialize();
        }

        public GameplayAffinityGroup _gameplayAffinityGroup { get; private set; }
        public VisualAffinityGroup _visualAffinityGroup { get; private set; }
        public FactionTraitGroup _factionTraitGroup { get; private set; }
        public HomePlanetGroup _homePlanetGroup { get; private set; }
        public MinorPopulationGroup _minorPopulationGroup { get; private set; }
        public PrimaryPopulationModifierGroup _primaryPopulationModifierGroup { get; private set; }
        public SecondaryPopulationModifierGroup _secondaryPopulationModifierGroup { get; private set; }
        public TertiaryPopulationModifierGroup _tertiaryPopulationModifierGroup { get; private set; }
        public PrimaryPoliticsGroup _primaryPoliticsGroup { get; private set; }
        public SecondaryPoliticsGroup _secondaryPoliticsGroup { get; private set; }
        public GovernmentGroup _governmentGroup { get; private set; }
        public TechGroup _techGroup { get; private set; }
    }
}
