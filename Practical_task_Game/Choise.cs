namespace Practical_task_Game
{
    internal class Choise
    {
        public static string name;
        public static void PlayersChoise()
        {
            Console.WriteLine("Do you want to continue? (yes|no)");
            string choise = Console.ReadLine();
            choise = choise.ToLower();
            while (choise != "yes" && choise != "no")
            {
                Console.WriteLine("Please write yes or no");
                choise = Console.ReadLine();
                choise = choise.ToLower();
            }
            if (choise == "no")
            {
                Console.WriteLine($"Good bye {name}");
                return;
            }
        }
    }
}
