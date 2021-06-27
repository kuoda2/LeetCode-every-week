public class Solution
{
    public int[] CountBits(int n)
    {
        int[] result = new int[n + 1];
        if (n == 0)
            return result;
        int current = 1;
        result[current] = 1;
        var cycleLentgh = 2;
        var cycleIndex = 0;
        while (++current <= n)
        {
            if (cycleIndex < cycleLentgh)
            {
                result[current] = result[cycleIndex] + 1;
            }
            else
            {
                cycleLentgh = current;
                cycleIndex = 0;
                result[current] = result[0] + 1;
            }
            cycleIndex++;
        }
        return result;
    }
}
