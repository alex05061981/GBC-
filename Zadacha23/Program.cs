// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int num = ReadInt("Введите число N: ");

for (int i = 1; i <= num; i++)
{ 
    Console.Write($"{i*i*i} ");
}

int ReadInt(string number)
{
    Console.Write(number);
    return Convert.ToInt32(Console.ReadLine());
}