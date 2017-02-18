using System;
using System.Collections.Generic;

namespace RepeatCounter
{
  public class RepeatCounter
  {
    private string _initialWord;
    private string _text;
    private int _count;


    public RepeatCounter(string initialWord, string text)
    {

      _initialWord = initialWord;
      _text = text;
    }

    public int CountRepeats()
    {
      int _count = 0;

      string wordToUpper = _initialWord.ToUpper();
      int wordToUpperLength = wordToUpper.Length;

      string textToUpper = _text.ToUpper();
      string[] wordSet = textToUpper.Split();

      foreach(string word in wordSet)
      {
        if (wordToUpper == word || wordToUpper + "'S" == word || wordToUpper + "ES" == word || wordToUpper + "LY" == word || wordToUpper + "S" == word || wordToUpper + "IES" == word)
        {
          _count+= 1;
        }
        else
        {
          _count+= 0;
        }
      }
      return _count;
    }

    public int GetCount()
    {
      return _count;
    }

    // public int GetContains()
    // {
    //   int counter = 0;
    //   string[] wordSet = _text.Split();
    //
    //   StringComparison comp = StringComparison.OrdinalIgnoreCase;
    //
    //   foreach(string word in wordSet)
    //   if ((comp, wordSet.Contains(word, comp) == true))
    //   {
    //     counter+= 1;
    //   }
    //   else
    //   {
    //     counter+= 0;
    //   }
    //   return counter;
    // }

  }
}
