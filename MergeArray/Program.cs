// LeetCode : https://leetcode.com/explore/learn/card/fun-with-arrays/525/inserting-items-into-an-array/3253/

/* You are given two integer arrays num1 and nums2, sorted in non-decreasing order, and two integers m and n, 
representing the number of elements in nums1 and nums2 respectively.
Merge nums1 and nums2 into a single array sorted in non-decreasing order.
The final sorted array should not be returned by the function, but instead be stored inside the array nums1. 
To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, 
and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
 */

var result = Merge([1] , 1 , [] , 0);

var result2 = Merge2([1], 1, [], 0);

int[] Merge(int[] nums1, int m, int[] nums2, int n)
{
    int[] temp = new int[m + n];
    var length = 0;
    var tempCount = 0;

    for (int i = 0; i < m ; i++)
    { 
        for(int j = tempCount ; j < nums2.Length; j++)
        {
            if (nums2[tempCount] <= nums1[i])
            {
                temp[length] = nums2[tempCount];
                length++;
                tempCount++;
            }
        }

        temp[length] = nums1[i];
        length++;        
    }

    for(int j = tempCount; j < nums2.Length; j++)
    {
        temp[length] = nums2[tempCount];
        length++;
        tempCount++;
    }

    for (int i = 0; i < temp.Length; i++)
    {
        nums1[i] = temp[i];
    }

    return nums1;
}


// The best answer

int[] Merge2(int[] nums1, int m, int[] nums2, int n)
{
    int i = m - 1; // آخرین عنصر معتبر در nums1
    int j = n - 1; // آخرین عنصر در nums2
    int k = m + n - 1; // آخرین جای nums1

    while (i >= 0 && j >= 0)
    {
        if (nums1[i] > nums2[j])
        {
            nums1[k] = nums1[i];
            i--;
        }
        else
        {
            nums1[k] = nums2[j];
            j--;
        }
        k--;
    }

    // اگر nums2 هنوز باقی مونده باشه
    while (j >= 0)
    {
        nums1[k] = nums2[j];
        j--;
        k--;
    }
    return nums1;
}
