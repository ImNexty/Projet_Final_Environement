using System;
using System.Collections;
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
        public static bool ChooseLanguage(out bool quit)
        {
            string input = "";
            quit = false;

            do
            {
                Console.WriteLine("1-English");
                Console.WriteLine("2-Francais");
                Console.WriteLine("3-Espanol");
                Console.WriteLine("4-Exit");
                input = Console.ReadLine();
            }while (!inputChecks.OneTwoThreeFour(input));

            switch (input)
            {
                case "1":
                    Languages.English(out quit);
                    break;
                case "2":
                    Languages.French(out quit);
                    break;
                case "3":
                    Languages.Spanish(out quit);
                    break;
                case "4":
                    quit = true;
                    break;
            }

            return quit;
        }

    }
}
