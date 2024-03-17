namespace Practical_task_Game
{
    internal class DetermineWinner
    {
        public static string playersWeaponID;
        public static string AIWeapon;
        public static int attempts;
        public static void Winner(int playersWeaponID, int AIWeapon)
        {
            if (playersWeaponID == AIWeapon)
            {
                attempts--;
                Console.WriteLine(AIWeapon);
                Console.WriteLine("==");
            }
            else if ((playersWeaponID == 1 && AIWeapon == 2) || (playersWeaponID == 2 && AIWeapon == 3) || (playersWeaponID == 3 && AIWeapon == 1))
            {
                attempts--;
                Console.WriteLine(AIWeapon);
                Console.WriteLine("YOU WIN!");
            }
            else
            {
                attempts--;
                Console.WriteLine(AIWeapon);
                Console.WriteLine("Y0U LOSE!");
            }
        }
    }
}

