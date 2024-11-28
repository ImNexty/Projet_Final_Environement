using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_Environement.src
{
    internal class Conversions
    {
        public static bool ConversionPoids()
        {
            string input = "";
            bool quit = false;
            do
            {
                Console.WriteLine("1-KG to LB");
                Console.WriteLine("2-LB to KG");
                Console.WriteLine("3-Change type of conversion");
                Console.WriteLine("4-Quit");
                input = Console.ReadLine();

            } while (!inputChecks.OneTwoThreeFour(input));

            do
            {
                switch (input)
                {
                    case "1":
                        string inputConvertion;
                        do
                        {
                            Console.WriteLine("Enter weight to convert");
                            inputConvertion = Console.ReadLine().ToUpper();

                        } while (!inputChecks.IsInt(inputConvertion) || inputConvertion != "QUIT");

                        if(inputConvertion == "QUIT")
                        {
                            quit = true;
                        }
                        else
                        {
                            Conversions.KGtoLB(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "2":
                        do
                        {
                            Console.WriteLine("Enter weight to convert");
                            inputConvertion = Console.ReadLine().ToUpper();

                        } while (!inputChecks.IsInt(inputConvertion) || inputConvertion != "QUIT");

                        if (inputConvertion == "QUIT")
                        {
                            quit = true;
                        }
                        else
                        {
                            Conversions.LBtoKG(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "3":
                        ConsoleInteractions.ChooseConversion(out quit);
                        break;

                    case "4":
                        quit = true;
                        break;
                }
            }while (!quit);
            return quit;
        }
        public static void KGtoLB(double input)
        {
            double LBTotal = input * 2.20462;
            Console.WriteLine("{0:F2}", LBTotal + " LB");
        }

        public static void LBtoKG(double input)
        {
            double KGTotal = input / 2.20462;
            Console.WriteLine("{0:F2}", KGTotal + " KG");
        }
        public static void MeterToFeet(double input)
        {
            double FeetTotal = input * 3.28084;
            Console.WriteLine("{0:F2}", FeetTotal + " Feet");
        }
        public static void FeetToMeter(double input)
        {
            double MeterTotal = input / 3.28084;
            Console.WriteLine("{0:F2}", MeterTotal + " Meters");
        }
        public static void SquareMetersToSquareFeet(double input)
        {
            double SquareFeetTotal = input * 10.76391041671;
            Console.WriteLine("{0:F2}", SquareFeetTotal + "Square Feet");
        }
        public static void SquareFeetToSquareMeter(double input)
        {
            double SquareMeterTotal = input / 10.76391041671;
            Console.WriteLine("{0:F2}", SquareMeterTotal + "Square Meters");
        }
        public static void CtoF(double input)
        {
            double C = input * (9/5) + 32;
            Console.WriteLine("{0:F2}", C + "Celsius");
        }
        public static void FtoC(double input)
        {
            double F = (input - 32) * (5/9);
            Console.WriteLine("{0:F2}", F + "Fahrenheit");
        }
    }
}
