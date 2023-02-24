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
      help();
      while(!isEnd)
      {
        string nextLine = Console.ReadLine();
        string[] nlSplit = nextLine.Split(' ');
        switch(nlSplit[0])
        {
          case "viewcart":
            displayCart(myCart);
            break;
          case "buy":
            try 
            {
              switch(nlSplit[1]) 
              {
                case "bread":
                  for(int i = 0; i < int.Parse(nlSplit[2]); i++)
                  {
                    myCart.AddToCart(new Bread());
                  }
                  Console.WriteLine($"Bought <{nlSplit[2]}> of Bread!");
                  break;
                case "pastry":
                  for(int i = 0; i < int.Parse(nlSplit[2]); i++)
                  {
                    myCart.AddToCart(new Pastry());
                  }
                  Console.WriteLine($"Bought <{nlSplit[2]}> of Pastry!");
                  break;
              }
            }
            catch(Exception e)
            {
              Console.WriteLine("Too few arguments! Please type help for command formats. " + e.Message);
            }
            break;
          case "help":
            help();
            break;
          default:
            Console.WriteLine("Unknown command! Type help to view the list of commands.");
            break;
        }
      }
    }

    static void help() 
    {
      Console.WriteLine("Hello! Welcome to Pierre's Bakery. Here's a list of commands:");
      Console.WriteLine("viewcart - View the contents of your shopping cart!");
      Console.WriteLine("buy bread <amount> - Example: buy bread 1 - Add bread to your cart. Every third bread is free!");
      Console.WriteLine("buy pastry <amount> - Example: buy pastry 2 - Add pastries to your cart. Every fourth pastry is free!");
      Console.WriteLine("help - View this list of commands :)");
    }

    static void displayCart(ShoppingCart myCart)
    {
      int width = 40;
      int topBottomPadding = 2;
      int leftPadding = 2;
      string displayString = "";
      for(int j = -topBottomPadding; j < myCart.contents.Count + topBottomPadding; j++) 
      {
        string theLine = "";
        bool lineEmpty = true;
        if(j >= 0 && j < myCart.contents.Count)
        {
          lineEmpty = false;
          theLine = $" 1 of {myCart.contents[j].GetType().Name} for ${myCart.contents[j].Price}";
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
      displayString += $"Total Cost of Items: ${myCart.CalculateTotal()}";
      Console.WriteLine(displayString);
    }
  }
}

  