using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Music
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Music.wav");
            Console.WriteLine(player.SoundLocation);
            player.PlayLooping();
            Console.Clear();
            bool Start = true;
            while (Start == true)
            {
                Start = false;
                //Menu
                Console.WriteLine("---Menu---\n(1) Play\n(2) About\n(3) Credits\n(4) Exit");
                string ValikMenu228 = Console.ReadLine();
                int ValikMenu;
                bool Kontroll = int.TryParse(ValikMenu228, out ValikMenu);

                if (Kontroll == false)
                {
                    Console.Clear();
                    Console.WriteLine("Sellist valikut ei ole, proovi uuesti.\n");
                    Start = true;
                }
                else
                {
                    if (ValikMenu == 1) //Sissejuhatus
                    {
                        var Artjom = new BattleSystem();
                        Artjom.Money = 100;
                        Artjom.Karma = 0;
                        Artjom.Lucky = 0;

                        Console.Clear();
                        BattleSystem.Typewrite("Edaspidised valikud muudavad sinu mängukäiku!\n\nSinu tegelaseks on üheksanda klassi õpilane Artjom, kes hiljuti kolis Ida-Virumaale, Kohtla-Järvele. \nSul oli eelmises linnas trenn, mis sulle väga meeldis, kuid uues linnas sellist trenni ei ole,\nning nüüd pead sa otsima uue treeninguala millega sa tegelema soovid hakata.");
                        bool Valik = true;
                        while (Valik == true)
                        {
                            Valik = false;
                            Console.WriteLine("\n\nPeate valima oma uue treeninguala:\n(1) Poks \n(2) Jalgpall \n(3) Iluuisutamine ");
                            string trgAla2 = Console.ReadLine();
                            int trgAla;
                            bool Kontroll2 = int.TryParse(trgAla2, out trgAla);

                            if (Kontroll2 == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Sellist valikut ei ole, proovi uuesti.\n");
                                Valik = true;
                            }
                            else
                            {
                                if (trgAla == 1) //Poks
                                {
                                    Artjom.Agility = 75;
                                    Artjom.Stamina = 80;
                                    Artjom.Respect = 80;
                                    Console.Clear();
                                    Console.WriteLine("Te valisite: Poksi");

                                    BattleSystem.Typewrite("\nArtjom on sõbrunenud oma uue klassiga väga hästi, kuid tal ei olnud tulevasel \nvanaaasta õhtul mitte midagi teha. \n\nArtjom ärkab üles ja seab end valmis kooli minema 28. detsembri hommikul. \nKoolis teel õpetajate tuppa, kus Artjom soovis klassijuhatajaga rääkida kohtab Artjom kahte klassivenda.\nArtjomi klassivennad Marek ja Siim märkavad teda ning suunduvad kiiresti tema poole: \n\nMarek ja Siim: Kuule, Artjom.\nArtjom: Jah?\nMarek ja Siim: Plaanid klassipeole tulla ka või? Polegi näinud sind varem pidudel.\nArtjom: Peole? Ma pole isegi kutset saanud.\nMarek ja Siim: Kas sa oled endaarust nii eriline, et väärid eraldi kutset? See on avatud pidu mees.\nArtjom: Aaa.. ma arvasin, et see on kinnine pidu.\nMarek ja Siim: Vahet pole mees, kas sa tuled siis või ei?\nArtjom: Võib-olla, ma hetkel ei oska öelda, ma hiljem annan teada.\nMarek ja Siim vaatavad imestunud nägudega Artjomi poole, kui ta jalutab ära õpetajate toa poole.\n");
                                }
                                else if (trgAla == 2) //Jalgpall
                                {
                                    Artjom.Agility = 50;
                                    Artjom.Stamina = 80;
                                    Artjom.Respect = 60;
                                    Console.Clear();
                                    Console.WriteLine("Te valisite: Jalgpalli");

                                    BattleSystem.Typewrite("\nArtjom oli üsnagi sotsiaalne oma eelmises koolis, aga peale kuu aega olles Kohtla-Järvel, \nei ole ta sõbrunenud uue klassiga terviklikult ning sellepärast ei olnud tal tulevasel \nvanaaasta õhtul mitte midagi plaanis. \n\nArtjom ärkab üles ja seab end valmis kooli minema 28. detsembri hommikul. \nKoolis teel õpetajate tuppa, kus Artjom soovis klassijuhatajaga rääkida kohtab Artjom kahte klassivenda.\nArtjomi klassivennad Marek ja Siim märkavad teda ning suunduvad kiiresti tema poole: \n\nMarek ja Siim: Kuule, Artjom.\nArtjom: Jah?\nMarek ja Siim: Plaanid Siimu poole peole tulla ka või? Polegi näinud sind varem pidudel.\nArtjom: Peole? Ma pole isegi kutset saanud.\nMarek ja Siim: Kas sa oled endaarust nii eriline, et väärid eraldi kutset? See on avatud pidu mees.\nArtjom: Aaa.. ma arvasin, et see on kinnine pidu\nMarek ja Siim: Vahet pole mees, kas sa tuled siis või ei?\nArtjom: Võib-olla, ma hetkel ei oska öelda, ma hiljem annan teada.\nMarek ja Siim vaatavad imestunud nägudega Artjomi poole, kui ta jalutab ära õpetajate toa poole.\n");
                                }
                                else if (trgAla == 3) //Iluuisutamine
                                {
                                    Artjom.Agility = 60;
                                    Artjom.Stamina = 30;
                                    Artjom.Respect = -40;
                                    Console.Clear();
                                    Console.WriteLine("Te valisite: Iluuisutamise");

                                    BattleSystem.Typewrite("\nArtjom oli üsnagi sotsiaalne oma eelmises koolis, aga peale kuu aega olles Kohtla-Järvel,\ntundis Artjom, et tema uus klass väldib teda ning sellepärast ei olnud tal tulevasel \nvanaaasta õhtul mitte midagi teha. \n\nArtjom ärkab üles ja seab end valmis kooli minema 28. detsembri hommikul. \nKoolis teel õpetajate tuppa, kus Artjom soovis klassijuhatajaga rääkida kohtab Artjom kahte klassivenda.\nArtjomi klassivennad Marek ja Siim märkavad teda ning suunduvad kiiresti tema poole: \n\nMarek ja Siim: Kuule, Artjom.\nArtjom: Jah?\nMarek ja Siim: Plaanid Siimu poole peole tulla ka või? Polegi näinud sind varem pidudel.\nArtjom: Peole? Ma pole isegi kutset saanud.\nMarek ja Siim: Kas sa oled endaarust nii eriline, et väärid eraldi kutset? See on avatud pidu mees.\nArtjom: Aaa.. ma arvasin, et see on kinnine pidu\nMarek ja Siim: Vahet pole mees, kas sa tuled siis või ei?\nArtjom: Võib-olla, ma hetkel ei oska öelda, ma hiljem annan teada.\nMarek ja Siim vaatavad imestunud nägudega Artjomi poole, kui ta jalutab ära õpetajate toa poole.\n");
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Sellist valikut ei ole, proovi uuesti.");
                                    Valik = true;
                                }
                            }
                        }

                        Console.WriteLine("\nVajutage enterit, et looga edasi minna.");
                        Console.ReadKey();
                        Console.Clear();

                        //1 päev
                        BattleSystem.Typewrite("Käes on 31.detsember.\n\nArtjom on õhtupoolikul poe ees, sest tema ema palus, et ta ostaks koju süüa ja juua. \nTeed takistab must BMW E39, autost astuvad välja Marek ja Siim ning küsivad: ");
                        bool Valik2 = true;
                        while (Valik2 == true)
                        {
                            Valik2 = false;
                            Console.WriteLine("\nMarek ja Siim: No Artjom, mida sa ära otsustasid? Kas tuled siis või ei?\n[Jah/Ei]");
                            string Vastus420 = Console.ReadLine().ToLower();
                            Console.Clear();
                            if (Vastus420 == "jah" || Vastus420 == "tulen")
                            {
                                BattleSystem.Typewrite("Marek kutsub Artjomi autosse, Artjom istub ning nad sõidavad peo poole, jutustades elust enesest.");
                            }
                            else if (Vastus420 == "ei" || Vastus420 == "ei tule")
                            {
                                BattleSystem.Typewrite("Siim läheb närvi mille peale Artjom siiski istub autosse");
                            }
                            else
                            {
                                Console.WriteLine("Sellist valikut ei ole, proovi uuesti.");
                                Valik2 = true;
                            }
                        }

                        BattleSystem.Typewrite("\nPeol märkab Artjom, et seal on palju tundmatuid nägusid, kuid suuremad grupid ikkagi suhtlevad pigem üksteise vahel \nkui kellegi teisega. Artjom läheb elutuppa otsima endale juua, teel sinna märkab ta pikka, blondi noormeest,\nkes märkab ka Artjomi ning suundub tema poole ja ütleb:\n\nDimitri: Tervist, tundud uus olevat. Olen Dimitri.\nArtjom: Kolisin hiljuti alles Kohtla-Järvele seega olen üsna uus, olen Artjom muidu.\nDimitri: Aa, sina oledki see Artjom keda Marek mulle mõned päevad tagasi mainis?\nArtjom: Vist jah, ega sa muidu ei tea juhuslikult, kes seda pidu korraldab?\nDimitri: See ongi minu pidu, tahad midagi juua või oled kainekas?\nArtjom: Ma ei tea.. ma pole varem joonud.\nDimitri: Tohoh, seda annab küll parandada. Tule minu järgi kööki, tutvustan sulle paari inimest.\n\nArtjom ja Dimitri seavad sammud köögi suunas, köögis märkavad nad, et õllekasti kõrval seisavad kaks noormeest ja üks tüdruk.\nArtjom ja Dimitri lähevad nende juurde ning hakkavad vestlema:\nDimitri: Vaadake kutid kelle ma leidsin, see on Artjom. Kutt kolis alles hiljuti Kohtla-Järvele seega võtke rahulikult.\nDimitri: Aga sellepeale me ju võtame?\nPeeter: Muidugi võtame.\nTanja: Kutid võtke nüüd rahulikult\nKutid: võtame võtame..");
                        bool Valik3 = true;
                        while (Valik3 == true)
                        {
                            Valik3 = false;
                            Console.WriteLine("\nTanja: Artjom kas sa tobi tahad?\n[Tahan/Ei taha]");
                            string Vastus1337 = Console.ReadLine().ToLower();

                            if (Vastus1337 == "tahan")
                            {
                                Console.Clear();
                                Console.WriteLine("Te valiste: Tahan");
                                BattleSystem.Typewrite("\nArtjom paneb suitsu põlema ning hakkab seda rahulikult tõmbama.");
                            }
                            else if (Vastus1337 == "ei taha")
                            {
                                Console.Clear();
                                Console.WriteLine("Te valisite: Ei taha");
                                BattleSystem.Typewrite("\nVaatamata Artjomi soovidest, surutakse talle ikka tobi ette ning ta hakkab seda kimudes köhima.");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Sellist valikut ei ole, proovi uuesti.");
                                Valik3 = true;
                            }
                        }

                        BattleSystem.Typewrite("\nKui Artjom suitsu ära tegi, siis otsustas ta koju magama minna. Soovis sõpradele head aega ja hakkas minema. \nKodus jäi ta koheselt magama.");

                        Console.WriteLine("\n\nVajutage enterit, et looga edasi minna.");
                        Console.ReadLine();
                        Console.Clear();
                        //3 päev
                        Artjom.FreeDay();

                        //4 päev
                        BattleSystem.Typewrite("Artjom ja Dimitri jalutavad peo poole, mis juba teist nädalat järjest toimub Dimitri pool.\nNad saavad oma pundiga kokku, teretavad üksteist ja on jällegi teel peo poole.\nKohale jõudes teeb Artjom ühe tobi.\n\nTanja: Sa viimasel ajal suht palju kimunud, veits paljuks ei lähe?\nArtjom: Vaevalt.\nDimitri: Õige, las mees teeb mida mees tahab.\nPeeter: Ega las ta teeb kui soovib. Suur mees ikkagi.\nTanja: Selge, eks ma ise peaks kah rohkem ennast vaatama.\nVladimir: Sa peaks juba võõrutusravi saama.\nTanja: Jää vait...\n ");
                        Console.WriteLine("\nVajutage enterit, et looga edasi minna.");
                        Console.ReadKey();
                        Console.Clear();
                        bool Valik4 = true;
                        while (Valik4 == true)
                        {
                            Valik4 = false;
                            BattleSystem.Typewrite("Tanja ja Vladimir jäävad vaidlema üksteise vahel, neid lahutab Vitja, Tanja poisssõber.\nSamal ajal Peeter läheb toob joogid, Dimitri ja Artjom lähevad tuppa.\n\nDimitri võtab taskust tableti ja küsib:\nDimitri: Tahad? Teeb su tuju paremaks.\nArtjom: Ei soovi väga, mul praegugi hea olla.\nDimitri: Kindel, et ei taha?\n[Tahan/Ei taha]\n");
                            string Vastus69 = Console.ReadLine().ToLower();

                            if (Vastus69 == "tahan")
                            {
                                Console.Clear();
                                Console.WriteLine("Teie valik: Tahan\n");
                                BattleSystem.Typewrite("\nDimitri: Vot seda ma arvasingi, sa oled ikka normaalne kutt.");
                                BattleSystem.Typewrite("\nPeale tableti võtmist langeb Artjom põlvili ning hakkab tundma end imelikult,\nsilme eest läheb hetkeks mustaks ning tagasi tulles tunneb Artjom tugevat valu arvates, et Vitja lõi tal pildi tasku.\nLäheb kakluseks.");
                            }
                            else if (Vastus69 == "ei taha")
                            {
                                Console.Clear();
                                Console.WriteLine("\nTeie valik: Ei taha");
                                BattleSystem.Typewrite(" \nDimitri: Einoh, vähemalt võta siis juua.");
                                BattleSystem.Typewrite("\nPeale joogi joomist võtmist langeb Artjom põlvili ning hakkab tundma end imelikult,\nsilme eest läheb hetkeks mustaks ning tagasi tulles tunneb Artjom tugevat valu arvates, et Vitja lõi tal pildi tasku.\nLäheb kakluseks.");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\nSellist valikut ei ole, proovi uuesti.");
                                Valik4 = true;
                            }
                        }

                        BattleSystem.Typewrite("\nArtjom: Nahui sa mulle sisse lendasid?\nVitja: Türa sa seleted?\nVitja: Vaatan, et oled suht äratõusnud juba, sulle tuleks küll viisakalt molli kütta.\nArtjom: Aga äkki tegutsed ka siis või oled niisama jutumees?\nVitja: Aga näita parem ise? Põrkad pidevalt aga võiksid ise ka tegudeni jõuda.");
                        bool Valik5 = true;
                        while (Valik5 == true)
                        {
                            Valik5 = false;
                            BattleSystem.Typewrite("\n\n[Löön/Ei löö]\n");
                            string action = Console.ReadLine().ToLower();

                            if (action == "löön")
                            {
                                Console.Clear();
                                Console.WriteLine("Te valisite: Löön");
                                BattleSystem.Typewrite("\nArtjom lööb Vitjat korduvalt näkku ning Vitja kukub põrandale pikali.");
                                bool Valik7 = true;
                                while (Valik7 == true)
                                {
                                    Valik7 = false;
                                    BattleSystem.Typewrite("\nTuppa tuleb peeter, kes korraks jälgib toimunut ja siis sähvatab:\nPeeter: Mida vittu sa korraldad Artjom? Putsi pean sind samamoodi kasti taguma?\nArtjom: Mille pärast?\nPeeter: Tra vaata mida sa Vitjaga tegid, ta on mu parim sõber.\n[Jooksen/Löön]\n");
                                    string action2 = Console.ReadLine().ToLower();

                                    if (action2 == "jooksen")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Te valisite: Jooksen");
                                        BattleSystem.Typewrite("\nArtjom jookseb ära, vältides Peetriga kaklust.");
                                        BattleSystem.Typewrite("\nArtjom leidis, et ta on väsinud ning seadis sammud kodu poole.");
                                    }
                                    else if (action2 == "löön")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Te valisite: Löön");
                                        BattleSystem.Typewrite("\nArtjom võtab lauapealt veinipudeli ning lööb selle kõvasti vastu Peetri pead.");
                                        BattleSystem.Typewrite("\nPeeter kukub põrandale pikali.\nArtjom satub paanikasse ning otsustab, et mõistlik oleks kiiremas korras jalga lasta.\nArtjom seadis sammud kodupoole.");
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Sellist valikut ei ole, proovi uuesti.\n");
                                        Valik7 = true;
                                    }
                                }
                            }
                            else if (action == "ei löö")
                            {
                                Console.Clear();
                                Console.WriteLine("Te valisite: Ei löö");
                                bool Valik7 = true;
                                while (Valik7 == true)
                                {
                                    Valik7 = false;
                                    BattleSystem.Typewrite("\nPeeter tuleb karjumise peale tuppa ning hakkab Artjomi ning Vitjat lepitama.\n\n[Õnnestub/Ei õnnestu]\n");
                                    string action3 = Console.ReadLine().ToLower();

                                    if (action3 == "õnnestub")
                                    {
                                        BattleSystem.Typewrite("Artjom ning Vitja suruvad kätt ja Artjom seab sammud kodupoole");
                                    }
                                    else if (action3 == "ei õnnestu")
                                    {
                                        BattleSystem.Typewrite("Peeter palub Artjomil kodu poole sammud seada, mida ka Artjom teeb\n\nVajutage enterit, et looga edasi minna.");
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Sellist valikut ei ole, proovi uuesti.");
                                        Valik7 = true;
                                    }
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Sellist valikut ei ole, proovi uuesti.\n");
                                Valik5 = true;
                            }
                        }

                        //5 päev (Freeday)
                        Console.Clear();
                        Artjom.Freeday1();

                        //6 päev
                        Console.Clear();

                        BattleSystem.Typewrite("Kell on 5:42 ning Dimitri helistab\n\nDimitri: Artjom sa pead mind aitama, ma olen suures pasas!\nArtjom: Kuidas? Millega?\nDimitri: Pole tähtis aga, kas sa saad mind aidata?\nArtjom: Jah muidugi ma aitan!\n");
                        BattleSystem.Typewrite("\nArtjom: Kus sa oled?!\nDimitri: Vanas tehases ja kutsu Vladimir ka.\nArtjom: Okei, ma kohe tulen.");
                        Console.WriteLine("\n\n-15 min hiljem jõuab Artjom Vladimiri ukse ette-");
                        BattleSystem.Typewrite("\nArtjom: Laseb uske kella\nArtjom: Mina Artjom, Dimitril on meie abi vaja.\nVladimir avab ukse ning kutsub teda sisse.\nArtjom: Ta jättis mulje, et ta on suures pasas!\nVladimir: Tule kaasa.\n");
                        BattleSystem.Typewrite("Artjom ja Vladimir lähevad alla keldrisse. Vladimir avab suure metallist kapi.\nArtjom: See on väga suur kogus relvi! \nVladimir võtab relva ja sihib Artjomi\nArtjom: Segane oled?\nVladimir: Kas sa lubad, et ei räägi kellelegi? \nArtjom: Muidugi luban! \nVladimir: Väga hea, vali siit midagi mis sulle meeldib.\nArtjom: Miks?! \nVladimir: Kuna me lähme kohe Dimitrit päästma.\nArtjom: Mida ?!\nVladimir: Sa kuulsid küll, vali nüüd!\nArtjom valib relva\nVladimir: Väga hea, polnud nii raske!\n\nNad lahkuvad keldrist ning suunduvad Vladimiri autoga vana tehase poole");
                        Console.WriteLine("\nVajutage enterit, et looga edasi minna.");
                        Console.ReadKey();
                        Console.Clear();
                        bool Valik6 = true;
                        while (Valik6 == true)
                        {
                            Valik6 = false;
                            BattleSystem.Typewrite("Tehase ees näevad nad Dimitrit kahtlaste kuttidega.\nDimitri märkab Artjomi ning Vladimirit, ning hakkab hüsteeriliselt nende poole jooksma.\nVladimir märkab Dimitri žeste vihjates, et ta vajab relva ning ta vajab seda kiiresti.\nArtjom ning Vladimir katavad ennast auto taha, et tulevaste kuulide eest ennast kaitsta sama teeb ka Dimitri, kes peidab ennast seina taha.\n(1) Tulista auto tagant\n(2) Põgene\n(3) Ürita Dimitri poole joosta\n");
                            string valik228 = Console.ReadLine();
                            int valik;
                            bool Kontroll322 = int.TryParse(valik228, out valik);

                            if (Kontroll == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Sellist valikut ei ole, proovi uuesti.\n");
                                Valik6 = true;
                            }
                            else
                            {
                                if (valik == 1)
                                {
                                    BattleSystem.Typewrite("\nArtjom ning Vladimir tapavad tulevahetuses kaks inimest kolmest, kolmas mees põgenes. \nDimitrist saab kriminaalse grupeeringu juht ning Artjom hakkab tema jaoks töötama. \nGame Over.");
                                }
                                else if (valik == 2)
                                {
                                    BattleSystem.Typewrite("\nArtjom ning Vladimir üritavad põgeneda, kuid mõlemad hukkuvad tugeva verejooksu tagajärjel. \nGame Over.");
                                }
                                else if (valik == 3)
                                {
                                    BattleSystem.Typewrite("\nArtjom saab Dimitri poole joostes tugevalt vigastada, talle järgnes Vladimir kes hukkus jooksmise käigus.\nGame Over. ");
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Sellist valikut ei ole");
                                    Valik6 = true;
                                }
                            }
                        }
                    }
                    else if (ValikMenu == 2)
                    {
                        Console.Clear();
                        BattleSystem.Typewrite("Meie mäng räägib ühest 9nda klassi poisist, kes kolib Kohtla-Järvele ning satub selletõttu halba seltskonda.\nMängu käigus käsitleme Artjomi elukäiku, mis muutub iga päevaga aina halvemaks.\n\n(Vajutage Enterit Main Menule naasemiseks)");
                        Console.ReadLine();
                        Console.Clear();
                        Start = true;
                    }
                    else if (ValikMenu == 3)
                    {
                        Console.Clear();
                        BattleSystem.Typewrite("Selle mängu tegemisse panustasid:\nKenno Pajunurm\nPatrick Teivas\nKen Liit\nMait Rappu\n\n(Vajutage Enterit Main Menule naasemiseks)");
                        Console.ReadLine();
                        Console.Clear();
                        Start = true;
                    }
                    else if (ValikMenu == 4)
                    {
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Sellist valikut ei ole, proovi uuesti.\n");
                        Start = true;
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("Programm lõpetas töö.\n");
        }
    }
}