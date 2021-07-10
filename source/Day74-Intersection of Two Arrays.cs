public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> hashset = new HashSet<int>();
        for(int i=0; i < nums1.Length; i++){
            hashset.Add(nums1[i]);
        }
        HashSet<int> intersection = new HashSet<int>();
        for(int i=0; i < nums2.Length; i++){
            if(hashset.Contains(nums2[i]))
                intersection.Add(nums2[i]);
        }
        int[] result = new int[intersection.Count];
        intersection.CopyTo(result);
        return result;
    }
}
