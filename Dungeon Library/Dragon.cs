using Dungeon_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Dragon : Monster
    {
        public int FireBreath;

        public Dragon(string name, string description, int life, int maxLife, int hitChance, int block,
            int minDmg, int maxDmg, int fireBreath)
            : base(name, description, hitChance, block, life, maxLife, minDmg, maxDmg)
        {
            FireBreath = fireBreath;
        }

        public Dragon()
        {
            Name = "Dragon";
            Description = "The giant ancient lizard fills you with dispair. This is the end.";
            Life = 100;
            MaxLife = 100;
            HitChance = 100;
            Block = 0;
            MinDmg = 5;
            MaxDmg = FireBreath + 10;
            FireBreath = 20;
        }//default Dragon

        public override string ToString()
        {
            return base.ToString() + string.Format("\nDragons can breathe fire. This increases it's attack by {0}", FireBreath);
        }
    }
}