using System;
namespace PierresBakery.Business 
{
  public interface IProduceItem : IBakeryItem
  {
    public string BestByDate{ get; set; }
  }
  public class Apple : IProduceItem
  {
    public double Price{ get; set; }
    public string BestByDate{ get; set; }
    public Apple()
    {
      Price = 4.00;
      BestByDate = DateTime.Today.AddDays(20.0).ToShortDateString();
    }
    public void MakeFree()
    {
      Price = 0.0;
    }
  }
  public class Banana : IProduceItem
  {
    public double Price{ get; set; }
    public string BestByDate{ get; set; }
    public Banana()
    {
      Price = 6.00;
      BestByDate = DateTime.Today.AddDays(20.0).ToShortDateString();
    }
    public void MakeFree()
    {
      Price = 0.0;
    }
  }
}