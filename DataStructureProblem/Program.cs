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

            linkedList.Append(56);
            //linkedList.Append(30);
            linkedList.Append(70);
           

            linkedList.AddAfter(30,56);

            linkedList.DeleteFirst();
            linkedList.Display();

        }
    }
}
