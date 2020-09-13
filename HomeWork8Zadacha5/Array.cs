using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork8Zadacha5
{
    class Array
    {
        int n = 0;
        int[] mas;


        public Array(int n)
        {

            mas = new int[n];
        }
        public void Filing()
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"введите элемент массива под индексом {i}:\t");
                mas[i] = Num();
            }
        }
        public void ShowMas()
        {
            foreach (int element in mas)
            {
                Console.Write(element + "\t");
            }
        }
        public void SortMas()
        {
            int temp = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] < mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;

                    }
                }
            }
            foreach (int element in mas)
            {
                Console.Write(element + "\t");
            }
        }
        public string VolMas
        {
            get
            {
                return $"размерность массива составляет{mas.Length} ";
            }
        }
        public int Skalyar
        {
            set
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] *= value;
                }
            }
        }
        static int Num()
        {
            for (; ; )
            {
                if (int.TryParse(Console.ReadLine(), out int a))
                    return a;
                else
                    Console.Write("введите коректные данные:\t");
            }
        }
    }
}
