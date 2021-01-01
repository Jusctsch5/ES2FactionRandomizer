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
            _adjectiveList.Add(new List<string> { "Craving", "Enslaving", "Rabid", "Ravenous", "Murdering", "Infestatious"});
            _adjectiveList.Add(new List<string> { "Wise-Cracking", "Cranky", "Scientific", "Intelligent"});
            _adjectiveList.Add(new List<string> { "Conniving", "Big-Tiddy", "Filthy Rich" });
            _adjectiveList.Add(new List<string> { "Enslaving", "Conquering", "Supreme" });
            _adjectiveList.Add(new List<string> { "Communist", "Xenophobic", "Influencial"});
            _adjectiveList.Add(new List<string> { "Perfect"});
            _adjectiveList.Add(new List<string> { "Unga" });
            _adjectiveList.Add(new List<string> { "Bunga" });
            _adjectiveList.Add(new List<string> { "German" });
            _adjectiveList.Add(new List<string> { "Flat" });
            _adjectiveList.Add(new List<string> { "Super" });

            _nounList = new List<List<string>>();
            _nounList.Add(new List<string> { "Slavers", "Cyber-Insects" });
            _nounList.Add(new List<string> { "Sophons", "Geckos", "Greys", "Intellectuals"});
            _nounList.Add(new List<string> { "Lumris", "Fish Mommies", "Scalies", "Merchants", "Gangsters" });
            _nounList.Add(new List<string> { "Vodyani"});
            _nounList.Add(new List<string> { "United Empire", "Communists"});
            _nounList.Add(new List<string> { "Horatio"});
            _nounList.Add(new List<string> { "Riftborn", "Timelords" });
            _nounList.Add(new List<string> { "Unfallen" });
            _nounList.Add(new List<string> { "Vaulters" });
            _nounList.Add(new List<string> { "Hisshos" });
            _nounList.Add(new List<string> { "Umbral Choir" });

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
