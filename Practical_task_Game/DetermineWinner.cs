namespace Practical_task_Game
{
    internal class DetermineWinner
    {
        public static string name;
        public static int age;
        public static int games;

        public static int Game()
        {
            string[] weapons = { "stone", "scissors", "paper" };
            Random randomN = new Random();
            int winsR = 0;
            int w = 0;

            for (int i = 1; i <= 3; i++)
            {

                int AIWeaponID = randomN.Next(0, weapons.Length);
                string AIWeapon = weapons[AIWeaponID];

                Console.WriteLine($"\nChose your weapon by number where stone - 0,scissors - 1, paper - 2");
                int playersWeaponID = int.Parse(Console.ReadLine());
                int playersWeapon = playersWeaponID;
                if (playersWeapon < 0 || playersWeapon > 2)
                {
                    Console.WriteLine("Wrong number");
                    Console.WriteLine($"Chose your weapon by number where stone - 0,scissors - 1, paper - 2");
                    playersWeaponID = int.Parse(Console.ReadLine());
                    playersWeapon = playersWeaponID;
                }

                if (playersWeapon == AIWeaponID)
                {

                    Console.WriteLine(AIWeapon);
                    Console.WriteLine("==");
                    Console.WriteLine("Played rounds:" + i);
                }
                else if ((playersWeapon == 1 && AIWeaponID == 2) || (playersWeapon == 2 && AIWeaponID == 3) || (playersWeapon == 3 && AIWeaponID == 1))
                {
                    winsR++;
                    Console.WriteLine(AIWeapon);
                    Console.WriteLine("YOU WIN!");
                    Console.WriteLine("Played rounds:" + i);

                }
                else
                {

                    Console.WriteLine(AIWeapon);
                    Console.WriteLine("Y0U LOSE!");
                    Console.WriteLine("Played rounds:" + i);
                }
            }
            if (winsR > 1)
            {

                Console.WriteLine("\nYOU WIN the game!");
                return 1;
            }
            else
            {
                Console.WriteLine("\nYOU lose the game!");
                return 0;
            }

        }
    }
}

