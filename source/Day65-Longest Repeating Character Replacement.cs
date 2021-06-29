public class Solution {
    public int CharacterReplacement(string s, int k) {
        // two pointer
        var length = s.Length;
        int[] count = new int[26];
        int maxCount= 0, maxLength= 0, start = 0;
        for(int end = 0; end < length ; end++){
            // get max same char count as base
            maxCount = Math.Max(maxCount, ++count[s[end] - 'A']);
            // if there is no more wildcard and over length, left pointer should move on
            while(end - start + 1 - maxCount > k)
            {   
                --count[s[start] - 'A'];
                start++;
            }
            // after while to make sure satisfy condition, compare the max length
            maxLength = Math.Max(maxLength, end - start + 1 );
            
        }
        return maxLength;
        
    }
}
