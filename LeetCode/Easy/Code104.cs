using System;

namespace LeetCode
{
    public class Code104
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

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            var l = 1 + MaxDepth(root.left);
            var r = 1 + MaxDepth(root.right);
            return Math.Max(l, r);
        }
    }
}