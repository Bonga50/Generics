using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericLinkedList
{
    internal class LinkedListTester
    {
        public static void Main(string[] args)
        {
            GenericLinkedListRunner<string> ListObj = new GenericLinkedListRunner<string>();

            ListObj.AddToFirst("Data");
            ListObj.AddToLast("Meta");
            ListObj.AddToLast("Google");
            ListObj.AddToLast("Amazon");
            foreach (var item in ListObj)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
