// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] arr = {2, 4, 6, 8, 10, 12, 14, 16};
void PtintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]},");

    }
    Console.WriteLine();

}
PtintArray(arr);