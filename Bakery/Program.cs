using System;
using System.Collections.Generic;
using BreadModels;
using PastryModels;
using System.Linq;


public class Program
{
  public static void Main()
  {
    Console.WriteLine("'Bonjour! Welcome to my bakery!' Pierre says.");
    Console.WriteLine("'I have many wonderful breads and pastries.'");
    Console.WriteLine("'My breads are $5 each, and pastries are $2 each.' he continues.");
    Console.WriteLine("'Don't miss out on our deals though! Buy 2 breads and get 1 free, and every 3rd pastry is only $1!'");

    Console.WriteLine("'How many loaves of bread would you like?' Pierre asks");
    string userInputBread = Console.ReadLine();
    BreadClass newBreadCount = new BreadClass();
    int breadCount = newBreadCount.GetBreadCount(userInputBread);
    int breadTotal = newBreadCount.BreadCalculator(breadCount);
    breadTotal = newBreadCount.BreadDealCalculator(breadTotal, breadCount);

    Console.WriteLine("'And how many pastries would you like?' Pierre asks");
    string userInputPastry = Console.ReadLine();
    PastryClass newPastryCount = new PastryClass();
    int pastryCount = newPastryCount.GetPastryCount(userInputPastry);
    int pastryTotal = newPastryCount.PastryCalculator(pastryCount);
    pastryTotal = newPastryCount.PastryDealCalculator(pastryTotal, pastryCount);

    Console.WriteLine("'Fantastique! Your total will be: $" + (breadTotal + pastryTotal) + ".'");
    Console.WriteLine("You hand Pierre $" + (breadTotal + pastryTotal + 5) + ".");
    Console.WriteLine("'I don't have any change, so thanks for the tip!' Pierre Says.");
  }
}