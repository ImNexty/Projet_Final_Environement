using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_Environement.src
{
    internal class ConsoleInteractions
    {
        public static bool ConvertOrQuit(out bool quit)
        {
            string input = "";
            quit = false;
            do
            {
                Console.WriteLine("1-Convert");
                Console.WriteLine("2-Quit");
                input = Console.ReadLine();

            } while (!inputChecks.OneOrTwo(input));

            if (inputChecks.Quit(input))
            {
                quit = true;
                return quit;
            }
            else
            {
                return quit;
            }
        }
        public static bool ChooseConversion(out bool quit)
        {
            string input = "";
            quit = false;

            do
            {
                Console.WriteLine("1-Convert weight");
                Console.WriteLine("2-Convert distance");
                Console.WriteLine("3-Convert surface");
                Console.WriteLine("4-Convert Temp");
                Console.WriteLine("5-Quit");
                input = Console.ReadLine();

            } while (!inputChecks.OneTwoThreeFourFive(input));

            switch (input)
            {
                case "1":
                    Conversions.ConversionPoids();
                    break;

                case "2":
                    break;

                case "3":
                    break;

                case "4":
                    break;

                case "5":
                    quit = true;
                    break;
            }
            return quit;
        }

    }
}
