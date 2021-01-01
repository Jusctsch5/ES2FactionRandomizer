using ES2FactionRandomizer.Definitions;
using ES2FactionRandomizer.Definitions.Traits;
using ES2FactionRandomizer.RandomFaction;
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

        public int GetTraitScoreLimit()
        {
            return _gameplayAffinity._scoreModifier;
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

        public void Initialize()
        {
            _factionName = FactionNames.GetRandomAdjective(_gameplayAffinity._type) + " " + FactionNames.GetRandomNoun(_visualAffinity._type);
        }

        public string ExportToXmlString()
        {
            string verbatimTestStr = @"
<?xml version=""1.0"" encoding=""utf - 8""?>
<MajorFaction xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" Name=""$UUID"" Author=""Random"" Standard=""false"" Priority=""0"">
  <Affinity Name=""$GAMEPLAYAFFINITY"" />
  <Trait Name=""IsMajorFaction"" />
$FACTIONTRAITS
  <TraitStartingSenate Name="""" SubCategory="""" Priority=""100"">
    <Prerequisites />
    <UnlockedAbstractShipDesigns />
    <Government Name=""$GOVERNMENT"" />
    <PoliticsWeight Politics=""Politics01"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics02"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics03"" Weight=""2"" />
    <PoliticsWeight Politics=""Politics04"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics05"" Weight=""0"" />
    <PoliticsWeight Politics=""Politics06"" Weight=""1"" />
    <Cost>10</Cost>
  </TraitStartingSenate>
  <Bailiff Name=""DefaultMoneyBailiff"" />
  <Bailiff Name=""DefaultEmpirePointBailiff"" />
  <MajorPopulation Affinity=""$VISUALAFFINITY"" Count=""2"" />
  <LocalizedDescription />
  <LocalizedName>$FACTIONNAME</LocalizedName>
</MajorFaction>";

            verbatimTestStr = verbatimTestStr.Replace("$UUID", Guid.NewGuid().ToString());
            verbatimTestStr = verbatimTestStr.Replace("$GAMEPLAYAFFINITY", _gameplayAffinity._jsonString);
            verbatimTestStr = verbatimTestStr.Replace("$GOVERNMENT", _government._jsonString);
            verbatimTestStr = verbatimTestStr.Replace("$VISUALAFFINITY", VisualAffinity.ConvertAffinityTypeToUuidStr(_visualAffinity._type));

            verbatimTestStr = verbatimTestStr.Replace("$FACTIONNAME", _factionName);

            string traitXmlString = "";
            foreach (var trait in _factionTraits)
            {
                traitXmlString += "  <Trait Name=\"" + trait._jsonString + "\" />\n";
            }
            traitXmlString.TrimEnd(traitXmlString[traitXmlString.Length - 1]);

            verbatimTestStr = verbatimTestStr.Replace("$FACTIONTRAITS", traitXmlString);

            return verbatimTestStr;
        }
    }
}