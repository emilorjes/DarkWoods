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
        public static List<Player.Player> playerList = new List<Player.Player> { Player.Player.player };
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
