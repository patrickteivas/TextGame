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
            var user = new Attack();
            user.Agility = 5;
            user.Intelligence = 5;

            int health = 100;
            int mana = 50;
            int stamina = 25;

            int attackdamageMin = user.Agility - 3;
            int attackdamageMax = user.Agility - 1;

            int spelldamage = user.Intelligence + 1;

            int enemyhealth = 50;

            string Health = Convert.ToString(health);
            string Mana = Convert.ToString(mana);
            string Stamina = Convert.ToString(stamina);

            string EnemyHealth = Convert.ToString(enemyhealth);

            Random rnd = new Random();
            
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            while(enemyhealth > 0)
            {
                Console.WriteLine("Choose your action Warrior of Viru:");
                Console.WriteLine("(Stab, Spell, Item, Flee)");

                string action = Console.ReadLine();

                if (action == "Stab")
                {
                    int randomnumber = rnd.Next(1, 100);
                    if (randomnumber <= 50)
                    {
                        enemyhealth = enemyhealth - attackdamageMin;
                        Console.WriteLine(enemyhealth);
                    }
                    {
                        enemyhealth = enemyhealth - attackdamageMax;
                        Console.WriteLine(enemyhealth);
                    }
                }
                if (action == "Spell")
                {
                    int randomnumber = rnd.Next(1, 2);
                    if (randomnumber > 1)
                    {
                        Console.WriteLine("You flung a fireball");
                        enemyhealth = enemyhealth - spelldamage;
                        Console.WriteLine(enemyhealth);
                    }
                    if (randomnumber < 1)
                    {
                        Console.WriteLine("Spell failed.");
                    }
                }



                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
        }
    }
}
