/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

456 -> 5
782 -> 8
918 -> 1*/

/*Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int num2=num;
int count=0;
int res = 0;
while (num2 >= 100)
{
    count++;
    num2 = num2 / 10;
}

res = num2 % 10;
Console.WriteLine($"{num} -> {res % 10}");
        
        {
            res = num2%10;
        num2=num2/10;
    Console.WriteLine("Вторая цифра, " + res);
         }
*/



/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

/*Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int num2=num;
int count=0;
int res = 0;
while (num > 0)
{
    count++;
    num = num / 10;
}
if (count < 3)
Console.WriteLine($"{num2} -> третьей цифры нет");
else
{
for(int k = 0; k < 3; k++)
{
    count -= 1;
    int j = 0, b = 1, a = 10, n = count;
    while (j != n)
    {
        j++;
        b = b*a;
    }
res = num2 / b;
}
Console.WriteLine($"{num2} ->{res % 10}");
}    */ 

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите цифру дня недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void CheckingDayOfWeek (int dayNumder)
{
if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine($"{dayNumber} -> да (выходной)");
}
else if (dayNumber < 1 || dayNumber > 7)
Console.WriteLine("эта цифра не является днем недели");
else 
Console.WriteLine($"{dayNumber} -> нет (не выходной)");
}
CheckingDayOfWeek(dayNumber);
