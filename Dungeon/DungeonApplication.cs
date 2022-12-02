using Dungeon_Library;
using DungeonLibrary;
using System.Data;
using System.Threading;

namespace Dungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Introduction
            Console.WriteLine(@"Loading...10%█▒▒▒▒▒▒▒▒▒");
            Thread.Sleep(1);//TODO set to 1000
            Console.Clear();
            Console.WriteLine(@"Loading...30%███▒▒▒▒▒▒▒");
            Thread.Sleep(1);
            Console.Clear();
            Console.WriteLine(@"Loading...50%█████▒▒▒▒▒");
            Thread.Sleep(1);
            Console.Clear();
            Console.WriteLine(@"Loading...80%███████▒▒▒");
            Thread.Sleep(1);
            Console.Clear();
            Console.WriteLine(@"Loading...100%██████████");
            Thread.Sleep(5);//TODO set to 500
            Console.Clear();
            Console.WriteLine("----==== Welcome to the Magic Dungeon ====----");

            Console.WriteLine(@"     
                                           O       /`-.__
                                                  /  \�'^|
                                     o           T    l  *
                                                _|-..-|_
                                         O    (^ '----' `)
                                               `\-....-/^
                                     O       o  ) ""/ "" (
                                               _( (-)  )_
                                           O  /\ )    (  /\
                                             /  \(    ) |  \
                                         o  o    \)  ( /    \
                                           /     |(  )|      \
                                          /    o \ \( /       \
                                    __.--'   O    \_ /   .._   \
                                   //|)\      ,   (_)   /(((\^)'\
                                      |       | O         )  `  |
                                      |      / o___      /      /
                                     /  _.-''^^__O_^^''-._     /
                                   .'  /  -''^^    ^^''-  \--'^
                                 .'   .`.  `'''----'''^  .`. \
                               .'    /   `'--..____..--'^   \ \
                              /  _.-/                        \ \
                          .::'_/^   |                        |  `.
                                 .-'|                        |    `-.
                           _.--'`   \                        /       `-.
                          /          \                      /           `-._
                          `'---..__   `.                  .�_.._   __       \
                                   ``'''`.              .'      `'^  `''---'^
                                          `-..______..-'");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Please enter your character's name.");

            string playerName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Your champion's name is {playerName}");
            //Base Weapon Objects
            Weapon sword1 = new Weapon("Knight's Broadsword", WeaponType.Sword, 25, 15, 30,false);
            Weapon knife1 = new Weapon("Assassin's Dagger", WeaponType.Knife, 20, 15, 40, false);
            Weapon axe1 = new Weapon("Lumber Axe", WeaponType.Axe, 35, 20, 20, false);
            Weapon bow1 = new Weapon("Long Bow", WeaponType.Bow, 45, 40, 30, true);
            Weapon spear1 = new Weapon("Guard's Spear", WeaponType.Spear, 60, 50, 20, true);
            Weapon club1 = new Weapon("Orc's Club", WeaponType.Club, 25, 15, 35, false);
            Weapon greatAxe1 = new Weapon("Giant's Axe", WeaponType.GreatAxe, 70, 50, 10, true);
            Weapon greatSword1 = new Weapon("Colossal Sword", WeaponType.GreatSword, 60, 45, 30, true);
            //Race Objects
            Race human = new Race(RaceType.Human, "", "");
            Race elf = new Race(RaceType.Elf, "", "");
            Race dragonKin = new Race(RaceType.DragonKin, "", "");
            Race halfDemon = new Race(RaceType.HalfDemon, "", "");
            Race merfolk = new Race(RaceType.Merfolk, "", "");
            Race angelKin = new Race(RaceType.AngelKin, "", "");
            Race giant = new Race(RaceType.Giant, "", "");
            Race vampire = new Race(RaceType.Vampire, "", "");

            bool playerIsChoosingWeapon = true;
            
            Player player = new Player(playerName, 50, 0, 100, 100, human, sword1);
            do
            {
                Console.WriteLine("\n Choose your weapon:\n" + "(S) Sword\n" + "(K) Knife\n" + "(A) Axe\n" + "(B) Bow\n" + "(P) Spear\n" + "(C) Club\n" + "(X) GreatAxe\n" + "(W) GreatSword\n" + "(Z) Show Weapon Descriptions");

                ConsoleKey userKey = Console.ReadKey().Key;
                Console.Clear();
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
                        case ConsoleKey.P:
                        player.EquippedWeapon = spear1;
                        playerIsChoosingWeapon = false;
                        break;
                        case ConsoleKey.C:
                        player.EquippedWeapon = club1;
                        playerIsChoosingWeapon = false;
                        break;
                    case ConsoleKey.X:
                        player.EquippedWeapon = greatAxe1;
                        playerIsChoosingWeapon = false;
                        break;
                    case ConsoleKey.W:
                        player.EquippedWeapon = greatSword1;
                        playerIsChoosingWeapon = false;
                        break;
                    case ConsoleKey.Z:
                        Console.WriteLine("\n" + sword1 + "\n");
                        Console.WriteLine(knife1 + "\n");
                        Console.WriteLine(axe1 + "\n");
                        Console.WriteLine(bow1 + "\n");
                        Console.WriteLine(spear1 + "\n");
                        Console.WriteLine(club1 + "\n");
                        Console.WriteLine(greatAxe1 + "\n");
                        Console.WriteLine(greatSword1 + "\n");
                        Console.WriteLine("If your weapon is one-handed, you will be given a shield for your other hand. This will increase your Armor Class by 1.");
                        break;
                    default:
                        Console.WriteLine("Input not understood. Please try again.");
                        break;
                }
            } while (playerIsChoosingWeapon);
            Console.WriteLine($"Your champion's name is {playerName}");
            Console.WriteLine($"You have chosen {player.EquippedWeapon.Name}");
            if (player.EquippedWeapon.IsTwoHanded == false)
            {
                Console.WriteLine("Your weapon only requires 1 hand. You will be given a shield for your other hand. This will increase your Armor Class by 1.");
                player.Block++;
            }
            bool playerIsChoosingRace = true;
            do
            {
                Console.WriteLine("\nChoose a Race:" +
                "\n(E) Elf" +
                "\n(H) Human" +
                "\n(M) Merfolk" +
                "\n(D) Draconoid" +
                "\n(A) Half-Angel" +
                "\n(V) Vampire" +
                "\n(G) Goliath" +
                "\n(N) Half-Demon" +
                "\n(Z) Show race descriptions\n");

                ConsoleKey raceCoice = Console.ReadKey().Key;
                

                switch (raceCoice)
                {
                    case ConsoleKey.E:
                        player.Race = elf;
                        playerIsChoosingRace = false;
                        //TODO custom attributes for each class
                        break;
                        case ConsoleKey.H:
                        player.Race = human;
                        playerIsChoosingRace = false;
                        break;
                        case ConsoleKey.M:
                        player.Race = merfolk;
                        playerIsChoosingRace = false;
                        break;
                        case ConsoleKey.V:
                        player.Race = vampire;
                        playerIsChoosingRace = false;
                        break;
                        case ConsoleKey.A:
                        player.Race = angelKin;
                        playerIsChoosingRace = false;
                        break;
                        case ConsoleKey.D:
                        player.Race = dragonKin;
                        playerIsChoosingRace = false;
                        break;
                    case ConsoleKey.G:
                        player.Race = giant;
                        playerIsChoosingRace = false;
                        break;
                    case ConsoleKey.N:
                        player.Race = halfDemon;
                        playerIsChoosingRace = false;
                        break;
                    case ConsoleKey.Z:
                        Console.WriteLine(elf + "\n");
                        Console.WriteLine(human + "\n");
                        Console.WriteLine(merfolk + "\n");
                        Console.WriteLine(dragonKin + "\n");
                        Console.WriteLine(angelKin + "\n");
                        Console.WriteLine(vampire + "\n");
                        Console.WriteLine(giant + "\n");
                        Console.WriteLine(halfDemon + "\n");
                        break;
                    default:
                        Console.WriteLine("Input not understood. Please try again.");
                        break;
                }
            } while (playerIsChoosingRace);
            Console.Clear();
            Console.WriteLine($"Your champion's name is {player.Name}");
            Console.WriteLine($"You have chosen {player.EquippedWeapon.Name}");
            Console.WriteLine($"The race you have chosen for {player.Name} is {player.Race.RaceType}");
            Thread.Sleep(2000);
            Console.Clear();
            if (player.Race.RaceType == RaceType.Elf)
            {
                Console.WriteLine($"Creating an {player.Race.RaceType} named {player.Name} wielding {player.EquippedWeapon.Name}" + (player.EquippedWeapon.IsTwoHanded ? "." : " and a shield."));
            }
            else if (player.Race.RaceType == RaceType.AngelKin)
            {
                Console.WriteLine($"Creating an {player.Race.RaceType} named {player.Name} wielding {player.EquippedWeapon.Name}" + (player.EquippedWeapon.IsTwoHanded ? "." : " and a shield."));
            }
            else
            {
                Console.WriteLine($"Creating a {player.Race.RaceType} named {player.Name} wielding {player.EquippedWeapon.Name}" + (player.EquippedWeapon.IsTwoHanded ? "." : " and a shield."));
            }
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine(@"Loading...10%█▒▒▒▒▒▒▒▒▒");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(@"Loading...30%███▒▒▒▒▒▒▒");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(@"Loading...50%█████▒▒▒▒▒");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(@"Loading...80%███████▒▒▒");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(@"Loading...100%██████████");
            Thread.Sleep(500);
            Console.Clear();
            int score = 0;

            bool playerIsAlive = true;//counter for gameplayloop
            bool playerIsFighting = true;//counter for the combat loop

            int lvlUp1 = 0;
            int lvlUp2 = 0;
            int lvlUp3 = 0;

            do//start of gameplay loop
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                switch (score)
                {
                    //Examples of stat increases
                    case 3:
                        for (int i = 0; lvlUp1 < 1; lvlUp1++)
                        {
                            Console.WriteLine("\nYou leveled up!\nYour maximum life has increased and been refilled!");
                            player.MaxLife += 50;//Increase their maximum life.
                            player.Life = player.MaxLife;//Refill their life.
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"{player.Name} has {player.Life} life remaining, out of {player.MaxLife} maximum life!");
                            Console.ResetColor();
                        }
                        break;
                    case 6:
                        for (int i = 0; lvlUp2 < 1; lvlUp2++)
                        {
                            Console.WriteLine("\nYou leveled up!\nYour maximum life has increased and been refilled!");
                            player.MaxLife += 50;//Increase their maximum life.
                            player.Life = player.MaxLife;//Refill their life.
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"{player.Name} has {player.Life} life remaining, out of {player.MaxLife} maximum life!");
                            Console.ResetColor();
                        }
                        break;
                    //Example of loot drop
                    case 10:
                        for (int i = 0; lvlUp3 < 1; lvlUp3++)
                        {
                            if (player.EquippedWeapon == sword1)
                            {
                                Weapon sword2 = new Weapon("Master Sword", WeaponType.Sword, 35, 25, 35, false);

                                Console.WriteLine("\nYou found the Master Sword!");
                                player.EquippedWeapon = sword2;
                            }
                            else if (player.EquippedWeapon == knife1)
                            {
                                Weapon knife2 = new Weapon("Shadowstep Dagger", WeaponType.Knife, 30, 25, 45, false);

                                Console.WriteLine("\nYou found the Shadowstep Dagger!");
                                player.EquippedWeapon = knife2;
                            }
                            else if (player.EquippedWeapon == axe1)
                            {
                                Weapon axe2 = new Weapon("Pic's Axe", WeaponType.Axe, 45, 30, 25, false);

                                Console.WriteLine("\nYou found the Pic's Axe!");
                                player.EquippedWeapon = axe2;
                            }
                            else if (player.EquippedWeapon == bow1)
                            {
                                Weapon bow2 = new Weapon("Colossal Bow", WeaponType.Bow, 60, 55, 35, true);

                                Console.WriteLine("\nYou found the Colossal Bow!");
                                player.EquippedWeapon = bow2;
                            }
                            else if (player.EquippedWeapon == spear1)
                            {
                                Weapon spear2 = new Weapon("Neptune's Trident", WeaponType.Spear, 75, 65, 25, true);

                                Console.WriteLine("\nYou found the Neptune's Trident!");
                                player.EquippedWeapon = spear2;
                            }
                            else if (player.EquippedWeapon == club1)
                            {
                                Weapon club2 = new Weapon("A Bonker", WeaponType.Club, 35, 25, 40, false);

                                Console.WriteLine("\nYou found the a Bonker!");
                                player.EquippedWeapon = club2;
                            }
                            else if (player.EquippedWeapon == greatAxe1)
                            {
                                Weapon greatAxe2 = new Weapon("Ground Breaker Axe", WeaponType.GreatAxe, 85, 65, 15, true);

                                Console.WriteLine("\nYou found the Ground Breaker Axe!");
                                player.EquippedWeapon= greatAxe2;
                            }
                            else if (player.EquippedWeapon == greatSword1)
                            {
                                Weapon greatSword2 = new Weapon("Giant's Knife", WeaponType.GreatSword, 75, 60, 35, true);

                                Console.WriteLine("\nYou found the Giant's Knife!");
                                player.EquippedWeapon= greatSword2;
                            }
                            Console.WriteLine("\nYou leveled up!\nYour maximum life has increased and been refilled!");
                            player.MaxLife += 50;//Increase their maximum life.
                            player.Life = player.MaxLife;//Refill their life.
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"{player.Name} has {player.Life} life remaining, out of {player.MaxLife} maximum life!");
                            Console.ResetColor();

                        }
                        break;
                };

                Console.ResetColor();
                Console.Clear();
                GetRoom();
                //Create Monster objects:
                Bunny b1 = new Bunny();
                Bunny b2 = new Bunny("Buneary", "From the Sinnoh Region!", 20, 20, 70, 1, 10, 5, true);
                Vampire v1 = new Vampire();
                Vampire v2 = new Vampire("The Count", "1! Ah, ah ah. 2! Ah, ah, ah. 3!", 25, 25, 60, 1, 10, 15, false);
                Turtle t1 = new Turtle();
                Turtle t2 = new Turtle("Franklin", "He can count by twos and tie his shoes", 1000, 1000, 50, 10, 5, 10, 50, 80);
                Dragon d1= new Dragon();
                Goblin g1 = new Goblin();


                //Add the Monsters to a Collection:
                Monster[] monsters =
                {
                    
                    b1
                };

                //Pick one at random to place in the room.
                Random rand = new Random();
                int randomNbr = rand.Next(monsters.Length);
                Monster monster = monsters[randomNbr];

                Console.Write("\nYou encountered"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(" {0}!" ,monster.Name); Console.ResetColor();

                #endregion

                #region Menu Loop

                do
                {
                    Console.ResetColor();
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

                            if (monster == g1)
                            {
                                Combat.GoblinBattle(monster, player);
                            }
                            else
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
                            Console.WriteLine(monster);
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
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue; Console.Write(playerName); Console.ForegroundColor = ConsoleColor.Red; Console.Write(" has died!"); Console.ResetColor();
                        Thread.Sleep(1000);
                        playerIsFighting = false;
                        playerIsAlive = false;
                    }
                    #endregion

                } while (playerIsFighting);

                #endregion
            } while (playerIsAlive);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"        
                                        ┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼
                                        ███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀
                                        ██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼
                                        ██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀
                                        ██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼
                                        ███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄
                                        ┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼
                                        ███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼
                                        ██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼
                                        ██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼
                                        ██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼
                                        ███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄
                                        ┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼
                                        ┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼
                                        ┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼
                                        ┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼
                                        ┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼
                                        ┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼
                                        ┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼
                                        ┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼
                                        ┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼
                                        ┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼
                                        ┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼
                                        ┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼
                                        ┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Score: {0}", score);
            Console.ResetColor();

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
