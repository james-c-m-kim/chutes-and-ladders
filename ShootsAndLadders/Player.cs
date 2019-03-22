using System;
using System.Collections.Generic;
using System.Text;

namespace ShootsAndLadders
{
    public class Player
    {
        #region
        // let's convert this to a property, and keep things consistent.
        //private int Number;
        #endregion

        private Random Random;

        public int Number { get; private set; }

        public Player(int playerNum)
        {
            Number = playerNum;
            Random = new Random(Number);
        }

        #region
        //public int GetNumber()
        //{
        //    return Number;
        //}
        #endregion

        #region
        // remove this, we really don't need it.
        // a Player cannot be without a number, so make that part of the ctor contract.
        //public void SetNumber(int value)
        //{
        //    Number = value;
        //}
        #endregion

        public int Move()
        {
            #region
            // we have a tighter ctor contract, so this check becomes superfluous
            //if (Random == null) {
            //    Random = new Random(Number);
            //}
            #endregion

            var spaces = Random.Next(1, 6);

            #region
            // can't roll a 0 on a 6 sided die...
            //var spaces = Random.Next(0, 6);

            //Console.WriteLine($"Spun a {spaces}.");  --> removing from here and merging output @ higher level.
            #endregion

            return spaces;
        }
    }
}
