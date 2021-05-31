public class Solution {
    public int NumIslands(char[][] grid) {
        int maxM = grid.Length;
        int maxN = grid[0].Length;
        int result = 0;
        for(int m = 0; m < maxM; m++){
            for(int n = 0; n < maxN; n++){
                if(grid[m][n] == '1'){
                    MarkIslandNearBy(m, n, maxM, maxN, grid);
                    result++;
                }
            }
        }
        return result;
    }
    
    public void MarkIslandNearBy(int m, int n, int maxM, int maxN, char[][] grid){
        if(m < 0 || n < 0 || m >= maxM || n >= maxN || grid[m][n] != '1') 
            return;
        grid[m][n] = '0';
        
        MarkIslandNearBy(m+1, n, maxM, maxN, grid);
        MarkIslandNearBy(m, n+1, maxM, maxN, grid);
        MarkIslandNearBy(m-1, n, maxM, maxN, grid);
        MarkIslandNearBy(m, n-1, maxM, maxN, grid);

        
    }
}
