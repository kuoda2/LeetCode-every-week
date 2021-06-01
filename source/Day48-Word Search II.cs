public class Solution {
    public IList<string> FindWords(char[][] board, string[] words) {
       List<String> res = new List<string>();
        TrieNode root = BuildTrieNode(words);
        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[0].Length; j++) {
                DFS(board, i, j, root, res);
            }
        }
        return res;
    }
    
    public TrieNode BuildTrieNode(string[] words){
        var root = new TrieNode();
        for(int i = 0; i < words.Length; i++){
            TrieNode n = root;
            for(int j = 0; j < words[i].Length; j++){
                char c = words[i][j];
                if(n.Next[c - 'a'] == null)
                    n.Next[c - 'a'] = new TrieNode();
                n = n.Next[c - 'a'];
            }
            n.Val = words[i];
            
        }
        return root;
        
    }
    
    public void DFS(char[][] board, int i , int j, TrieNode node, List<string> result){
        char c = board[i][j];
        if(c == '#' || node.Next[c - 'a'] == null) return;
        node = node.Next[c - 'a'];
        if(node.Val != null){
            result.Add(node.Val);
            node.Val = null;
        }
        board[i][j] = '#';
        if(i > 0) DFS(board, i - 1, j, node, result);
        if(j > 0) DFS(board, i, j - 1, node, result);
        if(i < board.Length - 1) DFS(board, i + 1, j , node, result);
        if(j < board[0].Length - 1) DFS(board, i, j + 1, node, result);
        board[i][j] = c;
    }
    public class TrieNode{
        public string Val;
        public TrieNode[] Next = new TrieNode[26];
    }
}
