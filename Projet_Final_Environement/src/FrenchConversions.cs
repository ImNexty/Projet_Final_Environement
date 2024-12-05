using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_Environement.src
{
    internal class FrenchConversions
    {
        public static bool ConversionWeight(out bool quit)
        {
            string input = "";
            quit = false;
            do
            {
                Console.WriteLine("Conversion de poids");
                Console.WriteLine("=================");
                Console.WriteLine("1-KG en LB");
                Console.WriteLine("2-LB en KG");
                Console.WriteLine("3-Pierre en KG");
                Console.WriteLine("4-KG en Pierre");
                Console.WriteLine("5-Changer le type de conversion");
                Console.WriteLine("6-Changer de langue");
                Console.WriteLine("=================");
                Console.WriteLine("7-Quitter");
                Console.WriteLine("=================");
                Console.Write("Entrer votre choix:");
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
                            Console.WriteLine("Entrez le poids en Kg à convertir ou tapez 'BACK' pour revenir à la sélection");
                            Console.Write("Entrer votre choix:");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.French(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            FrenchConversions.KGtoLB(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "2":
                        do
                        {
                            Console.WriteLine("Entrez le poids en Lbs à convertir ou tapez 'BACK' pour revenir à la sélection");
                            Console.Write("Entrer votre choix:");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.French(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            FrenchConversions.LBtoKG(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "3":
                        do
                        {
                            Console.WriteLine("Entrez le poids en Stone à convertir ou tapez 'BACK' pour revenir à la sélection");
                            Console.Write("Entrer votre choix:");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.French(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            FrenchConversions.StonetoKg(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "4":
                        do
                        {
                            Console.WriteLine("Entrez le poids en Kg à convertir ou tapez 'BACK' pour revenir à la sélection");
                            Console.Write("Entrer votre choix:");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.French(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            FrenchConversions.KgtoStone(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "5":
                        Console.WriteLine("Changer le type de conversion");
                        Languages.French(out quit);
                        break;
                    case "6":
                        Console.WriteLine("Changer de langue");
                        ConsoleInteractions.ChooseLanguage(out quit);
                        break;

                    case "7":
                        Console.WriteLine("Quitter");
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
                Console.WriteLine("Conversion de distance");
                Console.WriteLine("=================");
                Console.WriteLine("1-Mètres en pieds");
                Console.WriteLine("2-Pieds en mètres");
                Console.WriteLine("3-MM en pieds");
                Console.WriteLine("4-Pieds en MM");
                Console.WriteLine("5-Changer le type de conversion");
                Console.WriteLine("=================");
                Console.WriteLine("6-Quitter");
                Console.WriteLine("=================");
                Console.Write("Entrer votre choix:");
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
                            Console.WriteLine("Entrez la distance en mètres à convertir ou tapez 'BACK' pour revenir à la sélection");
                            Console.Write("Entrer votre choix:");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.French(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            FrenchConversions.MeterToFeet(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "2":
                        do
                        {
                            Console.WriteLine("Entrez la distance en pieds à convertir ou tapez 'BACK' pour revenir à la sélection");
                            Console.Write("Entrer votre choix:");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.French(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            FrenchConversions.FeetToMeter(Convert.ToDouble(inputConvertion));
                        }
                        break;
                    case "3":
                        do
                        {
                            Console.WriteLine("Entrez la distance en MM à convertir ou tapez 'BACK' pour revenir à la sélection");
                            Console.Write("Entrer votre choix:");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.French(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            FrenchConversions.MMToFeet(Convert.ToDouble(inputConvertion));
                        }
                        break;
                    case "4":
                        do
                        {
                            Console.WriteLine("Entrez la distance en pieds à convertir ou tapez 'BACK' pour revenir à la sélection");
                            Console.Write("Entrer votre choix:");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.French(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            FrenchConversions.FeetToMM(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "5":
                        Console.WriteLine("Changer le type de conversion");
                        Languages.French(out quit);
                        break;

                    case "6":
                        Console.WriteLine("Quitter");
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
                Console.WriteLine("Conversion de surface");
                Console.WriteLine("=================");
                Console.WriteLine("1-Mètres carrés en pieds carrés");
                Console.WriteLine("2-Pieds carrés en mètres carrés");
                Console.WriteLine("3-MM² en pieds carrés");
                Console.WriteLine("4-Pieds carrés en MM²");
                Console.WriteLine("5-Changer le type de conversion");
                Console.WriteLine("=================");
                Console.WriteLine("6-Quitter");
                Console.WriteLine("=================");
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
                            Console.WriteLine("Entrez la surface en mètres carrés à convertir ou tapez 'BACK' pour revenir à la sélection");
                            Console.Write("Entrer votre choix:");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.French(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            FrenchConversions.SquareMetersToSquareFeet(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "2":
                        do
                        {
                            Console.WriteLine("Entrez la surface en pieds carrés à convertir ou tapez 'BACK' pour revenir à la sélection");
                            Console.Write("Entrer votre choix:");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.French(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            FrenchConversions.SquareFeetToSquareMeter(Convert.ToDouble(inputConvertion));
                        }
                        break;
                    case "3":
                        do
                        {
                            Console.WriteLine("Entrez la surface en MM² à convertir ou tapez 'BACK' pour revenir à la sélection");
                            Console.Write("Entrer votre choix:");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.French(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            FrenchConversions.SquareMMToSquareFeet(Convert.ToDouble(inputConvertion));
                        }
                        break;
                    case "4":
                        do
                        {
                            Console.WriteLine("Entrez la surface en pieds carrés à convertir ou tapez 'BACK' pour revenir à la sélection");
                            Console.Write("Entrer votre choix:");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.French(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            FrenchConversions.SquareFeetToSquareMM(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "5":
                        Console.WriteLine("Changer le type de conversion");
                        Languages.French(out quit);
                        break;

                    case "6":
                        Console.WriteLine("Quitter");
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
                Console.WriteLine("Conversion de temperature");
                Console.WriteLine("=================");
                Console.WriteLine("1-Cellule en Fahrenheit");
                Console.WriteLine("2-Fahrenheit en Cellule");
                Console.WriteLine("3-Fahrenheit en Kelvin");
                Console.WriteLine("4-Kelvin en Fahrenheit");
                Console.WriteLine("5-Changer le type de conversion");
                Console.WriteLine("=================");
                Console.WriteLine("6-Quitter");
                Console.WriteLine("=================");
                Console.Write("Entrer votre choix:");
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
                            Console.WriteLine("Entrez la température en Celsius à convertir ou tapez 'BACK' pour revenir à la sélection");
                            Console.Write("Entrer votre choix:");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.French(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            FrenchConversions.CtoF(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "2":
                        do
                        {
                            Console.WriteLine("Entrez la température en Fahrenheit à convertir ou tapez 'BACK' pour revenir à la sélection");
                            Console.Write("Entrer votre choix:");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.French(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            FrenchConversions.FtoC(Convert.ToDouble(inputConvertion));
                        }
                        break;
                    case "3":
                        do
                        {
                            Console.WriteLine("Entrez la température en Fahrenheit à convertir ou tapez 'BACK' pour revenir à la sélection");
                            Console.Write("Entrer votre choix:");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.French(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            FrenchConversions.FtoK(Convert.ToDouble(inputConvertion));
                        }
                        break;
                    case "4":
                        do
                        {
                            Console.WriteLine("Entrez la température en Kelvin à convertir ou tapez 'BACK' pour revenir à la sélection");
                            Console.Write("Entrer votre choix:");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.French(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            FrenchConversions.KtoF(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "5":
                        Console.WriteLine("Changer le type de conversion");
                        Languages.French(out quit);
                        break;

                    case "6":
                        Console.WriteLine("Quitter");
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
                Console.WriteLine("Conversion de vitesse");
                Console.WriteLine("=================");
                Console.WriteLine("1-KM/H en MPH");
                Console.WriteLine("2-MPH en KM/H");
                Console.WriteLine("3-FOOT/H en MM/MIN");
                Console.WriteLine("4-MM/MIN en FOOT/H");
                Console.WriteLine("5-Changer le type de conversion");
                Console.WriteLine("=================");
                Console.WriteLine("6-Quitter");
                Console.WriteLine("=================");
                Console.Write("Entrer votre choix:");
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
                            Console.WriteLine("Entrez la vitesse en KM/H à convertir ou tapez 'BACK' pour revenir à la sélection");
                            Console.Write("Entrer votre choix:");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.French(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            FrenchConversions.SpeedKmToMPH(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "2":
                        do
                        {
                            Console.WriteLine("Entrez la vitesse en MPH à convertir ou tapez 'BACK' pour revenir à la sélection");
                            Console.Write("Entrer votre choix:");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.French(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            FrenchConversions.SpeedMPHToKm(Convert.ToDouble(inputConvertion));
                        }
                        break;
                    case "3":
                        do
                        {
                            Console.WriteLine("Entrez la vitesse en FOOT/H à convertir ou tapez 'BACK' pour revenir à la sélection");
                            Console.Write("Entrer votre choix:");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.French(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            FrenchConversions.SpeedFootToMM(Convert.ToDouble(inputConvertion));
                        }
                        break;
                    case "4":
                        do
                        {
                            Console.WriteLine("Entrez la vitesse en MM/MIN à convertir ou tapez 'BACK' pour revenir à la sélection");
                            Console.Write("Entrer votre choix:");
                            inputConvertion = Console.ReadLine().ToUpper();
                            Console.Clear();
                            if (inputConvertion.ToUpper() == "BACK")
                            {
                                Languages.French(out quit);
                                break;
                            }

                        } while (!inputChecks.IsInt(inputConvertion));

                        if (!quit)
                        {
                            FrenchConversions.SpeedMMToFoot(Convert.ToDouble(inputConvertion));
                        }
                        break;

                    case "5":
                        Console.WriteLine("Changer le type de conversion");
                        Languages.French(out quit);
                        break;

                    case "6":
                        Console.WriteLine("Quitter");
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
            Console.WriteLine((Math.Round(FeetTotal, 2)) + " Pieds");
            Console.WriteLine("=================");
        }
        public static void FeetToMeter(double input)
        {
            Console.Clear();
            double MeterTotal = input / 3.28084;
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(MeterTotal, 2)) + " Mètres");
            Console.WriteLine("=================");
        }
        public static void MMToFeet(double input)
        {
            Console.Clear();
            double MM = input / 304.8;
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(MM, 2)) + " Pieds");
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
            Console.WriteLine((Math.Round(SquareFeetTotal, 2)) + " Pieds carrés");
            Console.WriteLine("=================");
        }
        public static void SquareFeetToSquareMeter(double input)
        {
            Console.Clear();
            double SquareMeterTotal = input / 10.76391041671;
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(SquareMeterTotal, 2)) + " Mètres carrés");
            Console.WriteLine("=================");
        }
        public static void SquareMMToSquareFeet(double input)
        {
            Console.Clear();
            double SquareMMTotal = input / 93078.24;
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(SquareMMTotal, 2)) + " Pieds carrés");
            Console.WriteLine("=================");
        }
        public static void SquareFeetToSquareMM(double input)
        {
            Console.Clear();
            double SquareFeetTotal = input * 93078.24;
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(SquareFeetTotal, 2)) + " MM carrés");
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
            Console.WriteLine((Math.Round(Foot, 2)) + " MM/Min");
            Console.WriteLine("=================");
        }
        public static void SpeedMMToFoot(double input)
        {
            Console.Clear();
            double mm = (input * 5.08);
            Console.WriteLine("=================");
            Console.WriteLine((Math.Round(mm, 2)) + " Pieds/H");
            Console.WriteLine("=================");
        }
    }
}
