// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()); // null - ссылка в пустоту
// Console.Write("Введите количество столбцы массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// /// summary - описание метода
// /// m на n: m - кол-во строк, n - кол-во столбцов
// /// minValue , maxValue
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++)     // Строчки. m = matrix.GetLength(0)
//     {
//         for (int j = 0; j < n; j++) // n = matrix.GetLength(1)
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] inputArray)
// {
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//         {
//             Console.Write(inputArray[i,j] + "\t"); 
//             // 1    2    3    4
//         }
//         Console.WriteLine();
//     }
// }

// int [,] array = GetArray(rows,columns,0,10);// 0, 10 можно задать с консоли minValue maxValue (прописать их там)
// PrintArray(array);

// //////////////////////////////////
// int minNumber = int.MaxValue;
// System.Console.WriteLine(minNumber);

// int indexRow = 0;
// int indexCol = 0;

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (minNumber > array[i, j])
//         {
//             minNumber = array[i, j];
//             indexRow = i;
//             indexCol = j;
//         }
//     }
// }
// System.Console.WriteLine(minNumber + "\t");

// void PrintArray45(int[,] inputArray)
// {
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         if (i == indexRow) continue;
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//         {
//             if (j == indexCol) continue;
//             Console.Write(inputArray[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// PrintArray45 (array);


// ////РАЗНИЦА В КОДЕ с 27 и 41 строчкой, и 28 и 42 строчкой, и 30 и 44 строчкой - НО ОДНО И ТО ЖЕ

// // int[,] GetArray(int m, int n, int minValue, int maxValue)
// // {
// //     int[,] matrix = new int[m, n];
// //     for (int i = 0; i < m; i++)     // Строчки. m = matrix.GetLength(0)
// //     {
// //         for (int j = 0; j < n; j++) // n = matrix.GetLength(1)
// //         {
// //             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
// //         }
// //     }
// //     return matrix;
// // }


// // int[,] GetArray(int m, int n, int minValue, int maxValue)
// // {
// //     int[,] matrix = new int[3, 4];
// //     for (int i = 0; i < matrix.GetLength(0); i++) 
// //     {
// //         for (int j = 0; j < matrix.GetLength(1); j++) 
// //         {
// //             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
// //         }
// //     }
// //     return matrix;
// // }

Console.Write("Введите размерность 1: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность 2: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность 3: ");
int z = Convert.ToInt32(Console.ReadLine());



int IndexMarix(int[] array, int value)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int J = 0; j < array.GetLength(1); J++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if(array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}



int [,,] matrix = new int [x, y, z];  

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            matrix[i,j,k] = new Random().Next(100);
            Console.WriteLine(matrix[i,j,k]);
            int result = IndexMarix(matrix[i,j,k]);
        }
    }       
}

int [,,] printMatrix = new int [x, y, z];  

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            Console.Write(matrix[i,j,k] + "\t"); 
            
        } 
        Console.WriteLine();
    }  
}

