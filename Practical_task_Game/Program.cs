namespace Practical_task_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello/ enter your data");

            int playedGames = 0;
            int winsStatistic = 0;

            Console.Write("Write your name: ");
            string playerName = Console.ReadLine();
            while (string.IsNullOrEmpty(playerName))
            {
                Console.WriteLine("Empty name data");
                Console.Write("Write your name: ");
                playerName = Console.ReadLine();
            }
            Console.Write("Write your age: ");
            var ageData = Console.ReadLine();

            while (string.IsNullOrEmpty(ageData))
            {
                Console.WriteLine("Empty age data");
                Console.Write("Write your age: ");
                ageData = Console.ReadLine();
            }

            int ageCheck = int.Parse(ageData);
            if (ageCheck < 12)
            {
                Console.WriteLine("Age < 12");
                return;

            }
            Console.WriteLine($"Name: {playerName} \nAge: {ageData} \nPlayed rounds: {playedGames} \nWins: {winsStatistic}");




        }
    }
}
