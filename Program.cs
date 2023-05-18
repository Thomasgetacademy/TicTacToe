using System.Linq.Expressions;
using TrePåRad;

namespace TrePåRad

{
    internal class Program
    {
        static void Main()
        {
            /* Who's turn is decided by bool, True = X, False = O */
            bool turnOrder = true;
            bool gameOn = true;
            var board = new Board();
            string[] validCommands = { "a-1", "a-2", "a-3", "b-1", "b-2", "b-3", "c-1", "c-2", "c-3" };

            /* While the game is running, loop rund until someone has won */
            while (gameOn)
            {
                /* if turnorder == true its the users (X) turn, else it's the computer's turn */
                if (turnOrder)
                {
                    GameConsole.Show(board);
                    /* If the player does not write a valid command it will loop and the user has to write a valid command */
                    /* If the user writes an input where the board already has an X or an O it will loop and user has to type in another cord */
                    string playerCommand;
                    do
                    {
                        Console.WriteLine("You are 'X'. Please type your position (E.g. a-1, a-2)");
                        Console.Write("Your position: ");
                        playerCommand = Console.ReadLine();
                    } while (!validCommands.Contains(playerCommand) || !board.IsTaken(playerCommand));

                    /* Marks the X or O depending on who's turn it is */
                    board.Mark(playerCommand, "X");
                    /* Check if player won */
                    if (board.HasPlayerWon("X"))
                    {
                        gameOn = false;
                        GameConsole.Show(board);
                        Console.WriteLine("You won!");
                    }
                    playerCommand = " ";
                    turnOrder = false;
                }
                else
                {
                    bool isTaken = true;
                    while (isTaken)
                    {
                        Random random = new Random();
                        int computerIndex = random.Next(0, validCommands.Length);
                        string computerCommand = validCommands[computerIndex];
                        Console.WriteLine(computerCommand);
                        if (!board.IsTaken(computerCommand))
                        {
                        }
                        else
                        {
                            board.Mark(computerCommand, "O");
                            /* Check if computer won */
                            if (board.HasPlayerWon("O"))
                            {
                                gameOn = false;
                                GameConsole.Show(board);
                                Console.WriteLine("The Computer won!");
                            }
                            turnOrder = true;
                            isTaken = false;
                        }
                    }


                }
            }
        }
    }
}

