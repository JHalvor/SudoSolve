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
        private int _sideLength;
        public Board(int sideLength)
        {
            _sideLength = sideLength;
            _boxes = new Box[_sideLength, _sideLength];

            for (int y = 0; y < _sideLength; y++)
            {
                for (int x = 0; x < _sideLength; x++)
                {
                    _boxes[x, y] = new Box(_sideLength);
                }
            }
        }

        public string PrintBoard()
        {
            StringBuilder boardString = new StringBuilder(string.Empty);
            
            if (_sideLength < 2 && _sideLength > 4)
            {
                return boardString.ToString();
            }

            boardString.Append(GetTopLine());
            for (int i = 0; i < _sideLength - 1; i++)
            {
                boardString.Append(GetFillLine());
                boardString.Append(GetHorizontalSeparationLine());
            }
            boardString.Append(GetFillLine());
            boardString.Append(GetBottomLine());

            return boardString.ToString();
        }

        private string GetTopLine()
        {
            StringBuilder topLine = new StringBuilder(string.Empty);
            topLine.Append('╔');
            for (int i = 0; i < _sideLength; i++)
            {
                for (int j = 0; j < _sideLength - 1; j++)
                {
                    topLine.Append('═');
                    topLine.Append('╤');
                }
                topLine.Append('═');

                if (i + 1 < _sideLength)
                {
                    topLine.Append('╦');
                }
                else
                {
                    topLine.Append('╗');
                }
            }
            topLine.Append('\n');
            return topLine.ToString();
        }

        private string GetFillLine()
        {
            StringBuilder fillLine = new StringBuilder(string.Empty);
            char startChar = '║';
            char endChar = '║';
            char contentChar = ' ';
            char separationChar = '│';
            char hardSeparationChar = '║';

            for (int c = 0; c < _sideLength * 2 - 1; c++)
            {
                if (c % 2 == 0)
                {
                    startChar = '║';
                    contentChar = ' ';
                    separationChar = '│';
                    hardSeparationChar = '║';
                    endChar = '║';
                }
                else
                {
                    startChar = '╟';
                    contentChar = '─';
                    separationChar = '┼';
                    hardSeparationChar = '╫';
                    endChar = '╢';
                }

                fillLine.Append(startChar);
                for (int i = 0; i < _sideLength; i++)
                {
                    for (int j = 0; j < _sideLength - 1; j++)
                    {
                        fillLine.Append(contentChar);
                        fillLine.Append(separationChar);
                    }
                    fillLine.Append(contentChar);

                    if (i + 1 < _sideLength)
                    {
                        fillLine.Append(hardSeparationChar);
                    }
                    else
                    {
                        fillLine.Append(endChar);
                    }
                }
                fillLine.Append('\n');
            }
            return fillLine.ToString();
        }

        private string GetHorizontalSeparationLine()
        {
            StringBuilder horizontalSeparationLine = new StringBuilder(string.Empty);
            horizontalSeparationLine.Append('╠');
            for (int i = 0; i < _sideLength; i++)
            {
                for (int j = 0; j < _sideLength - 1; j++)
                {
                    horizontalSeparationLine.Append('═');
                    horizontalSeparationLine.Append('╪');
                }
                horizontalSeparationLine.Append('═');

                if (i + 1 < _sideLength)
                {
                    horizontalSeparationLine.Append('╬');
                }
                else
                {
                    horizontalSeparationLine.Append('╣');
                }
            }
            horizontalSeparationLine.Append('\n');
            return horizontalSeparationLine.ToString();
        }

        private string GetBottomLine()
        {
            StringBuilder bottomLine = new StringBuilder(string.Empty);
            bottomLine.Append('╚');
            for (int i = 0; i < _sideLength; i++)
            {
                for (int j = 0; j < _sideLength - 1; j++)
                {
                    bottomLine.Append('═');
                    bottomLine.Append('╧');
                }
                bottomLine.Append('═');

                if (i + 1 < _sideLength)
                {
                    bottomLine.Append('╩');
                }
                else
                {
                    bottomLine.Append('╝');
                }
            }
            bottomLine.Append('\n');
            return bottomLine.ToString();
        }

        public Box[,] Boxes { get { return _boxes; } }
        public int SideLength { get { return _sideLength; } }
    }
}