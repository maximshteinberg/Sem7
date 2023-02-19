// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            System.Console.Write(mat[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int GetPosition(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintPosition(int rows, int cols, int[,] matrix)
{
    if (rows >= matrix.GetLength(0) || cols >= matrix.GetLength(1))
    {
        System.Console.WriteLine("Такой позиции нет в массиве. ");
    }
    else System.Console.WriteLine($"Значение элемента на позиции [{rows},{cols}] = {matrix[rows, cols]}");
}

int[,] matrix = GenerateMatrix(3, 3);

int r = GetPosition("Введите номер строки: ");
int c = GetPosition("Введите номер столбца: ");
System.Console.WriteLine();

PrintMatrix(matrix);
System.Console.WriteLine();

PrintPosition(r,c,matrix);



