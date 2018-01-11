using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms_Assignment_1
{
    class DataStructures
    {
        private int legth; 
        private int first;
        private int last;

        private List<int> listOFInt = new List<int>();
        public List<int> ListOfInt()
        {
            return listOFInt.ToList();
        }

        public void addElements(int N)
        {
            listOFInt.Add(N);
        }

        public int countLength()
        {
            legth = listOFInt.Count;
            if (listOFInt != null)
            {
                return legth;
            }
            else
            {
                return 0;
            }
        }

        private int firstElment()
        {
            first = listOFInt.ElementAt(0);
            if (listOFInt != null)
            {
                return first;
            }
            else
            {
                return 0;
            }
        }

        private int lastElement()
        {
            last = listOFInt.ElementAt(2);
            if (listOFInt != null)
            {
                return last;
            }
            else
            {
                return 0;
            }
        }
        
        public int getElement(int index)
        {
            index = listOFInt.ElementAt(index);

            if (listOFInt != null)
            {
                return index;
            }
            else
            {
                return 0;
            }
        }

        public void removeIndex(int index)
        {
            if (listOFInt != null)
            {
                listOFInt.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public void removeFirst(int first)
        {
            if (listOFInt != null)
            {
                listOFInt.RemoveAt(first);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public void removeLast(int last)
        {
            if (listOFInt != null)
            {
                listOFInt.RemoveAt(last);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public int getFirst()
        {
            return firstElment();
        }

        public int getLast()
        {
            return lastElement();
        }

        public void sort()
        {
            try
            {
                listOFInt = listOFInt.OrderBy(q => q).ToList();
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        public int getMaxElement()
        {
            return getLast();
        }

        public int getMinElement()
        {
            return getFirst();
        }
    }
}
