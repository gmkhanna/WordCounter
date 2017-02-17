using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    // private string _initialWord;
    private string _text;

//string initialWord,
    public RepeatCounter(string text)
    {

      // _initialWord = initialWord;
      _text = text;
    }


    public int GetCount()
    {
      int wordCount = 0;

      string textToUpper = _text.ToUpper();
      string[] wordSet = textToUpper.Split();

      foreach(string word in wordSet)
      {
        wordCount+= 1;
      }
        return wordCount;
    }

    // public int GetCount()
    // {
    //   int count = 0;
    //   int textCount = 0;
    //
    //
    //   string wordToUpper = _initialWord.ToUpper();
    //
    //   string textToUpper = _text.ToUpper();
    //   string[] wordSet = textToUpper.Split();
    //
    //   foreach(string word in wordSet)
    //   {
    //     if (wordToUpper = word)
    //     {
    //       count+= 1;
    //     }
    //     else
    //     {
    //       count+= 0;
    //     }
    //     return count;
    //
    //   }
    // }

  }
}
