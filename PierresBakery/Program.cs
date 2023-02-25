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
          case "complaint":
            Console.WriteLine("We're sorry to hear if you had any trouble with our goods or services, please explain your complaint:");
            string comp = Console.ReadLine();
            int creditToGive = comp.Length/2;
            myCart.GiveStoreCredit((double)creditToGive);
            Console.WriteLine($"Thank you for reporting. We apologize for the inconvenience. You have been given {creditToGive} store credits, usable on any future purchase.");
            break;
          case "clearcart":
            myCart.contents.Clear();
            Console.WriteLine("Successfully cleared your shopping cart.");
            Console.WriteLine($"Your shopping cart total is now ${myCart.CalculateTotal()}");
            break;
          case "viewcart":
            displayCart(myCart);
            break;
          case "buy":
            try 
            {
              string name = nlSplit[1];
              char[] nameArray = name.ToCharArray();
              nameArray[0] = char.ToUpper(name[0]);
              string capitalizedName = String.Join("", nameArray);
              string fullName = "PierresBakery.Business." + capitalizedName;
              Type t = Type.GetType(fullName);
              for(int i = 0; i < int.Parse(nlSplit[2]); i++)
              {
                myCart.AddToCart((IBakeryItem)Activator.CreateInstance(t));
              }
              Console.WriteLine($"Bought <{nlSplit[2]}> of {capitalizedName}!");
              Console.WriteLine($"Your shopping cart total is now ${myCart.CalculateTotal()}");
            }
            catch(Exception e)
            {
              Console.WriteLine("Too few arguments or invalid item! Please type help for command formats. " + e.Message);
            }
            break;
          case "help":
            help();
            break;
          case "quit":
            Console.WriteLine("Goodbye! Have a great day!");
            isEnd = true;
            break;
          default:
            Console.WriteLine("Unknown command! Type help to view the list of commands.");
            break;
        }
      }
    }

    static void help() 
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Hello! Welcome to Pierre's Bakery. Here's a list of commands:");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("clearcart - Empty your shopping cart!");
      Console.WriteLine("viewcart - View the contents of your shopping cart!");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("******Available Items:******");
      Console.WriteLine("***Bread $5***");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("buy bread <amount> - Example: buy bread 1 - Add bread to your cart. Every third bread is free!");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("***Pastry $2***");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("buy pastry <amount> - Example: buy pastry 2 - Add pastries to your cart. Every fourth pastry is free!");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("***Apple $4***");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("buy apple <amount> - Example: buy apple 2 - Add apples to your cart.");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("***Banana $6***");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("buy banana <amount> - Example: buy banana 6 - Add bananas to your cart.");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("***Croissant $8***");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("buy croissant <amount> - Example: buy croissant 1 - Add croissant to your cart.");
      Console.WriteLine("help - View this list of commands :)");
      Console.WriteLine("complaint - Report an issue with a recent purchase.");
      Console.WriteLine("quit - Leave the bakery");
    }

    static void displayCart(ShoppingCart myCart)
    {
      if(myCart.contents.Count < 500) 
      {
        int width = 50;
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
          try
          {
            theLine += $" (Best By Date: {((IProduceItem)myCart.contents[j]).BestByDate})";
          }
          catch
          {
          }
          for(int i = -leftPadding; i < width; i++)
          {
            bool onLine = false;
            if(i >= 0 && i < theLine.Length)
            {
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
            else 
            {
              if((i+j)%4 == 0)
              {
                displayString += ".";
              }
              else
              {
                displayString += " ";
              }
            }
          }
          displayString += "\n";
        }
        if(myCart.contents.Count == 0)
        {
          displayString += "Your cart is empty! Start buying items with buy <item> <amount>\n";
        }
        displayString += $"Total Cost of Items: ${myCart.CalculateTotal()}";
        Console.WriteLine(displayString);
      }
      else 
      {
        Console.WriteLine($"Your cart is too big too view! It has {myCart.contents.Count} items.");
        Console.WriteLine($"Total Cost of Items: ${myCart.CalculateTotal()}");
      }
    }
  }
}

  