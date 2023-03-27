using System;
using System.Diagnostics;
using System.Threading;

namespace OpgaveSamling_Op1
{
    class Program
    {
        static void Main(string[] args)
        {
            // frimkaller metoden
            Console.WriteLine(SimpleRecursion(5));

            // Fibonacci tal methode
            Console.WriteLine(Fibonacci(40));

            // 2 til 20 og 2 til 40
            PlusetalMedSigSelv();
        }


        /// <summary>
        /// dette program grår igennem Recrusoin og  gøre langsomt n minderer og minder men giver tilbage -1 udanset hvad
        /// fordi at if dellen ikke returner n. men bare et flat -1. og der for er helle metoden lige gylditig
        /// </summary>
        /// <param name="n"></param>
        /// <returns>-1</returns>
        static int SimpleRecursion(int n)
        {
            if (n == 0)  // Base case         
                return -1; 
            else        // Recursive case 
                return SimpleRecursion(n - 1);
        }

        static int Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            
        }

        /// <summary>
        /// so it takes 1 millisecond to figger out the fiboncci on 20 
        /// and it takes 2 seconds and somverer to 312 from to 215. and thata is a tremendes difrins ind time
        /// </summary>
        static void PlusetalMedSigSelv()
        {
            Stopwatch ClockTime = new Stopwatch();

            // udskriver 
            Console.WriteLine();
            ClockTime = Stopwatch.StartNew();
            for (int i = 2; i <= 20; i+= 2)
            {
                Console.WriteLine(Fibonacci(i));
            }
            ClockTime.Stop();

            TimeSpan timeItTok = ClockTime.Elapsed;

            Console.WriteLine($"this is the time it tok minuts:{timeItTok.Minutes} Seconds:{timeItTok.Seconds} Milliseconds:{timeItTok.Milliseconds}");
        }
    }
}
