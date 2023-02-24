using PierresBakery.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PierresBakery.Tests 
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void MakeFree_SetsPriceToZero_Void()
    {
      Pastry p = new Pastry();
      p.MakeFree();
      Assert.AreEqual(0.0, p.Price);
      Bread b = new Bread();
      b.MakeFree();
      Assert.AreEqual(0.0, b.Price);
    }
    [TestMethod]
    public void Croissant_CreatesInstanceOfCroissant_Croisant()
    {
      Croissant c = new Croissant();
      Assert.AreEqual(typeof(Croissant), c.GetType());
    }
    [TestMethod]
    public void Bread_CreateInstanceOfBread_Bread()
    {
      Bread b = new Bread();
      Assert.AreEqual(typeof(Bread), b.GetType());
    }
    [TestMethod]
    public void Pastry_CreatesInstanceOfPastry_Pastry()
    {
      Pastry p = new Pastry();
      Assert.AreEqual(typeof(Pastry), p.GetType());
    }

    [TestMethod]
    public void Bread_PricePropertyIs5_Double()
    {
      Bread b = new Bread();
      Assert.AreEqual(5.00, b.Price);
    }
    [TestMethod]
    public void Pastry_PricePropertyIs2_Double()
    {
      Pastry p = new Pastry();
      Assert.AreEqual(2.00, p.Price);
    }
    [TestMethod]
    public void Croissant_PricePropertyIs8_Double()
    {
      Croissant c = new Croissant();
      Assert.AreEqual(8.00, c.Price);
    }
  }
}