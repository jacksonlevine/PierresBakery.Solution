using PierresBakery.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PierresBakery.Tests 
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void AddToCart_MakeEveryThirdBreadAndEverySecondPastryFree_Void()
    {
      ShoppingCart s = new ShoppingCart();
      Bread b1 = new Bread();
      Bread b2 = new Bread();
      Bread b3 = new Bread();
      Bread b4 = new Bread();
      Pastry p = new Pastry();
      Pastry p1 = new Pastry();
      Pastry p2 = new Pastry();
      s.AddToCart(b1);
      s.AddToCart(b2);
      s.AddToCart(b3);
      s.AddToCart(b4);
      Assert.AreEqual(15.00, s.CalculateTotal());
      s.AddToCart(p);
      s.AddToCart(p1);
      s.AddToCart(p2);
      Assert.AreEqual(19.00, s.CalculateTotal());
    }

    [TestMethod]
    public void CalculateTotal_ReturnsTotalCostOfContents_Double()
    {
      ShoppingCart s = new ShoppingCart();
      Bread b1 = new Bread();
      Bread b2 = new Bread();
      s.AddToCart(b1);
      s.AddToCart(b2);
      Assert.AreEqual(10.00, s.CalculateTotal());
    }

    [TestMethod]
    public void GetNumberOfType_ReturnsNumberOfTypeOfBakeryItem_Int()
    {
      ShoppingCart s = new ShoppingCart();
      Bread b1 = new Bread();
      Bread b2 = new Bread();
      Bread b3 = new Bread();
      Pastry p = new Pastry();
      s.AddToCart(b1);
      s.AddToCart(b2);
      s.AddToCart(b3);
      s.AddToCart(p);
      Assert.AreEqual(3, s.GetNumberOfType(typeof(Bread)));
      Assert.AreEqual(1, s.GetNumberOfType(typeof(Pastry)));
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
    public void IBakeryItem_MakeFreeMethodSetsPriceTo0_Void()
    {
      Pastry p = new Pastry();
      p.MakeFree();
      Assert.AreEqual(0.0, p.Price);
      Bread b = new Bread();
      b.MakeFree();
      Assert.AreEqual(0.0, b.Price);
    }
    [TestMethod]
    public void ShoppingCart_CreatesInstanceOfShoppingCart_ShoppingCart()
    {
      ShoppingCart s = new ShoppingCart();
      Assert.AreEqual(typeof(ShoppingCart), s.GetType());
    }
  }
}