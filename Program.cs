using TrePåRad;

namespace TrePåRad

{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Who's turn is decided by bool, True = X, False = O */
            bool turnOrder = true;
            bool gameOn = true;
            var board = new Board();
            string[] validCommands = { "a-1", "a-2", "a-3", "b-1", "b-2", "b-3", "c-1", "c-2", "c-3" };
            string playerCommand = "";

            /* While the game is running, loop rund until someone has won */
            while (gameOn)
            {
                /* if turnorder == true its the users (X) turn, else it's the computer's turn */
                if (turnOrder)
                {
                    bool userValidInput = false;
                    GameConsole.Show(board);
                    //Console.WriteLine(board.Squares[0].State);
                    /* If the player does not write a valid command it will loop and the user has to write a valid command */
                    while (!validCommands.Contains(playerCommand))
                    {
                        Console.WriteLine("You are 'X'. Please type your position (E.g. a-1, a-2)");
                        Console.Write("Your position: ");
                        /* If the user writes an input where the board already has an X or an O it will loop and user has to type in another cord */
                        while (!userValidInput)
                        {
                            playerCommand = Console.ReadLine();
                            if (!board.IsTaken(playerCommand))
                            {
                                Console.WriteLine("That square is already taken, please choose another.");
                            }
                            else
                            {
                                userValidInput = true;
                            }
                        }
                    }
                    board.Mark(playerCommand, "X");
                    if (board.HasPlayerWon("X") == "X")
                    {
                        Console.WriteLine("Player X has won");
                        gameOn = false;
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
                            turnOrder = true;
                            isTaken = false;
                        }
                    }


                }
            }
        }
    }
}

