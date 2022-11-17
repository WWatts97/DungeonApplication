using Dungeon_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Goblin : Monster
    {
        public bool IsEquipped { get; set; }

        public Goblin(string name, string description,  int maxLife, int life, int hitChance, int block,
            int minDmg, int maxDmg, bool isEquipped)
            : base(name, description, hitChance, block,  maxLife, life, minDmg, maxDmg)
        {
            IsEquipped = isEquipped;
        }

        public Goblin()
        {
            Name = "Goblin";
            Description = "Ugly, tiny, and dangerous!";
            MaxLife = 100;
            Life = 100;
            HitChance = 100;
            Block = 0;
            MinDmg = 5;
            MaxDmg = 5;
            IsEquipped = false;

            if (IsEquipped == true)
            {
                MinDmg += 10;
                MaxDmg += 10;
            }
        }//default Goblin

        public override string ToString()
        {
            return base.ToString() + (IsEquipped ? "\nIt's got a weapon!"
                : "\nJust a normal goblin.");
        }
    }
}