
using System;
using System.Collections.Generic;


namespace Exmaple
{

    public class ExampleClass
    {

        public delegate void DelegateGreeting(string address);

        static void Main()
        {
            DelegateGreeting del = x =>  Console.WriteLine("Welcome {0} to {1}", "Arab", x); 
            del += x => Console.WriteLine("Welcome {0} to {1}", "Bob", x);

            //del.Invoke("California");
            del("New York");

        }
    }

}





