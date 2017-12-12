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
            Start:
            Console.WriteLine("---Menu---\n(1) Play\n(2) About\n(3) Credits\n(4) Exit");
            int ValikMenu = int.Parse(Console.ReadLine());
            if (ValikMenu == 1)
            {
                var Artjom = new BattleSystem();
                Artjom.Money = 100;
                Artjom.Karma = 0;
                Artjom.Lucky = 0;

                Console.Clear();
                Typewrite("Edaspidised valikud muudavad sinu mängukäiku!\n\nSinu tegelaseks on üheksanda klassi õpilane Artjom, kes hiljuti kolis Ida-Virumaale, Kohtla-Järvele. \nSul oli eelmises linnas trenn, mis sulle väga meeldis, kuid uues linnas sellist trenni ei ole,\nning nüüd pead sa otsima uue treeninguala millega sa tegelema soovid hakata.");
                Valik:
                Console.WriteLine("\n\nPeate valima oma uue treeninguala:\n(1) Poks (Easy)\n(2) Jalgpall (Medium)\n(3) Iluuisutamine (Hard)");
                int trgAla = int.Parse(Console.ReadLine());
                if (trgAla == 1)
                {
                    Artjom.Agility = 75;
                    Artjom.Stamina = 80;
                    Artjom.Respect = 80;
                    Console.Clear();
                    Console.WriteLine("Te valisite: Poksi");

                    Typewrite("\nArtjom on sõbrunenud oma uue klassiga väga hästi, kuid tal ei olnud tulevasel \nvanaaasta õhtul mitte midagi teha. \n\nArtjom ärkab üles ja seab end valmis kooli minema 28. detsembri hommikul. \nKoolis teel õpetajate tuppa, kus Artjom soovis klassijuhatajaga rääkida kohtab Artjom kahte klassivenda.\nArtjomi klassivennad Marek ja Siim märkavad teda ning suunduvad kiiresti tema poole: \n\nMarek ja Siim: Kuule, Artjom.\nArtjom: Jah?\nMarek ja Siim: Plaanid Siimu poole peole tulla ka või? Polegi näinud sind varem pidudel.\nArtjom: Peole? Ma pole isegi kutset saanud.\nMarek ja Siim: Kas sa oled endaarust nii eriline, et väärid eraldi kutset? See on avatud pidu mees.\nArtjom: Aaa.. ma arvasin, et see on kinnine pidu\nMarek ja Siim: Vahet pole mees, tuled või ei?\nArtjom: Võib-olla, ma hetkel ei oska öelda, ma hiljem annan teada.\nMarek ja Siim vaatavad imestunud nägudega Artjomi poole, kui ta jalutab ära õpetajate toa poole.\n");
                }
                else if (trgAla == 2)
                {
                    Artjom.Agility = 50;
                    Artjom.Stamina = 80;
                    Artjom.Respect = 60;
                    Console.Clear();
                    Console.WriteLine("Te valisite: Jalgpalli");

                    Typewrite("\nArtjom oli üsnagi sotsiaalne oma eelmises koolis, aga peale kuu aega olles Kohtla-Järvel, \nei ole ta sõbrunenud uue klassiga terviklikult ning sellepärast ei olnud tal tulevasel \nvanaaasta õhtul mitte midagi plaanis. \n\nArtjom ärkab üles ja seab end valmis kooli minema 28. detsembri hommikul. \nKoolis teel õpetajate tuppa, kus Artjom soovis klassijuhatajaga rääkida kohtab Artjom kahte klassivenda.\nArtjomi klassivennad Marek ja Siim märkavad teda ning suunduvad kiiresti tema poole: \n\nMarek ja Siim: Kuule, Artjom.\nArtjom: Jah?\nMarek ja Siim: Plaanid Siimu poole peole tulla ka või? Polegi näinud sind varem pidudel.\nArtjom: Peole? Ma pole isegi kutset saanud.\nMarek ja Siim: Kas sa oled endaarust nii eriline, et väärid eraldi kutset? See on avatud pidu mees.\nArtjom: Aaa.. ma arvasin, et see on kinnine pidu\nMarek ja Siim: Vahet pole mees, tuled või ei?\nArtjom: Võib-olla, ma hetkel ei oska öelda, ma hiljem annan teada.\nMarek ja Siim vaatavad imestunud nägudega Artjomi poole, kui ta jalutab ära õpetajate toa poole.\n");
                }
                else if (trgAla == 3)
                {
                    Artjom.Agility = 60;
                    Artjom.Stamina = 30;
                    Artjom.Respect = -40;
                    Console.Clear();
                    Console.WriteLine("Te valisite: Iluuisutamise");

                    Typewrite("\nArtjom oli üsnagi sotsiaalne oma eelmises koolis, aga peale kuu aega olles Kohtla-Järvel,\ntundis Artjom, et tema uus klass väldib teda ning sellepärast ei olnud tal tulevasel \nvanaaasta õhtul mitte midagi teha. \n\nArtjom ärkab üles ja seab end valmis kooli minema 28. detsembri hommikul. \nKoolis teel õpetajate tuppa, kus Artjom soovis klassijuhatajaga rääkida kohtab Artjom kahte klassivenda.\nArtjomi klassivennad Marek ja Siim märkavad teda ning suunduvad kiiresti tema poole: \n\nMarek ja Siim: Kuule, Artjom.\nArtjom: Jah?\nMarek ja Siim: Plaanid Siimu poole peole tulla ka või? Polegi näinud sind varem pidudel.\nArtjom: Peole? Ma pole isegi kutset saanud.\nMarek ja Siim: Kas sa oled endaarust nii eriline, et väärid eraldi kutset? See on avatud pidu mees.\nArtjom: Aaa.. ma arvasin, et see on kinnine pidu\nMarek ja Siim: Vahet pole mees, tuled või ei?\nArtjom: Võib-olla, ma hetkel ei oska öelda, ma hiljem annan teada.\nMarek ja Siim vaatavad imestunud nägudega Artjomi poole, kui ta jalutab ära õpetajate toa poole.\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sellist valikut ei ole, proovi uuesti.");
                    goto Valik;
                }

                Console.WriteLine("\nVajutage enterit, et looga edasi minna.");
                Console.ReadKey();
                Console.Clear();

                Typewrite("Käes on 31.detsember.\n\nArtjom on õhtupoolikul poe ees, sest tema ema palus, et ta ostaks koju süüa ja juua. \nTeed takistab must BMW E39, autost astuvad välja Marek ja Siim ning küsivad: ");
                Valik2:
                Console.WriteLine("\nMarek ja Siim: No Artjom, mida sa ära otsustasid? Kas tuled siis või ei?\n[Jah, ei]");
                String Vastus420 = Console.ReadLine();
                Console.Clear();
                if (Vastus420 == "jah" | Vastus420 == "Jah" | Vastus420 == "Tulen" | Vastus420 == "tulen")
                {
                    Typewrite("Marek kutsub Artjomi autosse, Artjom istub ning nad sõidavad peo poole, jutustades elust enesest.");
                }
                else if (Vastus420 == "Ei" | Vastus420 == "ei" | Vastus420 == "ei tule" | Vastus420 == "Ei tule")
                {
                    Typewrite("Siim läheb närvi mille peale Artjom siiski istub autosse");
                }
                else
                {
                    Console.WriteLine("Sellist valikut ei ole, proovi uuesti.");
                    goto Valik2;
                }

                Typewrite("\nPeol märkab Artjom, et seal on palju tundmatuid nägusid, kuid suuremad grupid ikkagi suhtlevad pigem üksteise vahel \nkui kellegi teisega. Artjom läheb elutuppa otsima endale juua, teel sinna märkab ta pikka, blondi noormeest,\nkes märkab ka Artjomi ning suundub tema poole ning ütleb:\n\nDimitri: Tervist, tundud uus olevat. Olen Dimitri.\nArtjom: Kolisin hiljuti alles Kohtla-Järvele seega olen üsna uus, olen Artjom muidu.\nDimitri: Aa, sina oledki see Artjom keda Marek mulle mõned päevad tagasi mainis?\nArtjom: Vist jah, ega sa muidu ei tea juhuslikult, kes seda pidu korraldab?\nDimitri: See ongi minu pidu, tahad midagi juua või oled kainerool?\nArtjom: Ma ei tea.. ma pole varem joonud.\nDimitri: Tohoh, seda annab küll muuta. Tule minu järgi kööki, tutvustan sulle paari inimest.\n\nArtjom ja Dimitri seavad sammud köögi suunas, köögis märkavad nad, et õllekasti kõrval seisavad kaks noormeest ja üks tüdruk.\nArtjom ja Dimitri lähevad nende juurde ning hakkavad vestlema:\nDimitri: Vaadake kutid kelle ma leidsin, see on Artjom. Kutt kolis alles hiljuti Kohtla-Järvele seega võtke rahulikult.\nDimitri: Aga sellepeale me ju võtame?\nPeeter: Muidugi võtame.\nTanja: Kutid võtke nüüd rahulikult\nKutid: võtame võtame..");
                Console.WriteLine("Tanja: Artjom kas sa tobi tahad?\n[Tahan/Ei taha]");
                String Vastus1337 = Console.ReadLine();

                if (Vastus1337 == "Tahan" | Vastus1337 == "tahan")
                {
                    Typewrite("Artjom paneb suitsu põlema ning hakkab seda rahulikult tõmbama.");
                }
                else if (Vastus1337 == "ei taha" | Vastus1337 == "Ei taha")
                {
                    Typewrite("Vaatamata Artjomi soovidest, surutakse talle ikka tobi ette ning ta hakkab seda kimudes köhima.");
                }
                else
                {
                    Console.WriteLine("Sellist valikut ei ole, proovi uuesti.");
                    goto Valik2;
                }
            }
            else if (ValikMenu == 2)
            {
                Console.Clear();
                Typewrite("Meie mäng räägib ühest 9nda klassi poisist, kes kolib Kohtla-Järvele ning satub selletõttu halba seltskonda.\nMängu käigus käsitleme Artjomi elukäiku, mis muutub iga päevaga aina halvemaks.");
                Console.ReadLine();
                Console.Clear();
                goto Start;
                //About
            }
            else if (ValikMenu == 3)
            {
                Console.Clear();
                //Credits
            }
            else if (ValikMenu == 4)
            {
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sellist valikut ei ole, proovi uuesti.\n");
                goto Start;
            }
            Console.WriteLine("Programm lõpetas töö.");
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