public class WordDictionary {
    public class TrieNode {
        public TrieNode[] Children = new TrieNode[26];
        public bool IsEnd;
    }
    
    private TrieNode root;
    /** Initialize your data structure here. */
    public WordDictionary() {
        root = new TrieNode();
    }
    
    public void AddWord(string word) {
        var node = root;
        for(int i=0; i < word.Length; i++){
            var c = word[i];
            if(node.Children[c - 'a'] == null)
                node.Children[c - 'a'] = new TrieNode();
            node = node.Children[c - 'a'];
        }
        node.IsEnd = true;
        
    }
    
    public bool Search(string word) {
        return Match(word.ToCharArray(),0, root);
    }
    
    private bool Match(char[] chs, int index, TrieNode node) {
        if (index == chs.Length) return node.IsEnd;   
        if (chs[index] != '.') {
            return node.Children[chs[index] - 'a'] != null && Match(chs, index + 1, node.Children[chs[index] - 'a']);
        } else {
            for (int i = 0; i < node.Children.Length; i++) {
                if (node.Children[i] != null) {
                    if (Match(chs, index + 1, node.Children[i])) {
                        return true;
                    }
                }
            }
        }
        return false;
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
