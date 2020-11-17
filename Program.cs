using System;
using System.Collections.Generic;

namespace Planner
{
  class Program
  {
    static void Main(string[] args)
    {
      Building FiveOneTwoEigth = new Building("512 8th Avenue");
      FiveOneTwoEigth.Width = 1000;
      FiveOneTwoEigth.Depth = 250;
      FiveOneTwoEigth.Stories = 1;
      FiveOneTwoEigth.Construct();
      FiveOneTwoEigth.Purchase("Rick James");

      Building OneTwoThree = new Building("123 Main Street")
      {
        Width = 1500,
        Depth = 200,
        Stories = 2,
      };
      OneTwoThree.Construct();
      OneTwoThree.Purchase("Chelsy Thomas");

      City tallahassee = new City("Tallahassee");
      tallahassee.Mayor("Mike Towns");
      tallahassee.Year(1991);
      tallahassee.AddBuilding(FiveOneTwoEigth);
      tallahassee.AddBuilding(OneTwoThree);

      foreach (Building building in tallahassee.Buildings)
      {
        DisplayTemplate(building);
      }
    }

    static void DisplayTemplate(Building building)
    {
      Console.WriteLine($@"
{building.BuildingAdress()}
---------------
Designed by {building.DesignerName()}
Constructed on {building.DateCompleted()}
Owned by {building.OwnerName()}
{building.Volume} cubic meters of space
      ");
    }
  }
}
