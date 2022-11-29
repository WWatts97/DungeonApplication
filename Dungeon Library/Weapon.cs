using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Weapon
    {
        //fields
        private int _minDamage;
        //props
        public int MaxDamage { get; set; }
        public string Name { get; set; }
        public int BonusHitChance { get; set; }
        public bool IsTwoHanded { get; set; }
        public WeaponType Type { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else if (_minDamage > MaxDamage)
                {
                    _minDamage = MaxDamage;
                }
            }
        }
        //ctors
        public Weapon(string name, WeaponType type, int maxDamage, int minDamage, int bonusHitChance, bool isTwoHanded)
        {
            Name = name;
            Type = type;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
        }
        //methods
        public override string ToString()
        {
            return string.Format("Weapon Name: {0}\n" +
                "Weapon Type: {5}\n" +
                "Max Damage: {1}\n" +
                "Min Damage: {2}\n" +
                "Bonus Hit Chance: {3}\n" +
                "Does it require both hands? {4}",
                Name,
                MaxDamage,
                MinDamage,
                BonusHitChance,
                IsTwoHanded,
                Type);
        }
    }//end wepaon class
}
