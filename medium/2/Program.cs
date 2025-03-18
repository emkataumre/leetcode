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
public class Solution
{
    public ListNode AddTwoNumbers(ListNode list1, ListNode list2)
    {
        int carry = 0;
        ListNode dummy = new ListNode();
        ListNode current = dummy;
        while (list1 != null || list2 != null || carry > 0)
        {
            int val1 = (list1 != null) ? list1.val : 0;
            int val2 = (list2 != null) ? list2.val : 0;

            int sum = val1 + val2 + carry;
            carry = sum / 10;
            int digit = sum % 10;

            current.next = new ListNode(digit);

            current = current.next;

            if (list1 != null) list1 = list1.next;
            if (list2 != null) list2 = list2.next;

        }

        return dummy.next;
    }
}