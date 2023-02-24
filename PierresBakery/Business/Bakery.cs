namespace PierresBakery.Business 
{
  public interface IBakeryItem
  {
    public double Price{ get; set; }
    public void MakeFree();
  }
  public class Bread : IBakeryItem
  {
    public double Price{ get; set; }
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
  public class Croissant : IBakeryItem
  {
    public double Price{ get; set; }
    public Croissant()
    {
      Price = 8.00;
    }
    public void MakeFree()
    {
      Price = 0.0;
    }
  }
}