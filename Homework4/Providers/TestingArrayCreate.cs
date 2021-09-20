using Homework4.Abstractions;
using Homework4.Models.Plants;
using Homework4.Models.Plants.Bushes.BerryBushes;
using Homework4.Models.Plants.Bushes.FruitBushes;
using Homework4.Models.Plants.Flowers;
using Homework4.Models.Plants.Trees.DeciduousTrees;
using Homework4.Models.Plants.Trees.PalmTrees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Providers
{
  class TestingArrayCreate : IArrayCreate
  {
    private Plant[] container = null;

    public Plant[] GetGarden()
    {
      if(container == null)
      {
        int GardenSize = new Random().Next(210);
        Plant[] GetGarden = new Plant[GardenSize];

        Plant plant;

        for (int i = 0; i < GardenSize; i++)
        {
          int PlantTypeNumber = new Random().Next(5);

          switch (PlantTypeNumber)
          {
            case 0:
              plant = new Flower();
              break;
            case 1:
              plant = new BerryBush();
              break;
            case 2:
              plant = new FruitBush();
              break;
            case 3:
              plant = new PalmTree();
              break;
            case 4:
              plant = new DeciduousTree();
              break;
            default:
              throw new Exception($"no such type!");
          }

          GetGarden[i] = plant;

        }
        container = GetGarden;

      }
      return container;
    }
  }
}
