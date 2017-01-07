using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOCSCS_Master
{
    class Chap16_LinearDataStructures
    {
        //Write a program that reads from the console a sequence of positive integer numbers.
        //The sequence ends when empty line is entered. Calculate and print the sum and
        //the average of the sequence. Keep the sequence in List<int>.
        public static class ExOneTest
        {
            public static void RunExOneTest()
            {
                Console.WriteLine("Enter positive integers, when finished press enter wityhout entering anything");

                List<int> listOints = new List<int>();

                GetInputs(listOints);
                GetSumAndAvg(listOints);
            }

            public static void GetInputs(List<int> ints)
            {
                bool cont = true;
                while (cont)
                {
                    string input = Console.ReadLine();
                    if (input == "")
                    {
                        cont = false;
                    }
                    int number;
                    Int32.TryParse(input, out number);

                    ints.Add(number);
                }
            }

            public static void GetSumAndAvg(List<int> ints)
            {
                int sum = 0;
                int avg;
                foreach (var integer in ints)
                {
                    sum += integer;
                }
                avg = sum / ints.Count;

                Console.WriteLine("Sum of entered integers is: {0}", sum);
                Console.WriteLine("Avg of entered integers is: {0}", avg);
            }

        }

        //Write a program, which reads from the console N integers and prints
        //them in reversed order. Use the Stack<int> class.
        public static class ExTwoTest
        {
            public static void RunExTwoTest()
            {
                Console.WriteLine("Enter integers, when finished press enter wityhout entering anything");
                Console.WriteLine("The app should read back the integers in reverse order");

                Stack<int> StackOints = new Stack<int>();

                GetInputs(StackOints);
                PrintStack(StackOints);
            }


            public static void GetInputs(Stack<int> ints)
            {
                bool cont = true;
                while (cont)
                {
                    string input = Console.ReadLine();
                    if (input == "")
                    {
                        cont = false;
                    }
                    int number;
                    Int32.TryParse(input, out number);

                    ints.Push(number);
                }
            }

            public static void PrintStack(Stack<int> myStack)
            {
                foreach (var ints in myStack)
                {
                    Console.WriteLine(ints);
                }
            }

        }

        public class ExThree
        {
            //Write a program that reads from the console a sequence of positive
            //integer numbers.The sequence ends when an empty line is entered.Print
            //the sequence sorted in ascending order.
            public static void RunExThreeTest()
            {
                List<int> listOints = new List<int>();

                Console.WriteLine("Please enter some ints. To end submit blank");
                ReadInts(listOints);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("SORTING:");
                listOints.Reverse();
                listOints.Sort();
                PrintList(listOints);

            }

            public static void ReadInts(List<int> intList)
            {
                bool loop = true;
                while (loop)
                {
                    string s = Console.ReadLine();
                    if (s == "")
                    {
                        loop = false;
                    }
                    int num;
                    Int32.TryParse(s, out num);
                    intList.Add(num);
                }
                //intList.RemoveAt(0);
            }

            public static void PrintList(List<int> List)
            {
                foreach (var num in List)
                {
                    if (num != 0)
                    {
                        Console.WriteLine(num);
                    }
                }
            }

        }


        //Write a method that finds the longest subsequence of equal numbers in a given
        //List<int> and returns the result as new List<int>. Write a program to test
        //whether the method works correctly.

        //Use List<int>. Scan the list with a for-loop (1 … n-1) while keeping two variables: start and
        //length. Initially start=0, length=1. At each loop iteration if the number at the left is the
        //same as the current number, increase length. Otherwise restart from the current cell
        //(start=current, length=1). Remember the current start and length every time when the current
        //length becomes better than the current maximal length. Finally create a new list and copy
        //the found sequence to it.
        public static class ExFour //not working correctly
        {
            public static void RunExFour()
            {
                List<int> intList = new List<int>();
                int start = 0;
                int length = 1;
                int highestLength = 1;
                int hightestLenghtStart = 1;

                ExThree.ReadInts(intList);

                for (int i = 0; i < intList.Count; i++)
                {
                    if (intList.Count < i)
                    {
                        if (intList[i] == intList[i + 1])
                        {
                            length++;

                            if (length > highestLength)
                            {
                                highestLength = length;
                                hightestLenghtStart = start;
                            }
                        }
                        else
                        {
                            start = intList[i];
                            length = 1;
                        }
                    }
                }

                List<int> newList = new List<int>();

                int count = 0;
                for (int i = hightestLenghtStart; i < highestLength; i++)
                {
                    newList[count] = intList[i];
                }

                ExThree.PrintList(newList);
            }
        }

        //Write a program, which removes all negative numbers from a sequence.
        //Example: array = {19, -10, 12, -6, -3, 34, -2, 5}  {19, 12, 34, 5}
        public static class ExFive
        {
            public static void RunExFive()
            {
                List<int> intList = new List<int>();

                ExThree.ReadInts(intList);
                RemoveNegs(intList);
                ExThree.PrintList(intList);

            }

            public static void RemoveNegs(List<int> intList)
            {
                for (int i = 0; i < intList.Count; i++)
                {
                    if (intList[i] < 0)
                    {
                        intList.RemoveAt(i);
                        i = i - 1;
                    }
                }
            }
        }

        //Write a program that removes from a given sequence all numbers that appear an odd count of times.
        //Example: array = {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2}  {5, 3, 3, 5}
        public static class ExSix
        {
            public static void RunExSix() //used slow solution
            {
                List<int> intList = new List<int>();
                List<int> intListFin = new List<int>();

                Console.WriteLine("Please enter some digits, when finsihed submit blank");
                Console.WriteLine("All numbers that appear an odd number of times will be removed.");

                ExThree.ReadInts(intList);

                int count = 0;
                foreach (var num in intList)
                {
                    foreach (var numTwo in intList)
                    {
                        if (num == numTwo)
                        {
                            count++;
                        }
                    }
                    if (count % 2 != 0)
                    {
                        if (!intListFin.Contains(num))
                        {
                            intListFin.Add(num);
                        }
                    }
                    count = 0;
                }
                ExThree.PrintList(intListFin);
            }

            //* Fast solution: use a hash-table (Dictionary<int, int>). With a single
            //scan calculate count[p] (the number of occurrences of p in the input
            //sequence) for each number p from the input sequence. With another single
            //scan pass though all numbers p and append p to the result only when
            //count[p] is even. Read about hash tables from the chapter “Dictionaries,
            //Hash-Tables and Sets”.
            public static void RunExSixFast()
            {
                Dictionary<int, int> myDictionary = new Dictionary<int, int>();

                ReadIntsToDictionary(myDictionary);

                //myDictionary.count
            }

            public static void ReadIntsToDictionary(Dictionary<int, int> myDiction)
            {
                bool loop = true;
                int key = 0; //key is just a loop count
                while (loop)
                {
                    string s = Console.ReadLine();
                    if (s == "")
                    {
                        loop = false;
                    }
                    int num;
                    Int32.TryParse(s, out num);
                    key++;
                    myDiction.Add(key, num);
                }
            }

        }


        //Write a program that finds in a given array of integers (in the range [0…1000]) how many times each of them occurs.
        //Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
        //2 -> 2 times
        //3 -> 4 times
        //4 -> 3 times
        public static class ExSeven
        {
            public static void RunExSeven()
            {
                List<int> intList = new List<int>();

                //Add some ints:
                for (int i = 0; i < 10; i++)
                {
                    intList.Add(i * (i - 5));
                    intList.Add(i * (i - 4));
                    intList.Add(i * (i - 6));
                }

                ExThree.PrintList(intList);

                Dictionary<int, int> myDiction = new Dictionary<int, int>();

                AddIntOccurancesInListToDictionary(intList, myDiction);

                PrintIntDictionary(myDiction);

                //ExThree.ReadInts(intList);


            }

            public static void AddIntOccurancesInListToDictionary(List<int> myList, Dictionary<int, int> myDictionary)
            {
                foreach (var numToCheckFor in myList)
                {
                    int count = 0;
                    foreach (var num in myList)
                    {
                        if (num == numToCheckFor)
                        {
                            count++;
                        }
                    }
                    if (!myDictionary.ContainsKey(numToCheckFor))
                    {
                        myDictionary.Add(numToCheckFor, count);
                    }
                    count = 1;
                }
                if (myDictionary.ContainsKey(0))
                {
                    myDictionary.Remove(0);
                }
            }

            public static void PrintIntDictionary(Dictionary<int, int> myDiction)
            {
                foreach (var keyvaluepair in myDiction)
                {
                    Console.WriteLine(keyvaluepair.ToString());
                }
            }
        }


        //The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times. Write a program that finds the majorant of given array and prints it. If it does not exist, print "The majorant does not exist!".
        //Example: {2, 2, 3, 3, 2, 3, 4, 3, 3} -> 3
        public static class ExEight
        {
            public static void RunExEight()
            {
                Console.WriteLine("The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.");

                List<int> intList = new List<int>();
                Dictionary<int, int> myDiction = new Dictionary<int, int>();
                PopulateList(intList);

                ExThree.PrintList(intList);

                ExSeven.AddIntOccurancesInListToDictionary(intList, myDiction);

                bool foundMajorant = false;
                foreach (var num in myDiction)
                {
                    if (num.Key / 2 + 1 <= num.Value)
                    {
                        Console.WriteLine("Majorant: {0}", num.Key.ToString());
                        foundMajorant = true;
                    }
                }
                if (!foundMajorant)
                {
                    Console.WriteLine("The majorant does not exist!");
                }

            }

            public static void PopulateList(List<int> intList)
            {
                intList.Add(9);
                for (int i = 0; i < 5; i++)
                {
                    intList.Add(1);
                    intList.Add(5);
                }
                for (int i = 0; i < 3; i++)
                {
                    intList.Add(2);
                    intList.Add(5);
                }
                for (int i = 0; i < 2; i++)
                {
                    intList.Add(3);
                }
                for (int i = 0; i < 7; i++)
                {
                    intList.Add(4);
                }
            }
        }


        //We are given the following sequence:
        //S1 = N;
        //S2 = S1 + 1;
        //S3 = 2*S1 + 1;
        //S4 = S1 + 2;
        //S5 = S2 + 1;
        //S6 = 2*S2 + 1;
        //S7 = S2 + 2;

        //S7 = S3 + 1;
        //S8 = 2*S3 +1;
        //S9 = S3 + 2;
        //S10 = S4 + 1;

        //Using the Queue<T> class, write a program which by given N prints on the console the first 50 elements of the sequence.
        //Example: N=2 -> 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, …

        //GUIDELINES:
        //Use queue. In the beginning add N to the queue. After that take the current
        //element M and add to the queue M+1, then 2*M + 1 and then M+2. Repeat the same
        //for the next element in a loop. At each step in the loop print M and if at
        //certain point the queue size reaches 50, break the loop and finish the calculation.
        public static class Nine
        {
            public static void RunNine()
            {
                Queue<int> myQueue = new Queue<int>();
                Queue<int> finalQueue = new Queue<int>();

                Console.WriteLine("Please enter an int to use as the starting point for N");

                int n = ReadInt();
                int currentElement = n;

                Console.WriteLine("------------------------------------------------------");

                myQueue.Enqueue(n);
                finalQueue.Enqueue(n);

                foreach (var num in myQueue)
                {
                    finalQueue.Enqueue(num + 1);
                    finalQueue.Enqueue(2 * num + 1);
                    finalQueue.Enqueue(num + 2);
                }


                //for (int i = 0; i < 50; i++)
                //{

                //    myQueue.Enqueue(currentElement + 1);
                //    myQueue.Enqueue(currentElement 
                //}
                PrintQueue(finalQueue);

            }

            public static int ReadInt()
            {
                int n = 0;
                while (n == 0)
                {
                    string s = Console.ReadLine();
                    Int32.TryParse(s, out n);
                }
                return n;
            }

            public static void PrintQueue(Queue<int> myQueue)
            {
                foreach (var num in myQueue)
                {
                    Console.WriteLine(num);
                }
            }
        }

        //QUESTIONS:
        //We are given N and M and the following operations:
        //N = N+1
        //N = N+2
        //N = N*2
        //Write a program, which finds the shortest subsequence from the operations, which starts with N and ends with M. Use queue.
        //Example: N = 5, M = 16
        //Subsequence: 5 -> 7 -> 8 -> 16

        //GUIDELINES:
        //Use the data structure queue. Firstly, add to the queue N. Repeat the
        //following in a loop until M is reached: remove a number X from the queue
        //and add 3 new elements: X * 2, X + 2 and X + 1. Do not add numbers
        //greater than M. As optimization of the solution, try to avoid repeating
        //numbers in the queue.
        public static class Ten
        {
            public static void RunTen()
            {

                Queue<int> myQueue = new Queue<int>();

                Console.WriteLine("Enter an int to use as n");
                int n = Nine.ReadInt();

                Console.WriteLine("Enter an int to use as max");
                int M = Nine.ReadInt(); //max numbers

                Console.WriteLine("--------------------------");

                myQueue.Enqueue(n);

                for (int i = 0; i < M; i++)
                {
                    int x = myQueue.Dequeue();
                    if (x * 2 < M && myQueue.Count < M)
                    {
                        myQueue.Enqueue(x * 2);
                    }
                    if (x + 2 < M && myQueue.Count < M)
                    {
                        myQueue.Enqueue(x + 2);
                    }
                    if (x + 1 < M && myQueue.Count < M)
                    {
                        myQueue.Enqueue(x + 1);
                    }
                }

                Nine.PrintQueue(myQueue);

            }
        }

        //Implement the data structure dynamic doubly linked list (DoublyLinkedList<T>) – list, the
        //elements of which have pointers both to the next and the previous elements.
        //Implement the operations for adding, removing and searching for an element, as
        //well as inserting an element at a given index, retrieving an element by a given
        //index and a method, which returns an array with the elements of the list.
        public static class Eleven
        {
            public static void RunEleven()
        {
            DoublyLinkedList doubLinkedList = new DoublyLinkedList();

            doubLinkedList.Add(5);
            doubLinkedList.Add(6);
            doubLinkedList.Add(7);
            doubLinkedList.Add(8);

            
        }

        }

        class DoublyLinkedList
        {
            private class DoublyLinkedListNode
            {
                private object element;
                private DoublyLinkedListNode next;
                private DoublyLinkedListNode previous;

                public DoublyLinkedListNode(object element)
                {
                    this.element = element;
                    this.next = null;
                    this.previous = null;
                }

                public DoublyLinkedListNode(object element, DoublyLinkedListNode prevNode)
                {
                    this.element = element;
                    this.previous = prevNode;
                    prevNode.next = this;
                }

                public object Element
                {
                    get { return this.element; }
                    set { this.element = value; }
                }

                public DoublyLinkedListNode Next
                {
                    get { return this.next; }
                    set { this.next = value; }
                }

                public DoublyLinkedListNode Previous
                {
                    get { return this.previous; }
                    set { this.previous = value; }
                }
            }

            private DoublyLinkedListNode head;
            private DoublyLinkedListNode tail;
            private int count;

            public DoublyLinkedList()
            {
                this.head = null;
                this.tail = null;
                this.count = 0;
            }

            public int Count
            {
                get { return this.count; }
            }

            public object this[int index]
            {
                get
                {
                    if (index >= count || index < 0)
                    {
                        throw new ArgumentOutOfRangeException("Out of range!");
                    }
                    DoublyLinkedListNode currentNode = this.head;
                    for (int i = 0; i < index; i++)
                    {
                        currentNode = currentNode.Next;
                    }
                    return currentNode.Element;
                }
                set
                {
                    if (index >= count || index < 0)
                    {
                        throw new ArgumentOutOfRangeException("Out of range!");
                    }
                    DoublyLinkedListNode currentNode = this.head;
                    for (int i = 0; i < index; i++)
                    {
                        currentNode = currentNode.Next;
                    }
                    currentNode.Element = value;
                }
            }
            public void Add(object item)
            {
                if (this.head == null)
                {
                    this.head = new DoublyLinkedListNode(item);
                    this.tail = this.head;
                }
                else
                {
                    DoublyLinkedListNode newItem = new DoublyLinkedListNode(item, tail);
                    this.tail = newItem;
                }
                count++;
            }

            public void Insert(object item, int index)
            {
                count++;
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Out of range!");
                }
                DoublyLinkedListNode newItem = new DoublyLinkedListNode(item);
                int currentIndex = 0;
                DoublyLinkedListNode currentItem = this.head;
                DoublyLinkedListNode prevItem = null;
                while (currentIndex < index)
                {
                    prevItem = currentItem;
                    currentItem = currentItem.Next;
                    currentIndex++;
                }
                if (index == 0)
                {
                    newItem.Previous = this.head.Previous;
                    newItem.Next = this.head;
                    this.head.Previous = newItem;
                    this.head = newItem;
                }
                else if (index == count - 1)
                {
                    newItem.Previous = this.tail;
                    this.tail.Next = newItem;
                    newItem = this.tail;
                }
                else
                {
                    newItem.Next = prevItem.Next;
                    prevItem.Next = newItem;
                    newItem.Previous = currentItem.Previous;
                    currentItem.Previous = newItem;
                }
            }
            public void Remove(object item)
            {
                int currentIndex = 0;
                DoublyLinkedListNode currentItem = this.head;
                DoublyLinkedListNode prevItem = null;
                while (currentItem != null)
                {
                    if ((currentItem.Element != null &&
                        currentItem.Element.Equals(item)) ||
                        (currentItem.Element == null) && (item == null))
                    {
                        break;
                    }
                    prevItem = currentItem;
                    currentItem = currentItem.Next;
                    currentIndex++;
                }
                if (currentItem != null)
                {
                    count--;
                    if (count == 0)
                    {
                        this.head = null;
                    }
                    else if (prevItem == null)
                    {
                        this.head = currentItem.Next;
                        this.head.Previous = null;
                    }
                    else if (currentItem == tail)
                    {
                        currentItem.Previous.Next = null;
                        this.tail = currentItem.Previous;
                    }
                    else
                    {
                        currentItem.Previous.Next = currentItem.Next;
                        currentItem.Next.Previous = currentItem.Previous;
                    }
                }
            }
            public void RemoveAt(int index)
            {
                if (index >= this.count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Out of range!");
                }

                int currentIndex = 0;
                DoublyLinkedListNode currentItem = this.head;
                DoublyLinkedListNode prevItem = null;
                while (currentIndex < index)
                {
                    prevItem = currentItem;
                    currentItem = currentItem.Next;
                    currentIndex++;
                }
                if (this.count == 0)
                {
                    this.head = null;
                }
                else if (prevItem == null)
                {
                    this.head = currentItem.Next;
                    this.head.Previous = null;
                }
                else if (index == count - 1)
                {
                    prevItem.Next = currentItem.Next;
                    tail = prevItem;
                    currentItem = null;
                }
                else
                {
                    prevItem.Next = currentItem.Next;
                    currentItem.Next.Previous = prevItem;
                }
                count--;
            }
            public int indexOf(object item)
            {
                int index = 0;
                DoublyLinkedListNode currentItem = this.head;
                while (currentItem != null)
                {
                    if (((currentItem.Element != null) && (item == currentItem.Element)) ||
                        ((currentItem.Element == null) && (item == null)))
                    {
                        return index;
                    }
                    index++;
                    currentItem = currentItem.Next;
                }
                return -1;
            }
            public bool Contains(object element)
            {
                int index = indexOf(element);
                bool contains = (index != -1);
                return contains;
            }

            public void Clear()
            {
                this.head = null;
                this.tail = null;
                this.count = 0;
            }
        }


        //Create a DynamicStack<T> class to implement dynamically a stack (like a linked list, where each
        //element knows its previous element and the stack knows its last element). Add methods for all
        //commonly used operations like Push(), Pop(), Peek(), Clear() and Count.

        //Use singly linked list (similar to the list from the previous task, but only with a field
        //Previous, without a field Next).
        public static class Twelve
        {
            public static void RunTwelve()
            {
                //DynamicStack<int> myDynamicStack = new DynamicStack<int>();

                //myDynamicStack.Push(1);
                //myDynamicStack.Push(2);
                //myDynamicStack.Push(3);
                //myDynamicStack.Push(4);

                //Console.WriteLine(myDynamicStack.Peek());

                //myDynamicStack.Pop();

                //Console.WriteLine("STACK COUNT: {0}", myDynamicStack.Count());

                //myDynamicStack.Clear();


            }
        }

        //public class DynamicStack<int>
        //{


        //    //LIFO - last in first out

        //    //pull top item from list?
        //    public int Pop()
        //    {
        //        return 1;
        //    }

        //    //add to bottom of list
        //    public void Push(int i)
        //    {

        //    }

        //    public int Peek()
        //    {

        //        return 1;
        //    }

        //    public void Clear()
        //    {

        //    }

        //    public int Count()
        //    {
        //        return 1;
        //    }

        //    public static void PrintStack()
        //    {
        //        //foreach (var item in collection)
        //        //{
        //        //    Console.WriteLine(item.ToString());
        //        //}
        //    }

        //    public override string ToString()
        //    {
        //        return base.ToString();
        //    }

        //}


        public static class Thirteen
        {//13. Just modify your implementation of doubly-linked list to enable adding and removing from both its head and tail. Another solution is to use circular buffer (see http://en.wikipedia.org/wiki/Circular_buffer). When the buffer is full, create a new buffer of double size and move all existing elements to it.

            public static void RunThirteen()
            {
                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine();
            }
        }

        public static class Fourteen
        {//14. Use array. When you reach the last index, you need to add the next element at the beginning of the array. For the correct calculation of the indices use the remainder from the division with the array length. When you need to resize the array, implement it the same way like we implemented the resizing in the "Static List" section.

            public static void RunFourteen()
            {
                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine();
            }
        }

        public static class Fifteen
        {//15. Use the simple Bubble sort. We start with the leftmost element by checking whether it is smaller than the next one. If it is not, we swap their places. Then we compare with the next element and so on and so forth, until we reach a larger element or the end of the array. We return to the start of the array and repeat the same procedure many times until we reach a moment, when we have taken sequentially all elements and no one had to be moved.

            public static void RunFifteen()
            {
                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine();
            }
        }

        public static class Sixteen
        {//16. The algorithm is very easy: we start with an empty queue, in which we put the root directory (from which we start traversing). After that, until the queue is empty, we remove the current directory from the queue, print it on the console and add all its subdirectories to the queue. This way we are going to traverse the entire file system in breadth. If there are no cycles in the file system (as in Windows), the process will be finite.

            public static void RunSixteen()
            {
                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine();
            }
        }

        public static class Seventeen
        {//17. If in the solution of the previous problem we substitute the queue with a stack, we are going to get traversal in depth (DFS).

            public static void RunSeventeen()
            {
                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine();
            }
        }

        public static class Eighteen
        {//18. Use Breath-First Search (BFS) by starting from the position, marked with "*". Each unvisited adjacent to the current cell we fill with the current number + 1. We assume that the value at "*" is 0. After the queue is empty, we traverse the whole matrix and if in some of the cells we have 0, we fill it with "u".

            public static void RunEighteen()
            {
                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine();
            }
        }

    }
}
