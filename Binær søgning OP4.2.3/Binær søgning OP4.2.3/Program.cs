using System;
using System.Collections.Generic;

namespace Binær_søgning_OP4._2._3
{
    class Program
    {
        //values
        #region
        static int TheNummberTheUserWants;
        static bool ProgramIsRunning = true;

        static List<int> SomsortOfArrey = new List<int>() { 4, 6, 8, 9, 9, 10, 12, 15, 16, 19 };
        #endregion

        /// <summary>
        /// make a program to sort this nummbes
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            while (ProgramIsRunning)
            {
                try
                {
                    Console.WriteLine();
                    foreach (int n in SomsortOfArrey)
                    {
                        Console.Write(n + ", ");
                    }

                    // User masseg
                    Console.WriteLine(
                        "\n(1) Find nummber ind ''Array''" +
                        "\n(2) inset a new nummber into the ''Array''" +
                        "\n(0) Exit ");
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
                catch
                {
                    Console.WriteLine("Somthing went rong and");

                }
            }
        }

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
            //Values i need for the Sorting
            bool TriningToFindNummber = true;
            int low = 0;
            int Hight = SomsortOfArrey.Count - 1;
            int mid = 0;

            // get det middel of a array
            while (TriningToFindNummber == true)
            {
                // gets the hafe waje nummber of Hight and Low
                mid = low + ((Hight - low) / 2);

                if (SomsortOfArrey[mid] == TheNummberTheUserWants)// stopes the conunt if it favnede the nummber bekase if the nummber allede 
                    TriningToFindNummber = false;
                else if (low >= Hight) 
                {
                    // Makes sure if it kant finde a nummber higher or lower. it stopes the counting. this leves mid as ithere 0 or (SomsortOfArrey.Count)
                    TriningToFindNummber = false;

                    //makes it so if the unmmuber is higer then all the otheres
                    //dat it gets put ind a new line ind the "Array"
                    if (SomsortOfArrey[mid] < TheNummberTheUserWants)
                        mid += 1;
                }

                // søgger at (mid) enten gøre en fram eller en tilbage. fordi vi alldrede har 
                else if (SomsortOfArrey[mid] < TheNummberTheUserWants) 
                    low = mid + 1;
                else
                    Hight = mid - 1;
            }

            // inserts the nummber to the "Array"
            SomsortOfArrey.Insert(mid, TheNummberTheUserWants);
        }
        #endregion
    }
}
