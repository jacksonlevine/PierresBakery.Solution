using System;
using System.Collections.Generic;
namespace PierresBakery.Business 
{
  public class ShoppingCart
  {
    public List<IBakeryItem> contents = new List<IBakeryItem>();
    public void AddToCart(IBakeryItem b)
    {
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
  }

  public interface IBakeryItem
  {
    public double Price{ get; set; }
    public void MakeFree();
  }

  public class Bread : IBakeryItem
  {
    public double Price{get; set;}
    public Bread()
    {
      Price = 5.00;
    }
    public void MakeFree()
    {
      Price = 0.0;
    }
  }

  public class Pastry : IBakeryItem
  {
    public double Price{ get; set; }
    public Pastry()
    {
      Price = 2.00;
    }
    public void MakeFree()
    {
      Price = 0.0;
    }
  }
}