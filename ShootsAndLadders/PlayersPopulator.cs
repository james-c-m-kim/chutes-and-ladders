using System.Linq;

namespace ShootsAndLadders
{
    public class PlayersPopulator
    {
        public Player[] Populate(int numberOfPlayers)
        {
            return Enumerable.Range(1, numberOfPlayers)
                .Select(playerNum => new Player(playerNum))
                .ToArray();
        }
    }
}