// Leetcode : https://leetcode.com/problems/number-of-recent-calls/description/

RecentCounter obj = new RecentCounter();
int[] arrs = { 1, 250, 300, 4000 };
List<int> list = arrs.ToList();

for (int  i = 0 ; i < list.Count() ; i++)
{
    Console.WriteLine(obj.Ping(list[i]));
    list.Remove(list[i]);
}

Console.ReadLine();

public class RecentCounter
{
    Queue<int> queue;
    public RecentCounter()
    {
        queue = new Queue<int>();
    }

    public int Ping(int t)
    {
        queue.Enqueue(t);

        while (queue.Peek() < t - 3000)
        {
            queue.Dequeue();
        }

        return queue.Count();
    }
}