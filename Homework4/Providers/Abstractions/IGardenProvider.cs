using Homework4.Models.Plants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Abstractions
{
  public interface IGardenProvider
  {
    Plant[] Garden { get; }
  }
}
