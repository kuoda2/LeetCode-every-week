public class Solution {
    public void Rotate(int[][] matrix) {
        var n = matrix.Length;
        var record = new int[n,n];
        for(int x = 0 ; x < n ; x++){
            for(int y = 0; y < n ; y++){
                var tempX = x;
                var tempY = y;
                for(int times = 0; times < 3; times++){
                    record[tempX, tempY] = 1;
                    
                    var newX = n - 1 - tempY;
                    var newY = tempX;
                    if(record[newX, newY] == 1)
                        continue;
                    record[newX, newY] = 1;

                    Console.WriteLine(newX);
                    Console.WriteLine(newY);
                    Console.WriteLine();
                    int tempValue = matrix[newX][newY];
                    matrix[newX][newY] = matrix[tempX][tempY];
                    matrix[tempX][tempY] = tempValue;

                    
                    
                    tempX = newX;
                    tempY = newY;
                }
            }
        }
    }
}
