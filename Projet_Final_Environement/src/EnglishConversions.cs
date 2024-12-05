using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projet_Final_Environement.src
{
    internal class EnglishConversions
    {
        public static bool ConversionWeight(out bool quit)
        {
            string input = "";
            quit = false;
            do
            {
                Console.WriteLine("Weight Conversion");
                Console.WriteLine("=================");
                Console.WriteLine("1-KG to LB");
                Console.WriteLine("2-LB to KG");
                Console.WriteLine("3-Stone to KG");
                Console.WriteLine("4-KG to Stone");
                Console.WriteLine("5-Change type of conversion");
                Console.WriteLine("6-Change Language");
                Console.WriteLine("=================");
                Console.WriteLine("7-Quit");
                Console.Write("Enter your choice: ");;
                input = Console.ReadLine();
                Console.Clear();

            } while (!inputChecks.OneTwoThreeFourFiveSixSeven(input));

            do
            {
                switch (input)
                {
                    case "1":
                        string inputConvertion;
                        do
                        {
                            Console.WriteLine("Enter weight in Kg to convert or write back to return to selection");
                            Console.Write("Enter your choice: ");;
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.English(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if(!quit)
                        {
                            EnglishConversions.KGtoLB(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "2":
                        do
                        {
                            Console.WriteLine("Enter weight in Lbs to convert or write back to return to selection");
                            Console.Write("Enter your choice: ");;
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.English(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            EnglishConversions.LBtoKG(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "3":
                        do
                        {
                            Console.WriteLine("Enter weight in Stone to convert or write back to return to selection");
                            Console.Write("Enter your choice: ");;
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.English(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            EnglishConversions.StonetoKg(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "4":
                        do
                        {
                            Console.WriteLine("Enter weight in Kg to convert or write back to return to selection");
                            Console.Write("Enter your choice: ");;
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.English(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            EnglishConversions.KgtoStone(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "5":
                        Languages.English(out quit);
                        break;
                    case "6":
                        ConsoleInteractions.ChooseLanguage(out quit);
                        break;

                    case "7":
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
                Console.WriteLine("Distance Conversion");
                Console.WriteLine("=================");
                Console.WriteLine("1-Meters to feet");
                Console.WriteLine("2-Feet to Meters");
                Console.WriteLine("3-MM to feet");
                Console.WriteLine("4-Feet to MM");
                Console.WriteLine("5-Change type of conversion");
                Console.WriteLine("=================");
                Console.WriteLine("6-Quit");
                Console.WriteLine("=================");
                Console.WriteLine();
                Console.Write("Enter your choice: ");;
                input = Console.ReadLine();
                Console.Clear();

            } while (!inputChecks.OneTwoThreeFourFiveSix(input));

            do
            {
                switch (input)
                {
                    case "1":
                        string inputConvertion;
                        do
                        {
                            Console.WriteLine("Enter distance in meters to convert or write back to return to selection");
                            Console.Write("Enter your choice: ");;
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.English(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            EnglishConversions.MeterToFeet(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "2":
                        do
                        {
                            Console.WriteLine("Enter distance in feet to convert or write back to return to selection");
                            Console.Write("Enter your choice: ");;
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.English(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            EnglishConversions.FeetToMeter(Convert.ToDouble(inputConvertion));
                        }
                        break;
                    case "3":
                        do
                        {
                            Console.WriteLine("Enter distance in MM to convert or write back to return to selection");
                            Console.Write("Enter your choice: ");;
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.English(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            EnglishConversions.MMToFeet(Convert.ToDouble(inputConvertion));
                        }
                        break;
                    case "4":
                        do
                        {
                            Console.WriteLine("Enter distance in feet to convert or write back to return to selection");
                            Console.Write("Enter your choice: ");;
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.English(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            EnglishConversions.FeetToMM(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "5":
                        Languages.English(out quit);
                        break;

                    case "6":
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
                Console.WriteLine("Surface Conversion");
                Console.WriteLine("=================");
                Console.WriteLine("1-Square meters to square feet");
                Console.WriteLine("2-Square feet to square meters");
                Console.WriteLine("3-Square mm to square feet");
                Console.WriteLine("4-Square feet to square mm");
                Console.WriteLine("5-Change type of conversion");
                Console.WriteLine("6-Quit");
                Console.WriteLine("=================");
                Console.WriteLine();
                Console.Write("Enter your choice: ");;
                input = Console.ReadLine();
                Console.Clear();

            } while (!inputChecks.OneTwoThreeFourFiveSix(input));

            do
            {
                switch (input)
                {
                    case "1":
                        string inputConvertion;
                        do
                        {
                            Console.WriteLine("Enter surface in square meters to convert or write back to return to selection");
                            Console.Write("Enter your choice: ");;
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.English(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            EnglishConversions.SquareMetersToSquareFeet(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "2":
                        do
                        {
                            Console.WriteLine("Enter surface in square feet to convert or write back to return to selection");
                            Console.Write("Enter your choice: ");;
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.English(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            EnglishConversions.SquareFeetToSquareMeter(Convert.ToDouble(inputConvertion));
                        }
                        break;
                    case "3":
                        do
                        {
                            Console.WriteLine("Enter surface in square MM to convert or write back to return to selection");
                            Console.Write("Enter your choice: ");;
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.English(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            EnglishConversions.SquareMMToSquareFeet(Convert.ToDouble(inputConvertion));
                        }
                        break;
                    case "4":
                        do
                        {
                            Console.WriteLine("Enter surface in square feet to convert or write back to return to selection");
                            Console.Write("Enter your choice: ");;
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.English(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            EnglishConversions.SquareFeetToSquareMM(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "5":
                        Languages.English(out quit);
                        break;

                    case "6":
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
                Console.WriteLine("Temperature Conversion");
                Console.WriteLine("=================");
                Console.WriteLine("1-Celcius to Faranheit");
                Console.WriteLine("2-Faranheit to Celcius");
                Console.WriteLine("3-Faranheit to Kelvin");
                Console.WriteLine("4-Kelvin to Faranheit");
                Console.WriteLine("5-Change type of conversion");
                Console.WriteLine("6-Quit");
                Console.WriteLine("=================");
                Console.WriteLine();
                Console.Write("Enter your choice: ");;
                input = Console.ReadLine();
                Console.Clear();

            } while (!inputChecks.OneTwoThreeFourFiveSix(input));

            do
            {
                switch (input)
                {
                    case "1":
                        string inputConvertion;
                        do
                        {
                            Console.WriteLine("Enter temperature in Celcius to convert or write back to return to selection");
                            Console.Write("Enter your choice: ");;
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.English(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            EnglishConversions.CtoF(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "2":
                        do
                        {
                            Console.WriteLine("Enter temperature in Faranheit to convert or write back to return to selection");
                            Console.Write("Enter your choice: ");;
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.English(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            EnglishConversions.FtoC(Convert.ToDouble(inputConvertion));
                        }
                        break;
                    case "3":
                        do
                        {
                            Console.WriteLine("Enter temperature in Fahrenheit to convert or write back to return to selection");
                            Console.Write("Enter your choice: ");;
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.English(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            EnglishConversions.FtoK(Convert.ToDouble(inputConvertion));
                        }
                        break;
                    case "4":
                        do
                        {
                            Console.WriteLine("Enter temperature in Kelvin to convert or write back to return to selection");
                            Console.Write("Enter your choice: ");;
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.English(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            EnglishConversions.KtoF(Convert.ToDouble(inputConvertion));
                        }
                        break;


                    case "5":
                        Languages.English(out quit);
                        break;

                    case "6":
                        quit = true;
                        break;
                }
            } while (!quit);
            return quit;
        }
        public static bool ConversionSpeed(out bool quit)
        {
            string input = "";
            quit = false;
            do
            {
                Console.WriteLine("Speed Conversion");
                Console.WriteLine("=================");
                Console.WriteLine("1-KM/H to MPH");
                Console.WriteLine("2-MPH to KM/H");
                Console.WriteLine("3-FOOT/H to MM/MIN");
                Console.WriteLine("4-MM/MIN to FOOT/H");
                Console.WriteLine("5-Change type of conversion");
                Console.WriteLine("6-Quit");
                Console.WriteLine("=================");
                Console.WriteLine();
                Console.Write("Enter your choice: ");;
                input = Console.ReadLine();
                Console.Clear();

            } while (!inputChecks.OneTwoThreeFourFiveSix(input));

            do
            {
                switch (input)
                {
                    case "1":
                        string inputConvertion;
                        do
                        {
                            Console.WriteLine("Enter speed in KM/H to convert or write back to return to selection");
                            Console.Write("Enter your choice: ");;
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.English(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            EnglishConversions.SpeedKmToMPH(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "2":
                        do
                        {
                            Console.WriteLine("Enter speed in MPH to convert or write back to return to selection");
                            Console.Write("Enter your choice: ");;
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.English(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            EnglishConversions.SpeedMPHToKm(Convert.ToDouble(inputConvertion));
                        }
                        break;
                    case "3":
                        do
                        {
                            Console.WriteLine("Enter speed in FOOT/H to convert or write back to return to selection");
                            Console.Write("Enter your choice: ");;
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.English(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            EnglishConversions.SpeedFootToMM(Convert.ToDouble(inputConvertion));
                        }
                        break;
                    case "4":
                        do
                        {
                            Console.WriteLine("Enter speed in MM/MIN to convert or write back to return to selection");
                            Console.Write("Enter your choice: ");;
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.English(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            EnglishConversions.SpeedMMToFoot(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "5":
                        Languages.English(out quit);
                        break;

                    case "6":
                        quit = true;
                        break;
                }
            } while (!quit);
            return quit;
        }
        public static void KGtoLB(double input)
        {
            Console.Clear();
            double LBTotal = input * 2.20462;
            Console.WriteLine("=================");
            Console.WriteLine(input + " KG =" +(Math.Round(LBTotal, 2)) + " LB");
            Console.WriteLine("=================");
        }

        public static void LBtoKG(double input)
        {
            Console.Clear();
            double KGTotal = input / 2.20462;
            Console.WriteLine("=================");
            Console.WriteLine(input + " LB =" +(Math.Round(KGTotal, 2)) + " KG");
            Console.WriteLine("=================");
        }
        public static void StonetoKg(double input)
        {
            Console.Clear();
            double Stone = (input * 6.35029);
            Console.WriteLine("=================");
            Console.WriteLine(input + " Stone =" +(Math.Round(Stone, 2)) + " Kg");
            Console.WriteLine("=================");
        }
        public static void KgtoStone(double input)
        {
            Console.Clear();
            double Stone = (input / 6.35029);
            Console.WriteLine("=================");
            Console.WriteLine(input + " KG =" + (Math.Round(Stone, 2)) + " Stone");
            Console.WriteLine("=================");
        }
        public static void MeterToFeet(double input)
        {
            Console.Clear();
            double FeetTotal = input * 3.28084;
            Console.WriteLine("=================");
            Console.WriteLine(input + " Meter =" + (Math.Round(FeetTotal, 2)) + " Feet");
            Console.WriteLine("=================");
        }
        public static void FeetToMeter(double input)
        {
            Console.Clear();
            double MeterTotal = input / 3.28084;
            Console.WriteLine("=================");
            Console.WriteLine(input + " Feet =" + (Math.Round(MeterTotal, 2)) + " Meters");
            Console.WriteLine("=================");
        }
        public static void MMToFeet(double input)
        {
            Console.Clear();
            double MM = input / 304.8;
            Console.WriteLine("=================");
            Console.WriteLine(input + " MM =" + (Math.Round(MM, 2)) + " Feet");
            Console.WriteLine("=================");
        }
        public static void FeetToMM(double input)
        {
            Console.Clear();
            double MM = input * 304.8;
            Console.WriteLine("=================");
            Console.WriteLine(input + " Feet =" + (Math.Round(MM, 2)) + " MM");
            Console.WriteLine("=================");
        }

        public static void SquareMetersToSquareFeet(double input)
        {
            Console.Clear();
            double SquareFeetTotal = input * 10.76391041671;
            Console.WriteLine("=================");
            Console.WriteLine(input + " square meters =" + (Math.Round(SquareFeetTotal, 2)) + " Square Feet");
            Console.WriteLine("=================");
        }
        public static void SquareFeetToSquareMeter(double input)
        {
            Console.Clear();
            double SquareMeterTotal = input / 10.76391041671;
            Console.WriteLine("=================");
            Console.WriteLine(input + " square feet =" + (Math.Round(SquareMeterTotal, 2)) + " Square Meters");
            Console.WriteLine("=================");
        }
        public static void SquareMMToSquareFeet(double input)
        {
            Console.Clear();
            double SquareMMTotal = input / 93078.24;
            Console.WriteLine("=================");
            Console.WriteLine(input + " square mm =" + (Math.Round(SquareMMTotal, 2)) + " Square Feet");
            Console.WriteLine("=================");
        }
        public static void SquareFeetToSquareMM(double input)
        {
            Console.Clear();
            double SquareFeetTotal = input * 93078.24;
            Console.WriteLine("=================");
            Console.WriteLine(input + " square feet =" + (Math.Round(SquareFeetTotal, 2)) + " Square MM");
            Console.WriteLine("=================");
        }

        public static void CtoF(double input)
        {
            Console.Clear();
            double C = input * (9/5) + 32;
            Console.WriteLine("=================");
            Console.WriteLine(input + " Celcius =" + (Math.Round(C, 2)) + " Faranheit");
            Console.WriteLine("=================");
        }
        public static void FtoC(double input)
        {
            Console.Clear();
            double F = (input - 32) * (5/9);
            Console.WriteLine("=================");
            Console.WriteLine(input + " Faranheit =" + (Math.Round(F, 2)) + " Celcius");
            Console.WriteLine("=================");
        }
        public static void FtoK(double input)
        {
            Console.Clear();
            double F = ((input - 32) / 1.8) + 273.15;
            Console.WriteLine("=================");
            Console.WriteLine(input + " Faranheit =" + (Math.Round(F, 2)) + " Kelvin");
            Console.WriteLine("=================");
        }
        public static void KtoF(double input)
        {
            Console.Clear();
            double K = ((input - 273.15) * 1.8) + 32;
            Console.WriteLine("=================");
            Console.WriteLine(input + " Kelvin =" + (Math.Round(K, 2)) + " Fahrenheit");
            Console.WriteLine("=================");
        }
        public static void SpeedKmToMPH(double input)
        {
            Console.Clear();
            double Km = (input * 0.621371);
            Console.WriteLine("=================");
            Console.WriteLine(input + " Km/h =" + (Math.Round(Km, 2)) + " MPH");
            Console.WriteLine("=================");
        }
        public static void SpeedMPHToKm(double input)
        {
            Console.Clear();
            double Km = (input / 0.621371);
            Console.WriteLine("=================");
            Console.WriteLine(input + " MPH =" + (Math.Round(Km, 2)) + " KM/H");
            Console.WriteLine("=================");
        }
        public static void SpeedFootToMM(double input)
        {
            Console.Clear();
            double Foot = (input * 304.8 / 60);
            Console.WriteLine("=================");
            Console.WriteLine(input + " Foot/hour =" + (Math.Round(Foot, 2)) + " MM/Min");
            Console.WriteLine("=================");
        }
        public static void SpeedMMToFoot(double input)
        {
            Console.Clear();
            double mm = (input * 5.08);
            Console.WriteLine("=================");
            Console.WriteLine(input + " square mm =" + (Math.Round(mm, 2)) + " Foot/H");
            Console.WriteLine("=================");
        }
    }
}
