// // Задача 54: Задайте двумерный массив. Напишите программу, 
// // которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 1 2 4 7
// // 2 3 5 9
// // 2 4 4 8

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцы массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = GetArray(rows,columns);
Console.WriteLine("Массив до изменения: ");
PrintArray(matrix);
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int z = 0; z < matrix.GetLength(1) -1 -i; z++)
        {
        if (matrix[i, z] > matrix[i, z + 1]) ////для изменения сортировки поменять знак
        {
        int temp = matrix[i, z + 1];
        matrix[i, z + 1] = matrix[i, z];
        matrix[i, z] = temp;
        } 
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями: ");
PrintArray(matrix);
int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)     
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(11);
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
