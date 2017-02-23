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
            List<string> textSuffixed = new List<string> {};

            string wordUpper = _word.ToUpper();
            string textUpper = _text.ToUpper();
            var textSplit = textUpper.Split(',').ToList();
            List<string> suffixes = new List<string> {"", "ING", "IES", "Y", "EY", "TION", "ED", "ES", "ITIS", "ATION", "FY", "'S", "S'", "S"};


            foreach (var element in suffixes)
            {
                return textSuffixed = element + textSplit;
            }

            foreach (string textWord in textSuffixed)
            {
                if (wordUpper == textWord)
                {
                    count+= 1;
                }
                else
                {
                    count+= 0;
                }
            }
            return count;
        }

    }
}
