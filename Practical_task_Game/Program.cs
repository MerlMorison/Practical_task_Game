namespace Practical_task_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

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

                MakeAChoise.ChoiseStart();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Thank you, {name}, for playing with us! Goodbye!");
                Console.ResetColor();
            }

        }
    }
}

