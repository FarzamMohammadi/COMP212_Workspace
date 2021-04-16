using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    static class ExtendStringBuilder
    {
        public static int CountWords(this StringBuilder phraseToCount)
        {

            string words = phraseToCount.ToString();
            string[] wordArray = words.Split(' ');
            int counter = 0;
            
            foreach(string word in wordArray)
            {
                counter++;
            }

            return counter;

        }
    }
}
