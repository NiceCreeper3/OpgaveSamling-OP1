using System;
using System.Collections.Generic;

namespace Binær_søgning_OP4._2._3
{
    class Program
    {
        //values
        static int TheNummberTheUserWants;
        static bool ProgramIsRunning = true;

        static List<int> SomsortOfArrey = new List<int>() { 4, 6, 8, 9, 9, 10, 12, 15, 16, 19 };


        /// <summary>
        /// make a program to sort this nummbes
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // udskriver "Array"
            foreach (int n in SomsortOfArrey)
            {
                Console.Write(n + ", ");
            }



            FindNummberIndArray();
            try
            {
                while (ProgramIsRunning)
                {
                    // USer masseg
                    Console.WriteLine(
                        "(1) Find nummber ind ''Array''" +
                        "(2) inset a new nummber into the ''Array''" +
                        "(0) Exit ");
                    int WhatTheUserWants = int.Parse(Console.ReadLine());

                    switch (WhatTheUserWants)
                    {
                        case 1:
                            // Askes youser to rite nummber
                            Console.WriteLine("\n Write a nummber and we wil teal you where it is in the array");
                            TheNummberTheUserWants = int.Parse(Console.ReadLine());

                            FindNummberIndArray();
                            break;
                        case 2:
                            Console.WriteLine("\n Write a nummber and we wil Put it ind the Array");
                            TheNummberTheUserWants = int.Parse(Console.ReadLine());

                            AddNumberToArray();
                            break;
                        case 0:
                            ProgramIsRunning = false;
                            break;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Somthing went rong and");

            }

        }
/*
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
*/

        //Finds nummber ind "Array" 
        #region
        static void FindNummberIndArray()
        {
            bool TriningToFindNummber = true;
            int low = 0;
            int Hight = SomsortOfArrey.Count - 1;

            
            // get det middel of a array
            while (TriningToFindNummber==true)
            {
                // gets the hafe waje nummber of Hight and Low
                int mid = low + ((Hight - low) / 2);

                if (SomsortOfArrey[mid] == TheNummberTheUserWants)
                {
                    Console.WriteLine("you nummber: " + SomsortOfArrey[mid] + " is ind Colume: " + mid);
                    TriningToFindNummber = false;

                }
                else if (low >= Hight) // Makes sure if the nummber is not ind the program. that it stopes the reapite.
                {
                    Console.WriteLine("this nummber is not in the Array");
                    TriningToFindNummber = false;
                }
                // sørger vi gøre en fram ad fordi vi alledet har teastet det gammle 
                else if (SomsortOfArrey[mid] < TheNummberTheUserWants)
                    low = mid + 1;
                else
                    Hight = mid - 1;
            }
        }
        #endregion

        // adds a nummber to the 
        #region
        static void AddNumberToArray()
        {
            for(int i = 0; i <= SomsortOfArrey.Count; i++)
            {

            }


            foreach(int n in SomsortOfArrey)
            {
                Console.Write(n + ", ");
            }
        }
        #endregion
    }
}
