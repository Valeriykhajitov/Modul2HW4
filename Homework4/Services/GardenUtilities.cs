using Homework4.Models.Plants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4.Services
{
  public static class GardenUtilities
  {


    public static Plant GardenSearch(this Plant[] PlantsList, string CategoryName, string value)
    {

      foreach (Plant plant in PlantsList)
      {
        try
        {
          if (plant.GetType().GetProperty(CategoryName).GetValue(plant, null).ToString().Contains(value))
          {
            Console.WriteLine(plant.Name);
            return plant;
          }
        }
        catch (Exception e)
        {
          continue;
        }
      }
      return null;
    }

  }
}
