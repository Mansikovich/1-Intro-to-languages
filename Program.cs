﻿using System;

namespace ConsoleApp
{
class Program
{
static void Main(string[] args)
{

 /*
 //Задача 2   
 
 int a, b;
 Console.Write("Введите a: ");
 a = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите b: ");
 b = Convert.ToInt32(Console.ReadLine());

 if (a>b)
{
Console.WriteLine ("max: " + a);
}
else
{
   Console.WriteLine ("max: " + b );
}

*/
 
 /*
//Задача 4
 int a, b, c;
 Console.Write("Введите a: ");
 a = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите b: ");
 b = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите c: ");
 c = Convert.ToInt32(Console.ReadLine());
 

int max = a;

if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.WriteLine("Максимальное значение: " + max);
*/

/*
// Задача 6
 int a ;
 Console.Write("Введите число: ");
 a = Convert.ToInt32(Console.ReadLine());
 
if (a % 2 == 0 )
{
    Console.WriteLine("да");
}
else 
{
Console.WriteLine ("нет");

}
*/


//Задача 8
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int x = 1;
for(int i = 0; i < n; i++)
{
    if (x % 2 == 0)
    {
        Console.WriteLine(x);
    }
    x++;
}
    
}
}
}