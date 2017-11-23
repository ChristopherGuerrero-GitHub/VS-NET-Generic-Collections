using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
           
            /* The solution to better performance and SAFETY data types is by using the GENERIC COLLECTION.
             * When you instantiate/create an Generic collection object you must replace the T with the data type
             * Therefore no need to add more code to cast or wonder what kind of data types are contained
             * in the collection when reading/outputting the data.
             */

            //There are several types of COLLECTIONS: ie. Stack, ArrayList, Queue.

            //NON-GENERIC COLLECTION SEE BELOW NOTE YOU CAN SEE THERE IS NO DATA TYPE SPECIFIC:
            
            //ArrayList arrList = new ArrayList();
            //Stack myStack = new Stack();
            //Queue myQueue = new Queue();
            //SortedList srtList = new SortedList();

            /********************************************************************************************/
            //GENERIC COLLECTION SEE BELOW SAME AS NON-GENERIC COLLECTION EXCEPT SPECIFY THE DATA TYPE.
            /********************************************************************************************/

           
            /******************************************************************/
            //Working with a Generic List collection of string data type 
            /******************************************************************/

            List<string> stringList = new List<string>();
            stringList.Add("One string");
            stringList.Add("Two string");
            stringList.Add("Three string");

            Console.WriteLine("The total count in the List of type string is: " + stringList.Count);

            foreach(string s in stringList)
            {
                Console.WriteLine("Printing out List of type string: " + s);
            }

            
            stringList.Clear();    //This one line of code Clear method will delete the entire List. No need for loop
            Console.WriteLine("Clearing out List of type string.");
          

            //stringList.RemoveAt(1);    //This line of code is good if you want to remove at a certain index

            Console.WriteLine("The total count in the List of type string is: " + stringList.Count);

            /******************************************************************/
            //Working with a Generic Stack collection of integer data type
            /******************************************************************/

            Stack<int> intStack = new Stack<int>();
            intStack.Push(23);
            intStack.Push(88);
            intStack.Push(77);

            Console.WriteLine("The total count on the Stack of integer type is: " + intStack.Count);

            foreach (int i in intStack)
            {
                Console.WriteLine("Printing out Stack of type integer: " + i);
            }

            while(intStack.Count != 0)
            {
                intStack.Pop();
                Console.WriteLine("Popping from stack. ");
            }
            
            Console.WriteLine("The total count on the Stack of integer type is: " + intStack.Count);

            /******************************************************************/
            //Working with a Generic Queue collection of char data type
            /******************************************************************/

            Queue<char> charQueue = new Queue<char>();

            charQueue.Enqueue('A');
            charQueue.Enqueue('C');
            charQueue.Enqueue('E');

            Console.WriteLine("The total count in the Queue of data type char is:" + charQueue.Count);

            foreach(char a in charQueue)
            {
                Console.WriteLine("Printing out the Queue of char data type is: " + a);
            }

            while(charQueue.Count != 0)
            {
                charQueue.Dequeue();
                Console.WriteLine("Dequeueing the Queue. ");
            }

            Console.WriteLine("The total count in the Queue of data type char is:" + charQueue.Count);

            /******************************************************************/
            //Working with a Generic SortedList collection of integer data type
            /******************************************************************/

            SortedList<int,int> strList = new SortedList<int, int>();
            strList.Add(1,23);
            strList.Add(2,44);
            strList.Add(3,888);
            strList.Add(4,444);

            Console.WriteLine("The total count for the SortedList of integer data type: " + strList.Count);

                      
            foreach(KeyValuePair<int,int> i in strList)
            {
                Console.WriteLine("Printing out the SortedList of integer data type: " + "Index is: " +
                    i.Key + " the value is: " + i.Value);

            }


            
        }
    }
}
 