// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
{
   int num1, num2;
   Console.WriteLine("Введите два числа: ");
   num1 = Convert.ToInt32(Console.ReadLine());
   num2 = Convert.ToInt32(Console.ReadLine());
   if (num1>num2)
   {
       Console.WriteLine("{0} наибольшее число", num1);
   }
   else
   {
       Console.WriteLine("{0} наибольшее число", num2);
   }
   Console.ReadLine();
}