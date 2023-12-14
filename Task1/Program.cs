using System;
public static class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Gbljhfgrmgwimfowjemfv");
        /*int[,] TwoDimArray = CreateTwoDimArray(3, 3, 0, 50);
        Print(TwoDimArray);
        /*Console.WriteLine("Введите строку");
        string input = Console.ReadLine();
        string input2 = Console.ReadLine();
        int rw = Convert.ToInt32(input);
        Console.WriteLine("Введите столбец");
        int cl = Convert.ToInt32(input2);*/
        //Console.WriteLine(SrchElement(TwoDimArray, 1, 1));
    }
    /*public static int[,] CreateTwoDimArray(int rows, int cols, int min, int max)
    {
        int[,] TwoDimArray = new int[rows, cols];
        Random rand = new();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                TwoDimArray[i, j] = rand.Next(min, max + 1);
            }
        }
        return TwoDimArray;
    }
    /*    public static int SrchElement(int[,] array, int a, int b)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            if (a > rows || b > cols)
            {
                Console.WriteLine("[STOP]");
                return 0;
            }
            else
            {
                return array[a, b];
            }
    }*/
    /*public static void Print(int[,] array)
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
    }*/
}
