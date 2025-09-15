// LeetCode : https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/?utm_source=chatgpt.com

// چون آرایه سورت شده است با دو اشاره گر میتوان آن را حل کرد

var reusult = TwoSum([2, 7, 11, 15], 9);
Console.ReadLine();

int[] TwoSum(int[] numbers, int target)
{
    int[] result = new int[2];
    int right = numbers.Length - 1;
    int left = 0;

    for (int i = 0; i < numbers.Length - 1; i++)
    {
        var sum = numbers[right] + numbers[left];

        if (sum == target)
        {
            result[0] = left + 1;
            result[1] = right + 1;

            return result;
        }
        else if (sum < target)
        {
            left++;
        }
        else
        {
            right--;
        }
    }

    return result;
}