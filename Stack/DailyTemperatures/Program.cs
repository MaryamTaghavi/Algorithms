// LeetCode : https://leetcode.com/problems/daily-temperatures/description/

/*
Given an array of integers temperatures represents the daily temperatures, 
return an array answer such that answer[i] is the number of days you have to wait after the ith day to get a warmer temperature. 
If there is no future day for which this is possible, keep answer[i] == 0 instead.
 */

// Stack نگه می‌داره اندیس روزهایی که هنوز جوابشون پیدا نشده.
var result = DailyTemperatures([30, 60, 90]);
Console.ReadLine();

static int[] DailyTemperatures(int[] temperatures)
{
    Stack<int> stack = new Stack<int>();
    int[] result = new int[temperatures.Length];

    for (int i = 0; i < temperatures.Length ; i++)
    {
        var j = stack.Count();

        while (j > 0)
        {
            var peek = stack.Peek();
            j--;
            if (temperatures[i] > temperatures[peek])
            {
                result[peek] = i - peek;
                stack.Pop();
            }
        }

        stack.Push(i);
    }

    return result;
}