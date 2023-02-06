using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment20
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*    Why collections ?
                When we want to manage the objects or elements at run time. We can use collections
                Resize the collections at run time
                By using collection we can manage different elements
                We can manage object or objects at run time.
                Collections can grow & shrink memory at run time


                Non - Generic collections
                When we want to process different type of elements in to a single collection
                Dissimilar type of data can be manage using non generic collections


            */


            // Classes in Non -Generic Collections




            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            ArrayList list = new ArrayList();
            list.Add(10); // implicit boxing
            list.Add("Pune");
            list.Add(4.5);

            list.Insert(0, "Maharashtra");

            list.AddRange(arr1);
            list.Add(100);
            // list.Remove(4.5);
            // list.RemoveRange(1, 3);

            // list.RemoveAt(4);
            list.Clear();
            Console.WriteLine($"total elements {list.Count}");
            Console.WriteLine($"capacity of arraylist {list.Capacity}");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            /*    Stack →
                When we want to store & retrieve using LIFO (last in first out )manner
                Stack of plates,

                Push()--> push / add element in to the stack
                Pop() → remove the last inserted element / the element which is at the top of list will be removed */


            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            // stack.Pop();
            //stack.Pop();
            Console.WriteLine($"top element in the stack {stack.Peek()}");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }







            /*    Queue → 
                When we want to process element in a queue, FIFO (first in first out)


                Enqueue() → add to queue
                Dequeue() → remove the first element from the queue
                Peek() → return the first element in the queue                   */


            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            // queue.Dequeue();
            Console.WriteLine($"total elements {queue.Count}");
            Console.WriteLine($"first element in the queue {queue.Peek()}");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }





            /*     Hashtable → it is used to store data in the form of key-value pair
                   Internally uses hash algorithm , so might be possible that output is different
                   We can not insert, sort the hashtable

                   We can add, remove

                   We need to use built in struct type called DictionaryEntry → Key & value as property */



            Hashtable hashtable = new Hashtable();
            hashtable.Add(91, "IND");
            hashtable.Add(65, "AUS");
            hashtable.Add(1, "USA");
            hashtable.Add(2, "UK");
            hashtable.Add(4.5, "Test");
            hashtable.Add("Test2", 67.77);

            hashtable.Remove("Test2");

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"{item.Key} --> {item.Value}");
            }





        /*    SortedList → sorted list stores data in to form of key-value
              It is same as hashtable, but sorted list will sort the data based on key then stored.   */


                SortedList sortedList = new SortedList();
                sortedList.Add(91, "IND");
                sortedList.Add(65, "AUS");
                sortedList.Add(1, "USA");
                sortedList.Add(2, "UK");

                //sortedList.Remove(2);
                sortedList.Add(20, "Test");
                Console.WriteLine("Total elements " + sortedList.Count);
                foreach (DictionaryEntry item in sortedList)
                {
                    Console.WriteLine(item.Key + "  " + item.Value);
                }





            /*    Why collections ?
                 When we want to manage the objects or elements at run time. We can use collections
                 Resize the collections at run time
                 By using collection we can manage different elements
                 We can manage object or objects at run time.
                 Collections can grow & shrink memory at run time


                 Non - Generic collections
                 When we want to process different type of elements in to a single collection
                 Dissimilar type of data can be manage using non generic collections


             */




            
         





        }

    }
}
