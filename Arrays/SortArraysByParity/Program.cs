// LeetCode : https://leetcode.com/explore/learn/card/fun-with-arrays/511/in-place-operations/3260/

// Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.

// parity => equaility


int[] result = SortArrayByParity([5,1,7,3,8]);
Console.ReadLine();

static int[] SortArrayByParity(int[] nums)
{
    int length = nums.Length - 1; ;

    for (int i = 0; i < nums.Length; i++)
    {
        if ( i >= length)
        {
            break;
        }

        if (nums[i] % 2 != 0)
        {
            while (nums[length] % 2 != 0 && i < length)
            {
                length--;
            }

            var temp = nums[length];
            nums[length] = nums[i];
            nums[i] = temp;
        }
    }

    return nums;
}
