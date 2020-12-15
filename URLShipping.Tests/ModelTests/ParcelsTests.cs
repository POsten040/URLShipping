using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using URLShipping.Models;

namespace URLShipping.Tests
{
  [TestClass]
  public class ParcelTest 
  {
    // public void Dispose()
    // {
    //   Parcel.ClearAll();
    // }
    [TestMethod]
    public void ParcelConstructor_CreatesInstanceOfParcel_Parcel()
    {
      Parcel newParcel = new Parcel("test", 40, 4, 5, 6);
      string name = newParcel.Name;
      int weight = newParcel.Weight;
      Assert.AreEqual("test", name);
      Assert.AreEqual(40, weight);
      Assert.AreEqual(4, newParcel.Length);
      Assert.AreEqual(5, newParcel.Height);
      Assert.AreEqual(6, newParcel.Width);
    }
    [TestMethod]
    public void Volume_CorrectlyCaluculatesVolumeUsingDimensions_Int()
    {
      int Length = 4;
      int Height = 5;
      int Width = 6;
      Parcel newParcel = new Parcel("test", 40, Length, Height, Width);

      int result = newParcel.Volume();

      Assert.AreEqual(120, result);
      
    }
  }
}
