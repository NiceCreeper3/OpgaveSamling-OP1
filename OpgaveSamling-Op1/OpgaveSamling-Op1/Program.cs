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

            // 2 til 20 og 2 til 40
            PlusetalMedSigSelv();

            //TimesFortineTimes();
            
        }

        // 1.1
        #region
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
        #endregion

        // 1.2
        #region
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
            for(int i = 2; i <= 20; i+= 2)
            {
                Console.WriteLine(Fibonacci(i));
            }
            ClockTime.Stop();

            TimeSpan timeItTok = ClockTime.Elapsed;

            Console.WriteLine($"this is the time it tok minuts:{timeItTok.Minutes} Seconds:{timeItTok.Seconds} Milliseconds:{timeItTok.Milliseconds}");
        }

        static int Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        #endregion

        // 1.3
        #region


        /// <summary>
        /// det der skal gøres er at tallet bliver ganged med det nestes rekke nummer så 24 * 5 = 120 
        /// </summary>
        static void TimesFortineTimes()
        {
            for (int i = 0; i <= 14; i++)
            {
                Console.WriteLine($"{i} {TimesNummberWithItSelf(i)}");
            }
        }

        static int TimesNummberWithItSelf(int n)
        {
            if (n >= 14)
                return n;
            else
                return TimesNummberWithItSelf(n * 2);
        }
        #endregion
    }
}
