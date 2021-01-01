﻿using ES2FactionRandomizer.Definitions;
using ES2FactionRandomizer.Definitions.Traits;
using ES2FactionRandomizer.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2FactionRandomizer.RandomFaction.RandomizerMethods
{
    public class GreedyMethod : RandomizerMethod
    {
        public override CustomFaction GenerateRandomCustomFaction(TraitDefinitions iDefinitions, Preferences iPreferences)
        {

            ///
            // Handle Required Traits
            ///

            var faction = new CustomFaction();
            faction._gameplayAffinity = iDefinitions._gameplayAffinityGroup.GetRandomGameplayAffinity();
            if (iPreferences._matchAffinityType == Preferences.MatchAffinityType.MatchAffinity)
            {
                faction._visualAffinity = iDefinitions._visualAffinityGroup.GetVisualAffinity((VisualAffinityType)faction._gameplayAffinity._id);
            }   
            else
            {
                faction._visualAffinity = iDefinitions._visualAffinityGroup.GetRandomVisualAffinity();
            }
            faction._government = iDefinitions._governmentGroup.GetRandomGovernment();
            faction._homePlanet = iDefinitions._homePlanetGroup.GetRandomHomePlanet();

            ///
            // Handle Population Traits.
            ///

            faction._primaryPolitics = iDefinitions._primaryPoliticsGroup.GetRandomPrimaryPolitics();

            ///
            // Manage the optional population traits.
            // PrimaryPolitics (assigned, not optional), SecondaryPolitics (1), SecondaryPolitics (2)
            // PrimaryPopulationModifier (3), SecondaryPopulationModifier (4), TertiaryPopulationModifier (5)
            // TODO - handle the valid case where nothing is found based on remaining points.
            // Need to make sure recorded as "None".
            ///

            var populationTraits = new List<int> { 1, 2, 3, 4, 5 };
            RandomUtil.Shuffle(populationTraits); // hack to make sure we don't consistently blow our points on the first catagories
            foreach (int popTrait in populationTraits)
            {
                int desiredPopTraitPoints = iPreferences._desiredPopScore;
                int remainingPopTraitPoints = desiredPopTraitPoints - faction.CalculatePopulationScore();
                var secondaryPoliticsChosen = new List<int>();
                switch (popTrait)
                {
                    case 1:
                        faction._secondaryPolitics1 = iDefinitions._secondaryPoliticsGroup.GetRandomSecondaryPolitics(secondaryPoliticsChosen, remainingPopTraitPoints);
                        secondaryPoliticsChosen.Add(faction._secondaryPolitics1._id);
                        break;
                    case 2:
                        faction._secondaryPolitics2 = iDefinitions._secondaryPoliticsGroup.GetRandomSecondaryPolitics(secondaryPoliticsChosen, remainingPopTraitPoints);
                        secondaryPoliticsChosen.Add(faction._secondaryPolitics2._id);
                        break;
                    case 3:
                        faction._primaryPopulationModifier = iDefinitions._primaryPopulationModifierGroup.GetRandomPrimaryPopulationModifier(remainingPopTraitPoints);
                        break;
                    case 4:
                        faction._secondaryPopulationModifier = iDefinitions._secondaryPopulationModifierGroup.GetRandomSecondaryPopulationModifier(remainingPopTraitPoints);
                        break;
                    case 5:
                        faction._tertiaryPopulationModifier = iDefinitions._tertiaryPopulationModifierGroup.GetRandomTertiaryPopulationModifier(remainingPopTraitPoints);
                        break;
                    default:
                        break;
                }
            }

            ///
            // Handle possibly guaranteed minor population and tech traits
            ///

            int desiredTraitScore = iPreferences._desiredTraitScore;
            int remainingTraitScore = desiredTraitScore - faction.CalculateTraitScore();

            if (iPreferences._guaranteeTechType == Preferences.GuaranteeTechType.Guarantee1Tech)
            {
                faction._tech.Add(iDefinitions._techGroup.GetRandomTech());
            }
            else if (iPreferences._guaranteeTechType == Preferences.GuaranteeTechType.Guarantee2Tech)
            {
                var tech1 = iDefinitions._techGroup.GetRandomTech();
                List<int> excludeTech = new List<int> { tech1._id };
                var tech2 = iDefinitions._techGroup.GetRandomTech(excludeTech, remainingTraitScore);
                faction._tech.Add(tech1);
                faction._tech.Add(tech2);
            }

            if (iPreferences._guaranteeMinorPopulationType == Preferences.GuaranteeMinorPopulationType.GuaranteeMinorPopulation)
            {
                faction._minorPopulation = iDefinitions._minorPopulationGroup.GetRandomMinorPopulation();
            }

            ///
            // Handle faction traits
            // - Want a couple skills to define the faction (25-40 points)
            // - A couple downsides
            // - A handful of minor buffs
            ///

            remainingTraitScore = desiredTraitScore - faction.CalculateTraitScore();
            List<int> excludeTraits = new List<int>();
            var trait = iDefinitions._factionTraitGroup.GetRandomFactionTraitMinPoints(excludeTraits, 25);
            excludeTraits.Add(trait._id);
            faction._factionTraits.Add(trait);

            trait = iDefinitions._factionTraitGroup.GetRandomFactionTraitMinPoints(excludeTraits, 25);
            excludeTraits.Add(trait._id);
            faction._factionTraits.Add(trait);

            trait = iDefinitions._factionTraitGroup.GetRandomFactionTraitRange(excludeTraits, -25, -10);
            excludeTraits.Add(trait._id);
            faction._factionTraits.Add(trait);

            trait = iDefinitions._factionTraitGroup.GetRandomFactionTraitRange(excludeTraits, 5, 10);
            excludeTraits.Add(trait._id);
            faction._factionTraits.Add(trait);

            trait = iDefinitions._factionTraitGroup.GetRandomFactionTraitRange(excludeTraits, 5, 10);
            excludeTraits.Add(trait._id);
            faction._factionTraits.Add(trait);

            trait = iDefinitions._factionTraitGroup.GetRandomFactionTraitRange(excludeTraits, 5, 10);
            excludeTraits.Add(trait._id);
            faction._factionTraits.Add(trait);

            return faction;
        }

        public override List<CustomFaction> GenerateRandomCustomFactions(int iNumbers, TraitDefinitions iDefinitions, Preferences iPreferences)
        {
            List<CustomFaction> customFactionList = new List<CustomFaction>();
            for (int i = 0; i < iNumbers; i++)
            {
                CustomFaction newFaction = GenerateRandomCustomFaction(iDefinitions, iPreferences);
                customFactionList.Add(newFaction);
            }

            return customFactionList;
        }
    }
}