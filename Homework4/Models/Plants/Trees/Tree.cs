using Homework4.Enums;
using Homework4.Models.Plants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Models.Plants.Trees
{
  public abstract class Tree : Plant
  {
    public RootsType RootsType { get; init; }
  }
}
