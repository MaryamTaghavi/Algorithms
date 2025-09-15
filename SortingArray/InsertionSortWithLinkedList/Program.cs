// LeetCode : https://leetcode.com/problems/insertion-sort-list/description/ => LinkedList

// متوجه نشدم

ListNode head = new ListNode(1);
head.next = new ListNode(3);
head.next.next = new ListNode(5);
head.next.next.next = new ListNode(2);
head.next.next.next.next = new ListNode(11);
head.next.next.next.next.next = new ListNode(10);

// curr همیشه عنصر فعلی است که از لیست اصلی برداشتیم و میخواهیم در جای درست قرار بگیرد.
// prev عنصری است که قبل از جای مناسب curr قرار دارد.
// هیچ جابه‌جایی (swap) ای انجام نمی‌شود، فقط pointerها تغییر می‌کنند.

var result = InsertionSortList(head);
Console.ReadLine();

// خیلی سخت / متوجه نشدم
ListNode InsertionSortList(ListNode head)
{
    ListNode sorted = new ListNode(int.MinValue);
    ListNode curr = head;

    while (curr != null)
    {
        var key = curr.next;

        ListNode prev = sorted;

        while (prev.next != null && prev.next.val < curr.val)
        {
            prev = prev.next;
        }

        curr.next = prev.next;
        prev.next = curr;

        curr = key;
    }

    return sorted.next;
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