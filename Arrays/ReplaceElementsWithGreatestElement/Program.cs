// LeetCode : https://leetcode.com/explore/learn/card/fun-with-arrays/511/in-place-operations/3259/
/* Given an array arr, replace every element in that array with the greatest element among the elements to its right, 
and replace the last element with -1.
After doing so, return the array. */


var result = ReplaceElements([17, 18, 5, 4, 6, 1]);
Console.ReadLine();

int[] ReplaceElements(int[] arr)
{
    var greatest = -1;
    var temp = 0;

    for (int i = arr.Length - 1; i >= 0; i--)
    {
        temp = arr[i]; 
        arr[i] = greatest;

        if (temp > greatest)
        {
            greatest = temp;
        }
    }

    return arr;
}