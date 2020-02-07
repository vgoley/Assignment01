/*Vikanksha Goley
 *Assignment 01
 */ 
using System;
using System.Collections;

namespace Assignment01
{
    class Program
    {
        public static DateTime MyDateTime { get; private set; }

        static void Main(string[] args)
        {
            int n1 = 5;
            Console.WriteLine("Question1:");
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

            int n4 = 8;
            Stones(n4);
        }
        //Question 1
        private static void PrintPattern(int n)
        {
            try
            {
                if (n > 0)
                {
                    Console.Write(n);
                    PrintPattern(n - 1);
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing print Pattern");
            }
        }
        //Question 2
        private static void PrintSeries(int n2) 
        {
            try
            {
                Console.WriteLine("\nQuestion2:");
                int s = 0;
                for (int j1=1;j1<=n2;j1++)
                {                 
                    s = s + j1;
                    Console.WriteLine(s);
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
                Console.WriteLine("\nQuestion3:");
                DateTime.TryParse(s, out DateTime dt);
                Console.WriteLine("Input Date and Time is: " + dt);
                int Sec = ((dt.Hour * 60 * 60) + (dt.Minute * 60) + dt.Second);
                Console.WriteLine("Total Seconds = " + Sec);
                int USFhr = Sec / (60*45);
                int rem = Sec % (60 * 45);
                int USFmin = rem / 45;
                int USFsec = rem % 45;
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
                Console.WriteLine("\nQuestion4:");
                for (int i = 1; i <= n3; i++)
                {
                    if (i % 15 == 0)
                        Console.Write("US ");
                    else if (i % 35 == 0)
                        Console.Write("SF ");
                    else if (i % 21 == 0)
                        Console.Write("UF ");
                    else if (i % 3 == 0)
                        Console.Write("U ");
                    else if (i % 5 == 0)
                        Console.Write("S ");
                    else if (i % 7 == 0)
                        Console.Write("F ");
                    else
                        Console.Write(i + " ");

                    if (i % 11 == 0)
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
                Console.WriteLine("\nQuestion5:");
                for (int i = 0; i < words.Length; i++ )
                {
                    for (int j = 0; j < words.Length; j++)
                    {
                        if (i != j)
                        {
                            string temp = " ";
                            temp = words[i] + words[j];
                            int palin = 1;
                            for (int k = 0; k <= temp.Length / 2; k++)
                            {
                                if (temp[k] != temp[temp.Length - k - 1])
                                {
                                    palin = 0;
                                    break; 
                                }
                            }
                            if (palin == 1)
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
                Console.WriteLine("\n\nQuestion6:");
                if (n4 % 4 == 0)
                {
                    Console.WriteLine("False\n");
                }
                else
                {
                    int[] moves = new int[100];
                    moves[0] = 1;
                    n4 -= 1;
                    int i;
                    for (i = 1; n4 > 3; i++) 
                    {
                            moves[i] = 3;
                            n4 -= 3;
                    }
                    moves[i] = n4;
                    Console.Write("[" + moves[0]);
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("," + moves[j]);
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
