namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool validInput = false;

            while (validInput == false)
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
                        validInput = true;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Load();
                        validInput = true;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Settings();
                        validInput = true;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Exit();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong Input");
                        break;
                }

            }
        }
           
            
        

        public static void CharacterCreation()
        {
            Console.Clear();
            Console.WriteLine("Aye");
            string I = Console.ReadLine();
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
            Environment.Exit(0);
        }
    }
}
