// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



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

void GetResult(int[,] matr)
{
    double result;
    double sum;

    for (int j = 0; j < matr.GetLength(1); j++)
    {
        result = 0;
        sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            result = result + matr[i, j];
            sum = Math.Round((result / matr.GetLength(0)), 1);
        }
        System.Console.Write(sum + "\t");
    }

}

int[,] matrix = GenerateMatrix(2, 4);
PrintMatrix(matrix);
System.Console.WriteLine("Среднее арифметическое элементов в каждом столбце: ");
GetResult(matrix);