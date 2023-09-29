/*Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.*/

Console.WriteLine("input wheek day");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 6)
    Console.WriteLine("Yes");

if (day > 5)
    Console.WriteLine("No");


