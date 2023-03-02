//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵) 
//2, 4 -> 16


/*int Stepen(int num, int st)
{
    int result = 1;
    for(int i = 0; i < st; i++)
{
    result *= num;
    Console.WriteLine(Stepen(num, st));
}
return result;
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int st = Convert.ToInt32(Console.ReadLine());
double n = Math.Pow(num, st);
Console.Write($"{num}, {st} -> {n}");*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

/*Console.WriteLine("введите число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}

Console.Write($"Сумма цифр в числе равна: {sum}");*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

/*void PrintMass (int[] arr)

{
    Random rnd = new Random();
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(0, 99);
    Console.Write($"{arr[i]}, ");
  }
}
int[] arr = new int[8];

PrintMass(arr);*/

//Задача 27. - HARD необязательная Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
//452 -> 3
//82 -> 2
//9,012 ->4

int Kolvo(int num)

{
    int count = 0;
    for (int i = 0; i != num; count++)
        num /= 10;

    return count;
}
try
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Количество чисел в числе - {Kolvo(number)}");

}
catch
{
    Console.WriteLine("Введены неккоректные данные!");
}


