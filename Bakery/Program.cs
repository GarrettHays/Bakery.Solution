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
    Console.WriteLine("'What kind of bread would you like? Rye or Wheat?");
    string userInputBreadType = Console.ReadLine();
    userInputBreadType = userInputBreadType.ToLower();
    if (userInputBreadType != "rye" && userInputBreadType !="wheat")
    {
      Console.WriteLine("'No bread for you then.' Pierre says");
      breadTotal = 0;
    }
    Console.WriteLine("'And how many pastries would you like?' Pierre asks");
    string userInputPastry = Console.ReadLine();
    PastryClass newPastryCount = new PastryClass();
    int pastryCount = newPastryCount.GetPastryCount(userInputPastry);
    int pastryTotal = newPastryCount.PastryCalculator(pastryCount);
    pastryTotal = newPastryCount.PastryDealCalculator(pastryTotal, pastryCount);
    Console.WriteLine("'What kind of pastry would you like? Raspberry or Chocolate?");
    string userInputPastryType = Console.ReadLine();
    userInputPastryType =  userInputPastryType.ToLower();
    if ((userInputPastryType != "raspberry" && userInputPastryType !="chocolate") && breadTotal == 0)
    {
      Console.WriteLine("'Get out of my shop.' Pierre says");
      return;
    } else if (userInputPastryType != "raspberry" && userInputPastryType !="chocolate") {
      Console.WriteLine("'No pastries for you then.' Pierre says");
      pastryTotal = 0;
    }
    Console.WriteLine($"'Fantastique! Your total will be: ${breadTotal + pastryTotal} for {breadCount} loaves of {userInputBreadType} bread and {pastryCount} {userInputPastryType} pastries.'");
    Console.WriteLine("You hand Pierre $" + (breadTotal + pastryTotal + 5) + ".");
    Console.WriteLine("'I don't have any change, so thanks for the tip!' Pierre Says.");
  }
}