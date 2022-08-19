using System;

class Programm
{
    static (int[] array, int j) BreakIntoNums(string numbText)
    {
        int numbConv = Convert.ToInt32(numbText);
        int[] array = new int[numbText.Length];
        int j = 0;

        for (int i = 0; i < numbText.Length; i++)
        {
            int figure = numbConv % 10;
            numbConv = numbConv / 10;
            array[j] = figure;
            j++;
        }
        return (array, j);
    }

    static int SumNums(int[] arrayNum, int j)
    {
        int sum = 0;
        for (int i = 0; i < j; i++)
        {
            sum = sum + arrayNum[i];
        }
        return sum;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        string numb = Console.ReadLine();
        (int[] array, int j) = BreakIntoNums(numb);
        Console.WriteLine(SumNums(array, j));
    }
}

