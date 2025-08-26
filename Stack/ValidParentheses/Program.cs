/*
یک رشته شامل کاراکترهای (، )، {، }، [ و ] داده شده.
باید بررسی کنی که پرانتزها صحیح جفت شده‌اند یا نه.
 */

/*
[{}] => این رشته قابل قبول است
*/

Console.WriteLine(ValidParantheses("({})"));
Console.ReadLine();

static bool ValidParantheses(string str)
{
    var arrChars = str.ToCharArray();
    Stack<char> stack = new Stack<char>();

    for (int i = 0; i < arrChars.Length; i++)
    {
        if (arrChars[i] == '(' || arrChars[i] == '{' || arrChars[i] == '[')
        {
            stack.Push(arrChars[i]);
        }
        else
        {
            if (stack.Count == 0)
            {
                return false;
            }
            var popChar = stack.Pop();

            switch (popChar)
            {
                case '(':
                    if (arrChars[i] != ')')
                        return false;
                    break;

                case '{':
                    if (arrChars[i] != '}')
                        return false;
                    break;

                case '[':
                    if (arrChars[i] != ']')
                        return false;
                    break;
            }
        }
    }
    return stack.Count == 0;
}