public class MedianFinder {

 private List<int> list;

        public MedianFinder()
        {
            list = new List<int>();
        }

        public void AddNum(int num)
        {
            //list.Add(num);
            //list.Sort();
            var index = GetInsertIndex(list, num);
            list.Insert(index, num);
           
        }

        public double FindMedian()
        {
            var count = list.Count;
            var i = count / 2;
            if (count % 2 == 0)
            {
                return (list[i] + list[i - 1]) / (double)2;
            }
            else
                return list[i];
        }

        private int GetInsertIndex(List<int> nums, int target)
        {
            int lo = 0, hi = nums.Count - 1;
            while (lo <= hi)
            {
                var mid = (lo + hi) / 2;
                if (nums[mid] == target)
                    return mid + 1;
                else if (nums[mid] > target)
                {
                    hi = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    lo = mid + 1;
                }
            }
            return hi + 1;
        }
}
