
namespace Practical_task_Game
{
    internal class Program
    {
        public static void PlayersData(string name, int age, int games, int wins)
        {
            Console.WriteLine($"Name: {name} \nAge: {age} \nPlayed rounds: {games} \nWins: {wins}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter your data:");

            int games = 0;
            int wins = 0;

            Console.Write("Write your name: ");
            string name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Empty name data");
                Console.Write("Write your name: ");
                name = Console.ReadLine();
            }

            Console.Write("Write your age: ");
            string ageData = Console.ReadLine();
            while (string.IsNullOrEmpty(ageData) || !int.TryParse(ageData, out _))
            {
                Console.WriteLine("Invalid age data");
                Console.Write("Write your age: ");
                ageData = Console.ReadLine();
            }

            int age = int.Parse(ageData);
            if (age < 12)
            {
                Console.WriteLine("Age must be 12 or older to play.");
                return;
            }

            PlayersData(name, age, games, wins);
            Console.WriteLine("Do you want to start? (yes|no)");
        }
    }
}
