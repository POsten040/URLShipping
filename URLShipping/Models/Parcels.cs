namespace URLShipping.Models
{
  public class Parcel
  {
    public string Name;
    public int Weight;
    public int[] Dimensions;

    public Parcel(string name, int weight, int[] dimensions)
    {
      Name = name;
      Weight = weight;
      Dimensions = dimensions;
    }
  }
}