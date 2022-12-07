//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] array = mass(8);
Console.WriteLine($"[{String.Join(",", array)}]");


int[] mass(int size)
{
    int[] result = new int  [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(7);
    }

    return result;
}