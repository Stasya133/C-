/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

/*Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
	Console.WriteLine(a + "max");
else
	Console.WriteLine(b + "max");
if (a < b)
	Console.WriteLine(a + "min");
else
	Console.WriteLine(b + "min");*/



/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

/*Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("max = ");
Console.WriteLine(max);*/


/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

/*Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine(num + " - Четное число");
}
else
{
    Console.WriteLine(num + " - Нечетное число");
}*/


/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

/*Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
    if (i % 2 == 0)
Console.Write(i + " ");*/


/*Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
456111 -> 5
78 -> 8
9146548 -> 1
3 -> нет*/

/*Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int num2=num;
int count=0;
while (num > 0)
{
    count++;
    num = num / 10;
}

Console.WriteLine($"Разрядность введенного числа {count}");
int res= num2;
for (int i=1;i<=count;i++)
    {
        if (i!=count-0)
            res = num2%10;
        num2=num2/10;

    }

Console.WriteLine(res); */



/*Пробовала дополнительо решение*/
/*Console.WriteLine($"Разрядность введенного числа {count}");
int res= num2; 
int i=1;
while (i<=count && num<10)
       i++;  
    {
        if (i!=count-0)
         {
            res = num2%10;
        num2=num2/10;
    Console.WriteLine(res);
         }
else
Console.WriteLine("{0} второй цифры нет ", num);
 
    }*/


