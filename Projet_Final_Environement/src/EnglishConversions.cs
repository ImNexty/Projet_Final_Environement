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
                Console.WriteLine("1-KG to LB");
                Console.WriteLine("2-LB to KG");
                Console.WriteLine("3-Stone to KG");
                Console.WriteLine("4-KG to Stone");
                Console.WriteLine("5-Change type of conversion");
                Console.WriteLine("6-Change Language");
                Console.WriteLine("7-Quit");
                input = Console.ReadLine();

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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                Console.WriteLine("1-Meters to feet");
                Console.WriteLine("2-Feet to Meters");
                Console.WriteLine("3-MM to feet");
                Console.WriteLine("4-Feet to MM");
                Console.WriteLine("5-Change type of conversion");
                Console.WriteLine("6-Quit");
                input = Console.ReadLine();

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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                Console.WriteLine("1-Square meters to square feet");
                Console.WriteLine("2-Square feet to square meters");
                Console.WriteLine("3-Square mm to square feet");
                Console.WriteLine("4-Square feet to square mm");
                Console.WriteLine("5-Change type of conversion");
                Console.WriteLine("6-Quit");
                input = Console.ReadLine();

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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                Console.WriteLine("1-Celcius to Faranheit");
                Console.WriteLine("2-Faranheit to Celcius");
                Console.WriteLine("3-Faranheit to Kelvin");
                Console.WriteLine("4-Kelvin to Faranheit");
                Console.WriteLine("5-Change type of conversion");
                Console.WriteLine("6-Quit");
                input = Console.ReadLine();

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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                Console.WriteLine("1-KM/H to MPH");
                Console.WriteLine("2-MPH to KM/H");
                Console.WriteLine("3-FOOT/H to MM/MIN");
                Console.WriteLine("4-MM/MIN to FOOT/H");
                Console.WriteLine("5-Change type of conversion");
                Console.WriteLine("6-Quit");
                input = Console.ReadLine();

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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
            double LBTotal = input * 2.20462;
            Console.WriteLine((Math.Round(LBTotal, 2)) + " LB");
        }

        public static void LBtoKG(double input)
        {
            double KGTotal = input / 2.20462;
            Console.WriteLine((Math.Round(KGTotal, 2)) + " KG");
        }
        public static void StonetoKg(double input)
        {
            double Stone = (input * 6.35029);
            Console.WriteLine((Math.Round(Stone, 2)) + " Kg");
        }
        public static void KgtoStone(double input)
        {
            double Stone = (input / 6.35029);
            Console.WriteLine((Math.Round(Stone, 2)) + " Stone");
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
        public static void MMToFeet(double input)
        {
            double MM = input / 304.8;
            Console.WriteLine((Math.Round(MM, 2)) + " Feet");
        }
        public static void FeetToMM(double input)
        {
            double MM = input * 304.8;
            Console.WriteLine((Math.Round(MM, 2)) + " MM");
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
        public static void SquareMMToSquareFeet(double input)
        {
            double SquareMMTotal = input / 93078.24;
            Console.WriteLine((Math.Round(SquareMMTotal, 2)) + " Square Feet");
        }
        public static void SquareFeetToSquareMM(double input)
        {
            double SquareFeetTotal = input * 93078.24;
            Console.WriteLine((Math.Round(SquareFeetTotal, 2)) + " Square MM");
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
        public static void FtoK(double input)
        {
            double F = ((input - 32) / 1.8) + 273.15;
            Console.WriteLine((Math.Round(F, 2)) + " Kelvin");
        }
        public static void KtoF(double input)
        {
            double K = ((input - 273.15) * 1.8) + 32;
            Console.WriteLine((Math.Round(K, 2)) + " Fahrenheit");
        }
        public static void SpeedKmToMPH(double input)
        {
            double Km = (input * 0.621371);
            Console.WriteLine((Math.Round(Km, 2)) + " MPH");
        }
        public static void SpeedMPHToKm(double input)
        {
            double Km = (input / 0.621371);
            Console.WriteLine((Math.Round(Km, 2)) + " KM/H");
        }
        public static void SpeedFootToMM(double input)
        {
            double Foot = (input * 304.8 / 60);
            Console.WriteLine((Math.Round(Foot, 2)) + " MM/Min");
        }
        public static void SpeedMMToFoot(double input)
        {
            double mm = (input * 5.08);
            Console.WriteLine((Math.Round(mm, 2)) + " Foot/H");
        }
    }
}
