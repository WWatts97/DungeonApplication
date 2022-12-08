namespace Dungeon_Library
{
    public abstract class Character : ICombatable
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
                else if (value > MaxLife) 
                {
                    _life = MaxLife;
                }
            }
        }
        public Race Race { get; set; }

        //ctors

        public Character() { }

        public Character(string name, int hitChance, int block, int maxLife, int life, Race race)
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
            Life = life;
            Race = race;
        }
        //methods
        public virtual int CalcBlock()
            {
            if (Block == 0)
            {
                return 0;
            }
            else if (Block == 1)
            {
                Random rand = new Random();
                int roll = rand.Next(1, 5);
                return roll;
            }
            else if (Block == 2)
            {
                Random rand = new Random();
                int roll = rand.Next(3, 7);
                return roll;
            }
            else if (Block == 2)
            {
                Random rand = new Random();
                int roll = rand.Next(5, 9);
                return roll;
            }
            else if (Block == 3)
            {
                Random rand = new Random();
                int roll = rand.Next(7, 11);
                return roll;
            }
            else
            {
                return 10000;
            }
        }
        public virtual int CalcHitChance()
            {
            return HitChance;
            }
        public virtual int CalcDamage() 
            {
            return 0;
            }
        public override string ToString()
        {
            return string.Format("--==Character Stats==--\n" +
                "Name: {0}\n" +
                "Current Life: {2}\n" +
                "Max Life: {1}\n" +
                "Base Hit Chance: {3}%\n" +
                "Armor Class: {4}\n{5}",
                Name,
                MaxLife,
                Life,
                HitChance,
                Block,
                Race);
        }
    }//end character class
}
