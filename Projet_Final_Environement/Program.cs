using Microsoft.VisualBasic;
using Projet_Final_Environement.src;

class Program
{
    static void Main()
    {
        bool quit = false;
        do
        {
            ConsoleInteractions.ChooseLanguage(out quit);
        }
        while (!quit);
    }
}
