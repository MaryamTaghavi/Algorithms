// LeetCode : https://leetcode.com/problems/linked-list-cycle/description/?utm_source=chatgpt.com
/* یعنی اینکه هیچ موقع یک نودی مشاهده نمیشود که next = null داشته باشه
 این یعنی همیشه حلقه داریم */

/*
فرض کنید یک پیست داریم که یک نفر با دوبرابر سرعت در حال دوین است
نفر دیگر با سرعت دو برابری در حال چرخیدن است
اگر پیست خطی باشد هیچ جا بهم نمیرسند
اما اگر گرد باشد بالاخره یک جا بهم میرسند
 */

ListNode head = new ListNode(1);
head.next = new ListNode(3);
head.next.next = new ListNode(5);
head.next.next.next = new ListNode(2);
head.next.next.next.next = new ListNode(10);
head.next.next.next.next.next = head.next.next;

Console.WriteLine(HasCycle(head));

bool HasCycle(ListNode head)
{
    ListNode slow = head;
    ListNode fast = head;

    while (slow != null && fast != null && fast.next != null)
    {
        slow = slow.next;
        fast = fast.next.next;

        if (slow == fast)
            return true;
    }



    return false;
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