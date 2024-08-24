using TicTacToeDP.Models;

namespace TicTacToeDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Player 1", MarkType.X);
            Player player2 = new Player("Player 2", MarkType.O);
            Game game = new Game(player1, player2);
            while (true)
            {
                try
                {
                    Console.WriteLine($"{game.CurrentPlayer.Name}'s turn\n");
                    game.DisplayBoard();
                    Console.WriteLine("Enter Position (1-9): ");
                    int position = Convert.ToInt32(Console.ReadLine());
                    game.PlayTurn(position);
                    ResultType result = game.CheckGameResult();
                    if (result == ResultType.WIN)
                    {
                        Console.WriteLine($"{game.CurrentPlayer.Name} wins!");
                        game.DisplayBoard();
                        break;
                    }
                    else if (result == ResultType.DRAW)
                    {
                        Console.WriteLine("The game is a draw!");
                        game.DisplayBoard();
                        break;
                    }
                    game.SwitchTurn();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }
    }
}
