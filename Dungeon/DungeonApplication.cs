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
            #region Intro
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
            #endregion
            #region CreateWeaponObjects
            //Create Base Weapon Objects
            Weapon sword1 = new Weapon("Knight's Broadsword", WeaponType.Sword, 25, 15, 30, false);
            Weapon knife1 = new Weapon("Assassin's Dagger", WeaponType.Knife, 20, 15, 40, false);
            Weapon axe1 = new Weapon("Lumber Axe", WeaponType.Axe, 35, 20, 20, false);
            Weapon bow1 = new Weapon("Long Bow", WeaponType.Bow, 45, 40, 30, true);
            Weapon spear1 = new Weapon("Guard's Spear", WeaponType.Spear, 60, 50, 20, true);
            Weapon club1 = new Weapon("Orc's Club", WeaponType.Club, 25, 15, 35, false);
            Weapon greatAxe1 = new Weapon("Giant's Axe", WeaponType.GreatAxe, 70, 50, 10, true);
            Weapon greatSword1 = new Weapon("Colossal Sword", WeaponType.GreatSword, 60, 45, 30, true);
            //Create Upgraded Weapon Objects
            Weapon sword2 = new Weapon("Master Sword", WeaponType.Sword, 35, 25, 35, false);
            Weapon knife2 = new Weapon("Shadowstep Dagger", WeaponType.Knife, 30, 25, 45, false);
            Weapon axe2 = new Weapon("Pic's Axe", WeaponType.Axe, 45, 30, 25, false);
            Weapon bow2 = new Weapon("Colossal Bow", WeaponType.Bow, 60, 55, 35, true);
            Weapon spear2 = new Weapon("Neptune's Trident", WeaponType.Spear, 75, 65, 25, true);
            Weapon club2 = new Weapon("A Bonker", WeaponType.Club, 35, 25, 40, false);
            Weapon greatAxe2 = new Weapon("Ground Breaker Axe", WeaponType.GreatAxe, 85, 65, 15, true);
            Weapon greatSword2 = new Weapon("Giant's Knife", WeaponType.GreatSword, 75, 60, 35, true);
            #endregion
            #region CreateRaceObjects
            //Create Race Objects for player
            
            Race elf = new Race(RaceType.Elf, "Elves are small and can only use one-handed weapons. +5 Min and Max damage and +5% HitChance.", "Skulk");
            Race dragonKin = new Race(RaceType.Draconoid, "You use the power of the dragons to imbue your weapon with flames. +10 Min and Max damage", "Firebreathing");
            Race merfolkPlayer = new Race(RaceType.Merfolk, "If you fight again another merfolk, attacks will never miss and will not be reduced by armor", "Islandwalk");
            Race giant = new Race(RaceType.Goliath, "You are big. +50 Maximum life.", "Fortified");
            Race vampirePlayer = new Race(RaceType.Vampire, "Heal 10% of the damage you deal.", "Lifelink.");
            //Create Race Objects for monsters
            Race merfolkMonster = new Race(RaceType.Merfolk, "When it fights against another merfolk, it's attacks will always land and will not be reduced by armor.", "Islandwalk");
            Race vampireMonster = new Race(RaceType.Vampire, "Heals 10% of the damage it deals.", "Lifelink.");
            Race goblin = new Race(RaceType.Goblin, "Attacks you first!", "Haste");
            Race zombie = new Race(RaceType.Zombie, "Doesn't take damage. Instead, it loses limbs.", "Decay.");
            Race werewolf = new Race(RaceType.Werewolf, "Can transform into a monsterous wolf, increasing it's stats", "Transform.");
            
            #endregion
            //Create Player Object
            Player player = new Player("", 50, 0, 100, 100, elf, sword1);
            #region Counters for menu loops
            bool playerIsChoosingWeapon = true;
            bool playerIsCreatingPlayer = true;
            bool playerIsChoosingRace = true;
            bool playerIsConfirmingStats = true;
            #endregion
            do
            {
                #region Selecting Name
                Console.Clear();
                Console.WriteLine("Please enter your character's name.");
                string playerName = Console.ReadLine();
                Console.Clear();
                player.Name = playerName;
                #endregion
                do
                {
                    #region Selecting Weapon
                    Console.WriteLine($"Your champion's name is {player.Name}.");
                    Console.WriteLine("\nChoose your weapon:\n" + "(S) Sword\n" + "(K) Knife\n" + "(A) Axe\n" + "(B) Bow\n" + "(P) Spear\n" + "(C) Club\n" + "(X) GreatAxe\n" + "(W) GreatSword\n" + "(Z) Show Weapon Descriptions");

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
                            Console.WriteLine("\n\nPresss any key to continue.\n");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Input not understood. Please try again.\n");
                            playerIsChoosingWeapon = true;
                            break;
                    }
                    #endregion
                } while (playerIsChoosingWeapon);
                Console.Clear();
                do
                {
                    #region Selecting Race
                    Console.WriteLine($"Your champion's name is {player.Name}");
                    Console.WriteLine($"You have chosen {player.EquippedWeapon.Name}");
                    if (player.EquippedWeapon.IsTwoHanded == false)
                    {
                        Console.WriteLine("Your weapon only requires 1 hand. You will be given a shield for your other hand. This will increase your Armor Class by 1.");
                        player.Block++;
                    }
                    Console.WriteLine("\nChoose a Race:" +
                    "\n(E) Elf" +
                    "\n(M) Merfolk" +
                    "\n(D) Draconoid" +
                    "\n(V) Vampire" +
                    "\n(G) Goliath" +
                    "\n(Z) Show race descriptions\n");
                    ConsoleKey raceCoice = Console.ReadKey().Key;
                    Console.Clear();
                    switch (raceCoice)
                    {
                        case ConsoleKey.E:
                            player.Race = elf;
                            if (player.EquippedWeapon.IsTwoHanded == false)
                            {
                                player.EquippedWeapon.MaxDamage += 5;
                                player.EquippedWeapon.MinDamage += 5;
                            }
                            playerIsChoosingRace = false;
                            break;
                        case ConsoleKey.M:
                            player.Race = merfolkPlayer;
                            playerIsChoosingRace = false;
                            break;
                        case ConsoleKey.V:
                            player.Race = vampirePlayer;
                            playerIsChoosingRace = false;
                            break;
                        case ConsoleKey.D:
                            player.Race = dragonKin;
                            player.EquippedWeapon.MaxDamage += 10;
                            player.EquippedWeapon.MinDamage+= 10;
                            playerIsChoosingRace = false;
                            break;
                        case ConsoleKey.G:
                            player.Race = giant;
                            player.MaxLife += 50;
                            player.Life += 50;
                            playerIsChoosingRace = false;
                            break;
                        case ConsoleKey.Z:
                            Console.WriteLine(elf + "\n");
                            Console.WriteLine(merfolkPlayer + "\n");
                            Console.WriteLine(dragonKin + "\n");
                            Console.WriteLine(vampirePlayer + "\n");
                            Console.WriteLine(giant + "\n");
                            Console.WriteLine("\n\nPresss any key to continue.\n");
                            Console.ReadKey();
                            Console.Clear();
                            playerIsChoosingRace = true;
                            break;
                        default:
                            Console.WriteLine("Input not understood. Please try again.\n");
                            playerIsChoosingRace = true;
                            break;
                    }
                    
                    #endregion
                } while (playerIsChoosingRace);
                do
                {
                    Console.WriteLine($"This is your character.\n\nName: {player.Name}\nWeapon: {(player.EquippedWeapon.IsTwoHanded ? $"{player.EquippedWeapon.Name}" : $"{player.EquippedWeapon.Name} and a shield.")}\nRace: {player.Race.RaceType}");
                    Console.WriteLine("Are these the characteristics you want? (Y/N)");
                    ConsoleKey playerCreate = Console.ReadKey().Key;
                    switch (playerCreate)
                    {
                        case ConsoleKey.Y:
                            playerIsConfirmingStats = false;
                            playerIsCreatingPlayer = false;
                            break;
                        case ConsoleKey.N:
                            playerIsConfirmingStats = false;
                            playerIsCreatingPlayer = true;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Input not understood. Please try again.\n");
                            playerIsConfirmingStats = true;
                            break;
                    }
                } while (playerIsConfirmingStats);
                if (player.Race.RaceType == RaceType.Elf && player.EquippedWeapon.IsTwoHanded == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nAn elf cannot use a two-handed weapon! Please choose again.");
                    playerIsCreatingPlayer = true;
                    Console.ResetColor();
                    Console.ReadKey();
                }
            } while (playerIsCreatingPlayer);

            int score = 0;
            bool playerIsAlive = true;//counter for gameplayloop
            bool playerIsFighting = true;//counter for the combat loop
            int lvlUp1 = 0;
            int lvlUp2 = 0;
            int lvlUp3 = 0;
            short potions = 3;
            
            do//start of gameplay loop
            {
                #region CreateMonsterObjects
                //Create Monster objects:
                Goblin g1 = new Goblin("Goblin", "Ugly, tiny, fast, and dangerous!", 30, 30, 80, 0, 10, 5, goblin, true);
                Goblin g2 = new Goblin("Bugbear", "Hairy goblinoid born for battle and mayhem.", 50, 50, 85, 1, 20, 10, goblin, true);
                Goblin g3 = new Goblin("Orc", "Orcs are a brutish, aggressive, ugly, and malevolent.", 70, 70, 90, 2, 35, 15, goblin, true);
                Zombie z1 = new Zombie("Zombie", "Falling apart at the seams.", 3, 3, 70, 0, 15, 10, zombie, true);
                Zombie z2 = new Zombie("Undead", "Reanimated by supernatural means, technology, or disease.", 4, 4, 75, 0, 25, 15, zombie, true);
                Zombie z3 = new Zombie("Redead", "Zombie-like creature living in crypts or dark and haunted places.", 5, 5, 80, 0, 35, 25, zombie, true);
                Merfolk m1 = new Merfolk("Merfolk", "Something smells fishy.", 50, 50, 80, 1, 20, 10, merfolkMonster, true);
                Merfolk m2 = new Merfolk("Waveraker", "As it thrashes, it creates the sound of thunder.", 70, 70, 85, 2, 35, 20, merfolkMonster, true);
                Merfolk m3 = new Merfolk("Whirlthrasher", "Master of waves and crusher of storms.", 90, 90, 90, 3, 55, 35, merfolkMonster, true);
                Vampire v1 = new Vampire("Vampire", "He could use some sun.", 40, 40, 95, 1, 30, 20, vampireMonster, true);
                Vampire v2 = new Vampire("Sun-Cursed", "Forever locked from the charity of light.", 50, 50, 95, 2, 40, 30, vampireMonster, true);
                Vampire v3 = new Vampire("Markov", "A direct descendant of Edgar himself.", 60, 60, 95, 3, 50, 40, vampireMonster, true);
                Werewolf w1 = new Werewolf("Werewolf", "Good dog... Bad dog?", 40, 40, 85, 0, 25, 10, werewolf, false);
                Werewolf w2 = new Werewolf("Lycan", "A massive warrior, and a monsterous wolf.", 60, 60, 90, 1, 40, 25, werewolf, false);
                Werewolf w3 = new Werewolf("Ulrich", "Master of transformation. Only a monster now.", 80, 80, 95, 2, 55, 40, werewolf, true);
                #endregion
                #region MonserCollection
                Monster[] monsters =
               {
                    g1, g1, g1, g1, g1,
                    g2, g2,
                    g3,
                    z1, z1, z1, z1, z1,
                    z2, z2,
                    z3,
                    m1, m1, m1, m1, m1,
                    m2, m2,
                    m3,
                    v1, v1, v1, v1, v1,
                    v2, v2,
                    v3,
                    w1, w1, w1, w1, w1,
                    w2, w2,
                    w3,
                };
                //Pick one at random to place in the room.
                Random rand = new Random();
                int randomNbr = rand.Next(monsters.Length);
                Monster monster = monsters[randomNbr];
                #endregion
                #region LevelUpLoop
                Console.ForegroundColor = ConsoleColor.Yellow;
                switch (score)
                {
                    case 3://Level up after 3 monster kills
                        for (int i = 0; lvlUp1 < 1; lvlUp1++)
                        {
                            Console.WriteLine("\nYou leveled up!\nYour maximum life has increased and been refilled!");
                            player.MaxLife += 50;//Increase their maximum life.
                            player.Life = player.MaxLife;//Refill their life.
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"{player.Name} has {player.Life} life remaining, out of {player.MaxLife} maximum life!");
                            Console.ReadKey();
                            Console.ResetColor();
                        }
                        break;
                    case 7://Level up after 6 monster kills
                        for (int i = 0; lvlUp2 < 1; lvlUp2++)
                        {
                            Console.WriteLine("\nYou leveled up!\nYour maximum life has increased and been refilled!");
                            player.MaxLife += 50;//Increase their maximum life.
                            player.Life = player.MaxLife;//Refill their life.
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"{player.Name} has {player.Life} life remaining, out of {player.MaxLife} maximum life!");
                            Console.ReadKey();
                            Console.ResetColor();
                        }
                        break;
                    case 12://Level up after 10 monster kills, and upgrade Equipped Weapon
                        for (int i = 0; lvlUp3 < 1; lvlUp3++)
                        {
                            if (player.EquippedWeapon == sword1)
                            {
                                player.EquippedWeapon = sword2;
                                Console.WriteLine($"\nYou found the {player.EquippedWeapon.Name}!");
                            }
                            else if (player.EquippedWeapon == knife1)
                            {
                                player.EquippedWeapon = knife2;
                                Console.WriteLine($"\nYou found the {player.EquippedWeapon.Name}!");
                            }
                            else if (player.EquippedWeapon == axe1)
                            {
                                player.EquippedWeapon = axe2;
                                Console.WriteLine($"\nYou found the {player.EquippedWeapon.Name}!");
                            }
                            else if (player.EquippedWeapon == bow1)
                            {
                                player.EquippedWeapon = bow2;
                                Console.WriteLine($"\nYou found the {player.EquippedWeapon.Name}!");
                            }
                            else if (player.EquippedWeapon == spear1)
                            {
                                player.EquippedWeapon = spear2;
                                Console.WriteLine($"\nYou found the {player.EquippedWeapon.Name}!");
                            }
                            else if (player.EquippedWeapon == club1)
                            {
                                player.EquippedWeapon = club2;
                                Console.WriteLine($"\nYou found the {player.EquippedWeapon.Name}!");
                            }
                            else if (player.EquippedWeapon == greatAxe1)
                            {
                                player.EquippedWeapon = greatAxe2;
                                Console.WriteLine($"\nYou found the {player.EquippedWeapon.Name}!");
                            }
                            else if (player.EquippedWeapon == greatSword1)
                            {
                                player.EquippedWeapon = greatSword2;
                                Console.WriteLine($"\nYou found the {player.EquippedWeapon.Name}!");
                            }
                            Console.WriteLine("\nYou leveled up!\nYour maximum life has increased and been refilled!");
                            player.MaxLife += 50;//Increase their maximum life.
                            player.Life = player.MaxLife;//Refill their life.
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"{player.Name} has {player.Life} life remaining, out of {player.MaxLife} maximum life!");
                            Console.ReadKey();
                            Console.ResetColor();
                        }
                        break;
                    case 18:
                        Console.WriteLine("\nYou leveled up!\nYour maximum life has increased and been refilled!");
                        player.MaxLife += 50;//Increase their maximum life.
                        player.Life = player.MaxLife;//Refill their life.
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"{player.Name} has {player.Life} life remaining, out of {player.MaxLife} maximum life!");
                        Console.ReadKey();
                        Console.ResetColor();
                        break;
                    case 25:
                        Console.WriteLine("\nYou leveled up!\nYour maximum life has increased and been refilled!");
                        player.MaxLife += 50;//Increase their maximum life.
                        player.Life = player.MaxLife;//Refill their life.
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"{player.Name} has {player.Life} life remaining, out of {player.MaxLife} maximum life!");
                        Console.ReadKey();
                        Console.ResetColor();
                        break;
                };
                #endregion
                Console.Clear();
                Console.ResetColor();
                GetRoom();
                

                #region Menu Loop

                do
                {
                    Console.ResetColor();
                    if (monster.Name == "Orc" || monster.Name == "Undead" || monster.Name == "Ulrich")
                    {
                        Console.Write("\nYou're fighting an"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(" {0}!\n{1}\n", monster.Name, monster.Description); Console.ResetColor();
                        Console.WriteLine(monster.Description);

                    }
                    else
                    {
                        Console.Write("\nYou're fighting a"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(" {0}!\n{1}\n", monster.Name, monster.Description); Console.ResetColor();

                    }

                    Console.ResetColor();
                    playerIsFighting = true;
                    Console.WriteLine("\nChoose an action:\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "H) Heal\n" +
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
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("\nYou killed {0}", monster.Name);
                                Console.ResetColor();
                                score++;
                                Random potRNG = new Random();
                                int roll = rand.Next(1, 11);
                                if (roll == 10)
                                {
                                    potions++;
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine($"{player.Name} found a health potion!");
                                }
                                Console.ReadKey();
                                playerIsFighting = false;
                            }
                            break;
                        case "R":
                            Console.WriteLine("Running away!");
                            Console.WriteLine($"{monster.Name} attacks you as you flee!");
                            Combat.DoAttack(monster, player);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"{player.Name} has {player.Life} life remaining, out of {player.MaxLife} maximum life!");
                            playerIsFighting = false;
                            Console.ReadKey();
                            break;
                        case "H":
                            if (player.Life == player.MaxLife)
                            {
                                Console.WriteLine("Oops! You are at full HP! You can't use a health potion!");
                            }
                            else if (potions <= 0)
                            {
                                Console.WriteLine("You are all out of health potions!");
                            }
                            else
                            {
                                potions--;
                                player.Life += 50;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"{player.Name} drank a health potion and regained 50 life!");
                                Console.WriteLine($"{potions} health potions left!\n");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"{player.Name} has {player.Life} life remaining, out of {player.MaxLife} maximum life!\n");
                                Combat.DoAttack(monster, player);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"{player.Name} has {player.Life} life remaining, out of {player.MaxLife} maximum life!");
                                Console.WriteLine($"{monster.Name} has {monster.Life} life remaining, out of {monster.MaxLife} maximum life!");
                            }
                            break;
                        case "P":
                            Console.WriteLine($"{player}\nHealth Potions: {potions}");
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
                        Console.ForegroundColor = ConsoleColor.Blue; Console.Write(player.Name); Console.ForegroundColor = ConsoleColor.Red; Console.Write(" has died!"); Console.ResetColor();
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
            Console.WriteLine("Press any key to view your score.");
            Console.ReadKey();
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
