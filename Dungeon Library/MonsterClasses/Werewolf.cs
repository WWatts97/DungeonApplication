using Dungeon_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Werewolf : Monster
    {
        public DateTime TimeToShift { get; set; }
        public bool IsTransformed { get; set; }

        public Werewolf(string name, string description,  int maxLife, int life, int hitChance, int block,
            int maxDmg, int minDmg, Race race, bool isTransformed)
            : base(name, description, hitChance, block,  maxLife, life, maxDmg, minDmg, race)
        {
            TimeToShift = DateTime.Now;
            IsTransformed = isTransformed;
            if (TimeToShift.Hour < 6 || TimeToShift.Hour > 18)
            {
                isTransformed = true;
            }
            if (isTransformed == true)
            {
                HitChance += 5;
                Block += 1;
                MaxDmg += 10;
                MinDmg += 10;
                Life += 10;
                MaxLife+= 10;
            }

        }

        public override string ToString()
        {
            return base.ToString() + "\n" + (IsTransformed ? "He has transformed into a monsterous Wolf!" : "He hasn't transformed yet.");
        }
    }
}