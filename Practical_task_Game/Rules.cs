namespace Practical_task_Game
{
    internal class Rules
    {
        public static void RulesText()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nRules of the game:");
            Console.ResetColor();
            Console.WriteLine("You have to play three rounds in one game, and during each round you choose your weapon: Rock, Scissors or Paper. \nAfter you, the AI chooses its weapon, and then the program chooses the winner based on the following criteria:\n - Paper wins over stones, but loses to scissors\n - Scissors win over paper, but lose to stones\n - Rocks beat scissors but lose to paper");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n\nLET'S START!!!");
            Console.ResetColor();
        }

    }
}
