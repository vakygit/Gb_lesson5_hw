using System;
using System.Globalization;
public static class Program
{
    public static void Main(string[] args)
    {
        int[,] TwoDimArray = CreateTwoDimArray(5, 5, 0, 50);
        Print(TwoDimArray);
        Flop(TwoDimArray);
        System.Console.WriteLine();
        Print(TwoDimArray);
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
    public static int[,] Flop(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        int temp = 0;
        for (int j = 0; j < cols; j++)
        {
            temp = array[0, j];
            array[0, j] = array[rows - 1, j];
            array[rows - 1, j] = temp;
        }
        return array;
    }
}

