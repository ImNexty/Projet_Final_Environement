using Microsoft.VisualBasic;
using Projet_Final_Environement.src;

class Program
{
    static void Main()
    {
        bool quit = false;
        do
        {
            ConsoleInteractions.ConvertOrQuit(out quit);
            if (!quit)
            {
                ConsoleInteractions.ChooseConversion(out quit);
            }
        }
        while (!quit);
    }
}
