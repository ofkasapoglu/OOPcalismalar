using System;
using System.Xml.Schema;

namespace OOP.AbstractClassAndMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] {1210,1212,2123,1232,4356};
            var minheap = new MinHeap();
            var maxheap = new MaxHeap();
            foreach (var item in arr)
            {
                minheap.Insert(item);
                maxheap.Insert(item);
            }

            Console.WriteLine(minheap.Extract());//1 dönmesi beklenir.
            Console.WriteLine(maxheap.Extract());//5 dönmesi beklenir.
            Console.ReadKey();
        }

        

    }
}
