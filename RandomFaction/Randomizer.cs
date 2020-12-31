using ES2FactionRandomizer.Definitions;
using ES2FactionRandomizer.RandomFaction.RandomizerMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.RandomFaction
{
    class Randomizer
    {
        public Randomizer(RandomizerMethod iRandomMethod, Preferences iPreferences)
        {
            _randomizerMethod = iRandomMethod;
            _definitions = new TraitDefinitions();
            _definitions.Initialize();
        }
        public void GenerateRandomFaction()
        {
            _randomizerMethod.GenerateRandomCustomFaction(_definitions, _preferences);
        }

        RandomizerMethod _randomizerMethod;
        Preferences _preferences;
        TraitDefinitions _definitions;
    }
}
