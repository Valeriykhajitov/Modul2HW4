using Homework4.Abstractions;
using Homework4.Models.Plants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Services
{
  class DistinctService : IDistinctService
  {

    public int DistinctPlantTypes(Plant[] array)
    {
      Plant[] PlantsList = array;
      HashSet<Type> types = new HashSet<Type>(PlantsList.Select(x => x.GetType()));
      Console.WriteLine(types.Count);
      return types.Count();
    }
  }
}
