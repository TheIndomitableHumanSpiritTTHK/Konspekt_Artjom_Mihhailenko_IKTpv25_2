namespace KontrollTöö_0110205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis on teie nimi?");
            string nimi = Console.ReadLine();

            Console.WriteLine("Mis aasta te sündisite?");
            int sünniaasta = int.Parse(Console.ReadLine());

            int vanus = DateTime.Now.Year - sünniaasta;
            if (vanus < 0)
            {
                Console.WriteLine("Te ei saa olla negatiivse vanasega.");
            } else
            {
                Console.WriteLine($"Tere, {nimi}! Te olete {vanus} aastat vana.");
            }


            Console.WriteLine("Mis on praegu temperatuur?");
            double temperatuur = double.Parse(Console.ReadLine());
            if (temperatuur < 0)
            {
                Console.WriteLine("põrgu jaatus");
            }
            else if (temperatuur >= 0 && temperatuur <= 10)
            {
                Console.WriteLine("päris külm on");
            }
            else if (temperatuur >= 11 && temperatuur <= 20)
            {
                Console.WriteLine("Normaalne ilm");
            }
            else if (temperatuur >= 21 && temperatuur <= 30)
            {
                Console.WriteLine("Kes läheb grillimiseks?");
            } 
            else if (temperatuur >= 31 && temperatuur <= 40)
            {
                Console.WriteLine("APPI, GLOBAALJE SOOJENEMINE");
            }

            Console.WriteLine("Kas te tahate vaarikat, maasikat või apelsini?");
            string valik = Console.ReadLine();
            if (valik == "vaarikat") {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.WriteLine("näe, vaarikas!");
            }
            else if (valik == "maasikat")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("maasikaski on!");
            } else if (valik == "apelsini")
            {
                Console.WriteLine("Apelsini mul kahjuks ei ole :С");
            }
        }
    }
}
