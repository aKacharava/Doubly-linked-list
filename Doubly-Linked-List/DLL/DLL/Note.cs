using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class Note
    {
        // Objects that is a value, a next and previous
        int V;
        Note Next, Prev;

        // Static to know what data structure is Head and Tail
        static Note Head, Tail;
        static int counter;

        // Constructor to use the int in the Note
        Note(int v)
        {
            V = v;
        }

        /// <summary>
        /// Method that creates datastructure and then checks if the previous created data structure needs to be sorted
        /// in the Previous or Next of the next created data structure.
        /// </summary>
        public static void pBLA(int z)
        {
            counter++;
            Note n = new Note(z);

            if (Head == null)
            {
                Head = n;
                Tail = n;
            }
            else
            {
                if (n.V <= Head.V)
                {
                    Head.Prev = n;
                    n.Next = Head;
                    Head = n;
                }
                else
                {
                    if (n.V > Tail.V)
                    {
                        n.Prev = Tail;
                        Tail.Next = n;
                        Tail = n;
                    }
                    else
                    {
                        Note W;
                        W = Head;

                        while (W.V < n.V)
                        { 
                            W = W.Next;
                        }

                        if (W.V > n.V)
                        {
                            n.Prev = W.Prev;
                            W.Prev = n;
                            n.Next = W;
                            n.Prev.Next = n;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Adds numbers to an empty array and returns array with sorted numbers
        /// </summary>
        public static int[] addToArray()
        {
            int[] array = new int[counter];

            Note W = Head;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = W.V;
                W = W.Next;
            }

            return array;
        }
    }
}
