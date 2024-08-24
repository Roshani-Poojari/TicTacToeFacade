using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeDP.Models
{
    internal class Game
    {
        private Player[] players;
        private Board _board;
        private int currentPlayerIndex;
        public Game(Player player1, Player player2)
        {
            players = [player1, player2];
            _board = new Board();
            currentPlayerIndex = 0;
        }
        public Player CurrentPlayer
        {
            get { return players[currentPlayerIndex]; }
        }
        public void DisplayBoard()
        {
            _board.DisplayBoard();
        }
        public void PlayTurn(int position)
        {
            _board.SetCellMark(position, CurrentPlayer.MarkType);
        }
        public void SwitchTurn()
        {
            currentPlayerIndex = (currentPlayerIndex + 1) % 2;
        }
        public ResultType CheckGameResult()
        {
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(_board);
            return resultAnalyzer.AnalyzeResult();
        }
    }
}
