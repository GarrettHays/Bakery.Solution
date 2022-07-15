namespace BreadModels
{
  public class BreadClass
  {
    public int BreadCount {get; set;}

    public int Bread(string count)
    {
      BreadCount = int.Parse(count);
      return BreadCount;
    }
  }
}