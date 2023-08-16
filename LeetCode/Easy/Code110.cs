using System;

namespace LeetCode
{
    public class Code110
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

        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;
            var l = GetDepth(root.left);
            var r = GetDepth(root.right);
            return Math.Abs(l - r) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
        }

        private int GetDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            var l = GetDepth(root.left);
            var r = GetDepth(root.right);
            return Math.Max(l, r) + 1;
        }
    }
}