//Задача 19
//Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
using static System.Console;
Clear();
WriteLine("Введите пятизначное число");
int n=Convert.ToInt32(ReadLine());

if ((n>0 && (n>100000 || n<10000)) || (n<0 && (n<-100000 || n>-10000)) || n==0)
{
   WriteLine("Введенное число не является пятизначным");
   return;
}

int a=n%100;
int b=n/1000;
int b1=b/10;
int b2=b%10;
int c=b2*10+b1;

if (a==c)
{
    WriteLine($"Число {n} является палиндромом");
}
else
{
    WriteLine($"Число {n} не является палиндромом");
}


