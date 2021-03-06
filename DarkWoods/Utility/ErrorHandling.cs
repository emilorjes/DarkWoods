﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DarkWoods.Utility
{
    class ErrorHandling
    {
        public static void ErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong input, try again...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }


        public static void FiveChoiceMenuHandling(string menuChoiceString)
        {
            if (!int.TryParse(menuChoiceString, out int menuChoiceInt) || menuChoiceInt < 1 || menuChoiceInt > 5)
            {
                ErrorMessage();
            }
           
        }
        public static void FourChoiceMenuHandling(string menuChoiceString)
        {
            if (!int.TryParse(menuChoiceString, out int menuChoiceInt) || menuChoiceInt < 1 || menuChoiceInt > 4)
            {
                ErrorMessage();
            }
        }
        public static void ThreeChoiceMenuHandling(string menuChoiceString)
        {
            if (!int.TryParse(menuChoiceString, out int menuChoiceInt) || menuChoiceInt < 1 || menuChoiceInt > 3)
            {
                ErrorMessage();
            }
        }
        public static void TwoChoiceMenuHandling(string menuChoiceString)
        {
            if (!int.TryParse(menuChoiceString, out int menuChoiceInt) || menuChoiceInt < 1 || menuChoiceInt > 2)
            {
                ErrorMessage();
            }
        }

    }
}
