
namespace WordCounter.Objects
{
  public class RepeatCounter
  {

    public int CountRepeats(string sentence, string word)
    {
      int count = 0;
      sentence = sentence.ToLower();
      if (sentence == word)
      {
        count ++;
      }
      return count;
    }
  }
}
