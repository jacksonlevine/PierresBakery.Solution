using System;
namespace PierresBakery.Business 
{
  interface IBakeryItem
  {
    public double Price{ get; set; }
  }

  public class Bread : IBakeryItem
  {
    public double Price{get; set;}
    public Bread()
    {
      Price = 5.00;
    }
  }

  public class Pastry
  {

  }
}