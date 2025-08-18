// LeetCode : https://leetcode.com/explore/learn/card/fun-with-arrays/526/deleting-items-from-an-array/3247/

/* Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. 
 * The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.
Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:
Change the array nums such that the first k elements of nums contain the elements which are not equal to val. 
The remaining elements of nums are not important as well as the size of nums.
Return k.
 */

var result = RemoveElement2([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]);
Console.WriteLine(result);
Console.ReadLine();

int RemoveElement(int[] nums, int val)
{
    int length = nums.Length - 1 ;
    int i = 0;

    while (i <= length)
    {
        if (nums[i] == val)
        {
            while (i <= length && nums[length] == val)
            {
                length--;
            }
            if (i > length)
            {
                break;
            }

            nums[i] = nums[length];
            nums[length] = val;
        }
        else
        {
            i++;
        }
    }
    

    return length + 1;
}

/* مثال 2 :
توضیح:
بهت یه آرایه‌ی مرتب ‌شده از اعداد صحیح داده میشه. باید همه‌ی تکراری‌ها رو حذف کنی، طوری که هر عنصر فقط یکبار بیاد.
حذف هم باید in-place انجام بشه.
باید برگردونی k = تعداد عناصر یکتا.
و آرایه طوری تغییر کنه که nums[0..k-1] شامل اون عناصر یکتا باشه. */

int RemoveElement2(int[] nums)
{
    int i = 0;
    int length = nums.Length - 1;
    var element = nums[i];
    i++;

    for(int k = i; k <= nums.Length - 1 ; k++)
    {
        while (nums[k] == element)
        {
            while (nums[length] == nums[i])
            {
                length--;
            }

            nums[k] = nums[length];
            nums[length] = element;
            element = nums[k];
        }
    }

    return length;
}
