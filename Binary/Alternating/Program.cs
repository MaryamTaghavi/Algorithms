/* LeetCode : https://leetcode.com/problems/minimum-number-of-flips-to-make-the-binary-string-alternating/description/
 */

// هدف ساختن رشته 010101 یا 101010 است
// Minimum Flips to Make a Binary String Alternating


/* برای جابجایی کرکتر اول به آخر باید از الگوریتم
sliding window استفاده کنیم
دو رشته را بهم میچسبانیم و بر اساس طول رشته اصلی یکی یکی میایم جلو و با الگوی اصلی که 0101 یا 1010 مقایسه میکنیم
*/
var result = MinFlips("11010");
Console.WriteLine(result);
Console.ReadLine();

int MinFlips(string s)
{
    int n = s.Length;
    int diff1 = 0; // برای "0101..."
    int diff2 = 0; // برای "1010..."
    var minOps = int.MaxValue;
    // Sliding Window
    var sliding = s + s;

    for (int i = 0; i < sliding.Length; i++)
    {
        // حالت 0101...
        if (sliding[i] != (i % 2 == 0 ? '0' : '1'))
            diff1++;

        // حالت 1010...
        if (sliding[i] != (i % 2 == 0 ? '1' : '0'))
            diff2++;

        if (i >= n)
        {
            int j = i - n;
            char oldExpected1 = (j % 2 == 0) ? '0' : '1';
            char oldExpected2 = (j % 2 == 0) ? '1' : '0';

            if (sliding[j] != oldExpected1) diff1--;
            if (sliding[j] != oldExpected2) diff2--;
        }

        if (i >= n - 1)
        {
            minOps = Math.Min(minOps, Math.Min(diff1, diff2));
        }
    }



    return minOps;
}