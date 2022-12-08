using Dungeon_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Monster : Character
    {
        //FIELDS
        private int _minDmg;//We only need this field because it has a business rule.

        //PROPS
        public int MaxDmg { get; set; }
        public int MinDmg
        {
            get { return _minDmg; }
            set
            {
                if (value <= MaxDmg)//If the value is less than or equal to the maximum...
                {
                    _minDmg = value;//Set the value as the minimum damage.
                }
                else//But if it exceeds the maximum...
                {
                    _minDmg = MaxDmg;//Set the value at the maximum.
                }
            }
        }
        public string Description { get; set; }

        //CTOR
        public Monster() { }

        public Monster(string name, string description, int hitChance, int block, int life, int maxLife, int maxDmg, int minDmg, Race race) : base(name, hitChance, block, maxLife, life, race)
        {
            Description = description;
            MaxDmg = maxDmg;
            MinDmg = minDmg;
        }

        //METHODS
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            return base.ToString() + $"\nMax Damage : {MaxDmg}\nMin Damage: {MinDmg}" +
                $"\nMonster Description: {Description}";
        }
    

        public override int CalcDamage()
        {
            Random rand = new Random();//Create an instance of the Random class.
            int damage = rand.Next(
                    MinDmg,//The minimum will be the minimum Damage.
                    MaxDmg + 1//The exclusive upper bound will be the maximum Damage plus one.
                );
            return damage;
        }
    }
}
