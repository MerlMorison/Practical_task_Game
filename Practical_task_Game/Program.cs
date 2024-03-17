namespace Practical_task_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int games = 0;
            int win = 0;
            Console.WriteLine("Hello, please enter your data:");

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

            }
            Player.PlayersData(name, age, 0, 0);



            Console.WriteLine("\nDo you want to start? (yes|no)");
            string choise = Console.ReadLine();
            choise = choise.ToLower();
            while (choise != "yes" && choise != "no")
            {
                Console.WriteLine("Please write yes or no");
                choise = Console.ReadLine();
                choise = choise.ToLower();
            }
            while (choise == "yes" && choise != "no")
            {
                games++;
                win += DetermineWinner.Game();
                Player.PlayersData(name, age, games, win);

                Console.WriteLine("\nDo you want to play again? (yes|no)");
                choise = Console.ReadLine();
                choise = choise.ToLower();
                while (choise != "yes" && choise != "no")
                {
                    Console.WriteLine("Please write yes or no");
                    choise = Console.ReadLine();
                    choise = choise.ToLower();
                }
            }
            Console.WriteLine($"Good bye {name}");

        }
    }
}

