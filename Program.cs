// Урок 2. Условные операторы, циклы, массивы, строки, StringBuilder
using System;
class Program
{
    static void Main(string[] args)
    {
        int[,] arr = { { 7, 3, 2 },
                       { 4, 9, 6 },
                       { 1, 8, 5 } };

        List<int> nums = GetList(arr);
        
        nums.Sort();

        WriteToArray(arr, nums);

        ShowArray(arr);
    }

    static List<int> GetList(int[,] array)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                list.Add(array[i, j]);
            }
        }
        return list;
    }
    static int[,] WriteToArray(int[,] arr, List<int> list)
    {        
        int count = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = list[count++];
            }
        }
        return arr;
    }

    static void ShowArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}