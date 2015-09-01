using System; 
using DoublyLinkedList;

namespace LinkedListConsole
{
    class Program
    {
        static void Main()
        {

            var list = new LinkedList<string>();

            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");

            
            list.RemoveAt(3);

             list.Traverse(Console.WriteLine);

            //Console.WriteLine();

            //list.Traverse(Console.WriteLine,true);

            //Console.WriteLine();

            Console.WriteLine("Hit any key...");
            Console.ReadLine();
        }
    }
}
