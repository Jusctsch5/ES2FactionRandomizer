using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer
{
    class Randomizer
    {
        public Randomizer()
        {
            _matchGameplayAndVisualAffinity = true;
            _scoreAdherence = ScoreAdherenceType.ApproxScore;
        }
        public enum ScoreAdherenceType
        {
            None, // Resulting score will be random, i.e. don't adhere to any score.
            ExactScore,  // All must match desired score
            ApproxScore, // At score or no less than 20% desired score
        }

        public void GenerateRandomTraits()
        {

        }


        bool _matchGameplayAndVisualAffinity;
        ScoreAdherenceType _scoreAdherence;
        int _desiredScore;
    }
}
