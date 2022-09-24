// Задача 23
//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
using static System.Console;
Clear();
WriteLine("Введите число ");
int n=Convert.ToInt32(ReadLine());
int count=1;
int result=0;

while (count<n  | count==n)
{
    result=count*count;
    Write($" {result} ; ");
    count=count+1;
}