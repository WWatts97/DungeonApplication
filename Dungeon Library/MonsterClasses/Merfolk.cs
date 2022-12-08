using Dungeon_Library;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Merfolk : Monster
    {
        public bool IsWet { get; set; }

        public Merfolk(string name, string description, int maxLife, int life, int hitChance, int block,
            int maxDmg, int minDmg, Race race, bool isWet)
            : base(name, description, hitChance, block, maxLife, life, maxDmg, minDmg, race)
        {
            IsWet = isWet;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}