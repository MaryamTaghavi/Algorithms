// LeetCode : https://leetcode.com/problems/insertion-sort-list/description/ => LinkedList

ListNode head = new ListNode(1);
head.next = new ListNode(3);
head.next.next = new ListNode(5);
head.next.next.next = new ListNode(2);
head.next.next.next.next = new ListNode(11);
head.next.next.next.next.next = new ListNode(10);


ListNode InsertionSortList(ListNode head)
{
    return null;
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