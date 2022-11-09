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

            bool counterMainLoop = true;

            do
            {
                //TODO Create a Monster
                //TODO Create a Room

                bool counterInnerLoop = true;

                do
                {
                    switch (switch_on)
                    {
                        case "ATTACK":
                            break;
                        case "RUN AWAY":
                            break;
                        case "CHARACTER INFO":
                            break;
                        case "MONSTER INFO":
                            break;
                        case "EXIT":
                            break;
                        default:
                            break;
                    }

                } while (counterInnerLoop);

            } while (counterMainLoop);
        }//end main

        private static string GetRoom()
        {

        }
    }//end class
}//end namespace
