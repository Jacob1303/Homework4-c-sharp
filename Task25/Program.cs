using System;

class Programm
{
    static int Exponent(int a, int b)
    {
        int expo = 1;

        for (int i = 0; i < b; i++)
        {
            expo = expo * a;
        }
        return expo;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите 2 положительных целых числа");
        Console.Write("Первое число - ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Второе число - ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Первое число возведённое в степень второго числа = " + Exponent(num1, num2));
    }
}