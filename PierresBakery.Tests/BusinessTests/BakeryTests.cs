using PierresBakery.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PierresBakery.Tests 
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void Bread_CreateInstanceOfBread_Bread()
    {
      Bread b = new Bread();
      Assert.AreEqual(typeof(Bread), b.GetType());
    }
  }
}