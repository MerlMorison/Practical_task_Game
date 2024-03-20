namespace Practical_task_Game
{
    internal class Rules
    {
        public static void RulesText()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\r\n█▀█ █░█ █░░ █▀▀ █▀   █▀█ █▀▀   ▀█▀ █░█ █▀▀   █▀▀ ▄▀█ █▀▄▀█ █▀▀ ▀" +
                                "\r\n█▀▄ █▄█ █▄▄ ██▄ ▄█   █▄█ █▀░   ░█░ █▀█ ██▄   █▄█ █▀█ █░▀░█ ██▄ ▄");
            Console.ResetColor();
            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------" +
                              "\n|You have to play three rounds in one game, and during each round you choose your weapon: Rock, Scissors or Paper.|" +
                              "\n|After you, the AI chooses its weapon, and then the program chooses the winner based on the following criteria:   |" +
                              "\n| - Paper wins over stones, but loses to scissors                                                                 |" +
                              "\n| - Scissors win over paper, but lose to stones                                                                   |" +
                              "\n| - Rocks beat scissors but lose to paper                                                                         |" +
                              "\n-------------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n\n██╗░░░░░███████╗████████╗██╗░██████╗  ░██████╗████████╗░█████╗░██████╗░████████╗██╗██╗██╗" +
                              $"\r\n██║░░░░░██╔════╝╚══██╔══╝╚█║██╔════╝  ██╔════╝╚══██╔══╝██╔══██╗██╔══██╗╚══██╔══╝██║██║██║" +
                              $"\r\n██║░░░░░█████╗░░░░░██║░░░░╚╝╚█████╗░  ╚█████╗░░░░██║░░░███████║██████╔╝░░░██║░░░██║██║██║" +
                              $"\r\n██║░░░░░██╔══╝░░░░░██║░░░░░░░╚═══██╗  ░╚═══██╗░░░██║░░░██╔══██║██╔══██╗░░░██║░░░╚═╝╚═╝╚═╝" +
                              $"\r\n███████╗███████╗░░░██║░░░░░░██████╔╝  ██████╔╝░░░██║░░░██║░░██║██║░░██║░░░██║░░░██╗██╗██╗" +
                              $"\r\n╚══════╝╚══════╝░░░╚═╝░░░░░░╚═════╝░  ╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝╚═╝╚═╝");
            Console.ResetColor();
        }

    }
}
