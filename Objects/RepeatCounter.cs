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

            string wordUpper = _word.ToUpper();
            string textUpper = _text.ToUpper();

            {
                if (wordUpper == textUpper)
                {
                    count+= 1;
                }
                else
                {
                    count+= 0;
                }
                return count;
            }
        }

    }
}
