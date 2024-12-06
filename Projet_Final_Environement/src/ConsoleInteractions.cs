using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_Environement.src
{
    /// <summary>
    /// Cette section est le menu de base et demande à l'utilisateur de choisir une option jusqu'à ce que l'option choisi soit valide. 
    /// L'utilisateur sera redirigé vers l'option choisi.
    /// </summary>
    internal class ConsoleInteractions
    {
        public static bool ChooseLanguage(out bool quit)
        {
            string input = "";
            quit = false;

            do
            {
                Console.WriteLine("Menu language");
                Console.WriteLine("=================");
                Console.WriteLine("1-English");
                Console.WriteLine("2-Francais");
                Console.WriteLine("3-Espanol");
                Console.WriteLine("=================");
                Console.WriteLine("4-Exit");
                Console.WriteLine("=================");
                Console.Write("Enter your choice:");
                input = Console.ReadLine();
                Console.Clear();
            } while (!inputChecks.OneTwoThreeFour(input));

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
