/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] SetArray(int row, int col, int beginNum, int endNum)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(beginNum, endNum + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
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

double[] AvgColumnArray(int[,] arr)
{
    double[] AverageArr = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sumCol = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sumCol += arr[i, j];
        }
        AverageArr[j] = Math.Round(sumCol / arr.GetLength(0), 1);
    }
    return AverageArr;
}
Console.WriteLine();
Console.WriteLine("Формируем двумерный массив:");
Console.Write(" -количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write(" -количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] myArray = SetArray(row, col, 1, 9);
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", AvgColumnArray(myArray))}.");
Console.WriteLine();
