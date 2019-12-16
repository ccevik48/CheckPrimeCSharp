using System;

namespace checkPrime
{
    class Program
    {
        public static bool isPrime(int number)
        {
            bool flag = true;
            int i = 2;
            while(i <= Math.Ceiling(Math.Sqrt(number)) )
            {
                if( number % i == 0)
                {
                    flag = false;
                    break;
                }
                else
                {
                    i++;
                }
            }
            return flag;
        }
        
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            // the code that you want to measure comes here
            Console.WriteLine(isPrime(1234577));
            watch.Stop();
            
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);
            
        }
    }
}
