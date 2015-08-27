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
            Size++;
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


        public T GetAt(int index)
        {
            T result = default(T);
            var count = 0;
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

        public void RemoveAt(int index)
        {
            if (index == 0)
            {
                root = root.Next;
                return;
            }

            var count = 0;
            Node<T> selected = root;
            Node<T> last = null;
            while (selected != null)
            {
                
                
                if (count == index)
                {
                    if (last != null)
                    {
                        last.Next = selected.Next;
                    }
                    
                    return; 
                }
                 
                last = selected;
                selected = selected.Next;
              
                count++;
                
            }
        }

        public int Size { set; get; }

    }

}
