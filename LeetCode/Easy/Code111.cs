using System;

namespace LeetCode
{
    public class Code111
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

        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            var m1 = MinDepth(root.right) + 1;
            var m2 = MinDepth(root.left) + 1;
            return root.left == null || root.right == null ? m1 + m2 + 1 : Math.Min(m1, m2) + 1;
        }
    }
}