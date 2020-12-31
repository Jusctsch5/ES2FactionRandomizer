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
        public CustomFaction()
        {

        }

        public CustomFaction(GameplayAffinity            iGameplay,
                             VisualAffinity              iVisual,
                             List<FactionTrait>          iFactionTraits,
                             HomePlanet                  iHomePlanet,
                             MinorPopulation             iPop, 
                             PrimaryPopulationModifier   iPrim, 
                             SecondaryPopulationModifier iSecondary,
                             TertiaryPopulationModifier  iTert,
                             PrimaryPolitics             iPrimaryPolitics,
                             SecondaryPolitics           iSecondaryPolitics1,
                             SecondaryPolitics           iSecondaryPolitics2,
                             Government                  iGovernment,
                             List<Tech> iTech)
        {
            _gameplayAffinity = iGameplay;
            _visualAffinity = iVisual;
            _factionTraits = iFactionTraits;
            _homePlanet = iHomePlanet;
            _minorPopulation = iPop;
            _primaryPopulationModifier = iPrim;
            _secondaryPopulationModifier = iSecondary;
            _tertiaryPopulationModifier = iTert;
            _primaryPolitics = iPrimaryPolitics;
            _secondaryPolitics1 = iSecondaryPolitics1;
            _secondaryPolitics2 = iSecondaryPolitics2;
            _government = iGovernment;
            _tech = iTech;
        }

        public int CalculatePopulationScore()
        {
            int score = 0;
            score += _visualAffinity._scoreModifier;
            score += _primaryPopulationModifier._scoreModifier;
            score += _secondaryPopulationModifier._scoreModifier;
            score += _tertiaryPopulationModifier._scoreModifier;
            score += _primaryPolitics._scoreModifier;
            score += _secondaryPolitics1._scoreModifier;
            score += _secondaryPolitics2._scoreModifier;
            return score;
        }
        public int CalculateTraitScore()
        {
            int score = 0;
            foreach (var trait in _factionTraits)
            {
                score += trait._scoreModifier;
            }

            score += _minorPopulation._scoreModifier;
            score += _homePlanet._scoreModifier;
            score += _government._scoreModifier;

            foreach (var tech in _tech)
            {
                score += tech._scoreModifier;
            }

            return score;
        }

        public int GetTraitScoreLimit()
        {
            return _gameplayAffinity._scoreModifier;
        }

        public GameplayAffinity _gameplayAffinity { get; set; }
        public VisualAffinity   _visualAffinity { get; set; }
        public List<FactionTrait> _factionTraits { get; set; }
        public HomePlanet _homePlanet { get; set; }
        public MinorPopulation _minorPopulation { get; set; }
        public PrimaryPopulationModifier _primaryPopulationModifier { get; set; }
        public SecondaryPopulationModifier _secondaryPopulationModifier { get; set; }
        public TertiaryPopulationModifier _tertiaryPopulationModifier { get; set; }
        public PrimaryPolitics _primaryPolitics { get; set; }
        public SecondaryPolitics _secondaryPolitics1 { get; set; }
        public SecondaryPolitics _secondaryPolitics2 { get; set; }
        public Government _government { get; set; }
        public List<Tech> _tech { get; set; }
    }
}
