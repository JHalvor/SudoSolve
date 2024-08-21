using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudoSolve.console
{
    public class Box
    {
        public Cell[,] Cells;
        public Box(int sideLength)
        {
            Cells = new Cell[sideLength, sideLength];
            for (int y = 0; y < sideLength; y++)
            {
                for (int x = 0; x < sideLength; x++)
                {
                    Cells[x, y] = new Cell();
                }
            }
        }
    }
}
