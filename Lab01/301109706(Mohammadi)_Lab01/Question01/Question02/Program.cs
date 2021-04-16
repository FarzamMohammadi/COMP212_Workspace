using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("My name is Farzam Mohammadi and this is Programming 3 and its fun");

            Console.WriteLine(stringBuilder.CountWords());
        }
    }
}
