// Урок 2. Условные операторы, циклы, массивы, строки, StringBuilder
using System;
class Program
{
    static void Main(string[] args)
    {
        int[,] arr = { { 7, 3, 2, 10 },
                       { 4, 9, 6, 11 },
                       { 1, 8, 5, 12 } };

        Console.WriteLine("Исходный массив:");
        Show2DArray(arr);

        Sort2DArray(arr);

        Console.WriteLine("Массив после сортировки:");
        Show2DArray(arr);
    }

    
    static void Sort2DArray(int[,] arr)
    {
        // Так как массивы передаются по ссылке, возвращать значение не нужно. 
        // Работаем непосредственно с переданным массивом.

        List<int> list = [.. arr]; // считываем все содержимое массива в список

        list.Sort(); // Сортируем по порядку.

        // записываем по порядку содержимое списка в массив
        int count = 0;        
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = list[count++];
            }
        }
    }

    static void Show2DArray(int[,] arr) // Вывод двумерного массива на консоль
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