using Homework4.Models.Plants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Providers
{
  class GardenService : IGardenService
  {
    private int _iterator = 0;

    public GardenService(int capacity)
    {
      Garden = new Plant[capacity];
      Capacity = capacity;
    }

    public Plant[] Garden { get; }
    public int Capacity { get; }

    public void Add(Plant garden)
    {
      if (_iterator < Capacity)
      {
        Garden[_iterator++] = garden;
      }
    }

    public void Remove()
    {
      Garden[_iterator--] = null;
    }
  }
}
