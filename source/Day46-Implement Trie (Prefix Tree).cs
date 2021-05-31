public class Trie {
    
    private TrieNode root;
    /** Initialize your data structure here. */
    public Trie() {
        root = new TrieNode();
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        TrieNode node = root;
        for (int i = 0; i < word.Length; i++) {
            char currentChar = word[i];
            if (!node.ContainsKey(currentChar)) {
                node.Put(currentChar, new TrieNode());
            }
            node = node.Get(currentChar);
        }
        node.IsEnd = true;

    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
       TrieNode node = SearchPrefix(word);
       return node != null && node.IsEnd;

    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        TrieNode node = SearchPrefix(prefix);
        return node != null;
    }
    
     private TrieNode SearchPrefix(String word) {
         TrieNode node = root;
         for (int i = 0; i < word.Length; i++) {
            char curLetter = word[i];
            if (node.ContainsKey(curLetter)) {
                node = node.Get(curLetter);
            } else {
                return null;
            }
         }
         return node;
    }
    
    public class TrieNode{
        private TrieNode[] links;
        public bool IsEnd;
        
        public TrieNode(){
            links = new TrieNode[26];
        }
        public bool ContainsKey(char c){
            return links[c - 'a'] != null;
        }
        
        public TrieNode Get(char c){
            return links[c - 'a'];
        }
        
        public void Put(char c, TrieNode node){
            links[c - 'a'] = node;
        }
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
