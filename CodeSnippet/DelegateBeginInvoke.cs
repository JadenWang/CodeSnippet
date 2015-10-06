
using System;
using System.Collections.Generic;


namespace Exmaple
{

    public class ExampleClass
    {

        public delegate void DelegateGreeting(string address);

        static void Main()
        {
            DelegateGreeting del = x => { Console.WriteLine("Welcome {0} to {1}", "Arab", x); System.Threading.Thread.Sleep(2000); };

            IAsyncResult AsycCall = del.BeginInvoke("California", null, null );
            del.EndInvoke(AsycCall);
            Console.WriteLine("Asyc call finished");
        }
    }

}





