using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    internal class DungeonApplication
    {
        static void Main(string[] args)
        {
            //TODO welcome to the dungeon

            //TODO Create a player object

            //bool counterMainLoop = true;

            //    bool counterInnerLoop = true;

            //do
            //{
            //    //TODO Create a Monster
            Console.WriteLine(GetRoom());


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
            Random rollRoom = new Random();
            int roomDescRandom = rollRoom.Next(roomDescriptions.Length);
            return $"{roomDescriptions[roomDescRandom]}";
            
        }//end GetRoom()
    }//end class
}//end namespace
