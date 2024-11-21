using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_Environement.src
{
    internal class Conversions
    {
        public static void KGtoLB(double input)
        {
            double LBTotal = input * 2.20462;
            Console.WriteLine("{0:F2}", LBTotal);
        }

        public static void LBtoKG(double input)
        {
            double KGTotal = input * 2.20462;
            Console.WriteLine("{0:F2}", KGTotal);
        }
    }
}
