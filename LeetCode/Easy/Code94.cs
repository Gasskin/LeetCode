using System.Collections.Generic;

namespace LeetCode
{
    public class Code94
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        
        public IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            if (root == null)
                return result;
            if (root.left != null)
                result.AddRange(InorderTraversal(root.left));
            result.Add(root.val);
            if (root.right != null)
                result.AddRange(InorderTraversal(root.right));
            return result;
        }
    }
}