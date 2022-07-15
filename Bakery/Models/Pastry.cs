namespace PastryModels
{
  public class PastryClass
  {
    public int GetPastryCount(string count)
    {
      int pastryCount = int.Parse(count);
      return pastryCount;
    }

    public int PastryCalculator(int pastryCount)
    {
      int pastryTotal = 0;
      int pastryCost = 2;
      pastryTotal = pastryCost * pastryCount;
      return pastryTotal;
    }

    public int PastryDealCalculator(int pastryTotal, int pastryCount)
    {
      if (pastryCount == 6)
      {
        int pastryDeal = pastryCount * 2;
        pastryTotal = (pastryDeal - 2);
      }
      else if (pastryCount >= 3)
      {
        int pastryDeal = pastryCount * 2;
        pastryTotal = (pastryDeal - 1);
      }
      return pastryTotal;
    }
  }
}