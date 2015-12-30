using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippet
{
    class Task1
    {
        public static void Main()
        {
            Task task1 = new Task(() => { Console.WriteLine("This is from task #1."); });
            Task task2 = new Task(() => PrintMessage(2));

            task1.Start();
            task2.Start();
            Console.ReadLine();
        }

        private static void PrintMessage(int task)
        {
            Console.WriteLine(string.Format("This is from task #{0}", task));
        }
    }
}
