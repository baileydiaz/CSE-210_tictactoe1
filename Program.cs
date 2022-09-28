class TicTacToe
{
    static void Main(string[] args)
    {

        List<string> board = GetNewBoard();
        string currentPlayer = "x";

        while (!IsGameOver(board))
        {
            DisplayBoard(board);

            int choice = GetMoveChoice(currentPlayer);
            MakeMove(board, choice, currentPlayer);

            currentPlayer = GetNextPlayer(currentPlayer);
        }

        DisplayBoard(board);
        Console.WriteLine("Good game. Thanks for playing!");
    }

    /// <summary>Gets a new instance of the board with the numbers 1-9 in place. </summary>
    /// <returns>A list of 9 strings representing each square.</returns>
    static List<string> GetNewBoard()
    {
        //  Best way to create a list
        List<string> board = new List<string>();

        board.Add("1");
        board.Add("2");
        board.Add("3");
        board.Add("4");
        board.Add("5");
        board.Add("6");
        board.Add("7");
        board.Add("8");
        board.Add("9");
        return board;
    }

    /// <summary>Displays the board in a 3x3 grid.</summary>
    /// <param name="board">The board</param>
    static void DisplayBoard(List<string> board)
    {
        Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
    }

    /// <summary>
    /// Determines if the game is over because of a win or a tie.
    /// </summary>
    /// <param name="board">The current board.</param>
    /// <returns>True if the game is over</returns>
    static bool IsGameOver(List<string> board)
    {
        return IsWinner(board,"x") || IsWinner(board, "o")|| IsTie(board);
    }

    /// <summary>Determines if the provided player has a tic tac toe.</summary>
    /// <param name="board">The current board</param>
    /// <param name="player">The player to check for a win</param>
    /// <returns></returns>
    static bool IsWinner(List<string> board, string player)
    {
        if ((board[0]) == player && board[1] == player && board[2] == player) {
            return true;
        }

        if ((board[3]) == player && board[4] == player && board[5] == player) {
            return true; 
        }

        if ((board[6]) == player && board[7] == player && board[8] == player) {
            return true; 
        }

        if ((board[2]) == player && board[4] == player && board[6] == player) {
            return true;
        }

        if ((board[0]) == player && board[4] == player && board[8] == player) {
            return true; 
        }

        if ((board[0]) == player && board[3] == player && board[6] == player) {
            return true;
        }
        if ((board[1]) == player && board[4] == player && board[7] == player) {
            return true; 
        }
        if ((board[2]) == player && board[5] == player && board[8] == player) {
            return true;
        }

        return false;
    }

    /// <summary>Determines if the board is full with no more moves possible.</summary>
    /// <param name="board">The current board.</param>
    /// <returns>True if the board is full.</returns>
    static bool IsTie(List<string> board)
    {
        if (board.Contains("1")){
            return false;
        }
    
        if (board.Contains("2")){
            return false;
        }
        if (board.Contains("3")){
            return false;
        }
        if (board.Contains("4")){
            return false;
        }
        if (board.Contains("5")){
            return false;
        }
        if (board.Contains("6")){
            return false;
        }
        if (board.Contains("7")){
            return false;
        }
        if (board.Contains("8")){
            return false;
        }
        if (board.Contains("9"))
            {
            return false;
            }
        else{
            return true;
        }
    }

    /// <summary>Cycles through the players (from x to o and o to x)</summary>
    /// <param name="currentPlayer">The current players sign (x or o)</param>
    /// <returns>The next players sign (x or o)</returns>
    static string GetNextPlayer(string currentPlayer)
    {
        if (currentPlayer == "o"){
            return "x";
            }

        else {
            return "x";
        }
    }

    /// <summary>Gets the 1-based spot number associated with the user's choice.</summary>
    /// <param name="currentPlayer">The sign (x or o) of the current player.</param>
    /// <returns>A 1-based spot number (not a 0-based index)</returns>
    static int GetMoveChoice(string currentPlayer)
    {
        return 1;
    }

    /// <summary>
    /// Places the current players mark on the board at the desired spot.
    /// This method does NOT check to ensure the spot is available.
    /// </summary>
    /// <param name="board">The current board</param>
    /// <param name="choice">The 1-based spot number (not a 0-based index).</param>
    /// <param name="currentPlayer">The current player's sign (x or o)</param>
    static void MakeMove(List<string> board, int choice, string currentPlayer)
    {
        
    }
}

// Alternate solution for converting array to list

// return new List<string>(numbers)