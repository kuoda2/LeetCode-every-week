public class Solution {
  public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var sets = new List<IList<int>>();
            GenerateSets(candidates, target, 0, 0, new List<int>(), sets);
            return sets;
        }

        public void GenerateSets(int[] candidates, int target, int index, int currentSum, List<int> current, List<IList<int>> sets)
        {
            if(currentSum > target) return;
            
            if (currentSum == target) {
                var c = new List<int>();
                c.AddRange(current);
                sets.Add(c);
                return;
            }

            for (int i = index; i < candidates.Length; i++) {
                currentSum = currentSum + candidates[i];
                current.Add(candidates[i]);
                GenerateSets(candidates, target, i, currentSum, current, sets);
                currentSum = currentSum - candidates[i];
                current.Remove(candidates[i]);
            }
        }

}
