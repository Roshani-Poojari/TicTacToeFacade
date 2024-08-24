using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace TicTacToeDP.Models
{
    internal class ResultAnalyzer
    {
        private Board _board;
        private ResultType _result;
        public ResultAnalyzer(Board board)
        {
            _board = board;
            _result = ResultType.PROGRESS;
        }
        private bool HorizontalWinCheck()
        {
            Cell[] cells = _board.GetCell();
            for (int i = 0; i <= 6; i += 3)
            {
                if (cells[i].GetMark() != MarkType.EMPTY &&
                    cells[i].GetMark() == cells[i + 1].GetMark() &&
                    cells[i + 1].GetMark() == cells[i + 2].GetMark())
                {
                    return true;
                }
            }
            return false;
        }
        private bool VerticalWinCheck()
        {
            Cell[] cells = _board.GetCell();
            for (int i = 0; i < 3; i++)
            {
                if (cells[i].GetMark() != MarkType.EMPTY &&
                    cells[i].GetMark() == cells[i + 3].GetMark() &&
                    cells[i + 3].GetMark() == cells[i + 6].GetMark())
                {
                    return true;
                }
            }
            return false;
        }
        private bool DiagonalWinCheck()
        {
            Cell[] cells = _board.GetCell();
            if ((cells[0].GetMark() != MarkType.EMPTY && cells[0].GetMark() == cells[4].GetMark() && cells[4].GetMark() == cells[8].GetMark()) ||
                (cells[2].GetMark() != MarkType.EMPTY && cells[2].GetMark() == cells[4].GetMark() && cells[4].GetMark() == cells[6].GetMark()))
            {
                return true;
            }
            return false;
        }
        public ResultType AnalyzeResult()
        {
            if (HorizontalWinCheck() || VerticalWinCheck() || DiagonalWinCheck())
                _result = ResultType.WIN;
            else if (_board.IsBoardFull())
                _result = ResultType.DRAW;
            else
                _result = ResultType.PROGRESS;
            return _result;
        }
    }
}
