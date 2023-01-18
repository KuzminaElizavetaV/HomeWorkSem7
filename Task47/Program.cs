/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.*/

double[,] SetArray(int row, int col, int minValue, int maxValue)
{
    double[,] arr = new double[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()), 2);
        }
    return arr;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начальное значение диапазона: ");
int beginNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное значение диапазона: ");
int endNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double[,] myArray = SetArray(row, col, beginNum, endNum);
PrintArray(myArray);
Console.WriteLine();
