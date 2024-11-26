using Microsoft.VisualBasic;
using Projet_Final_Environement.src;

class Program
{
    static void Main()
    {
        bool quit = false;
        do
        {
            string input = "";
            do
            {
                Console.WriteLine("1-Convert");
                Console.WriteLine("2-Quit");
                input = Console.ReadLine();
                

            }while (!inputChecks.OneOrTwo(input));

            if (inputChecks.Quit(input))
            {
                break;
            }

            input = "";

            do
            {
                Console.WriteLine("1-KG to LB");
                Console.WriteLine("2-LB to KG");
                input = Console.ReadLine();

            } while (!inputChecks.OneOrTwo(input));

            if(input == "1")
            {
                do
                {
                    Console.WriteLine("Enter weight to convert");
                    input = Console.ReadLine();

                } while (!inputChecks.IsInt(input));

                Conversions.KGtoLB(Convert.ToDouble(input));
            }
            else
            {
                do
                {
                    Console.WriteLine("Enter weight to convert");
                    input = Console.ReadLine();

                } while (!inputChecks.IsInt(input));

                Conversions.LBtoKG(Convert.ToDouble(input));
            }
            
        }
        while (!quit);
    }
}
