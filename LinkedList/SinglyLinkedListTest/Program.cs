using System; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace SinglyLinkedListTest
{
    class Program
    {
        static void Main()
        {

            var list = new LinkedList<string>();

            list.Add("A");
            list.Add("B");
            list.Add("C");
           
            list.RemoveAt(1);

            list.Traverse(Console.WriteLine);

            

          
            

            Console.WriteLine("Hit any key...");
            Console.ReadLine();
        }
    }
}
