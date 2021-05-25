public class Solution {
    public int Rob(int[] nums)
    {
        var n = nums.Length;
        if (n > 4)
        {
            nums[2] = nums[2] + nums[0];
            nums[3] = Math.Max(nums[3] + nums[0], nums[3] + nums[1]);

            var result = 0;
            for (int i = 4; i < n; i++)
            {
                nums[i] = Math.Max(nums[i] + nums[i - 2], nums[i] + nums[i - 3]);
                result = Math.Max(nums[i - 1], nums[i]);
            }
            return result;
        }
        if (n == 4)
        {
            return Math.Max(Math.Max(nums[0] + nums[3], nums[0] + nums[2]), nums[1] + nums[3]);
        }
        if (n == 3)
        {
            return Math.Max(nums[0] + nums[2], nums[1]);
        }
        if (n == 2)
        {
            return Math.Max(nums[0], nums[1]);
        }
        if (n == 1)
        {
            return nums[0];
        }
        return 0;
    }
}
