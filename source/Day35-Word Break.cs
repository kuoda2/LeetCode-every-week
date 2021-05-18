public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        HashSet<string> hashSet = new HashSet<string>(wordDict);
        bool[] dp = new bool[s.Length+1];
        dp[0] = true;
        for(int i = 1; i <=s.Length; i++)
            for(int j = 0;j < i; j++){
                //Console.WriteLine("i:"+i +" j:" + j + "->" +s.Substring(j,i-j));
                dp[i] = dp[j] && hashSet.Contains(s.Substring(j,i-j));
                if(dp[i])
                    break;
                //Console.WriteLine("i:" + i + dp[i]);
            }
        return dp[s.Length];
    }
}
// input: leetcode
//
// i:1 j:0->l
// i:1False
// i:2 j:0->le
// i:2False
// i:2 j:1->e
// i:2False
// i:3 j:0->lee
// i:3False
// i:3 j:1->ee
// i:3False
// i:3 j:2->e
// i:3False
// i:4 j:0->leet
// i:4True
// i:5 j:0->leetc
// i:5False
// i:5 j:1->eetc
// i:5False
// i:5 j:2->etc
// i:5False
// i:5 j:3->tc
// i:5False
// i:5 j:4->c
// i:5False
// i:6 j:0->leetco
// i:6False
// i:6 j:1->eetco
// i:6False
// i:6 j:2->etco
// i:6False
// i:6 j:3->tco
// i:6False
// i:6 j:4->co
// i:6False
// i:6 j:5->o
// i:6False
// i:7 j:0->leetcod
// i:7False
// i:7 j:1->eetcod
// i:7False
// i:7 j:2->etcod
// i:7False
// i:7 j:3->tcod
// i:7False
// i:7 j:4->cod
// i:7False
// i:7 j:5->od
// i:7False
// i:7 j:6->d
// i:7False
// i:8 j:0->leetcode
// i:8False
// i:8 j:1->eetcode
// i:8False
// i:8 j:2->etcode
// i:8False
// i:8 j:3->tcode
// i:8False
// i:8 j:4->code
// i:8True
