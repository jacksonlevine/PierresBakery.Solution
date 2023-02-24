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
            displayCart(myCart);
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

    static void displayCart(ShoppingCart myCart)
    {
      int width = 40;
      int topBottomPadding = 5;
      int leftPadding = 5;
      string displayString = "";
      for(int j = -topBottomPadding; j < myCart.contents.Count + topBottomPadding; j++) 
      {
        string theLine = "";
        bool lineEmpty = true;
        if(j >= 0 && j < myCart.contents.Count)
        {
          lineEmpty = false;
          theLine = $" 1 of {myCart.contents[j].GetType().ToString()} for ${((myCart.contents[j].Price < 1) ? "0" : "")}{myCart.contents[j].Price}";
        }
        for(int i = -leftPadding; i < width; i++)
        {
          bool onLine = false;
          if(i >= 0 && i < theLine.Length) {
            onLine = true;
          }
          if(j == -topBottomPadding || j == myCart.contents.Count + topBottomPadding -1 || i == -leftPadding || i == width - 1)
          {
            displayString += "*";
          }
          else
          if(lineEmpty == false && onLine == true)
          {
            displayString += theLine[i];
          }
          else {
            displayString += " ";
          }
        }
        displayString += "\n";
      }
      Console.SetCursorPosition(0,0);
      Console.WriteLine(displayString);
    }
  }
}

  