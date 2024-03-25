namespace Practical_task_Game
{
    internal class GameBody
    {
        public static string name;
        public static int age;
        public static int games;

        public static int Game()
        {
            Random randomN = new Random();
            int winsR = 0;


            for (int i = 1; i <= 3; i++)
            {

                int AIWeaponID = randomN.Next(1, 4);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nChoose your weapon by number where stone - 1, scissors - 2, paper - 3");
                Console.ResetColor();

                string playersWeaponInput = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(playersWeaponInput) || !int.TryParse(playersWeaponInput, out int playersWeapon) || playersWeapon < 1 || playersWeapon > 3)
                {
                    Console.WriteLine("\nInvalid input. Please choose your weapon by entering a number between 1 and 3:\n");
                    playersWeaponInput = Console.ReadLine();
                }
                
                int playersWeaponID = int.Parse(playersWeaponInput);

                if (playersWeaponID == AIWeaponID)
                {
                    Pictures.ChoisePlayer(playersWeaponID);
                    Pictures.ChoiseAI(AIWeaponID);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nYour result is a draw!");
                    Console.ResetColor();
                    Console.WriteLine("\nPlayed rounds:" + i);
                }
                else if ((playersWeaponID == 1 && AIWeaponID == 2) || (playersWeaponID == 2 && AIWeaponID == 3) || (playersWeaponID == 3 && AIWeaponID == 1))
                {
                    winsR++;
                    Pictures.ChoisePlayer(playersWeaponID);
                    Pictures.ChoiseAI(AIWeaponID);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nYou won the round!");
                    Console.ResetColor();
                    Console.WriteLine("\nPlayed rounds:" + i);

                }
                else
                {

                    Pictures.ChoisePlayer(playersWeaponID);
                    Pictures.ChoiseAI(AIWeaponID);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\nYou lost the round!");
                    Console.ResetColor();
                    Console.WriteLine("\nPlayed rounds:" + i);
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n█▄█ █▀█ █ █ █▀█   █▀█ █▀▀ █▀ █ █ █   ▀█▀      " +
                            "\r\n █  █▄█ █▄█ █▀▄   █▀▄ ██▄ ▄█ █▄█ █▄▄  █  ▄ ▄ ▄");
            Console.ResetColor();

            if (winsR > 1)
            {
                Pictures.YouWin();
                return 1;
            }
            else
            {
                Pictures.YouLose();
                return 0;
            }

        }
    }
}