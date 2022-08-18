using System;

class Programm
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        string numb = Console.ReadLine();
        int numbConv = Convert.ToInt32(numb);
        int[] array = new int[numb.Length];
        int j = 0;

        for (int i = 0; i < numb.Length; i++)
        {
            int figure = numbConv % 10;
            numbConv = numbConv / 10;
            array[j] = figure;
            j++;
        }

        int sum = 0;

        for (int i = 0; i < j; i++)
        {
            sum = sum + array[i];
        }

        Console.WriteLine(sum);
    }
}

