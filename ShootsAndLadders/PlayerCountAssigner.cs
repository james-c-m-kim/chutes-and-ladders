using System;

namespace ShootsAndLadders
{
    public class PlayerCountAssigner
    {
        public int GetPlayerCount()
        {
            var validInput = false;
            int numberOfPlayers;
            do
            {
                var numberOfPlayersInput = Console.ReadLine();
                validInput = int.TryParse(numberOfPlayersInput, out numberOfPlayers);
            } while (!validInput);

            return numberOfPlayers;
        }
    }
}