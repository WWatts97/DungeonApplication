using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    internal class DungeonApplication
    {
        static void Main(string[] args)
        {
            //TODO Create a player

            //bool counterMainLoop = true;

            //do
            //{
            //    //TODO Create a Monster
            Console.WriteLine(GetRoom());

            //    bool counterInnerLoop = true;

            //    //do
            //    //{
            //    //    switch (switch_on)
            //    //    {
            //    //        case "ATTACK":
            //    //            break;
            //    //        case "RUN AWAY":
            //    //            break;
            //    //        case "CHARACTER INFO":
            //    //            break;
            //    //        case "MONSTER INFO":
            //    //            break;
            //    //        case "EXIT":
            //    //            break;
            //    //        default:
            //    //            break;
            //    //    }

            //    } while (counterInnerLoop);

            //} while (counterMainLoop);
        }//end main

        private static string GetRoom()
        {
            string[] roomDescriptions =
            {
                "This room is made of wood. It you can smell the age in the air.",
                "You are filled with an overwhleming sensation of dread as you enter. The room reaks of death.",
                "You are blinded. The room is so bright it cannot contain it all.",
                "This room is smelly. That's it.",
            };
            Random rng = new Random();
            int roomDescRandom = rng.Next(roomDescriptions.Length);
            return $"{roomDescriptions[roomDescRandom]}";
            
        }//end GetRoom()
    }//end class
}//end namespace
