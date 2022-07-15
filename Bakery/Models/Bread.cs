namespace BreadModels
{
  public class BreadClass
  {
    public int GetBreadCount(string count)
    {
      int breadCount = int.Parse(count);
      return breadCount;
    }

    public int BreadCalculator(int breadCount)
    {
      int breadTotal = 0;
      int breadCost = 5;
      breadTotal = breadCost * breadCount;
      return breadTotal;
    }

    public int BreadDealCalculator(int breadTotal, int breadCount)
    {
      if (breadCount >= 3)
      {
        int breadDeal = breadCount / 3;
        breadTotal -= (breadDeal * 5);
      }
      return breadTotal;
    }
  }
}