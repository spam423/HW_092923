/*Напишите программу, которая: 
1. принимает на вход трёхзначное число  
2. на выходе показывает вторую цифру этого числа.
456 -> 5*/



Console.WriteLine("input number");
int num = Convert.ToInt32(Console.ReadLine());

int FirstNumber(int number)
{
    int firstNum = number / 1000;
    int lastNum = number % 100;
    return firstNum * 10 + lastNum / 10;
}

int res = FirstNumber(num);

Console.WriteLine(res);
