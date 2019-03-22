using System.Collections.Generic;
using System.Linq;

namespace ShootsAndLadders
{
    public class SquaresPopulator
    {
        public static readonly int TotalSquares = 100; // total number of squares on the board
        private readonly Dictionary<int, int> mapSquareToChutesOrLadders = new Dictionary<int, int>
        {
            {10, 18},
            {24, 35},
            {30, 40},
            {41, 57},
            {45, 55},
            {48, 60},
            {51, 64},
            {63, 70},
            {80, 100},
            {20, 14},
            {32, 15},
            {50, 25},
            {61, 43},
            {78, 65}
        };

        public Square[] Populate()
        {
            var mapOfSquares = Enumerable.Range(1, TotalSquares).Select(squareNum => new Square(squareNum))
                .ToDictionary(k => k.SquareNumber, v => v);

            foreach (var square in mapOfSquares)
            {
                if (mapSquareToChutesOrLadders.ContainsKey(square.Value.SquareNumber))
                {
                    var chuteLadderIdx = mapSquareToChutesOrLadders[square.Value.SquareNumber];
                    square.Value.ChuteOrLadderTo = mapOfSquares[chuteLadderIdx];
                }
            }

            return mapOfSquares.Values.ToArray();
        }
    }
}