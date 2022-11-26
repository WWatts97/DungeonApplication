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
        public Goblin()
        {
            Name = "Goblin";
            Description = "Ugly, tiny, fast, and dangerous!";
            MaxLife = 100;
            Life = 100;
            HitChance = 100;
            Block = 0;
            MaxDmg = 20;
            MinDmg = 10;
        }//default Goblin

        public override string ToString()
        {
            return base.ToString() + "Goblins are fast! He will attack you before you attack him!";
        }
    }
}