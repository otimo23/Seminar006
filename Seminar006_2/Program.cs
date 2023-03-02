/*Задача 40:**Напишите программу, 
которая принимает на вход три числа и проверяет, может ли 
существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника:
каждая сторона треугольника меньше суммы двух других сторон.*/

Console.Clear();
Console.Write("Введите стороны треугольника через пробел: ");

string[] st = Console.ReadLine().Split(' ');
int a = int.Parse(st[0]);
int b = int.Parse(st[1]);
int c = int.Parse(st[2]);

if(IsTriangle(a,b,c))
{
    Console.WriteLine("Yes");
}
else{
    Console.WriteLine("No");
}

bool IsTriangle(int a, int b, int c){
    return (((a + b) > c) && ((a + c) > b) && ((b + c) > a));
}










/*Console.WriteLine("Enter 3 triangle sides: ");
Console.Write("Side 1: ");
double a = double.Parse(Console.ReadLine ()!);
Console.Write("Side 2: ");
double b = double.Parse(Console.ReadLine ()!);
Console.Write("osnov: ");
double c = double.Parse(Console.ReadLine ()!);

if(a+b > c)  //|| b+c > a || c+a > b
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}*/