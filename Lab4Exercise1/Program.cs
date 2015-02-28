using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace BasicCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            myList.Add("First");
            myList.Add("Second");
            myList.Add("Third");
            myList.Add("Fourth");

            foreach (string item in myList)
            {
                Console.WriteLine("Unsorted: {0}", item);
            }

            // Sort using the standard comparer
            myList.Sort();

            foreach (string item in myList)
            {
                Console.WriteLine(" Sorted: {0}", item);
            }
        }
    }
}
