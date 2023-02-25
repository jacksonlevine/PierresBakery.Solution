using PierresBakery.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PierresBakery.Tests
{
  [TestClass]
  public class ShoppingCartTests
  {
    [TestMethod]
    public void ShoppingCart_CreatesInstanceOfShoppingCart_ShoppingCart()
    {
      ShoppingCart s = new ShoppingCart();
      Assert.AreEqual(typeof(ShoppingCart), s.GetType());
    }
    [TestMethod]
    public void AddToCart_MakeEveryThirdBreadAndEveryFourthPastryFree_Void()
    {
      ShoppingCart s = new ShoppingCart();
      Bread b1 = new Bread();
      Bread b2 = new Bread();
      Bread b3 = new Bread();
      Bread b4 = new Bread();
      Pastry p = new Pastry();
      Pastry p1 = new Pastry();
      Pastry p2 = new Pastry();
      Pastry p3 = new Pastry();
      s.AddToCart(b1);
      s.AddToCart(b2);
      s.AddToCart(b3);
      s.AddToCart(b4);
      Assert.AreEqual(15.00, s.CalculateTotal());
      s.AddToCart(p);
      s.AddToCart(p1);
      s.AddToCart(p2);
      s.AddToCart(p3);
      Assert.AreEqual(21.00, s.CalculateTotal());
    }
    [TestMethod]
    public void AddToCart_ThreeBananasForPriceOfOne_Void()
    {
      ShoppingCart s = new ShoppingCart();
      s.AddToCart(new Banana());
      s.AddToCart(new Banana());
      s.AddToCart(new Banana());
      Assert.AreEqual(6.00, s.CalculateTotal());
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
    public void GiveStoreCredit_ItemsBoughtAfterArePaidForByStoreCredit_Void()
    {
      ShoppingCart s = new ShoppingCart();
      s.GiveStoreCredit(10);
      s.AddToCart(new Apple());
      s.AddToCart(new Apple());
      s.AddToCart(new Apple());
      Assert.AreEqual(2.00, s.CalculateTotal());
    }
  }
}