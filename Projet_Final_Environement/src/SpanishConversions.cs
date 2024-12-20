﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_Environement.src
{
    /// <summary>
    /// Cette section comprend toutes les conversions (calculs) et les menus de choix des unités pour quand l'utilisateur choisit
    /// l'option de langue espagnole. C'est dans ces boucles que les résultats seront calculés et affichés selon les options choisies
    /// </summary>
    internal class SpanishConversions
    {
        public static bool ConversionWeight(out bool quit)
        {
            string input = "";
            quit = false;
            do
            {
                Console.WriteLine("Conversión de peso:");
                Console.WriteLine("=================");
                Console.WriteLine("1-KG a LB");
                Console.WriteLine("2-LB a KG");
                Console.WriteLine("3-Stone a KG");
                Console.WriteLine("4-KG a Stone");
                Console.WriteLine("5-Cambiar tipo de conversión");
                Console.WriteLine("6-Cambiar idioma");
                Console.WriteLine("=================");
                Console.WriteLine("7-Salir");
                Console.WriteLine("=================");
                Console.Write("Ingrese su elección: ");

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
                            Console.WriteLine("Ingrese el peso en Kg para convertir o escriba 'BACK' para volver a la selección");
                            Console.Write("Ingrese su elección: ");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.Spanish(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            SpanishConversions.KGtoLB(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "2":
                        do
                        {
                            Console.WriteLine("Ingrese el peso en Lbs para convertir o escriba 'BACK' para volver a la selección");
                            Console.Write("Ingrese su elección: ");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.Spanish(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            SpanishConversions.LBtoKG(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "3":
                        do
                        {
                            Console.WriteLine("Ingrese el peso en Stone para convertir o escriba 'BACK' para volver a la selección");
                            Console.Write("Ingrese su elección: ");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.Spanish(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            SpanishConversions.StonetoKg(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "4":
                        do
                        {
                            Console.WriteLine("Ingrese el peso en Kg para convertir o escriba 'BACK' para volver a la selección");
                            Console.Write("Ingrese su elección: ");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.Spanish(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            SpanishConversions.KgtoStone(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "5":
                        Languages.Spanish(out quit);
                        break;
                    case "6":
                        ConsoleInteractions.ChooseLanguage(out quit);
                        break;

                    case "7":
                        quit = true;
                        break;
                }
            } while (!quit);
            return quit;
        }

        public static bool ConversionDistance(out bool quit)
        {
            string input = "";
            quit = false;
            do
            {
                Console.WriteLine("Conversión de distancia:");
                Console.WriteLine("=================");
                Console.WriteLine("1-Metros a pies");
                Console.WriteLine("2-Pies a metros");
                Console.WriteLine("3-MM a pies");
                Console.WriteLine("4-Pies a MM");
                Console.WriteLine("5-Cambiar tipo de conversión");
                Console.WriteLine("=================");
                Console.WriteLine("6-Salir");
                Console.WriteLine("=================");
                Console.Write("Ingrese su elección: ");
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
                            Console.WriteLine("Ingrese la distancia en metros para convertir o escriba 'BACK' para volver a la selección");
                            Console.Write("Ingrese su elección: ");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.Spanish(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            SpanishConversions.MeterToFeet(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "2":
                        do
                        {
                            Console.WriteLine("Ingrese la distancia en pies para convertir o escriba 'BACK' para volver a la selección");
                            Console.Write("Ingrese su elección: ");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.Spanish(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            SpanishConversions.FeetToMeter(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "3":
                        do
                        {
                            Console.WriteLine("Ingrese la distancia en MM para convertir o escriba 'BACK' para volver a la selección");
                            Console.Write("Ingrese su elección: ");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.Spanish(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            SpanishConversions.MMToFeet(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "4":
                        do
                        {
                            Console.WriteLine("Ingrese la distancia en pies para convertir o escriba 'BACK' para volver a la selección");
                            Console.Write("Ingrese su elección: ");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.Spanish(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            SpanishConversions.FeetToMM(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "5":
                        Languages.Spanish(out quit);
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
                Console.WriteLine("Conversión de superficie:");
                Console.WriteLine("=================");
                Console.WriteLine("1-Metros cuadrados a pies cuadrados");
                Console.WriteLine("2-Pies cuadrados a metros cuadrados");
                Console.WriteLine("3-MM cuadrados a pies cuadrados");
                Console.WriteLine("4-Pies cuadrados a MM cuadrados");
                Console.WriteLine("5-Cambiar tipo de conversión");
                Console.WriteLine("=================");
                Console.WriteLine("6-Salir");
                Console.WriteLine("=================");
                Console.Write("Ingrese su elección: ");
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
                            Console.WriteLine("Ingrese la superficie en metros cuadrados para convertir o escriba 'BACK' para volver a la selección");
                            Console.Write("Ingrese su elección: ");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.Spanish(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            SpanishConversions.SquareMetersToSquareFeet(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "2":
                        do
                        {
                            Console.WriteLine("Ingrese la superficie en pies cuadrados para convertir o escriba 'BACK' para volver a la selección");
                            Console.Write("Ingrese su elección: ");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.Spanish(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            SpanishConversions.SquareFeetToSquareMeter(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "3":
                        do
                        {
                            Console.WriteLine("Ingrese la superficie en MM cuadrados para convertir o escriba 'BACK' para volver a la selección");
                            Console.Write("Ingrese su elección: ");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.Spanish(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            SpanishConversions.SquareMMToSquareFeet(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "4":
                        do
                        {
                            Console.WriteLine("Ingrese la superficie en pies cuadrados para convertir o escriba 'BACK' para volver a la selección");
                            Console.Write("Ingrese su elección: ");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.Spanish(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            SpanishConversions.SquareFeetToSquareMM(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "5":
                        Languages.Spanish(out quit);
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
                Console.WriteLine("Conversión de temperatura:");
                Console.WriteLine("=================");
                Console.WriteLine("1-Celsius a Fahrenheit");
                Console.WriteLine("2-Fahrenheit a Celsius");
                Console.WriteLine("3-Fahrenheit a Kelvin");
                Console.WriteLine("4-Kelvin a Fahrenheit");
                Console.WriteLine("5-Cambiar tipo de conversión");
                Console.WriteLine("=================");
                Console.WriteLine("6-Salir");
                Console.WriteLine("=================");
                Console.Write("Ingrese su elección: ");
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
                            Console.WriteLine("Ingrese la temperatura en Celsius para convertir o escriba 'BACK' para volver a la selección");
                            Console.Write("Ingrese su elección: ");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.Spanish(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            SpanishConversions.CtoF(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "2":
                        do
                        {
                            Console.WriteLine("Ingrese la temperatura en Fahrenheit para convertir o escriba 'BACK' para volver a la selección");
                            Console.Write("Ingrese su elección: ");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.Spanish(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            SpanishConversions.FtoC(Convert.ToDouble(inputConvertion));
                        }
                        break;
                    case "3":
                        do
                        {
                            Console.WriteLine("Ingrese la temperatura en Fahrenheit para convertir o escriba 'BACK' para volver a la selección");
                            Console.Write("Ingrese su elección: ");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.Spanish(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            SpanishConversions.FtoK(Convert.ToDouble(inputConvertion));
                        }
                        break;
                    case "4":
                        do
                        {
                            Console.WriteLine("Ingrese la temperatura en Kelvin para convertir o escriba 'BACK' para volver a la selección");
                            Console.Write("Ingrese su elección: ");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.Spanish(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            SpanishConversions.KtoF(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "5":
                        Languages.Spanish(out quit);
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
                Console.WriteLine("Conversión de velocidad:");
                Console.WriteLine("=================");
                Console.WriteLine("1-KM/H a MPH");
                Console.WriteLine("2-MPH a KM/H");
                Console.WriteLine("3-FOOT/H a MM/MIN");
                Console.WriteLine("4-MM/MIN a FOOT/H");
                Console.WriteLine("5-Cambiar tipo de conversión");
                Console.WriteLine("=================");
                Console.WriteLine("6-Salir");
                Console.WriteLine("=================");
                Console.Write("Ingrese su elección: ");
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
                            Console.WriteLine("Ingrese la velocidad en KM/H para convertir o escriba 'BACK' para volver a la selección");
                            Console.Write("Ingrese su elección: ");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.Spanish(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            SpanishConversions.SpeedKmToMPH(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "2":
                        do
                        {
                            Console.WriteLine("Ingrese la velocidad en MPH para convertir o escriba 'BACK' para volver a la selección");
                            Console.Write("Ingrese su elección: ");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.Spanish(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            SpanishConversions.SpeedMPHToKm(Convert.ToDouble(inputConvertion));
                        }
                        break;
                    case "3":
                        do
                        {
                            Console.WriteLine("Ingrese la velocidad en FOOT/H para convertir o escriba 'BACK' para volver a la selección");
                            Console.Write("Ingrese su elección: ");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.Spanish(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            SpanishConversions.SpeedFootToMM(Convert.ToDouble(inputConvertion));
                        }
                        break;
                    case "4":
                        do
                        {
                            Console.WriteLine("Ingrese la velocidad en MM/MIN para convertir o escriba 'BACK' para volver a la selección");
                            Console.Write("Ingrese su elección: ");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.Spanish(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            SpanishConversions.SpeedMMToFoot(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "5":
                        Languages.Spanish(out quit);
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
            Console.WriteLine((Math.Round(LBTotal, 2)) + " LB");
            Console.WriteLine("=================");
        }

        public static void LBtoKG(double input)
        {
            Console.Clear();
            double KGTotal = input / 2.20462;
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(KGTotal, 2)) + " KG");
            Console.WriteLine("=================");
        }

        public static void StonetoKg(double input)
        {
            Console.Clear();
            double Stone = (input * 6.35029);
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(Stone, 2)) + " Kg");
            Console.WriteLine("=================");
        }

        public static void KgtoStone(double input)
        {
            Console.Clear();
            double Stone = (input / 6.35029);
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(Stone, 2)) + " Stone");
            Console.WriteLine("=================");
        }

        public static void MeterToFeet(double input)
        {
            Console.Clear();
            double FeetTotal = input * 3.28084;
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(FeetTotal, 2)) + " Feet");
            Console.WriteLine("=================");
        }

        public static void FeetToMeter(double input)
        {
            Console.Clear();
            double MeterTotal = input / 3.28084;
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(MeterTotal, 2)) + " Metros");
            Console.WriteLine("=================");
        }

        public static void MMToFeet(double input)
        {
            Console.Clear();
            double MM = input / 304.8;
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(MM, 2)) + " Feet");
            Console.WriteLine("=================");
        }

        public static void FeetToMM(double input)
        {
            Console.Clear();
            double MM = input * 304.8;
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(MM, 2)) + " MM");
            Console.WriteLine("=================");
        }

        public static void SquareMetersToSquareFeet(double input)
        {
            Console.Clear();
            double SquareFeetTotal = input * 10.76391041671;
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(SquareFeetTotal, 2)) + " Pies cuadrados");
            Console.WriteLine("=================");
        }

        public static void SquareFeetToSquareMeter(double input)
        {
            Console.Clear();
            double SquareMeterTotal = input / 10.76391041671;
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(SquareMeterTotal, 2)) + " Metros cuadrados");
            Console.WriteLine("=================");
        }

        public static void SquareMMToSquareFeet(double input)
        {
            Console.Clear();
            double SquareMMTotal = input / 93078.24;
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(SquareMMTotal, 2)) + " Pies cuadrados");
            Console.WriteLine("=================");
        }

        public static void SquareFeetToSquareMM(double input)
        {
            Console.Clear();
            double SquareFeetTotal = input * 93078.24;
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(SquareFeetTotal, 2)) + " MM cuadrados");
            Console.WriteLine("=================");
        }

        public static void CtoF(double input)
        {
            Console.Clear();
            double C = input * (9 / 5) + 32;
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(C, 2)) + " Fahrenheit");
            Console.WriteLine("=================");
        }

        public static void FtoC(double input)
        {
            Console.Clear();
            double F = (input - 32) * (5 / 9);
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(F, 2)) + " Celsius");
            Console.WriteLine("=================");
        }

        public static void FtoK(double input)
        {
            Console.Clear();
            double F = ((input - 32) / 1.8) + 273.15;
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(F, 2)) + " Kelvin");
            Console.WriteLine("=================");
        }

        public static void KtoF(double input)
        {
            Console.Clear();
            double K = ((input - 273.15) * 1.8) + 32;
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(K, 2)) + " Fahrenheit");
            Console.WriteLine("=================");
        }

        public static void SpeedKmToMPH(double input)
        {
            Console.Clear();
            double Km = (input * 0.621371);
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(Km, 2)) + " MPH");
            Console.WriteLine("=================");
        }

        public static void SpeedMPHToKm(double input)
        {
            Console.Clear();
            double Km = (input / 0.621371);
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(Km, 2)) + " KM/H");
            Console.WriteLine("=================");
        }

        public static void SpeedFootToMM(double input)
        {
            Console.Clear();
            double Foot = (input * 304.8 / 60);
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(Foot, 2)) + " MM/Minuto");
            Console.WriteLine("=================");
        }

        public static void SpeedMMToFoot(double input)
        {
            Console.Clear();
            double mm = (input * 5.08);
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(mm, 2)) + " Pie/Hora");
            Console.WriteLine("=================");
        }
    }
}
