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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
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
            current = current.next;
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

public class Program
{
    public static void Main(string[] args)
    {
        var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(3)));

        Solution solution = new Solution();
        ListNode result = solution.MergeTwoLists(list1, list2);

        PrintList(result);
    }

    private static void PrintList(ListNode head)
    {
        ListNode current = head;
        while (current != null)
        {
            Console.WriteLine(current.val + " -> ");
            current = current.next;
        }
        Console.WriteLine("null");

    }
}
