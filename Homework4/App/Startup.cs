using Homework4.Abstractions;
using Homework4.Models.Plants;
using Homework4.Providers;
using Homework4.Services;
using Modul2HW4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Exec
{
  public class Startup
  {
    private Plant[] _garden;
    private const int _gardenSize = 20;
    private readonly ISortService _sortService;
    private readonly IDistinctService _distinctService;
    private readonly IGardenService _gardenService;
    private readonly IGardenProvider _gardenProvider;

    public Startup(ISortService someService, IDistinctService distinctService, IArrayCreate arrayCreate)
    {
      _sortService = someService;
      _distinctService = distinctService;
    }

    public void Run()
    {

      var rnd = new Random();
      for (var i = 0; i < _gardenSize; i++)
      {
        _gardenService.Add(_gardenProvider.Garden[rnd.Next(_gardenProvider.Garden.Length)]);
      }

      _distinctService.DistinctPlantTypes(_garden);

      _sortService.GardenSort(_garden, "bushFruit");
      _garden = _gardenService.Garden;
      object p = _garden.GardenSearch("bushFruit", "Nuts");
    }
  }
}
