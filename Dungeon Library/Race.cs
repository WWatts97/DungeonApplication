using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Race
    {
        public RaceType RaceType { get; set; }
        public string Description { get; set; } 
        public string Bonus { get; set; }

        public Race(RaceType raceType, string desc, string bonus) 
        {
            RaceType = raceType;
            Description = desc;
            Bonus = bonus;
        }
        public override string ToString() =>
         string.Format($"Race: {RaceType}\nRace Attributes: {Bonus}\nRace Description: {Description}");
    }
}
