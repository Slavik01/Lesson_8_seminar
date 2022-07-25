// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.Write("Введите количество строк первого массива: ");
int rowsFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первого массива: ");
int columnsFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк второго массива: ");
int rowsSecondMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второго массива: ");
int columnsSecondMatrix = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Первый массив:");
int [,] matrix = GetArray(rowsFirstMatrix,columnsFirstMatrix);
PrintArray(matrix);
Console.WriteLine("Второй массив: ");
int [,] SecondMatrix = GetArray(rowsSecondMatrix,columnsSecondMatrix);
PrintArray(SecondMatrix);

int [,] compositionMatrix = new int [rowsFirstMatrix, columnsFirstMatrix];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        compositionMatrix[i,j] = matrix[i,j] * SecondMatrix[i,j]; // умножение 1 и 2 матрици 
    }   
}
Console.WriteLine("Произведение матриц: ");
PrintArray(compositionMatrix);

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



