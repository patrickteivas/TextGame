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

            Console.WriteLine("Edaspidised valikud sinu mängukäiku!\n");
            Console.WriteLine("Sinu tegelaseks on üheksanda klassi õpilane Artjom, kes hiljuti kolis Ida-Virumaale, Kohtla-Järvele. \nSul oli eelmises linnas trenn, mis sulle väga meeldis, kuid uues linnas seda ei ole,\nning nüüd pead sa otsima uue treeninguala millega sa tegelema soovid hakata.");
            Valik:
            Console.WriteLine("\nPeate valima oma uue treeninguala (Sisestage järjekorranumber):\n(1) Poks\n(2) Jalgpall\n(3) Iluuisutamine");
            int trgAla = int.Parse(Console.ReadLine());
            if (trgAla == 1)
            {
                Artjom.Agility = 75;
                Artjom.Stamina = 80;
                Artjom.Respect = 80;
            }
            else if (trgAla == 2)
            {
                Artjom.Agility = 50;
                Artjom.Stamina = 80;
                Artjom.Respect = 60;
            }
            else if (trgAla == 3)
            {
                Artjom.Agility = 60;
                Artjom.Stamina = 30;
                Artjom.Respect = -40;
            }
            else
            {
                Console.WriteLine("Sellist valikut pole.");
                goto Valik;
            }

            Console.WriteLine("\nArtjom oli üsnagi sotsiaalne oma eelmises koolis, aga peale kuu aega olles Kohtla-Järvel, \nei olnud ta sõbrunenud väga oma uue klassis, ning sellepärast ei olnud tal tulevasel \nvanaaasta õhtul mitte midagi teha.");
            Console.WriteLine("\nArtjom ärkab üles ja seab end valmis kooli minema 28. detsembri hommikul. \nKoolis teel õpetajate toa, kus Artjom soovis klassijuhatajaga rääkida kohtab Artjom kahte klassivenda, Marek ja Siim.\nNad märkavad Artjomi ning suunduvad kiiresti tema poole:");
        }
    }
}
