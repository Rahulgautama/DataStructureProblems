using System;
using System.Collections.Generic;

namespace DataStructureProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            //linkedList.Add(56);
           // linkedList.Add(30);
            //linkedList.Add(70);

            //linkedList.Append(56);
            //linkedList.Append(30);
            //linkedList.Append(70);

            //linkedList.AddAfter(30,56);

            //linkedList.AddAfter(40, 30);

            //linkedList.Delete(40);
            Node new_node;

            new_node = linkedList.NewNode(12);
            linkedList.SortedInsert(new_node);
            new_node = linkedList.NewNode(25);
            linkedList.SortedInsert(new_node);
            new_node = linkedList.NewNode(13);
            linkedList.SortedInsert(new_node);
            //linkedList.DeleteFirst();
            //linkedList.DeleteLast();
            //Console.WriteLine(linkedList.Search(56));
            linkedList.Display();

        }
       
    }
}
