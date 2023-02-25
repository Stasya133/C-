/*Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
14212 -> нет
12821 -> да
23432 -> да*/



/*Console.WriteLine("Введите пятизначное число:");
int N = Convert.ToInt32(Console.ReadLine());
int temp1 = N;
int num1=N/1000;
string num2="";
if ( (N / 10000 >= 1 && N / 10000 <= 9))
{
for(int i=0; i<2; i++)
{
num2 = num2 + $"{N % 10}";
N = N/10;
}
if (num1==Convert.ToInt32(num2)) Console.WriteLine($"{temp1} - Является палиндромным числом");
else Console.WriteLine($"{temp1} - Не является палиндромным числом");
}
else Console.WriteLine($"{temp1} - Не является пятизначный");*/


/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

/*void Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
  double n = Math.Round (Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2)), 2);

 
  Console.WriteLine($"Расстояние составляет {n}");
}

Console.WriteLine("Введите координату х1, у1 и z1");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату х2, у2 и z2");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

Distance(x1, y1, z1, x2, y2, z2);*/


      

/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

/*Console.WriteLine("Введите натуральное: ");
int x = Convert.ToInt32(Console.ReadLine());
int x1 = x;
string res = $"{x} -> ";
for (int i = 1; i <= x; i++){
    int tmp = i * i * i;
    res += $"{tmp}, ";
}
Console.WriteLine(res);*/


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

void Distance(int x, int y, int z)
{
  double n = Math.Round (Math.Sqrt((x - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2)), 2);

 
  Console.WriteLine($"Расстояние составляет {n}");
}

Console.WriteLine("Введите координату х1, у1 и z1");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату х2, у2 и z2");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

Distance(x1, y1, z1, x2, y2, z2);