using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    //Q1:############################################################################
    internal class Q1
    {
        static void Main(string[] args)
        {
            int[] transactions = { 200, -150, 340, 500, -100 };
            int total = 0;
            for (int i = 0; i < transactions.Length; i++)
            {
                total = total + transactions[i];
            }
            Console.WriteLine("Total transactions: " + total);
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }

    //Q2:############################################################################
    internal class Q2
    {
        static void Main(string[] args)
        {
            float[] scores = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
            float total = 0;
            foreach (float score in scores)
            {
                total = total + score;
            }
            float avg = total / scores.Length;
            Console.WriteLine("My average scores: " + avg);
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }

    //Q3:############################################################################
    internal class Q3
    {
        static void Main(string[] args)
        {
            int[] prices = { 1500, 2300, 999, 3200, 1750 };
            int biggest = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > biggest)
                {
                    biggest = prices[i];
                }
            }
            Console.WriteLine("Biggest number: " + biggest);
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }

    //Q4:############################################################################
    internal class Q4
    {
        static void Main(string[] args)
        {
            int[] participantCodes = { 102, 215, 324, 453, 536 };
            int even = 0;
            int odd = 0;
            foreach (int num in participantCodes)
            {
                if (num % 2 == 0)
                {
                    even = even + 1;
                }
                else
                {
                    odd = odd + 1;
                }
            }
            Console.WriteLine("Even numbers: " + even);
            Console.WriteLine("Odd numbers: " + odd);
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }

    //Q5:############################################################################
    internal class Q5
    {
        static void Main(string[] args)
        {
            int[] searchHistory = { 101, 202, 303, 404, 505 };
            Console.WriteLine("Backwards numbers:");
            for (int i = searchHistory.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(searchHistory[i]);
            }
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }

    //Q6:############################################################################
    internal class Q6
    {
        static void Main(string[] args)
        {
            int[] measurements = { 2, 4, 6, 8 };
            int factor = 3;

            Console.WriteLine("After multiplying:");
            for (int i = 0; i < measurements.Length; i++)
            {
                measurements[i] = measurements[i] * factor;
                Console.WriteLine(measurements[i]);
            }
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }

    //Q7:############################################################################
    internal class Q7
    {
        static void Main(string[] args)
        {
            int[] bookCodes = { 101, 203, 304, 405, 506 };
            int searchCode = 304;
            int pos = -1;
            for (int i = 0; i < bookCodes.Length; i++)
            {
                if (bookCodes[i] == searchCode)
                {
                    pos = i;
                    break;
                }
            }
            if (pos != -1)
            {
                Console.WriteLine("got it at: " + pos);
            }
            else
            {
                Console.WriteLine("not there");
            }
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }

    //Q8:############################################################################
    internal class Q8
    {
        static void Main(string[] args)
        {
            int[] grades = { 56, 78, 89, 45, 67 };
            Array.Sort(grades);
            int second = grades[1];
            Console.WriteLine("second smallest: " + second);
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }

    //Q9:############################################################################
    internal class Q9
    {
        static void Main(string[] args)
        {
            int[] ids = { 102, 215, 102, 324, 215 };
            HashSet<int> noDuplicates = new HashSet<int>();
            foreach (int n in ids)
            {
                if (n < 0)
                {
                    Console.WriteLine("Negative number found: " + n);
                    return;
                }
            }
            {
                noDuplicates.Add(n);
            }
            foreach (int n in noDuplicates)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }

    //Q10:############################################################################
    internal class Q10
    {
        static void Main(string[] args)
        {
            int[] dataset1 = { 1, 2, 3, 4, 5 };
            int[] dataset2 = { 3, 4, 5, 6, 7 };

            Console.WriteLine("Same numbers:");
            for (int i = 0; i < dataset1.Length; i++)
            {
                for (int j = 0; j < dataset2.Length; j++)
                {
                    if (dataset1[i] == dataset2[j])
                    {
                        Console.WriteLine(dataset1[i]);
                    }
                }
            }
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }
}
