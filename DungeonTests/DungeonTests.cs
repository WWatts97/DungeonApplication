using Dungeon_Library;
using DungeonLibrary;

namespace DungeonTests
{
    public class DungeonTests
    {
        [Fact]
        public void Test_CalcBlock()//Test1
        {
            //Arranage
            Race race = new Race(RaceType.Elf, "Small", "Small Again");
            Weapon weapon = new Weapon("Sharp Sword", WeaponType.Sword, 20, 10, 30, false);
            Player player = new Player("JIM", 50, 1, 100, 100, race, weapon);
            //Act
            int doBLock = player.CalcBlock();
            //Assert
            Assert.True(doBLock >= 0 && doBLock <= 5 );
        }

        [Fact]
        public void Test_CalcHitChance()//Test2
        {
            //Arranage
            Race race = new Race(RaceType.Elf, "Small", "Small Again");
            Weapon weapon = new Weapon("Sharp Sword", WeaponType.Sword, 20, 10, 30, false);
            Player player = new Player("JIM", 50, 1, 100, 100, race, weapon);
            int expectedHitChance = 80;
            //Act
            int doHitChance = player.CalcHitChance();
            //Assert
            Assert.Equal(doHitChance, expectedHitChance);
        }

        [Fact]
        public void Test_CalcDamage_Monster()//Test3
        {
            //Arranage
            Race race = new Race(RaceType.Elf, "Small", "Small Again");
            Goblin monster = new Goblin("", "", 10, 10, 80, 0, 20, 10, race, true);
            //Act
            int doDamage = monster.CalcDamage();
            //Assert
            Assert.True(doDamage >= 10 && doDamage <= 20 );
        }

        [Fact]
        public void Test_CalcDamage_Player()//Test4
        {
            //Arranage
            Race race = new Race(RaceType.Elf, "Small", "Small Again");
            Weapon weapon = new Weapon("Sharp Sword", WeaponType.Sword, 20, 10, 30, false);
            Player player = new Player("JIM", 50, 1, 100, 100, race, weapon);
            //Act
            int doDamage = player.CalcDamage();
            //Assert
            Assert.True(doDamage >= 10 && doDamage <= 20);
        }

        [Fact]
        public void Test_DoAttack()//Test5
        {
            //Arranage
            Race race = new Race(RaceType.Elf, "Small", "Small Again");
            Weapon weapon = new Weapon("Sharp Sword", WeaponType.Sword, 20, 10, 30, false);
            Player player = new Player("JIM", 50, 1, 100, 100, race, weapon);
            Goblin monster = new Goblin("", "", 10, 10, 80, 0, 20, 10, race, true);
            int playerBeforeBattleHP = player.Life;
            int monsterBeforeBattleHP = monster.Life;
            //Act
            Combat.DoAttack(player, monster);
            //Assert
            Assert.True(player.Life <= playerBeforeBattleHP && monster.Life <= monsterBeforeBattleHP);
        }

        [Fact]
        public void Test_DoBattle()//Test6
        {
            //Arranage
            Race race = new Race(RaceType.Elf, "Small", "Small Again");
            Weapon weapon = new Weapon("Sharp Sword", WeaponType.Sword, 20, 10, 30, false);
            Player player = new Player("JIM", 50, 1, 100, 100, race, weapon);
            Goblin monster = new Goblin("", "", 10, 10, 80, 0, 20, 10, race, true);
            int playerBeforeBattleHP = player.Life;
            int monsterBeforeBattleHP = monster.Life;
            //Act
            Combat.DoAttack(player, monster);
            //Assert
            Assert.True(player.Life <= playerBeforeBattleHP && monster.Life <= monsterBeforeBattleHP);
        }
    }
}