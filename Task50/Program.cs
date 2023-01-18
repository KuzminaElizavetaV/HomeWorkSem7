/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
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
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

bool SearchArrayIndex(int[,] arr, int IndexRow, int IndexCol)
{
    if ((0 <= IndexRow && IndexRow < arr.GetLength(0)) && (0 <= IndexCol && IndexCol < arr.GetLength(1)))
        return true;
    else
        return false;
}
Console.WriteLine();
Console.WriteLine("Сформируем двумерный массив:");
Console.Write("    количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("    количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] myArray = SetArray(row, col, 1, 1000);
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine("Введите координаты для поиска элемента:");
Console.Write("    номер строки = ");
int m = Convert.ToInt32(Console.ReadLine()) - 1; //маленкая хитрость для пользователя, так как мы привыкли начинать счет от единицы,
Console.Write("    номер столбца = ");           //а в масиве индексация начинается с нуля  
int n = Convert.ToInt32(Console.ReadLine()) - 1; //аналогично для позиции номера столбца
Console.WriteLine();
if (SearchArrayIndex(myArray, m, n))
    Console.WriteLine(myArray[m, n]);
else
    Console.WriteLine("Такого элемента в массиве нет");
Console.WriteLine();
    