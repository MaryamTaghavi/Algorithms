// LeetCode : https://leetcode.com/explore/learn/card/fun-with-arrays/511/in-place-operations/3157/

MoveZeroes([0,1 , 0 , 0 , 2 , 3]);

static int[] MoveZeroes(int[] nums) 
{
    // Best Solution 

    int insertPos = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != 0)
        {
            nums[insertPos] = nums[i];
            if (i != insertPos) nums[i] = 0;
            insertPos++;
        }
    }

    // My Solution

    //int length = 1;

    //for (int i = 0; i < nums.Length - 1; i++)
    //{
    //    if (nums[i] == 0)
    //    {
    //        length = i + 1;
    //        if(length >= nums.Length)
    //        {
    //            break;
    //        }

    //        while (length < nums.Length && nums[length] == 0)
    //        {
    //            length++;
    //        }

    //        if (length < nums.Length)
    //        {
    //            nums[i] = nums[length];
    //            nums[length] = 0;
    //        }
    //    }
//}

    return nums;
}