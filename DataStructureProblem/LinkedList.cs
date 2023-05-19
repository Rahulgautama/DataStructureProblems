﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblem
{
    public class LinkedList
    {
        public Node head;

        public Node GetLastNode(LinkedList linkedList)
        {
            Node temp = linkedList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public void Append(LinkedList linkedList, int new_data)
        {
            Node new_node = new Node(new_data);
            if (linkedList.head == null)
            {
                linkedList.head = new_node;
                return;
            }
            Node lastNode = GetLastNode(linkedList);
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
