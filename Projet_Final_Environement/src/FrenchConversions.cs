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
                Console.WriteLine("1-KG en LB");
                Console.WriteLine("2-LB en KG");
                Console.WriteLine("3-Pierre en KG");
                Console.WriteLine("4-KG en Pierre");
                Console.WriteLine("5-Changer le type de conversion");
                Console.WriteLine("6-Changer de langue");
                Console.WriteLine("7-Quitter");
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
                            Console.WriteLine("Entrez le poids en Kg à convertir ou tapez 'BACK' pour revenir à la sélection");
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                Console.WriteLine("1-Mètres en pieds");
                Console.WriteLine("2-Pieds en mètres");
                Console.WriteLine("3-MM en pieds");
                Console.WriteLine("4-Pieds en MM");
                Console.WriteLine("5-Changer le type de conversion");
                Console.WriteLine("6-Quitter");
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
                            Console.WriteLine("Entrez la distance en mètres à convertir ou tapez 'BACK' pour revenir à la sélection");
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                Console.WriteLine("1-Mètres carrés en pieds carrés");
                Console.WriteLine("2-Pieds carrés en mètres carrés");
                Console.WriteLine("3-MM² en pieds carrés");
                Console.WriteLine("4-Pieds carrés en MM²");
                Console.WriteLine("5-Changer le type de conversion");
                Console.WriteLine("6-Quitter");
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
                            Console.WriteLine("Entrez la surface en mètres carrés à convertir ou tapez 'BACK' pour revenir à la sélection");
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                Console.WriteLine("1-Cellule en Fahrenheit");
                Console.WriteLine("2-Fahrenheit en Cellule");
                Console.WriteLine("3-Fahrenheit en Kelvin");
                Console.WriteLine("4-Kelvin en Fahrenheit");
                Console.WriteLine("5-Changer le type de conversion");
                Console.WriteLine("6-Quitter");
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
                            Console.WriteLine("Entrez la température en Celsius à convertir ou tapez 'BACK' pour revenir à la sélection");
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                Console.WriteLine("1-KM/H en MPH");
                Console.WriteLine("2-MPH en KM/H");
                Console.WriteLine("3-FOOT/H en MM/MIN");
                Console.WriteLine("4-MM/MIN en FOOT/H");
                Console.WriteLine("5-Changer le type de conversion");
                Console.WriteLine("6-Quitter");
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
                            Console.WriteLine("Entrez la vitesse en KM/H à convertir ou tapez 'BACK' pour revenir à la sélection");
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
                            inputConvertion = Console.ReadLine().ToUpper();
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
            Console.WriteLine((Math.Round(FeetTotal, 2)) + " Pieds");
        }
        public static void FeetToMeter(double input)
        {
            double MeterTotal = input / 3.28084;
            Console.WriteLine((Math.Round(MeterTotal, 2)) + " Mètres");
        }
        public static void MMToFeet(double input)
        {
            double MM = input / 304.8;
            Console.WriteLine((Math.Round(MM, 2)) + " Pieds");
        }
        public static void FeetToMM(double input)
        {
            double MM = input * 304.8;
            Console.WriteLine((Math.Round(MM, 2)) + " MM");
        }

        public static void SquareMetersToSquareFeet(double input)
        {
            double SquareFeetTotal = input * 10.76391041671;
            Console.WriteLine((Math.Round(SquareFeetTotal, 2)) + " Pieds carrés");
        }
        public static void SquareFeetToSquareMeter(double input)
        {
            double SquareMeterTotal = input / 10.76391041671;
            Console.WriteLine((Math.Round(SquareMeterTotal, 2)) + " Mètres carrés");
        }
        public static void SquareMMToSquareFeet(double input)
        {
            double SquareMMTotal = input / 93078.24;
            Console.WriteLine((Math.Round(SquareMMTotal, 2)) + " Pieds carrés");
        }
        public static void SquareFeetToSquareMM(double input)
        {
            double SquareFeetTotal = input * 93078.24;
            Console.WriteLine((Math.Round(SquareFeetTotal, 2)) + " MM carrés");
        }

        public static void CtoF(double input)
        {
            double C = input * (9 / 5) + 32;
            Console.WriteLine((Math.Round(C, 2)) + " Fahrenheit");
        }
        public static void FtoC(double input)
        {
            double F = (input - 32) * (5 / 9);
            Console.WriteLine((Math.Round(F, 2)) + " Celsius");
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
            Console.WriteLine((Math.Round(mm, 2)) + " Pieds/H");
        }
    }
}
