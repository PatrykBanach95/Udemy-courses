using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stos
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);


            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.Push("word");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.ReadLine();


        }
    }
}
