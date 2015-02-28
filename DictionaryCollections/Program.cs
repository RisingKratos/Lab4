using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Collections.Specialized;

namespace Lab4Exercise3
{
    public class Program
    {
        public static string Check(string ourNumber)
        {
            Hashtable lookup = new Hashtable();

            lookup["0"] = "Zero";
            lookup["1"] = "One";
            lookup["2"] = "Two";
            lookup["3"] = "Three";
            lookup["4"] = "Four";
            lookup["5"] = "Five";
            lookup["6"] = "Six";
            lookup["7"] = "Seven";
            lookup["8"] = "Eight";
            lookup["9"] = "Nine";
            int k = 0;
            foreach (char c in ourNumber)
            {
                string digit = c.ToString();
                if (lookup.ContainsKey(digit))
                {
                    k++;
                    Console.WriteLine(lookup[digit]);
                }
            }
            if (k == ourNumber.Count())
            {
                return "All input symbols are numbers";
            }
            return "Not all input symbols are numbers";
        }

        static void Main(string[] args)
        {
            string ourNumber = Console.ReadLine();
            Console.WriteLine(Check(ourNumber));
        }
    }
}