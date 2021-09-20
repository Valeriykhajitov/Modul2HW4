
using Homework4.Models.Plants;
using System.Collections;

namespace Homework4.Services
{
  public interface ISortService
  {
    public void GardenSort(Plant[] PlantsList, string CategoryName);
  }
}