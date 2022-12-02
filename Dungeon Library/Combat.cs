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

            Thread.Sleep(1);//TODO set to 100

            //if the attacker hits
            if (roll <= (attacker.CalcHitChance()))
            {
                int damageDealt = attacker.CalcDamage() - defender.CalcBlock();

                defender.Life -= damageDealt;

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{attacker.Name} attacked for {attacker.CalcDamage()}!");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"{defender.Name} blocked {defender.CalcBlock()} damage!");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{defender.Name} takes {damageDealt} damage!\n");

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
            if (player.Life > 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{player.Name} has {player.Life} life remaining, out of {player.MaxLife} maximum life!");
            }
            else
            {
                Console.WriteLine($"{player.Name} has died!");
            }
            if (monster.Life > 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{monster.Name} has {monster.Life} life remaining, out of {monster.MaxLife} maximum life!");
            }
           
            Console.ResetColor();
        }//end DoBattle

        public static void GoblinBattle(Monster monster, Player player)
        {
            DoAttack(monster, player);

            if (player.Life > 0) 
            { 
                DoAttack(player, monster);
            }
            if (player.Life > 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{player.Name} has {player.Life} life remaining, out of {player.MaxLife} maximum life!");
            }
            if (monster.Life > 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{monster.Name} has {monster.Life} life remaining, out of {monster.MaxLife} maximum life!");
            }
            else
            {
                Console.WriteLine($"{player.Name} has died!");
            }

            Console.ResetColor();
        }
    }
}
