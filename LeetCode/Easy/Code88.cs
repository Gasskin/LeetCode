namespace LeetCode
{
    public class Code88
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return head;
            var preNode = head;
            var cur = head.next;
            while (cur != null)
            {
                if (cur.val == preNode.val)
                {
                    preNode.next = cur.next;
                    cur = cur.next;
                }
                else
                {
                    preNode = cur;
                    cur = cur.next;
                }
            }
            return head;
        }
    }
}