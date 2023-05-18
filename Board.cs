
using System.Runtime.InteropServices;
using TrePåRad;

namespace TrePåRad;

public class Board
{
    internal List<Square> Squares { get; }

    public Board()
    {
        Squares = new List<Square>();

        for (int i = 0; i < 9; i++)
        {
            if (i == 0 || i == 3 || i == 6)
            {
                Squares.Add(new Square("a", i / 3, " "));
            }
            else if (i == 1 || i == 4 || i == 7)
            {
                Squares.Add(new Square("b", i / 3, " "));
            }
            else
            {
                Squares.Add(new Square("c", i / 3, " "));
            }
        }
    }

    public void Mark(string playerCommand, string xOrY)
    {
        _ =
        playerCommand == "a-1" ? Squares[0].Value = xOrY :
        playerCommand == "a-2" ? Squares[1].Value = xOrY :
        playerCommand == "a-3" ? Squares[2].Value = xOrY :
        playerCommand == "b-1" ? Squares[3].Value = xOrY :
        playerCommand == "b-2" ? Squares[4].Value = xOrY :
        playerCommand == "b-3" ? Squares[5].Value = xOrY :
        playerCommand == "c-1" ? Squares[6].Value = xOrY :
        playerCommand == "c-2" ? Squares[7].Value = xOrY :
        playerCommand == "c-3" ? Squares[8].Value = xOrY : null;
    }

    public bool IsTaken(string playerCommand)
    {
        bool isTaken =
            (playerCommand != "a-1" || Squares[0].Value == " ") &&
            (playerCommand != "a-2" || Squares[1].Value == " ") &&
            (playerCommand != "a-3" || Squares[2].Value == " ") &&
            (playerCommand != "b-1" || Squares[3].Value == " ") &&
            (playerCommand != "b-2" || Squares[4].Value == " ") &&
            (playerCommand != "b-3" || Squares[5].Value == " ") &&
            (playerCommand != "c-1" || Squares[6].Value == " ") &&
            (playerCommand != "c-2" || Squares[7].Value == " ") &&
            (playerCommand != "c-3" || Squares[8].Value == " ");
        return isTaken;
    }

    public bool HasPlayerWon(string userInput)
    {
        /* Checks if the rows are the same */
        bool isGameOver =
        Squares[0].Value == userInput && Squares[1].Value == userInput && Squares[2].Value == userInput ||
        Squares[3].Value == userInput && Squares[4].Value == userInput && Squares[5].Value == userInput ||
        Squares[6].Value == userInput && Squares[7].Value == userInput && Squares[8].Value == userInput ||
        /* Checks if the columns are the same */
        Squares[0].Value == userInput && Squares[3].Value == userInput && Squares[6].Value == userInput ||
        Squares[1].Value == userInput && Squares[4].Value == userInput && Squares[7].Value == userInput ||
        Squares[2].Value == userInput && Squares[5].Value == userInput && Squares[8].Value == userInput ||
        /* Checks if the diagonal lines are the same */
        Squares[0].Value == userInput && Squares[4].Value == userInput && Squares[8].Value == userInput ||
        Squares[2].Value == userInput && Squares[4].Value == userInput && Squares[6].Value == userInput ? true : false;
        return isGameOver;
    }
}
