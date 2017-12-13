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
                    if (Agility < 100)
                    {
                        Agility += 10;
                        if (Agility > 100) Agility = 100;
                    }
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
                }
                else if (otsus == 2)
                {
                    Console.Clear();
                    if (Respect < 100)
                    {
                        Respect += 5;
                        if (Respect > 100) Respect = 100;
                    }
                    Typewrite("Artjom otsustas, et ei lähe kooli ning nüüd on \ntal võimalus tegeleda millegi muuga.\n");
                    valik2:
                    Console.WriteLine("\nMillega ta võiks tegeleda?\n(1) Otsib varustaja ja müüb narkotsi.\n(2) Teeb peale.\n(3) Magab päeva maha.");
                    int otsus2 = int.Parse(Console.ReadLine());
                    if (otsus2 == 1)
                    {
                        Console.Clear();
                        if (Respect < 50)
                        {
                            Console.WriteLine("Kahjuks te ei saa sellega tegeleda (Liiga madal Respect).");
                            goto valik2;
                        }
                        else
                        {
                            Random rnd = new Random();
                            int chance = rnd.Next(0, 2);
                            if (chance == 1)
                            {
                                Typewrite("Te leidsite diileri ja saite narko müüdud, kuid sellega läks terve päev.\nNüüd Artjom suundub koju ");
                                if (Respect < 100)
                                {
                                    Respect += 15;
                                    if (Respect > 100) Respect = 100;
                                }
                                Money += 35;
                                if (päevad == 2)
                                {
                                    Typewrite("ning talle helistab ootamatult Dimitri.\n\nDimitri: Jou mees sa pead kohe minu juurde peole tulema.\nArtjom: Ma ei tea kas viitsin.\nDimitri: Cmon mees, poh tule.\nArtjom: No davai ma tulen.\n\nNing nüüd liigub Artjom Dimitri maja poole.");
                                    state = false;
                                }
                                else Typewrite("ja jääb magama.");
                                Console.WriteLine("\nVajutage enterit, et looga edasi minna.");
                                Console.ReadKey();
                                Console.Clear();
                                päevad++;
                            }
                            else
                            {
                                Typewrite("Teil ei vedanud ja te ei leidnud diilerit, kuid otsiste terve päev.\nNüüd Artjom on kõndimisest väsinud ja liigub koju");
                                Respect -= 5;
                                if (päevad == 2)
                                {
                                    Typewrite(" ning talle helistab ootamatult Dimitri.\n\nDimitri: Jou mees sa pead kohe minu juurde peole tulema.\nArtjom: Ma ei tea kas viitsin.\nDimitri: Cmon mees, poh tule.\nArtjom: No davai ma tulen.\n\nNing nüüd liigub Artjom Dimitri maja poole.");
                                    state = false;
                                }
                                else Typewrite(", kus jääb magama.");
                                Console.WriteLine("\nVajutage enterit, et looga edasi minna.");
                                Console.ReadKey();
                                Console.Clear();
                                päevad++;
                            }
                        }
                    }
                    else if (otsus2 == 2)
                    {
                        Random rnd = new Random();
                        int chance = rnd.Next(0, 2);
                        if (chance == 1)
                        {
                            Console.Clear();
                            Typewrite("Artjomil vedas: kui ta vaatas kapi alla, leidis ta sealt peidetud ZIP-locki, tegi peale ning hakkas XBOXi pelama.");
                            if (Respect < 100)
                            {
                                Respect += 5;
                                if (Respect > 100) Respect = 100;
                            }
                            if (päevad == 2)
                            {
                                Typewrite("\nÕhtul talle helistab ootamatult Dimitri.\n\nDimitri: Jou mees sa pead kohe minu juurde peole tulema.\nArtjom: Ma ei tea kas viitsin.\nDimitri: Cmon mees, poh tule.\nArtjom: No davai ma tulen.\n\nNing nüüd liigub Artjom Dimitri maja poole.");
                                state = false;
                            }
                            else Typewrite(" Õhtul läks Artjom magama.");
                            Console.WriteLine("\nVajutage enterit, et looga edasi minna.");
                            Console.ReadKey();
                            Console.Clear();
                            päevad++;
                        }
                        else
                        {
                            Console.Clear();
                            Typewrite("Artjomil ei vedanud ning ta ei leidnud kodus peale.");
                            if (Stamina < 100)
                            {
                                Stamina += 10;
                                if (Stamina > 100) Stamina = 100;
                            }
                            if (päevad == 2)
                            {
                                Typewrite("\nSelle peale otsustab Artjom päeva maha magada, kuid õhtul talle helistab ootamatult Dimitri.\n\nDimitri: Jou mees sa pead kohe minu juurde peole tulema.\nArtjom: Ma ei tea kas viitsin.\nDimitri: Cmon mees, poh tule.\nArtjom: No davai ma tulen.\n\nNing nüüd liigub Artjom Dimitri maja poole.");
                                state = false;
                            }
                            else Typewrite("\nSelle peale otsustas ta terve päeva maha magada.");
                            Console.WriteLine("\nVajutage enterit, et looga edasi minna.");
                            Console.ReadKey();
                            Console.Clear();
                            päevad++;
                        }
                    }
                    else if (otsus2 == 3)
                    {
                        Console.Clear();
                        Typewrite("Artjom oli liiga väsinud, et midagi teha, ning magas päeva maha.");
                        if (Stamina < 100)
                        {
                            Stamina += 10;
                            if (Stamina > 100) Stamina = 100;
                        }
                        if (päevad == 2)
                        {
                            Typewrite("\nÕhtul talle helistab ootamatult Dimitri, millega äratab Artjomi üles.\n\nDimitri: Jou mees sa pead kohe minu juurde peole tulema.\nArtjom: Ma ei tea kas viitsin.\nDimitri: Cmon mees, poh tule.\nArtjom: No davai ma tulen.\n\nNing nüüd liigub Artjom Dimitri maja poole.");
                            state = false;
                        }
                        Console.WriteLine("\nVajutage enterit, et looga edasi minna.");
                        Console.ReadKey();
                        Console.Clear();
                        päevad++;
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
