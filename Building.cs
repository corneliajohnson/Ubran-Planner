using System;

namespace Planner
{
  public class Building
  {
    //private fields
    private string _designer = "Cornelia Johnson";
    private DateTime _dateConstructed;
    private string _address;
    private string _owner;

    //public properties
    public int Stories { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }

    //read only with just get
    public double Volume
    {
      get
      {
        return (Width * Depth);
      }
    }

    //Constructor 
    public Building(string address)
    {
      _address = address;
    }

    public void Construct()
    {
      _dateConstructed = DateTime.Now;
    }

    public void Purchase(string person)
    {
      _owner = person;
    }

    //Information needed for display
    public string OwnerName()
    {
      return _owner;
    }

    public string BuildingAdress()
    {
      return _address;
    }

    public string DesignerName()
    {
      return _designer;
    }

    public DateTime DateCompleted()
    {
      return _dateConstructed;
    }
  }
}