namespace Practical_task_Game
{
    internal class DetermineWinner
    {
        public static string playersWeaponID;
        public static string AIWeapon;
        public static void Game()
        {
            string[] weapons = { "stone", "scissors", "paper" };
            Random randomN = new Random();
            int games = 0;
            int wins = 0;
            for (int i = 0; i <= 3; i++)
            {
                games++;
                int AIWeaponID = randomN.Next(0, weapons.Length);
                string AIWeapon = weapons[AIWeaponID];

                Console.WriteLine($"Chose your weapon by number where stone - 1,scissors - 2, paper - 3");
                int playersWeaponID = int.Parse(Console.ReadLine());
                int playersWeapon = playersWeaponID - 1;
                if (playersWeapon <= 0 || playersWeapon >= 2)
                {
                    Console.WriteLine("Wrong number");
                    Console.WriteLine($"Chose your weapon by number where stone - 1,scissors - 2, paper - 3");
                    playersWeaponID = int.Parse(Console.ReadLine());
                    playersWeapon = playersWeaponID - 1;
                }

                if (playersWeapon == AIWeaponID)
                {

                    Console.WriteLine(AIWeapon);
                    Console.WriteLine("==");
                    Console.WriteLine(i);
                }
                else if ((playersWeapon == 1 && AIWeaponID == 2) || (playersWeapon == 2 && AIWeaponID == 3) || (playersWeapon == 3 && AIWeaponID == 1))
                {
                    wins++;
                    Console.WriteLine(AIWeapon);
                    Console.WriteLine("YOU WIN!");
                    Console.WriteLine(i);

                }
                else
                {

                    Console.WriteLine(AIWeapon);
                    Console.WriteLine("Y0U LOSE!");
                    Console.WriteLine(i);
                }
            }
            if (wins == 2 || wins == 3)
            {
                Console.WriteLine("YOU WIN the game!");
            }
            Console.WriteLine("YOU lose the game!");
        }
    }
}

