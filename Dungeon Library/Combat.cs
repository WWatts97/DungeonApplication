using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using DungeonLibrary;

namespace Dungeon_Library
{
    public class Combat
    {
        //this is not a datatype class
        //this is a warehouse for methods related to combat

        public static void DoAttack(Character attacker, Character defender)
        {
            Random rand = new Random();
            int roll = rand.Next(1, 101);

            Thread.Sleep(30);

            //if the attacker hits
            if (roll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                int damageDealt = attacker.CalcDamage();

                defender.Life -= damageDealt;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} for {2} damage!",
                    attacker.Name, defender.Name, damageDealt);

                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("{0} missed!",attacker.Name);
            }
        }

        public static void DoBattle(Player player, Monster monster)
        {
            DoAttack(player, monster);

            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }
        }
    }
}
