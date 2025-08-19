/* LeetCode : https://leetcode.com/explore/learn/card/fun-with-arrays/527/searching-for-items-in-an-array/3251/
/*
Given an array of integers arr, return true if and only if it is a valid mountain array.

Recall that arr is a mountain array if and only if:

arr.length >= 3
There exists some i with 0 < i < arr.length - 1 such that:
arr[0] < arr[1] < ... < arr[i - 1] < arr[i]
arr[i] > arr[i + 1] > ... > arr[arr.length - 1]

 */

var result = ValidMountainArray([1,2,3,4,5,6,7,8]);
Console.WriteLine(result);
Console.ReadLine();

bool ValidMountainArray(int[] arr)
{
    var length = arr.Length - 1;
    var i = 0;

    if (arr.Length < 3)
    {
        return false;
    }

    while (i < length && arr[i + 1] > arr[i])
    {
        i++;
    }

    if (i == length || i == 0)
    {
        return false;
    }


    while (i < length && arr[i + 1] < arr[i])
    {      
        i++;
    }

    return  i == length;
}