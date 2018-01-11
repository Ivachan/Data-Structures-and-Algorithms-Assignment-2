using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataStructures listOfNumbers()
            {
                DataStructures myDATAlist = new DataStructures();
                myDATAlist.addElements(4);
                myDATAlist.addElements(19);
                myDATAlist.addElements(89);
                myDATAlist.addElements(44);
                myDATAlist.addElements(25);
                myDATAlist.addElements(32);
                return myDATAlist;
            }

            Console.WriteLine(new string('^', 25));
            Console.WriteLine("List of numbers: ");
            DataStructures list = listOfNumbers();
            foreach (int d in list.ListOfInt())
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();

            Console.WriteLine(new string('^', 25));
            Console.WriteLine("Remove first element: ");
            list.removeFirst(0);
            foreach (int f in list.ListOfInt())
            {
                Console.WriteLine(f);
            }
            Console.WriteLine();

            Console.WriteLine(new string('^', 25));
            Console.WriteLine("Remove last element: ");
            list.removeLast(4);
            foreach (int l in list.ListOfInt())
            {
                Console.WriteLine(l);
            }
            Console.WriteLine();

            Console.WriteLine(new string('^', 25));
            Console.WriteLine("Remove some element: ");
            list.removeIndex(2);
            foreach (int i in list.ListOfInt())
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine(new string('^', 25));
            Console.WriteLine("First element: " + list.getFirst());
            Console.WriteLine();
            Console.WriteLine("Last element: " + list.getLast());
            Console.WriteLine();

            Console.WriteLine(new string('^', 25));
            Console.WriteLine("Sorted list:");
            list.sort();
            foreach (int o in list.ListOfInt())
            {
                Console.WriteLine(o);
            }
            Console.WriteLine();

            Console.WriteLine(new string('^', 25));
            Console.WriteLine("Max element: " + list.getMaxElement());
            Console.WriteLine();
            Console.WriteLine("Min element: " + list.getMinElement());
            Console.WriteLine();

            Console.WriteLine(new string('^', 25));
            Console.WriteLine("Numbers in list: " + list.countLength());
            Console.WriteLine();
        }
    }
}
    

