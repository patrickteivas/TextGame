using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage funktsiooni järjekorranumber.\n\n---Menu---\n(1) Play\n(2) About\n(3) Credits\n(4) Exit");
            int ValikMenu = int.Parse(Console.ReadLine());
            if (ValikMenu == 1)
            {
                bool state = true;
                while (state == true)
                {

                    var Artjom = new BattleSystem();
                    Artjom.Money = 100;
                    Artjom.Karma = 0;
                    Artjom.Lucky = 0;

                    Console.Clear();
                    Console.WriteLine("Edaspidised valikud muudavad sinu mängukäiku!\n\nSinu tegelaseks on üheksanda klassi õpilane Artjom, kes hiljuti kolis Ida-Virumaale, Kohtla-Järvele. \nSul oli eelmises linnas trenn, mis sulle väga meeldis, kuid uues linnas seda ei ole,\nning nüüd pead sa otsima uue treeninguala millega sa tegelema soovid hakata.");
                    Valik:
                    Console.WriteLine("\nPeate valima oma uue treeninguala (Sisestage järjekorranumber):\n(1) Poks\n(2) Jalgpall\n(3) Iluuisutamine");
                    int trgAla = int.Parse(Console.ReadLine());
                    if (trgAla == 1)
                    {
                        Artjom.Agility = 75;
                        Artjom.Stamina = 80;
                        Artjom.Respect = 80;
                        Console.Clear();
                        Console.WriteLine("Te valisite: Poksi");
                    }
                    else if (trgAla == 2)
                    {
                        Artjom.Agility = 50;
                        Artjom.Stamina = 80;
                        Artjom.Respect = 60;
                        Console.Clear();
                        Console.WriteLine("Teie valisite: Jalgpalli");
                    }
                    else if (trgAla == 3)
                    {
                        Artjom.Agility = 60;
                        Artjom.Stamina = 30;
                        Artjom.Respect = -40;
                        Console.Clear();
                        Console.WriteLine("Te valisite: Iluuisutamise");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Sellist valikut ei ole, proovi uuesti.");
                        goto Valik;
                    }
                    Console.WriteLine("\nArtjom oli üsnagi sotsiaalne oma eelmises koolis, aga peale kuu aega olles Kohtla-Järvel, \nei olnud ta sõbrunenud väga oma uue klassiga, ning sellepärast ei olnud tal tulevasel \nvanaaasta õhtul mitte midagi teha. \n\nArtjom ärkab üles ja seab end valmis kooli minema 28. detsembri hommikul. \nKoolis teel õpetajate tuppa, kus Artjom soovis klassijuhatajaga rääkida kohtab Artjom kahte klassivenda.\nArtjomi klassivennad Marek ja Siim märkavad teda ning suunduvad kiiresti tema poole: \n\nMarek ja Siim: Kuule, Artjom.\nArtjom: Jah?\nMarek ja Siim: Plaanid Siimu poole peole tulla ka või? Polegi näinud sind varem pidudel.\nArtjom: Peole? Ma pole isegi kutset saanud.\nMarek ja Siim: Kas sa oled endaarust nii eriline, et väärid eraldi kutset? See on avatud pidu mees.\nArtjom: Aaa.. ma arvasin, et see on kinnine pidu\nMarek ja Siim: Vahet pole mees, tuled või ei?\nArtjom: Võib-olla, ma hetkel ei oska öelda, ma hiljem annan teada.\nMarek ja Siim vaatavad imestunud nägudega Artjomi poole, kui ta jalutab ära õpetajate toa poole");

                    Console.WriteLine("\nVajutage enterit, et looga edasi minna.");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("Käes on 31.detsember.\n\nArtjom on õhtupoolikul poe ees, sest tema ema palus et ta ostaks koju süüa ja juua. \nTeed takistab must BMW E39, autost astuvad välja Marek ja Siim ning küsivad Artjomilt:");
                Valik2:
                    Console.WriteLine("\nMarek ja Siim: No mida sa ära otsustasid? Kas tuled siis või ei?\n[Jah, ei]");
                    String Vastus420 = Console.ReadLine();
                    Console.Clear();
                    if (Vastus420 == "jah" | Vastus420 == "Jah" | Vastus420 == "Tulen" | Vastus420 == "tulen")
                    {
                        Console.WriteLine("Marek kutsub Artjomi autosse, Artjom istub ning nad sõidavad peo poole, jutustades elust enesest");
                    }
                    else if (Vastus420 == "Ei" | Vastus420 == "ei" | Vastus420 == "ei tule" | Vastus420 == "Ei tule")
                    {
                        Console.WriteLine("Siim läheb närvi mille peale Artjom siiski istub autosse");
                    }
                    else
                    {
                        Console.WriteLine("Sellist valikut ei ole, proovi uuesti.");
                        goto Valik2;
                    }

                    Console.WriteLine("\nPeol märkab Artjom, et seal on palju tundmatuid nägusid, kuid suuremad grupid ikkagi suhtlevad pigem üksteise vahel,\nkui kellegi teisega. Artjom läheb elutuppa otsima endale juua, teel sinna märkab ta pikka, blondi noormeest,\nkes märkab ka Artjomi ning suundub tema poole ning ütleb:\n\nDimitri: Tervist, tundud uus olevat. Olen Dimitri.\nArtjom: Kolisin hiljuti alles Kohtla-Järvele seega olen üsna uus jap, olen Artjom muidu.\nDimitri: Aa, sina oledki see Artjom keda Marek mulle mõned päevad tagasi mainis?\nArtjom: Vist jah, ega sa muidu ei tea juhuslikult, kes seda pidu korraldab?\nDimitri: See ongi minu pidu, tahad midagi juua või oled sa autojuht?\nArtjom: Ma ei tea.. ma pole varem joonud varem.\nDimitri: Tohoh, siis peab küll ära proovima. Tule minu järgi köögi, tutvustan sulle paari inimest\n\nArtjom ja Dimitri seavad sammud köögi suunas, köögis märkavad nad, et õllekasti kõrval seisavad kaks noormeest ja üks tüdruk.\nArtjom ja Dimitri lähevad nende juurde ning hakkavad vestlema:\nDimitri: Vaadake kutid kelle ma leidsin, see on Artjom. Kutt kolis alles hiljuti Kohtla-Järvele seega võtke rahulikult.\n");
                    Console.WriteLine("Dimitri: Aga sellepeale me ju võtame ?\nPeeter: Muidugi võtame.\nTanja: Kutid võtke nüüd rahulikult\nKutid: võtame võtame..\nTanja: Artjom sa suitsu ei taha muidu?\n[Tahan/Ei taha]");
                    String Vastus1337 = Console.ReadLine();

                    if (Vastus1337 == "Tahan" | Vastus1337 == "tahan")
                    {
                        Console.WriteLine("Artjom paneb suitsu põlema ning hakkab seda rahulikult tõmbama.");
                    }
                    else if (Vastus1337 == "ei taha" | Vastus1337 == "Ei taha")
                    {
                        Console.WriteLine("Vaatamata Artjomi soovidest, surutakse talle ikka suits peale ning ta hakkb seda tõmmates köhima.");
                    }
                    else
                    {
                        Console.WriteLine("Sellist valikut ei ole, proovi uuesti.");
                        goto Valik2;
                    }


                }
            }
            else if (ValikMenu == 2)
            {
                Console.Clear();
                //About
            }
            else if (ValikMenu == 3)
            {
                Console.Clear();
                //Credits
            }
            else if (ValikMenu == 4)
            {
                //Exit
            }
        }
    }
}