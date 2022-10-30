// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка)

{
    int num;
    Console.Write("Введите число: ");
    num = Convert.ToInt32(Console.ReadLine());
    if (num % 2 ==0)
    {
        Console.Write("Введенное число является четным");
        Console.Read();
    }
    else
    {
        Console.Write("Введенное число нечетное");
        Console.Read();
    }
}