namespace _56_Game_Rules_Constants
{
   public class GameRules
    {
        public const int MAX_LEVEL = 50;
        public const int STARTING_HEALTH = 100;
        public const int MAX_INVENTORY = 20;
        public static void DisplayRules()
        {
            Console.WriteLine("Game Rules:\n");
            Console.WriteLine($"Maximum Level: {MAX_LEVEL}");
            Console.WriteLine($"Starting Health: {STARTING_HEALTH}");
            Console.WriteLine($"Maximum Inventory: {MAX_INVENTORY}");
        }
    }   
}
