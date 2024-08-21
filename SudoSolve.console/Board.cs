using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudoSolve.console
{
    public class Board
    {
        public Box[,] Boxes;
        public Board(int sideLength)
        {
            Boxes = new Box[sideLength, sideLength];
            for (int y = 0; y < sideLength; y++)
            {
                for (int x = 0; x < sideLength; x++)
                {
                    Boxes[x, y] = new Box(sideLength);
                }
            }
        }
    }
}
