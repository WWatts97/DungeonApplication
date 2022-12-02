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

        public Player(string name, int hitChance, int block, int maxLife, int life, Race race, Weapon equippedWeapon) : base(name,hitChance, block, maxLife, life)
        {
            Race= race;
            EquippedWeapon= equippedWeapon;
        }

        public override string ToString()
        {
            string raceDescription = "";

            switch (Race)
            {//TODO race desc
                case Race.Elf:
                    raceDescription = "Elf";
                    break;
                case Race.Human:
                    raceDescription = "Human";
                    break;
                case Race.Merfolk:
                    raceDescription = "Merfolk";
                    break;
                case Race.AngelKin:
                    raceDescription = "Angel-Kin";
                    break;
                case Race.DragonKin:
                    raceDescription = "Dragon-Kin";
                    break;
                case Race.Vampire:
                    raceDescription = "Vampire";
                    break;
                case Race.Giant:
                    raceDescription = "Giant";
                    break;
                case Race.HalfDemon:
                    raceDescription = "Half-Demon";
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            return base.ToString() + "Race: " + Race + "\nDescription: " + raceDescription + "\n\n" + EquippedWeapon + "\nCurrent Hit Chance: " + (HitChance + EquippedWeapon.BonusHitChance) + "%";
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
