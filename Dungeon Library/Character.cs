namespace Dungeon_Library
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
                else if (value > MaxLife) 
                {
                    _life = MaxLife;
                }
            }
        }
        //ctors

        public Character() { }

        public Character(string name, int hitChance, int block, int maxLife, int life)
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
            Life = life;
        }
        //methods
        public virtual int CalcBlock()
            {
            return Block;
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
            return string.Format("Character Name: {0}\n" +
                "Max Life: {1}\n" +
                "Current Life: {2}\n" +
                "Hit Chance: {3}\n" +
                "Block? {4}",
                Name,
                MaxLife,
                Life,
                HitChance,
                Block);
        }
    }//end character class
}