// LeetCode : https://leetcode.com/problems/sort-an-array/description/ => Array

// In-Place حل میشود در بهترین حالت که آرایه مرتب است O(n)
// و در بدترین حالت O(n2)

//int[] array = new int[5] {1,5,3,2,9};
//int[] array = new int[0];

int[] array = new int[5] { 9, 8, 3, 2, 9 };

var result = InsertionSortList(array);
Console.WriteLine(result);

int[] InsertionSortList(int[] head)
{
    for(int i = 1; i < head.Length ; i++)
    {
        int key = head[i];
        int j = i - 1;

        while(j >= 0 && head[j] > key)
        {
            head[j+1] = head[j];
            j--;
        }
        
        head[j+1] = key ;
    }

    return head;
}