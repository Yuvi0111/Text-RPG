using System.Drawing.Printing;
using System.Net.Cache;

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
                    "Hint: Press any numbers such as \"1\", \"2\", \"3\" etc for input THROUGHOUT the game... " +
                    "\n");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        loops.validInput = true;
                        CharacterCreation();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        loops.validInput = true;
                        Load();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        loops.validInput = true;
                        Settings();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Exit();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong input, are you sure you are hitting the right number keys?");
                        break;
                }

            }
        }




        public static void CharacterCreation()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            CharacterInfo mainChar = new CharacterInfo();
            Class charClass = new Class();

            Console.WriteLine("Create your character: \n" +
                "\n" +
                "\n");
            Console.Write("Name: ");
            mainChar.Name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" \n \n \nClasses: 1. Fighter \n" +
               "Fighters have mastered the art of combat, wielding weapons with unmatched skill and wearing armour like a second skin. \n \n \n" +
               "2. Cleric \n" +
               "Clerics are representatives of the gods they worship, wielding potent divine magic for good or ill. \n \n \n" +
               "3. Rogue \n" +
               "With stealth, skill and uncanny reflexes, a rogue's versatility lets them get the upper hand in almost any situation. \n \n \n" +
               "4. Wizard \n" +
               "Wizards master the arcane by specialising in individual schools of magic, combining ancient spells with modern research. \n \n \n");

            string Class = null;
            Loops loops = new Loops();
            while (loops.validInput == false)
            {
                Console.Write("Choose an option: ");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        mainChar.Class = charClass.Fighter;
                        Class = "Fighter";
                        loops.validInput = true;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        mainChar.Class = charClass.Cleric;
                        Class = "Cleric";
                        loops.validInput = true;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        mainChar.Class = charClass.Rogue;
                        Class = "Rogue";
                        loops.validInput = true;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        mainChar.Class = charClass.Wizard;
                        Class = "Wizard";
                        loops.validInput = true;
                        break;
                    default:
                        Console.WriteLine(" Wrong input, are you sure you are hitting the right number keys?");
                        break;
                }

            }
            Console.WriteLine("\nClass: " + Class);
            
            loops.validInput = false;
            while (loops.validInput == false)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\n\n\nType character age:");
                string Age = Console.ReadLine();
                try
                {
                    mainChar.Age = Convert.ToInt16(Age);
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nERROR ENCOUNTERED: Invalid format, only use INTEGERS (1, 2, 3 etc...) for age.");
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nERROR ENCOUNTERED: The age is absurdly big. Follow the guideline in the message below.");
                }
                finally
                {
                }
                switch (mainChar.Age)
                {
                    case < 18:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nERROR ENCOUNTERED: The age needs to be in the range 18 years - 110 years");
                        break;
                    case > 100:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nERROR ENCOUNTERED: The age needs to be in the range 18 years - 110 years");
                        break;
                    default:
                        loops.validInput = true;
                        break;
                }
            }
            

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