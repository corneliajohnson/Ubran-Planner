using System.Collections.Generic;

namespace Planner
{
  public class City
  {
    private string _cityName;
    private string _mayor;
    private int _yearEst;
    public List<Building> Buildings = new List<Building>();
    public City(string cityName)
    {
      _cityName = cityName;
    }
    public void Mayor(string mayor)
    {
      _mayor = mayor;
    }
    public void Year(int yearEst)
    {
      _yearEst = yearEst;
    }
    public string CityName()
    {
      return _cityName;
    }
    public string MayorName()
    {
      return _mayor;
    }
    public int YearEst()
    {
      return _yearEst;
    }
    public void AddBuilding(Building building)
    {
      Buildings.Add(building);
    }
  }
}