namespace Practical_task_Game
{
    internal class MakeAChoise
    {
        public static string name;
        public static void ChoiseStart()
        {
            int games = 0;
            int win = 0;
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
            if (choise == "yes")
            {
                Rules.RulesText();

                while (choise == "yes" && choise != "no")
                {
                    games++;
                    win += GameBody.Game();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nLet's take a look at your score for this session:");
                    Console.ResetColor();

                    Player.PlayersData(games, win);
                    Console.ResetColor();


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
            }

        }
    }
}
