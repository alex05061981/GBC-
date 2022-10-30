// Напишите программу, которая на вход принимает число(N), а на выходе показывает все четные числа от 1 до N
{

    Console.Write("Введите число : ");
    int num = Convert.ToInt32(Console.ReadLine());
    while(num>2)
    {
        if (num%2==0)
        {
            Console.Write(num + ", ");
        }
       num--;
    }
    if(num==2)
    {
        Console.Write(num);
    }
    else
    {
        Console.Write("Нет четных чисел");
    }
}
