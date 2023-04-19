using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switcharoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Switcharoo("923456781"));
            Console.ReadKey();
        }
        public static string Switcharoo(String s)
        {
            if (s.Length <= 1)
                return "Incompatible";
            /*  char aux;
              char[] cadena=s.ToCharArray();
              aux = cadena[0];
              cadena[0] = cadena[cadena.Length-1];
              cadena[cadena.Length - 1] = aux;
              return new string(cadena);
            */
         string a, b, c;
            a = s.Substring(s.Length - 1);
            b = s.Substring(1, s.Length - 2);
            c= s.Substring(0, 1);

            return s.Substring(s.Length - 1) + s.Substring(1,s.Length-2) +s.Substring(0,1);

        }
    }
}
