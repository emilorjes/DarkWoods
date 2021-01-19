using System;
using System.Collections.Generic;
using System.Text;

namespace DarkWoods.Player
{
    class Player
    {
        private string playerName;
        private int playerLevel;
        private int playerExp;
        private int playerHp;
        private string playerWepon;
        private int playerGold;
        private int playerStrenght;
        private int toughness;
        private int playerDmg;

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }
        public int PlayerLevel
        {
            get { return playerLevel; }
            set { playerLevel = value; }
        }
        public int PlayerExp
        {
            get { return playerExp; }
            set { playerExp = value; }
        }
        public int PlayerHp
        {
            get { return playerHp; }
            set { playerHp = value; }
        }
        public string PlayerWepon
        {
            get { return playerWepon; }
            set { playerWepon = value; }
        }
        public int PlayerGold
        {
            get { return playerGold; }
            set { playerGold = value; }
        }
        public int PlayerStrenght
        {
            get { return playerStrenght; }
            set { playerStrenght = value; }
        }
        public int PlayerToughness
        {
            get { return toughness; }
            set { toughness = value; }
        }
        public int PlayerDmg
        {
            get { return playerDmg; }
            set { playerDmg = value; }
        }


        public Player()
        {

        }
        public Player(string playerName, int playerLevel, int playerExp, int playerHp, string playerWepon, int playerGold, int playerStrength, int playerToughness, int playerDmg)
        {
            this.PlayerName = playerName;
            this.PlayerLevel = playerLevel;
            this.PlayerExp = playerExp;
            this.PlayerHp = playerHp;
            this.PlayerWepon = playerWepon;
            this.PlayerGold = playerGold;
            this.PlayerStrenght = playerStrength;
            this.PlayerToughness = playerToughness;
        }
        public static Player player = new Player(" ", 1, default, 100, " ", default, default, default,default);

        public static void PrintPlayerInfo(Player player)
        {
            Console.Write("Name: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(player.PlayerName);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nLevel: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(player.PlayerLevel);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nHP: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{player.PlayerHp} / 200");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nEXP: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{player.PlayerExp} / 100");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nGold: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(player.PlayerGold);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nStrength: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(player.PlayerStrenght);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nToughness: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(player.PlayerToughness);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nWepon: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(player.PlayerWepon);
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadLine();
        }
    }
}
