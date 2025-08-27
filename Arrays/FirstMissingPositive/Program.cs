/*
Return the smallest positive integer that is not present
[2,-3,4,1,1,7] => 3
عدد مثبت یعنی بزرگتر از صفر
in-place
اجازه گرفتن فضای اضافی نیست
کوچکترین عدد مثبت که گم شده، همیشه بین 1 و n+1 است، که n طول آرایه است.
اگر آرایه [1..n] تمام اعداد ۱ تا n را داشت، جواب n+1 است.
اگر نه، اولین عددی که وجود ندارد همان جواب است.
 */

var result = SmallestNum([-3, 4, 1, 2]);
Console.WriteLine(result);
Console.ReadLine();

static int SmallestNum(int[] arr)
{
    var n = arr.Length;

    for (int i = 0; i < n; i++)
    {
        // اول اینجا را if گذاشته بودم ولی اگر if باشد
        // ممکنه عددی که swap شده جای ایندکس آیم هم در جایگاه درستی نباشد
        // بنابراین while میذاریم تا انقدر جابجا کند که در جای درستی قرار بگیرد
        // این شرط برای آن است که اگر ایندکسی قبلا ویزیت شده و تغییرات روش اعمال شده دیگه توی شرط قرار نگیره
        // arr[arr[i]-1] != arr[i]
        while (arr[i] > 0 && arr[i] <= n && arr[arr[i]-1] != arr[i])
        {
            var currectIndex = arr[i] - 1;
            (arr[i], arr[currectIndex]) = (arr[currectIndex], arr[i]);
        }
    }

    for (int i = 0; i < n ; i++)
    {
        if(arr[i] -1 != i)
        {
            return i + 1;
        }
    }

    return n + 1;
}