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
            
        }
    }
}
