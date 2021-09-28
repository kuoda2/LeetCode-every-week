public class Solution
 {
     private List<IList<string>> result;
     private bool[] choosedX;
     private bool[] choosedY;
     private bool[] choosedSlopeAdd;
     private bool[] choosedSlopeMinus;

     public IList<IList<string>> SolveNQueens(int n)
     {
         result = new List<IList<string>>();
         choosedX = new bool[n];
         choosedY = new bool[n];
         choosedSlopeAdd = new bool[n * 2];
         choosedSlopeMinus = new bool[n * 2];
         BackTracking(new List<string>(), 0, n);
         return result;
     }

     public void BackTracking(List<string> list, int y, int n)
     {
         if (list.Count == n)
         {
             result.Add(list.ToList());
             return;
         }

         for (int i = 0; i < n; i++)
         {
             if (!choosedX[i] && !choosedY[y] && !choosedSlopeAdd[i + y] && !choosedSlopeMinus[i - y + n])
             {
                 var temp = new string('.', n);
                 temp = temp.Remove(i, 1).Insert(i, "Q");
                 list.Add(temp);
                 choosedX[i] = choosedY[y] = choosedSlopeAdd[i + y] = choosedSlopeMinus[i - y + n] = true;
                 BackTracking(list, y + 1, n);
                 list.RemoveAt(list.Count - 1);
                 choosedX[i] = choosedY[y] = choosedSlopeAdd[i + y] = choosedSlopeMinus[i - y + n] = false;
             }
         }
     }
 }
