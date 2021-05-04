public class Solution {
    public bool Exist(char[][] board, string word) {
        for(int i = 0; i < board.Length; i++)
            for(int j = 0; j < board[0].Length; j++)
                if(Exist(board, i, j, word, 0))
                    return true;
        return false;
    }
    
    public bool Exist(char[][] board, int i , int j, string word, int index){
        if(index == word.Length)
            return true;
        if(i < 0 || j < 0 || i == board.Length || j == board[0].Length)
            return false;
        if(board[i][j] != word[index])
            return false;
        // to prevent take the same char twice
        board[i][j] = '#';
        
        var result = Exist(board, i - 1, j, word, index+1) ||
                     Exist(board, i, j - 1, word, index+1) ||
                     Exist(board, i + 1, j, word, index+1) ||
                     Exist(board, i, j + 1, word, index+1);
        board[i][j] = word[index];
        return result;
    }
}
