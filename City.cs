using System.Collections.Generic;


namespace Planner
{
  public class City
  {
    private string _cityName;
    private string _mayor;
    private int _yearEst;
    public City(string cityName)
    {
      _cityName = cityName;
    }
    public void Mayor(string mayor)
    {
      _mayor = mayor;
    }
    public void YearEst(int yearEst)
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
    public int Year()
    {
      return _yearEst;
    }
  }
}