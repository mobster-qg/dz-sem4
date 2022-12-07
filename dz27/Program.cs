//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12
Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"сумма = {GetMultiply(num)}");


int GetMultiply(int number)
{
    int result = 0;
    for (int i = 0; i <= number; i++)
    {
        result = i % 10 +i / 10 % 10 + i / 100;
       
    }
    return result;
}