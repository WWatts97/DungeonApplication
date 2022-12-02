using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Turtle : Monster
    {
        
        public int BonusBlock { get; set; }
        public int HidePercent { get; set; }

        public Turtle(string name, string description,  int maxLife, int life, int hitChance, int block,
            int maxDmg, int minDmg, int bonusBlock, int hidePercent)
            : base(name, description, hitChance, block,  maxLife, life, maxDmg, minDmg)
        {
            BonusBlock = bonusBlock;
            HidePercent = hidePercent;
        }

        public Turtle()
        {
            Name = "Michaelangelo";
            Description = "Turtle power!";
            MaxLife = 70;
            Life = 70;
            HitChance = 60;
            Block = 15;
            MaxDmg = 30;
            MinDmg = 20;
            BonusBlock = 20;
            HidePercent = 25;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\n{0}% chance it will hide, granting {1} bonus block.",
                HidePercent, BonusBlock);
        }

        public override int CalcBlock()
        {
           
            int calculatedBlock = Block;

            Random rand = new Random();

            int percent = rand.Next(1, 101);

            if (percent <= HidePercent)
            {
                calculatedBlock += BonusBlock;
            }

            return calculatedBlock;
        }
    }
}