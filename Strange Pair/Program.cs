using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strange_Pair
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static Boolean strange_pair(string cad1, string cad2)
        {
            char[] c1, c2;
            c1=cad1.ToUpper().ToCharArray();
            c2=cad2.ToUpper().ToCharArray();
            return c1[0] == c2[c2.Length-1] && c1[c1.Length-1] == c2[0];
            /*char v1, v2,v3,v4;
            v1= c1[0];
            v2 = c2[c2.Length-1];
            v3 = c1[c1.Length-1];
            v4 = c2[0];
            if (v1 == v2 && v3==v4) {
                return true;
            }
            else
            {
                return false;
            }
            */
            
        }
    }
}
