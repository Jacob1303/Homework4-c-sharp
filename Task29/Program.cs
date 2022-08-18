using System;

class Programm
{

    static void Main(string[] args)
    {
        Console.Write("ВВедите предполагаемое количество используемых чисел - ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[] array = new double[n];

        Console.WriteLine("Введите поочередно числа");

        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}