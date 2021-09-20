using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Models.Plants
{
  public abstract class Plant
  {
    public string Name { get; init; }

    public string Origin { get; init; }

    public double Height { get; init; }


    public Plant()
    {
      Name = new Random().Next(2000).ToString();
      Origin = new Random().Next(32111).ToString();
      Height = new Random().Next(1155);
    }
  }
}
