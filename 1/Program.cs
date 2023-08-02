// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void SortDoubleMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            for (int k = 0; k < massive.GetLength(1) - 1; k++)
            {
                if (massive[i, k] < massive[i, k + 1])
                {
                    int temp = massive[i, k + 1];
                    massive[i, k + 1] = massive[i, k];
                    massive[i, k] = temp;
                }
            }
        }
    }
}

void PrintDoubleMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine("");
    }
}

int[,] MakeDoubleMassive(int rows, int columns)
{
    int[,] massive = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            massive[i, j] = new Random().Next(1, 9 + 1);
        }
    }
    return massive;
}

int GetInfo(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInfo("Введите количество строк: ");
int columns = GetInfo("Введите количество столбцов: ");
int[,] massive = MakeDoubleMassive(rows, columns);
Console.WriteLine("");
PrintDoubleMassive(massive);
Console.WriteLine("В итоге получается вот такой массив: ");
SortDoubleMassive(massive);
PrintDoubleMassive(massive);
Console.WriteLine("");