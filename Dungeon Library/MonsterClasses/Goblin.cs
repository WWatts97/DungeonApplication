using Dungeon_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Goblin : Monster
    {
        public bool IsFast { get; set; }

        public Goblin(string name, string description, int maxLife, int life, int hitChance, int block,
            int maxDmg, int minDmg, Race race, bool isFast)
            : base(name, description, hitChance, block, maxLife, life, maxDmg, minDmg, race)
        {
            IsFast = isFast;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}