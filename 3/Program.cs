// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] MakeNewMassiveProiz(int[,] massive1, int[,] massive2)
{
    int[,] newMassive = new int[massive1.GetLength(0), massive1.GetLength(1)];
    for (int i = 0; i < newMassive.GetLength(0); i++)
    {
        for (int j = 0; j < newMassive.GetLength(1); j++)
        {
            int result = 0;
            for (int k = 0; k < newMassive.GetLength(1); k++)
            {
                result += massive1[i, k] * massive2[k, j]; // massive[0,0] * massive[0,0] + massive[0, 1] * massive[1, 0]
            }
            newMassive[i, j] = result;
        }
    }
    return newMassive;
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

int rows1 = GetInfo("Введите количество строк 1 матрицы: ");
int columns1 = GetInfo("Введите количество столбцов 1 матрицы: ");
int rows2 = GetInfo("Введите количество строк 2 матрицы: ");
int columns2 = GetInfo("Введите количество столбцов 2 матрицы: ");
int[,] massive1 = MakeDoubleMassive(rows1, columns1);
int[,] massive2 = MakeDoubleMassive(rows2, columns2);
Console.WriteLine("");
Console.WriteLine("Даны 2 матрицы: ");
PrintDoubleMassive(massive1);
Console.WriteLine("");
PrintDoubleMassive(massive2);
Console.WriteLine("");
Console.WriteLine("Результирующая матрица: ");
int[,] newMassive = MakeNewMassiveProiz(massive1, massive2);
PrintDoubleMassive(newMassive);