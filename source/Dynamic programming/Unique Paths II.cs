public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        if(obstacleGrid[0][0] == 1 || obstacleGrid[^1][^1] == 1)
            return 0;
        for(int i = 0; i < obstacleGrid[0].Length; i++){
            for(int j = 0; j < obstacleGrid.Length; j++){
                if(obstacleGrid[j][i] == 1)
                        continue;
                if(i == 0 && j == 0){
                    obstacleGrid[j][i] = -1;
                }
                else if(i == 0){
                    obstacleGrid[j][i] = obstacleGrid[j-1][i];
                }
                else if(j == 0){
                    obstacleGrid[j][i] = obstacleGrid[j][i-1];
                }
                else{
                    var top = obstacleGrid[j][i-1] == 1 ? 0 : obstacleGrid[j][i-1];
                    var left = obstacleGrid[j-1][i] == 1 ? 0 : obstacleGrid[j-1][i];
                    obstacleGrid[j][i] = top + left;
                }
            }
        }
        return obstacleGrid[^1][^1] * -1;
    }
}
