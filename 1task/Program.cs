/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.Clear();

Console.WriteLine("Введите чтсло:");
int a = Convert.ToInt32(Console.ReadLine());
if(a/10000 == a%10 && (a/1000)%10==(a/10)%10)
{
    Console.WriteLine("Палиндром");
}
else
{
Console.WriteLine("не палиндром");
}