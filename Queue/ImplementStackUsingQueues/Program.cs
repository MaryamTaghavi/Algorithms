// LeetCode : https://leetcode.com/problems/implement-stack-using-queues/description/


MyStack myStack = new MyStack();
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);

myStack.Peek(); // return 3
myStack.Pop(); // return 3
myStack.Empty(); // return False

public class MyStack
{
    Queue<int> queue1 = new Queue<int>();
    Queue<int> queue2 = new Queue<int>();

    public MyStack()
    {
    }

    public void Push(int x)
    {
        while (queue1.Count > 0)
        {
             queue2.Enqueue(queue1.Dequeue());
        }

        queue1.Enqueue(x);

        while (queue2.Count > 0)
        {
            queue1.Enqueue(queue2.Dequeue());
        }
    }

    public int Pop()
    {
        return queue1.Dequeue();
    }

    public int Peek()
    {
        // فقط عنصر برداشته میشه و دیده میشه ولی در واقع حذف نمیشه برمیداریم میبینیم و میذاریم سر جاش
        var top = queue1.Dequeue();

        Push(top);

        return top ;
    }

    public bool Empty()
    {
        return queue1.Count() == 0;
    }
}