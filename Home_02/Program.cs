/* Задача 2: Напишите программу вычисления функции 
Аккермана с помощью рекурсии. Даны два 
неотрицательных числа m и n. 
m = 2, n = 3 -> A(m,n) = 29 */


namespace Home_02
{
    public static class Program
    {
        public static void Main(string[] arg)
        {
            System.Console.WriteLine("введите число m:");
            int m = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("введите число n:");
            int n = Convert.ToInt32(System.Console.ReadLine());

            int resultAkkerman = FunctionAkkerman(m, n);
            System.Console.WriteLine($"A({m},{n}) = {resultAkkerman}");
        }

        public static int FunctionAkkerman(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else
            {
                if (n == 0)
                    return FunctionAkkerman(m - 1, 1);
                else
                    return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));

            }
        }

    }
}


