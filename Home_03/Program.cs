/* Задача 3: Задайте произвольный массив. Выведете 
его элементы, начиная с конца. Использовать 
рекурсию, не использовать циклы.
[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 */

using System.Runtime.InteropServices;

namespace Home_03
{
    public static class Program
    {
        public static void Main(string[] arg)
        {
            System.Console.WriteLine("введите размер массива:");
            int size = Convert.ToInt32(System.Console.ReadLine());
            int[] array = OneArray(size);
            System.Console.WriteLine("исходный массив:");
            System.Console.WriteLine(Print(array));
            System.Console.WriteLine("обратный/перевернутый массив:");
            array = ReversArray(array, array.Length - 1);
            System.Console.WriteLine(Print(array));

        }
        public static int[] OneArray(int size)
        {
            int[] arr = new int[size];
            Random rand = new();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(1, 9);
            }
            return arr;
        }
        public static string Print(int[] array)
        {
            string result = string.Join(", ", array);
            return result;
        }

        public static int[] ReversArray(int[] array, int index)
        {
            if (index < array.Length / 2)
            {
                return array;
            }
            else
            {
                int temp = array[index];
                array[index] = array[array.Length - index - 1];
                array[array.Length - index - 1] = temp;
                return ReversArray(array, index -= 1);
            }
        }
    }
}

