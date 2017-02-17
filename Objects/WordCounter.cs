using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _initialWord;
    private string _checkText;

    public RepeatCounter(string initialWord, string checkText)
    {
      _initialWord = initialWord;
      _checkText = checkText;

    }

    public bool CountRepeatsBool()
    {
      if (_initialWord == _checkText)
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
