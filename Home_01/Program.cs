/* Задача 1: Задайте значения M и N. Напишите 
программу, которая выведет все натуральные числа 
в промежутке от M до N. Использовать рекурсию, не 
использовать циклы.
M = 1; N = 5 -> "1, 2, 3, 4, 5" 
M = 4; N = 8 -> "4, 5, 6, 7, 8" */

namespace Home_01
{
    public static class Program
    {
        public static void Main(string[] arg)
        {
            System.Console.WriteLine("введите число М:");
            int num1 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("введите число N:");
            int num2 = Convert.ToInt32(System.Console.ReadLine());
            string numbers = AllNumbers(num1, num2);
            System.Console.WriteLine($"M = {num1}; N = {num2} => {numbers}");

        }
        public static string AllNumbers(int num1, int num2)
        {
            if (num1 > num2)
            {
                return "";
            }
            else
            {
                if (num1 == num2)
                {
                    return $"{num1} ";
                }
                else
                {
                    return $"{num1}, " + AllNumbers(num1 + 1, num2);
                }
            }
        }
    }

}

