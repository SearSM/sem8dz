// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int FindMinRows(int[,] massive)
{
    int summLine;
    int minRows = 10000;
    int lineIndex = 0;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        summLine = 0;
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            summLine += massive[i, j];
        }
        if (summLine < minRows)
        {
            minRows = summLine;
            lineIndex = i;
        }
    }
    return lineIndex + 1;
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
Console.WriteLine("");
int minLine = FindMinRows(massive);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minLine} строка");