/*Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.*/


Console.WriteLine("input number");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)
{
    string str = num.ToString();
    Console.WriteLine(str[2]);
}
if (num<99)
{
    Console.WriteLine("no third");
}
