using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolution
{
    class Program
    {
        static void Main(string[] args)
        {

            // AddMultiple3or5();
            // SumEvenFibonacciNumbers();
            //  var MaxPrimeFactor = GetMaxPrimeFactorNumber().Max();
            // Console.WriteLine(MaxPrimeFactor);
            //foreach(var item in ListPrimeFactor)
            //{
            //    Console.WriteLine(item);
            //}

            //  LargestPalindromeProductoftwo3digits();
            //  Console.ReadLine();
            SumSquareDifference();

        }

        public static void AddMultiple3or5()
        {
            try
            {
                List<int> Multiple3or5 = new List<int>();
                for (int i = 1; i < 1000; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        // sum = sum + i;
                        Multiple3or5.Add(i);
                    }


                }

                int sum = Multiple3or5.Sum();
                Console.WriteLine(sum);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void SumEvenFibonacciNumbers()
        {
            int sum = 0;
            int fibo = 0;
            int firstNumber = 0;
            int SecondNumber = 1;

            try
            {
                for (int i = 2; i < 4000000; i++)
                {
                    fibo = firstNumber + SecondNumber;
                    firstNumber = SecondNumber;
                    SecondNumber = fibo;
                    if (fibo % 2 == 0)
                    {
                        sum = sum + fibo;
                        if (sum >= 4000000)
                        {
                            break;
                        }
                    }

                }

                Console.WriteLine(sum);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static IEnumerable<int> GetMaxPrimeFactorNumber()
        {
            List<int> PrimeFactor = new List<int>();
            Console.WriteLine("Enter the number for factorial");
            double fact = Convert.ToDouble(Console.ReadLine());
            try
            {

                for (int i = 2; i <= fact; i++)
                {
                    while (fact % i == 0)
                    {

                        PrimeFactor.Add(i);
                        fact = fact / i;
                    }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return PrimeFactor;
        }

        public static void LargestPalindromeProductoftwo3digits()
        {
            int max = 0;
            int firstDigit = 0;
            int secondDigit = 0;

            try
            {

                for (int i = 999; i >= 100; i--)
                {
                    for (int j = 999; j >= 100; j--)
                    {
                        int palinNum = i * j;
                        if (IsPalindrome(Convert.ToString(palinNum)))
                        {
                            if (palinNum > max)
                            {
                                max = palinNum;
                                firstDigit = i;
                                secondDigit = j;

                            }


                        }

                    }
                }

                Console.WriteLine(max);
                Console.WriteLine(firstDigit);
                Console.WriteLine(secondDigit);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public static bool IsPalindrome(string number)
        {
            try
            {
                char[] c = number.ToCharArray();
                Array.Reverse(c);

                string s = new string(c);
                if (number == s) return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return false;
        }

        public static void SumSquareDifference()
        {
            try
            {
                int sum = 0;
                double SumOfSquare = 0, SquareOfSum = 0;
                for (int i = 1; i <= 100; i++)
                {
                    SumOfSquare = SumOfSquare + Math.Pow(i, 2);
                    sum = sum + i;
                }
                SquareOfSum = Math.Pow(sum, 2);
                double diff = SquareOfSum - SumOfSquare;
                Console.Write(diff);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
