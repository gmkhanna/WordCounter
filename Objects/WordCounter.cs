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

    public int GetCount()
    {
      int count = 0;
      string wordToUpper = _initialWord.ToUpper();
      string textToUpper = _text.ToUpper();

      if(wordToUpper == textToUpper)
      {
        count+= 1;
      }
    return count;
    }
  }
}
