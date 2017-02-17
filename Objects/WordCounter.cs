using System;
using System.Collections.Generic;
using Linq;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _initialWord;
    private string _text;


    public RepeatCounter(string initialWord, string text)
    {

      _initialWord = initialWord;
      _text = text;
    }

    // public int GetCount()
    // {
    //   int count = 0;
    //
    //   string wordToUpper = _initialWord.ToUpper();
    //   int wordToUpperLength = wordToUpper.Length;
    //
    //   string textToUpper = _text.ToUpper();
    //   string[] wordSet = textToUpper.Split();
    //
    //   foreach(string word in wordSet)
    //   {
    //     if (wordToUpper == word || wordToUpper + "'S" == word || wordToUpper + "ES" == word || wordToUpper + "LY" == word || wordToUpper + "S" == word || wordToUpper + "IES" == word)
    //     {
    //       count+= 1;
    //     }
    //     else
    //     {
    //       count+= 0;
    //     }
    //   }
    //   return count;
    // }

    public int GetContains()
    {
      int counter = 0;
      string[] wordSet = _text.Split();

      StringComparison comp = StringComparison.OrdinalIgnoreCase;

      foreach(string word in wordSet)
      if ((comp, wordSet.Contains(word, comp) == true))
      {
        counter+= 1;
      }
      else
      {
        counter+= 0;
      }
      return counter;
    }



  }
}
//
// public int GetCount()
// {
//   int wordCount = 0;
//
//   string textToUpper = _text.ToUpper();
//   string[] wordSet = textToUpper.Split();
//
//   foreach(string word in wordSet)
//   {
//     wordCount+= 1;
//   }
//     return wordCount;
// }
