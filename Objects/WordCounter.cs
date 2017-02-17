using System;
using System.Collections.Generic;

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

    public bool GetContains()
    {
      if (_text.Contains(_initialWord))
      {
        return true;
      }
      else
      {
        return false;
      }
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
