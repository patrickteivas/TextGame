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
            int päevad = 1;
            bool state = true;
            while (state == true)
            {
                Typewrite("Artjom ärkab, kell on 7:45. Peate otsustama, mida Artjom edasi teeb.");
                valik:
                Console.WriteLine("\n(1) Läheb kooli\n(2) Ei lähe kooli");
                int otsus = int.Parse(Console.ReadLine());

                if (otsus == 1)
                {
                    Console.Clear();
                    Typewrite("Artjom tõusis voodist üles, pesi hambaid ja läks kooli.\nArtjom õppis hoolsalt koolis ning kell sai 17:00. Artjom läks koju.\nKodus Artjom sõi ning ");
                    if (päevad == 1)
                    {
                        Typewrite("läks magama.");
                        päevad++;
                    }
                    else if (päevad == 2)
                    {
                        Typewrite("ning talle helistas ootamatult Dimitri.\n\nDimitri: Jou mees sa pead kohe minu juurde peole tulema.\nArtjom: Ma ei tea kas viitsin.\nDimitri: Cmon mees, poh tule.\nArtjom: No davai ma tulen.\n\nNing nüüd liigub Artjom Dimitri maja poole.");
                        state = false;
                    }

                    Console.WriteLine("\n\nVajutage enterit, et looga edasi minna.");
                    Console.ReadLine();
                    Console.Clear();

                    if (Stamina < 100)
                    {
                        Stamina += 10;
                    }
                }
                else if (otsus == 2)
                {
                    Console.Clear();
                    Typewrite("Artjom otsustas, et ei lähe kooli ning nüüd on tal võimalus tegeleda millegi muuga.\n");
                    valik2:
                    Console.WriteLine("\nMillega ta võiks tegeleda?\n(1) Otsib varustaja ja müüb narkotsi.\n(2) Teeb peale.\n(3) Magab päeva maha.");
                    int otsus2 = int.Parse(Console.ReadLine());
                    if (otsus2 == 1)
                    {
                        Console.Clear();
                    }
                    else if (otsus2 == 2)
                    {
                        Console.Clear();
                    }
                    else if (otsus2 == 3)
                    {
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write("Niisugust valikut pole, proovige uuesti\n");
                        goto valik2;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.Write("Niisugust valikut pole, proovige uuesti");
                    goto valik;
                }
            }
        }

        public void DimitriBattle()
        {

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
