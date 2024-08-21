using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudoSolve.console
{
    public class Board
    {
        private Box[,] _boxes;
        public Board(int sideLength)
        {
            _boxes = new Box[sideLength, sideLength];

            for (int y = 0; y < sideLength; y++)
            {
                for (int x = 0; x < sideLength; x++)
                {
                    _boxes[x, y] = new Box(sideLength);
                }
            }
        }

        public Box[,] Boxes { get { return _boxes; } }
    }
}