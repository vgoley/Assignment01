﻿/*Vikanksha Goley
 *Assignment 01
 */ 
using System;
using System.Collections;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 5;
            //Each iteration prints one row in the pattern.
            for (int i = n1; i >= 1; i--)
            {
                PrintPattern(i);
                Console.Write("\n");
            }

            int n2 = 6;
            PrintSeries(n2);

            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine(t);

            int n3 = 110;
            int k = 11;
            UsfNumbers(n3, k);

            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);

            int n4 = 5;
            Stones(n4);
        }
        //Question 1
        private static void PrintPattern(int n)
        {
            try
            {
                if (n > 0)
               //When n=0, control goes out to the main and execute next iteration.
                {
                    Console.Write(n);
                    PrintPattern(n - 1);
                //Recursively called the function to print each element in a row.
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing print Pattern");
            }
        }
        //Question 2
        //
        private static void PrintSeries(int n2) 
        {
            try
            {
                Console.WriteLine("\n");
                int s = 0;
                for (int j1 = 1; j1 <= n2; j1++)
                {
                  //Adds each element in the previous sum to calculate next element of the series.
                    s = s + j1;
                    Console.Write(s);
                    if (j1 != n2) //To  print comma after al ements except the last one.
                        Console.Write(',');
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing print Series");
            }
        }
        //Question 3
        public static string UsfTime(string s)
        {
            try
            {
                Console.WriteLine("\n\n");
                DateTime.TryParse(s, out DateTime dt);
                //Calculate total seconds corresponding to the input time.
                int Sec = ((dt.Hour * 60 * 60) + (dt.Minute * 60) + dt.Second);
                int USFhr = Sec / (60*45); //Calculating Hours in USF time.
                int rem = Sec % (60 * 45); 
                int USFmin = rem / 45;     //Calculating minutes in USF time.
                int USFsec = rem % 45;     //Calculating seconds in USF time.
                return(USFhr + ":" + USFmin + ":" + USFsec); 
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }
        //Question 4
        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                Console.WriteLine("\n");
                for (int i = 1; i <= n3; i++)
                {
                    if (i % 15 == 0) //For checking numbers multiple of both 3 and 5
                        Console.Write("US ");
                    else if (i % 35 == 0) //For checking numbers multiple of both 5 and 7
                        Console.Write("SF ");
                    else if (i % 21 == 0) //For checking numbers multiple of both 3 and 7
                        Console.Write("UF ");
                    else if (i % 3 == 0)  //For checking numbers multiple of only 3
                        Console.Write("U ");
                    else if (i % 5 == 0)  //For checking numbers multiple of only 5
                        Console.Write("S ");
                    else if (i % 7 == 0)  //For checking numbers multiple of only 7
                        Console.Write("F ");
                    else
                        Console.Write(i + " ");

                    if (i % 11 == 0) //To check if 11 numbers have been printed in a line.
                        Console.Write('\n');
                }              
            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }
        //Question 5
        public static void PalindromePairs(string[] words)
        {
            try
            {
                Console.WriteLine("\n");
                for (int i = 0; i < words.Length; i++ )
                {   //Using two loops to concatenate a word with every other word.
                    for (int j = 0; j < words.Length; j++)
                    {
                        if (i != j) //Check so that any word is not concatenated with itself.
                        {
                            string temp = " ";
                            temp = words[i] + words[j];
                            int palin = 1;
                            for (int k = 0; k <= temp.Length / 2; k++) 
                            {
                                if (temp[k] != temp[temp.Length - k - 1])
                                //Comparing letters at same position, one from the beginning and other from end.
                                {
                                    palin = 0; 
                                    break; //When mismatch is found, go out of the loop.
                                }
                            }
                            if (palin == 1) //Means no mismatch found, its a palindrome.
                            {
                                Console.Write("[" + i + "," + j + "]");
                            }
                        }
                        else continue;
                    }
                }
            }
            catch
            {

                Console.WriteLine("Exception occured while computing PalindromePairs()");
            }
        }

        //Question6:
        public static void Stones(int n4)
        {
            try
            {
                Console.WriteLine("\n\n");
                //If the stones are mutiple of 4, first person would never win.
                if (n4 % 4 == 0)
                {
                    Console.WriteLine("False\n");
                }
                else
                {
                    int[] moves = new int[100]; //array to store the moves of each player.
                    int firstchance = (n4 % 4); //player is smart so will pick such that multiple of 4 is left.
                    moves[0] = firstchance;
                    Console.Write("[" + moves[0]);
                    n4 -= firstchance; //Remaining stones.
                    int i;
                    if(n4 > 0)
                    { 
                        for (i = 1; n4 > 3; i++)
                        {   //Eah person will pick three stones 
                            moves[i] = 3;
                            n4 -= 3;
                        }
                        moves[i] = n4;  
                        for (int k = 1; k <= i; k++)
                        {   //Print the moves of each player.
                            Console.Write("," + moves[k]);
                        }
                    }
                    Console.Write("]\n");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }
    }
}
