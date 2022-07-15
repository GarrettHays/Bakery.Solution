namespace BreadModels
{
  public class BreadClass
  {
    public int BreadCount {get; set;}
    public int BreadSubTotal {get; set;}

    public int Bread(string count)
    {
      BreadCount = int.Parse(count);
      BreadSubTotal = 0;
      return BreadCount;
    }

    public int BreadCalculator()
    {
      for (int i = 0; i < BreadCount; i++)
      {
        BreadSubTotal += 5;
      }
      return BreadSubTotal;
    }

    public int BreadDealCalculator()
    {
      if (BreadCount >= 3)
      {
        int BreadDeal = BreadCount / 3;
        BreadSubTotal -= (BreadDeal * 5);
      }
      return BreadSubTotal;
    }
  }
}