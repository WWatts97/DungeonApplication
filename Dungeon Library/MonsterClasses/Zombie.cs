using Dungeon_Library;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Zombie : Monster
    {
        public bool IsFallingApart { get; set; }

        public Zombie(string name, string description, int maxLife, int life, int hitChance, int block,
                    int maxDmg, int minDmg, Race race, bool isFallingApart)
                    : base(name, description, hitChance, block, maxLife, life, maxDmg, minDmg, race)
        {
            IsFallingApart= isFallingApart;
        }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            return $"--==Character Stats==--\nName: {Name}\nCurrent Limbs: {Life}\nMax Limbs: {MaxLife}\nBase Hit Chance: {HitChance}%\nArmor Class: {Block}\n{Race}\nMax Damage: {MaxDmg}\nMin Damage: {MinDmg}\nDescription: {Description}" +
                $"\nCombat Hint: Zombies can't take damage. You must sever it's limbs!";
        }
    }
}