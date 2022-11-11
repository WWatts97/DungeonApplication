using System.Data;

namespace DungeonLibrary
{
    public class Character
    {
        //fields
        private int _life;
        //props
        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int MaxLife { get; set; }
        public int Life 
        { 
            get { return _life; }
            set 
            {
                if (value <= MaxLife)
                {
                    _life = value;
                }
                else
                {
                    _life = MaxLife;
                }
            }
        }
        //ctors
        public Character(string name, int hitChance, int block, int maxLife, int life)
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
            Life = life;
        }
        //methods
        public decimal CalcBlock()
        {

        }
        public decimal CalcHitChance()
        {

        }
        public decimal CalcDamage() 
        { 
        
        }
    }//end character class

    
    //NicelyFormatted ToString()
    public class Weapon
    {
        //fields
        private int _minDamage;
        //props
        public int MaxDamage { get; set; }
        public string Name { get; set; }
        public int BonusHitChance { get; set; }
        public bool IsTwoHanded { get; set; }
        public int MinDamage 
        { 
            get { return _minDamage; }
            set
            {
                if (value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = MaxDamage;
                }
            }
        }
        //ctors
        public Weapon(string name, int maxDamage, int minDamage, int bonusHitChance, bool isTwoHanded)
        {
            Name = name;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
        }
        //methods
        public override string ToString()
        {
            return string.Format("Weapon Name: {0}\n" +
                "Max Damage: {1}\n" +
                "Min Damage: {2}\n" +
                "Bonus Hit Chance: {3}\n" +
                "Does it require both hands? {3}",
                Name,
                MaxDamage,
                MinDamage,
                BonusHitChance,
                IsTwoHanded); 
        }
    }//end wepaon class
}//end namesapce