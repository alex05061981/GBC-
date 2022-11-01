﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int MakeArray(int num1, int num2)
{
int result = 0;
    if (num2 < 3)
    {
        Console.Write("Третьей цифры нет, держи: ");
    }
    else
    {
        int num3 = 1;
        for (int i = num2; i > 3; i--)
        {
            num3 = num3 * 10;
        }

        result = (num1 / num3) % 10;
    }
return result;
}