using DarkWoods.Player;
using DarkWoods.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace DarkWoods.Shop
{
    class Shop
    {
        private int addStrenght;
        private int addToughness;
        private int strenghtPrice;
        private int toughnessPrice;
        private int zeroGold;

        public int AddStrenght { get => addStrenght; set => addStrenght = value; }
        public int AddToughness { get => addToughness; set => addToughness = value; }
        public int StrenghtPrice { get => strenghtPrice; set => strenghtPrice = value; }
        public int ToughnessPrice { get => toughnessPrice; set => toughnessPrice = value; }
        public int ZeroGold { get => zeroGold; set => zeroGold = value; }

        public Shop()
        {

        }
        public Shop(int addStrenght, int addToughness, int strenghtPrice, int toughnessPrice, int zeroGold)
        {
            this.AddStrenght = addStrenght;
            this.AddToughness = addToughness;
            this.StrenghtPrice = strenghtPrice;
            this.ToughnessPrice = toughnessPrice;
            this.ZeroGold = zeroGold;


        }


        public static Shop cabinShop = new Shop(20, 20, 50, 50, default);

        public static void ShopCabin()
        {
            bool keepMenuGo = true;
           
            Console.WriteLine("Welcom to The Cabin Store, what can i help you with traveller?\n");
            do
            {
                Console.WriteLine($"Current Gold ammount: {Player.Player.player.PlayerGold} \n");
                Console.WriteLine($"1.  Buy Strenght Amulette: {cabinShop.StrenghtPrice} Gold.");
                Console.WriteLine($"2.  Buy Toughness Amulette: {cabinShop.ToughnessPrice} Gold.");
                Console.WriteLine($"3.  Leave the shop \n");
                Console.Write("Your choice: ");
               
                string menuChoiceString = Console.ReadLine();
                ErrorHandling.ThreeChoiceMenuHandling(menuChoiceString);
               
                Console.Clear();

                switch (menuChoiceString)
                {
                    case "1":
                        BuyStrenght();
                        break;
                    case "2":
                        BuyToughness();
                        break;
                    case "3":
                        keepMenuGo = false;
                        break;
                }

                Console.Clear();

            } while (keepMenuGo);
        }


        private static void BuyStrenght()
        {

            if (Player.Player.player.PlayerGold < cabinShop.StrenghtPrice || Player.Player.player.PlayerGold <= cabinShop.ZeroGold)
            {
                NotEnoughMoney();
            }
            else
            {
                Player.Player.player.PlayerStrenght += cabinShop.AddStrenght;
                Console.WriteLine($"You added {cabinShop.AddStrenght} points to your Toughness! Your toughness is now {Player.Player.player.PlayerStrenght}. ");
            }
        }


        private static void BuyToughness()
        {

            if (Player.Player.player.PlayerGold < cabinShop.ToughnessPrice || Player.Player.player.PlayerGold <= cabinShop.ZeroGold)
            {
                NotEnoughMoney();
            }
            else
            {
                Player.Player.player.PlayerToughness += cabinShop.AddToughness;
                Console.WriteLine($"You added {cabinShop.AddToughness} points to your Toughness! Your toughness is now {Player.Player.player.PlayerToughness}. ");
            }

        }


        private static void NotEnoughMoney()
        {
            Console.WriteLine("You don't have enough gold to buy this item. Kill more monsters to earn more gold.");
            Console.WriteLine($"Current Gold: {Player.Player.player.PlayerGold}");
            Console.ReadLine();
        }
    }
}
