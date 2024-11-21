using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_Environement.src
{
    internal class inputChecks
    {
        public static bool IsInt(string input)
        {
            return int.TryParse(input, out _);
        }
        public static bool Quit(string input)
        {
            int numb = Convert.ToInt32(input);
            bool quit = false;

            if (numb == 2)
            {
                quit = true;
                return quit;
            }
            else
            {
                return quit;
            }
        }
        public static bool OneOrTwo(string input)
        {
            if(input == "1" || input == "2")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

