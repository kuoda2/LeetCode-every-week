public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        IList<int> result = new List<int>();
        int[] mstep = new int[4]{0,1,0,-1};
        int[] nstep = new int[4]{1,0,-1,0};
        int m = matrix.Length;
        int n = matrix[0].Length;
        int ml = 0;
        int nl = 0;
        int step = m * n - 1;
        int tempM = 0;
        int tempN = 0;
        
        int loopStep = 4;
        int i = 0;
        int l = 0;
        m--;
        n--;
        while(i <= step){
            
      
          Console.WriteLine("m=>{0}, n=>{1}, ml=>{2}, nl=>{3}, l=>{4}",m,n,ml,nl,l);
                Console.WriteLine(tempM.ToString() + " " + tempN.ToString());
                result.Add(matrix[tempM][tempN]);
                i++;

               
                var tm = tempM + mstep[l];
                var tn = tempN + nstep[l];
                if(tm > m || tn > n)
                {
                    Console.WriteLine("tm=>{0}, tn=>{1}",tm,tn);
                    nl += Math.Abs(nstep[l]);

                    m -= Math.Abs(mstep[l]);
                    l++;
                    Console.WriteLine("l++");
                }
                else if(tm < ml || tn < nl){
                   Console.WriteLine("tm=>{0}, tn=>{1}",tm,tn);
                    Console.WriteLine("ml=>{0},nl=>{1}",ml,nl);
                    n -= Math.Abs(nstep[l]);

                    ml += Math.Abs(mstep[l]);
                    l++;
                    Console.WriteLine("l++");


                }
            if(l == 4)
                l = 0;
            
            tempM += mstep[l];
            tempN += nstep[l];
            Console.WriteLine(tempM.ToString() + " " + tempN.ToString());
            Console.WriteLine();

            }
        
        return result;

    }
   
}
