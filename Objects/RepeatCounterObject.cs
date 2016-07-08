
namespace WordCounter.Objects
{
  public class RepeatCounter
  {

    public int CountRepeats(string sentence, string word)
    {
      int count = 0;
      if (sentence == word)
      {
        count ++;
      }
      return count;
    }
  }
}
