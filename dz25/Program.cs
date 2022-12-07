//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.Clear();
Console.WriteLine("Введите число: A");
int numbera =int.Parse( Console.ReadLine());
Console.WriteLine("Введите число: B");
int numberb = int.Parse( Console.ReadLine());

int degree(int numbera, int numberb)
{
    int result = numbera;

    for (int i = 2; i <= numberb; i++)
    {
        result = result * numbera ;
       
    }
    return result;
}
Console.WriteLine(degree(numbera, numberb));