namespace Practical_task_Game
{
    internal class Program
    {
        public static int wins;
        public static int games;
        static void Main(string[] args)
        {
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
                return;
            }

            PrintPlayersData.PlayersData(name, age, games, wins);
            Console.WriteLine("Do you want to start? (yes|no)");
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

                DetermineWinner.Game();

                PrintPlayersData.PlayersData(name, age, games, wins);
                Console.WriteLine("Do you want to play again? (yes|no)");
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

            /*
            Console.WriteLine($"Chose your weapon by number where stone - 1,scissors - 2, paper - 3");
            Weapon playersWeapon = (Weapon)int.Parse(Console.ReadLine());
            int playersWeaponID = (int)playersWeapon;
            if (playersWeaponID < 1 || playersWeaponID > 3)
            {
                Console.WriteLine("Wrong number");
                Console.WriteLine($"Chose your weapon by number where stone - 1,scissors - 2, paper - 3");
                playersWeapon = (Weapon)int.Parse(Console.ReadLine());
                playersWeaponID = (int)playersWeapon;
            }
            else
            {
                while (attempts > 0)
                {
                    int AIWeapon = randomN.Next(1, 4);
                    DetermineWinner.Winner(playersWeaponID, AIWeapon);
                    Console.WriteLine(attempts);
                }
                games++;
            }
            PrintPlayersData.PlayersData(name, age, games, wins);
            Choise.PlayersChoise();
            */
        }
    }
}

