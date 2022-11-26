using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //Change the access modifier from internal to public.
    //Inherit from Monster by adding ": Monster"
    public class Bunny : Monster
    {
        //Add any unique properties for this Monster.
        public bool IsFluffy { get; set; }

        //Make sure to add that unique property to the inherited properties in the parameters.
        public Bunny(string name, string description,  int maxLife, int life, int hitChance, int block,
            int maxDmg, int minDmg, bool isFluffy)
            : base(name, description, hitChance, block, maxLife, life, maxDmg, minDmg)
        //Use the base constructor to assign the inherited properties.
        {
            IsFluffy = isFluffy;//Assign the unique property.
        }

        //EXAMPLE: An empty constructor for default values:
        public Bunny()//Take in no parameters.
        {
            Name = "White Rabbit";
            Description = "Well, that's no ordinary rabbit! That's the most foul, cruel, and bad-tempered rodent you ever set eyes on!";
            MaxLife = 100;
            Life = 100;
            HitChance = 100;
            Block = 0;
            MaxDmg = 5;
            MinDmg = 5;
            IsFluffy = false;
        }//default Rabbit

        public override string ToString()//EXAMPLE: Override the ToString() using the unique property
        {
            return base.ToString() + (IsFluffy ? "\nIt's so fluffy, I'm gonna die!"
                : "\nNot so fluffy...");
        }

        public override int CalcBlock()//EXAMPLE: Override CalcBlock() using the unique property
        {
            //return base.CalcBlock();
            int calculatedBlock = Block;
            if (IsFluffy)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            return calculatedBlock;
        }
    }
}