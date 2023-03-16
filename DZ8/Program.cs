/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/



/*void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 21);
}


void SortArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int b = 0; b < array.GetLength(1) - 1; b++)
            {
                if (array[i, b] < array[i, b + 1])
                {
                    int temp = array[i, b + 1];
                    array[i, b + 1] = array[i, b];
                    array[i, b] = temp;
                }

            }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
}


Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);*/


/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

/*void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 21);
}


void SumMinArray(int[,] array)
{
    int minN = 0;
    int sumMinN = 0;
    int sumN = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        minN += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sumN += array[i, j];
       
            if (sumN < minN)
            {
                minN = sumN;
                sumMinN = i;
            }
            sumN = 0;
    }
    Console.Write($"{sumMinN + 1} строка, сумма {minN}");
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
}


Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
SumMinArray(array);*/



