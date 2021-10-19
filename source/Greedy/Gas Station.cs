public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int left = 0;
        var queue = new Queue<int>();
        var index = 0;
        var LENGTH = gas.Length * 2 + 1;
        for(int i = 0; i < LENGTH; i++){
            if(left < 0){
                queue.Clear();
                left = 0;
            }
            index = i % gas.Length;
            left += gas[index];
            left -= cost[index];
            queue.Enqueue(index);
            if(queue.Count == gas.Length && left >=0)
                return queue.Dequeue();
        }
        return -1;
    }
}
