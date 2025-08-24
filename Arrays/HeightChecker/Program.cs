// LeetCode : https://leetcode.com/explore/learn/card/fun-with-arrays/523/conclusion/3228/

Console.WriteLine(HeightChecker([5, 1, 4, 2, 1,0, 3]));
Console.ReadLine();

static int HeightChecker(int[] heights)
{
    int[] expected = heights.OrderBy(h => h).ToArray();

    int mismatchCount = 0;

    for (int i = 0; i < heights.Length; i++)
    {
        if (heights[i] != expected[i])
            mismatchCount++;
    }

    return mismatchCount;
}