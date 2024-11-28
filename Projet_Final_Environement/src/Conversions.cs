using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projet_Final_Environement.src
{
    internal class Conversions
    {
        public static bool ConversionWeight(out bool quit)
        {
            string input = "";
            quit = false;
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
                            Console.WriteLine("Enter weight in Kg to convert or write back to return to selection");
                            inputConvertion = Console.ReadLine().ToUpper();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                ConsoleInteractions.ChooseConversion(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if(!quit)
                        {
                            Conversions.KGtoLB(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "2":
                        do
                        {
                            Console.WriteLine("Enter weight in Lbs to convert or write back to return to selection");
                            inputConvertion = Console.ReadLine().ToUpper();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                ConsoleInteractions.ChooseConversion(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
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

        public static bool ConversionDistance(out bool quit)
        {
            string input = "";
            quit = false;
            do
            {
                Console.WriteLine("1-Meters to feet");
                Console.WriteLine("2-Feet to Meters");
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
                            Console.WriteLine("Enter distance in meters to convert or write back to return to selection");
                            inputConvertion = Console.ReadLine().ToUpper();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                ConsoleInteractions.ChooseConversion(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            Conversions.MeterToFeet(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "2":
                        do
                        {
                            Console.WriteLine("Enter distance in feet to convert or write back to return to selection");
                            inputConvertion = Console.ReadLine().ToUpper();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                ConsoleInteractions.ChooseConversion(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            Conversions.FeetToMeter(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "3":
                        ConsoleInteractions.ChooseConversion(out quit);
                        break;

                    case "4":
                        quit = true;
                        break;
                }
            } while (!quit);
            return quit;
        }

        public static bool ConversionSurface(out bool quit)
        {
            string input = "";
            quit = false;
            do
            {
                Console.WriteLine("1-Square meters to square feet");
                Console.WriteLine("2-Square feet to square meters");
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
                            Console.WriteLine("Enter surface in square meters to convert or write back to return to selection");
                            inputConvertion = Console.ReadLine().ToUpper();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                ConsoleInteractions.ChooseConversion(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            Conversions.SquareMetersToSquareFeet(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "2":
                        do
                        {
                            Console.WriteLine("Enter surface in square feet to convert or write back to return to selection");
                            inputConvertion = Console.ReadLine().ToUpper();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                ConsoleInteractions.ChooseConversion(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            Conversions.SquareFeetToSquareMeter(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "3":
                        ConsoleInteractions.ChooseConversion(out quit);
                        break;

                    case "4":
                        quit = true;
                        break;
                }
            } while (!quit);
            return quit;
        }

        public static bool ConversionTemperature(out bool quit)
        {
            string input = "";
            quit = false;
            do
            {
                Console.WriteLine("1-Celcius to Faranheit");
                Console.WriteLine("2-Faranheit to Celcius");
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
                            Console.WriteLine("Enter temperature in Celcius to convert or write back to return to selection");
                            inputConvertion = Console.ReadLine().ToUpper();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                ConsoleInteractions.ChooseConversion(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            Conversions.CtoF(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "2":
                        do
                        {
                            Console.WriteLine("Enter temperature in Faranheit to convert or write back to return to selection");
                            inputConvertion = Console.ReadLine().ToUpper();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                ConsoleInteractions.ChooseConversion(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            Conversions.FtoC(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "3":
                        ConsoleInteractions.ChooseConversion(out quit);
                        break;

                    case "4":
                        quit = true;
                        break;
                }
            } while (!quit);
            return quit;
        }
        public static void KGtoLB(double input)
        {
            double LBTotal = input * 2.20462;
            Console.WriteLine((Math.Round(LBTotal, 2)) + " LB");
        }

        public static void LBtoKG(double input)
        {
            double KGTotal = input / 2.20462;
            Console.WriteLine((Math.Round(KGTotal, 2)) + " KG");
        }
        public static void MeterToFeet(double input)
        {
            double FeetTotal = input * 3.28084;
            Console.WriteLine((Math.Round(FeetTotal, 2)) + " Feet");
        }
        public static void FeetToMeter(double input)
        {
            double MeterTotal = input / 3.28084;
            Console.WriteLine((Math.Round(MeterTotal, 2)) + " Meters");
        }
        public static void SquareMetersToSquareFeet(double input)
        {
            double SquareFeetTotal = input * 10.76391041671;
            Console.WriteLine((Math.Round(SquareFeetTotal, 2)) + " Square Feet");
        }
        public static void SquareFeetToSquareMeter(double input)
        {
            double SquareMeterTotal = input / 10.76391041671;
            Console.WriteLine((Math.Round(SquareMeterTotal, 2)) + " Square Meters");
        }
        public static void CtoF(double input)
        {
            double C = input * (9/5) + 32;
            Console.WriteLine((Math.Round(C, 2)) + " Faranheit");
        }
        public static void FtoC(double input)
        {
            double F = (input - 32) * (5/9);
            Console.WriteLine((Math.Round(F, 2)) + " Celcius");
        }
    }
}
