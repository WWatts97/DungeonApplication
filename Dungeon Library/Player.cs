using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public sealed class Player : Character
    {
        //FIELDS

        //PROPS
        //UNIQUE props of player :
        public Race Race { get; set; }
        public Weapon EquippedWeapon { get; set; }

        public Player(string name, int hitChance, int block, int maxLife, int life, Race race, Weapon equippedWeapon) : base(name, hitChance, block, maxLife, life)
        {
            Race = race;
            EquippedWeapon = equippedWeapon;
        }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            return base.ToString() + Race + "\n\n" + EquippedWeapon + "\nCurrent Hit Chance: " + (HitChance + EquippedWeapon.BonusHitChance) + "%\n";
        }

        public override int CalcDamage()
        {
            Random rand = new Random();

            int damage = rand.Next(
                EquippedWeapon.MinDamage,
                EquippedWeapon.MaxDamage + 1);

            return damage;
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }
    }
}
