// LeetCode : https://leetcode.com/problems/evaluate-reverse-polish-notation/description/

var result = EvalRPN(["-78", "-33", "196", "+", "-19", "-", "115", "+", "-", "-99", "/", "-18", "8", 
    "*", "-86", "-", "-", "16", "/", "26", "-14", "-", "-", "47", "-", "101", "-", "163", "*", "143",
    "-", "0", "-", "171", "+", "120", "*", "-60", "+", "156", "/", "173", "/", "-24", "11", "+", "21", 
    "/", "*", "44", "*", "180", "70", "-40", "-", "*", "86", "132", "-84", "+", "*", "-", "38", "/", 
    "/", "21", "28", "/", "+", "83", "/", "-31", "156", "-", "+", "28", "/", "95", "-", "120", "+", 
    "8", "*", "90", "-", "-94", "*", "-73", "/", "-62", "/", "93", "*", "196", "-", "-59", "+", 
    "187", "-", "143", "/", "-79", "-89", "+", "-"]);

Console.WriteLine(result);

Console.ReadLine();

int EvalRPN(string[] tokens)
{
    Stack<int> stack = new Stack<int>();
    var num1 = 0;
    var num2 = 0;

    if (tokens.Count() > 0)
    {
        stack.Push(int.Parse(tokens[0]));
    }

    for (int i = 1; i < tokens.Count(); i++)
    {
        if (int.TryParse(tokens[i], out var value))
        {
            stack.Push(value);
        }

        else
        {
            num1 = stack.Pop();
            num2 = stack.Pop();

            switch (tokens[i])
            {
                case "/":
                    stack.Push(num2 / num1);
                    break;

                case "*":
                    stack.Push(num2 * num1);
                    break;

                case "+":
                    stack.Push(num2 + num1);
                    break;

                case "-":
                    stack.Push(num2 - num1);
                    break;
            }
        }
    }

    return stack.Pop();
}