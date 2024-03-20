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
                Console.WriteLine($"\nChose your weapon by number where stone - 1,scissors - 2, paper - 3");
                Console.ResetColor();
                int playersWeaponID = int.Parse(Console.ReadLine());


                if (playersWeaponID < 1 || playersWeaponID > 3)
                {
                    Console.WriteLine("Wrong number");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nChose your weapon by number where stone - 1,scissors - 2, paper - 3");
                    Console.ResetColor();
                    playersWeaponID = int.Parse(Console.ReadLine());

                }

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