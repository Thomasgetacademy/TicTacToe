namespace TrePåRad;

public class GameConsole
{
    public static void Show(Board GameBoard)
    {
        Console.WriteLine("  1 2 3");
        Console.WriteLine(" ┌─────┐");
        Console.WriteLine($"a│{GameBoard.Squares[0].Value} {GameBoard.Squares[1].Value} {GameBoard.Squares[2].Value}│");
        Console.WriteLine($"b│{GameBoard.Squares[3].Value} {GameBoard.Squares[4].Value} {GameBoard.Squares[5].Value}│");
        Console.WriteLine($"c│{GameBoard.Squares[6].Value} {GameBoard.Squares[7].Value} {GameBoard.Squares[8].Value}│");
        Console.WriteLine(" └─────┘");
    }
}