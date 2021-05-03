public class Solution {
    public void SetZeroes(int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int[] nArray = new int[n];
        int[] mArray = new int[m];
        
        for(int i=0; i<m; i++){
            for(int j = 0; j< n; j++){
                if(matrix[i][j] == 0)
                {
                    nArray[j] = 1;
                    mArray[i] = 1;
                }

            }
        }
       for(int i=0; i<m; i++){
            for(int j = 0; j< n; j++){
                if(nArray[j] == 1 || mArray[i] == 1)
                    matrix[i][j] = 0;
            }
        }
        
    }
}
