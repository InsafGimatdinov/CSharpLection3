using System;
public class Example4
{
    public static void Main()
    {
        int[] arr = { 5, 4, 52, 5, 6, 7, 3, 1, 4, 5 };
        void PrintArray(int[] array)
        {
            int count = array.Length;
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minPos = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minPos])
                    {
                        minPos = j;
                    }
                }
                int temp = array[i];
                array[i] = array[minPos];
                array[minPos] = temp;
            }
        }
        PrintArray(arr);
        SelectionSort(arr);
        PrintArray(arr);
    }
}