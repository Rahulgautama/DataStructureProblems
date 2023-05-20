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

        public void DeleteFirst()
        {
            Node secondNode = head.next;
            head = secondNode;
        }
        public bool Search(int data)
        {
            Node current = head; 
            while (current != null)
            {
                if (current.data == data)
                    return true; 
                current = current.next;
            }
            return false; 
        }

        public void DeleteLast()
        {            
            Node second_last = head;
            while (second_last.next.next != null)
                second_last = second_last.next;
            
            second_last.next = null;
        }
        public void Delete(int data)
        {
            Node previousNode = head;
            Node current = head.next;
            while (current.data!=data)
            {
                previousNode = current;
                current = current.next;
            }
            previousNode.next = current.next;
        }
        public void SortedInsert(Node newNode)
        {
             
            if (this.head == null)
            {
                this.head = newNode;
                return;
            }

            Node prev = null;
            Node current = this.head;
            while (current != null && current.data < newNode.data)
            {
                prev = current;
                current = current.next;
            }

            if (prev == null)
            {
                newNode.next = this.head;
                this.head = newNode;
            }
            else
            {
                newNode.next = current;
                prev.next = newNode;
            }
        }
        public Node NewNode(int data)
        {
            Node x = new Node(data);
            return x;
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
