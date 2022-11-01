// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = 0;
int num2 = 0;


if (num > 99 && num < 1000)
{
    num1 = num / 10;
    num2 = num1 % 10;
    System.Console.WriteLine($"{num} -> {num2}");
}
else
{
    System.Console.WriteLine("Число не является трехзначным");
}
