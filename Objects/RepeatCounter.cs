using System;
using System.Collections.Generic;

namespace RepeatCounterApp
{
    public class RepeatCounter
    {
        private string _word;
        private string _text;

        public RepeatCounter(string word, string text)
        {
            _word = word;
            _text = text;
        }

        public int CountRepeats()
        {
            int count = 0;
            {
                if (_word == _text)
                {
                    count+= 1;
                }
                return count;
            }
        }

    }
}
