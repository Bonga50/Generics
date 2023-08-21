using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericConstraints
{
    public class MyLinkedList<T> : IEnumerable where T : Student
    {

        //pubic class Classname<T> where : class
        //Constranints can not be from value types
        //Constraints can be from refence types.

      
        public class Node
        {

            public Node Next;
            public Node Prev;

            public T Value { get; set; }

            public Node() { }

            public Node(T value)
            {
                Value = value;
            }
        }

        private Node head;

        /// <summary>
        /// Mathod to add to the first element/ begining of the list.
        /// </summary>
        /// <param name="arg"></param>
        public void AddToFirst(T arg)
        {
            if (head == null)
            {
                head = new Node(arg);
            }
            else
            {

                Node newNode = new Node(arg);
                newNode.Next = head;
                newNode.Prev = null;
                head.Prev = newNode;
                head = newNode;
            }
        }
        /// <summary>
        /// Method to add to the end of the list
        /// </summary>
        /// <param name="arg"></param>
        public void AddToLast(T arg)
        {
            Node newNode = new Node(arg);
            if (head is null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }


        }

        public void Display()
        {
            Node current = head;

            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
