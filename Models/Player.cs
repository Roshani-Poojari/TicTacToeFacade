using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeDP.Models
{
    internal class Player
    {
        public string Name { get; set; }
        public MarkType MarkType { get; set; }
        public Player(string name, MarkType mark)
        {
            Name = name;
            MarkType = mark;
        }
    }
}
