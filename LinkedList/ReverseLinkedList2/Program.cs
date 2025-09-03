//LeetCode : https://leetcode.com/problems/reverse-linked-list-ii/description/?utm_source=chatgpt.com

ListNode head = new ListNode(1);
head.next = new ListNode(3);
head.next.next = new ListNode(5);
head.next.next.next = new ListNode(2);
head.next.next.next.next = new ListNode(10);

ReverseBetween(head, 2, 4);

ListNode ReverseBetween(ListNode head, int left, int right)
{
    if (head == null || left == right) 
        return head ;

    ListNode dummy = new ListNode(0, head) ;
    ListNode prev = dummy ;

    for (int i = 1; i < left; i++)
    {
        prev = prev.next;
    }

    ListNode curr = prev.next ;
    ListNode next = null ;
    ListNode prevSub = null ;

    for (int i = 0; i <= right - left; i++)
    {
        next = curr.next ;
        curr.next = prevSub ;
        prevSub = curr;
        curr = next;
    }

    prev.next.next = curr ;
    prev.next = prevSub ;

    return dummy.next;
}

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