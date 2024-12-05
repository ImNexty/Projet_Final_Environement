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
                Console.WriteLine("Error/Erreur");
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
                Console.WriteLine("Error/Erreur");
                return false;
            }
        }
        public static bool OneTwoThreeFour(string input)
        {
            if (input == "1" || input == "2" || input == "3" || input == "4")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Error/Erreur");
                return false;
            }
        }
        public static bool OneTwoThreeFourFiveSix(string input)
        {
            if (input == "1" || input == "2" || input == "3" || input == "4" || input == "5" || input == "6")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Error/Erreur");
                return false;
            }
        }
        public static bool OneTwoThreeFourFiveSixSeven(string input)
        {
            if (input == "1" || input == "2" || input == "3" || input == "4" || input == "5" || input == "6" || input == "7")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Error/Erreur");
                return false;
            }
        }
    }
}

