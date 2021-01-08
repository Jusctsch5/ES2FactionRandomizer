using ES2FactionRandomizer.Definitions;
using ES2FactionRandomizer.RandomFaction.RandomizerMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.RandomFaction
{
    public class FactionCreator
    {
        public FactionCreator(RandomizerMethod iRandomMethod, TraitDefinitions iTraitDefinition, Preferences iPreferences)
        {
            _randomizerMethod = iRandomMethod;
            _definitions = iTraitDefinition;
            _definitions.Initialize();
            _preferences = iPreferences;
        }
        public CustomFaction GenerateRandomFaction()
        {
            CustomFaction faction = _randomizerMethod.GenerateRandomCustomFaction(_definitions, _preferences);
            faction.Initialize();
            return faction;
        }

        RandomizerMethod _randomizerMethod;
        Preferences _preferences;
        TraitDefinitions _definitions;
    }
}
