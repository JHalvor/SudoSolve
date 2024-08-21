using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudoSolve.console
{
    public class Box
    {
        private Cell[,] _cells;
        
        public Box(int sideLength)
        {
            _cells = new Cell[sideLength, sideLength];

            for (int y = 0; y < sideLength; y++)
            {
                for (int x = 0; x < sideLength; x++)
                {
                    _cells[x, y] = new Cell();
                }
            }
        }

        public Cell[,] Cells { get { return _cells; } }
    }
}