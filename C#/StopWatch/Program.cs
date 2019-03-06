using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{

    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            int choice;
            do
            {
                Console.Write("Choose operation :\n 1 - Start the measurement\n 2 - Finish the measurement\n 3 - Result of measurement\n 0 - Close the program\n");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) 
                {

                    case 1:
                        stopWatch.Start();
                        break;
                    case 2:
                        stopWatch.Stop();
                        break;
                    case 3:
                        Console.WriteLine("The duration of the measurement is : " + stopWatch.Duration());
                        break;

                }
                if(choice==0 || choice ==1 || choice ==2 || choice ==3)
                {}
                else
                {
                    Console.WriteLine("The wrong choice was made!");
                }

            } while (choice != 0);





        }
    }


}

