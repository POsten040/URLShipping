namespace URLShipping.Models
{
  public class Parcel
  {
    private string _name;
    private int _weight;
    private int _length;
    private int _height;
    private int _width;

    public Parcel(string name, int weight, int length, int height, int width)
    {
      _name = name;
      _weight = weight;
      _length = length;
      _height = height;
      _width = width;
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
  }
}
