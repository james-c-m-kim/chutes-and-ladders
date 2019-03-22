using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShootsAndLadders
{
    public class Board
    {
        public List<Square> Squares { get; private set; }
        public Player[] Players { get; private set; }
        
        public Board(int numberOfPlayers) {
            Players = new PlayersPopulator().Populate(numberOfPlayers);
            Squares = new List<Square>(new SquaresPopulator().Populate());

            #region
            //FIXED: Start at 1, Starting at Player 0 was bad.
            //for (int i = 1; i <= numberOfPlayers; i++)
            //{
            //    var nextPlayer = new Player();
            //    nextPlayer.SetNumber(i);
            //    Players.Add(nextPlayer);
            //}
            #endregion

            #region
            //for (var j = 0; j <= 100; j++)
            //{
            //    var newSquare = new Square();
            //    Squares.Add(newSquare);

            //    #region
            //    //if (j == 10)
            //    //{
            //    //    newSquare.LadderTo = 18;
            //    //}
            //    //else if (j == 20)
            //    //{
            //    //    newSquare.ShootTo = 14;
            //    //}
            //    //else if (j == 24)
            //    //{
            //    //    newSquare.LadderTo = 35;
            //    //}
            //    //else if (j == 30)
            //    //{
            //    //    newSquare.LadderTo = 40;
            //    //}
            //    //else if (j == 32)
            //    //{
            //    //    newSquare.ShootTo = 15;
            //    //}
            //    //else if (j == 41)
            //    //{
            //    //    newSquare.LadderTo = 57;
            //    //}
            //    //else if (j == 45)
            //    //{
            //    //    newSquare.LadderTo = 55;
            //    //}
            //    //else if (j == 48)
            //    //{
            //    //    newSquare.LadderTo = 60;
            //    //}
            //    //else if (j == 50)
            //    //{
            //    //    newSquare.ShootTo = 25;
            //    //}
            //    //else if (j == 51)
            //    //{
            //    //    newSquare.ShootTo = 64;
            //    //}
            //    //else if (j == 61)
            //    //{
            //    //    newSquare.ShootTo = 43;
            //    //}
            //    //else if (j == 63)
            //    //{
            //    //    newSquare.LadderTo = 70;
            //    //}
            //    //else if (j == 78)
            //    //{
            //    //    newSquare.ShootTo = 65;
            //    //}
            //    //else if (j == 80)
            //    //{
            //    //    newSquare.LadderTo = 100;
            //    //}
            //    #endregion

            //    // problem, we already evaluated j == 48 up above. this is why using a dictionary 
            //    // is more efficient...
            //    //else if (j == 48)
            //    //{
            //    //    newSquare.LadderTo = 53;
            //    //}

            //}
            #endregion

            Squares[0].Players.AddRange(Players);
        }

        public Player GetLoser()
        {
            return Players.Except(Squares.Last().Players).First();
        }
    }
}
