using System.Collections.Generic;
namespace PierresBakery.Business 
{
  public class ShoppingCart
  {
    public List<IBakeryItem> contents = new List<IBakeryItem>();
    public void AddToCart(IBakeryItem b)
    {
      if(b.GetType() == typeof(Bread))
      {
        int numOfThisType = GetNumberOfType(typeof(Bread));
        if((numOfThisType + 1) % 3 == 0) {
          b.MakeFree();
        }
      }
      if(b.GetType() == typeof(Pastry))
      {
        int numOfThisType = GetNumberOfType(typeof(Pastry));
        if((numOfThisType + 1) % 4 == 0) {
          b.MakeFree();
        }
      }
      contents.Add(b);
    }
    public double CalculateTotal()
    {
      double price = 0.0;
      foreach(IBakeryItem b in contents) 
      {
        price += b.Price;
      }
      return price;
    }
    public int GetNumberOfType(System.Type type)
    {
      int count = 0;
      foreach(IBakeryItem b in contents) 
      {
        if(b.GetType() == type)
        {
          count += 1;
        }
      }
      return count;
    }
  }
}