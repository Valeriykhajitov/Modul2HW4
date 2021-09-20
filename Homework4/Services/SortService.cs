using Homework4.Abstractions;
using Homework4.Models.Plants;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Services
{
  class SortService : ISortService
  {
    IGardenProvider ArrayCreate = null;

    public SortService()
    {
      
    }

    public void GardenSort(Plant[] PlantsList, string CategoryName)
    {
      Array.Sort(PlantsList, delegate (Plant x, Plant y)
      {
        string FirstObject;
        string SecondObject;
        try
        {
          FirstObject = x.GetType().GetProperty(CategoryName).GetValue(x, null).ToString();
        }
        catch (Exception e)
        {
          FirstObject = null;
        }

        try
        {
          SecondObject = y.GetType().GetProperty(CategoryName).GetValue(y, null).ToString();
        }
        catch (Exception e)
        {
          SecondObject = null;
        }

        if (FirstObject == null && SecondObject == null) return 0;
        else if (FirstObject == null) return -1;
        else if (SecondObject == null) return 1;
        else return FirstObject.CompareTo(SecondObject);
      });
    }
      /*public Plant[] GardenSort(string CategoryName)
      {
        Plant[] PlantsList = ArrayCreate.GetGarden();
        Array.Sort(PlantsList, delegate (Plant x, Plant y)
        {
          string FirstObject;
          string SecondObject;
          try
          {
            FirstObject = x.GetType().GetProperty(CategoryName).GetValue(x, null).ToString();
          }
          catch (Exception e)
          {
            FirstObject = null;
          }

          try
          {
            SecondObject = y.GetType().GetProperty(CategoryName).GetValue(y, null).ToString();
          }
          catch (Exception e)
          {
            SecondObject = null;
          }

          if (FirstObject == null && SecondObject == null) return 0;
          else if (FirstObject == null) return -1;
          else if (SecondObject == null) return 1;
          else return FirstObject.CompareTo(SecondObject);
        });
        return PlantsList;
      */


    }
    
    }
