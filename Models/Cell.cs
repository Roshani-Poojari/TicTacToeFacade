using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeDP.Exceptions;

namespace TicTacToeDP.Models
{
    internal class Cell
    {
        private MarkType _mark;
        public Cell()
        {
            _mark = MarkType.EMPTY;
        }
        public bool IsEmpty()
        {
            return _mark == MarkType.EMPTY;
        }
        public MarkType GetMark()
        {
            return _mark;
        }
        public void SetMark(MarkType mark)
        {
            if (IsEmpty())
            {
                _mark = mark;
            }
            else
                throw new CellAlreadyMarkedException("Cell Already Marked!!");
        }
    }
}
