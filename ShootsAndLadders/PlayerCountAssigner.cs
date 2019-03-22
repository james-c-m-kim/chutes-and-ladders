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

                // just for sanity's sakes, i'm going to enforce a numeric range.
                if (numberOfPlayers < 0 || numberOfPlayers > 10)
                {
                    validInput = false;
                }

                if (!validInput)
                {
                    Console.WriteLine("Please enter a number between 1 and 10.");
                }
            } while (!validInput);

            return numberOfPlayers;
        }
    }
}