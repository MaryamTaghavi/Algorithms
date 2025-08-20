/* LeetCode : https://leetcode.com/problems/minimum-number-of-flips-to-make-the-binary-string-alternating/description/
 */

// هدف ساختن رشته 010101 یا 101010 است
// Minimum Flips to Make a Binary String Alternating

var result = MinFlips("1110");
Console.WriteLine(result);
Console.ReadLine();

int MinFlips(string s)
{
    var num = 0;

    if (s.Length == 0)
    {
        return num;
    }

    if (s[0] != s[s.Length - 1])
    {
        var firstChar = s[0];
        s = s.Remove(0, 1);
        s += firstChar;
    }

    char[] chars = s.ToCharArray();

    for (int i = 1; i < chars.Length - 2; i++)
    {
        if (chars[i] != chars[i + 1] && chars[i - 1] != chars[i])
        {
            continue;
        }

        if (chars[i] == '0')
        {
            chars[i + 1] = chars[i - 1] = '1';
            num++;
        }
        else
        {
            chars[i + 1] = chars[i - 1] = '0';
            num++;
        }
    }

    string str = string.Concat(chars);
    return num;
}