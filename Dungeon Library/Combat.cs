using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using DungeonLibrary;
using Dungeon_Library;
using System.Security.Cryptography;

namespace Dungeon_Library
{
    public class Combat
    {
        public static void DoAttack(Character attacker, Character defender)
        {
            Random rand = new Random();
            int roll = rand.Next(1, 101);

            Thread.Sleep(100);
            if (attacker.Race.RaceType == RaceType.Merfolk && defender.Race.RaceType == RaceType.Merfolk)
            {
                attacker.HitChance = 100;
                attacker.Block = 0;
                defender.HitChance = 100;
                defender.Block= 0;
            }
            //if the attacker hits
            if (roll <= (attacker.CalcHitChance()))
            {
                int attackedFor = attacker.CalcDamage();
                int damageBlocked = defender.CalcBlock();
                int damageDealt = attackedFor - damageBlocked;
                int lifeLinked = 0;

                if (defender.Race.RaceType == RaceType.Zombie)
                {
                    defender.Life -= 1;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{attacker.Name} severed a limb!\n");
                }
                else if (attacker.Race.RaceType == RaceType.Vampire)
                {
                    defender.Life -= damageDealt;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{attacker.Name} attacked for {attackedFor}!");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"{defender.Name} blocked {damageBlocked} damage!");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{defender.Name} takes {damageDealt} damage!");
                    lifeLinked = damageDealt / 10;
                    attacker.Life += lifeLinked;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{attacker.Name} gains {lifeLinked} life from lifelink!\n");
                    Console.ResetColor();
                }
                else
                {
                    defender.Life -= damageDealt;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{attacker.Name} attacked for {attackedFor}!");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"{defender.Name} blocked {damageBlocked} damage!");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{defender.Name} takes {damageDealt} damage!\n");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("{0} missed!\n", attacker.Name);
            }
        }//end DoAttack()



        public static void DoBattle(Player player, Monster monster)
        {
            if (player.EquippedWeapon.Name == "Assassin's Daggers" || player.EquippedWeapon.Name == "Shadowstep Daggers")
            {
                if (monster.Race.RaceType == RaceType.Goblin)
                {
                    DoAttack(monster, player);

                    if (player.Life > 0)
                    {
                        DoAttack(player, monster);
                        if (monster.Life <= 0)
                        {

                        }
                        else
                        {
                            DoAttack(player, monster);
                        }
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"{player.Name} has {player.Life} life remaining, out of {player.MaxLife} maximum life!");
                    }
                    if (monster.Life > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"{monster.Name} has {monster.Life} life remaining, out of {monster.MaxLife} maximum life!");
                    }
                    if (player.Life <= 0)
                    {
                        Console.WriteLine($"{player.Name} has died!");
                    }
                    Console.ResetColor();
                }//end if checking goblin
                else
                {
                    DoAttack(player, monster);
                    if (monster.Life <= 0)
                    {

                    }
                    else
                    {
                        DoAttack(player, monster);
                    }
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
                        if (monster.Race.RaceType == RaceType.Zombie)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"{monster.Name} has {monster.Life} limbs remaining, out of {monster.MaxLife} maximum limbs!");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"{monster.Name} has {monster.Life} life remaining, out of {monster.MaxLife} maximum life!");
                        }
                    }
                    Console.ResetColor();
                }//end Else Race Check
            }//end Dagger Check
            else
            {
                if (monster.Race.RaceType == RaceType.Goblin)
                {
                    DoAttack(monster, player);

                    if (player.Life > 0)
                    {
                        DoAttack(player, monster);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"{player.Name} has {player.Life} life remaining, out of {player.MaxLife} maximum life!");
                    }
                    if (monster.Life > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"{monster.Name} has {monster.Life} life remaining, out of {monster.MaxLife} maximum life!");
                    }
                    if (player.Life <= 0)
                    {
                        Console.WriteLine($"{player.Name} has died!");
                    }
                    Console.ResetColor();
                }//end if checking goblin
                else
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
                        if (monster.Race.RaceType == RaceType.Zombie)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"{monster.Name} has {monster.Life} limbs remaining, out of {monster.MaxLife} maximum limbs!");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"{monster.Name} has {monster.Life} life remaining, out of {monster.MaxLife} maximum life!");
                        }
                    }
                    Console.ResetColor();
                }//end Else Race Check
            }
        }//end of DoBattle()
    }//end combat class
}//end namespace
       