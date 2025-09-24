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


            //2.3 mitu vahemikku, switch abil, double/float
            Console.WriteLine($"Sisesta oma pikkus ka, palun, {nimi}: ");
            double pikkus = double.Parse(Console.ReadLine());

            switch (pikkus)
            {
                default:
                    Console.WriteLine("Pikkust ei tunta");
                    break;
                case < 1.00d:
                    Console.WriteLine("Oled juntsu");
                    break;
                case < 1.25d and > 1.00d:
                    Console.WriteLine("Oled peaaegu allameetrimees");
                    break;
                case < 1.50d and > 1.25d:
                    Console.WriteLine($"Päkapikk enam ei olegi {nimi}!");
                    break;
                case < 1.75d and > 1.50d:
                    Console.WriteLine("Oled enamasti standardpikkus, kui mitte just natuke lühike");
                    break;
                case < 2.00d and > 1.75d:
                    Console.WriteLine("Pikk kolge, vaata et sa pead vastu uksepiita ära ei löö");
                    break;
                case > 2.00d:
                    Console.WriteLine("Täielik tulnukas, kuidas pilved välja näevad?");
                    break;
            }

            // 3. kalkulaator switchidega
            Console.WriteLine("Tere. Sisestage esimene number");
            int arv1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nüüd sisestage teine number");
            int arv2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Noh aga mis me teeme?");
            Console.WriteLine("1. liitmine (+)");
            Console.WriteLine("2. jagamine (/)");
            Console.WriteLine("3. korrutamine (*)");
            Console.WriteLine("4. lahutamine (-)");
            Console.WriteLine("5. Astendamine (^)");

            Console.WriteLine("Palun sisestage oma valik (1,2,3, 4 või 5): ");
            int valik = int.Parse(Console.ReadLine());

            double tulemus = 0;

            if (valik == 1)
            {
                tulemus = arv1 + arv2;
            }
            else if (valik == 2)
            {
                tulemus = arv1 / arv2;
            }
            else if (valik == 3)
            {
                tulemus = arv1 * arv2;
            }
            else if (valik == 4)
            {
                tulemus = arv1 - arv2;
            }
            else if (valik == 5)
            {
                tulemus = Math.Pow(arv1, arv2);
            }
            else
            {
                throw new Exception("Vale valik. Proovige uuesti.");
            }



            Console.WriteLine("Tulemus: " + tulemus);



            // 4. parool

            Console.WriteLine("Programmi edasiseks tööks sisesta palun parool: ");
            string parool = Console.ReadLine();

            switch (parool)
            {
                default:
                    Console.WriteLine("Parool on vale, proovi uuesti");
                    break;
                case "secret":
                    Console.WriteLine("Parool on õige, aarete laegas avaneb");
                    break;
                case "qwerty" or "1234":
                    Console.WriteLine("Parool on sobimatu, palun mingi muu");
                    break;
            }      
        }
    }
}
