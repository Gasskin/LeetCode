namespace LeetCode
{
    public class Code101
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

        public bool IsSymmetric(TreeNode root)
        {
            return AreSymmetric(root.left, root.right);
        }

        public bool AreSymmetric(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }

            if (p == null || q == null)
            {
                return false;
            }

            return p.val == q.val && AreSymmetric(p.left, q.right) && AreSymmetric(p.right, q.left);
        }
    }
}