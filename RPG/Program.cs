﻿using System.Drawing.Printing;

namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Loops loops = new Loops();
            while (loops.validInput == false)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=- TEXT RPG -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= \n" +
                    "\n" +
                    "1. Create a character \n" +
                    "2. Load \n" +
                    "3. Settings \n" +
                    "4. Exit \n" +
                    "Hint: Press any numbers such as \"1\", \"2\", \"3\" etc for input... " +
                    "\n");
                ConsoleKeyInfo menuInput = Console.ReadKey();
                switch (menuInput.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        CharacterCreation();
                        loops.validInput = true;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Load();
                        loops.validInput = true;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Settings();
                        loops.validInput = true;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Exit();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong Input, are you sure you are hitting the right number keys?");
                        break;
                }

            }
        }
           
            
        

        public static void CharacterCreation()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            
            CharacterInfo mainChar = new CharacterInfo();
            Console.WriteLine("Create your character: \n" +
                "\n" +
                "\n");
            Console.Write("Name: ");
            mainChar.Name = Console.ReadLine();
            Console.WriteLine("Class: 1. Barbarian \n" +
                "The strong embrace the wild that hides inside - keen instincts, primal physicality, and most of all, an unbridled, unquenchable rage. \n \n \n" +
                "2. Cleric \n" +
                "Clerics are representatives of the gods they worship, wielding potent divine magic for good or ill. \n \n \n" +
                "3. Rogue \n" +
                "With stealth, skill and uncanny reflexes, a rogue's versatility lets them get the upper hand in almost any situation. \n \n \n" +
                "4. Wizard \n" +
                "Wizards master the arcane by specialising in individual schools of magic, combining ancient spells with modern research. \n \n \n");

        }

        private static void Load()
        {
            Console.Clear();

        }

        private static void Settings() 
        {
            Console.Clear();

        }

        private static void Exit()
        {
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("Hope you had a fun time, come back again. " +
                "Press Enter to exit \n \n \n \n \n \n");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("You need to press the ENTER key to exit the game, \n" +
                    "One of the ENTER keys should be on the far right bottom of the keyboard beside the numpad keys, \n" +
                    "The other ENTER key should be near your number keys (->, <- etc...), above your shift button.");
            }
            Environment.Exit(0);
        }
    }   
}
// TODO:
// 1. Create a Character Creation Screen
// 2. Create the settings Menu
// 3. Add a starting point
// 4. Refine Exitting the program (COMPLETED)