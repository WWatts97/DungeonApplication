using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Player : Character
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
                case Race.Troll:
                    raceDescription = "Troll";
                    break;
                case Race.Gnome:
                    raceDescription = "Gnome";
                    break;
                case Race.Demon:
                    raceDescription = "Demon";
                    break;
            }

            return base.ToString()+ "\nDescription: " + raceDescription + "\n" + EquippedWeapon + "\nRace: "+ Race;
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
