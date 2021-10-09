using ES2FactionRandomizer.Definitions;
using ES2FactionRandomizer.Definitions.Traits;
using ES2FactionRandomizer.RandomFaction;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ES2FactionRandomizer
{
    public class CustomFaction
    {
        public CustomFaction()
        {
            _gameplayAffinity = null;
            _visualAffinity = null;
            _factionTraits = new List<FactionTrait>();
            _homePlanet = null;
            _minorPopulation = null;
            _primaryPopulationModifier = null;
            _secondaryPopulationModifier = null;
            _tertiaryPopulationModifier = null;
            _primaryPolitics = null;
            _secondaryPolitics1 = null;
            _secondaryPolitics2 = null;
            _government = null;
            _tech = new List<Tech>();
            _factionName = "";
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
            _factionName = "";
        }

        public int CalculatePopulationScore()
        {
            int score = 0;
            score += _visualAffinity != null ? _visualAffinity._scoreModifier : 0;
            score += _primaryPopulationModifier != null ? _primaryPopulationModifier._scoreModifier : 0;
            score += _secondaryPopulationModifier != null ? _secondaryPopulationModifier._scoreModifier : 0;
            score += _tertiaryPopulationModifier != null ? _tertiaryPopulationModifier._scoreModifier : 0;
            score += _primaryPolitics != null ? _primaryPolitics._scoreModifier : 0;
            score += _secondaryPolitics1 != null ? _secondaryPolitics1._scoreModifier : 0;
            score += _secondaryPolitics2 != null ? _secondaryPolitics2._scoreModifier : 0;
            return score;
        }

        public int CalculateTraitScore()
        {
            int score = 0;
            foreach (var trait in _factionTraits)
            {
                score += trait._scoreModifier;
            }

            score += _minorPopulation != null ? _minorPopulation._scoreModifier : 0;
            score += _homePlanet != null ? _homePlanet._scoreModifier : 0;
            score += _government != null ? _government._scoreModifier : 0;

            foreach (var tech in _tech)
            {
                score += tech._scoreModifier;
            }

            return score;
        }

        public int CalculateTraits()
        {
            int traits = 0;
            traits += _tech.Count();
            traits += _factionTraits.Count();
            if (_minorPopulation != null)
            {
                traits++;
            }
            return traits;
        }

        public int GetPopulationScoreLimit()
        {
            return 60;
        }

        public int GetTraitScoreLimit()
        {
            return _gameplayAffinity._scoreModifier;
        }

        public int GetTraitLimit()
        {
            return 8;
        }

        public string FactionToString()
        {
            string factionStr = "Resulting Random Faction:\n";
            factionStr += "\nFaction:" + _gameplayAffinity?._type.ToString();
            factionStr += "\nVisual:" + _visualAffinity?._type.ToString();
            factionStr += "\nHomePlanet:" + _homePlanet?._type.ToString();
            factionStr += "\nGovernment:" + _government?._type.ToString();
            factionStr += "\nPrimPolitics:" + _primaryPolitics?._type.ToString();
            factionStr += "\nSecondaryPolitics1:" + _secondaryPolitics1?._type.ToString();
            factionStr += "\nSecondaryPolitics2:" + _secondaryPolitics2?._type.ToString();
            factionStr += "\nPrimPopMod:" + _primaryPopulationModifier?._type.ToString();
            factionStr += "\nSecPopMod:" + _secondaryPopulationModifier?._type.ToString();
            factionStr += "\nTerPopMod:" + _tertiaryPopulationModifier?._type.ToString();
            factionStr += "\nMinorPop:" + _minorPopulation?._type.ToString();
            factionStr += "\nTechs";
            foreach (var techSingle in _tech)
            {
                factionStr += "\n\tTech:" + techSingle._type.ToString();
            }
            factionStr += "\nTraits";
            foreach (var factionTraits in _factionTraits)
            {
                factionStr += "\n\tTrait:" + factionTraits._type.ToString();
            }

            factionStr += "\nPopulation Score: " + CalculatePopulationScore() + "/60";
            factionStr += "\nTrait Score: " + CalculateTraitScore() + "/" + GetTraitScoreLimit();
            factionStr += "\nTrait Count: " + CalculateTraits() + "/8";
            factionStr += "\n\n";
            return factionStr;
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
        public string _factionName { get; set; }
        public string _visualAffinityUuidStr { get; set; }
        public string _gameplayAffinityUuidStr { get; set; }

        public void Initialize()
        {
            _factionName = FactionNames.GetRandomAdjective(_gameplayAffinity._type) + " " + FactionNames.GetRandomNoun(_visualAffinity._type);
            _gameplayAffinityUuidStr = Guid.NewGuid().ToString();
            _visualAffinityUuidStr = Guid.NewGuid().ToString();
        }

        public string RemoveMatchingLine(string iInputString, string iMatch)
        {
            string newString = string.Empty;
            using (StringReader reader = new StringReader(iInputString))
            {
                string line = string.Empty;
                while (true)
                {
                    line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
   
                    if (line.Contains(iMatch))
                    { 
                        // pass
                    }
                    else
                    {
                        newString += "\n" + line;
                    }
                } 
            }

            return newString;
        }
        
        public string CreatePopulationXmlString()
        {
            string populationStr = 
@"<?xml version=""1.0"" encoding=""utf-8""?>
<PopulationDefinition xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" AffinityName=""$VISUALAFFINITYUUID"" LocalizedName=""$FACTIONNAME"" UniquePopulationId=""2"">
  <DefaultPolitics>
    <Politics BaseScore=""1"" BaseTrend=""0"" PoliticsReference=""$POLITICS"" />
  </DefaultPolitics>
  <Trait Name=""$POLPRIM"" />
  <Trait Name=""$POLSEC1"" />
  <Trait Name=""$POLSEC2"" />
  <Trait Name=""$POPMOD"" />
  <Trait Name=""$POPPRIM"" />
  <Trait Name=""$POPSEC"" />
  <Trait Name=""$POPTRI"" />
  <AffinityMapping Name=""$VISUALAFFINITY"" />
  <GrowthBoostLuxuryOptions>
    <Luxury>Luxury1</Luxury>
    <Luxury>Luxury2</Luxury>
    <Luxury>Luxury3</Luxury>
    <Luxury>Luxury4</Luxury>
    <Luxury>Luxury5</Luxury>
    <Luxury>Luxury6</Luxury>
    <Luxury>Luxury7</Luxury>
    <Luxury>Luxury8</Luxury>
  </GrowthBoostLuxuryOptions>
</PopulationDefinition>";

            Console.Write(populationStr);
            populationStr = populationStr.Replace("$FACTIONNAME", _factionName);
            populationStr = populationStr.Replace("$POLITICS", _primaryPolitics.GetPoliticsReference());
            populationStr = populationStr.Replace("$VISUALAFFINITYUUID", _visualAffinityUuidStr);
            populationStr = populationStr.Replace("$VISUALAFFINITY", _visualAffinity._jsonString);
            populationStr = populationStr.Replace("$POLPRIM", _primaryPolitics._jsonString);

            if (_secondaryPolitics1 == null)
            {
                populationStr = RemoveMatchingLine(populationStr, "$POLSEC1");
            }
            else
            {
                populationStr = populationStr.Replace("$POLSEC1", _secondaryPolitics1._jsonString);
            }

            if (_secondaryPolitics2 == null)
            {
                populationStr = RemoveMatchingLine(populationStr, "$POLSEC2");
            }
            else
            {
                populationStr = populationStr.Replace("$POLSEC2", _secondaryPolitics2._jsonString);
            }

            if (_visualAffinity == null)
            {
                populationStr = RemoveMatchingLine(populationStr, "$POPMOD");
            }
            else
            {
                populationStr = populationStr.Replace("$POPMOD", _visualAffinity.GetPopulationModifierTrait());
            }

            if (_primaryPopulationModifier == null)
            {
                populationStr = RemoveMatchingLine(populationStr, "$POPPRIM");
            }
            else
            {
                populationStr = populationStr.Replace("$POPPRIM", _primaryPopulationModifier._jsonString);
            }

            if (_secondaryPopulationModifier == null)
            {
                populationStr = RemoveMatchingLine(populationStr, "$POPSEC");
            }
            else
            {
                populationStr = populationStr.Replace("$POPSEC", _secondaryPopulationModifier._jsonString);
            }

            if (_tertiaryPopulationModifier == null)
            {
                populationStr = RemoveMatchingLine(populationStr, "$POPTRI");
            }
            else
            {
                populationStr = populationStr.Replace("$POPTRI", _tertiaryPopulationModifier._jsonString);
            }

            populationStr = Regex.Replace(populationStr, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
            return populationStr;
        }

        public string CreateFactionXmlString()
        {
            string factionStr = 
@"<?xml version=""1.0"" encoding=""utf-8""?>
<MajorFaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" Name=""$UUID"" Author=""Random"" Standard=""false"" Priority=""0"">
  <Affinity Name=""$GAMEPLAYAFFINITY"" />
  <Trait Name=""IsMajorFaction"" />
$FACTIONTRAITS
$TECHS
$MINORPOP
  <Trait Name=""$HOMEPLANET"" />
  <Trait Name=""TraitCustomFaction"" />
  <TraitStartingSenate Name="""" SubCategory="""" Priority=""100"">
    <Prerequisites />
    <UnlockedAbstractShipDesigns />
    <Government Name=""$GOVERNMENT"" />
$POLITICSWEIGHT
    <Cost>10</Cost>
  </TraitStartingSenate>
  <Bailiff Name=""DefaultMoneyBailiff"" />
  <Bailiff Name=""DefaultEmpirePointBailiff"" />
  <MajorPopulation Affinity=""$VISUALAFFINITY"" Count=""2"" />
  <LocalizedDescription>Herro.</LocalizedDescription>
  <LocalizedName>$FACTIONNAME</LocalizedName>
</MajorFaction>";

            factionStr = factionStr.Replace("$UUID", Guid.NewGuid().ToString());
            factionStr = factionStr.Replace("$GAMEPLAYAFFINITY", _gameplayAffinity._jsonString);
            factionStr = factionStr.Replace("$GOVERNMENT", _government._jsonString);
            factionStr = factionStr.Replace("$HOMEPLANET", _homePlanet._jsonString);
            if (_minorPopulation != null)
            {
                factionStr = factionStr.Replace("$MINORPOP", "  <Trait Name=\"" + _minorPopulation._jsonString+ "\" />");
            }
            else
            {
                factionStr = factionStr.Replace("$MINORPOP", "");
            }

            factionStr = factionStr.Replace("$VISUALAFFINITY", _visualAffinityUuidStr);
            factionStr = factionStr.Replace("$FACTIONNAME", _factionName);
            factionStr = factionStr.Replace("$POLITICSWEIGHT", createPoliticsWeightString());

            string traitXmlString = "";
            var last = _factionTraits.Last();
            foreach (var trait in _factionTraits)
            {
                traitXmlString += "  <Trait Name=\"" + trait._jsonString + "\" />";
                if (trait != last)
                {
                    traitXmlString += System.Environment.NewLine;
                }
            }
            factionStr = factionStr.Replace("$FACTIONTRAITS", traitXmlString);

            string techXmlString = "";
            var lastTech = _tech.Last();
            foreach (var tech in _tech)
            {
                techXmlString += "  <Trait Name=\"" + tech._jsonString + "\" />";
                if (tech != lastTech)
                {
                    techXmlString += System.Environment.NewLine;
                }
            }
            factionStr = factionStr.Replace("$TECHS", techXmlString);

            factionStr = Regex.Replace(factionStr, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
            return factionStr;
        }

        private string createPoliticsWeightString()
        {
            string politicsWeightString = "";

            switch (_primaryPolitics._type)
            {
                case PrimaryPoliticsType.PopulationPoliticalTraitIndustrialist:
                 politicsWeightString = @"    <PoliticsWeight Politics=""Politics01"" Weight=""2"" />
    <PoliticsWeight Politics=""Politics02"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics03"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics04"" Weight=""1"" />
    <PoliticsWeight Politics=""Politics05"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics06"" Weight=""0"" />";

                    break;
                case PrimaryPoliticsType.PopulationPoliticalTraitPacifist:
                    politicsWeightString = @"    <PoliticsWeight Politics=""Politics01"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics02"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics03"" Weight=""2"" />
    <PoliticsWeight Politics=""Politics04"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics05"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics06"" Weight=""1"" />";
                    break;
                case PrimaryPoliticsType.PopulationPoliticalTraitScientific:
                    politicsWeightString = @"    <PoliticsWeight Politics=""Politics01"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics02"" Weight=""2"" />
    <PoliticsWeight Politics=""Politics03"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics04"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics05"" Weight=""1"" />
    <PoliticsWeight Politics=""Politics06"" Weight=""0"" />";
                    break;
                case PrimaryPoliticsType.PopulationPoliticalTraitReligious:
                    politicsWeightString = @"    <PoliticsWeight Politics=""Politics01"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics02"" Weight=""1"" />
    <PoliticsWeight Politics=""Politics03"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics04"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics05"" Weight=""2"" />
    <PoliticsWeight Politics=""Politics06"" Weight=""0"" />";
                    break;
                case PrimaryPoliticsType.PopulationPoliticalTraitMilitarist:
                    politicsWeightString = @"    <PoliticsWeight Politics=""Politics01"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics02"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics03"" Weight=""1"" />
    <PoliticsWeight Politics=""Politics04"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics05"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics06"" Weight=""2"" />";
                    break;
                case PrimaryPoliticsType.PopulationPoliticalTraitEcologist:
                    politicsWeightString = @"    <PoliticsWeight Politics=""Politics01"" Weight=""1"" />
    <PoliticsWeight Politics=""Politics02"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics03"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics04"" Weight=""2"" />
    <PoliticsWeight Politics=""Politics05"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics06"" Weight=""0"" />";
                    break;
            }

            return politicsWeightString;
        }
    }
}