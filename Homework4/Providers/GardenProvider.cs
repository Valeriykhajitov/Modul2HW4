using Homework4.Abstractions;
using Homework4.Enums;
using Homework4.Models.Plants;
using Homework4.Models.Plants.Bushes.BerryBushes;
using Homework4.Models.Plants.Bushes.FruitBushes;
using Homework4.Models.Plants.Flowers;
using Homework4.Models.Plants.Trees.ConiferousTrees.Pines;
using Homework4.Models.Plants.Trees.ConiferousTrees.Yew;
using Homework4.Models.Plants.Trees.DeciduousTrees.Acacia;
using Homework4.Models.Plants.Trees.DeciduousTrees.Lindens;
using Homework4.Models.Plants.Trees.DeciduousTrees.Willows;
using Homework4.Models.Plants.Trees.PalmTrees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Providers
{
  public class GardenProvider : IGardenProvider
  {
    public GardenProvider()
    {
      Garden = new Plant[]
      {
        new Willow
        {
          Name = "Knotted Willow",
          Origin = "Belgium",
          Height = 225,
          RootsType = Enums.RootsType.Sinker,
          LeavesLength = 0.12
        },

        new BerryBush
        {
          Name = "Thornless Gooseberry",
          Origin = "Russia",
          Height = 0.451,
          bushType = BushType.Rosette,
          BushBerries = BushBerries.Gooseberry,
        },

        new Flower
        {
          Name = "Rose",
          Origin = "Netherlands",
          Height = 0.032,
          StemLength = 0.025,
        },

        new Yew
        {
          Name = "English Yew",
          Origin = "England",
          Height = 3.12,
          RootsType = RootsType.Sinker,
          IsPoisonous = true,
        },

        new Acacia
        {
          Name = "Silver Acacia",
          Origin = "Siberia",
          Height = 4.95,
          RootsType = RootsType.Deep,
          AcaciaType = AcaciaTypes.White,
        },

        new BerryBush
        {
          Name = "Raspberry",
          Origin = "Netherlands",
          Height = 0.252,
          bushType = BushType.Rosette,
          BushBerries = BushBerries.Raspberry,
        },

        new Flower
        {
          Name = "Tulip",
          Origin = "Netherlands",
          Height = 0.040,
          StemLength = 0.035,
        },

        new Pine
        {
          Name = "Cedar",
          Origin = "Russia",
          Height = 9.95,
          RootsType = RootsType.Deep,
          pine = PineTypes.LarchCones,
        },

        new FruitBush
        {
          Name = "Hazel",
          Origin = "North America",
          Height = 2.31,
          bushType = BushType.Woody,
          bushFruit = BushFruits.Nuts,
        },

        new Linden
        {
          Name = "KingLinden",
          Origin = "Ukraine",
          Height = 699,
          RootsType = RootsType.Sinker,
          LindenType = LindenType.Summer,
        },

        new PalmTree
        {
          Name = "CoconutPalm",
          Origin = "Hawaii",
          Height = 550,
          RootsType = RootsType.Sinker,
          FruitType = FruitType.Coconuts,
        },
      };
    }

    public Plant[] Garden { get; }
  }
}
