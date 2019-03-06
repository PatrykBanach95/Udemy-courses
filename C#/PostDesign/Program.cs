using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postdesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The program creates a post and gives you the opportunity to vote for it, and to display the current number of votes");
            Console.WriteLine("Title of the post: ");
            string title = Console.ReadLine();
            Console.WriteLine("Describe the problem: ");
            string describe = Console.ReadLine();

            Post post = new Post(title, describe, DateTime.Now);
            int choice;
            
            do
            {
                Console.Write("Choose what you want to do with the post:\n1 - give plus\n2 - give minus\n3 - display the current rating of the post\n0 - Close the program\n");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: post.upVote(); break;
                    case 2: post.downVote(); break;
                    case 3: Console.WriteLine(post.VoteNumber()); break;                    
                }
            } while (choice != 0);
            
        }
    }
}
