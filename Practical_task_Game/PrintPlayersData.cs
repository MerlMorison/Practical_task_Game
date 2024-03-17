namespace Practical_task_Game
{
    internal class PrintPlayersData
    {

        public void PlayersData(string name, int age, int games, int wins)
        {
            Console.WriteLine($"Name: {name} \nAge: {age} \nPlayed rounds: {games} \nWins: {wins}");
        }
    }
}
