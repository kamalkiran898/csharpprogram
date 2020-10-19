
using System;
namespace practice
{
    public class fun
    {
        private static int nom;

        public static bool chkprime(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        public static int Fibo(int nno)
        {
            int num1 = 0;
            int num2 = 1;

            for (int i = 0; i < nno; i++)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp + num2;
            }
            return num1;
        }
        static bool isArmstrong(int x)
        {
            int temp = x;
            int sum = 0;
            while (x != 0)
            {
                sum = sum + x % 10;
                x = x / 10;
            }

            if (sum == temp)
                return true;
            else
                return false;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("2:fibno 1:prime 3: amstrongnumber");
            int x = Convert.ToInt32(Console.ReadLine());
           
            switch (x)
            {

                case 1:
                    Console.Write("\n\nFunction : To display the n number Fibonacci series :\n");
                    Console.Write("Input number of Fibonacci Series : ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("The Fibonacci series of " + n + " numbers is :");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(Fibo(i) + "  ");
                    }
                    Console.WriteLine();
                    break;
                case 2:
                    Console.Write("\n\nFunction : To check a number is prime or not :\n");
                    Console.Write("Input a number : ");
                    int no = Convert.ToInt32(Console.ReadLine());

                    if (chkprime(no))
                        Console.WriteLine(no + " is a prime number");
                    else
                        Console.WriteLine(no + " is not a prime number");
                    break;
                case 3:
                    Console.WriteLine("Enter the maximum limit for searching");
                    int max = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= max; i++)
                    {
                        if (isArmstrong(i))
                            Console.WriteLine(i);
                    }
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
    }
}