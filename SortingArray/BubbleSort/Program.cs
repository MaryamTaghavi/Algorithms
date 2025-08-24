// Leetcode : https://leetcode.com/problems/height-checker/editorial/
// Time Complexity: O(n^2)


var result = SortArrays([10, 2, 4, 5, 3, 7, 9]);
Console.ReadLine();

int[] SortArrays(int[] arr)
{
    var length = arr.Length - 1 ;
    for (int i = 0; i < length; i++)
    {
        for(int j = 0; j < length - i; j++)
        {
            if( arr[j] > arr[j+1])
            {
                var temp = arr[j + 1];
                arr[j+1] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr;
}