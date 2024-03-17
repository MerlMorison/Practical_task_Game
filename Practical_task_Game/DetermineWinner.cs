namespace Practical_task_Game
{
    internal class DetermineWinner
    {
        public static string name;
        public static int age;
        public static int games;

        public static int Game()
        {
            string[] weapons = { "none", "stone", "scissors", "paper" };
            Random randomN = new Random();
            int winsR = 0;

            for (int i = 1; i <= 3; i++)
            {

                int AIWeaponID = randomN.Next(1, 4);
                string AIWeapon = weapons[AIWeaponID];

                Console.WriteLine($"\nChose your weapon by number where stone - 1,scissors - 2, paper - 3");
                int playersWeaponID = int.Parse(Console.ReadLine());
                string playersWeapon = weapons[playersWeaponID];

                if (playersWeaponID < 1 || playersWeaponID > 3)
                {
                    Console.WriteLine("Wrong number");
                    Console.WriteLine($"Chose your weapon by number where stone - 1,scissors - 2, paper - 3");
                    playersWeaponID = int.Parse(Console.ReadLine());
                    playersWeapon = weapons[playersWeaponID];
                }

                if (playersWeaponID == AIWeaponID)
                {

                    Console.WriteLine($"Your weapon - {playersWeapon}; AI`s weapon - {AIWeapon}");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Your result is a draw!");
                    Console.ResetColor();
                    Console.WriteLine("Played rounds:" + i);
                }
                else if ((playersWeaponID == 1 && AIWeaponID == 2) || (playersWeaponID == 2 && AIWeaponID == 3) || (playersWeaponID == 3 && AIWeaponID == 1))
                {
                    winsR++;
                    Console.WriteLine($"Your weapon - {playersWeapon}; AI`s weapon - {AIWeapon}");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("You won the round!");
                    Console.ResetColor();
                    Console.WriteLine("Played rounds:" + i);

                }
                else
                {

                    Console.WriteLine($"Your weapon - {playersWeapon}; AI`s weapon - {AIWeapon}");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("You lost the round!");
                    Console.ResetColor();
                    Console.WriteLine("Played rounds:" + i);
                }
            }
            if (winsR > 1)
            {
                string[] praiseOptions = { "\nCongratulations, you won the battle!", "\nWOW! You won!", "\nYou won! You're just amazing!" };
                int messege = randomN.Next(0, praiseOptions.Length);
                Console.WriteLine("\nYour result...");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU WON!!!" + praiseOptions[messege]);
                Console.ResetColor();
                return 1;
            }
            else
            {
                string[] encouragementOptions = { "\nDon't lose faith in your abilities. There will be a chance to win again!", "\nDon't give up, you'll do better next time!", "\nTry again, and you will win!" };
                int messege = randomN.Next(0, encouragementOptions.Length);
                Console.WriteLine("\nYour result...");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("YOU LOSE!!!" + encouragementOptions[messege]);
                Console.ResetColor();
                return 0;
            }

        }
    }
}

