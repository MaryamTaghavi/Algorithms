// Leetcode : https://leetcode.com/problems/daily-temperatures/description/


// کامل نیست


/*
Given an array of integers temperatures represents the daily temperatures, 
return an array answer such that answer[i] is the number of days you have to wait after the ith day to get a warmer temperature. 
If there is no future day for which this is possible, keep answer[i] == 0 instead.
 */

// Stack نگه می‌داره اندیس روزهایی که هنوز جوابشون پیدا نشده.
var result = DailyTemperatures([73, 74, 75, 71, 69, 72, 76, 73]);
Console.ReadLine();

static int[] DailyTemperatures(int[] temperatures)
{
    Stack<int> stack = new Stack<int>();
    int[] result = new int[temperatures.Length];

    if (temperatures.Count() > 0)
    {
        stack.Push(temperatures[0]);
    }
    for (int i = 0; i < temperatures.Length; i++)
    {
        if (temperatures[i + 1] > temperatures[i])
        {
            result[i] = i;
            var peek = stack.Peek();

            while(stack.Count > 0)
            {
                if(temperatures[i + 1] > peek)
                {
                    result[peek] = 
                }
            }
        }

        else
        {
            stack.Push(temperatures[i]);
        }
    }

    return result;
}