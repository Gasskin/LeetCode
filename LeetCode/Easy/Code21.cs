namespace LeetCode
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

    public class Code21
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }

            if (list2 == null)
            {
                return list1;
            }

            ListNode node;
            if (list1.val <= list2.val)
            {
                node = list1;
                list1 = list1.next;
            }
            else
            {
                node = list2;
                list2 = list2.next;
            }

            var head = node;
            
            while (true)
            {
                if (list1 == null)
                {
                    node.next = list2;
                    break;
                }
                
                if (list2 == null)
                {
                    node.next = list1;
                    break;
                }
                
                if (list1.val <= list2.val)
                {
                    node.next = list1;
                    node = node.next;
                    list1 = list1.next;
                }
                else
                {
                    node.next = list2;
                    node = node.next;
                    list2 = list2.next;
                }
            }

            return head;
        }
    }
}