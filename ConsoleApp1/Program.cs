﻿using System;
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
                Console.WriteLine("Sellist valikut pole.");
                goto Valik;
            }
            Console.WriteLine("\nArtjom oli üsnagi sotsiaalne oma eelmises koolis, aga peale kuu aega olles Kohtla-Järvel, \nei olnud ta sõbrunenud väga oma uue klassiga, ning sellepärast ei olnud tal tulevasel \nvanaaasta õhtul mitte midagi teha. \n\nArtjom ärkab üles ja seab end valmis kooli minema 28. detsembri hommikul. \nKoolis teel õpetajate tuppa, kus Artjom soovis klassijuhatajaga rääkida kohtab Artjom kahte klassivenda, Marekut ja Siimu.\nMarek ja Siim märkavad Artjomi ning suunduvad kiiresti tema poole: \n\nMarek ja Siim: Kuule, Artjom.\nArtjom: Jah?\nMarek ja Siim: Plaanid Siimu poole peole tulla ka või? Polegi näinud sind varem pidudel.\nArtjom: Peole? Ma pole isegi kutset saanud.\nMarek ja Siim: Kas sa oled endaarust nii eriline, et väärid eraldi kutset? See on avatud pidu mees.\nArtjom: Aaa.. ma arvasin, et see on kinnine pidu\nMarek ja Siim: Vahet pole mees, tuled või ei?\nArtjom: Võib-olla, ma hetkel ei oska öelda, ma hiljem annan teada.\nMarek ja Siim vaatavad imestunud nägudega Artjomi poole, kui ta jalutab ära õpetajate toa poole");

            Console.WriteLine("\nVajutage enterit, et looga edasi minna.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Test");
            
           
        }
    }
}
