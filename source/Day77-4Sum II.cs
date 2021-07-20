public class Solution {
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
        {
            var result = 0;
            Dictionary<int, int> map1 = new Dictionary<int, int>();
            Dictionary<int, int> map2 = new Dictionary<int, int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums1.Length; j++)
                {
                    var key = nums1[i] + nums2[j];
                    if (map1.ContainsKey(key))
                        map1[key]++;
                    else
                        map1[key] = 1;
                }
            }
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums1.Length; j++)
                {
                    var key = nums3[i] + nums4[j];
                    if (map2.ContainsKey(key))
                        map2[key]++;
                    else
                        map2[key] = 1;
                }
            }

            foreach (var item in map1)
            {
                var key1 = item.Key;
                var key2 = 0 - key1;
                if (map2.ContainsKey(key2))
                {
                    var count = map1[key1] * map2[key2];
                    result += count;
                }
            }
            return result;
        }
}
