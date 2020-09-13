using System;

namespace HomeWork8Zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите количесто элементов массива:\t");
            int n = num();
            Array mas = new Array(n);

            mas.Filing();
            Console.WriteLine("элементы массива");
            mas.ShowMas();
            Console.WriteLine();
            Console.WriteLine("отсортированные элементы массива");
            mas.SortMas();
            Console.WriteLine();
            Console.WriteLine(mas.VolMas);
            mas.Skalyar = 2;
            Console.WriteLine("элементы массива умноженные на скаляр");
            mas.ShowMas();

        }
        static int num()
        {
            for (; ; )
            {
                if (int.TryParse(Console.ReadLine(), out int a) && a > 0)
                    return a;
                else
                    Console.Write("введите коректные данные:\t");
            }
        }

    }
}
