namespace PastryModels
{
  public class PastryClass
  {
    public int PastryCount {get; set;}
    public int PastrySubTotal {get; set;}

    public int Pastry(string count)
    {
      PastryCount = int.Parse(count);
      PastrySubTotal = 0;
      return PastryCount;
    }

    public int PastryCalculator()
    {
      for (int i = 0; i < PastryCount; i++)
      {
        PastrySubTotal += 2;
      }
      return PastrySubTotal;
    }

    public int PastryDealCalculator()
    {
      if (PastryCount == 6)
      {
        int PastryDeal = PastryCount * 2;
        PastrySubTotal = (PastryDeal - 2);
      }
      else if (PastryCount >= 3)
      {
        int PastryDeal = PastryCount * 2;
        PastrySubTotal = (PastryDeal - 1);
      }
      return PastrySubTotal;
    }
  }
}