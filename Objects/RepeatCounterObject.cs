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

    // -- Setters for RepeatCounter -- //
    public void SetUserSentence(string newSentence)
    {
      _userSentence = newSentence;
    }
    public void SetWordToCheck(string newWord)
    {
      _wordToCheck = newWord;
    }

    // -- Getters for RepeatCounter -- //
    public string GetUserSentence()
    {
      return _userSentence;
    }

    public string GetWordToCheck()
    {
      return _wordToCheck;
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
        if (checkedWord == word)
        {
          count ++;
        }
      }
      return count;
    }
  }
}
