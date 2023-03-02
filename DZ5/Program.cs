//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void ThirdArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(99, 999);

}

void PrintArray(int[] array)
{

    foreach (var el in array)
        Console.Write($"{el},");
    Console.Write("]");
}

void ChetArray(int[] array)
{

    int res = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
        {
            res++;
        }

    Console.Write($" -> {res}");

}

int[] array = new int[4];
ThirdArray(array);
PrintArray(array);
ChetArray(array);
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*void FillArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(2, 10);
}

void PrintArray(int[] array)
{
    foreach (var el in array)
        Console.Write($"{el} ");
    Console.Write("]");
}

void FindIndex(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i += 2)
        if (array[i] != 0)
        {
            sum += array[i];

        }
    Console.WriteLine($" Сумма элементов на нечетных позициях равна -> {sum}");

}

int[] array = new int[5];
FillArray(array);
PrintArray(array);
FindIndex(array);*/


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

/*void FillArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 50);
}

void PrintArray(int[] array)
{
    foreach (var el in array)
        Console.Write($"{el} ");

    Console.Write("]");
}

void FindRazr(int[] array)
{
    int sumR = 0;

    for (int i = 0; i < array.Length; i++)
        sumR = array.Max() - array.Min();

    Console.WriteLine($" Разница между максимальным и минимальным элементов массива -> {sumR}");
}

int[] array = new int[5];
FillArray(array);
PrintArray(array);
FindRazr(array);*/

//Задача 30. - HARD необязательная Напишите программу, которая на вход получает размерность массива. Далее заполняет его случайными уникальными числами и выводит на экран. Далее производим сортировку массива от большего к меньшему и выводим на экран. Далее придумываем алгоритм перемешивания списка на основе случайности , применяем этот алгоритм и выводим на экран результат. Встроенные методы работы с массивами использовать нельзя.

/*void FillArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 50);
}

void PrintArray(int[] array)
{
    foreach (var el in array)
        Console.Write($"{el} ");

    Console.WriteLine();
}

void SelectionSort(int[] array)

{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;

        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }

}


void MixArray(int[] array)

{

    for (int j = array.Length - 1; j >= 1; j--)
    {
        int i = new Random().Next(j + 1);

        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}


int[] array = new int[10];
FillArray(array);
PrintArray(array);
SelectionSort(array);
PrintArray(array);
MixArray(array);
PrintArray(array);*/