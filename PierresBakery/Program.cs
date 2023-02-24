using PierresBakery.Business;
using System;
namespace PierresBakery 
{
  public class Program 
  {
    static void Main()
    {
      bool isEnd = false;
      ShoppingCart myCart = new ShoppingCart();
      Console.WriteLine("Hello! Welcome to Pierre's Bakery. Here's a list of commands:");
      Console.WriteLine("viewcart - View the contents of your shopping cart!");
      Console.WriteLine("buy bread - Add bread to your cart. Every third bread is free!");
      Console.WriteLine("buy pastry - Add one pastry to your cart. Every second pastry is free!");
      Console.WriteLine("help - View this list of commands :)");
      while(!isEnd)
      {
        string nextLine = Console.ReadLine();
        switch(nextLine)
        {
          case "viewcart":
            displayCart();
            break;
          case "buy bread":
            myCart.AddToCart(new Bread());
            Console.WriteLine("You bought <1> of Bread!");
            break;
          case "buy pastry":
            myCart.AddToCart(new Pastry());
            Console.WriteLine("You bought <1> of Pastry!");
            break;
          default:
            Console.WriteLine("Unknown command! Type help to view the list of commands.");
            break;
        }
      }
    }
  }
}

  