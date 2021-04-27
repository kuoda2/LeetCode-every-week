public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        IList<int> result = new List<int>();
        int[] mstep = new int[4]{0,1,0,-1};
        int[] nstep = new int[4]{1,0,-1,0};
        int m = matrix.Length;
        int n = matrix[0].Length;
        int currM = 0;
        int currN = -1;
        
        List<int> list = new List<int>();
        m--;
        if(n > m)
        {
            for(int i = m; m > 0 ; m--, n--){
                list.Add(n);
                list.Add(m);
            }
            list.Add(n);
        }
        else{
              for(int i = n; n > 0 ; m--, n--){
                list.Add(n);
                list.Add(m);
            }
        }
        foreach(var a in list){
            Console.WriteLine(a);
        }
        
       int l = 0;
       for(int i = 0; i < list.Count(); i++){
           var step = list[i];
           for(int s = 0; s < step; s++){
           currN += nstep[l%4];
           currM += mstep[l%4];
           Console.WriteLine("currM=>{0}, currN=>{1}, l=>{2}",currM,currN,l);
           result.Add(matrix[currM][currN]);
           }
           l++;
       }
        return result;

    }
   
}
