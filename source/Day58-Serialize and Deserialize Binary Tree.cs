public class Codec
{
    // Encodes a tree to a single string.
    public string serialize(TreeNode root)
    {
        if (root == null)
            return string.Empty;
        List<string> nums = new List<string>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            nums.Add(node?.val == null ? "null" : node.val.ToString());
            if (node == null)
                continue;
            queue.Enqueue(node.left);
            queue.Enqueue(node.right);
        }
        return string.Join(",", nums);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data)
    {
        if (data == string.Empty)
            return null;
        var dataArray = data.Split(',');
        var root = new TreeNode(Convert.ToInt32(dataArray[0]));
        Queue<TreeNode> queue = new Queue<TreeNode>(new[] { root });
        for (int i = 1; i < dataArray.Length; i++)
        {
            var parent = queue.Dequeue();
            if (dataArray[i] != "null")
            {
                var left = new TreeNode(Convert.ToInt32(dataArray[i]));
                queue.Enqueue(left);
                parent.left = left;
            }
            if (dataArray[++i] != "null")
            {
                var right = new TreeNode(Convert.ToInt32(dataArray[i]));
                queue.Enqueue(right);
                parent.right = right;
            }
        }

        return root;
    }
}
