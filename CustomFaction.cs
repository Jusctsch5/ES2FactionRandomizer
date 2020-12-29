using ES2FactionRandomizer.Definitions;
using ES2FactionRandomizer.Definitions.Traits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer
{
    public class CustomFaction
    {
        public CustomFaction(GameplayAffinity            iGameplay,
                             VisualAffinity              iVisual,
                             List<FactionTrait>          iFactionTraits,
                             HomePlanet                  iHomePlanet,
                             Population                  iPop, 
                             PrimaryPopulationModifier   iPrim, 
                             SecondaryPopulationModifier iSecondary,
                             TertiaryPopulationModifier  iTert,
                             PrimaryPolitics             iPrimaryPolitics,
                             SecondaryPolitics           iSecondaryPolitics1,
                             SecondaryPolitics           iSecondaryPolitics2,
                             Government                  iGovernment)
        {
            _affinityGameplay = iGameplay;
            _visualAffinity = iVisual;
            _factionTraits = iFactionTraits;
            _homePlanet = iHomePlanet;
            _population = iPop;
            _primaryPopulationModifier = iPrim;
            _secondaryPopulationModifier = iSecondary;
            _tertiaryPopulationModifier = iTert;
            _primaryPolitics = iPrimaryPolitics;
            _secondaryPolitics1 = iSecondaryPolitics1;
            _secondaryPolitics2 = iSecondaryPolitics2;
            _government = iGovernment;
        }

        public GameplayAffinity _affinityGameplay { get; set; }
        public VisualAffinity     _visualAffinity { get; set; }
        public List<FactionTrait> _factionTraits { get; set; }
        public HomePlanet _homePlanet { get; set; }
        public Population _population { get; set; }
        public PrimaryPopulationModifier _primaryPopulationModifier { get; set; }
        public SecondaryPopulationModifier _secondaryPopulationModifier { get; set; }
        public TertiaryPopulationModifier _tertiaryPopulationModifier { get; set; }
        public PrimaryPolitics _primaryPolitics { get; set; }
        public SecondaryPolitics _secondaryPolitics1 { get; set; }
        public SecondaryPolitics _secondaryPolitics2 { get; set; }
        public Government _government { get; set; }
    }
}
