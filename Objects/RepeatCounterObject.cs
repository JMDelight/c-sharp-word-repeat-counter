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
      string[] delimiters = new [] {" ", ",", ".", "!", "?", "\""};
      string[] sentenceWords = sentence.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
      word = word.ToLower();
      word = word.Trim();
      foreach (string checkedWord in sentenceWords)
      {
        // System.Console.WriteLine(checkedWord);
        if (checkedWord == word)
        {
          count ++;
        }
      }
      return count;
    }
  }
}
