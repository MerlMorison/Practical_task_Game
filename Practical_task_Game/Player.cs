namespace Practical_task_Game
{
    internal class Player
    {
        public static string name;
        public static int age;
        public static int win;
        public static int games;

        public static void PlayersData(string name, int age, int games, int win)
        {

            Console.Write($"\n█▄░█ ▄▀█ █▀▄▀█ █▀▀ ▀" +
                          $"\n█░▀█ █▀█ █░▀░█ ██▄ ▄ {name} " +
                          $"\n\n▄▀█ █▀▀ █▀▀ ▀" +
                            $"\n█▀█ █▄█ ██▄ ▄ {age} " +
                          $"\n\n█▀█ █░░ ▄▀█ █▄█ █▀▀ █▀▄   █▀▀ ▄▀█ █▀▄▀█ █▀▀ █▀ ▀" +
                            $"\n█▀▀ █▄▄ █▀█ ░█░ ██▄ █▄▀   █▄█ █▀█ █░▀░█ ██▄ ▄█ ▄ {games} " +
                          $"\n\n█░█░█ █ █▄░█ █▀ ▀" +
                            $"\n▀▄▀▄▀ █ █░▀█ ▄█ ▄ {win}");
            Console.WriteLine("\n\n===================================================================================================================");

        }
        public static void PlayersData(int games, int win)
        {

            Console.WriteLine($"\n\n█▀█ █░░ ▄▀█ █▄█ █▀▀ █▀▄   █▀▀ ▄▀█ █▀▄▀█ █▀▀ █▀ ▀" +
                                $"\n█▀▀ █▄▄ █▀█ ░█░ ██▄ █▄▀   █▄█ █▀█ █░▀░█ ██▄ ▄█ ▄ {games} " +
                              $"\n\n█░█░█ █ █▄░█ █▀ ▀" +
                                $"\n▀▄▀▄▀ █ █░▀█ ▄█ ▄ {win}");
            Console.WriteLine("\n\n===================================================================================================================");
        }
    }
}
