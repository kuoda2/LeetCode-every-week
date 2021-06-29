public class Solution
 {
     public static void Backtrack(int i, int j, int iMax, int jMax)
     {
         if (i < 0 || j < 0 || i > iMax || j > jMax)
             return;
     }

     public class Solution
     {
         public IList<IList<int>> PacificAtlantic(int[][] heights)
         {
             var result = new List<IList<int>>();

             int m = heights.Length;
             int n = heights[0].Length;
             var ltOcean = new bool[m][];
             var rbOcean = new bool[m][];
             for (int i = 0; i < m; i++)
             {
                 ltOcean[i] = new bool[n];
                 rbOcean[i] = new bool[n];
             }
             // top and bottom
             for (int col = 0; col < n; col++)
             {
                 DFS(heights, 0, col, heights[0][col], ltOcean);
                 DFS(heights, m - 1, col, heights[m - 1][col], rbOcean);
             }

             // left and right
             for (int row = 0; row < m; row++)
             {
                 DFS(heights, row, 0, heights[row][0], ltOcean);
                 DFS(heights, row, n - 1, heights[row][n - 1], rbOcean);
             }
             for (int i = 0; i < m; i++)
             {
                 for (int j = 0; j < n; j++)
                 {
                     if (ltOcean[i][j] && rbOcean[i][j])
                         result.Add(new[] { i, j });
                 }
             }

             return result;
         }

         public void DFS(int[][] heights, int r, int c, int preHeight, bool[][] ocean)
         {
             if (r < 0 ||
                 c < 0 ||
                 r > heights.Length - 1 ||
                 c > heights[0].Length - 1 ||
                 ocean[r][c] ||
                 heights[r][c] < preHeight
                 )
                 return;
             ocean[r][c] = true;
             DFS(heights, r + 1, c, heights[r][c], ocean);
             DFS(heights, r, c + 1, heights[r][c], ocean);
             DFS(heights, r - 1, c, heights[r][c], ocean);
             DFS(heights, r, c - 1, heights[r][c], ocean);
         }
     }
 }
