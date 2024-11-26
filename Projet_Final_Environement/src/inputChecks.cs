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
            if (int.TryParse(input, out int result))
            {
                return true;
            }
            else
            {
                Console.WriteLine($"The input '{input}' is not a valid integer.");
                return false;
            }
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
                Console.WriteLine("Invalid input");
                return false;
            }
        }
    }
}

