// رشته ورودی خودش و برعکسش مساوی باشد 010 اکی است ولی 0101 قابل قبول نیست

var result = Palindrome("10100101");
Console.WriteLine(result);
Console.ReadLine();

bool Palindrome(string s)
{
    bool result = true ;
    var n = s.Length ;

    for (int i = 0; i < n / 2; i++)
    {
        if (s[i] != s[n - 1 - i])
        {
            result = false;
        }
    }
    return result;
}




