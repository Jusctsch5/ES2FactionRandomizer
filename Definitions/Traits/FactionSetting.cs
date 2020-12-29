using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer
{
    public class FactionSetting
    {
        public FactionSetting(string iJsonString, int iScoreModifier)
        {
            _jsonString = iJsonString;
            _scoreModifier = iScoreModifier;
        }

        public string _jsonString { get; set; }
        public int _scoreModifier { get; set; }
    }

    /*
    <?xml version = "1.0" encoding="utf-8"?>
<MajorFaction xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" Name="786264be-f052-4efb-80c3-b74276052964" Author="Frogulous" Standard="false" Priority="0">
  <Affinity Name = "AffinityGameplayCravers" />
  < Trait Name="IsMajorFaction" />
  <Trait Name = "FactionTraitFearlessWarriors1" />
  < Trait Name="FactionTraitTechnologyDefinitionEconomyAndTrade1" />
  <Trait Name = "FactionTraitTechnologyDefinitionMilitary1" />
  < Trait Name="FactionTraitCrowdedPlanets1" />
  <Trait Name = "FactionTraitMinorNiris" />
  < Trait Name="FactionTraitBigFleets1" />
  <Trait Name = "FactionTraitIneptTraders" />
  < Trait Name="FactionTraitHomePlanetPlanetTypeTerran" />
  <Trait Name = "TraitCustomFaction" />
  < TraitStartingSenate Name="" SubCategory="" Priority="100">
    <Prerequisites />
    <UnlockedAbstractShipDesigns />
    <Government Name = "GovernmentDemocracy" />
    < PoliticsWeight Politics="Politics01" Weight="0" />
    <PoliticsWeight Politics = "Politics02" Weight="0" />
    <PoliticsWeight Politics = "Politics03" Weight="1" />
    <PoliticsWeight Politics = "Politics04" Weight="0" />
    <PoliticsWeight Politics = "Politics05" Weight="0" />
    <PoliticsWeight Politics = "Politics06" Weight="2" />
    <Cost>10</Cost>
  </TraitStartingSenate>
  <Bailiff Name = "DefaultMoneyBailiff" />
  < Bailiff Name="DefaultEmpirePointBailiff" />
  <MajorPopulation Affinity = "8e684513-e6a3-4c19-bdad-3bd349a54e51" Count="2" />
  <LocalizedDescription />
  <LocalizedName>Sophisticated Cravers</LocalizedName>
</MajorFaction>
        */
}
