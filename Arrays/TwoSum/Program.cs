// LeetCode : https://leetcode.com/problems/two-sum/description/?envType=problem-list-v2&envId=array

// hashset ایندکس نداره و فقط برای نگهداری دیتا استفاده میشود
var result = TwoSum([2, 7, 11, 15], 9);
Console.ReadLine();

int[] TwoSum(int[] nums, int target)
{
    int[] result = new int[2];
    HashSet<int> hashSet = new HashSet<int>();

    for (int i = 0; i < nums.Count(); i++)
    {
        var y = target - nums[i];

        if (!hashSet.Contains(y))
        {
            hashSet.Add(nums[i]);
        }

        else
        {
            var index = Array.IndexOf(nums, y);
            result[0] = index;
            result[1] = i ;
        }
    }

    return result;
}