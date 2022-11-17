﻿using Dungeon_Library;
using DungeonLibrary;

namespace Dungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Introduction
            Console.WriteLine("\n--== The Dragon's Dungeon ==--\n");

            Console.WriteLine(@"
                 \||/
                |  @___oo
      /\  /\   / (__,,,,|
     ) /^\) ^\/ _)
     )   /^\/   _)
     )   _ /  / _)
 /\  )/\/ ||  | )_)
<  >      |(,,) )__)
 ||      /    \)___)\
 | \____(      )___) )___
  \______(_______;;; __;;;");
            #endregion

            #region Create Player


            //Prompt the user to input their name:
            Console.WriteLine("What is your name?");

            //Store the user input in a string.
            string playerName = Console.ReadLine();



            //Construct the Player's weapon:
            Weapon sword1 = new Weapon("Sword", WeaponType.Sword, 10,5,10,false);
            Weapon knife1 = new Weapon("Knife", WeaponType.Knife, 10, 5, 10, false);
            Weapon axe1 = new Weapon("Axe", WeaponType.Axe, 10, 5, 10, false);
            Weapon bow1 = new Weapon("Bow", WeaponType.Bow, 10, 5, 10, false);
            Weapon lightsaber1 = new Weapon("Lightsaber", WeaponType.Lightsaber, 10, 5, 10, false);

            bool playerIsChoosingWeapon = true;
            Weapon chosenWeapon;

            Player player = new Player(playerName, 70, 5, 100, 100, Race.Human, sword1);
            do
            {
                Console.WriteLine("\n Choose your weapon:\n" + "(S) Sword\n" + "(K) Knife\n" + "(A) Axe\n" + "(B) Bow\n" + "(L) Lightsaber");

                ConsoleKey userKey = Console.ReadKey().Key;

                switch (userKey)
                {
                    case ConsoleKey.S:
                        player.EquippedWeapon = sword1;
                        playerIsChoosingWeapon = false;
                        break;
                    case ConsoleKey.K:
                        player.EquippedWeapon = knife1;
                        playerIsChoosingWeapon = false;
                        break;
                        case ConsoleKey.A:
                        player.EquippedWeapon = axe1;
                        playerIsChoosingWeapon = false;
                        break;
                        case ConsoleKey.B:
                        player.EquippedWeapon = bow1;
                        playerIsChoosingWeapon = false;
                        break;
                        case ConsoleKey.L:
                        player.EquippedWeapon = lightsaber1;
                        playerIsChoosingWeapon = false;
                        break;
                    default:
                        Console.WriteLine("Input not understood. Please try again.");
                        break;
                }
            } while (playerIsChoosingWeapon);

            bool playerIsChoosingRace = true;

            do
            {
                Console.WriteLine("\nChoose a Race:" +
                "\n(E) Elf" +
                "\n(H) Human" +
                "\n(M) Merfolk" +
                "\n(D) Demon" +
                "\n(G) Gnome" +
                "\n(T) Troll");

                ConsoleKey raceCoice = Console.ReadKey().Key;
                Console.Clear();

                switch (raceCoice)
                {
                    case ConsoleKey.E:
                        player.Race = Race.Elf;
                        playerIsChoosingRace = false;
                        //TODO custom attributes for each class
                        break;
                        case ConsoleKey.H:
                        player.Race = Race.Human;
                        playerIsChoosingRace = false;
                        break;
                        case ConsoleKey.M:
                        player.Race = Race.Merfolk;
                        playerIsChoosingRace = false;
                        break;
                        case ConsoleKey.D:
                        player.Race = Race.Demon;
                        playerIsChoosingRace = false;
                        break;
                        case ConsoleKey.G:
                        player.Race = Race.Gnome;
                        playerIsChoosingRace = false;
                        break;
                        case ConsoleKey.T:
                        player.Race = Race.Troll;
                        playerIsChoosingRace = false;
                        break;
                    default:
                        Console.WriteLine("Input not understood. Please try again.");
                        break;
                }
            } while (playerIsChoosingRace);

            


            //Construct the Player object:
            //NOTE: Pass in the user input string as the Name for the Player.


            #endregion


            //track the score:
            int score = 0;
            //we will update this score whenever the player defeats a monster.
            //the display the score to the player when they exit thw game.

            #region Gameplay Loop

            bool playerIsAlive = true;//counter for gameplayloop
            bool playerIsFighting = true;//counter for the combat loop

            do//start of gameplay loop
            {
                bool isFirstLoop = true;

                Console.ForegroundColor= ConsoleColor.Yellow;
                switch (score)
                {
                    case 3:
                        Console.WriteLine("You leveled up!");
                        player.MaxLife += 50;
                        player.Life = player.MaxLife;
                        break;
                    case 6:
                        Console.WriteLine("You leveled up!");
                        player.MaxLife += 50;
                        player.Life = player.MaxLife;
                        break;
                    case 10:
                        Weapon sword2 = new Weapon("Sword", WeaponType.Sword, 10, 5, 10, false);
                       //TODO wepaon loot?
                        break;
                    case 15:
                        break;
                }
                //any code in this loop will execute when the player kills a monster

                #region Create Room & Monster

                //Because we are doing the Console.WriteLine() inside
                //the GetRoom() method, we can just call the method here.
                GetRoom();

                //However, an alternative solution is to return a string
                //from GetRoom() and then pass that into the CW like:
                //Console.WriteLine(GetRoom());
                //Again, this would only work if you have string as
                //the return type of GetRoom(). In my case, I return void,
                //and write to the Console inside the method.

                //Create Monster objects:
                Bunny b1 = new Bunny();
                Bunny b2 = new Bunny("Buneary", "From the Sinnoh Region!", 20, 20, 70, 0, 5, 10, true);
                Vampire v1 = new Vampire();
                Vampire v2 = new Vampire("The Count", "1! Ah, ah ah. 2! Ah, ah, ah. 3!", 25, 25, 60, 1, 10, 15, false);
                Turtle t1 = new Turtle();
                Turtle t2 = new Turtle("Franklin", "He can count by twos and tie his shoes", 10, 10, 50, 10, 5, 10, 50, 80);
                Dragon d1= new Dragon();
                Goblin g1 = new Goblin();


                //Add the Monsters to a Collection:
                Monster[] monsters =
                {
                    b1,
                    b2, b2, b2,
                    v1,
                    v2, v2,
                    t1,
                    t2,
                    d1,
                    g1, g1
                };

                //Pick one at random to place in the room.
                Random rand = new Random();
                int randomNbr = rand.Next(monsters.Length);
                Monster monster = monsters[randomNbr];

                Console.WriteLine("You encountered {0}!", monster.Name);

                #endregion

                #region Menu Loop

                do
                {
                    playerIsFighting = true;
                    Console.WriteLine("\nChoose an action:\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) View Player Stats\n" +
                        "M) View Monster Stats\n" +
                        "Q) Quit\n");

                    string fightingChoice = Console.ReadLine();

                    Console.Clear();

                    switch (fightingChoice.ToUpper())
                    {
                        case "A":
                            Combat.DoBattle(player, monster);

                            //check monster life
                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nYou killed {0}", monster.Name);
                                Console.ResetColor();
                                score++;
                                playerIsFighting = false;
                            }
                            break;
                        case "R":
                            Console.WriteLine("Running away!");
                            Console.WriteLine($"{monster.Name} attacks you as you flee!");
                            Combat.DoAttack(monster, player);
                            playerIsFighting = false;
                            break;
                        case "P":
                            //Because we have an override of the ToString() method on our Player class,
                            //that information can be printed to the console simply by passing the 
                            //Player object into the Console.WriteLine();
                            Console.WriteLine(player);
                            break;
                        case "M":
                            //TODO: Print Monster stats. (ToString() method)
                            break;
                        case "Q":
                            playerIsFighting = false;
                            playerIsAlive = false;
                            break;
                        default:
                            Console.WriteLine("Input invalid. Please type a letter from the Menu below and press Enter.");
                            break;
                    }

                    #region Check player life

                    if (player.Life <= 0)
                    {
                        Console.WriteLine("Game over! Better luck next time!");
                        playerIsFighting = false;
                        playerIsAlive = false;
                    }
                    #endregion

                } while (playerIsFighting);

                #endregion
            } while (playerIsAlive);

            #endregion

            Console.WriteLine("Thanks for playing!");
            Console.WriteLine("\n Score: {0}", score);

        }//end Main()

        private static void GetRoom()
        {
            string[] rooms =
            {
                "A large forge squats against the far wall of this room, and coals glow dimly inside. Before the forge stands a wide block of iron with a heavy-looking hammer lying atop it, no doubt for use in pounding out shapes in hot metal. Other forge tools hang in racks nearby, and a barrel of water and bellows rest on the floor nearby.",
                "Rusting spikes line the walls and ceiling of this chamber. The dusty floor shows no sign that the walls move over it, but you can see the skeleton of some humanoid impaled on some wall spikes nearby.",
                "Tapestries decorate the walls of this room. Although they may once have been brilliant in hue, they now hang in graying tatters. Despite the damage of time and neglect, you can perceive once-grand images of wizards' towers, magical beasts, and symbols of spellcasting.",
                "This room is walled and floored with black marble veined with white. The ceiling is similarly marbled, but the thick pillars that hold it up are white. A stain of blood drips down one side of a nearby pillar.",
                "This room is shattered. A huge crevasse shears the chamber in half, and the ground and ceilings are tilted away from it. It's as though the room was gripped in two enormous hands and broken like a loaf of bread. Someone has torn a tall stone door from its hinges somewhere else in the dungeon and used it to bridge the 15-foot gap of the chasm between the two sides of the room. Whatever did that must have possessed tremendous strength because the door is huge, and the enormous hinges look bent and mangled.",
                "Neither light nor darkvision can penetrate the gloom in this chamber. An unnatural shade fills it, and the room's farthest reaches are barely visible. Near the room's center, you can just barely perceive a lump about the size of a human lying on the floor.",
                "A flurry of bats suddenly flaps through the doorway, their screeching barely audible as they careen past your heads. They flap past you into the rooms and halls beyond. The room from which they came seems barren at first glance.",
                "A huge stewpot hangs from a thick iron tripod over a crackling fire in the center of this chamber. A hole in the ceiling allows some of the smoke from the fire to escape, but much of it expands across the ceiling and rolls down to fill the room in a dark fog. Other details are difficult to make out, but some creature must be nearby, because something's cooking.",
                "You open the door to the remains of two humans, an elf, and a dwarf lying on the ground in front of you. It seems that they might once have been wearing armor, except for the elf, who remains dressed in a blue robe. Clearly they were defeated and victors stripped them of their valuables.",
                "You feel a sense of foreboding upon peering into this cavernous chamber. At its center lies a low heap of refuse, rubble, and bones atop which sit several huge broken eggshells. Judging by their shattered remains, the eggs were big enough to hold a crouching man, making you wonder how large -- and where -- the mother is.",
                "You open the door to what must be a combat training room. Rough fighting circles are scratched into the surface of the floor. Wooden fighting dummies stand waiting for someone to attack them. A few punching bags hang from the ceiling.",
                "A 30-foot-tall demonic idol dominates this room of black stone. The potbellied statue is made of red stone, and its grinning face holds what looks to be two large rubies in place of eyes. A fire burns merrily in a wide brazier the idol holds in its lap.",
                "A chill crawls up your spine and out over your skin as you look upon this room. The carvings on the wall are magnificent, a symphony in stonework -- but given the themes represented, it might be better described as a requiem. Scenes of death, both violent and peaceful, appear on every wall framed by grinning skeletons and ghoulish forms in ragged cloaks.",
                "A horrendous, overwhelming stench wafts from the room before you. Small cages containing small animals and large insects line the walls. Some of the creatures look sickly and alive but most are clearly dead. Their rotting corpses and the unclean cages no doubt result in the zoo's foul odor. A cat mews weakly from its cage, but the other creatures just silently shrink back into their filthy prisons.",
                "Huge rusted metal blades jut out of cracks in the walls, and rusting spikes project down from the ceiling almost to the floor. This room may have once been trapped heavily, but someone triggered them, apparently without getting killed. The traps were never reset and now seem rusted in place.",
                 "This chamber was clearly smaller at one time, but something knocked down the wall that separated it from an adjacent room. Looking into that space, you see signs of another wall knocked over. It doesn't appear that anyone made an effort to clean up the rubble, but some paths through see more usage than others."
            };
            Random rollRoom = new Random();
            int randIndex = rollRoom.Next(rooms.Length);
            string roomDesc = rooms[randIndex];
            Console.WriteLine(roomDesc);
        }
    }//end class()
}//end namespace