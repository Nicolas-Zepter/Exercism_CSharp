using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism_CSharp
{
    #region Task Description
    /*
    Calculate the number of grains of wheat on a chessboard.
    A chessboard has 64 squares. Square 1 has one grain, square 2 has two grains, square 3 has four grains, and so on, doubling each time.
    Write code that calculates:
     - the number of grains on a given square
     - the total number of grains on the chessboard
    */
    #endregion

    public static class Grains
    {
        /// <summary>
        /// Calculates the grains of rice on a given square.
        /// </summary>
        /// <param name="n">The number of the square, i.e., its index in the sequence.</param>
        /// <returns>A <see cref="System.UInt64"/> indicating the grains of rice on square n.</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static ulong Square(int n)
        {
            if (n <= 0 || n > 64) throw new ArgumentOutOfRangeException();
            return (ulong)Math.Pow(2, (n - 1));
        }

        /// <summary>
        /// Calculates the total grains of rice on the entire chessboard.
        /// </summary>
        /// <returns>A <see cref="System.UInt64"/> indicating the grains of rice on the chessboard.</returns>
        public static ulong Total() => (ulong)Math.Pow(2, 64);
    }
}
