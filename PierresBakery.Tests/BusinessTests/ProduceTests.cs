using PierresBakery.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PierresBakery.Tests 
{
  [TestClass]
  public class ProduceTests
  {
    [TestMethod]
    public void MakeFree_InheritsMakeFreeMethodFromIBakeryItem_Void()
    {
      Apple a = new Apple();
      a.MakeFree();
      Assert.AreEqual(0.0, a.Price);
      Banana b = new Banana();
      b.MakeFree();
      Assert.AreEqual(0.0, b.Price);
    }
    [TestMethod]
    public void Apple_CreatesInstanceOfApple_Apple()
    {
      Apple a = new Apple();
      Assert.AreEqual(typeof(Apple), a.GetType());
    }
    [TestMethod]
    public void Banana_CreatesInstanceOfBanana_Banana()
    {
      Banana b = new Banana();
      Assert.AreEqual(typeof(Banana), b.GetType());
    }
    [TestMethod]
    public void Banana_PriceIsEqualToSix_Double()
    {
      Banana b = new Banana();
      Assert.AreEqual(6.00, b.Price);
    }
    [TestMethod]
    public void Apple_PriceIsEqualToFour_Double()
    {
      Apple a = new Apple();
      Assert.AreEqual(4.00, a.Price);
    }
  }
}