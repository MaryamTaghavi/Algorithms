/* LeetCode : https://leetcode.com/explore/learn/card/fun-with-arrays/527/searching-for-items-in-an-array/3251/
/*
Given an array of integers arr, return true if and only if it is a valid mountain array.

Recall that arr is a mountain array if and only if:

arr.length >= 3
There exists some i with 0 < i < arr.length - 1 such that:
arr[0] < arr[1] < ... < arr[i - 1] < arr[i]
arr[i] > arr[i + 1] > ... > arr[arr.length - 1]

 */

var result = ValidMountainArray([2, 1, 2, 3, 5, 7, 9, 10, 12, 14, 15, 16, 18, 14, 13]);
Console.WriteLine(result);
Console.ReadLine();

bool ValidMountainArray(int[] arr)
{
    var counter = false;

    if (arr.Length < 3)
    {
        return counter;
    }

    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (i > 0 && arr[i + 1] < arr[i] && arr[i - 1] < arr[i])
        {
            counter = true;
            continue;
        }

        if(!counter && arr[i + 1] < arr[i])
        {
            return false;
        }

        if (counter && arr[i] <= arr[i + 1] || arr[i] == arr[i + 1])
        {
            return false;
        }
    }

    return counter;
}