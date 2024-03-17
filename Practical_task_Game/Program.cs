namespace Practical_task_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int games = 0;
            int win = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the game Rock, Scissors, Paper!:");
            Console.ResetColor();

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
                Console.WriteLine("Your age must be 12 or older to play. Wait a couple years and come back to us!");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nLets check your data:");
                Console.ResetColor();
                Player.PlayersData(name, age, 0, 0);


                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nDo you want to start? (Yes|No)");
                Console.ResetColor();
                string choise = Console.ReadLine();
                choise = choise.ToLower();
                while (choise != "yes" && choise != "no")
                {
                    Console.WriteLine("Please write yes or no");
                    choise = Console.ReadLine();
                    choise = choise.ToLower();
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nRules of the game:");
                Console.ResetColor();
                Console.WriteLine("You have to play three rounds in one game, and during each round you choose your weapon: Rock, Scissors or Paper. \nAfter you, the AI chooses its weapon, and then the program chooses the winner based on the following criteria:\n - Paper wins over stones, but loses to scissors\n - Scissors win over paper, but lose to stones\n - Rocks beat scissors but lose to paper");
                while (choise == "yes" && choise != "no")
                {
                    games++;
                    win += DetermineWinner.Game();
                    Player.PlayersData(games, win);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nDo you want to play again? (Yes|No)");
                    Console.ResetColor();
                    choise = Console.ReadLine();
                    choise = choise.ToLower();
                    while (choise != "yes" && choise != "no")
                    {
                        Console.WriteLine("Please write yes or no");
                        choise = Console.ReadLine();
                        choise = choise.ToLower();
                    }
                }
                Console.WriteLine($"Thank you, {name}, for playing with us! Goodbye!");
            }

        }
    }
}

