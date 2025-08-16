/* Given a fixed-length integer array arr, duplicate each occurrence of zero, shifting the remaining elements to the right.
 Note that elements beyond the length of the original array are not written. Do the above modifications to the input array in place and do not return anything. */

/* Input: arr = [1,0,2,3,0,4,5,0]
Output: [1,0,0,2,3,0,0,4]
Explanation: After calling your function, the input array is modified to: [1,0,0,2,3,0,0,4] */

/* Input: arr = [1,2,3]
Output: [1,2,3]
Explanation: After calling your function, the input array is modified to: [1,2,3] */

int[] arr = { 1, 0, 2, 3, 0, 4, 5, 0 };

Solution.DuplicateZeros(arr);

Console.ReadLine();

public static class Solution
{
    public static void DuplicateZeros(int[] arr)
    {
        int[] temporaryArray = new int[arr.Length];
        var temporaryLength = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (temporaryLength == arr.Length)
            {
                break;
            }
            if (arr[i] != 0)
            {
                temporaryArray[temporaryLength] = arr[i];
                temporaryLength++;
            }
            else
            {
                temporaryArray[temporaryLength] = arr[i];
                if(temporaryLength + 1 == arr.Length)
                {
                    break;
                }

                temporaryArray[temporaryLength + 1] = 0;
                temporaryLength = temporaryLength + 2;
            }

        }
        // اگر این جوری آرایه موقت رو بریزیم داخل arr
        // فقط اشاره گر عوض میشود و نه محتوا پس آرایه بیرونی همون مقدار ثابت را دارد 
        // باید با روش پایینی مقادیر را گپی کنیم تا آرایه بیرونی هم مقدار آن عوض شود
        // اگر بخواهیم به روش زیر مقادیر را عوض کنیم باید ورودی را به صورت ref تغییر بدهیم.

        //arr = temporaryArray;

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = temporaryArray[i];
        }
    }
}
