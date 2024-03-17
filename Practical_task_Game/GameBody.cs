namespace Practical_task_Game
{
    internal class GameBody
    {
        public static string name;
        public static int age;
        public static int games;

        public static int Game()
        {
            string[] weapons = { "none", "stone", "scissors", "paper" };
            Random randomN = new Random();
            int winsR = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nLET'S START!!!");
            Console.ResetColor();
            for (int i = 1; i <= 3; i++)
            {

                int AIWeaponID = randomN.Next(1, 4);
                string AIWeapon = weapons[AIWeaponID];

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nChose your weapon by number where stone - 1, scissors - 2, paper - 3");
                Console.ResetColor();
                string playersWeapon = Console.ReadLine().ToLower();

                if (!int.TryParse(playersWeapon, out int playersWeaponID))
                {
                    Console.WriteLine("Wrong input. Please enter a number between 1 and 3.");

                }
                else if (playersWeaponID < 1 || playersWeaponID > 3)
                {
                    Console.WriteLine("Wrong input. Please enter a number between 1 and 3.");
                }
                else
                {
                    string playersWeaponID = weapons[playersWeaponID];

                }

                if (playersWeaponID == AIWeaponID)
                {

                    Console.WriteLine($"Your weapon - {playersWeaponID}; AI`s weapon - {AIWeapon}");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Your result is a draw!");
                    Console.ResetColor();
                    Console.WriteLine("Played rounds:" + i);
                }
                else if ((playersWeaponID == 1 && AIWeaponID == 2) || (playersWeaponID == 2 && AIWeaponID == 3) || (playersWeaponID == 3 && AIWeaponID == 1))
                {
                    winsR++;
                    Console.WriteLine($"Your weapon - {playersWeaponID}; AI`s weapon - {AIWeapon}");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("You won the round!");
                    Console.ResetColor();
                    Console.WriteLine("Played rounds:" + i);

                }
                else
                {

                    Console.WriteLine($"Your weapon - {playersWeaponID}; AI`s weapon - {AIWeapon}");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("You lost the round!");
                    Console.ResetColor();
                    Console.WriteLine("Played rounds:" + i);
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nYour result...");
            Console.ResetColor();

            if (winsR > 1)
            {
                string[] praiseOptions = { "\nCongratulations, you won the battle!", "\nWOW! You won!", "\nYou won! You're just amazing!" };
                int messege = randomN.Next(0, praiseOptions.Length);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU WON!!!" + praiseOptions[messege]);
                Console.ResetColor();
                Console.WriteLine("__________________________________________________________________________________");
                return 1;
            }
            else
            {
                string[] encouragementOptions = { "\nDon't lose faith in your abilities. There will be a chance to win again!", "\nDon't give up, you'll do better next time!", "\nTry again, and you will win!" };
                int messege = randomN.Next(0, encouragementOptions.Length);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("YOU LOSE!!!" + encouragementOptions[messege]);
                Console.ResetColor();
                Console.WriteLine("__________________________________________________________________________________");
                return 0;
            }

        }
    }
}

