using System;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _userSentence;
    private string _wordToCheck;

    public RepeatCounter(string userSentence, string wordToCheck)
    {
      _userSentence = userSentence;
      _wordToCheck = wordToCheck;
    }

    // -- A function that takes an inputted sentence and counts how many instances of the inputted word are contained in the snetence -- //
    public int CountRepeats()
    {
      int count = 0;
      string sentence = _userSentence.ToLower();
      string word = _wordToCheck.ToLower().Trim();
      string[] delimiters = new [] {" ", ",", ".", "!", "?", "\""};
      string[] sentenceWords = sentence.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
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
