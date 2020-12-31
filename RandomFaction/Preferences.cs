using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.RandomFaction
{
    public class Preferences
    {
        public Preferences()
        {
            _matchAffinityType = MatchAffinityType.DoNotMatchAffinity;
            _scoreAdherence = ScoreAdherenceType.ApproxScore;
            _approxScoreModifier = 0.1F;
            _traitScoreType = TraitScoreType.BasedOnGameplayAffinity;

            // Settings attempt to create a legal custom faction as per ES2 rules
            _desiredTraitScore = 100;
            _desiredPopScore = 60;
            _maxTraitCount = 8;
            _guaranteeMinorPopulationType = GuaranteeMinorPopulationType.GuaranteeMinorPopulation;
            _guaranteeTechType = GuaranteeTechType.Guarantee1Tech;
        }

        public enum MatchAffinityType
        {
            MatchAffinity,
            DoNotMatchAffinity,
        }
        public enum ScoreAdherenceType
        {
            None, // Resulting score will be random, i.e. don't adhere to any score.
            ExactScore,  // All must match desired score
            ApproxScore, // At score or no less than % desired score
        }
        public enum TraitScoreType
        {
            BasedOnGameplayAffinity,
            SetValue
        }

        public enum GuaranteeMinorPopulationType
        {
            DoNotGuaranteeMinorPopulation,
            GuaranteeMinorPopulation,
        }

        public enum GuaranteeTechType
        {
            DoNotGuaranteeTech,
            Guarantee1Tech,
            Guarantee2Tech,
        }

        public MatchAffinityType _matchAffinityType { get; private set; }
        public ScoreAdherenceType _scoreAdherence { get; private set; }
        public float _approxScoreModifier { get; private set; }
        public TraitScoreType _traitScoreType { get; private set; }
        public int _desiredTraitScore { get; private set; }
        public int _desiredPopScore { get; private set; }
        public int _maxTraitCount { get; private set; }

        public GuaranteeMinorPopulationType _guaranteeMinorPopulationType { get; private set; }
        public GuaranteeTechType _guaranteeTechType { get; private set; }
    }

}
