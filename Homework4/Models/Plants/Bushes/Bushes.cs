using Homework4.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Models.Plants.Bushes
{
  public abstract class Bushes : Plant
  {
    public BushType bushType { get; init; }
  }
}
