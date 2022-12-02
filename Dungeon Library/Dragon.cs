using Dungeon_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Dragon : Monster
    {
        public int FireBreath;

        public Dragon(string name, string description,  int maxLife, int life, int hitChance, int block,
            int maxDmg, int minDmg, int fireBreath)
            : base(name, description, hitChance, block,  maxLife, life, maxDmg, minDmg)
        {
            FireBreath = fireBreath;
        }

        public Dragon()
        {
            Name = "Dragon";
            Description = "The giant ancient lizard fills you with dispair. This is the end.";
            MaxLife = 100;
            Life = 100;
            HitChance = 100;
            Block = 0;
            FireBreath = 20;
            MaxDmg = FireBreath + 10;
            MinDmg = 5;
        }//default Dragon

        public override string ToString()
        {
            return base.ToString() + string.Format("\nDragons can breathe fire. This increases it's attack by {0}", FireBreath);
        }
    }
}