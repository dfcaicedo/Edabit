using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_a_Number_is_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("______________________");
            for (int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
            {
                if (isPrime(i))
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        public static Boolean isPrime(int dato)
        {
            for (int i = 2;i<=dato/2;i++)
                if (dato % i == 0)
                    return false;
            return true;
        }
    }
}
