using System;
using System.Globalization;
public static class Program
{
    public static void Main(string[] args)
    {
        int[,] TwoDimArray = CreateTwoDimArray(3, 5, 1, 50);
        Print(TwoDimArray);
        System.Console.WriteLine(FindMinimum(TwoDimArray));
    }
    public static int[,] CreateTwoDimArray(int rows, int cols, int min, int max)
    {
        int[,] TwoDimArray = new int[rows, cols];
        Random rand = new();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                TwoDimArray[i, j] = rand.Next(min, max + 1);
            }
        }
        return TwoDimArray;
    }
    public static void Print(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                System.Console.Write(array[i, j] + "\t");
            }
            System.Console.WriteLine();
        }
    }
    public static int FindMinimum(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        int min = 2147483647;
        int sum = 0;
        int index = 0;
        int[] numbers = new int[cols];
        for (int i = 0; i < rows; i++)
        {
            sum = 0;
            for (int j = 0; j < cols; j++)
            {
                sum = sum + array[i, j];
            }
            if (sum < min)
            {
                min = sum;
                index = i;
            }
        }
        Console.WriteLine("Строка c минимальной суммой - " + index);
        for (int j = 0; j < cols; j++)
        {
            numbers[j] = array[index, j];
            Console.Write(numbers[j] + "\t");
        }
        Console.WriteLine();
        return sum;
    }
}

