//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3



/*Console.WriteLine("Введите элементы с клавиатуры, через пробел");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    count++;
}
Console.Write ($"{count}");*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


/*Console.WriteLine("Введите b1 и k1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
var k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2 и k2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
var k2 = Convert.ToDouble(Console.ReadLine());
 
 
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");*/


//Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте список чисел НегаФибоначчи, в том числе для отрицательных индексов.

//*Пример:*
//- для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

void Fibon(String[] args)
{
    int num0 = 0;
    int num1 = 1;
    int num2;

    int k = 8;
    for (int i = 0; i <=k; i++)
    {
        
        num2 = num0 + num1;

        Console.Write(num0 + " ");
        num0 = num1;
        num1 = num2;
    }
}   

Fibon(args);




