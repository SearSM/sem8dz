// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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
    int number = 1;
    int i = 0;
    int j = 0;
    while (number <= massive.GetLength(0) * massive.GetLength(1))
    {
        massive[i, j] = number;
        number++;
        if (i <= j + 1 && i + j < massive.GetLength(1) - 1) j++;
        else if (i < j && i + j >= massive.GetLength(0) - 1) i++;
        else if (i >= j && i + j > massive.GetLength(1) - 1) j--;
        else i--;
    }
    return massive;
}

int num = 4;
int[,] massive = MakeDoubleMassive(num, num);
Console.WriteLine("");
PrintDoubleMassive(massive);