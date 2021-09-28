public class Solution
{
    private char[] charSet = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

    public void SolveSudoku(char[][] board)
    {
        var count = 0;
        foreach (var row in board)
        {
            foreach (var item in row)
            {
                if (item == '.')
                    count++;
            }
        }
        BackTracking(board);
    }

    private bool BackTracking(char[][] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == '.')
                {
                    foreach (var c in charSet)
                    {
                        if (IsValid(i, j, c, board))
                        {
                            board[i][j] = c;
                            if (BackTracking(board))
                                return true;
                            board[i][j] = '.';
                        }
                    }
                    return false;
                }
            }
        }
        return true;
    }


    private bool IsValid(int row, int col, char c, char[][] board)
    {
        // check row
        for (int j = 0; j < board.Length; j++)
        {
            if (board[row][j] == c)
                return false;
        }

        // check column
        for (int i = 0; i < board.Length; i++)
        {
            if (board[i][col] == c)
                return false;
        }

        // check block
        var rowStart = (row / 3) * 3;
        var colStart = (col / 3) * 3;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[rowStart + i][colStart + j] == c)
                    return false;
            }
        }
        return true;
    }
}
