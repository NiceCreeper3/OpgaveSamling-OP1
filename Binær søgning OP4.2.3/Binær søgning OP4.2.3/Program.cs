using System;
using System.Collections.Generic;

namespace Binær_søgning_OP4._2._3
{
    class Program
    {
        //values
        static int TheNummberTheUserWants;

        // arrey med random nummrer
        static List<int> SomsortOfArrey = new List<int>(){ 7, 6, 8, 17, 9, 10, 0, 15, 8, 19 };


        /// <summary>
        /// make a program to sort this nummbes
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            // sortes aver array
            SortArray();

            foreach (int n in SomsortOfArrey)
            {
                Console.WriteLine(n);
            }


            try
            {
                TheNummberTheUserWants = int.Parse(Console.ReadLine());

                FindNummberIndArray();
            }
            catch
            {
                Console.WriteLine("Somthing went rong and");

            }

        }

        static void SortArray()
        {
            for(int ListNummber = 0; ListNummber <= SomsortOfArrey.Count; ListNummber++)
            {
                for (int ListNummberInfront = 1; ListNummberInfront <= SomsortOfArrey.Count; ListNummberInfront++)
                {
                    // cheacs if det nummber in front is bigger
                    if(SomsortOfArrey[ListNummber] > SomsortOfArrey[ListNummberInfront])
                    {
                        // if the nummber ind front is samaller it gets put bak one space
                        SomsortOfArrey.RemoveAt(ListNummberInfront);
                        SomsortOfArrey.Insert(ListNummberInfront -1, SomsortOfArrey[ListNummberInfront]);
                    }

                    foreach(int i in SomsortOfArrey)
                    {
                        Console.WriteLine(i + " " + ListNummberInfront);
                    }
                }
            }
        }


        //the program 
        #region
        static void FindNummberIndArray()
        {
            // get det middel of a array
            int mid = SomsortOfArrey[SomsortOfArrey.Count / 2];

            while (true)
            {
                if (mid == TheNummberTheUserWants)
                {
                    Console.WriteLine(SomsortOfArrey[mid]);
                    break;
                }
                else if (TheNummberTheUserWants < mid)
                {
                    mid /= 2;
                }
                else
                {
                    mid *= 2;
                }
            }
        }
        #endregion
    }
}
