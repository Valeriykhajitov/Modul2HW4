using Homework4.Models.Plants;

namespace Homework4.Providers
{
  internal interface IGardenService
  {
    Plant[] Garden { get; }
    int Capacity { get; }
    void Add(Plant plants);
    public void Remove();
  }
}