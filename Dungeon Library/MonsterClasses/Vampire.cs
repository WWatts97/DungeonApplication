using Dungeon_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Vampire : Monster
    {
        public bool IsLifelinked { get; set; }

        public Vampire(string name, string description,  int maxLife, int life, int hitChance, int block,
            int maxDmg, int minDmg, Race race, bool isLifelinked)
            : base(name, description, hitChance, block,  maxLife, life, maxDmg, minDmg, race)
        {
            IsLifelinked = isLifelinked;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}