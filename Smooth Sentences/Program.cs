using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smooth_Sentences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la frase");
            string a;
            a = "jose esta aprendiendo operaciones sobre edabit";
           // a = Console.ReadLine(); 
            Console.WriteLine(Smooth_Sentences(a));
            Console.ReadKey();
        }
        public static bool Smooth_Sentences(string frase)
        {
            string[] pal = frase.ToUpper().Split(' ');
            for (int i = 1;i<pal.Length;i++)
            {
                /*string ult, pri;
                ult = pal[i - 1].Substring(pal[i - 1].Length-1, 1);
                pri = pal[i].Substring(0,1);
                if (ult!=pri)
                    return false;
                */
                char[] ult, pri;
                ult = pal[i-1].ToCharArray();
                pri = pal[i].ToCharArray();
                if (ult[ult.Length - 1] != pri[0])
                    return false;

            }
            return true;
        }
    }
}
