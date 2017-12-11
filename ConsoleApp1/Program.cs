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

            Console.WriteLine("Sinu tegelane on Artjom, üheksanda klassi Õpilane, kes hiljuti kolis Ida-Virumaale Kohtla-Järvesse. Linnas on tal raske tutvuda inimestega ning tal trenn, mis algas alles paari kuu eest, jäi katki, ning nüüd peab ta otsima uue treeninguala.");
        }
    }
}
