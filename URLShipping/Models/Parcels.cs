using System;
using System.Collections.Generic;

namespace URLShipping.Models
{
  public class Parcel
  {
    private string _name;
    private int _weight;
    private int _length;
    private int _height;
    private int _width;
    private double _cost;
    private int _volume;

    private static List<Parcel> _instances = new List<Parcel> {};
    public Parcel(string name, int weight, int length, int height, int width)
    {
      _name = name;
      _weight = weight;
      _length = length;
      _height = height;
      _width = width;
      // _volume = 0;
      _instances.Add(this);
      
    }
    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }
    public int Weight
    {
      get { return _weight; }
      set { _weight = value; }
    }
    public int Length
    {
      get { return _length; }
      set { _length = value; }
    }
    public int Height
    {
      get { return _height; }
      set { _height = value; }
    }
    public int Width
    {
      get {return _width; }
      set { _width= value; }
    }
    public int Volume()
    {
      return Length * Height * Width;
    }
    public double CostToShip()
    { 
      
      double result = (double) this.Weight / this.Volume() *50;
      return Math.Round(result, 2); 
    
    }
    public static List<Parcel> GetAll()
    {
      return _instances;
    }
  }
}
