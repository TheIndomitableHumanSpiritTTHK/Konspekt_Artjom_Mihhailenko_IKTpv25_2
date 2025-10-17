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


            //5 värvituvastus

            Console.WriteLine("Milline värv sulle kõige rohkem meeldib?: ");
            string favoriteColor = Console.ReadLine();
            switch (favoriteColor)
            {
                default:
                    Console.WriteLine("Värvi ei tunne");
                    break;
                case "punane":
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case "oranz":
                    Console.WriteLine("Kahjuks oranzi ei ole");
                    break;
                case "kollane":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case "roheline":
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
            }
            Console.WriteLine("Värv muudetud!");


            //# Kolija kalkulaator - Kirjuta programm mis:
            //#    - Küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.
            //#    - olenevalt kasutaja sisestusest küsib ta:
            //#    - - tünni jaoks:
            //#    - - - kas kasutaja teab põhja raadiust (r) või põhja läbimõõtu (d):
            //#    - - - tünni kõrgust
            //#    - - - kaane paksust (kaane paksus võtab tünni kõrgusest maha, kuna kaan võtab tünni sisust natuke ruumi)
            //#    - - - Arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
            //#    - - kasti jaoks:
            //#    - - - Kas kast on kuubiku kujuline või risttahuka kujuline
            //#    - - - - kui on kuubik, siis küsib kasutajalt ainult küljepikkust
            //#    - - - - kui on risttahukas siis küsib kasutajalt:
            //#    - - - - - pikima külje pikkust, 
            //#    - - - - - lühima külje pikkust ja
            //#    - - - - - kasti kõrgust
            //#    - - arvutab vastavalt kasti kogupindala, mahu, ja pikima läbiva joone (d)

            Console.WriteLine("Kas te tahate ära mõõta pappkasti või õlitunni?");
            string valik1 = Console.ReadLine();
            
            if (valik1 == "pappkast")
            {
                Console.WriteLine("Kas kast on kuubiku kujuline või risttahuka kujuline?");
                string kasttüüp = Console.ReadLine();

                if (kasttüüp == "kuubik")
                {
                    Console.WriteLine("Mis on kasti küljepikk?");
                    int kastiküljepikk = int.Parse(Console.ReadLine());

                    int V = kastiküljepikk * kastiküljepikk * kastiküljepikk; // объем
                    int S = (kastiküljepikk * kastiküljepikk) * 6;

                } else if (kasttüüp == "risttahukas")
                {
                    Console.WriteLine("Mis on pikim küljepikkus?");
                    int pikimküljepikkus = int.Parse(Console.ReadLine()); // a
                    
                    Console.WriteLine("Mis on lühim küljepikkus?");
                    int lühimküljepikkus = int.Parse(Console.ReadLine());  // b ?

                    Console.WriteLine("Mis on kasti kõrgus?");
                    int kastikõrgus = int.Parse(Console.ReadLine());  // h

                    int S_risttahukas = 2 * ((pikimküljepikkus * lühimküljepikkus) + (pikimküljepikkus * kastikõrgus) + (lühimküljepikkus * kastikõrgus));
                    int V_risttahukas = pikimküljepikkus * lühimküljepikkus * kastikõrgus;
                }
            }
            else if (valik1 == "tünn")
            {
                Console.WriteLine("Kas sa tead tünni raadiust R või läbimõõtu D");
                string rvõid = Console.ReadLine();

                Console.WriteLine("Mis on selle raadius või läbimõõt? metrites");
                double kasutajamõõt = double.Parse(Console.ReadLine());


                Console.WriteLine("Kui kõrge on sinu tünn? meetrites");
                double kõrgus = double.Parse(Console.ReadLine());
                
                
                Console.WriteLine("Kui paks on sinu tünn? meetrites");
                double kaanepaksus = double.Parse(Console.ReadLine());

                double Sp = 0;
                switch (rvõid)
                {
                    default:
                        break;
                    case "R":
                        Sp = Math.PI * (kasutajamõõt * kasutajamõõt);
                        break;
                    case "D":
                        kasutajamõõt = kasutajamõõt / 2;
                        Sp = Math.PI * (kasutajamõõt * kasutajamõõt);
                        break;
                }

                double V = 0;
                kõrgus = kõrgus - kaanepaksus;
                V = Sp * kõrgus;

                // arvutame küljepindala
                kõrgus += kaanepaksus;
                double Sk = 2 * Math.PI * kasutajamõõt * kõrgus;

                double S = Sp + Sk;
                Console.WriteLine($"Sinu tünn mahutab {V}\nTünni küljepindala on {Sk}\nTünni kogupindala on {S}");
            }

            int muutuja = 3;
            // int          -> on muutuja nime ees olev andmetüübi kirjeldus, mis näitab ära, millist 
            //                 tüüpi andmed sell muutuja sees on
            // "muutuja"    -> on nimetus, ehk muutuja, mis hoiab endas mingeid andmed, inimloetava
            //                 ja mil abil saab neid addresseerida koodi sees
            // =            -> üksis võrdusmärk omistab muutuja sisse vastava väärtuse mis asub teiselpool võrdusmärki
            // 3            -> muutujale omistatav väärtus
            /* Võimalikud adnmetüübid mida vaja võib minna: */
            int a = 1; // int on täisarv
            decimal b = 2.1M; // decimal on kümnendsüsteemis olev komakohaga arv
            float c = 3.9f; // float on 32-bitine komakohaga arv
            double d = 5.6d; // double on 64-bitine komakohaga arv
            char c1 = 'a'; // üksainus täht või tähemark mis tähistatakse ülakomadega ''
            string s = "tekst"; // tähtedest koosnev sõna või teks, tähistatakse jutumärkidega **

            var x = "abc"; // var on ebamääruse andmetüübiga kohalik muutuja
            var y = 123;  // ta võib omaga endas teisi andmetüüpe
            const int z = 9; // konstant tüüpi muutujaid ei saa muuta, nende sisu on read only

            int liitmine = 1 + 1; // liitmine, kaks arvu liidetakse kokku
            int lahutamine = 1 - 1; // lahutamine, kus esimesest arvust lahutatakse maha teine
            double korrutamine = 1*2; // korrutamine, kus teine arv korrutatakse esimese arvu kordi
            double jagamine = 1 / 2; // jagamine, esimene arv jagatakse teise arvuga
            double astendamine = Math.Pow(2, 2); //astendamine
            double juurimine = Math.Sqrt(2);  // ruutjuur, parametrina juritav arv

            // muutuja nimed
            int arv = 0;
            string sõna = "abc";
            // string string = "abc"; // kaitstud sõna kasutada ei saa

            // muutuja nimeks ei sobi järgnevad sõnad
            // abstract, as, base, bool, break, byte, case,
            // catch, char, checked, class, count, continue, decimal,
            // default, delegate, do, double, else, enum, event,
            // explicit, extern, false, finally, fixed, float, for
            // foreach, goto, if, implicit, in, int, interface, internal
            // is, lock, long, namespace, new, null, object, operator
            // out, override, params, private, protected, public, readonly,
            // ref, return, sbyte, sealed, short, sizeof, stackalloc
            // static, string, struct, switch, this, throw, try, typeof
            // uint, ulong, unchecked, ushort, using, virtual
            // void, volatile, while.


            Console.WriteLine("Tere. Sisestage esimene number");
            // Addresseerime moodulit "Console", punkti abil ütleme, et kasutame funktsiooni WriteLine
            // selle jaoks et öelda kasutajale sõnum, mis asub funktsiooni nime järel sulgude vahel
            // ümbritsetuna jutumärkidega

            int arv1_ = int.Parse(Console.ReadLine());
            // instantsieerime muutuja nimega "arv1", ning selle ette anname andmetüübiks "int", see
            // ütleb ära, et siin muutujas on täisarvud sees. Omistame muutujale võrdusmärgi abil
            // väärtuse, mille saame kasutajalt. Selle jaoks, addresseerime uuesti "Console" moodulit
            // Aga seekord on funktsiooni nimi "ReadLine". Selleks, et käsureapealt tulev arv programmile
            // tekstina ei näe välja, küsime int mooduli seest omakorda funktsiooni "Parse", ning paneme
            // ReadLine funktsiooni Parse() sulgude vahele



            Console.WriteLine("Nüüd sisestage teine number");
            // Addresseerime moodulit "Console", punkti abil ütleme, et kasutame funktsiooni WriteLine
            // selle jaoks et öelda kasutajale sõnum, mis asub funktsiooni nime järel sulgude vahel
            // ümbritsetuna jutumärkidega

            int arv2_ = int.Parse(Console.ReadLine());
            // instantsieerime muutuja nimega "arv1", ning selle ette anname andmetüübiks "int", see
            // ütleb ära, et siin muutujas on täisarvud sees. Omistame muutujale võrdusmärgi abil
            // väärtuse, mille saame kasutajalt. Selle jaoks, addresseerime uuesti "Console" moodulit
            // Aga seekord on funktsiooni nimi "ReadLine". Selleks, et käsureapealt tulev arv programmile
            // tekstina ei näe välja, küsime int mooduli seest omakorda funktsiooni "Parse", ning paneme
            // ReadLine funktsiooni Parse() sulgude vahele


            Console.WriteLine("Noh aga mis me teeme?");
            // Addresseerime moodulit "Console", koos "WriteLine" funktsiooniga, et esitada kasutajale küsimuse
            // "Noh aga mis me teeme?". Punkti abil saame moodulist Console, funktsiooni
            // WriteLine, ning sulgude vahel ongi kasutajale esitatav tekst. Tekst ise on ka ümbritsetud
            // jutumärkidega. Lause lõpeb lauselõpumärgiga ";".

            Console.WriteLine("1. liitmine (+)");
            // Addresseerime moodulit "Console", koos "WriteLine" funktsiooniga, et esitada kasutajale küsimuse
            // "1. liitmine (+)". Punkti abil saame moodulist Console, funktsiooni
            // WriteLine, ning sulgude vahel ongi kasutajale esitatav tekst. Tekst ise on ka ümbritsetud
            // jutumärkidega. Lause lõpeb lauselõpumärgiga ";".

            Console.WriteLine("2. jagamine (/)");
            // Addresseerime moodulit "Console", koos "WriteLine" funktsiooniga, et esitada kasutajale küsimuse
            // "2. jagamine (/)". Punkti abil saame moodulist Console, funktsiooni
            // WriteLine, ning sulgude vahel ongi kasutajale esitatav tekst. Tekst ise on ka ümbritsetud
            // jutumärkidega. Lause lõpeb lauselõpumärgiga ";".

            Console.WriteLine("3. korrutamine (*)");
            // Addresseerime moodulit "Console", koos "WriteLine" funktsiooniga, et esitada kasutajale küsimuse
            // "3. korrutamine (*)". Punkti abil saame moodulist Console, funktsiooni
            // WriteLine, ning sulgude vahel ongi kasutajale esitatav tekst. Tekst ise on ka ümbritsetud
            // jutumärkidega. Lause lõpeb lauselõpumärgiga ";".

            Console.WriteLine("4. lahutamine (-)");
            // Addresseerime moodulit "Console", koos "WriteLine" funktsiooniga, et esitada kasutajale küsimuse
            // "4. lahutamine (-)". Punkti abil saame moodulist Console, funktsiooni
            // WriteLine, ning sulgude vahel ongi kasutajale esitatav tekst. Tekst ise on ka ümbritsetud
            // jutumärkidega. Lause lõpeb lauselõpumärgiga ";".

            Console.WriteLine("5. Astendamine (^)");
            // Addresseerime moodulit "Console", koos "WriteLine" funktsiooniga, et esitada kasutajale küsimuse
            // "5. Astendamine (^)". Punkti abil saame moodulist Console, funktsiooni
            // WriteLine, ning sulgude vahel ongi kasutajale esitatav tekst. Tekst ise on ka ümbritsetud
            // jutumärkidega. Lause lõpeb lauselõpumärgiga ";".



            Console.WriteLine("Palun sisestage oma valik (1,2,3, 4 või 5): ");
            // Addresseerime moodulit "Console", koos "WriteLine" funktsiooniga, et esitada kasutajale küsimuse
            // ""Palun sisestage oma valik (1,2,3, 4 või 5): ". Punkti abil saame moodulist Console, funktsiooni
            // WriteLine, ning sulgude vahel ongi kasutajale esitatav tekst. Tekst ise on ka ümbritsetud
            // jutumärkidega. Lause lõpeb lauselõpumärgiga ";".

            int valik_ = int.Parse(Console.ReadLine());
            // instantsieerime muutuja nimega "arv1", mille ette anname andmetüübiks "int", see
            // ütleb ära, et siin muutujas on täisarvud sees. Omistame muutujale võrdusmärgi abil
            // väärtuse, mille saame kasutajalt. Selle jaoks, addresseerime uuesti "Console" moodulit
            // funktsiooni nimi "ReadLine". Selleks, et käsureapealt tulev arv programmile
            // tekstina ei näe välja, küsime int mooduli seest omakorda funktsiooni "Parse", ning paneme
            // ReadLine funktsiooni Parse() sulgude vahele

            double tulemus_ = 0;
            // instantsieerime muutuja nimega "tulemus", andmetüübiga int, ning omistame talle algse
            // väärtuse võrdusmärgi abil, milleks on 0. Lause lõpeb lauselõpumärgiga ";".


            // alustame tingimus lause switch, ning selle tingimuse määrame ära sulgudega, mille vahel
            // paneme "valik_" muutuja ja edasi vaatame, kas see muutuja vastab mingisugusele tingimusele, mis on koodiplookis {} sulgudes
            switch (valik_)
            {
                // määrasime toimingu juhuks, kui muutuja "valik_" ei vasta ühelegi meie tingimusele, selleks kasutame "default",
                // mille järel paneme kooloni, et näidata funktsiooni edasisi toiminguid.
                default:
                    throw new Exception("Vale valik. Proovige uuesti.");
                    // viskame erindi (Exception), mis ütleb, et valik oli vale ja kutsub kasutajat proovima uuesti
                    // seetõttu kasutame "throw" tingimus, kus instatsieerime uus Exception, ning sulgude vahel ongi kasutajale esitatav tekst. Tekst ise on ka ümbritsetud

                // määrame toimingu juhuks, kui muutuja "valik_" vastab ühele meie tingimusele ja on võrdne arvuga 1
                // Selleks kasutame "case", mille järel määrame väärtuse, millele "valik_ " peab vastama, et töötaks koodiplokk, mis kirjutatakse kooloni märgi järele
                case 1:
                    tulemus_ = arv1_ + arv2_;
                    break;
                    // kui valik on 1, liidame kaks arvu ning salvestame tulemuse muutujasse "tulemus_". 
                    // sellises lauses omistame muutujale "tulemus" võrdusmärgi abil liitmistehte tulemuse,
                    // kus liidame kokku muutuja "arv1_" ja muutuja "arv2_" sisu.

                    // selleks, et programmile õelda, et koolonile järgneva koodiploki
                    // tingimused on lõppenud, peame sellest väljuma, näiteks käsuga "break"


                // määrame toimingu juhuks, kui muutuja "valik_" vastab ühele meie tingimusele ja on võrdne arvuga 2
                // Selleks kasutame "case", mille järel määrame väärtuse, millele "valik_ " peab vastama, et töötaks koodiplokk, mis kirjutatakse kooloni märgi järele
                case 2:
                    tulemus_ = arv1_ / arv2_;
                    break;
                    // kui valik on 2, jagame kaks arvu ning salvestame tulemuse muutujasse "tulemus_". 
                    // sellises lauses omistame muutujale "tulemus" võrdusmärgi abil jagamistehte tulemuse,
                    // kus liidame kokku muutuja "arv1_" ja muutuja "arv2_" sisu.

                    // selleks, et programmile õelda, et koolonile järgneva koodiploki
                    // tingimused on lõppenud, peame sellest väljuma, näiteks käsuga "break"

                // määrame toimingu juhuks, kui muutuja "valik_" vastab ühele meie tingimusele ja on võrdne arvuga 3
                // Selleks kasutame "case", mille järel määrame väärtuse, millele "valik_ " peab vastama, et töötaks koodiplokk, mis kirjutatakse kooloni märgi järele
                case 3:
                    tulemus_ = arv1_ * arv2_;
                    break;
                // määrame toimingu juhuks, kui muutuja "valik_" vastab ühele meie tingimusele ja on võrdne arvuga 4
                // Selleks kasutame "case", mille järel määrame väärtuse, millele "valik_ " peab vastama, et töötaks koodiplokk, mis kirjutatakse kooloni märgi järele
                case 4:
                    tulemus_ = arv1_ - arv2_;
                    break;



                // määrame toimingu juhuks, kui muutuja "valik_" vastab ühele meie tingimusele ja on võrdne arvuga 5
                // Selleks kasutame "case", mille järel määrame väärtuse, millele "valik_ " peab vastama, et töötaks koodiplokk, mis kirjutatakse kooloni märgi järele
                case 5:
                    tulemus = Math.Pow(arv1, arv2);
                    break;
            }

            Console.WriteLine("Tulemus: " + tulemus);
            // Kasutame moodulist "Console" punkti abil funktsiooni "WriteLine" et kuvada kasutajale tehte tulemus.
            // Selle jaoks on WriteLine funktsioonis parameetrina pandud muutuja "tulemus" ilma tekstiks teisendamata
        }
    }
}
