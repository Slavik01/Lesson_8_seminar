// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int minSum = int.MaxValue;
int numberLine = 0;

int [,] matrix = GetArray(rows,columns);
PrintArray(matrix);
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i,j];
    }
    if (sum < minSum)
    {
        minSum = sum;
        numberLine++;
    }
Console.WriteLine($"Сумма элементов равна: {sum}");
}
Console.WriteLine($"В строчке {numberLine} минимальныя сумма равна: {minSum}");

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)     
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0,11);
        }
    }
    return array;
}
void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i,j] + "\t"); 
        }
        Console.WriteLine();
    }
}
