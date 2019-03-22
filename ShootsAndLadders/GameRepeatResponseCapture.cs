using System;

namespace ShootsAndLadders
{
    public class GameRepeatResponseCapture
    {
        public bool PlayAgain()
        {
            var playAgain = Console.ReadLine();

            // we only care if the player explicitly types Y or y
            // which means play again
            if (!string.IsNullOrEmpty(playAgain) &&
                playAgain?.ToLower() == "y")
            {
                return true;
            }

            // anythin else means No, do not play again.
            return false;
        }
    }
}