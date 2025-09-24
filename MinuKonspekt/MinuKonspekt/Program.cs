using System.Globalization;

namespace MinuKonspekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");


            // Muutujad, Matematilised tehted, if, else-if, else:

            // tuvasta sisu võrdluses tühja stringiga, string andmetüüp
            Console.WriteLine("Tere kasutaja, mis on sinu nimi?");
            string nimi = Console.ReadLine();

            if (nimi == "")
            {
                Console.WriteLine("Kasutaja ei sisestanud oma nime.");
            } 
            else if (nimi != null)
            {
                Console.WriteLine($"Tere, {nimi}!");
            }
            else
            {
                Console.WriteLine("Kasutaja ei sisestanud oma nime.");
            }


            //2. tuvastav arvuvahemik, võrdluses piirväärtustega, int/double/float andmetüüp
            Console.WriteLine($"{nimi}, mis on sinu vanus? ");
            int kasutajaVanus = int.Parse(Console.ReadLine());

            // 2.1 mitu tingimust pesastatud if-ide abil
            /*if (kasutajaVanus > 0)
            {
                if (kasutajaVanus < 18)
                {
                    Console.WriteLine("Kahjuks energijajooki sulle ei müüda, oled Monsterist ilma = (");
                }
                else 
                { 
                    Console.WriteLine("Saab osta monsterit, nice"); 
                }
            */


            // 2.2 mitu tingimust pesastatud swtich-ide abil
            switch (kasutajaVanus)
            {
                default:
                    Console.WriteLine("Kahjuks energijajooki sulle ei müüda, oled Monsterist ilma = (");
                    break;
                case > 0 and > 18:
                    Console.WriteLine("Saab osta monsterit, nice");
                    break;
            }


        }
    }
}
