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

            /* Võimalikud komposiitandmetüübid */
            // 1. massiiv:
            // [] -> Massiiv on komposiitandmetüüp, mille sees saab olla mitmeid samat tüüpi lihtandmeid. Massiivi tähistatakse kantsulgudega.
            //       Massiive saab olla ükskõik millist lihtandmetüüpi massiive.
            //       Massiivi tekitamisel tuleb ära öelda kui pikk või kui suur see massiiv on
            //       Massiiv ei pea olema koostatud ainult lihtandmetüüpidest, vaid massiive saab olla ka tehtud teistest komposiitandmetüüpidest
            //       Sealhulgas massiiv ise.
            // Esimene tekitusviis: 
            int[] arvuMassiiv = new int[3]; // andmetüüp int väljendab et tegu on täisarvutüüpi andmega ja kantsulud väljendavad et ühtlasi on
                                            // tegu ka massiiviga. Muutuja nimeks on "arvuMassiiv" ja võrdusmärgi abil on omistatud muutujasse 
                                            // uus tühi massiiv kasuted kaitstud sõna "new", millele järgnev seda massiivi andmetüübi ja
                                            // pikkuse sätestus "int[3]". See tähendab et siin massiivis on kolm elementi mis on täisarvud.

            // Teine tekitusviis:
            int[] arvuMassiiv2 = [1,2,3];   // teine massiivi tekitus viis kus järjendi pikkuse sätestamise asemel, pannakse elemendi kohe 
                                            // järjendit omava muutuja sisse, järjendi pikkust sätestama ei pea, kuna pikkuse tuletab kompilaator
                                            // sinna sisse pandud elementide koguse järgi. 

            // -- massiivi sisemised meetodid:
            int hasThisMany = arvuMassiiv.Length; // massiivi meetod "Length" mille me saame kasutusele võtta punkti abil, loendab kokku 
                                                  // mitu element, adresseeritav massiiv omab, omistatakse ainult järjendi pikkus, mitte
                                                  // järjendi sees olevaid elemente.


            //2. Loend:
            // List<T> -> Loend on komposiitandmetüüp, mille sees saab olla mitmeid samat tüüpi liht ja komposiitandmeid. Loend-tüüpi andmeid tähistatakse
            //            täiendava andmetüübikirjeldusega "List" mille järel noolsulgudesse <> asetatakse mis tüüpi andmed seal loendis on.
            //            Loendi tekitamisel, erinevalt massiivist, ei pea ütlema kui pikk loend on. Loendisse saab dünaamiliselt elemente juurde lisada,
            //            ehk tema pikkus ei ole fikseeritud. Sarnaselt massiiviga saab temas hoida ka teisi loendeid.
            // Esimene tekitusviis:
            List<int> arvuNimekiri = new List<int>(); //Andmetüübi kirjeldus "List<>" näitab et tegu on loendiga. Listi noolsulgude <> vahel on loendis
                                                      //olevate andmete andmetüüp. Antud juhul on andmetüübiks "int" mis tähistab täisarve. Muutuja enda
                                                      //nimeks on "arvuNimekiri". Omistame sellesse muutujasse kaitstud sõna "new" abil uue tühja
                                                      //täisarvuloendi sätestusega "List<int>()".
                                                      // Teine tekitusviis:
            List<int> arvuNimekiri2 = new List<int>() { 1, 2, 3 }; //Teine loendi tekitusviis. Andmetüübi kirjeldus "List<>" näitab et tegu on loendiga, Listi
                                                                   //noolsulgude vahel on loendis olevate elementide andmetüüp. Antud juhul on andmetüübiks "int"
                                                                   //mis tähistab täisarve. Muutuja enda nimeks on "arvuNimekiri2". Omistame selle muutujasse 
                                                                   //kaitstud sõna "new" abil uue täisarvuloendi, aga seekord, peale sätestust "List<int>()" saame
                                                                   //instantsieerimise hetkel talle kaasa anda ka esimesi elemente. Antud juhul on need elemendid
                                                                   //"1", "2" ja "3". Elemendid sisestatakse nimekirja loogeliste sulgude vahel. Enam ei ole tegu
                                                                   //tühja nimekirjaga, vaid loendiga kus on kolm elementi juba sees.
                                                                   // kolmas tekitusviis:
            List<int> arvuNimekiri3 = new List<int>(3); //Kolmas loendi tekitusviis. Andmetüübi kirjeldus "List<>" näitab et tegu on loendiga, Listi noolsulgude
                                                        //vahel on loendis olevate elementide andmetüüp. Antud juhul on andmetüübiks "int" mis tähistab täisarve.
                                                        //Muutuja enda nimeks on "arvuNimekiri3". Omistame sellesse muutujasse kaitstud sõna "new" abil uue
                                                        //täisarvuloendi, aga tavaliste sulgude vahele paneme arvu "3". Sarnaselt massiiviga ütleb see, et
                                                        //loend on 3 elemendi suurune. Loend ise ja tema elemendid on tühjad, aga seal on 3 elementi. Arv "3"
                                                        //on parameeter mida Listi konstruktor pikkuse määramiseks kasutab. Nimekiri säilitab oma omaduse muuta
                                                        //pikkust elementide lisamise-eemaldamisega, aga vajadusel saab nii anda talle pikkuse.
            int aa = 9001;
            // -- Loendi sisemised meetodid:
            arvuNimekiri.Add(99); //Loendi meetod "Add()" lisab enne punkti olevale järjendile uue elemendi, element mida lisatakse on Add meetodi sulgude
                                  //vahel. Elementi sasab lisada otse (antud juhul täisarv "99")
            arvuNimekiri.Add(aa); //või muutujana.
            int loendiPikkus = arvuNimekiri3.Count(); //Loendi meetod "Count()" loeb kokku mitu elementi järjendis on, meetod tagastab täisarvu mis vastab
                                                      //elementide kogusele.
            bool KasSeeArvOn = arvuNimekiri3.Contains(3); //Loendi meetod "Contains()" otsib kogu järjendi seest elementi, mis vastab sulgude vahel olevale
                                                          //parameetrile. Meetod tagastab kas "true" või "false" - on leitud või ei ole. Tegemist on
                                                          //põhimõtteliselt foreach tsükliga, mis otsib kindlat vastet, töötades läbi kogu loendi.
            arvuNimekiri3.Remove(4); //Loendi meetod "Remove()"eemaldab enne punkti olevast loendist, kindlal asukohal oleva elemendi. Sulgude vahel on parameetriks
                                     //eemaldatava elemendi asukohajärjekorranumber.


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

            Console.WriteLine("Sisesta ostusumma");
            double ostusumma = double.Parse(Console.ReadLine());
            switch (ostusumma)
            {
                default:
                    Console.WriteLine("Sisestatud on vigane arv");
                    break;
                case > 100:
                    Console.WriteLine("Saad 20% allahindlust!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    break;
                case < 101 and > 50:
                    Console.WriteLine("Saad 10% allahindlust.");
                    break;
                case < 51 and > 20:
                    Console.WriteLine("5% allahidlust.");
                    break;
                case < 21 and > 0:
                    Console.WriteLine("allahindlust ei saa");
                    break;
            }


            //string kasutajaNimi = "";
            //do
            //{
            //    Console.WriteLine("Palun sisesta oma kasutajanimi: ");
            //    kasutajaNimi = Console.ReadLine();
            //} while (kasutajaNimi != "user1");

            //if (kasutajaNimi == "user1")
            //{
            //    int ruuduSuurus = 0;

            //    do
            //    {
            //        Console.WriteLine("Kui suurt ruutu saada tahad?");
            //        ruuduSuurus = int.Parse(Console.ReadLine());
            //    } while (ruuduSuurus < 0 || ruuduSuurus > 20);

            //    char reaKujund = 'Æ';
            //    string üksRida = "";

            //    int tsükliMuutuja = ruuduSuurus;

            //    do
            //    {
            //        üksRida = üksRida + "_" + reaKujund;
            //        tsükliMuutuja = tsükliMuutuja - 1;
            //    } while (tsükliMuutuja != 0);

            //    tsükliMuutuja = ruuduSuurus;

            //    do
            //    {
            //        Console.WriteLine(üksRida);
            //        tsükliMuutuja -= 1;
            //    }
            //    while (tsükliMuutuja != 0);

            //    Console.WriteLine($"Palun, siin on sinu ruut, suurusega {ruuduSuurus}x{ruuduSuurus}");
            //}

            /* Tingimuslause osad */
            if (true) { }       // kaitsus sõna if kutsub esile tingimuslause, mille tingimus on sulgude vahel, ning millele järgneb
                                // koodiplokk tingimuse täitumisel teostatava koodiga
            else if (false) { } // kaitstus sõnad "else" ja "if" kutsuvad esile sekundaarse tingimuslause, mille tingimus
                                //  on samamoodi sulgude vahel, ning millele peab eelnema alat kas "if" või teine "else if". Tingimuse täitumisel
                                // ja eelneva tingimuse mittetäitumisel, teostatakse koodiplooki sees olev kood
            else { }            // kaitstud sõna else kutsub esile järeltingimuse, millele peab eelnema kas "if" või "else if", ning mille koodiploki sisu
                                // täidetakse kõikide teiste "if" ja "else if" tingimuste läbikukkumisel
            int option = 3;     // 
            switch (option)     // switch on kaitstud sõna alternatiivse tingimuskontrolli jaoks mida saab if else-if asemel kasutada
                                // sulgude vahele käib muutuja nimi mille põhjal tingimuslik ümberlülitus toimub. siin sulgude vahel 
                                // ei ole tingimus ise, vaid kõigest kontrollitab muutuja, või omakorda sulgude vahel muu tingimus.
                                // pärast lülitusvalikut tuleb koodiplokk 
            {
                case 1:         // koodiplooki sees on erinevad juhtumid, juhtumit sätestatakse kaitstud sõna case abil. antud juhul kontrollitakse
                                // kas muutujas "option" on väärtus 1, millele järgned koolon ":" väljendades tingimuse täitimisel tehtava
                                // kooditegevuse algust
                    break;      // kui tegevus on tehtud, väljutakse mitte ainult juhtumist, vaid kogu käesoleva "case"-tingimustikust kaitstud
                                // sõnaga "break". peale breaki on lauselõppumärk ";".
                case 2:         // Juhtumeid võib olla mitmeid, antud juhul on neid kolm nindlalt
                    break;
                case 3:
                    Console.WriteLine(option); // tehtav kooditegevus
                    break;
                default:        // default juhtumit täidetakse siis, kui ülejäänud juhtumid ei kirjelda muutujas "option" olevat seisu.
                    break;      // ka default lõpeb sõnaga "break".
            }

            /* Sõne tööristad ja muud tekstiga seotut */
            string alfa = "a\nb";           // \n -> tekitab ühe sõne sisse reamurde, sõne kus on sees üks "\n", omab kahte rida.
            string beta = $"a {alfa} b";    // $ -> lubab kasutada muutujaid loogiliste sulgudega otse teksti sees. on variant
                                            //      formateeritud stringist.






            /* Loogilised tehted */
            // &&       -> "and" loogiline tehe, mida kasutatakse tingimuste kirjeldamisel, ning mis annam positiivse vastuse (true) juhul kui
            //              mõlemal pool && märki olevad tingimused on täidetud. Kui üks neist ei ole, siis annab negatiivse vastuse (false)

            // ||       -> "or"! loogiline tege, mida kasutatakse tingimuste tingimuste kirjeldamisel, ning mis annab positiivse vastuse (true) siis kui 
            //             vähemalt üks tingimus on täidetud. Negatiivne vastus (false) tagastatakse siis, kui kõik tingimused on täitmata


            // !        -> "not" loogiline tehe, mida kasutatakse tingimuse tulemuse inverteerimiseks. Tulemus, mis muidu tagastaks (true)
            //             hüüumargi abil tagastab (false), ja vastupidi - tulemus mis muidu tagastaks (false), hüüumärgi abil tagastab (true)


            /* Võrdlusoperaatorid */

            // ==       -> "on võrdne". Võrdusmärkide ühel pool olev objekt peab vastama täpselt oma olemuselt võrdusmärkide teise pool oleva
            //              objektiga. Ei ole sama nagu üks võrgusmärk, üks võrdusmärk omistab, kaks võrdleb


            // !=       -> "ei ole võrdne". Võrdusmärgi ühel pool olev objekt *EI TOHI* olla samal kujul nagu võrdusmärgi teisel pool olev objekt.
            //          Ta võib olla ükskõik mis muul kujul, aga mitte võrreldava objektiga samal kujul. Võrdlus operaator on kombinatsioon
            //          "on võrdne" operaatorist, ja loogiliselt tehtest "not"

            // >        -> "on suurem kui". Märgist vasakul pool olev objekt peaks olema suurem, kui parema pool olev objekt. 
            // <        -> "on väiksem kui". Märgist vasakul pool olev objekt peaks olema väiksem, kui parema pool olev objekt.
            // >=       -> "suuremvõrdne". Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või suurem kui parempoolne objekt
            //          Võrdlusoperaator on kombinatsioon "on võrdne" ja "on suurem kui" operaatoritest.
            // <=       -> "väiksemvõrdne". Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või väiksem kui parempoolne objekt
            //          Võrdlusoperaator on kombinatsioon "on võrdne" ja "on väiksem kui" operaatoritest.


            /* Omistusoperaatorid ja kiirtehted */

            int thing = 1; // = -> üksis võrdusmärk omistab muutuja sisse väärtuse, mida saab kasudata, läbi muutuja nime
            thing += 1; // += -> võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva arvu
                        //       asendeb tehed "thing = thing +1;". on kombinatsioon matemaatiliselt tehtest "+" ja omistamisest "="

            thing -= 1; // -= -> võrdusmärk mille ees on miinus, automaatselt lauhtab muutujast maha võrdusmärgi teisel pool oleva arvu
                        //       asendab tehet "thing = thing - 1;". on kombinatsioon matemaatiliselt tehtest "-" ja omistamisest "="
            
            thing *= 2; // *= -> võrdusmärk mille ees on korrutustmärk "*", automaatselt korrutab muutuja sisu, võrdusmärgi teisel pool
                        //       oleva arvu kordi. asendab tehet "thing = thing * 2". on kombinatsioon tehtest "*" ja omistamisest "="


            thing /= 2; // /= -> võrdusmärk mille ees on jagamismärk "/", automaatselt jagab muutuja sisu võrdusmärgi teisel pool oleva
                        //       arvu osadeks. asendab tehet "thing = thing / 2". on kombinatsioon tehtest "/" ja omistamisest "="


            thing++;     // ++ -> on spetsiifiliselt ühe juurde liitmiseks kiirtehe
            thing--;     // -- -> on spetsiifiliselt ühe maha lahatamiseks kiirtehe



            /* Tsüklid */
            // 1. do-while. 
            int d = 0;
            do // on kaitstud sõna, mis alustab do-while tsüklit. Pärast seda on tsükliplokk {} ning ütleb et tee seda koodi
            {
                d++;
            } while (d != 5); // niikaua kuni while järel olevate sulgude vahel tingimus ei täitu, käivitakse eelne kood uuesti

            // 2. while
            int i = 1;          // tsükli muutuja, mis aitab järgepidada while tsükli toimimisel
            while (i < 5)       // "while" on kaitstud sõna mis alustab while tsükli varianti, ilma "do"ta, ning vajab alati välist 
                                // tsüklimuutujat. Antud juhul on selleks i. Tsükli tingimus, mis peale "while" sõna on, asub sulgude vahel, 
                                // siin kontrooliktasegi tsükli tööd, läbi kindla tingimuse kasutades tsüklimuutujat.
                                // Antud juhul tsükkel töötab niikaua, kuni i on väiksem kui 5. kui i on sama suur nagu 5, siis tsükkel
                                // katkeb.
            {
                // koodiplokk kus midagi tehakse
                i++; // ning seejärel muudetakse tsüklimuutuja "i" olekut. antud juhul liidetakse 1 juurde kiirtehega "++".
            }
            
            // 3. for
            int kogus = 6;  // muutuja mida tsükkel kasutab oma töö tegemiseks - teisisõnu, tööeldav materjal
            for (int k = 0; k < kogus; k++) // kaitstud sõna "for" alustab for-tsüklit, pärast mida on sulud, mille vahel on kõik tsükli 
                                            // töö jaoks vajalik olemas. Esimene parameter, tekitab tsükli töö jaoks kohaliku muutuja
                                            // "int k = 0;" mida tsükli ENDA töö juhtimiseks. Teine parameeter on tingimuslause, mis kontrollib
                                            // tingimuse täitumist "k < kogus" ning mille täitumisel tsükli töö jatkub, aga mille
                                            // mitte täitumisel tsükkel katkeb. Kolmas parameeter on tsüklimuutuja inkrementeerimine kiirtehtega "k++".
                                            // Pane tähele, et iga sulgude vahel oleva osa järel (välja arvatud viimase) on
                                            // lauselõpumärk. Tsükli tööd kontrolliv tingimuslause koosneb kolmest reast, mitte ühest
                                            // nagu "while" või "do-while" puhul
            
            {                               // sulgudele järgneb, loogeliste sulgude vahel ole koodiplokk {}
                Console.WriteLine(k);       // töötlustegevus tsükli sees, on muutuja "k" hetkearvu väljakuvamine.
            }

            // 4. foreach
            int[] arvuLoend = { 3, 89, 123412, 7, 67 }; //massiiv mida foreach tsükkel kasutab, või töötleb mingil kujul.
            foreach (var arvInLoend in arvuLoend) // kaitstud sõna foreach alustab foreach tsükli. Pärast mida on sulud, mille vahel tekitatakse
                                                  // ajutine muutuja andmetüübiga "var" töödeldava andmekogumi üksikelemendi jaoks. süntaksis olev
                                                  // kaitstud sõna "in" väljendab et tsükkel käib selle loendi elementide kohta, ning var "arvInLoend
                                                  // muutuja hoiab endas just peale sõna "in" oleva andmekogumi elementi. Tsüklil ei ole nähtavat
                                                  // tsüklimuutujat ega tingimust, tsükkel toimib niikaua kuni elemente jätkub ehk tsükli töö käib
                                                  // iga üksiku elemendi kohta andmekogumis. Tsüklil ei ole vaja tsüklimuutujat, kuna talle on
                                                  // sisse ehitatud vaikimisi elemndi järjestuse jälgimine. Niipalju kui andmeid on, ongi see,
                                                  // mitu korda tsükkel käivitatakse.
            {                                     // {} koodiplokk kus tehakse mingi tegevus
                Console.WriteLine(arvInLoend);    // antud juhul kuvatakse välja ajutine muutuja, mille sees on loendi element. 
            }
        }
    }
}
