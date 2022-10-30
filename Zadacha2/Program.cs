// Напишите программу, которая принимет на вход три числа и выдает максимальное из этих чисел
{
   int num1, num2, num3;
   Console.WriteLine("Введите три целочисленных числа: ");
   num1 = Convert.ToInt32(Console.ReadLine());
   num2 = Convert.ToInt32(Console.ReadLine());
   num3 = Convert.ToInt32(Console.ReadLine());
   if (num1>num2)
   {
      if (num1>num3)
      {
         Console.WriteLine("{0} наибольшее число", num1);
      }
      else
      {
         Console.WriteLine("{0} наибольшее число", num3);
      }
    }
    else
    {
      if (num2>num3)
      {    
        Console.WriteLine("{0} наибольшее число", num2);
      }
      else
      {
        Console.WriteLine("{0} наибольшее число", num3);
      }
    }
    Console.ReadLine();
}
