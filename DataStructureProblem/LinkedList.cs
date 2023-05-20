using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblem
{
    public class LinkedList
    {
        public Node head;

       public void Append(int new_data)
        {            
            Node new_node = new Node(new_data);
            if (head == null)
            {
                head = new_node;
                return;
            }
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            Node lastNode = temp;
            lastNode.next = new_node;
        }
        public void Add(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Inserted into Linked List ", node.data);
        }

        public void AddAfter(int data,int where)
        {
            Node node = new Node(data);

            Node temp = head;
            while (temp.data!=where)
            {
                temp = temp.next;
            }
            node.next = temp.next;
            temp.next = node;
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
