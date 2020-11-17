using System;

namespace Planner
{
  public class Building
  {
    //private fields
    private string _designer = "Cornelia";
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

  }
}