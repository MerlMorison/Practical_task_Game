namespace Practical_task_Game
{
    internal class Player
    {
        public static string name;
        public static int age;
        public static int win;
        public static int games;
        public static void PlayerID()
        {
            
        }
        public static void PlayersData(string name, int age, int games, int win)
        {
            Console.WriteLine($"Name: {name} \nAge: {age} \nPlayed games: {games} \nWins: {win}");
        }
        public static void PlayersData(int games, int win)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nLet's take a look at your score for this session:");
            Console.ResetColor();
            Console.WriteLine($"Played games - {games} \nWins - {win}");
        }
    }
}
