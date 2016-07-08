using System;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {

    // -- A function that takes an inputted sentence and counts how many instances of the inputted word are contained in the snetence -- //
    public int CountRepeats(string sentence, string word)
    {
      int count = 0;
      sentence = sentence.ToLower();
      string[] sentenceWords = sentence.Split(new[]{" "}, StringSplitOptions.RemoveEmptyEntries);
      word = word.ToLower();
      word = word.Trim();
      foreach (string checkedWord in sentenceWords)
      {
        if (checkedWord == word)
        {
          count ++;
        }
      }
      return count;
    }
  }
}
