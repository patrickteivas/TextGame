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
            var Artjom = new BattleSystem();
            Artjom.Money = 100;
            Artjom.Karma = 0;
            Artjom.Lucky = 0;

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

            //Tra patrick mul poh, eelmine tekst läks liiga pikaks, cancer editida juba nagu tra #ei kannata - nii on palju lihtsam ja loogilisem ülesehitus .
            Console.WriteLine("Käes on 31.detsember.\n\nArtjom on õhtupoolikul poe ees, sest tema ema palus et ta ostaks koju süüa ja juua. \nTeed takistab must BMW E39, autost astuvad välja Marek ja Siim ning küsivad Artjomilt:");
            Console.WriteLine("\nMarek ja Siim: No mida sa ära otsustasid? Kas tuled siis või ei?\n[Jah, ei]"); // [Jah, ei] süsteemi kast tuleb viisakamaks muuta.
            String Vastus420 = Console.ReadLine();
            Valik2: // Siin on mingi bug, spammib.
            Console.Clear();
            if (Vastus420 == "jah" | Vastus420 == "Jah" | Vastus420 == "Tulen" | Vastus420 == "tulen") {
                Console.WriteLine("Marek kutsub Artjomi autosse, Artjom istub ning nad sõidavad peo poole, jutustades elust enesest"); }
            else if (Vastus420 == "Ei" | Vastus420 == "ei" | Vastus420 == "ei tule" | Vastus420 == "Ei tule") {
                Console.WriteLine("Siim läheb närvi mille peale Artjom siiski istub autosse"); }
            else
            {
                Console.WriteLine("Sellist valikut ei ole, proovi uuesti.");
                goto Valik2;
            }
           
           // Console.WriteLine("\nPeol märkab Artjom, et seal on palju tundmatuid nägusid, kuid suuremad grupid ikkagi suhtlevad pigem üksteise vahel,\nkui kellegi teisega. Artjom läheb elutuppa otsima endale juua, teel sinna märkab ta pikka, blondi noormeest,\nkes märkab ka Artjomi ning suundub tema poole ning ütleb: ");
            Console.WriteLine("\nPeol märkab Artjom, et seal on palju tundmatuid nägusid, kuid suuremad grupid ikkagi suhtlevad pigem üksteise vahel,\nkui kellegi teisega. Artjom läheb elutuppa otsima endale juua, teel sinna märkab ta pikka, blondi noormeest,\nkes märkab ka Artjomi ning suundub tema poole ning ütleb:\n\nDimitri: Tervist, tundud uus olevat. Olen Dimitri.\nArtjom: Kolisin hiljuti alles Kohtla-Järvele seega olen üsna uus jap, olen Artjom muidu.\nDimitri: Aa, sina oledki see Artjom keda Marek mulle mõned päevad tagasi mainis?\nArtjom: Vist jah, ega sa muidu ei tea juhuslikult, kes seda pidu korraldab?\nDimitri: See ongi minu pidu, tahad midagi juua või oled sa autojuht?\nArtjom: Ma ei tea.. ma pole varem joonud varem.\nDimitri: Tohoh, siis peab küll ära proovima. Tule minu järgi köögi, tutvustan sulle paari inimest\n\nArtjom ja Dimitri seavad sammud köögi suunas, köögis märkavad nad, et õllekasti kõrval seisavad kaks noormeest ja üks tüdruk.\nArtjom ja Dimitri lähevad nende juurde ning hakkavad vestlema:\nDimitri: Vaadake kutid kelle ma leidsin, see on Artjom. Kutt kolis alles hiljuti Kohtla-Järvele seega võtke rahulikult. \n");
        }
    }
}
