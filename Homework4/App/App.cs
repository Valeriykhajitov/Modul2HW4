using Homework4.Abstractions;
using Homework4.Exec;
using Homework4.Providers;
using Homework4.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.App
{
  public class App
  {
    public static void Launch()
    {
      var serviceProvider = new ServiceCollection()
               .AddTransient<IArrayCreate, TestingArrayCreate>()
               .AddTransient<ISortService, SortService>()
               .AddTransient<IDistinctService, DistinctService>()
               .AddTransient<Startup>()
               .BuildServiceProvider();

      var start = serviceProvider.GetService<Startup>();
      start.Run();
    }
  }
}
