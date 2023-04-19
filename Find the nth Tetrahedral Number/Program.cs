using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_nth_Tetrahedral_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factor(5));


            Console.ReadKey();
        }
        public static int factor(int a)
        {
            if (a == 1) 
                return 1;
            return ((a * (a + 1)) / 2) + factor(a - 1);
        }
    }
}
