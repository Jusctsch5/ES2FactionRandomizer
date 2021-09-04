using ES2FactionRandomizer.Definitions.Traits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.RandomFaction
{
    public static class FactionNames
    {
        static List<List<string>> _adjectiveList;
        static List<List<string>> _nounList;
        static Random _rand;

        static public void Initialize()
        {
            // Cravers        
            // Sophons        
            // Lumeris        
            // Vodyani        
            // United Empire        
            // Horatio        
            // Riftborn      
            // Trees     
            // Vaulters       
            // MajorHisshos   
            // UmbralChoir

            _adjectiveList = new List<List<string>>();
            _adjectiveList.Add(new List<string> { "Craving", "Enslaving", "Rabid", "Ravenous", "Murdering", "Infestatious", "Cyber"});
            _adjectiveList.Add(new List<string> { "Wise Cracking", "Cranky", "Scientific", "Intelligent"});
            _adjectiveList.Add(new List<string> { "Conniving", "Big Tiddy", "Filthy Rich" });
            _adjectiveList.Add(new List<string> { "Enslaving", "Conquering", "Supreme" });
            _adjectiveList.Add(new List<string> { "Communist", "Xenophobic", "Influencial"});
            _adjectiveList.Add(new List<string> { "Perfect", "Xenophobic", "Big Brained"});
            _adjectiveList.Add(new List<string> { "Robotic", "Other Dimensional", "Traveling" });
            _adjectiveList.Add(new List<string> { "Passive", "Cautious", "Kindly", "Wizened",  });
            _adjectiveList.Add(new List<string> { "German", "Nordic", "Proud", "Pirate Loving" });
            _adjectiveList.Add(new List<string> { "Flat", "Wide", "Red Breasted", "White Billed", "Tall" });
            _adjectiveList.Add(new List<string> { "Super", "Silent", "L33t", "Invisible" });

            _nounList = new List<List<string>>();
            _nounList.Add(new List<string> { "Slavers", "Insects", "Killers" });
            _nounList.Add(new List<string> { "Sophons", "Geckos", "Greys", "Intellectuals"});
            _nounList.Add(new List<string> { "Lumris", "Fish Mommies", "Scalies", "Merchants", "Gangsters" });
            _nounList.Add(new List<string> { "Vodyani", "Androids", "Priests"});
            _nounList.Add(new List<string> { "Empire", "Communists", "Russians"});
            _nounList.Add(new List<string> { "Horatio", "Besosi", "Jeffs", "Big Heads"});
            _nounList.Add(new List<string> { "Riftborn", "Timelords", "Aliens" });
            _nounList.Add(new List<string> { "Unfallen", "Trees", "Branch" });
            _nounList.Add(new List<string> { "Vaulters", "Vikings", "Bandits", "Vault Boys", "Privateers" });
            _nounList.Add(new List<string> { "Hisshos", "Wadeshos", "Birds", "Bird People", "Squakers" });
            _nounList.Add(new List<string> { "Ghosts", "Choir", "Choir Boys", "Hackers" });

            _rand = new Random();
        }

        static public string GetRandomAdjective(GameplayAffinityType iAffinity)
        {
            var adjectiveList = _adjectiveList[(int)iAffinity];
            if (adjectiveList.Count() == 0)
            {
                return "";
            }

            return adjectiveList[_rand.Next(adjectiveList.Count())];
        }
        static public string GetRandomNoun(VisualAffinityType iAffinity)
        {
            var nounList = _nounList[(int)iAffinity];
            if (nounList.Count() == 0)
            {
                return "";
            }

            return nounList[_rand.Next(nounList.Count())];
        }
    }
}
