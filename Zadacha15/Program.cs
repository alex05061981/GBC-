// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число дня недели от 1 до 7: ");
int num = int.Parse(Console.ReadLine());

if ((num > 7) || (num < 1))
{
    Console.WriteLine("Неверный день недели");
    return;
}
if (num > 5)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}