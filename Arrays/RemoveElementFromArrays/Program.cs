// LeetCode : https://leetcode.com/explore/learn/card/fun-with-arrays/526/deleting-items-from-an-array/3247/

/* Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. 
 * The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.
Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:
Change the array nums such that the first k elements of nums contain the elements which are not equal to val. 
The remaining elements of nums are not important as well as the size of nums.
Return k.
 */

var result1 = RemoveElement([1, 1, 2], 1);
Console.WriteLine(result1);

var result2 = RemoveElement2([1, 1, 2]);
Console.WriteLine(result2);

var result3 = MoveZeroes([7, 0, 0, 0]);
Console.WriteLine(result3);

Console.ReadLine();

int RemoveElement(int[] nums, int val)
{
    int length = nums.Length - 1;
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
بهت یه آرایه‌ی مرتب ‌شده از اعداد صحیح داده میشه. باید همه‌ی تکراری‌ها رو حذف کنی، طوری که هر عنصر فقط یکبار بیاد.
حذف هم باید in-place انجام بشه.
باید برگردونی k = تعداد عناصر یکتا.
و آرایه طوری تغییر کنه که nums[0..k-1] شامل اون عناصر یکتا باشه.
آرایه اولیه سورت شده است و آرایه نهایی شامل k عنصر اول هم باید سورت شده باشد*/

int RemoveElement2(int[] nums)
{
    int i = 1;
    int writeIndex = 0;

    while (i <= nums.Length - 1)
    {
        if (nums[i] != nums[writeIndex])
        {
            writeIndex++;
            nums[writeIndex] = nums[i];
        }
        i++;
    }

    return nums.Length > 0 ? writeIndex + 1 : 0;
}

// این الگوریتم با two pointer حل میشه


/*
Move Zeroes / حذف و جابه‌جایی صفرها

یه آرایه nums داده شده، شامل اعداد صحیح.
باید همه‌ی صفرها رو به انتهای آرایه منتقل کنی، ولی ترتیب بقیه‌ی عناصر حفظ بشه.
باید in-place باشه و از آرایه اضافی استفاده نکنی.
در نهایت فقط آرایه تغییر می‌کنه، خروجی هم آرایه تغییر یافته هست.

 */

int[] MoveZeroes(int[] nums)
{
    int i = 0;
    int writeIndex = 0;

    while (i <= nums.Length - 1)
    {
        if (nums[i] != 0)
        {
            nums[writeIndex] = nums[i];
            writeIndex++;
        }

        i++;
    }

    for (int j = writeIndex; j <= nums.Length - 1; j++)
    {
        nums[j] = 0;
    }

    return nums;
}