using System;
using System.Linq;

namespace ShootsAndLadders
{
    public class Game
    {
        public void Play(int numberOfPlayers)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Starting a new game with {numberOfPlayers} players.");
            Console.WriteLine();

            // we're going to track who finished in which place (1st, 2nd, etc)
            var board = new Board(numberOfPlayers);
            var lastSquare = board.Squares.Last();

            while (lastSquare.Players.Count < (numberOfPlayers - 1))
            {
                foreach (var player in board.Players)
                {
                    // replaced all the GetNumber() calls with property accessor notations
                    var currentSquare = board.Squares.Single(x => x.Players.Any(y => y.Number == player.Number));
                    var currentSquareIndex = board.Squares.IndexOf(currentSquare);
                    
                    var spacesToMove = player.Move();
                    var newSquareIndex = currentSquareIndex + spacesToMove;
                    if (newSquareIndex >= SquaresPopulator.TotalSquares)
                    {
                        newSquareIndex = currentSquareIndex;
                    }
                    var newSquare = board.Squares[newSquareIndex];
                    currentSquare.Players.Remove(player);

                    Console.WriteLine($"Player {player.Number} [{currentSquareIndex + 1}]: spun a {spacesToMove}. Moved to square {newSquareIndex}");

                    if (newSquare.ChuteOrLadderTo != null)
                    {
                        var hyperJump = newSquare.ChuteOrLadderTo.SquareNumber;
                        var ladderOrChute = hyperJump > newSquareIndex ? "ladder" : "chute";
                        newSquare = newSquare.ChuteOrLadderTo;

                        Console.WriteLine($"Took a {ladderOrChute} to {hyperJump}!");
                    }

                    #region
                    // everything is a "ladder" in this old code...
                    // and we have repeating logic...
                    //if (board.Squares[newSquare].LadderTo.HasValue)
                    //{
                    //    newSquare = board.Squares[newSquare].LadderTo.GetValueOrDefault();
                    //    Console.WriteLine($"You took a ladder to {newSquare}!");
                    //}
                    //if (board.Squares[newSquare].ShootTo.HasValue)
                    //{
                    //    newSquare = board.Squares[newSquare].ShootTo.GetValueOrDefault();
                    //    Console.WriteLine($"You took a ladder to {newSquare}!");
                    //}
                    //board.Squares[newSquare].Players.Add(player);
                    #endregion


                    newSquare.Players.Add(player);
                    Console.WriteLine();
                }
            }

            // let's make this more exciting and rank the players as they finish.
            var winner = lastSquare.Players.First();
            Console.WriteLine($"Player {winner.Number} is the winner: CONGRATS!");

            for (var i = 1; i < lastSquare.Players.Count; i++)
            {
                Console.WriteLine($"Player {lastSquare.Players[i].Number} ranked #{i + 1} in this game.");
            }

            // can safely assume we only have one 
            var lastPlayer = board.GetLoser();
            Console.WriteLine($"Sad to say, player {lastPlayer.Number} was the loser in this game... Better luck next time!");

            #region old code

            //var winner = board.Squares.Last().Players.First().Number;
            //Console.WriteLine($"Play {winner} wins the game!");

            #endregion
        }
    }
}