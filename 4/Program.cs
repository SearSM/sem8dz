// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintTripleMassive(int[,,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            for (int k = 0; k < massive.GetLength(2); k++)
            {
                Console.Write($"{massive[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine("");
    }
}

int[,,] MakeTripleMassive(int rows, int columns, int sizeData)
{
    int[] arrayTemp = new int[rows * columns * sizeData];
    for (int i = 0; i < arrayTemp.Length; i++)
    {
        arrayTemp[i] = new Random().Next(10, 98 + 1);
        int numTemp = arrayTemp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (arrayTemp[i] == arrayTemp[j])
                {
                    arrayTemp[i] = new Random().Next(10, 98 + 1);
                    j = 0;
                    numTemp = arrayTemp[i];
                }
                numTemp = arrayTemp[i];
            }
        }
    }
    int[,,] massive = new int[rows, columns, sizeData];
    int l = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < sizeData; k++)
            {
                massive[i, j, k] = arrayTemp[l];
                l++;
            }
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
int sizeData = GetInfo("Введите размерность данных: ");
int[,,] massive = MakeTripleMassive(rows, columns, sizeData);
Console.WriteLine("");
PrintTripleMassive(massive);