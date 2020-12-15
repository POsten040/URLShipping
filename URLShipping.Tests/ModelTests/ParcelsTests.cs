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
      int[] dimensions = {4,5,6};
      Parcel newParcel = new Parcel("test", 40, dimensions);
      string name = newParcel.Name;
      int weight = newParcel.Weight;
      int[] testDimensions = newParcel.Dimensions;

      Assert.AreEqual("x", name);
      Assert.AreEqual(12, weight);
      Assert.AreEqual(dimensions, testDimensions);

    }
  }
}
