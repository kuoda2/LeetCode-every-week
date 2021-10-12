public class Solution {
    public int[][] ReconstructQueue(int[][] people) {
        Array.Sort(people, new OrderComparer());
        
        var result = new List<int[]>();
        foreach (var p in people)
        {
            result.Insert(p[1], p);
        }

        return result.ToArray();
    }
}

public class OrderComparer : IComparer<int[]>
{
   public int Compare(int[] x, int[] y)
   {
        if(x[0] == y[0])
            return x[1].CompareTo(y[1]);
        return  y[0].CompareTo(x[0]);
   }
}
