public class Solution_Revisited
{
    public ListNode MergeTwoSortedLists(ListNode list1, ListNode list2)
    {
        ListNode head = new ListNode();
        ListNode current = head;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {

                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;

            }
        }

        if (list1 != null)
        {
            current.next = list1;
        }
        if (list2 != null)
        {
            current.next = list2;
        }

        return head.next;
    }
}