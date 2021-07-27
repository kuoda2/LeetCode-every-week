public class Solution {
    public string ReverseStr(string s, int k) {
        var charArray = s.ToCharArray();
        for (int start = 0; start < a.Length; start += 2 * k) {
            int i = start, j = Math.Min(start + k - 1, a.Length - 1);
            while (i < j) {
                char temp = a[i];
                charArray[i++] = a[j];
                charArray[j--] = tmp;
            }
        }
        return new string(charArray);
    }
}
