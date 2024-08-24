using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeDP.Exceptions;

namespace TicTacToeDP.Models
{
    internal class Board
    {
        private Cell[] cells;
        public Board()
        {
            cells = new Cell[9];
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = new Cell();
            }
        }
        public bool IsBoardFull()
        {
            for (int i = 0; i < cells.Length; i++)
            {
                if (cells[i].IsEmpty())
                    return false;
            }
            return true;
        }
        public void SetCellMark(int loc, MarkType mark)
        {
            int index = loc - 1;
            if (index < 0 || index >= cells.Length)
                throw new InvalidPositionException("Entered position is invalid!!");
            cells[index].SetMark(mark);
        }
        public Cell[] GetCell()
        {
            return cells;
        }
        public void DisplayBoard()
        {
            Console.WriteLine();
            for (int i = 0; i < cells.Length; i++)
            {
                string mark = cells[i].GetMark().ToString();
                if (mark == "EMPTY") 
                    mark = " ";
                Console.Write(mark);
                if (i % 3 < 2)
                    Console.Write(" | ");
                else if (i < cells.Length - 1)
                    Console.WriteLine("\n---------");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
