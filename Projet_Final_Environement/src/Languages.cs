using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_Environement.src
{
    /// <summary>
    /// Cette section vérifie le choix de langue fait par l'utilisateur et lui donne un menu dans la langue choisi 
    /// pour choisir le type de conversion
    /// </summary>
    internal class Languages
    {
        public static void English(out bool quit)
        {
            string input;
            quit = false;

            do
            {
                Console.WriteLine("Choose the type of conversion");
                Console.WriteLine("=================");
                Console.WriteLine("1-Convert weight");
                Console.WriteLine("2-Convert distance");
                Console.WriteLine("3-Convert surface");
                Console.WriteLine("4-Convert Temp");
                Console.WriteLine("5-Convert Speed");
                Console.WriteLine("6-Change Language");
                Console.WriteLine("=================");
                Console.WriteLine("7-Quit");
                Console.WriteLine("=================");
                Console.Write("Enter your choice: ");;
                input = Console.ReadLine();
                Console.Clear();

            } while (!inputChecks.OneTwoThreeFourFiveSixSeven(input));

            switch (input)
            {
                case "1":
                    EnglishConversions.ConversionWeight(out quit);
                    break;

                case "2":
                    EnglishConversions.ConversionDistance(out quit);
                    break;

                case "3":
                    EnglishConversions.ConversionSurface(out quit);
                    break;

                case "4":
                    EnglishConversions.ConversionTemperature(out quit);
                    break;

                case "5":
                    EnglishConversions.ConversionSpeed(out quit);
                    break;
                case "6":
                    ConsoleInteractions.ChooseLanguage(out quit);
                    break;
                case "7":
                    quit = true;
                    break;
            }
        }
        public static void French(out bool quit)
        {
            string input;
            quit = false;

            do
            {
                Console.WriteLine("=================");
                Console.WriteLine("1-Convertir le poids");
                Console.WriteLine("2-Convertir la distance");
                Console.WriteLine("3-Convertir la surface");
                Console.WriteLine("4-Convertir la température");
                Console.WriteLine("5-Convertir la vitesse");
                Console.WriteLine("6-Changer de langue");
                Console.WriteLine("=================");
                Console.WriteLine("7-Quitter");
                Console.WriteLine("=================");
                Console.Write("Enter your choice:");
                input = Console.ReadLine();
                Console.Clear();

            } while (!inputChecks.OneTwoThreeFourFiveSixSeven(input));

            switch (input)
            {
                case "1":
                    FrenchConversions.ConversionWeight(out quit);
                    break;

                case "2":
                    FrenchConversions.ConversionDistance(out quit);
                    break;

                case "3":
                    FrenchConversions.ConversionSurface(out quit);
                    break;

                case "4":
                    FrenchConversions.ConversionTemperature(out quit);
                    break;

                case "5":
                    FrenchConversions.ConversionSpeed(out quit);
                    break;
                case "6":
                    ConsoleInteractions.ChooseLanguage(out quit);
                    break;
                case "7":
                    quit = true;
                    break;
            }
        }
        public static void Spanish(out bool quit)
        {
            string input;
            quit = false;

            do
            {
                Console.WriteLine("=================");
                Console.WriteLine("1-Convertir peso");
                Console.WriteLine("2-Convertir distancia");
                Console.WriteLine("3-Convertir superficie");
                Console.WriteLine("4-Convertir temperatura");
                Console.WriteLine("5-Convertir velocidad");
                Console.WriteLine("6-Cambiar idioma");
                Console.WriteLine("=================");
                Console.WriteLine("7-Salir");
                Console.WriteLine("=================");
                input = Console.ReadLine();
                Console.Clear();

            } while (!inputChecks.OneTwoThreeFourFiveSixSeven(input));

            switch (input)
            {
                case "1":
                    SpanishConversions.ConversionWeight(out quit);
                    break;

                case "2":
                    SpanishConversions.ConversionDistance(out quit);
                    break;

                case "3":
                    SpanishConversions.ConversionSurface(out quit);
                    break;

                case "4":
                    SpanishConversions.ConversionTemperature(out quit);
                    break;

                case "5":
                    SpanishConversions.ConversionSpeed(out quit);
                    break;
                case "6":
                    ConsoleInteractions.ChooseLanguage(out quit);
                    break;
                case "7":
                    quit = true;
                    break;
            }
        }
    }
}
