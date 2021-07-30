using System;

namespace quickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next() % 100;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].ToString() + " ");
            }
            QuickSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].ToString() + " ");
            }
        }
        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        //метод возвращающий индекс опорного элемента
        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        //быстрая сортировка
        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }
    }
}
