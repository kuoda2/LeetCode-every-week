public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        Dictionary<int, HashSet<int>> edge = new Dictionary<int, HashSet<int>>();
        for (int i = 0; i < numCourses; i++)
            edge.Add(i, new HashSet<int>());

        for (int i = 0; i < prerequisites.Length; i++) {
            int key = prerequisites[i][0];
            int val = prerequisites[i][1];

            edge[key].Add(val);
        }

        bool[] visited = new bool[numCourses];
        bool[] used = new bool[numCourses];
        for (int i = 0; i < numCourses; i++) {
            if (!DFS(used, visited, edge, i)) return false;
        }

        return true;
    }

    private bool DFS(bool[] used, bool[] visited, Dictionary<int, HashSet<int>> edge, int i)
    {
        if (used[i]) return false;

        if (edge[i].Any() && !visited[i]) {
            visited[i] = true;

            used[i] = true;
            foreach (var v in edge[i]) {
                if (!DFS(used, visited, edge, v)) return false;
            }
            used[i] = false;
        }

        return true;
    }
}
