using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DoublyLinkedList
{
    public class Node<T>
    {
        public T Data { set; get; }
        public Node<T> Next { set; get; }
        public Node<T> Previous { set; get; }
    }

    public class LinkedList<T>
    {

        private Node<T> head;
        private Node<T> tail;


        public void Add(T data)
        {
            var node = new Node<T>
            {
                Data = data
            };

            if (head == null)
            {
                head = node;
                tail = head;
            }
            else
            {
                node.Previous = tail;
                tail.Next = node;
                tail = tail.Next;
            }

        }

        public void RemoveAt(int index)
        {
            var count = 0;
            Node<T> current = head;
            while (current != null)
            {
                if (count == index)
                {
                    Node<T> next = current.Next;
                    Node<T> prev = current.Previous;

                    if (prev != null)
                    {
                        prev.Next = next;
                    }

                    if (next != null)
                    {
                        next.Previous = prev;
                    }
                }

                current =  current.Next;
                count++;
            }
        }

        public T GetAt(int index)
        {
            var count = 0;
            T result = default(T);
            Traverse(x =>
            {
                if (count == index)
                {
                    result = x;
                }
                count++;
            });
            return result;
        }

        public void Traverse(Action<T> callback)
        {
            Traverse(callback,false);
        }

        public void Traverse(Action<T> callback,bool backward)
        {
            Node<T> current = backward? tail: head;
            while (current != null)
            {
                callback(current.Data);
                current = backward ? current.Previous : current.Next;
            }
        }
         


    }
}
