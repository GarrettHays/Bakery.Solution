namespace PastryModels
{
  public class PastryClass
  {
    public int PastryCount {get; set;}

    public int Pastry(string count)
    {
      PastryCount = int.Parse(count);
      return PastryCount;
    }
  }
}