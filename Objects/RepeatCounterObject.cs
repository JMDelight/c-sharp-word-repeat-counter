
namespace WordCounter.Objects
{
  public class RepeatCounter
  {

    // -- A function that takes an inputted sentence and counts how many instances of the inputted word are contained in the snetence -- //
    public int CountRepeats(string sentence, string word)
    {
      int count = 0;
      sentence = sentence.ToLower();
      sentence = sentence.Trim();
      word = word.ToLower();
      if (sentence == word)
      {
        count ++;
      }
      return count;
    }
  }
}
