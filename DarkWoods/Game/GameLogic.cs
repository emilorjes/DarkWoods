using DarkWoods.Game;
using DarkWoods.Monster;
using DarkWoods.Player;
using DarkWoods.Shop;
using DarkWoods.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace DarkWoods.Game
{
    class GameLogic
    {
        //===================================================================================================================================================================================
        // GameLogic
        //===================================================================================================================================================================================
        public static List<Monster.Monster> listOfMOnsters = new List<Monster.Monster>() 
        {Creekjumper.creekjumper, Deathrunner.deathrunner, Earthcrawler.earthcrawler, Swampdemon.swampdemon, Treedropper.treedropper};
        public static List<Player.Player> playerList = new List<Player.Player> { Player.Player.player };
        public static Random rand = new Random();

        public static void NewGame()
        {
            GameLogic.GameIntro();
            GameLogic.MainMenu();
        }
        private static void GameIntro()
        {
            GameLogo();
            StoryVisualText.IntroText();
            ChoosePlayerAndWeponNames();
        }
        private static void MainMenu()
        {
            bool keepMenuGo = true;
            do
            {
                Console.WriteLine("1.  Enter the Darkwoods.....");
                Console.WriteLine("2.  Show details about your character");
                Console.WriteLine("3.  Show details about monsters");
                Console.WriteLine("4.  Go to shop.");
                Console.WriteLine("5.  Exit\n");
                Console.Write("Your coice: ");
                string menuChoiceString = Console.ReadLine();
                ErrorHandling.FiveChoiceMenuHandling(menuChoiceString);

                Console.Clear();

                switch (menuChoiceString)
                {
                    case "1":
                        EnterDarkwoods();
                        break;
                    case "2":
                        Player.Player.PrintPlayerInfo(playerList[0]);
                        break;
                    case "3":

                        break;
                    case "4":
                        Shop.Shop.ShopCabin();
                        break;
                    case "5":
                        Exit();
                        break;

                }

                Console.Clear();

            } while (keepMenuGo);
        }
        private static void EnterDarkwoods()
        {

            bool keepMenuGo = true;
            string menuChoiceString;
            Console.WriteLine($"You have entered the Darkwoods {Player.Player.player.PlayerName}............... Stay safe my friend..... \n");



            do
            {
                Console.WriteLine($"1.  Explore the Darkwoods");
                Console.WriteLine($"2.  Leave the Darkwoods \n");
                Console.Write("Your choice: ");
                menuChoiceString = Console.ReadLine();

                ErrorHandling.TwoChoiceMenuHandling(menuChoiceString);

                Console.Clear();

                switch (menuChoiceString)
                {
                    case "1":
                        ExploreDarkwoods();
                        break;
                    case "2":
                        keepMenuGo = false;
                        break;
                }

                Console.Clear();

            } while (keepMenuGo);
        }

        private static void ExploreDarkwoods()
        {


            int randomMonster = rand.Next(listOfMOnsters.Count);
            MonsterAppear(listOfMOnsters[randomMonster]);
            bool keepMenuGo = true;
            string menuChoiceString;

           



            do
            {
                
                Console.WriteLine($"1.  Attack!");
                Console.WriteLine($"2.  Flee...... \n");
                Console.Write("Your choice: ");
                menuChoiceString = Console.ReadLine();

                ErrorHandling.TwoChoiceMenuHandling(menuChoiceString);

                Console.Clear();

                switch (menuChoiceString)
                {
                    case "1":
                        AttackMonster(listOfMOnsters[randomMonster]);
                        break;
                    case "2":
                        keepMenuGo = false;
                        PlayerMOnsterFUllHp(listOfMOnsters[randomMonster]);
                       break;
                    
                }

                Console.Clear();

            } while (keepMenuGo);
        }

        private static void MonsterAppear(Monster.Monster monster)
        {

            Console.WriteLine($"Watch out! An ancient {monster.MonsterName} level {monster.MonsterLevel} is blocking your way\n");
        }
        private static void AttackMonster(Monster.Monster monster)
        {
            int randomPlayerDmg = rand.Next(1, 50);
            Player.Player.player.PlayerDmg = randomPlayerDmg;
            int randomMonsterDmg = rand.Next(1, 25);
            monster.MonsterAtkDmg = randomMonsterDmg;
            Console.WriteLine($"You attack the {monster.MonsterName} with your {Player.Player.player.PlayerWepon} and deal {Player.Player.player.PlayerDmg} damage.");
            monster.MonsterHp = monster.MonsterHp - Player.Player.player.PlayerDmg;
            Console.WriteLine($"The {monster.MonsterName} life is {monster.MonsterHp} / {monster.MonsterMaxHp}.\n");
            Console.WriteLine($"The {monster.MonsterName} attack you with {monster.MonsterAtkName} and deal {monster.MonsterAtkDmg}.");
            Player.Player.player.PlayerHp = Player.Player.player.PlayerHp - monster.MonsterAtkDmg;
            Console.WriteLine($"Your life is {Player.Player.player.PlayerHp} / 100 ");
            Console.ReadLine();
        }
        private static void PlayerMOnsterFUllHp(Monster.Monster monster)
        {
            Player.Player.player.PlayerHp = 100;
            monster.MonsterHp = monster.MonsterMaxHp;
        }

        private static void GameLogo()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("     WELCOME TO THE DARKWOODS     ");
            Console.WriteLine("==================================");
        }
        


        private static void ChoosePlayerAndWeponNames()
        {
            Console.WriteLine("Choose a name for your.... ");
            Console.Write("Hero:");
            Player.Player.player.PlayerName = Console.ReadLine();
            Console.Write("Wepon: ");
            Player.Player.player.PlayerWepon = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Hello {Player.Player.player.PlayerName}!");
        }


        private static void Exit()
        {
            Console.Write("The Darkwoods awiats you......\n\n\n");
            Environment.Exit(0);
        }


    }
}
