using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Reversing_a_Binary_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BinarioaDecimal(DecToBinary(12)));
            Console.ReadKey();
        }
        public static string DecToBinary(int value)
        {
            string acu = "";
            while(value > 0)
            {
                acu = (value % 2).ToString() + acu;
                value = (value-value%2)/2;
            }
            return acu;
        }
        /*
        public static string reverse(string s)
        {
            char[] chars = s.ToCharArray();
            char[] respuesta= new char[chars.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                respuesta[i] = chars[chars.Length-1-i];
            }
            return new string(respuesta);
        }
        */
        public static int BinarioaDecimal(string s)
        {
            int acu = 0;
            char[]  chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                int num = (int)chars[i]-48;
                acu += (int) (num * Math.Pow(2, i));
            }
            return acu;
        }
    }
}
