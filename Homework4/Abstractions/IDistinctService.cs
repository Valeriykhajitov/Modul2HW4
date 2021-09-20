

using Homework4.Models.Plants;

namespace Homework4.Services
{
  public interface IDistinctService
  {
    public int DistinctPlantTypes(Plant[] array);
  }
}