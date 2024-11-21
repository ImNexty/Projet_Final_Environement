using Microsoft.VisualBasic;
using Projet_Final_Environement.src;

class Program
{
    static void Main()
    {
        string input1 = "";
        string input2 = "";
        do
        {
            Console.WriteLine("1-Convert");
            Console.WriteLine("2-Exit");
            input1 = Console.ReadLine();

            inputChecks.Quit(input1);

            if (inputChecks.IsInt(input1))
            {
                while (!inputChecks.OneOrTwo(input2))
                {
                    Console.WriteLine("1- KG to LB");
                    Console.WriteLine("2- LB to KG");
                    input2 = Console.ReadLine();
                }
                if (input2 == "1")
                {
                    Console.WriteLine("Enter weight in KG");
                }
                else
                {
                    Console.WriteLine("Enter weight in LB");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
        while (!inputChecks.Quit(input1));
    }
}
