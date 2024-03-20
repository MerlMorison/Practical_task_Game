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
            Console.WriteLine("\n\r\n█▀▄ █▀█   █▄█ █▀█ █░█   █░█░█ ▄▀█ █▄░█ ▀█▀   ▀█▀ █▀█   █▀ ▀█▀ ▄▀█ █▀█ ▀█▀ ▀█   ▄▀ █▄█ █▀▀ █▀   ░░▄▀   █▄░█ █▀█ ▀▄" +
                                "\r\n█▄▀ █▄█   ░█░ █▄█ █▄█   ▀▄▀▄▀ █▀█ █░▀█ ░█░   ░█░ █▄█   ▄█ ░█░ █▀█ █▀▄ ░█░ ░▄   ▀▄ ░█░ ██▄ ▄█   ▄▀░░   █░▀█ █▄█ ▄▀" +
                                "\r\n");
            Console.ResetColor();
            string choise = Console.ReadLine();
            choise = choise.ToLower();
            while (choise != "yes" && choise != "no")
            {
                Console.WriteLine("\nPlease write yes or no\n");
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
                    Console.WriteLine($"\n█░░ █▀▀ ▀█▀ ▀ █▀   ▀█▀ ▄▀█ █▄▀ █▀▀   ▄▀█   █░░ █▀█ █▀█ █▄▀   ▄▀█ ▀█▀   █▄█ █▀█ █░█ █▀█   █▀ █▀▀ █▀█ █▀█ █▀▀" +
                                      $"\n█▄▄ ██▄ ░█░ ░ ▄█   ░█░ █▀█ █░█ ██▄   █▀█   █▄▄ █▄█ █▄█ █░█   █▀█ ░█░   ░█░ █▄█ █▄█ █▀▄   ▄█ █▄▄ █▄█ █▀▄ ██▄" +
                                      $"\n" +
                                      $"\n█▀▀ █▀█ █▀█   ▀█▀ █░█ █ █▀   █▀ █▀▀ █▀ █▀ █ █▀█ █▄░█ ▀" +
                                      $"\n█▀░ █▄█ █▀▄   ░█░ █▀█ █ ▄█   ▄█ ██▄ ▄█ ▄█ █ █▄█ █░▀█ ▄");
                    Console.ResetColor();

                    Player.PlayersData(games, win);
                    Console.ResetColor();


                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n\r\n█▀▄ █▀█   █▄█ █▀█ █░█   █░█░█ ▄▀█ █▄░█ ▀█▀   ▀█▀ █▀█   █▀█ █░░ ▄▀█ █▄█   ▄▀█ █▀▀ ▄▀█ █ █▄░█ ▀█   " +
                                        "\r\n█▄▀ █▄█   ░█░ █▄█ █▄█   ▀▄▀▄▀ █▀█ █░▀█ ░█░   ░█░ █▄█   █▀▀ █▄▄ █▀█ ░█░   █▀█ █▄█ █▀█ █ █░▀█ ░▄   " +
                                        "\r\n" +
                                        "\r\n▄▀ █▄█ █▀▀ █▀     ▄▀    █▄ █ █▀█ ▀▄" +
                                        "\r\n▀▄  █  ██▄ ▄█   ▄▀      █ ▀█ █▄█ ▄▀" +
                                        "\r\n");
                    Console.ResetColor();
                    choise = Console.ReadLine();
                    choise = choise.ToLower();
                    while (choise != "yes" && choise != "no")
                    {
                        Console.WriteLine("\nPlease write yes or no\n");
                        choise = Console.ReadLine();
                        choise = choise.ToLower();
                    }
                }
            }

        }
    }
}
