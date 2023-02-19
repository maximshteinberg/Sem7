// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMatrix(int rows, int cols)
// {
//     Random rand = new Random();
//     int[,] matrix = new int[rows, cols];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(0, 21);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i,j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int rows = ReadInt("Введите количество строк матрицы: ");
// int cols = ReadInt("Введите количество столбцов матрицы: ");
// System.Console.WriteLine();
// var myMatrix = GenerateMatrix(rows, cols);
// PrintMatrix(myMatrix);

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// Андрей 20:19
// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMatrix(int rows, int cols)
// {
//     Random rand = new Random();
//     int[,] matrix = new int[rows, cols];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(2, 4);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {

//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }
// void PrintMatrix2(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j % 2 == 0 && i % 2 == 0)
//             {
//                 matrix[i, j] = matrix[i, j] * matrix[i, j];
        
//             System.Console.Write(matrix[i, j] + "\t");
//             }
// else
// {
//   System.Console.Write(matrix[i, j] + "\t");
// }
//             // System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int rows = ReadInt("Введите количество строк матрицы: ");
// int cols = ReadInt("Введите количество столбцов матрицы: ");
// System.Console.WriteLine();
// var myMatrix = GenerateMatrix(rows, cols);
// PrintMatrix(myMatrix);  
// System.Console.WriteLine();
// PrintMatrix2(myMatrix);



// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMatrix(int rows, int cols)
// {
//     Random rand = new Random();
//     int[,] matrix = new int[rows, cols];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(2, 4);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {

//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }
// void PrintMatrix2(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j % 2 == 0 && i % 2 == 0)
//             {
//                 matrix[i, j] = matrix[i, j] * matrix[i, j];
        
//             System.Console.Write(matrix[i, j] + "\t");
//             }
// else
// {
//   System.Console.Write(matrix[i, j] + "\t");
// }
//             // System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int rows = ReadInt("Введите количество строк матрицы: ");
// int cols = ReadInt("Введите количество столбцов матрицы: ");
// System.Console.WriteLine();
// var myMatrix = GenerateMatrix(rows, cols);
// PrintMatrix(myMatrix);  
// System.Console.WriteLine();
// PrintMatrix2(myMatrix);





// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
//
//  (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMatrix(int rows, int cols)
// {
//     Random rand = new Random();
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(0, 10);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// // int SumElements(int[,] matrix)
// // {
// //     int SumElements = 0;
// //     for (int i = 0; i < matrix.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < matrix.GetLength(1); j++)
// //         {
// //             if (i == j)
// //             {
// //                 SumElements += matrix[i, j];
// //             }
// //         }
// //     }
// //     return SumElements;
// // }

// int SumElements(int[,] matrix)
// {
//     int SumElements = 0;
//     int length = (matrix.GetLength(0) > matrix.GetLength(1)) ? matrix.GetLength(1) : matrix.GetLength(0);

//     // if (matrix.GetLength(0) > matrix.GetLength(1))
//     //     length = matrix.GetLength(1);
//     // else length = matrix.GetLength(0);
//     for (int i = 0; i < length; i++)
//     {
//         SumElements += matrix[i, i];
//     }
//     return SumElements;
// }

// int rows = ReadInt("Введите количество строк матрицы: ");
// int cols = ReadInt("Введите количество столбцов матрицы: ");

// var myMatrix = GenerateMatrix(rows, cols);
// PrintMatrix(myMatrix);
// System.Console.WriteLine(SumElements(myMatrix));