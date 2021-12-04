using System;

namespace lab_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Random random = new Random();

            Console.WriteLine("Source array: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);

                Console.Write(array[i] + " ");
            }
            array.ChangeMinAndMax();
        }
    }
    public static class MyExtension
    {
        public static void ChangeMinAndMax(this int[] arr)
        {
            int min = 0;

            int max = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[min] > arr[i])
                {
                    min = i;
                }
                if (arr[max] < arr[i])
                {
                    max = i;
                }
            }
            int tmp = arr[min];

            arr[min] = arr[max];

            arr[max] = tmp;

            Console.WriteLine("\nModified array: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
