using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BattleSystem
    {
        public int Stamina { get; set; }
        public int Agility { get; set; }
        public int Lucky { get; set; }
        public int Respect { get; set; }
        public int Money { get; set; }
        public int Karma { get; set; }

        public void FreeDay()
        {
            int päevad = 0;
            bool state = true;
            while (state == true)
            {
                Typewrite("Artjom ärkab, kell on 7:45. Peate otsustama, mida Artjom edasi teeb.");
                Console.WriteLine("\n(1) Läheb kooli\n(2) Ei lähe kooli");
                int otsus = int.Parse(Console.ReadLine());
                if (otsus == 1)
                {
                    Console.Clear();
                    Typewrite("Artjom tõusis voodist üles, pesi hambaid ja läks kooli.\nArtjom õppis hoolsalt koolis ning kell sai 17:00. Artjom läks koju.\nKodus Artjom sõi ");
                    if (Stamina < 100)
                    {
                        Stamina += 10;
                    }

                }
                else if (otsus == 2)
                {
                    Typewrite("");
                }
                else
                {

                }
                päevad++;

                if (päevad == 2)
                {
                    Typewrite("\nning talle helistas ootamatult Dimitri.\nDimitri: Jou mees sa pead kohe minu juurde peole tulema.\nArtjom: Ma ei tea kas viitsin.\nDimitri: Cmon mees, poh tule.\nArtjom: No davai ma tulen.\nNing nüüd liigub Artjom Dimitri maja poole.");
                    state = false;
                }
                else
                {
                    Typewrite("ning läks magama.");
                    Console.Clear();
                }
            }
        }

        static void Typewrite(string message)
        {
            int a = 50;
            for (int i = 0; i < message.Length; i++)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter) a = 00;
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(a);
            }
        }
    }
}
