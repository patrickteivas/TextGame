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
            //Menu
            Console.WriteLine("---Menu---\n(1) Play\n(2) About\n(3) Credits\n(4) Exit");
            int ValikMenu = int.Parse(Console.ReadLine());
            if (ValikMenu == 1) //Sissejuhatus
            {
                var Artjom = new BattleSystem();
                Artjom.Money = 100;
                Artjom.Karma = 0;
                Artjom.Lucky = 0;

                Console.Clear();

                TypewriteWhite("Edaspidised valikud muudavad sinu mängukäiku!\n\nSinu tegelaseks on üheksanda klassi õpilane Artjom, kes hiljuti kolis Ida-Virumaale, Kohtla-Järvele. \nSul oli eelmises linnas trenn, mis sulle väga meeldis, kuid uues linnas sellist trenni ei ole,\nning nüüd pead sa otsima uue treeninguala millega sa tegelema soovid hakata." );

                Valik:
                Console.WriteLine("\n\nPeate valima oma uue treeninguala:\n(1) Poks (Easy)\n(2) Jalgpall (Medium)\n(3) Iluuisutamine (Hard)");
                int trgAla = int.Parse(Console.ReadLine());
                if (trgAla == 1) //Poks
                {
                    Artjom.Agility = 75;
                    Artjom.Stamina = 80;
                    Artjom.Respect = 80;
                    Console.Clear();
                    Console.WriteLine("Te valisite: Poksi");

                    TypewriteWhite("\nArtjom on sõbrunenud oma uue klassiga väga hästi, kuid tal ei olnud tulevasel \nvana aasta õhtul mitte midagi teha. \n\nArtjom ärkab üles ja seab end valmis kooli minema 28. detsembri hommikul. \nKoolis teel õpetajate tuppa, kus Artjom soovis klassijuhatajaga rääkida kohtab Artjom kahte klassivenda.\nArtjomi klassivennad Marek ja Siim märkavad teda ning suunduvad kiiresti tema poole: \n\n");

                    TypewriteRed("Marek ja Siim: ");
                    TypewriteWhite("Kuule, Artjom.\n");

                    TypewriteRed("Artjom: ");
                    TypewriteWhite("Jah?\n");

                    TypewriteRed("Marek ja Siim: ");
                    TypewriteWhite("Plaanid klassipeole tulla ka või? Polegi näinud sind varem pidudel.\n");

                    TypewriteRed("Artjom: ");
                    TypewriteWhite("Peole? Ma pole isegi kutset saanud.\n");

                    TypewriteRed("Marek ja Siim: ");
                    TypewriteWhite("Kas sa oled endaarust nii eriline, et väärid eraldi kutset? See on avatud pidu mees.\n");

                    TypewriteRed("Artjom: ");
                    TypewriteWhite("Aaa.. ma arvasin, et see on kinnine pidu.\n");

                    TypewriteRed("Marek ja Siim: ");
                    TypewriteWhite("Vahet pole mees, tuled või ei?\n");

                    TypewriteRed("Artjom: ");
                    TypewriteWhite("Võib-olla, ma hetkel ei oska öelda, ma hiljem annan teada.\nMarek ja Siim vaatavad imestunud nägudega Artjomi poole, kui ta jalutab ära õpetajate toa poole.\n");
                }
                else if (trgAla == 2) //Jalgpall
                {
                    Artjom.Agility = 50;
                    Artjom.Stamina = 80;
                    Artjom.Respect = 60;
                    Console.Clear();
                    Console.WriteLine("Te valisite: Jalgpalli");

                    TypewriteWhite("\nArtjom oli üsnagi sotsiaalne oma eelmises koolis, aga peale kuu aega olles Kohtla-Järvel, \nei ole ta sõbrunenud uue klassiga terviklikult ning sellepärast ei olnud tal tulevasel \nvanaaasta õhtul mitte midagi plaanis. \n\nArtjom ärkab üles ja seab end valmis kooli minema 28. detsembri hommikul. \nKoolis teel õpetajate tuppa, kus Artjom soovis klassijuhatajaga rääkida kohtab Artjom kahte klassivenda.\nArtjomi klassivennad Marek ja Siim märkavad teda ning suunduvad kiiresti tema poole: \n\n");
                    TypewriteRed("Marek ja Siim: ");
                    TypewriteWhite("Kuule, Artjom.\n");
                    TypewriteRed("Artjom: ");
                    TypewriteWhite("Jah?\n");
                    TypewriteRed("Marek ja Siim: ");
                    TypewriteWhite("Plaanid Siimu poole peole tulla ka või? Polegi näinud sind varem pidudel.\n");
                    TypewriteRed("Artjom: ");
                    TypewriteWhite("Peole? Ma pole isegi kutset saanud.\n");
                    TypewriteRed("Marek ja Siim: ");
                    TypewriteWhite("Kas sa oled endaarust nii eriline, et väärid eraldi kutset? See on avatud pidu mees.\n");
                    TypewriteRed("Artjom: ");
                    TypewriteWhite("Aaa.. ma arvasin, et see on kinnine pidu\n");
                    TypewriteRed("Marek ja Siim: ");
                    TypewriteWhite("Vahet pole mees, tuled või ei?\n");
                    TypewriteRed("Artjom: ");
                    TypewriteWhite("Võib-olla, ma hetkel ei oska öelda, ma hiljem annan teada.\nMarek ja Siim vaatavad imestunud nägudega Artjomi poole, kui ta jalutab ära õpetajate toa poole.\n");
                }
                else if (trgAla == 3) //Iluuisutamine
                {
                    Artjom.Agility = 60;
                    Artjom.Stamina = 30;
                    Artjom.Respect = -40;
                    Console.Clear();
                    Console.WriteLine("Te valisite: Iluuisutamise");

                    TypewriteWhite("\nArtjom oli üsnagi sotsiaalne oma eelmises koolis, aga peale kuu aega olles Kohtla-Järvel,\ntundis Artjom, et tema uus klass väldib teda ning sellepärast ei olnud tal tulevasel \nvanaaasta õhtul mitte midagi teha. \n\nArtjom ärkab üles ja seab end valmis kooli minema 28. detsembri hommikul. \nKoolis teel õpetajate tuppa, kus Artjom soovis klassijuhatajaga rääkida kohtab Artjom kahte klassivenda.\nArtjomi klassivennad Marek ja Siim märkavad teda ning suunduvad kiiresti tema poole: \n\n");
                    TypewriteRed("Marek ja Siim: ");
                    TypewriteWhite("Kuule, Artjom.\n");
                    TypewriteRed("Artjom: ");
                    TypewriteWhite("Jah?\n");
                    TypewriteRed("Marek ja Siim: ");
                    TypewriteWhite("Plaanid Siimu poole peole tulla ka või? Polegi näinud sind varem pidudel.\n");
                    TypewriteRed("Artjom: ");
                    TypewriteWhite("Peole? Ma pole isegi kutset saanud.\n");
                    TypewriteRed("Marek ja Siim: ");
                    TypewriteWhite("Kas sa oled endaarust nii eriline, et väärid eraldi kutset? See on avatud pidu mees.\n");
                    TypewriteRed("Artjom: ");
                    TypewriteWhite("Aaa.. ma arvasin, et see on kinnine pidu\n");
                    TypewriteRed("Marek ja Siim: ");
                    TypewriteWhite("Vahet pole mees, tuled või ei?\n");
                    TypewriteRed("Artjom: ");
                    TypewriteWhite("Võib-olla, ma hetkel ei oska öelda, ma hiljem annan teada.\nMarek ja Siim vaatavad imestunud nägudega Artjomi poole, kui ta jalutab ära õpetajate toa poole.\n");
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

                //1 päev
                TypewriteWhite("Käes on 31.detsember.\n\nArtjom on õhtupoolikul poe ees, sest tema ema palus, et ta ostaks koju süüa ja juua. \nTeed takistab must BMW E39, autost astuvad välja Marek ja Siim ning küsivad: ");
                Valik2:
                Console.WriteLine("\nMarek ja Siim: No Artjom, mida sa ära otsustasid? Kas tuled siis või ei?\n[Jah/Ei]");
                String Vastus420 = Console.ReadLine();
                Console.Clear();
                if (Vastus420 == "jah" | Vastus420 == "Jah" | Vastus420 == "Tulen" | Vastus420 == "tulen")
                {
                    TypewriteWhite("Marek kutsub Artjomi autosse, Artjom istub ning nad sõidavad peo poole, jutustades elust enesest.");
                }
                else if (Vastus420 == "Ei" | Vastus420 == "ei" | Vastus420 == "ei tule" | Vastus420 == "Ei tule")
                {
                    TypewriteWhite("Siim läheb närvi mille peale Artjom siiski istub autosse");
                }
                else
                {
                    Console.WriteLine("Sellist valikut ei ole, proovi uuesti.");
                    goto Valik2;
                }

                TypewriteWhite("\nPeol märkab Artjom, et seal on palju tundmatuid nägusid, kuid suuremad grupid ikkagi suhtlevad pigem üksteise vahel \nkui kellegi teisega. Artjom läheb elutuppa otsima endale juua, teel sinna märkab ta pikka, blondi noormeest,\nkes märkab ka Artjomi ning suundub tema poole ning ütleb:\n\n" +
                    "Dimitri: " +
                    "Tervist, tundud uus olevat. Olen Dimitri.\n" +
                    "Artjom: " +
                    "Kolisin hiljuti alles Kohtla-Järvele seega olen üsna uus, olen Artjom muidu.\n" +
                    "Dimitri: " +
                    "Aa, sina oledki see Artjom keda Marek mulle mõned päevad tagasi mainis?\n" +
                    "Artjom: " +
                    "Vist jah, ega sa muidu ei tea juhuslikult, kes seda pidu korraldab?\n" +
                    "Dimitri: " +
                    "See ongi minu pidu, tahad midagi juua või oled kainekas?\n" +
                    "Artjom: " +
                    "Ma ei tea.. ma pole varem joonud.\n" +
                    "Dimitri: " +
                    "Tohoh, seda annab küll muuta. Tule minu järgi kööki, tutvustan sulle paari inimest.\n\nArtjom ja Dimitri seavad sammud köögi suunas, köögis märkavad nad, et õllekasti kõrval seisavad kaks noormeest ja üks tüdruk.\nArtjom ja Dimitri lähevad nende juurde ning hakkavad vestlema:\n" +
                    "Dimitri: " +
                    "Vaadake kutid kelle ma leidsin, see on Artjom. Kutt kolis alles hiljuti Kohtla-Järvele seega võtke rahulikult.\n" +
                    "Dimitri: " +
                    "Aga sellepeale me ju võtame?\n" +
                    "Peeter: " +
                    "Muidugi võtame.\n" +
                    "Tanja: " +
                    "Kutid võtke nüüd rahulikult\n" +
                    "Kutid: " +
                    "võtame võtame..");
                Valik3:
                Console.WriteLine("\nTanja: Artjom kas sa tobi tahad?\n[Tahan/Ei taha]");
                String Vastus1337 = Console.ReadLine();

                if (Vastus1337 == "Tahan" | Vastus1337 == "tahan")
                {
                    Console.Clear();
                    Console.WriteLine("Te valiste: Tahan");
                    TypewriteWhite("\nArtjom paneb suitsu põlema ning hakkab seda rahulikult tõmbama.");
                }
                else if (Vastus1337 == "ei taha" | Vastus1337 == "Ei taha")
                {
                    Console.Clear();
                    Console.WriteLine("Te valisite: Ei taha");
                    TypewriteWhite("\nVaatamata Artjomi soovidest, surutakse talle ikka tobi ette ning ta hakkab seda kimudes köhima.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sellist valikut ei ole, proovi uuesti.");
                    goto Valik3;
                }

                TypewriteWhite("\nKui Artjom suitsu ära tegi, siis otsustas ta koju magama minna. Soovis sõpradele head aega ja hakkas minema. \nKodus jäi ta koheselt magama.");

                Console.WriteLine("\n\nVajutage enterit, et looga edasi minna.");
                Console.ReadLine();
                Console.Clear();
                Artjom.FreeDay();

                TypewriteWhite("\nArtjom ja Dimitri jalutavad peo poole, mis juba teist nädalat järjest toimub Dimitri pool.\nNad saavad oma pundiga kokku, teretavad üksteist ja on jällegi teel peo poole.\nKohale jõudes teeb Artjom ühe tobi.\nTanja: Sa viimasel ajal suht palju kimund, veits paljuks ei lähe?\nArtjom: Vaevalt.\nDimitri: Õige mees.\nPeeter: Ega las ta teeb kui soovib. Mees teeb mis tahab.\nTanja: Selge, eks ma ise peaks vähem peale tegema ja enda alkohooliga tagasi hoidma.\nVladimir: Sa peaks juba võõrutusravi saama.\nTanja: Jää vait...\n ");
                TypewriteWhite("\nVajutage enterit, et looga edasi minna.");
                Console.ReadKey();
                Console.Clear();
                Valik4:
                TypewriteWhite("Tanja ja Vladimir jäävad kaklema üksteise vahel, neid lahutab Vitja,Tanja poisssõber.\nSamal ajal Peeter läheb toob joogid, Dimitri ja Artjom lähevad tuppa.\nDimitri võtab taskust tableti ja küsib:\nDimitri: Tahad? Teeb su tuju paremaks.\nArtjom: Ei soovi väga, mul praegugi hea olla.\nDimitri: Aga mis siis kui joogiga pakun?\n[Tahan/Ei taha]\n");
                String Vastus69 = Console.ReadLine();
                
                if (Vastus69 == "tahan" | Vastus69 == "Tahan")
                {
                    Console.Clear();
                    TypewriteWhite("Teie valik: Jah\n");
                    TypewriteWhite("\nDimitri: Vot seda ma arvasingi, sa oled ikka normaalne kutt.");
                    TypewriteWhite("\nPeale tableti võtmist langeb Artjom põlvili ning hakkab tundma end imelikult,\nsilme eest läheb korraks mustaks ning tagasi tulles näeb Artjom rusikat enda poole lendamas.\nLäheb kakluseks.");
                }
                else if (Vastus69 == "ei taha" | Vastus69 == "Ei taha")
                {
                    Console.Clear();
                    TypewriteWhite("\nTeie valik: Ei");
                    TypewriteWhite("Einoh, vähemalt võta siis juua.");
                    TypewriteWhite("\nPeale joogi joomist võtmist langeb Artjom põlvili ning hakkab tundma end imelikult,\nsilme eest läheb korraks mustaks ning tagasi tulles näeb Artjom rusikat enda poole lendamas.\nLäheb kakluseks.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nSellist valikut ei ole, proovi uuesti.");
                    goto Valik4;
                }
                Valik5:
                TypewriteWhite("\nArtjom: Nahui sa mulle sisse lendad?\nVitja: Türa sa seleted?\nVitja: Vaatan, et oled suht äratõusnud juba, sulle tuleks küll viisakalt molli kütta.\nArtjom: Aga äkki tegutsed ka siis või oled niisama jutumees?\nVitja: Aga näita parem ise? Põrkad pidevalt aga võiksid ise ka tegudeni jõuda.");
                TypewriteWhite("\n\n[Löön/Ei löö]\n");
                string action = Console.ReadLine();

                if (action == "Löön"|action == "löön")
                {
                    Console.Clear();
                    Console.WriteLine("Te valisite: Löön");
                    TypewriteWhite("\nArtjom lööb Vitjat korduvalt näkku ning Vitja kukub põrandale pikali.");
                    Valik6:
                    TypewriteWhite("\nTuppa tuleb peeter, kes korraks jälgib toimunut ja siis sähvatab:\nPeeter: Mida vittu sa korraldad Artjom? Putsi pean sind samamoodi kasti taguma?\nArtjom: Mille pärast?\nPeeter: Tra vaata mida sa Vitjaga tegid, ta on mu parim sõber.\n[Jooksen/löön]\n");
                    string action2 = Console.ReadLine();

                    if (action2 == "Jooksen" | action2 == "jooksen")
                    {
                        Console.Clear();
                        Console.WriteLine("Te valisite: Jooksen");
                        TypewriteWhite("\nArtjom jookseb ära, vältides Peetriga kaklust.");
                        TypewriteWhite("\nArtjom leidis, et ta on väsinud ning seadis sammud kodu poole.");
                    }
                    else if (action2 == "Löön" | action2 == "löön")
                    {
                        Console.Clear();
                        Console.WriteLine("Te valisite: Löön");
                        TypewriteWhite("\nArtjom võtab lauapealt veinipudeli ning lööb selle kõvasti vastu Peetri pead.");
                        TypewriteWhite("\nPeeter kukub põrandale pikali.\nArtjom satub paanikasse ning otsustab, et mõistlik oleks kiiremas korras jalga lasta.\nArtjom seadis sammud kodupoole.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Sellist valikut ei ole, proovi uuesti.\n");
                        goto Valik6;
                    }
                
                }
                else if (action == "Ei löö"| action == "ei löö")
                {
                    Console.Clear();
                    Console.WriteLine("Te valisite: Ei löö");
                    TypewriteWhite("\nPeeter tuleb karjumise peale tuppa ning hakkab Artjomi ning Vitjat lepitama.\n\n[Õnnestub/Ei õnnestu]");
                    string action3 = Console.ReadLine();

                        if (action3 == "Õnnestub" |action3 == "õnnestub")
                        {
                        TypewriteWhite("\nArtjom ning Vitja suruvad kätt ja Artjom seab sammud kodupoole");
                        }
                        else if (action3 == "Ei õnnestu" | action3 == "ei õnnestu")
                        {
                        TypewriteWhite("\nPeeter palub Artjomil kodu poole sammud seada, mida ka Artjom teeb\n\nVajutage enterit, et looga edasi minna.");
                        Console.ReadLine();
                        }

                    //6 päev
                    Console.Clear();
                    Valik6:
                    TypewriteWhite("Kell on 5.42 ning Dimitri helistab\n\nDimitri: Artjom sa pead mind aitama, ma olen suures pasas!\nArtjom: Kuidas? Millega?\nDimitri: Pole tähtis aga, kas sa saad mind aidata?\n[Aitan/Ei aita]\n");
                    string action4 = Console.ReadLine();

                    if(action4 == "Aitan"| action4 == "aitan")
                    {
                        Console.Clear();
                        Console.WriteLine("Te valisite: Aitan");
                        TypewriteWhite("\nArtjom: Kus sa oled?!\nDimitri: Vanas tehases ja kutsu Vladimir ka.\nArtjom: Okei, ma kohe tulen.\n Vajutage enterit, et looga edasi minna.");
                        Console.ReadLine();
                        Console.WriteLine("-15 min hiljem jõuab Artjom Vladimiri ukse ette-");
                        TypewriteWhite("\nArtjom: Laseb uske kella\nArtjom: Mina Artjom, Dimitril on meie abi vaja.\nVladimir avab ukse ning kutsub teda sisse.\nArtjom: Ta jättis mulje, et ta on suures pasas!\nVladimir: Tule kaasa.\n");
                        TypewriteWhite("Artjom ja Vladimir lähevad alla keldrisse. Vladimir avab suure metallist kapi.\nArtjom: See on väga suur kogus relvi! \nVladimir võtab relva ja sihib Artjomi\nArtjom: Segane oled?\nVladimir: Kas sa lubad, et ei räägi kellegile? \nArtjom: Muidugi luban! \nVladimir: Väga hea, vali siit midagi mis sulle meeldib.\nArtjom: Miks?! \nVladimir: Kuna me lähme kohe Dimitrit päästma.\nArtjom: Mida ?!\nVladimir: Sa kuulsid küll, vali nüüd!\nArtjom valib relva\nVladimir: Väga hea, polnud nii raske!\n\nNad lahkuvad keldrist ning suunduvad vana tehase poole");

                    }
                    else if(action4 == "Ei aita" | action4 == "ei aita")
                    {
                        // Tekst/Tegevus puudu. 
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Sellist valikut ei ole, proovi uuesti.\n");
                        goto Valik6;
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sellist valikut ei ole, proovi uuesti.\n");
                    goto Valik5;
                }
            }
            else if (ValikMenu == 2)
            {
                Console.Clear();
                TypewriteWhite("Meie mäng räägib ühest 9nda klassi poisist, kes kolib Kohtla-Järvele ning satub selletõttu halba seltskonda.\nMängu käigus käsitleme Artjomi elukäiku, mis muutub iga päevaga aina halvemaks.\n\n(Vajutage Enterit Main Menule naasemiseks)");
                Console.ReadLine();
                Console.Clear();
                goto Start;
            }
            else if (ValikMenu == 3)
            {
                Console.Clear();
                TypewriteWhite("Selle mängu tegemisse panustasid:\nKenno Pajunurm\nPatrick Teivas\nKen Liit\nMait Rappu\n\n(Vajutage Enterit Main Menule naasemiseks)");
                Console.ReadLine();
                Console.Clear();
                goto Start;
            }
            else if (ValikMenu == 4)
            {
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sellist valikut ei ole, proovi uuesti.\n");
                goto Start;
            }
            Console.WriteLine("\nProgramm lõpetas töö."); 
        }

        static void TypewriteWhite(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;

            int a = 50;
            for (int i = 0; i < message.Length; i++)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter) a = 00;
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(a);
                
            }
        }

        static void TypewriteRed(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;

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