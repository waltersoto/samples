using System;

namespace LinkedList
{
    public class Node<T>
    {
        public T Data { set; get; }
        public Node<T> Next { set; get; } 
    }

    public class LinkedList<T>
    {

        private Node<T> root;
        private Node<T> current;

        public void Add(T data)
        {
            var node = new Node<T>
            {
                Data = data
            };

            if (root == null)
            {
                root = node;
            }
            else
            { 
                current.Next = node; 
            }
            current = node;
        }

        public void Traverse(Action<T> callback)
        {
            Node<T> selected = root;
            while (selected != null)
            {
                if (callback != null)
                {
                    callback(selected.Data);
                }
                selected = selected.Next;
            }
        }



    }
}
