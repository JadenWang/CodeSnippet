
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics;


namespace Exmaple
{

    public class ExampleClass
    {

        public static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 100000000; i++ )
            {
                NewMethod2();
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        private static void NewMethod()
        {
            int i = 10;
            object O = i;  // boxing to object (to heap)
        }

        private static void NewMethod2()
        {
            int i = 10;
            int j = i;  // boxing to object (to heap)
        }

    }

}





