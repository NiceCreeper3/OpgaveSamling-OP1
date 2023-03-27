using System;

namespace OpgaveSamling_Op1
{
    class Program
    {
        static void Main(string[] args)
        {
            // frimkaller metoden
            Console.WriteLine(SimpleRecursion(5));
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

    }
}
