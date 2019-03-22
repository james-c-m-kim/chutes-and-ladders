using System;
using System.Collections.Generic;
using System.Text;

namespace ShootsAndLadders
{
    public class Square
    {
        public List<Player> Players { get; set; }
        public Square ChuteOrLadderTo { get; set; }
        public int SquareNumber { get; private set; }

        #region
        // really don't need to know if it's a chute or ladder
        // if the linked square is higher index, it's a ladder
        // if lower index then it's a chute...
        //public int? ShootTo { get; set; }
        //public int? LadderTo { get; set; }
        #endregion

        public Square(int squareNum)
        {
            SquareNumber = squareNum;
            Players = new List<Player>();
        }
    }
}
