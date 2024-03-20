namespace Practical_task_Game
{
    internal class Pictures
    {
        public static int playersWeaponID;
        public static int AIWeaponID;
        public static void YouWin()
        {
            Random randomN = new Random();
            string[] praiseOptions = { "\nCongratulations, you won the battle!", "\nWOW! You won!", "\nYou won! You're just amazing!" };
            int messege = randomN.Next(0, praiseOptions.Length);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░" +
                              "\n░░░░░░░░░░░████░░░░░░░░░░░░░░░░░░░░" +
                            "\r\n░░░░░░░░░███░██░░░░░░░░░░░░░░░░░░░░" +
                            "\r\n░░░░░░░░░██░░░█░░░░░░░░░░░░░░░░░░░░" +
                            "\r\n░░░░░░░░░██░░░██░░░░░░░░░░░░░░░░░░░" +
                            "\r\n░░░░░░░░░░██░░░███░░░░░░░░░░░░░░░░░" +
                            "\r\n░░░░░░░░░░░██░░░░██░░░░░░░░░░░░░░░░" +
                            "\r\n░░░░░░░░░░░██░░░░░███░░░░░░░░░░░░░░" +
                            "\r\n░░░░░░░░░░░░██░░░░░░██░░░░░░░░░░░░░" +
                            "\r\n░░░░░░░███████░░░░░░░██░░░░░░░░░░░░" +
                            "\r\n░░░░█████░░░░░░░░░░░░░░███░██░░░░░░" +
                            "\r\n░░░██░░░░░████░░░░░░░░░░██████░░░░░" +
                            "\r\n░░░██░░████░░███░░░░░░░░░░░░░██░░░░" +
                            "\r\n░░░██░░░░░░░░███░░░░░░░░░░░░░██░░░░" +
                            "\r\n░░░░██████████░███░░░░░░░░░░░██░░░░" +
                            "\r\n░░░░██░░░░░░░░████░░░░░░░░░░░██░░░░" +
                            "\r\n░░░░███████████░░██░░░░░░░░░░██░░░░" +
                            "\r\n░░░░░░██░░░░░░░████░░░░░██████░░░░░" +
                            "\r\n░░░░░░██████████░██░░░░███░██░░░░░░" +
                            "\r\n░░░░░░░░░██░░░░░████░███░░░░░░░░░░░" +
                            "\r\n░░░░░░░░░█████████████░░░░░░░░░░░░░" +
                            "\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░" +
                            "\r\n" + praiseOptions[messege]);
            Console.ResetColor();

            Console.WriteLine("\r\n█▀█ █▀█ █▀▀ █▀   █▀▀ █▄░█ ▀█▀ █▀▀ █▀█   ▀█▀ █▀█   █▀▀ █▀█ █▄░█ ▀█▀ █ █▄░█ █░█ █▀▀" +
                              "\r\n█▀▀ █▀▄ ██▄ ▄█   ██▄ █░▀█ ░█░ ██▄ █▀▄   ░█░ █▄█   █▄▄ █▄█ █░▀█ ░█░ █ █░▀█ █▄█ ██▄" +
                              "\r\n");
            Console.ReadLine();
        }
        public static void YouLose()
        {
            Random randomN = new Random();
            string[] encouragementOptions = { "\nYou lost! Don't lose faith in your abilities. There will be a chance to win again!", "\nYou lost! Don't give up, you'll do better next time!", "\nYou lost! Try again, and you will win!" };
            int messege = randomN.Next(0, encouragementOptions.Length);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n███████████████████████████" +
                            "\r\n███████████████████████████" +
                            "\r\n███████▀▀▀░░░░░░░▀▀▀███████" +
                            "\r\n████▀░░░░░░░░░░░░░░░░░▀████" +
                            "\r\n███│░░░░░░░░░░░░░░░░░░░│███" +
                            "\r\n██▌│░░░░░░░░░░░░░░░░░░░│▐██" +
                            "\r\n██░└┐░░░░░░░░░░░░░░░░░┌┘░██" +
                            "\r\n██░░└┐░░░░░░░░░░░░░░░┌┘░░██" +
                            "\r\n██░░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░██" +
                            "\r\n██▌░│██████▌░░░▐██████│░▐██" +
                            "\r\n███░│▐███▀▀░░▄░░▀▀███▌│░███" +
                            "\r\n██▀─┘░░░░░░░▐█▌░░░░░░░└─▀██" +
                            "\r\n██▄░░░▄▄▄▓░░▀█▀░░▓▄▄▄░░░▄██" +
                            "\r\n████▄─┘██▌░░░░░░░▐██└─▄████" +
                            "\r\n█████░░▐█─┬┬┬┬┬┬┬─█▌░░█████" +
                            "\r\n████▌░░░▀┬┼┼┼┼┼┼┼┬▀░░░▐████" +
                            "\r\n█████▄░░░└┴┴┴┴┴┴┴┘░░░▄█████" +
                            "\r\n███████▄░░░░░░░░░░░▄███████" +
                            "\r\n██████████▄▄▄▄▄▄▄██████████" +
                            "\r\n███████████████████████████" +
                            "\r\n" + encouragementOptions[messege]);
            Console.ResetColor();
            Console.WriteLine("\r\n█▀█ █▀█ █▀▀ █▀   █▀▀ █▄░█ ▀█▀ █▀▀ █▀█   ▀█▀ █▀█   █▀▀ █▀█ █▄░█ ▀█▀ █ █▄░█ █░█ █▀▀" +
                              "\r\n█▀▀ █▀▄ ██▄ ▄█   ██▄ █░▀█ ░█░ ██▄ █▀▄   ░█░ █▄█   █▄▄ █▄█ █░▀█ ░█░ █ █░▀█ █▄█ ██▄" +
                              "\r\n");
            Console.ReadLine();
        }

        public static void ChoisePlayer(int playersWeaponID)
        {

            switch (playersWeaponID)
            {
                case 1:
                    Console.WriteLine("                  _______");
                    Console.WriteLine("              ---'   ____)");
                    Console.WriteLine("   Your             (_____)");
                    Console.WriteLine("  weapon            (_____)");
                    Console.WriteLine("                    (____)");
                    Console.WriteLine("              ---.__(___)");
                    break;
                case 2:
                    Console.WriteLine("                  _______");
                    Console.WriteLine("              ---'   ____)____");
                    Console.WriteLine("   Your                 ______)");
                    Console.WriteLine("  weapon             __________)");
                    Console.WriteLine("                   (____)");
                    Console.WriteLine("              ---.__(___)");
                    break;
                case 3:
                    Console.WriteLine("                  _______");
                    Console.WriteLine("              ---'   ____)____");
                    Console.WriteLine("   Your                 ______)");
                    Console.WriteLine("  weapon                _______)");
                    Console.WriteLine("                      _______)");
                    Console.WriteLine("              ---.__________)");
                    break;
            }
        }
        public static void ChoiseAI(int AIWeaponID)
        {

            switch (AIWeaponID)
            {
                case 1:
                    Console.WriteLine("                  _______");
                    Console.WriteLine("              ---'   ____)");
                    Console.WriteLine("    AI              (_____)");
                    Console.WriteLine("  weapon            (_____)");
                    Console.WriteLine("                    (____)");
                    Console.WriteLine("              ---.__(___)");
                    break;
                case 2:
                    Console.WriteLine("                  _______");
                    Console.WriteLine("              ---'   ____)____");
                    Console.WriteLine("    AI                  ______)");
                    Console.WriteLine("  weapon             __________)");
                    Console.WriteLine("                   (____)");
                    Console.WriteLine("              ---.__(___)");
                    break;
                case 3:
                    Console.WriteLine("                  _______");
                    Console.WriteLine("              ---'   ____)____");
                    Console.WriteLine("    AI                  ______)");
                    Console.WriteLine("  weapon                _______)");
                    Console.WriteLine("                      _______)");
                    Console.WriteLine("              ---.__________)");
                    break;
            }
        }
    }
}
