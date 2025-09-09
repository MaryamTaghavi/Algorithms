// LeetCode : https://leetcode.com/problems/two-sum/description/?envType=problem-list-v2&envId=array

// HashSet ایندکس نداره و فقط برای نگهداری دیتا استفاده میشود
// چون هم میخوایم دیتا و هم ایندکس را نگه داریم از دیکشنری استفاده میکنیم
var result = TwoSum([2, 7, 11, 15], 9);
Console.ReadLine();

int[] TwoSum(int[] nums, int target)
{
    int[] result = new int[2];
    Dictionary<int,int> dict = new Dictionary<int,int>();

    for (int i = 0; i < nums.Count(); i++)
    {
        var y = target - nums[i];

        if (dict.ContainsKey(y))
        {
            return new int[] { dict[y], i };
        }

        else
        {
            dict[nums[i]] = i;
        }
    }

    return result;
}