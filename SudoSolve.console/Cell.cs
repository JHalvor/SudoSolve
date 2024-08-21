using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudoSolve.console
{
    public class Cell
    {
        private int _number;
        private List<int> _possibleNumbers;
        private bool _isSet;
        public int Number { get { return _number; } }
        public bool IsSet { get { return _isSet; } }
        public Cell()
        {
            _isSet = false;
        }
        public Cell(int number)
        {
            _number = number;
            _isSet = true;
        }

        public void Set(int number)
        {
            _isSet = true;
            _number = number;
            _possibleNumbers.Clear();
        }

        public void Clear()
        {
            _isSet = false;
            _number = 0;
            _possibleNumbers.Clear();
        }
    }
}
