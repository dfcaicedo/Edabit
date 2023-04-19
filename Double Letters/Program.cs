using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
            Console.WriteLine(doubleletter("dadDy"));
            Console.WriteLine(doubleletter("daduy"));
            Console.WriteLine(doubleletter("dadiy"));
            Console.WriteLine(doubleletter("dadty"));
            Console.WriteLine(doubleletter("dadyy"));
            Console.WriteLine(doubleletter("dadty"));
            Console.WriteLine(doubleletter("dadey"));
            Console.ReadKey();
        }
        public static bool doubleletter(string word)
        {
            char[] chars = word.ToLower().ToCharArray();
            for (int c = 0; c < chars.Length-1; c++)
            {
                if (chars[c] == chars[c+1])
                    return true;
            }
            return false;
        }
    }
}
