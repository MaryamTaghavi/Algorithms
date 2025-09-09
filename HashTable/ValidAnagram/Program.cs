// LeetCode : https://leetcode.com/problems/valid-anagram/description/

Console.WriteLine(IsAnagram("rat", "car"));
Console.ReadLine();

bool IsAnagram(string s, string t)
{
    char[] str = s.ToCharArray();
    char[] str1 = t.ToCharArray();

    if (str.Length != str1.Length)
    {
        return false;
    }

    Dictionary<char,int> dic = new Dictionary<char,int>();
    Dictionary<char,int> dic1 = new Dictionary<char,int>();

    for (int i = 0 ; i < str.Length ; i++)
    {
        if (dic.ContainsKey(str[i]))
        {
            dic[str[i]] += 1;
        }
        else
        {
            dic.Add(str[i], 1);
        }
    }

    for (int i = 0; i < str1.Length; i++)
    {
        if (dic1.ContainsKey(str1[i]))
        {
            dic1[str1[i]] += 1;
        }
        else
        {
            dic1.Add(str1[i], 1);
        }
    }

    for (int i = 0; i < str.Length; i++)
    {
        if (!dic1.ContainsKey(str[i]) || dic[str[i]] - dic1[str[i]] != 0)
            return false;
    }

    return true;
}