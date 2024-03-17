namespace Practical_task_Game
{
    internal class Player
    {
        public static string name;
        public static int age;
        public static int win;
        public static int games;

        public static void PlayersData(string name, int age, int games, int win)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Name: {name} \nAge: {age} \nPlayed games: {games} \nWins: {win}");
            Console.ResetColor();
        }
        public static void PlayersData(int games, int win)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Played games: {games} \nWins: {win}");
            Console.ResetColor();
        }
    }
}
