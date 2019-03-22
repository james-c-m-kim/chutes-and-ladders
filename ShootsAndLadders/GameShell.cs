using System;

namespace ShootsAndLadders
{
    public class GameShell
    {
        public void Start()
        {
            var game = new Game();
            var playersAssigner = new PlayerCountAssigner();
            var playAgainCapture = new GameRepeatResponseCapture();
            var play = true;

            //while (true) --> let's bind the eval to an explicit variable
            while (play)
            {
                Console.WriteLine("Welcome to shoots and ladders! How many players?");
                var numberOfPlayers = playersAssigner.GetPlayerCount();

                //int.Parse(numberOfPlayers)  --> we didn't have graceful exception handling
                game.Play(numberOfPlayers);
                Console.WriteLine();

                Console.WriteLine("Would you like to play again? (Y to play again, anything else exits the game)");
                play = playAgainCapture.PlayAgain();

                if (!play)
                {
                    Console.WriteLine("OK, good-bye and see you soon!");
                }
                #region
                // doesn't cover uppercases, and accepts words like north, new zealand, etc as "no"
                //var playAgain = Console.ReadLine();
                //if (playAgain.ToLower().StartsWith("n"))
                //{
                //    return;
                //}

                #endregion
            }
        }
    }
}