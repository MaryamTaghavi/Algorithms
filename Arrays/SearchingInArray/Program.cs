// Leetcode : https://leetcode.com/explore/learn/card/fun-with-arrays/527/searching-for-items-in-an-array/3250/

// Linear Search => This technique for finding an element by checking through all elements one by one is known as the linear search algorithm.

// Edge Cases به معنی در نظر گرفتن حالت های خاص میشه مثلا آرایه ورودی نال باشه یا المان مورد نظر اصلا در آرایه وجود نداشته باشد.

// Binary Search => آرایه مرتب باشد و ما در وسط به دنبال المان مورد نظر میگردیم.

// HashSet  سرعت بسیار بالاتری نسبت به آرایه دارد و جستجو در آن بسیار سریعتر است

/*

Given an array arr of integers, check if there exist two indices i and j such that :
    i != j
    0 <= i, j < arr.length
    arr[i] == 2 * arr[j]

 */

var result = CheckIfExist([0, 2, 7, 8, 5, 6]);
Console.WriteLine(result);
Console.ReadLine();

bool CheckIfExist(int[] arr)
{
    var seen = new HashSet<int>();

    for (int i = 0; i < arr.Length; i++)
    {
        if(seen.Contains(2 * arr[i]) || (seen.Contains(arr[i] / 2) && arr[i] % 2 == 0))
        {
            return true;
        }

        seen.Add(arr[i]);
    }

    return false;
}
