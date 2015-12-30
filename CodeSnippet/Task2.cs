using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippet
{
    class Task2
    {
        public static void Main()
        {
            Task<int> task1 = new Task<int>(() => { return Sum(100); });
            task1.Start();
            //task1.Wait();
            Console.WriteLine(task1.Result); // Result will automatically call wait

            var task2 = Task.Factory.StartNew(() => Console.WriteLine("create and start new task by startnew;"));
            var task3 = 
                Task.Run(
                     () => Console.WriteLine("create and start new task by run")    
                    );
            Task.WaitAll(task1, task2, task3);
        }

        private static int Sum(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++ )
            {
                sum += i;
            }
            return sum;
        }
    }
}
