    public class Solution
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var result = new List<IList<int>>();
            if (nums.Length < 4)
                return result;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                // avoid duplicate
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    // avoid duplicate
                    if (j > i + 1 && nums[j] == nums[j - 1])
                        continue;
                    var left = j + 1;
                    var right = nums.Length - 1;
                    while (right > left)
                    {
                        if (nums[i] + nums[j] + nums[left] + nums[right] > target)
                            right--;
                        else if (nums[i] + nums[j] + nums[left] + nums[right] < target)
                            left++;
                        else
                        {
                            result.Add(new[] { nums[i], nums[j], nums[left], nums[right] });
                            // avoid duplicate
                            while (right > left && nums[right] == nums[right - 1]) right--;
                            while (right > left && nums[left] == nums[left + 1]) left++;
                            right--;
                            left++;
                        }
                    }
                }
            }
            return result;
        }
    }
