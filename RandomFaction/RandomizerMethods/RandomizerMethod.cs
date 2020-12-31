using ES2FactionRandomizer.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.RandomFaction.RandomizerMethods
{
    abstract public class RandomizerMethod
    {
        abstract public CustomFaction GenerateRandomCustomFaction(TraitDefinitions iDefinitions, Preferences iPreferences);
        abstract public List<CustomFaction> GenerateRandomCustomFactions(int iNumbers, TraitDefinitions iDefinitions, Preferences iPreferences);
    }
}
