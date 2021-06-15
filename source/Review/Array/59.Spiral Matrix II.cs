public class Solution {
 public int[][] GenerateMatrix(int n)
        {
            int[][] result = new int[n][];
            for (int k = 0; k < n; k++) result[k] = new int[n];
            var direction = new int[4][] { new[] { 0, 1 }, new[] { 1, 0 }, new[] { 0, -1 }, new[] { -1, 0 } };

            int i = 0;
            int val = 1;
            int x = 0;
            int y = -1;
            int minX = 0, minY = 0;
            int maxX = n - 1, maxY = n - 1;

            while (val <= n * n)
            {
                var nextY = y + direction[i][1];
                var nextX = x + direction[i][0];
                if (nextY <= maxY && nextY >= minY && nextX <= maxX && nextX >= minX)
                {
                    y = nextY;
                    x = nextX;
                    result[x][y] = val;
                    val++;
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            minX += 1;
                            break;

                        case 1:
                            maxY -= 1;
                            break;

                        case 2:
                            maxX -= 1;
                            break;

                        case 3:
                            minY += 1;
                            break;

                        default:
                            break;
                    }
                    i++;
                    i %= 4;
                }
            }
            return result;
        }
}
